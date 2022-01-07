Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Random
Public Class Form1
    Dim breadInstances As New List(Of breadInstance)

    Public message As String
    Public laughed As Boolean = False
    Dim punCounter As Integer = -1
    Dim punArray(42) As String
    Dim secret1 As Boolean = True
    Dim secret2 As Boolean = True

    Dim breadCount As Integer = 0
    Dim mouse, baker, farm, factory As Integer

    'each object with this class stores data relating to one match detected in the supplied text file
    Public Class breadInstance
        Public breadName As String
        Public breadDesc As String
        Public breadImg As String
        Public sourceSentence As String
        Public sourcePos As Integer
        Public sentenceNum As Integer
    End Class

    'updates the information displayed on the form to the bread instance selected in the scroll bar
    Private Sub changeBread()
        Dim bread As breadInstance = breadInstances(scrBread.Value)
        picBread.Image = Image.FromFile(bread.breadImg)
        lblBreadName.Text = bread.breadName
        lblDesc.Text = bread.breadDesc
        lblSentence.Text = Str(bread.sentenceNum + 1)
        lblPos.Text = bread.sourcePos
        txtSentence.Text = bread.sourceSentence

        lblCurrent.Text = scrBread.Value + 1
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Dim textString As String
        Dim dialog As New OpenFileDialog
        dialog.Filter = "Text Document|*.txt"
        Dim fileName As String

        Dim breadIndex As Integer
        breadInstances.Clear()

        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            'read text file and split into sentences

            fileName = dialog.FileName

            textString = My.Computer.FileSystem.ReadAllText(fileName)

            textString = textString.Replace("? ", ". ")
            textString = textString.Replace("! ", ". ")

            Dim sentences() = textString.Split(". ")


            'reading bread_types.xml

            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode

            m_xmld = New XmlDocument
            m_xmld.Load("bread_types.xml")
            m_nodelist = m_xmld.GetElementsByTagName("Bread")

            'Bread Recognition: checks each sentence for each defined type of bread, recording each match in a list.
            For i As Integer = 0 To sentences.Length - 1
                For Each m_node In m_nodelist
                    breadIndex = InStr(sentences(i).ToLower(), m_node.Item("BreadName").InnerText.ToLower())
                    If breadIndex > 0 Then
                        Dim newBread As New breadInstance
                        newBread.breadName = m_node.Item("BreadName").InnerText
                        newBread.breadDesc = m_node.Item("BreadDesc").InnerText
                        newBread.breadImg = m_node.Item("BreadImg").InnerText
                        newBread.sourceSentence = sentences(i)
                        newBread.sentenceNum = i
                        newBread.sourcePos = breadIndex
                        breadInstances.Add(newBread)
                    End If
                Next
            Next

            If breadInstances.Count > 0 Then
                MsgBox("Found a total of" + Str(breadInstances.Count) + " instance(s) of bread.", Buttons:=0, "BAKR.IO")
                scrBread.Value = 0
                scrBread.Maximum = breadInstances.Count + 8
                lblCurrent.Text = 1
                lblTotal.Text = breadInstances.Count

                changeBread()

                scrBread.Enabled = True

                breadCount += breadInstances.Count
                lblBreadNum.Text = breadCount
            Else
                MsgBox("No bread was detected in this file. :(", Buttons:=0, "BAKR.IO")
                scrBread.Enabled = False
            End If


        End If
    End Sub

    Private Sub scrBread_Scroll(sender As Object, e As ScrollEventArgs) Handles scrBread.Scroll
        changeBread()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ShowDialog()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If breadCount >= 10 Then
            breadCount -= 10
            lblBreadNum.Text = breadCount
            mouse += 1
            lbl1.Text = mouse
        Else
            MsgBox("Not enough bread!", Buttons:=0, "BAKR.IO")
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If breadCount >= 100 Then
            breadCount -= 100
            lblBreadNum.Text = breadCount
            baker += 1
            lbl2.Text = baker
        Else
            MsgBox("Not enough bread!", Buttons:=0, "BAKR.IO")
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If breadCount >= 2000 Then
            breadCount -= 2000
            lblBreadNum.Text = breadCount
            farm += 1
            lbl3.Text = farm
        Else
            MsgBox("Not enough bread!", Buttons:=0, "BAKR.IO")
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If breadCount >= 30000 Then
            breadCount -= 30000
            lblBreadNum.Text = breadCount
            factory += 1
            lbl4.Text = factory
        Else
            MsgBox("Not enough bread!", Buttons:=0, "BAKR.IO")
        End If
    End Sub

    Private Sub btnPun_Click(sender As Object, e As EventArgs) Handles btnPun.Click
        'handles first click
        If punCounter = -1 Then
            MsgBox("WARNING: The majority of these puns are really bad. Proceed at your own risk.", Buttons:=0, "BAKR.IO")
            punCounter = 0
            Randomize()

            'read the puns from the text document and store them in an array
            Try
                Dim punString As String = My.Computer.FileSystem.ReadAllText("pun_machine_text.txt")
                punArray = punString.Split(",,")
            Catch ex As Exception
                MsgBox("The Pun Machine seems to be missing. (probably for the best)", Buttons:=0, "BAKR.IO")
                btnPun.Enabled = False
            End Try

            Exit Sub
        End If

        If secret1 And punCounter > 5 Then
            'secret ending 1
            If punCounter < 13 Then
                punCounter = 13
                btnPun.Text = "[0  v  0]"
            End If
            message = punArray(punCounter)
        ElseIf secret2 And punCounter > 5 Then
            'secret ending 2
            If punCounter < 30 Then
                punCounter = 30
                btnPun.Text = "[o  _  o]"
            End If
            message = punArray(punCounter)
        Else
            'random pun
            Dim index As Integer = Rnd() * 12
            message = punArray(index)
            btnPun.Text = "[0  -  0]"
        End If

        Form3.ShowDialog()

        If laughed = True Then
            secret2 = False
        Else
            secret1 = False
        End If

        'disables button at the ending
        If (punCounter = 42 And secret2) Or (punCounter = 29 And secret1) Then
            btnPun.Enabled = False
        Else
            punCounter += 1
        End If

        laughed = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        picBakery.Image = Image.FromFile("bread_default.png")
    End Sub

    Private Sub picBakery_Click(sender As Object, e As EventArgs) Handles picBakery.Click
        breadCount += 1 + 2 * mouse + 9 * baker + 30 * farm + 200 * factory
        lblBreadNum.Text = breadCount

        If breadCount > 1000000 Then
            MsgBox("Congratulations for baking over 1 Million Bread!", Buttons:=0, "BAKR.IO")
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            picBakery.Enabled = False
        End If
    End Sub
End Class
