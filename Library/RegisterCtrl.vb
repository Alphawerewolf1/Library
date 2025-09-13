Imports MySql.Data.MySqlClient

Public Class RegisterCtrl
    Inherits UserControl

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Connect()
        Try
            ' Insert into users table
            Dim cmd As New MySqlCommand("INSERT INTO users(username,password,role) VALUES(@u,@p,'borrower')", conn)
            cmd.Parameters.AddWithValue("@u", txtNewUsername.Text)
            cmd.Parameters.AddWithValue("@p", txtNewPassword.Text)
            cmd.ExecuteNonQuery()

            Dim userId As Integer = CInt(cmd.LastInsertedId)

            ' Insert into borrowers table
            Dim cmd2 As New MySqlCommand("INSERT INTO borrowers(user_id,full_name,email) VALUES(@uid,@f,@e)", conn)
            cmd2.Parameters.AddWithValue("@uid", userId)
            cmd2.Parameters.AddWithValue("@f", txtFullName.Text)
            cmd2.Parameters.AddWithValue("@e", txtEmail.Text)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Registration successful! Please log in.")

            ' ✅ Load LoginCtrl via Panel.LoadControl
            Dim parentForm As Panel = CType(Me.FindForm(), Panel)
            If parentForm IsNot Nothing Then
                parentForm.LoadControl(New LoginCtrl())
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim parentForm As Panel = CType(Me.FindForm(), Panel)
        If parentForm IsNot Nothing Then
            parentForm.LoadControl(New LoginCtrl())
        End If
    End Sub
End Class
