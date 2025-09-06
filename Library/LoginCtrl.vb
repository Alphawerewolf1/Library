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
                ' fetch borrower_id
                Connect()
                Dim getBorrowerCmd As New MySqlCommand("SELECT borrower_id FROM borrowers WHERE user_id=@uid", conn)
                getBorrowerCmd.Parameters.AddWithValue("@uid", userId)
                Dim borrowerId As Integer = CInt(getBorrowerCmd.ExecuteScalar())
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
