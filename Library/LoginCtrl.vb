Imports MySql.Data.MySqlClient

Public Class LoginCtrl
    Inherits UserControl

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Connect()
        Dim cmd As New MySqlCommand("SELECT * FROM users WHERE username=@u AND password=@p", conn)
        cmd.Parameters.AddWithValue("@u", txtUsername.Text)
        cmd.Parameters.AddWithValue("@p", txtPassword.Text)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim role As String = reader("role").ToString()
            Dim username As String = reader("username").ToString()
            Dim userId As Integer = reader("user_id")
            MessageBox.Show("Login successful as " & role)

            reader.Close()
            conn.Close()

            Dim parentForm As Panel = CType(Me.FindForm(), Panel)

            If role = "admin" Then
                Dim adminCtrl As New AdminDashboardCtrl()
                adminCtrl.username = username
                parentForm.LoadControl(adminCtrl)
            Else
                ' borrower login
                Connect()
                Dim getBorrowerCmd As New MySqlCommand("SELECT borrower_id FROM borrowers WHERE user_id=@uid", conn)
                getBorrowerCmd.Parameters.AddWithValue("@uid", userId)
                Dim borrowerIdObj As Object = getBorrowerCmd.ExecuteScalar()

                ' if borrower profile doesn’t exist, create one
                If borrowerIdObj Is Nothing OrElse borrowerIdObj Is DBNull.Value Then
                    Dim insertCmd As New MySqlCommand("INSERT INTO borrowers(user_id, full_name, email) VALUES(@uid, @name, @mail)", conn)
                    insertCmd.Parameters.AddWithValue("@uid", userId)
                    insertCmd.Parameters.AddWithValue("@name", username) ' default full_name = username
                    insertCmd.Parameters.AddWithValue("@mail", username & "@mail.com") ' placeholder email
                    insertCmd.ExecuteNonQuery()

                    borrowerIdObj = insertCmd.LastInsertedId
                End If

                Dim borrowerId As Integer = Convert.ToInt32(borrowerIdObj)
                conn.Close()

                Dim borrowerCtrl As New BorrowerDashboardCtrl()
                borrowerCtrl.username = username
                borrowerCtrl.borrowerId = borrowerId
                parentForm.LoadControl(borrowerCtrl)
            End If
        Else
            MessageBox.Show("Invalid login")
            reader.Close()
            conn.Close()
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim parentForm As Panel = CType(Me.FindForm(), Panel)
        parentForm.LoadControl(New RegisterCtrl())
    End Sub
End Class
