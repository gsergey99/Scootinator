Public Class DBBroker
    Private Shared Instance As DBBroker
    Private Shared connection As OleDb.OleDbConnection
    Private Shared connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Sub New()
        DBBroker.connection = New OleDb.OleDbConnection(DBBroker.connectionString)
        DBBroker.connection.Open()
    End Sub
    Public Shared Function GetBroker() As DBBroker
        If Instance Is Nothing Then
            Instance = New DBBroker()
        End If

        Return Instance
    End Function

    Public Shared Function GetBroker(path As String) As DBBroker
        DBBroker.connectionString = DBBroker.connectionString & path
        Return DBBroker.GetBroker()
    End Function
    Public Function Read(sql As String) As OleDb.OleDbDataReader
        Dim com As New OleDb.OleDbCommand(sql, DBBroker.connection)
        Return com.ExecuteReader()
    End Function
    Public Function Change(Sql As String) As Integer
        Dim com As New OleDb.OleDbCommand(Sql, DBBroker.connection)
        Return com.ExecuteNonQuery()
    End Function
End Class
