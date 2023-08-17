<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Return_Book
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
        Me.lblPenaltyDay = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblPenaltyAmount = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.lblPenalty = New System.Windows.Forms.Label()
        Me.btnCalculatePenalty = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.rb1D = New System.Windows.Forms.RadioButton()
        Me.rb2D = New System.Windows.Forms.RadioButton()
        Me.rbD3 = New System.Windows.Forms.RadioButton()
        Me.rbD4 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Location = New System.Drawing.Point(123, 92)
        Me.lblBookID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(114, 20)
        Me.lblBookID.TabIndex = 0
        Me.lblBookID.Text = "Enter Book ID:"
        '
        'lblPenaltyDay
        '
        Me.lblPenaltyDay.AutoSize = True
        Me.lblPenaltyDay.Location = New System.Drawing.Point(123, 189)
        Me.lblPenaltyDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPenaltyDay.Name = "lblPenaltyDay"
        Me.lblPenaltyDay.Size = New System.Drawing.Size(97, 20)
        Me.lblPenaltyDay.TabIndex = 1
        Me.lblPenaltyDay.Text = "Penalty Day:"
        Me.lblPenaltyDay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(123, 138)
        Me.lblStudentID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(134, 20)
        Me.lblStudentID.TabIndex = 2
        Me.lblStudentID.Text = "Enter Student ID:"
        '
        'lblPenaltyAmount
        '
        Me.lblPenaltyAmount.AutoSize = True
        Me.lblPenaltyAmount.Location = New System.Drawing.Point(123, 263)
        Me.lblPenaltyAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPenaltyAmount.Name = "lblPenaltyAmount"
        Me.lblPenaltyAmount.Size = New System.Drawing.Size(125, 20)
        Me.lblPenaltyAmount.TabIndex = 3
        Me.lblPenaltyAmount.Text = "Penalty Amount:"
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(304, 89)
        Me.txtBookID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(148, 26)
        Me.txtBookID.TabIndex = 4
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(304, 139)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(148, 26)
        Me.txtStudentID.TabIndex = 7
        '
        'lblPenalty
        '
        Me.lblPenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPenalty.Location = New System.Drawing.Point(304, 263)
        Me.lblPenalty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPenalty.Name = "lblPenalty"
        Me.lblPenalty.Size = New System.Drawing.Size(154, 34)
        Me.lblPenalty.TabIndex = 8
        '
        'btnCalculatePenalty
        '
        Me.btnCalculatePenalty.Location = New System.Drawing.Point(128, 331)
        Me.btnCalculatePenalty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalculatePenalty.Name = "btnCalculatePenalty"
        Me.btnCalculatePenalty.Size = New System.Drawing.Size(164, 62)
        Me.btnCalculatePenalty.TabIndex = 11
        Me.btnCalculatePenalty.Text = "Calculate Penalty"
        Me.btnCalculatePenalty.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(540, 331)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(164, 62)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(324, 331)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(164, 62)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'rb1D
        '
        Me.rb1D.AutoSize = True
        Me.rb1D.Location = New System.Drawing.Point(304, 185)
        Me.rb1D.Name = "rb1D"
        Me.rb1D.Size = New System.Drawing.Size(75, 24)
        Me.rb1D.TabIndex = 14
        Me.rb1D.TabStop = True
        Me.rb1D.Text = "1 Day"
        Me.rb1D.UseVisualStyleBackColor = True
        '
        'rb2D
        '
        Me.rb2D.AutoSize = True
        Me.rb2D.Location = New System.Drawing.Point(443, 185)
        Me.rb2D.Name = "rb2D"
        Me.rb2D.Size = New System.Drawing.Size(75, 24)
        Me.rb2D.TabIndex = 15
        Me.rb2D.TabStop = True
        Me.rb2D.Text = "2 Day"
        Me.rb2D.UseVisualStyleBackColor = True
        '
        'rbD3
        '
        Me.rbD3.AutoSize = True
        Me.rbD3.Location = New System.Drawing.Point(304, 215)
        Me.rbD3.Name = "rbD3"
        Me.rbD3.Size = New System.Drawing.Size(75, 24)
        Me.rbD3.TabIndex = 16
        Me.rbD3.TabStop = True
        Me.rbD3.Text = "3 Day"
        Me.rbD3.UseVisualStyleBackColor = True
        '
        'rbD4
        '
        Me.rbD4.AutoSize = True
        Me.rbD4.Location = New System.Drawing.Point(443, 215)
        Me.rbD4.Name = "rbD4"
        Me.rbD4.Size = New System.Drawing.Size(75, 24)
        Me.rbD4.TabIndex = 17
        Me.rbD4.TabStop = True
        Me.rbD4.Text = "4 Day"
        Me.rbD4.UseVisualStyleBackColor = True
        '
        'Return_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.rbD4)
        Me.Controls.Add(Me.rbD3)
        Me.Controls.Add(Me.rb2D)
        Me.Controls.Add(Me.rb1D)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculatePenalty)
        Me.Controls.Add(Me.lblPenalty)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.lblPenaltyAmount)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblPenaltyDay)
        Me.Controls.Add(Me.lblBookID)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Return_Book"
        Me.Text = "Return_Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBookID As Label
    Friend WithEvents lblPenaltyDay As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblPenaltyAmount As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents lblPenalty As Label
    Friend WithEvents btnCalculatePenalty As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents rb1D As RadioButton
    Friend WithEvents rb2D As RadioButton
    Friend WithEvents rbD3 As RadioButton
    Friend WithEvents rbD4 As RadioButton
End Class
