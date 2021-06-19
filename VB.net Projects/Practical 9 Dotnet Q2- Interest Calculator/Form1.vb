Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Aquamarine
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim P As Integer
        Dim R As Double
        Dim T As Integer
        Dim c As Double
        P = MaskedTextBox1.Text
        R = MaskedTextBox2.Text
        T = MaskedTextBox3.Text
        If CheckBox1.Checked = True Then
            c = (P * R * T) / 100
            Label5.Text = "Simple Interest:::   " & c

        ElseIf CheckBox2.Checked = True Then
            c = P * (1 + R / 100) ^ T
            Label5.Text = "Compound Interest:::    " & c
        End If
    End Sub
End Class
