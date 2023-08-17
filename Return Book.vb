Public Class Return_Book
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtBookID.Text = ""
        txtStudentID.Text = ""
        txtPenaltyDay.Text = ""
        lblPenalty.Text = ""
    End Sub

    Private Sub btnCalculatePenalty_Click(sender As Object, e As EventArgs) Handles btnCalculatePenalty.Click
        Dim BookID, StudentID As String
        Dim Payment As Double
        Dim PenaltyDay As Integer
        BookID = txtBookID.Text
        StudentID = txtStudentID.Text
        PenaltyDay = txtPenaltyDay.Text

        If PenaltyDay = 1 Then
            Payment = 1.0 * 5
        End If
        If PenaltyDay = 2 Then
            Payment = 2.0 * 5
        End If
        If PenaltyDay = 3 Then
            Payment = 3.0 * 5
        End If

        lblPenalty.Text = Payment

    End Sub

    Private Sub Return_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPenaltyDay_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class