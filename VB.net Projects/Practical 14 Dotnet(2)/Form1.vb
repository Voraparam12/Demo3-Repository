Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HasnainMakadaDataSet.STUDENT_DETAILS' table. You can move, or remove it, as needed.
        Me.STUDENT_DETAILSTableAdapter.Fill(Me.HasnainMakadaDataSet.STUDENT_DETAILS)
        Dim con As SqlConnection = New SqlConnection("Data Source=MSi;Initial Catalog=HasnainMakada;Integrated Security=True")
        Dim selectquery As String = "Select * from STUDENT_DETAILS"
        Dim sda As SqlDataAdapter = New SqlDataAdapter(selectquery, con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        DGVStudentDetails.DataSource = dt
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If (txtid.Text = " ") Then
            MsgBox("Please Enter id")
        ElseIf (txtname.Text = " ") Then
            MsgBox("Please Enter Name")
        ElseIf (txtroll.Text = " ") Then
            MsgBox("Please Enter Roll Number")
        ElseIf (txtbranch.Text = " ") Then
            MsgBox("Please Enter Branch")
        Else
            Dim con As SqlConnection = New SqlConnection("Data Source=MSi;Initial Catalog=HasnainMakada;Integrated Security=True")
            con.Open()
            Dim insertquery As String = "Insert into STUDENT_DETAILS(STD_ID, STD_NAME, STD_ROLL, STD_BRANCH) VALUES('" + txtid.Text + "', '" + txtname.Text + "', '" + txtroll.Text + "', '" + txtbranch.Text + "' )"
            Dim cmd As SqlCommand = New SqlCommand(insertquery, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Inserted Succesfully")
            con.Close()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If (txtid.Text = " ") Then
            MsgBox("Enter Id To Delete Data")
        Else
            Dim con As SqlConnection = New SqlConnection("Data Source=MSi;Initial Catalog=HasnainMakada;Integrated Security=True")
            con.Open()
            Dim deletequery As String = "Delete from STUDENT_DETAILS Where STD_ID=  """ + txtid.Text + ""
            Dim cmd As SqlCommand = New SqlCommand(deletequery, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Deleted Successfully")
            con.Close()
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If (txtid.Text = " ") Then
            MsgBox("Please Enter ID First")
        Else
            Dim con As SqlConnection = New SqlConnection("Data Source=MSi;Initial Catalog=HasnainMakada;Integrated Security=True")
            con.Open()
            Dim updatequery As String = "Update STUDENT_DETAILS set STD_Name=  """ + txtname.Text + """,
            STD_Roll= """ + txtroll.Text + """ Where STD_ID= """ + txtid.Text + "'"
            Dim cmd As SqlCommand = New SqlCommand(updatequery, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Data Updated Successfully")
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Application.Exit()
    End Sub
End Class
