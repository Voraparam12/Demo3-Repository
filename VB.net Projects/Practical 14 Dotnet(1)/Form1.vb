Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HasnainMakadaDataSet.STUDENT_DETAILS' table. You can move, or remove it, as needed.
        Me.STUDENT_DETAILSTableAdapter.Fill(Me.HasnainMakadaDataSet.STUDENT_DETAILS)

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs)
        Dim con As SqlConnection = New SqlConnection("Data Source=MSI;Initial Catalog=HasnainMakada;Integrated Security=True")
        Dim deletequery As String = "Delete from STUDENT_DETAILS WHERE STD_ID=2"
    End Sub
End Class
