<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picBread = New System.Windows.Forms.PictureBox()
        Me.lblBreadName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBreadName = New System.Windows.Forms.TextBox()
        Me.txtBreadDesc = New System.Windows.Forms.TextBox()
        Me.scrBread = New System.Windows.Forms.HScrollBar()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picBread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Console", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(242, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(223, 48)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "BAKR.IO"
        '
        'picBread
        '
        Me.picBread.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBread.Location = New System.Drawing.Point(282, 138)
        Me.picBread.Name = "picBread"
        Me.picBread.Size = New System.Drawing.Size(144, 144)
        Me.picBread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBread.TabIndex = 4
        Me.picBread.TabStop = False
        '
        'lblBreadName
        '
        Me.lblBreadName.AutoSize = True
        Me.lblBreadName.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBreadName.Location = New System.Drawing.Point(51, 110)
        Me.lblBreadName.Name = "lblBreadName"
        Me.lblBreadName.Size = New System.Drawing.Size(192, 24)
        Me.lblBreadName.TabIndex = 5
        Me.lblBreadName.Text = "Name of Bread"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(51, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Description"
        '
        'txtBreadName
        '
        Me.txtBreadName.Location = New System.Drawing.Point(51, 154)
        Me.txtBreadName.Name = "txtBreadName"
        Me.txtBreadName.Size = New System.Drawing.Size(182, 31)
        Me.txtBreadName.TabIndex = 7
        '
        'txtBreadDesc
        '
        Me.txtBreadDesc.Location = New System.Drawing.Point(51, 249)
        Me.txtBreadDesc.Multiline = True
        Me.txtBreadDesc.Name = "txtBreadDesc"
        Me.txtBreadDesc.Size = New System.Drawing.Size(182, 106)
        Me.txtBreadDesc.TabIndex = 8
        '
        'scrBread
        '
        Me.scrBread.Location = New System.Drawing.Point(134, 405)
        Me.scrBread.Maximum = 20
        Me.scrBread.Name = "scrBread"
        Me.scrBread.Size = New System.Drawing.Size(219, 38)
        Me.scrBread.TabIndex = 9
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(284, 302)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(142, 53)
        Me.btnImage.TabIndex = 10
        Me.btnImage.Text = "Select Image"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNew.Location = New System.Drawing.Point(500, 138)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(120, 63)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(500, 219)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 63)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.Location = New System.Drawing.Point(500, 302)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 63)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(423, 405)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(230, 38)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Return"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 480)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnImage)
        Me.Controls.Add(Me.scrBread)
        Me.Controls.Add(Me.txtBreadDesc)
        Me.Controls.Add(Me.txtBreadName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBreadName)
        Me.Controls.Add(Me.picBread)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "BAKR.IO - Edit Bread List"
        CType(Me.picBread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picBread As PictureBox
    Friend WithEvents lblBreadName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBreadName As TextBox
    Friend WithEvents txtBreadDesc As TextBox
    Friend WithEvents scrBread As HScrollBar
    Friend WithEvents btnImage As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
End Class
