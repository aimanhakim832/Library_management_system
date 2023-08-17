<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reserve_Book
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
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.lblReturnDate = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.txtReturnDate = New System.Windows.Forms.TextBox()
        Me.txtCurrentDate = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.btnCRB = New System.Windows.Forms.Button()
        Me.btnERB = New System.Windows.Forms.Button()
        Me.btnRRB = New System.Windows.Forms.Button()
        Me.lblDisplayOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Location = New System.Drawing.Point(23, 53)
        Me.lblBookID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(118, 20)
        Me.lblBookID.TabIndex = 0
        Me.lblBookID.Text = "Enter Book ID: "
        '
        'lblReturnDate
        '
        Me.lblReturnDate.AutoSize = True
        Me.lblReturnDate.Location = New System.Drawing.Point(22, 166)
        Me.lblReturnDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReturnDate.Name = "lblReturnDate"
        Me.lblReturnDate.Size = New System.Drawing.Size(101, 20)
        Me.lblReturnDate.TabIndex = 2
        Me.lblReturnDate.Text = "Return Date:"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Location = New System.Drawing.Point(22, 124)
        Me.lblCurrentDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(105, 20)
        Me.lblCurrentDate.TabIndex = 3
        Me.lblCurrentDate.Text = "Current Date:"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(23, 86)
        Me.lblStudentID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(134, 20)
        Me.lblStudentID.TabIndex = 4
        Me.lblStudentID.Text = "Enter Student ID:"
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(198, 47)
        Me.txtBookID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(148, 26)
        Me.txtBookID.TabIndex = 5
        '
        'txtReturnDate
        '
        Me.txtReturnDate.Location = New System.Drawing.Point(198, 166)
        Me.txtReturnDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReturnDate.Name = "txtReturnDate"
        Me.txtReturnDate.Size = New System.Drawing.Size(148, 26)
        Me.txtReturnDate.TabIndex = 6
        '
        'txtCurrentDate
        '
        Me.txtCurrentDate.Location = New System.Drawing.Point(198, 124)
        Me.txtCurrentDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCurrentDate.Name = "txtCurrentDate"
        Me.txtCurrentDate.Size = New System.Drawing.Size(148, 26)
        Me.txtCurrentDate.TabIndex = 8
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(198, 83)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(148, 26)
        Me.txtStudentID.TabIndex = 9
        '
        'btnCRB
        '
        Me.btnCRB.Location = New System.Drawing.Point(26, 203)
        Me.btnCRB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCRB.Name = "btnCRB"
        Me.btnCRB.Size = New System.Drawing.Size(97, 43)
        Me.btnCRB.TabIndex = 10
        Me.btnCRB.Text = "Calculate "
        Me.btnCRB.UseVisualStyleBackColor = True
        '
        'btnERB
        '
        Me.btnERB.Location = New System.Drawing.Point(240, 202)
        Me.btnERB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnERB.Name = "btnERB"
        Me.btnERB.Size = New System.Drawing.Size(101, 43)
        Me.btnERB.TabIndex = 11
        Me.btnERB.Text = "Exit  "
        Me.btnERB.UseVisualStyleBackColor = True
        '
        'btnRRB
        '
        Me.btnRRB.Location = New System.Drawing.Point(131, 202)
        Me.btnRRB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRRB.Name = "btnRRB"
        Me.btnRRB.Size = New System.Drawing.Size(101, 43)
        Me.btnRRB.TabIndex = 12
        Me.btnRRB.Text = "Reset  "
        Me.btnRRB.UseVisualStyleBackColor = True
        '
        'lblDisplayOutput
        '
        Me.lblDisplayOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayOutput.Location = New System.Drawing.Point(27, 251)
        Me.lblDisplayOutput.Name = "lblDisplayOutput"
        Me.lblDisplayOutput.Size = New System.Drawing.Size(319, 102)
        Me.lblDisplayOutput.TabIndex = 13
        Me.lblDisplayOutput.Text = " "
        '
        'Reserve_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 378)
        Me.Controls.Add(Me.lblDisplayOutput)
        Me.Controls.Add(Me.btnRRB)
        Me.Controls.Add(Me.btnERB)
        Me.Controls.Add(Me.btnCRB)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtCurrentDate)
        Me.Controls.Add(Me.txtReturnDate)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblReturnDate)
        Me.Controls.Add(Me.lblBookID)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Reserve_Book"
        Me.Text = "Reserve_Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBookID As Label
    Friend WithEvents lblReturnDate As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtReturnDate As TextBox
    Friend WithEvents txtCurrentDate As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnCRB As Button
    Friend WithEvents btnERB As Button
    Friend WithEvents btnRRB As Button
    Friend WithEvents lblDisplayOutput As Label
End Class
