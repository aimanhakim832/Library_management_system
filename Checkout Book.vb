Public Class Checkout_Book
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim lblBorrowerName As String
        Dim lblBorrowerID As Integer

        lblBorrowerName = txtBorrowerName.Text
        lblBorrowerID = txtBorrowerID.Text

        Dim lblAuthor As String
        Dim lblTittleOfBook As String
        Dim lblGenre As String
        Dim lblDateOut As Integer
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Main_Menu.Show()
    End Sub
End Class