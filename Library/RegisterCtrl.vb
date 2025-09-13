Imports MySql.Data.MySqlClient

Public Class RegisterCtrl
    Inherits UserControl

    ' Controls (make sure these exist in the designer)
    ' txtFullName (TextBox)
    ' txtEmail (TextBox)
    ' lblNewUsername (TextBox)
    ' txtNewPassword (TextBox)
    ' btnCreateAccount (Button)
    ' btnLogin (Button)

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Connect()
        Try
            Dim cmd As New MySqlCommand("INSERT INTO users(username,password,role) VALUES(@u,@p,'borrower')", conn)
            cmd.Parameters.AddWithValue("@u", txtNewUsername.Text)
            cmd.Parameters.AddWithValue("@p", txtNewPassword.Text)
            cmd.ExecuteNonQuery()

            Dim userId As Integer = CInt(cmd.LastInsertedId)

            Dim cmd2 As New MySqlCommand("INSERT INTO borrowers(user_id,full_name,email) VALUES(@uid,@f,@e)", conn)
            cmd2.Parameters.AddWithValue("@uid", userId)
            cmd2.Parameters.AddWithValue("@f", txtFullName.Text)
            cmd2.Parameters.AddWithValue("@e", txtEmail.Text)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Registration successful! Please log in.")

            ' ✅ After success, go to login screen
            Dim parentForm As Form = Me.FindForm()
            If parentForm IsNot Nothing Then
                parentForm.Controls.Clear()
                Dim loginCtrl As New LoginCtrl()
                loginCtrl.Dock = DockStyle.Fill
                parentForm.Controls.Add(loginCtrl)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim parentForm As Form = Me.FindForm()
        If parentForm IsNot Nothing Then
            parentForm.Controls.Clear()
            Dim loginCtrl As New LoginCtrl()
            loginCtrl.Dock = DockStyle.Fill
            parentForm.Controls.Add(loginCtrl)
        End If
    End Sub

    Private Sub RegisterCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNewUsername_TextChanged(sender As Object, e As EventArgs) Handles txtNewUsername.TextChanged

    End Sub
End Class
