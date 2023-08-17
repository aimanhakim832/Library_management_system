Public Class Report_Invalid_IDs
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim BookID As String

        BookID = txtBookID.Text

        lblDisplayDetail.Text = BookID

    End Sub
End Class