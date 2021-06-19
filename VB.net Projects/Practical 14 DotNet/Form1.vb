Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HasnainMakadaDataSet1.STUDENT_DETAILS' table. You can move, or remove it, as needed.
        Me.STUDENT_DETAILSTableAdapter.Fill(Me.HasnainMakadaDataSet1.STUDENT_DETAILS)
        'TODO: This line of code loads data into the 'HasnainMakadaDataSet.Student_Details' table. You can move, or remove it, as needed.
        Me.STUDENT_DETAILSTableAdapter.Fill(Me.HasnainMakadaDataSet1.STUDENT_DETAILS)
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = "Data Source=MSI;Initial Catalog=HasnainMakada;Integrated Security=True"
        con.Open()
        Dim selectquery As String = "select * from STUDENT_DETAILS"
        Dim sda As SqlDataAdapter = New SqlDataAdapter(selectquery, con)
    End Sub
End Class