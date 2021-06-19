Public Class Form1
    Dim birthdate As Date
    Dim result As TimeSpan
    Dim age As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.AliceBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LB2.Items.Add(LB1.SelectedItem)
        LB1.Items.Remove(LB1.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LB1.Items.Add(LB2.SelectedItem)
        LB2.Items.Remove(LB2.SelectedItem)
    End Sub

    Private Sub LLSubmit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLSubmit.LinkClicked
        Form2.BackColor = Color.AliceBlue
        Form2.Show()
        ''''''Name'''''''''
        Form2.Label2.Text = txtname.Text
        ''''''Age'''''''''''
        Form2.Label4.Text = DTPDob.Value
        birthdate = DTPDob.Value
        result = Today.Subtract(birthdate)
        age = result.TotalDays / 365
        Form2.Label8.Text = age
        ''''''Mobile Number''''''''''
        Form2.Label6.Text = MTBMobile.Text
        ''''''Hobbies''''''''''''''
        Dim hobby As New System.Text.StringBuilder
        For Each item In LB2.Items
            hobby.Append(item)
            hobby.Append(" , ")
        Next
        Form2.Label10.Text = hobby.ToString
        '''''''Address''''''''''''''
        Form2.RichTextBox2.Text = RichTextBox1.Text
        '''''''City''''''''''''
        Form2.Label13.Text = CBCity.SelectedItem
        '''''''Progress Bar'''''''''''''
        ProgressBar1.Visible = True
        For i As Integer = 0 To 100 Step 1
            ProgressBar1.Value = i
            Threading.Thread.Sleep(20)
        Next
    End Sub

    Private Sub LLClear_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLClear.LinkClicked
        txtname.Clear()
        DTPDob.Value = Today
        MTBMobile.Clear()
        RichTextBox1.Clear()
        CBCity.Text = "Choose Your City"
        LB1.Items.AddRange(LB2.Items)
        LB2.Items.Clear()
    End Sub

    Private Sub LLCancel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLCancel.LinkClicked
        Application.Exit()
    End Sub
End Class
