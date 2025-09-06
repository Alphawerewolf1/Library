<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowerDashboardCtrl
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
        dgvBorrowedBooks = New DataGridView()
        LogoutBtn = New Button()
        txtSearchBooks = New TextBox()
        btnReturnBook = New Button()
        btnBorrowBook = New Button()
        dgvAvailableBooks = New DataGridView()
        loginlbl = New Label()
        BorrowQtyLbl = New Label()
        numBorrowQty = New NumericUpDown()
        ReturnQtyLbl = New Label()
        numReturnQty = New NumericUpDown()
        btnSearchBooks = New Button()
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAvailableBooks, ComponentModel.ISupportInitialize).BeginInit()
        CType(numBorrowQty, ComponentModel.ISupportInitialize).BeginInit()
        CType(numReturnQty, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvBorrowedBooks
        ' 
        dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowedBooks.Location = New Point(340, 33)
        dgvBorrowedBooks.Name = "dgvBorrowedBooks"
        dgvBorrowedBooks.Size = New Size(233, 384)
        dgvBorrowedBooks.TabIndex = 20
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Location = New Point(593, 394)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(75, 23)
        LogoutBtn.TabIndex = 19
        LogoutBtn.Text = "Log out"
        LogoutBtn.UseVisualStyleBackColor = True
        ' 
        ' txtSearchBooks
        ' 
        txtSearchBooks.Location = New Point(600, 258)
        txtSearchBooks.Name = "txtSearchBooks"
        txtSearchBooks.Size = New Size(100, 23)
        txtSearchBooks.TabIndex = 18
        ' 
        ' btnReturnBook
        ' 
        btnReturnBook.Location = New Point(600, 150)
        btnReturnBook.Name = "btnReturnBook"
        btnReturnBook.Size = New Size(75, 23)
        btnReturnBook.TabIndex = 17
        btnReturnBook.Text = "Return"
        btnReturnBook.UseVisualStyleBackColor = True
        ' 
        ' btnBorrowBook
        ' 
        btnBorrowBook.Location = New Point(600, 92)
        btnBorrowBook.Name = "btnBorrowBook"
        btnBorrowBook.Size = New Size(75, 23)
        btnBorrowBook.TabIndex = 16
        btnBorrowBook.Text = "Borrow"
        btnBorrowBook.UseVisualStyleBackColor = True
        ' 
        ' dgvAvailableBooks
        ' 
        dgvAvailableBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAvailableBooks.Location = New Point(101, 33)
        dgvAvailableBooks.Name = "dgvAvailableBooks"
        dgvAvailableBooks.Size = New Size(233, 384)
        dgvAvailableBooks.TabIndex = 15
        ' 
        ' loginlbl
        ' 
        loginlbl.AutoSize = True
        loginlbl.Location = New Point(609, 33)
        loginlbl.Name = "loginlbl"
        loginlbl.Size = New Size(59, 15)
        loginlbl.TabIndex = 21
        loginlbl.Text = "username"
        ' 
        ' BorrowQtyLbl
        ' 
        BorrowQtyLbl.AutoSize = True
        BorrowQtyLbl.Location = New Point(726, 123)
        BorrowQtyLbl.Name = "BorrowQtyLbl"
        BorrowQtyLbl.Size = New Size(51, 15)
        BorrowQtyLbl.TabIndex = 40
        BorrowQtyLbl.Text = "Amount"
        ' 
        ' numBorrowQty
        ' 
        numBorrowQty.Location = New Point(600, 121)
        numBorrowQty.Name = "numBorrowQty"
        numBorrowQty.Size = New Size(120, 23)
        numBorrowQty.TabIndex = 39
        ' 
        ' ReturnQtyLbl
        ' 
        ReturnQtyLbl.AutoSize = True
        ReturnQtyLbl.Location = New Point(726, 181)
        ReturnQtyLbl.Name = "ReturnQtyLbl"
        ReturnQtyLbl.Size = New Size(51, 15)
        ReturnQtyLbl.TabIndex = 42
        ReturnQtyLbl.Text = "Amount"
        ' 
        ' numReturnQty
        ' 
        numReturnQty.Location = New Point(600, 179)
        numReturnQty.Name = "numReturnQty"
        numReturnQty.Size = New Size(120, 23)
        numReturnQty.TabIndex = 41
        ' 
        ' btnSearchBooks
        ' 
        btnSearchBooks.Location = New Point(600, 287)
        btnSearchBooks.Name = "btnSearchBooks"
        btnSearchBooks.Size = New Size(75, 23)
        btnSearchBooks.TabIndex = 43
        btnSearchBooks.Text = "Search"
        btnSearchBooks.UseVisualStyleBackColor = True
        ' 
        ' BorrowerDashboardCtrl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnSearchBooks)
        Controls.Add(ReturnQtyLbl)
        Controls.Add(numReturnQty)
        Controls.Add(BorrowQtyLbl)
        Controls.Add(numBorrowQty)
        Controls.Add(loginlbl)
        Controls.Add(dgvBorrowedBooks)
        Controls.Add(LogoutBtn)
        Controls.Add(txtSearchBooks)
        Controls.Add(btnReturnBook)
        Controls.Add(btnBorrowBook)
        Controls.Add(dgvAvailableBooks)
        Name = "BorrowerDashboardCtrl"
        Size = New Size(800, 450)
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAvailableBooks, ComponentModel.ISupportInitialize).EndInit()
        CType(numBorrowQty, ComponentModel.ISupportInitialize).EndInit()
        CType(numReturnQty, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvBorrowedBooks As DataGridView
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents txtSearchBooks As TextBox
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents btnBorrowBook As Button
    Friend WithEvents dgvAvailableBooks As DataGridView
    Friend WithEvents loginlbl As Label
    Friend WithEvents BorrowQtyLbl As Label
    Friend WithEvents numBorrowQty As NumericUpDown
    Friend WithEvents ReturnQtyLbl As Label
    Friend WithEvents numReturnQty As NumericUpDown
    Friend WithEvents btnSearchBooks As Button

End Class
