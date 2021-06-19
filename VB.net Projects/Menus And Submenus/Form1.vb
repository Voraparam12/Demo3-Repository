Public Class Form1
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Tsrip1_Click(sender As Object, e As EventArgs) Handles Tsrip1.Click
        MsgBox("I have been Clicked")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.AliceBlue
    End Sub
End Class