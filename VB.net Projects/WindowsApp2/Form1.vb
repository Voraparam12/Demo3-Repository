Public Class Form1
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        BackColor = Color.Black

    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        BackColor = Color.Red
    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        BackColor = Color.Blue
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        BackColor = Color.BlueViolet
        MsgBox("The form is closed")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        BackColor = Color.White
        MsgBox("The form is closing")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Beige
        Dim name As String
        name = InputBox("Type your name here", "Input box", "1", 100, 100)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        BackColor = Color.CadetBlue
    End Sub

    Private Sub Form1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDoubleClick
        BackColor = Color.BlueViolet

    End Sub

    Private Sub Form1_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        BackColor = Color.Aqua

    End Sub
End Class
