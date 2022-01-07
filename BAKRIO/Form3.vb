Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblMessage.Text = Form1.message
    End Sub

    Private Sub btnLaugh_Click(sender As Object, e As EventArgs) Handles btnLaugh.Click
        Form1.laughed = True
        Close()
    End Sub

    Private Sub btnDonot_Click(sender As Object, e As EventArgs) Handles btnDonot.Click
        Close()
    End Sub
End Class