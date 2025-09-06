<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboardCtrl
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
        lblBookID = New Label()
        txtBookID = New TextBox()
        txtGenre = New TextBox()
        lblGenre = New Label()
        txtAuthor = New TextBox()
        txtISBN = New TextBox()
        lblSearch = New Label()
        lblAuthor = New Label()
        lblBookISBN = New Label()
        lblBookTitle = New Label()
        btnSearch = New Button()
        txtSearch = New TextBox()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        txtTitle = New TextBox()
        dgvBooks = New DataGridView()
        loginlbl = New Label()
        numQuantity = New NumericUpDown()
        qtylbl = New Label()
        LogoutBtn = New Button()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblBookID
        ' 
        lblBookID.AutoSize = True
        lblBookID.Location = New Point(670, 47)
        lblBookID.Name = "lblBookID"
        lblBookID.Size = New Size(48, 15)
        lblBookID.TabIndex = 35
        lblBookID.Text = "Book ID"
        ' 
        ' txtBookID
        ' 
        txtBookID.Location = New Point(564, 44)
        txtBookID.Name = "txtBookID"
        txtBookID.Size = New Size(100, 23)
        txtBookID.TabIndex = 34
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(564, 160)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(100, 23)
        txtGenre.TabIndex = 33
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(670, 163)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(38, 15)
        lblGenre.TabIndex = 32
        lblGenre.Text = "Genre"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(564, 131)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(100, 23)
        txtAuthor.TabIndex = 31
        ' 
        ' txtISBN
        ' 
        txtISBN.Location = New Point(564, 102)
        txtISBN.Name = "txtISBN"
        txtISBN.Size = New Size(100, 23)
        txtISBN.TabIndex = 30
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(670, 310)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(45, 15)
        lblSearch.TabIndex = 29
        lblSearch.Text = "Search:"
        ' 
        ' lblAuthor
        ' 
        lblAuthor.AutoSize = True
        lblAuthor.Location = New Point(670, 134)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(44, 15)
        lblAuthor.TabIndex = 28
        lblAuthor.Text = "Author"
        ' 
        ' lblBookISBN
        ' 
        lblBookISBN.AutoSize = True
        lblBookISBN.Location = New Point(670, 102)
        lblBookISBN.Name = "lblBookISBN"
        lblBookISBN.Size = New Size(65, 15)
        lblBookISBN.TabIndex = 27
        lblBookISBN.Text = "Book ISBN:"
        ' 
        ' lblBookTitle
        ' 
        lblBookTitle.AutoSize = True
        lblBookTitle.Location = New Point(670, 76)
        lblBookTitle.Name = "lblBookTitle"
        lblBookTitle.Size = New Size(62, 15)
        lblBookTitle.TabIndex = 26
        lblBookTitle.Text = "Book Title:"
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(564, 339)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 25
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(564, 310)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 23)
        txtSearch.TabIndex = 24
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(564, 281)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 23
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(564, 252)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 22
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(564, 223)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 21
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(564, 73)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(100, 23)
        txtTitle.TabIndex = 20
        ' 
        ' dgvBooks
        ' 
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Location = New Point(65, 33)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.Size = New Size(481, 384)
        dgvBooks.TabIndex = 19
        ' 
        ' loginlbl
        ' 
        loginlbl.AutoSize = True
        loginlbl.Location = New Point(564, 26)
        loginlbl.Name = "loginlbl"
        loginlbl.Size = New Size(59, 15)
        loginlbl.TabIndex = 36
        loginlbl.Text = "username"
        ' 
        ' numQuantity
        ' 
        numQuantity.Location = New Point(563, 191)
        numQuantity.Name = "numQuantity"
        numQuantity.Size = New Size(120, 23)
        numQuantity.TabIndex = 37
        ' 
        ' qtylbl
        ' 
        qtylbl.AutoSize = True
        qtylbl.Location = New Point(689, 193)
        qtylbl.Name = "qtylbl"
        qtylbl.Size = New Size(51, 15)
        qtylbl.TabIndex = 38
        qtylbl.Text = "Amount"
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Location = New Point(564, 394)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(75, 23)
        LogoutBtn.TabIndex = 39
        LogoutBtn.Text = "Log out"
        LogoutBtn.UseVisualStyleBackColor = True
        ' 
        ' AdminDashboardCtrl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(LogoutBtn)
        Controls.Add(qtylbl)
        Controls.Add(numQuantity)
        Controls.Add(loginlbl)
        Controls.Add(lblBookID)
        Controls.Add(txtBookID)
        Controls.Add(txtGenre)
        Controls.Add(lblGenre)
        Controls.Add(txtAuthor)
        Controls.Add(txtISBN)
        Controls.Add(lblSearch)
        Controls.Add(lblAuthor)
        Controls.Add(lblBookISBN)
        Controls.Add(lblBookTitle)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtTitle)
        Controls.Add(dgvBooks)
        Name = "AdminDashboardCtrl"
        Size = New Size(800, 450)
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBookID As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblBookISBN As Label
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents loginlbl As Label
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents qtylbl As Label
    Friend WithEvents LogoutBtn As Button

End Class
