Imports MySql.Data.MySqlClient

Module DbConnection
    Public conn As MySqlConnection

    Public Sub Connect()
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=library_db")
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Database connection failed: " & ex.Message)
        End Try
    End Sub
End Module
