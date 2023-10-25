Imports System.Data.SqlClient

Public Class HospitalDBConnectionHelper
    'Inherits SqlServerConnectionHelper
    Private connectionString As String

    Public Sub New(hospitalDB As String)
        connectionString = $"Data Source=localhost\sqlexpress;Initial Catalog={hospitalDB};Integrated Security=True; Connect Timeout=60;"
    End Sub

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
    '' Public Sub New()

    '' MyBase.New("hospitalDB")
    '' End Sub
End Class

