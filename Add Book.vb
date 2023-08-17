Public Class Add_Book
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBookTitle.Text = ""
        txtBookAuthor.Text = ""
        txtBookPublisher.Text = ""
        txtShelfNo.Text = ""
        lblDisplayAddBook.Text = ""
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim BookTitle, BookAuthor, BookPublisher, ShelfNo As String

        BookTitle = txtBookTitle.Text
        BookAuthor = txtBookAuthor.Text
        BookPublisher = txtBookPublisher.Text
        ShelfNo = txtShelfNo.Text

        lblDisplayAddBook.Text = "This is your new information" & vbNewLine &
                                 "Book Title: " & BookTitle & vbNewLine &
                                 "Book Author: " & BookAuthor & vbNewLine &
                                 "Book Publisher: " & BookPublisher & vbNewLine &
                                 "Book Shelf No: " & ShelfNo & vbNewLine
    End Sub
End Class