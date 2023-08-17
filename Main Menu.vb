Public Class Main_Menu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        Me.Hide()
        Return_Book.Show()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Me.Hide()
        Add_Book.Show()
    End Sub

    Private Sub btnCheckoutBook_Click(sender As Object, e As EventArgs) Handles btnCheckoutBook.Click
        Me.Hide()
        Checkout_Book.Show()
    End Sub

    Private Sub btnReserveBook_Click(sender As Object, e As EventArgs) Handles btnReserveBook.Click
        Me.Hide()
        Reserve_Book.Show()
    End Sub

    Private Sub btnReportInvalidID_Click(sender As Object, e As EventArgs) Handles btnReportInvalidID.Click
        Me.Hide()
        Report_Invalid_IDs.Show()
    End Sub

    Private Sub btnRenewBook_Click(sender As Object, e As EventArgs) Handles btnRenewBook.Click
        Me.Hide()
        Renew_Book.Show()
    End Sub

    Private Sub btnCheckAccount_Click(sender As Object, e As EventArgs) Handles btnCheckAccount.Click
        Me.Hide()
        Check_Account.Show()
    End Sub

    Private Sub lblDisplaySID_Click(sender As Object, e As EventArgs) Handles lblDisplaySID.Click
        lblDisplaySID.Text = Login.txtStudentID.Text
    End Sub

    Private Sub lblDisplayName_Click(sender As Object, e As EventArgs) Handles lblDisplayName.Click
        lblDisplayName.Text = Login.txtName.Text
    End Sub
End Class