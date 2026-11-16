Imports MySql.Data.MySqlClient
Module mdlDatabase

    Public conn As New MySqlConnection

    Public Sub ConnectDatabase()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "SERVER=localhost; DATABASE=dbpasien; user id=root; password=ukrida; port=3306; charset=utf8;"
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to database", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Public Sub DisconnectDatabase()
        Try
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException

        End Try
    End Sub
End Module
