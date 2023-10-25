Imports System.Data.SqlClient

Public Class SqlServerConnectionHelper
    Private ReadOnly connectionString As String

    Public Sub New(master As String)
        connectionString = $"Data Source=localhost\SQLEXPRESS;Initial Catalog={master};Integrated Security=True"
    End Sub

    Public Function GetDataTable(query As String) As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dataTable)
            Catch ex As Exception
                Throw New Exception("Error executing query: " & ex.Message)
            End Try
        End Using

        Return dataTable
    End Function
End Class
