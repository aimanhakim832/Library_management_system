Public Class Check_Account
    Private Sub Check_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtStudentID.Text = ""
        rbStudent.Checked = False
        rbLibrarian.Checked = False
        rbM1Y.Checked = False
        rb1Y.Checked = False
        lblDisplayCheckAccount.Text = ""
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim Name, StudentID, Status, Active As String

        Name = txtName.Text
        StudentID = txtStudentID.Text

        If rbStudent.Checked = True Then
            Status = "Your are Student"
        Else
            Status = "Your are Librarian"
        End If

        If rbM1Y.Checked = True Then
            Active = "Your account not active"
        Else
            Active = "Your account is active"
        End If

        lblDisplayCheckAccount.Text = "Name: " & Name & vbNewLine &
                                      "Student ID: " & StudentID & vbNewLine &
                                      "Status: " & Active & vbNewLine &
                                      "User: " & Status & vbNewLine
    End Sub
End Class