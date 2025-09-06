Imports MySql.Data.MySqlClient

Public Class BorrowerDashboardCtrl
    Inherits UserControl

    Public borrowerId As Integer   ' set from login
    Public username As String      ' passed from login for display

    Private Sub BorrowerDashboardCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginlbl.Text = "Welcome, " & username
        LoadAvailableBooks()
        LoadBorrowedBooks()
    End Sub

    ' ✅ Load available books (with author name)
    Private Sub LoadAvailableBooks(Optional search As String = "")
        Connect()
        Dim query As String = "SELECT b.book_id, b.title, IFNULL(a.name,'Unknown') AS author, b.isbn, b.genre, b.quantity 
                               FROM books b
                               LEFT JOIN authors a ON b.author_id = a.author_id
                               WHERE b.quantity > 0"

        If search <> "" Then
            query &= " AND (b.title LIKE @s OR a.name LIKE @s OR b.isbn LIKE @s OR b.genre LIKE @s)"
        End If

        Dim da As New MySqlDataAdapter(query, conn)
        If search <> "" Then
            da.SelectCommand.Parameters.AddWithValue("@s", "%" & search & "%")
        End If

        Dim dt As New DataTable
        da.Fill(dt)
        dgvAvailableBooks.DataSource = dt
        conn.Close()
    End Sub

    ' ✅ Load my borrowed books (with author name)
    Private Sub LoadBorrowedBooks()
        Connect()
        Dim query As String = "SELECT bb.borrow_id, 
                                      b.title AS book_title, 
                                      IFNULL(a.name,'Unknown') AS author, 
                                      b.isbn, 
                                      b.genre, 
                                      bb.quantity_borrowed, 
                                      bb.borrow_date
                               FROM borrowed_books bb
                               JOIN books b ON bb.book_id = b.book_id
                               LEFT JOIN authors a ON b.author_id = a.author_id
                               WHERE bb.borrower_id=@b AND bb.quantity_borrowed > 0"
        Dim da As New MySqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@b", borrowerId)

        Dim dt As New DataTable
        da.Fill(dt)
        dgvBorrowedBooks.DataSource = dt
        conn.Close()
    End Sub

    ' ✅ Borrow a book
    Private Sub btnBorrowBook_Click(sender As Object, e As EventArgs) Handles btnBorrowBook.Click
        If dgvAvailableBooks.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a book to borrow.")
            Exit Sub
        End If

        Dim bookId As Integer = dgvAvailableBooks.CurrentRow.Cells("book_id").Value
        Dim availableQty As Integer = dgvAvailableBooks.CurrentRow.Cells("quantity").Value
        Dim borrowQty As Integer = CInt(numBorrowQty.Value)

        If borrowQty <= 0 OrElse borrowQty > availableQty Then
            MessageBox.Show("Invalid quantity. Available: " & availableQty)
            Exit Sub
        End If

        Connect()
        Try
            ' insert borrow record
            Dim cmd As New MySqlCommand("INSERT INTO borrowed_books(borrower_id, book_id, quantity_borrowed, borrow_date) 
                                         VALUES(@b,@book,@q,NOW())", conn)
            cmd.Parameters.AddWithValue("@b", borrowerId)
            cmd.Parameters.AddWithValue("@book", bookId)
            cmd.Parameters.AddWithValue("@q", borrowQty)
            cmd.ExecuteNonQuery()

            ' update stock
            Dim cmd2 As New MySqlCommand("UPDATE books SET quantity=quantity-@q WHERE book_id=@id", conn)
            cmd2.Parameters.AddWithValue("@q", borrowQty)
            cmd2.Parameters.AddWithValue("@id", bookId)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Book borrowed successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        conn.Close()

        LoadAvailableBooks()
        LoadBorrowedBooks()
    End Sub

    ' ✅ Return books
    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        If dgvBorrowedBooks.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a book to return.")
            Exit Sub
        End If

        Dim borrowId As Integer = dgvBorrowedBooks.CurrentRow.Cells("borrow_id").Value
        Dim qtyBorrowed As Integer = dgvBorrowedBooks.CurrentRow.Cells("quantity_borrowed").Value
        Dim qtyToReturn As Integer = CInt(numReturnQty.Value)

        If qtyToReturn <= 0 OrElse qtyToReturn > qtyBorrowed Then
            MessageBox.Show("Invalid return quantity. Borrowed: " & qtyBorrowed)
            Exit Sub
        End If

        Connect()
        Try
            ' get book_id
            Dim getBookIdCmd As New MySqlCommand("SELECT book_id FROM borrowed_books WHERE borrow_id=@id", conn)
            getBookIdCmd.Parameters.AddWithValue("@id", borrowId)
            Dim bookId As Integer = CInt(getBookIdCmd.ExecuteScalar())

            ' update borrowed_books
            Dim updateBorrowedCmd As New MySqlCommand("UPDATE borrowed_books SET quantity_borrowed=quantity_borrowed-@q WHERE borrow_id=@id", conn)
            updateBorrowedCmd.Parameters.AddWithValue("@q", qtyToReturn)
            updateBorrowedCmd.Parameters.AddWithValue("@id", borrowId)
            updateBorrowedCmd.ExecuteNonQuery()

            ' update stock
            Dim updateBookCmd As New MySqlCommand("UPDATE books SET quantity=quantity+@q WHERE book_id=@bid", conn)
            updateBookCmd.Parameters.AddWithValue("@q", qtyToReturn)
            updateBookCmd.Parameters.AddWithValue("@bid", bookId)
            updateBookCmd.ExecuteNonQuery()

            ' delete record if nothing left
            Dim deleteCmd As New MySqlCommand("DELETE FROM borrowed_books WHERE borrow_id=@id AND quantity_borrowed<=0", conn)
            deleteCmd.Parameters.AddWithValue("@id", borrowId)
            deleteCmd.ExecuteNonQuery()

            MessageBox.Show("Return successful!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        conn.Close()

        LoadAvailableBooks()
        LoadBorrowedBooks()
    End Sub

    ' ✅ Search books
    Private Sub btnSearchBooks_Click(sender As Object, e As EventArgs) Handles btnSearchBooks.Click
        LoadAvailableBooks(txtSearchBooks.Text)
    End Sub

    ' ✅ Logout
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        ' go back to login control
        Dim parentForm = Me.FindForm()
        If parentForm IsNot Nothing AndAlso TypeOf parentForm Is Panel Then
            CType(parentForm, Panel).LoadControl(New LoginCtrl())
        End If
    End Sub
End Class
