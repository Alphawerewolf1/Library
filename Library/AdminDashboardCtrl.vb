Imports MySql.Data.MySqlClient

Public Class AdminDashboardCtrl
    Inherits UserControl

    Public username As String  ' passed from login for display

    Private Sub AdminDashboardCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginlbl.Text = "Welcome, " & username
        LoadBooks()
    End Sub

    ' ✅ Load all books with author name
    Private Sub LoadBooks()
        Connect()
        Dim query As String = "SELECT b.book_id, b.title, a.name AS author, b.isbn, b.genre, b.quantity " &
                              "FROM books b " &
                              "LEFT JOIN authors a ON b.author_id = a.author_id"
        Dim da As New MySqlDataAdapter(query, conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvBooks.DataSource = dt
        conn.Close()
    End Sub

    ' 🔹 Get or create author_id
    Private Function GetAuthorId(authorName As String) As Integer
        Dim authorId As Integer = -1
        Dim cmd As New MySqlCommand("SELECT author_id FROM authors WHERE name=@name", conn)
        cmd.Parameters.AddWithValue("@name", authorName)
        Dim result = cmd.ExecuteScalar()
        If result IsNot Nothing Then
            authorId = Convert.ToInt32(result)
        Else
            ' Insert new author
            Dim insertCmd As New MySqlCommand("INSERT INTO authors (name) VALUES (@name); SELECT LAST_INSERT_ID();", conn)
            insertCmd.Parameters.AddWithValue("@name", authorName)
            authorId = Convert.ToInt32(insertCmd.ExecuteScalar())
        End If
        Return authorId
    End Function

    ' ✅ Add new book
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Connect()
            Dim authorId As Integer = GetAuthorId(txtAuthor.Text)

            Dim query As String = "INSERT INTO books (title, author_id, isbn, genre, quantity) VALUES (@t,@a,@i,@g,@q)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@t", txtTitle.Text)
            cmd.Parameters.AddWithValue("@a", authorId)
            cmd.Parameters.AddWithValue("@i", txtISBN.Text)
            cmd.Parameters.AddWithValue("@g", txtGenre.Text)
            cmd.Parameters.AddWithValue("@q", CInt(numQuantity.Value))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book added successfully!")
            conn.Close()
            LoadBooks()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ✅ Update existing book
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Connect()
            Dim authorId As Integer = GetAuthorId(txtAuthor.Text)

            Dim query As String = "UPDATE books SET title=@t, author_id=@a, isbn=@i, genre=@g, quantity=@q WHERE book_id=@id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@t", txtTitle.Text)
            cmd.Parameters.AddWithValue("@a", authorId)
            cmd.Parameters.AddWithValue("@i", txtISBN.Text)
            cmd.Parameters.AddWithValue("@g", txtGenre.Text)
            cmd.Parameters.AddWithValue("@q", CInt(numQuantity.Value))
            cmd.Parameters.AddWithValue("@id", txtBookID.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book updated!")
            conn.Close()
            LoadBooks()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ✅ Delete book
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Connect()
            Dim query As String = "DELETE FROM books WHERE book_id=@id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", txtBookID.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book deleted!")
            conn.Close()
            LoadBooks()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ✅ Search books (with author name)
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Connect()
            Dim query As String = "SELECT b.book_id, b.title, a.name AS author, b.isbn, b.genre, b.quantity " &
                                  "FROM books b " &
                                  "LEFT JOIN authors a ON b.author_id = a.author_id " &
                                  "WHERE b.title LIKE @s OR a.name LIKE @s OR b.isbn LIKE @s OR b.genre LIKE @s"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@s", "%" & txtSearch.Text & "%")
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvBooks.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ✅ Populate fields from DataGridView row
    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBooks.Rows(e.RowIndex)
            txtBookID.Text = row.Cells("book_id").Value.ToString()
            txtTitle.Text = row.Cells("title").Value.ToString()
            txtAuthor.Text = row.Cells("author").Value.ToString()
            txtISBN.Text = row.Cells("isbn").Value.ToString()
            txtGenre.Text = row.Cells("genre").Value.ToString()
            numQuantity.Value = CDec(row.Cells("quantity").Value)
        End If
    End Sub
End Class
