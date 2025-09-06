<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginCtrl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnRegister = New Button()
        btnLogin = New Button()
        LblPassword = New Label()
        LblUsername = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblLogin = New Label()
        SuspendLayout()
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(162, 233)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(75, 23)
        btnRegister.TabIndex = 11
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(33, 233)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 10
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Location = New Point(36, 130)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(90, 15)
        LblPassword.TabIndex = 9
        LblPassword.Text = "Enter Password:"
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.Location = New Point(33, 75)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(93, 15)
        LblUsername.TabIndex = 8
        LblUsername.Text = "Enter Username:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(33, 148)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(204, 23)
        txtPassword.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(33, 93)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(204, 23)
        txtUsername.TabIndex = 6
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Location = New Point(33, 26)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(37, 15)
        lblLogin.TabIndex = 21
        lblLogin.Text = "Login"
        ' 
        ' LoginCtrl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblLogin)
        Controls.Add(btnRegister)
        Controls.Add(btnLogin)
        Controls.Add(LblPassword)
        Controls.Add(LblUsername)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "LoginCtrl"
        Size = New Size(800, 450)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblLogin As Label

End Class
