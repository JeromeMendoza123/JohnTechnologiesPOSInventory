Imports MySql.Data.MySqlClient

Module DBConnection
    ' Change these values to match your MySQL setup
    Private ReadOnly server As String = "localhost"
    Private ReadOnly database As String = "emgininventory"
    Private ReadOnly uid As String = "root"
    Private ReadOnly password As String = "" ' Set your MySQL root password if any

    Private ReadOnly connectionString As String =
        $"Server={server};Database={database};Uid={uid};Pwd={password};SslMode=none;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Module
