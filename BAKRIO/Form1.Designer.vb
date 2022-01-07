<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picBread = New System.Windows.Forms.PictureBox()
        Me.gbBreadRec = New System.Windows.Forms.GroupBox()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scrBread = New System.Windows.Forms.HScrollBar()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblBreadName = New System.Windows.Forms.Label()
        Me.gbBreadBaker = New System.Windows.Forms.GroupBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBreadNum = New System.Windows.Forms.Label()
        Me.picBakery = New System.Windows.Forms.PictureBox()
        Me.btnPun = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picBread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBreadRec.SuspendLayout()
        Me.gbBreadBaker.SuspendLayout()
        CType(Me.picBakery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(16, 133)
        Me.btnOpenFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(235, 52)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Choose file"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(16, 64)
        Me.lblPrompt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(235, 64)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "USE BUTTON TO PICK A FILE"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Console", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(453, 56)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(223, 48)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "BAKR.IO"
        '
        'picBread
        '
        Me.picBread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBread.Location = New System.Drawing.Point(294, 121)
        Me.picBread.Name = "picBread"
        Me.picBread.Size = New System.Drawing.Size(200, 200)
        Me.picBread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBread.TabIndex = 3
        Me.picBread.TabStop = False
        '
        'gbBreadRec
        '
        Me.gbBreadRec.Controls.Add(Me.lblPos)
        Me.gbBreadRec.Controls.Add(Me.lblSentence)
        Me.gbBreadRec.Controls.Add(Me.Label3)
        Me.gbBreadRec.Controls.Add(Me.lblCurrent)
        Me.gbBreadRec.Controls.Add(Me.lblTotal)
        Me.gbBreadRec.Controls.Add(Me.txtSentence)
        Me.gbBreadRec.Controls.Add(Me.Label2)
        Me.gbBreadRec.Controls.Add(Me.Label1)
        Me.gbBreadRec.Controls.Add(Me.scrBread)
        Me.gbBreadRec.Controls.Add(Me.lblDesc)
        Me.gbBreadRec.Controls.Add(Me.lblBreadName)
        Me.gbBreadRec.Controls.Add(Me.lblPrompt)
        Me.gbBreadRec.Controls.Add(Me.picBread)
        Me.gbBreadRec.Controls.Add(Me.btnOpenFile)
        Me.gbBreadRec.Font = New System.Drawing.Font("Lucida Console", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gbBreadRec.Location = New System.Drawing.Point(43, 130)
        Me.gbBreadRec.Name = "gbBreadRec"
        Me.gbBreadRec.Size = New System.Drawing.Size(523, 560)
        Me.gbBreadRec.TabIndex = 4
        Me.gbBreadRec.TabStop = False
        Me.gbBreadRec.Text = "Bread Recognition"
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Font = New System.Drawing.Font("Lucida Console", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPos.Location = New System.Drawing.Point(161, 273)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(23, 22)
        Me.lblPos.TabIndex = 14
        Me.lblPos.Text = "0"
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Font = New System.Drawing.Font("Lucida Console", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSentence.Location = New System.Drawing.Point(161, 236)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(23, 22)
        Me.lblSentence.TabIndex = 13
        Me.lblSentence.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(24, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sentence:"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(336, 453)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(29, 28)
        Me.lblCurrent.TabIndex = 11
        Me.lblCurrent.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(435, 453)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(29, 28)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "0"
        '
        'txtSentence
        '
        Me.txtSentence.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSentence.Location = New System.Drawing.Point(24, 320)
        Me.txtSentence.Multiline = True
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.ReadOnly = True
        Me.txtSentence.Size = New System.Drawing.Size(216, 201)
        Me.txtSentence.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(24, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Position:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "of"
        '
        'scrBread
        '
        Me.scrBread.Enabled = False
        Me.scrBread.Location = New System.Drawing.Point(294, 490)
        Me.scrBread.Maximum = 20
        Me.scrBread.Name = "scrBread"
        Me.scrBread.Size = New System.Drawing.Size(208, 47)
        Me.scrBread.TabIndex = 6
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDesc.Location = New System.Drawing.Point(294, 338)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(200, 103)
        Me.lblDesc.TabIndex = 5
        Me.lblDesc.Text = "Description"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBreadName
        '
        Me.lblBreadName.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBreadName.Location = New System.Drawing.Point(294, 82)
        Me.lblBreadName.Name = "lblBreadName"
        Me.lblBreadName.Size = New System.Drawing.Size(200, 24)
        Me.lblBreadName.TabIndex = 4
        Me.lblBreadName.Text = "BreadName"
        Me.lblBreadName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbBreadBaker
        '
        Me.gbBreadBaker.Controls.Add(Me.lbl2)
        Me.gbBreadBaker.Controls.Add(Me.lbl3)
        Me.gbBreadBaker.Controls.Add(Me.lbl4)
        Me.gbBreadBaker.Controls.Add(Me.lbl1)
        Me.gbBreadBaker.Controls.Add(Me.btn4)
        Me.gbBreadBaker.Controls.Add(Me.btn3)
        Me.gbBreadBaker.Controls.Add(Me.btn2)
        Me.gbBreadBaker.Controls.Add(Me.btn1)
        Me.gbBreadBaker.Controls.Add(Me.Label8)
        Me.gbBreadBaker.Controls.Add(Me.Label7)
        Me.gbBreadBaker.Controls.Add(Me.Label6)
        Me.gbBreadBaker.Controls.Add(Me.Label5)
        Me.gbBreadBaker.Controls.Add(Me.lblBreadNum)
        Me.gbBreadBaker.Controls.Add(Me.picBakery)
        Me.gbBreadBaker.Controls.Add(Me.btnPun)
        Me.gbBreadBaker.Controls.Add(Me.Label4)
        Me.gbBreadBaker.Font = New System.Drawing.Font("Lucida Console", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gbBreadBaker.Location = New System.Drawing.Point(608, 131)
        Me.gbBreadBaker.Name = "gbBreadBaker"
        Me.gbBreadBaker.Size = New System.Drawing.Size(507, 431)
        Me.gbBreadBaker.TabIndex = 5
        Me.gbBreadBaker.TabStop = False
        Me.gbBreadBaker.Text = "Bread Baker"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Lucida Console", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl2.Location = New System.Drawing.Point(216, 124)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(24, 22)
        Me.lbl2.TabIndex = 18
        Me.lbl2.Text = "0"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Lucida Console", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl3.Location = New System.Drawing.Point(216, 180)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(24, 22)
        Me.lbl3.TabIndex = 17
        Me.lbl3.Text = "0"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Lucida Console", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl4.Location = New System.Drawing.Point(216, 233)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(24, 22)
        Me.lbl4.TabIndex = 16
        Me.lbl4.Text = "0"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Lucida Console", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl1.Location = New System.Drawing.Point(216, 71)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(24, 22)
        Me.lbl1.TabIndex = 15
        Me.lbl1.Text = "0"
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(446, 227)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(42, 35)
        Me.btn4.TabIndex = 14
        Me.btn4.Text = "$"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(446, 175)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(42, 35)
        Me.btn3.TabIndex = 13
        Me.btn3.Text = "$"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(446, 121)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(42, 35)
        Me.btn2.TabIndex = 12
        Me.btn2.Text = "$"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(446, 65)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(42, 35)
        Me.btn1.TabIndex = 11
        Me.btn1.Text = "$"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(249, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Factory (30k)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(249, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Farm (2k)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(249, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Baker (100)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(249, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Mouse (10)"
        '
        'lblBreadNum
        '
        Me.lblBreadNum.Font = New System.Drawing.Font("Lucida Console", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBreadNum.Location = New System.Drawing.Point(35, 246)
        Me.lblBreadNum.Name = "lblBreadNum"
        Me.lblBreadNum.Size = New System.Drawing.Size(170, 87)
        Me.lblBreadNum.TabIndex = 6
        Me.lblBreadNum.Text = "Click for Bread"
        Me.lblBreadNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picBakery
        '
        Me.picBakery.Location = New System.Drawing.Point(35, 63)
        Me.picBakery.Name = "picBakery"
        Me.picBakery.Size = New System.Drawing.Size(170, 170)
        Me.picBakery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBakery.TabIndex = 2
        Me.picBakery.TabStop = False
        '
        'btnPun
        '
        Me.btnPun.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPun.Location = New System.Drawing.Point(315, 364)
        Me.btnPun.Name = "btnPun"
        Me.btnPun.Size = New System.Drawing.Size(144, 53)
        Me.btnPun.TabIndex = 1
        Me.btnPun.Text = "[0  -  0]"
        Me.btnPun.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "The Pun Machine:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(662, 587)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(399, 91)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "EDIT BREAD LIST"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 750)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbBreadBaker)
        Me.Controls.Add(Me.gbBreadRec)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "BAKR.IO - Bread Recognition"
        CType(Me.picBread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBreadRec.ResumeLayout(False)
        Me.gbBreadRec.PerformLayout()
        Me.gbBreadBaker.ResumeLayout(False)
        Me.gbBreadBaker.PerformLayout()
        CType(Me.picBakery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenFile As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picBread As PictureBox
    Friend WithEvents gbBreadRec As GroupBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblBreadName As Label
    Friend WithEvents txtSentence As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents scrBread As HScrollBar
    Friend WithEvents lblCurrent As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPos As Label
    Friend WithEvents lblSentence As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbBreadBaker As GroupBox
    Friend WithEvents btnPun As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblBreadNum As Label
    Friend WithEvents picBakery As PictureBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
