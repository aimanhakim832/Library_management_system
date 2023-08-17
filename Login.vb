Public Class Login
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        MessageBox.Show("Login Successfully")
        Me.Hide()
        Main_Menu.Show()
        Dim lblName As String
        Dim lblStudentID As String

        lblName = txtName.Text
        lblStudentID = txtStudentID.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtStudentID.Text = ""
    End Sub
End Class