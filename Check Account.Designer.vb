<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Check_Account
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAccountUser = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblLastLogin = New System.Windows.Forms.Label()
        Me.rbStudent = New System.Windows.Forms.RadioButton()
        Me.rb1Y = New System.Windows.Forms.RadioButton()
        Me.rbM1Y = New System.Windows.Forms.RadioButton()
        Me.rbLibrarian = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDisplayCheckAccount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(91, 65)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblAccountUser
        '
        Me.lblAccountUser.AutoSize = True
        Me.lblAccountUser.Location = New System.Drawing.Point(91, 120)
        Me.lblAccountUser.Name = "lblAccountUser"
        Me.lblAccountUser.Size = New System.Drawing.Size(75, 13)
        Me.lblAccountUser.TabIndex = 1
        Me.lblAccountUser.Text = "Account User:"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(91, 92)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(61, 13)
        Me.lblStudentID.TabIndex = 2
        Me.lblStudentID.Text = "Student ID:"
        '
        'lblLastLogin
        '
        Me.lblLastLogin.AutoSize = True
        Me.lblLastLogin.Location = New System.Drawing.Point(91, 177)
        Me.lblLastLogin.Name = "lblLastLogin"
        Me.lblLastLogin.Size = New System.Drawing.Size(59, 13)
        Me.lblLastLogin.TabIndex = 3
        Me.lblLastLogin.Text = "Last Login:"
        '
        'rbStudent
        '
        Me.rbStudent.AutoSize = True
        Me.rbStudent.Location = New System.Drawing.Point(172, 120)
        Me.rbStudent.Name = "rbStudent"
        Me.rbStudent.Size = New System.Drawing.Size(62, 17)
        Me.rbStudent.TabIndex = 4
        Me.rbStudent.TabStop = True
        Me.rbStudent.Text = "Student"
        Me.rbStudent.UseVisualStyleBackColor = True
        '
        'rb1Y
        '
        Me.rb1Y.AutoSize = True
        Me.rb1Y.Location = New System.Drawing.Point(172, 200)
        Me.rb1Y.Name = "rb1Y"
        Me.rb1Y.Size = New System.Drawing.Size(65, 17)
        Me.rb1Y.TabIndex = 6
        Me.rb1Y.TabStop = True
        Me.rb1Y.Text = "< 1 Year"
        Me.rb1Y.UseVisualStyleBackColor = True
        '
        'rbM1Y
        '
        Me.rbM1Y.AutoSize = True
        Me.rbM1Y.Location = New System.Drawing.Point(172, 177)
        Me.rbM1Y.Name = "rbM1Y"
        Me.rbM1Y.Size = New System.Drawing.Size(65, 17)
        Me.rbM1Y.TabIndex = 7
        Me.rbM1Y.TabStop = True
        Me.rbM1Y.Text = "> 1 Year"
        Me.rbM1Y.UseVisualStyleBackColor = True
        '
        'rbLibrarian
        '
        Me.rbLibrarian.AutoSize = True
        Me.rbLibrarian.Location = New System.Drawing.Point(172, 143)
        Me.rbLibrarian.Name = "rbLibrarian"
        Me.rbLibrarian.Size = New System.Drawing.Size(65, 17)
        Me.rbLibrarian.TabIndex = 8
        Me.rbLibrarian.TabStop = True
        Me.rbLibrarian.Text = "Librarian"
        Me.rbLibrarian.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(172, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(123, 20)
        Me.txtName.TabIndex = 9
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(172, 94)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(123, 20)
        Me.txtStudentID.TabIndex = 10
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(348, 55)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 11
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(348, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(348, 84)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblDisplayCheckAccount
        '
        Me.lblDisplayCheckAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayCheckAccount.Location = New System.Drawing.Point(94, 220)
        Me.lblDisplayCheckAccount.Name = "lblDisplayCheckAccount"
        Me.lblDisplayCheckAccount.Size = New System.Drawing.Size(188, 89)
        Me.lblDisplayCheckAccount.TabIndex = 14
        '
        'Check_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDisplayCheckAccount)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.rbLibrarian)
        Me.Controls.Add(Me.rbM1Y)
        Me.Controls.Add(Me.rb1Y)
        Me.Controls.Add(Me.rbStudent)
        Me.Controls.Add(Me.lblLastLogin)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblAccountUser)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Check_Account"
        Me.Text = "Check_Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAccountUser As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblLastLogin As Label
    Friend WithEvents rbStudent As RadioButton
    Friend WithEvents rb1Y As RadioButton
    Friend WithEvents rbM1Y As RadioButton
    Friend WithEvents rbLibrarian As RadioButton
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblDisplayCheckAccount As Label
End Class
