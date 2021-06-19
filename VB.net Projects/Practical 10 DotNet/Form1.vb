Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.FullOpen = True
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.FullOpen = True
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FontDialog1.ShowColor = True
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font 'Change the font of the selected string  
            TextBox1.ForeColor = FontDialog1.Color 'Change the color of selected string  
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.InitialDirectory = "D:\"
            OpenFileDialog1.Title = "Open An Image File"
            OpenFileDialog1.Filter = "Image|*.jpg"
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SaveFileDialog1.Filter = "Image|*.jpg"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText _
        (SaveFileDialog1.FileName, TextBox1.Text, True)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()
    End Sub
End Class
