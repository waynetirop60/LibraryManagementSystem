Imports System.Data.SqlClient

Public Class Form1

    Dim connectionString As String = "Data Source=UNFAZED\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM Books"
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvBooks.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            connection.Open()
            Dim query As String = "INSERT INTO Books (Title, Author, YearPublished, Genre) VALUES (@Title, @Author, @YearPublished, @Genre)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Title", txtTitle.Text)
            command.Parameters.AddWithValue("@Author", txtAuthor.Text)
            command.Parameters.AddWithValue("@YearPublished", Convert.ToInt32(txtYearPublished.Text))
            command.Parameters.AddWithValue("@Genre", txtGenre.Text)
            command.ExecuteNonQuery()
            MessageBox.Show("Book added successfully.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE Books SET Title=@Title, Author=@Author, YearPublished=@YearPublished, Genre=@Genre WHERE ID=@ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvBooks.CurrentRow.Cells(0).Value))
            command.Parameters.AddWithValue("@Title", txtTitle.Text)
            command.Parameters.AddWithValue("@Author", txtAuthor.Text)
            command.Parameters.AddWithValue("@YearPublished", Convert.ToInt32(txtYearPublished.Text))
            command.Parameters.AddWithValue("@Genre", txtGenre.Text)
            command.ExecuteNonQuery()
            MessageBox.Show("Book updated successfully.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            connection.Open()
            Dim query As String = "DELETE FROM Books WHERE ID=@ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvBooks.CurrentRow.Cells(0).Value))
            command.ExecuteNonQuery()
            MessageBox.Show("Book deleted successfully.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTitle.Clear()
        txtAuthor.Clear()
        txtYearPublished.Clear()
        txtGenre.Clear()
    End Sub

    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBooks.Rows(e.RowIndex)
            txtTitle.Text = row.Cells(1).Value.ToString()
            txtAuthor.Text = row.Cells(2).Value.ToString()
            txtYearPublished.Text = row.Cells(3).Value.ToString()
            txtGenre.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

End Class
