<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterCtrl
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
        btnLogin = New Button()
        btnCreateAccount = New Button()
        lblEmail = New Label()
        txtEmail = New TextBox()
        LblFullName = New Label()
        txtFullName = New TextBox()
        lblNewPassword = New Label()
        txtNewPassword = New TextBox()
        lblNewUsername = New Label()
        txtNewUsername = New TextBox()
        lblRegister = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(208, 300)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 19
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Location = New Point(24, 300)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(178, 23)
        btnCreateAccount.TabIndex = 18
        btnCreateAccount.Text = "Create Account"
        btnCreateAccount.UseVisualStyleBackColor = True
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(24, 228)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(39, 15)
        lblEmail.TabIndex = 17
        lblEmail.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(24, 246)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(100, 23)
        txtEmail.TabIndex = 16
        ' 
        ' LblFullName
        ' 
        LblFullName.AutoSize = True
        LblFullName.Location = New Point(24, 167)
        LblFullName.Name = "LblFullName"
        LblFullName.Size = New Size(64, 15)
        LblFullName.TabIndex = 15
        LblFullName.Text = "Full Name:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(24, 185)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(100, 23)
        txtFullName.TabIndex = 14
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.AutoSize = True
        lblNewPassword.Location = New Point(24, 111)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(60, 15)
        lblNewPassword.TabIndex = 13
        lblNewPassword.Text = "Password:"
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(24, 129)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(100, 23)
        txtNewPassword.TabIndex = 12
        ' 
        ' lblNewUsername
        ' 
        lblNewUsername.AutoSize = True
        lblNewUsername.Location = New Point(24, 61)
        lblNewUsername.Name = "lblNewUsername"
        lblNewUsername.Size = New Size(63, 15)
        lblNewUsername.TabIndex = 11
        lblNewUsername.Text = "Username:"
        ' 
        ' txtNewUsername
        ' 
        txtNewUsername.Location = New Point(24, 79)
        txtNewUsername.Name = "txtNewUsername"
        txtNewUsername.Size = New Size(100, 23)
        txtNewUsername.TabIndex = 10
        ' 
        ' lblRegister
        ' 
        lblRegister.AutoSize = True
        lblRegister.Location = New Point(24, 19)
        lblRegister.Name = "lblRegister"
        lblRegister.Size = New Size(49, 15)
        lblRegister.TabIndex = 20
        lblRegister.Text = "Register"
        ' 
        ' RegisterCtrl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblRegister)
        Controls.Add(btnLogin)
        Controls.Add(btnCreateAccount)
        Controls.Add(lblEmail)
        Controls.Add(txtEmail)
        Controls.Add(LblFullName)
        Controls.Add(txtFullName)
        Controls.Add(lblNewPassword)
        Controls.Add(txtNewPassword)
        Controls.Add(lblNewUsername)
        Controls.Add(txtNewUsername)
        Name = "RegisterCtrl"
        Size = New Size(800, 450)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents LblFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblNewUsername As Label
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents lblRegister As Label

End Class
