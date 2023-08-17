Public Class Reserve_Book
    Private Sub btnERB_Click(sender As Object, e As EventArgs) Handles btnERB.Click
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub btnCRB_Click(sender As Object, e As EventArgs) Handles btnCRB.Click
        Dim BookID As String
        Dim StudentID As String
        Dim CurrentDate As String
        Dim ReturnDate As String

        BookID = txtBookID.Text
        StudentID = txtStudentID.Text
        CurrentDate = txtCurrentDate.Text
        ReturnDate = txtReturnDate.Text

        lblDisplayOutput.Text = "Book ID :" & BookID & vbNewLine &
                                "Student ID :" & StudentID & vbNewLine &
                                "Current Date :" & CurrentDate & vbNewLine &
                                "Return Date :" & ReturnDate & vbNewLine


    End Sub

    Private Sub btnRRB_Click(sender As Object, e As EventArgs) Handles btnRRB.Click
        txtBookID.Text = ""
        txtStudentID.Text = ""
        txtCurrentDate.Text = ""
        txtReturnDate.Text = ""
        lblDisplayOutput.Text = ""
    End Sub
End Class