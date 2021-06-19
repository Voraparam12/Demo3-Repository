Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F_name.ReadOnly = True
        M_name.ReadOnly = True
        L_name.ReadOnly = True
        Email_text.ReadOnly = True
        Password.ReadOnly = True
        If RadioMale.Checked = True Then
            Label4.Text = RadioMale.Text
        End If
        If Radiofemale.Checked = True Then
            Label4.Text = Radiofemale.Text
        End If
        If CheckBox1.Checked = True Then
            Label5.Text = CheckBox1.Text
        End If
        If CheckBox2.Checked = True Then
            Label5.Text &= " ," & CheckBox2.Text
        End If
        If CheckBox3.Checked = True Then
            Label5.Text &= " ," & CheckBox3.Text
        End If
        If CheckBox4.Checked = True Then
            Label5.Text &= " ," & CheckBox4.Text
        End If
        Numericage.ReadOnly = True
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        Password.PasswordChar = "*"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        F_name.Clear()
        F_name.ReadOnly = False
        M_name.Clear()
        M_name.ReadOnly = False
        L_name.Clear()
        L_name.ReadOnly = False
        Email_text.Clear()
        Email_text.ReadOnly = False
        Password.Clear()
        Password.ReadOnly = False
        RadioMale.Checked = False
        Radiofemale.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        Numericage.ResetText()
        Label4.ResetText()
        Label5.ResetText()
        Numericage.Value = Numericage.Minimum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Aqua

    End Sub
End Class
