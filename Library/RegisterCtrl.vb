Imports MySql.Data.MySqlClient

Public Class RegisterCtrl
    Inherits UserControl

    ' Controls (make sure these exist in the designer)
    ' txtFullName (TextBox)
    ' txtEmail (TextBox)
    ' lblNewUsername (TextBox) – rename to txtNewUsername ideally
    ' txtNewPassword (TextBox)
    ' btnCreateAccount (Button)
    ' btnLogin (Button)

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Connect()
        Try
            Dim cmd As New MySqlCommand("INSERT INTO users(username,password,role) VALUES(@u,@p,'borrower')", conn)
            cmd.Parameters.AddWithValue("@u", lblNewUsername.Text)
            cmd.Parameters.AddWithValue("@p", txtNewPassword.Text)
            cmd.ExecuteNonQuery()

            Dim userId As Integer = CInt(cmd.LastInsertedId)

            Dim cmd2 As New MySqlCommand("INSERT INTO borrowers(user_id,full_name,email) VALUES(@uid,@f,@e)", conn)
            cmd2.Parameters.AddWithValue("@uid", userId)
            cmd2.Parameters.AddWithValue("@f", txtFullName.Text)
            cmd2.Parameters.AddWithValue("@e", txtEmail.Text)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Registration successful!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim parentForm As Panel = CType(Me.FindForm(), Panel)
        parentForm.LoadControl(New LoginCtrl())
    End Sub

    Private Sub RegisterCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
