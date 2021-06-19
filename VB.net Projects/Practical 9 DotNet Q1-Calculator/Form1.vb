Public Class Form1
    Dim n1 As Integer
    Dim n2 As Integer
    Dim c As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Aquamarine

    End Sub

    Private Sub BTResult_Click(sender As Object, e As EventArgs) Handles BTResult.Click
        n1 = MaskedTextBox1.Text
        n2 = MaskedTextBox2.Text
        If RBAddition.Checked = True Then
            c = n1 + n2
            Label2.Text = "Addition is   " & c
        ElseIf RBSubtract.Checked = True Then
            c = n1 - n2
            Label2.Text = "Subtraction is  " & c
        ElseIf RBmulti.Checked = True Then
            c = n1 * n2
            Label2.Text = "Multiplication is  " & c
        ElseIf RBdiv.Checked = True Then
            c = n1 / n2
            Label2.Text = "Division is " & c
        End If

    End Sub
End Class
