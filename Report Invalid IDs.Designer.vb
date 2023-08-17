<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Invalid_IDs
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.lblDisplayDetail = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(100, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Report Invalid ID :"
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Location = New System.Drawing.Point(97, 115)
        Me.lblBookID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(52, 13)
        Me.lblBookID.TabIndex = 10
        Me.lblBookID.Text = "Book ID :"
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(163, 115)
        Me.txtBookID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(100, 20)
        Me.txtBookID.TabIndex = 11
        '
        'lblDetail
        '
        Me.lblDetail.AutoSize = True
        Me.lblDetail.Location = New System.Drawing.Point(97, 163)
        Me.lblDetail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(40, 13)
        Me.lblDetail.TabIndex = 12
        Me.lblDetail.Text = "Detail :"
        '
        'lblDisplayDetail
        '
        Me.lblDisplayDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayDetail.Location = New System.Drawing.Point(141, 163)
        Me.lblDisplayDetail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplayDetail.Name = "lblDisplayDetail"
        Me.lblDisplayDetail.Size = New System.Drawing.Size(102, 129)
        Me.lblDisplayDetail.TabIndex = 13
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(310, 163)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(56, 27)
        Me.btnCheck.TabIndex = 14
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(310, 205)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(56, 27)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(310, 247)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 27)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(310, 290)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 27)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Report_Invalid_IDs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblDisplayDetail)
        Me.Controls.Add(Me.lblDetail)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.lblBookID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Report_Invalid_IDs"
        Me.Text = "Report_Invalid_IDs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents lblDetail As Label
    Friend WithEvents lblDisplayDetail As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
End Class
