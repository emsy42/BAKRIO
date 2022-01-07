Imports System.Xml

Public Class Form2
    Dim m_xmld As XmlDocument
    Dim m_nodelist As XmlNodeList
    Dim m_node As XmlNode

    Dim newBread As Boolean = False 'whether or not the user is creating a new entry or editing a pre-existing one
    Dim imageFile As String

    'reloads the xml file and updates the form display to account for any changes
    Private Sub xmlUpdate()
        m_xmld = New XmlDocument
        m_xmld.Load("bread_types.xml")
        m_nodelist = m_xmld.GetElementsByTagName("Bread")

        scrBread.Maximum = m_nodelist.Count + 8
        scrBread.Enabled = True
        newBread = False
        changeBread()
    End Sub

    Private Sub changeBread()
        Dim bread As XmlNode = m_nodelist(scrBread.Value)
        imageFile = bread.Item("BreadImg").InnerText
        picBread.Image = Image.FromFile(imageFile)
        txtBreadName.Text = bread.Item("BreadName").InnerText
        txtBreadDesc.Text = bread.Item("BreadDesc").InnerText
        m_node = bread
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = "PNG Image|*.png|JPG Image|*.jpg"

        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            'put image in picture box
            picBread.Image = Image.FromFile(dialog.FileName)
            imageFile = dialog.FileName
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        xmlUpdate()
    End Sub

    Private Sub scrBread_Scroll(sender As Object, e As ScrollEventArgs) Handles scrBread.Scroll
        changeBread()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If newBread = False Then
            If MsgBox("Are you sure you want to delete this bread? This CANNOT be undone!", DialogResult.OK, "BAKR.IO") = DialogResult.OK Then
                'having nothing to display causes problems, so this is how we prevent those problems.
                If scrBread.Value = 0 Then
                    MsgBox("Deletion failed: You cannot remove this bread!", Buttons:=0, "BAKR.IO")
                    Exit Sub
                End If
                m_xmld.DocumentElement.RemoveChild(m_node)
                m_xmld.Save("bread_types.xml")

                scrBread.Value -= 1

                xmlUpdate()
                MsgBox("Successfully deleted this bread.", Buttons:=0, "BAKR.IO")
            End If
        Else
            xmlUpdate()
            scrBread.Enabled = True
        End If

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        newBread = True
        scrBread.Enabled = False
        picBread.Image = Nothing
        txtBreadName.Text = Nothing
        txtBreadDesc.Text = Nothing
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'validates user input
        If txtBreadName.TextLength > 14 Then
            MsgBox("Input Error: Name Of Bread is too long.", Buttons:=0, "BAKR.IO")
            Exit Sub
        ElseIf txtBreadDesc.TextLength > 80 Then
            MsgBox("Input Error: Bread Description is too long.", Buttons:=0, "BAKR.IO")
            Exit Sub
        ElseIf txtBreadName.Text Is Nothing Then
            MsgBox("Input Error: Please enter a name for your bread.", Buttons:=0, "BAKR.IO")
            Exit Sub
        ElseIf txtBreadDesc.Text Is Nothing Then
            MsgBox("Input Error: Please enter a description for your bread.", Buttons:=0, "BAKR.IO")
            Exit Sub
        ElseIf picBread.Image Is Nothing Then
            MsgBox("Input Error: Please select an image for your bread.", Buttons:=0, "BAKR.IO")
            Exit Sub
        End If

        If newBread = True Then
            'creates a new xml element, adds it to the xml file amnd saves it
            Dim bread As XmlElement = m_xmld.CreateElement("Bread")

            Dim BreadName As XmlElement = m_xmld.CreateElement("BreadName")
            BreadName.InnerText = txtBreadName.Text

            Dim BreadDesc As XmlElement = m_xmld.CreateElement("BreadDesc")
            BreadDesc.InnerText = txtBreadDesc.Text

            Dim BreadImg As XmlElement = m_xmld.CreateElement("BreadImg")
            BreadImg.InnerText = imageFile

            bread.AppendChild(BreadName)
            bread.AppendChild(BreadDesc)
            bread.AppendChild(BreadImg)

            m_xmld.DocumentElement.AppendChild(bread)

            m_xmld.Save("bread_types.xml")

            MsgBox("Save successful.", Buttons:=0, "BAKR.IO")

            xmlUpdate()
        Else
            'updates and saves xml file
            m_node.Item("BreadName").InnerText = txtBreadName.Text
            m_node.Item("BreadDesc").InnerText = txtBreadDesc.Text
            m_node.Item("BreadImg").InnerText = imageFile

            m_xmld.Save("bread_types.xml")

            MsgBox("Save successful.", Buttons:=0, "BAKR.IO")
        End If
    End Sub
End Class