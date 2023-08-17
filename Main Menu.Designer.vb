<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Me.label = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblDisplayName = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblDisplaySID = New System.Windows.Forms.Label()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnCheckoutBook = New System.Windows.Forms.Button()
        Me.btnReserveBook = New System.Windows.Forms.Button()
        Me.btnReportInvalidID = New System.Windows.Forms.Button()
        Me.btnRenewBook = New System.Windows.Forms.Button()
        Me.btnCheckAccount = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(127, 38)
        Me.label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(263, 27)
        Me.label.TabIndex = 1
        Me.label.Text = "Welcome to KPMSI Library Management"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(141, 88)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Name :"
        '
        'lblDisplayName
        '
        Me.lblDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayName.Location = New System.Drawing.Point(186, 87)
        Me.lblDisplayName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(184, 18)
        Me.lblDisplayName.TabIndex = 9
        Me.lblDisplayName.Text = " "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(118, 119)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Student ID :"
        '
        'lblDisplaySID
        '
        Me.lblDisplaySID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplaySID.Location = New System.Drawing.Point(186, 119)
        Me.lblDisplaySID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplaySID.Name = "lblDisplaySID"
        Me.lblDisplaySID.Size = New System.Drawing.Size(184, 19)
        Me.lblDisplaySID.TabIndex = 11
        Me.lblDisplaySID.Text = " "
        '
        'btnReturnBook
        '
        Me.btnReturnBook.Location = New System.Drawing.Point(121, 171)
        Me.btnReturnBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(91, 42)
        Me.btnReturnBook.TabIndex = 12
        Me.btnReturnBook.Text = "Return Book"
        Me.btnReturnBook.UseVisualStyleBackColor = True
        '
        'btnAddBook
        '
        Me.btnAddBook.Location = New System.Drawing.Point(238, 171)
        Me.btnAddBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(91, 42)
        Me.btnAddBook.TabIndex = 13
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'btnCheckoutBook
        '
        Me.btnCheckoutBook.Location = New System.Drawing.Point(358, 171)
        Me.btnCheckoutBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckoutBook.Name = "btnCheckoutBook"
        Me.btnCheckoutBook.Size = New System.Drawing.Size(91, 42)
        Me.btnCheckoutBook.TabIndex = 14
        Me.btnCheckoutBook.Text = "Checkout Book"
        Me.btnCheckoutBook.UseVisualStyleBackColor = True
        '
        'btnReserveBook
        '
        Me.btnReserveBook.Location = New System.Drawing.Point(80, 238)
        Me.btnReserveBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReserveBook.Name = "btnReserveBook"
        Me.btnReserveBook.Size = New System.Drawing.Size(91, 42)
        Me.btnReserveBook.TabIndex = 15
        Me.btnReserveBook.Text = "Reserve Book"
        Me.btnReserveBook.UseVisualStyleBackColor = True
        '
        'btnReportInvalidID
        '
        Me.btnReportInvalidID.Location = New System.Drawing.Point(186, 238)
        Me.btnReportInvalidID.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReportInvalidID.Name = "btnReportInvalidID"
        Me.btnReportInvalidID.Size = New System.Drawing.Size(91, 42)
        Me.btnReportInvalidID.TabIndex = 16
        Me.btnReportInvalidID.Text = "Report Invalid ID"
        Me.btnReportInvalidID.UseVisualStyleBackColor = True
        '
        'btnRenewBook
        '
        Me.btnRenewBook.Location = New System.Drawing.Point(299, 238)
        Me.btnRenewBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRenewBook.Name = "btnRenewBook"
        Me.btnRenewBook.Size = New System.Drawing.Size(91, 42)
        Me.btnRenewBook.TabIndex = 17
        Me.btnRenewBook.Text = "Renew Book"
        Me.btnRenewBook.UseVisualStyleBackColor = True
        '
        'btnCheckAccount
        '
        Me.btnCheckAccount.Location = New System.Drawing.Point(408, 238)
        Me.btnCheckAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckAccount.Name = "btnCheckAccount"
        Me.btnCheckAccount.Size = New System.Drawing.Size(91, 42)
        Me.btnCheckAccount.TabIndex = 18
        Me.btnCheckAccount.Text = "Check Account"
        Me.btnCheckAccount.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(259, 293)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 42)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCheckAccount)
        Me.Controls.Add(Me.btnRenewBook)
        Me.Controls.Add(Me.btnReportInvalidID)
        Me.Controls.Add(Me.btnReserveBook)
        Me.Controls.Add(Me.btnCheckoutBook)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.lblDisplaySID)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.lblDisplayName)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label)
        Me.Name = "Main_Menu"
        Me.Text = "Main_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label As Label
    Friend WithEvents label1 As Label
    Friend WithEvents lblDisplayName As Label
    Friend WithEvents label2 As Label
    Friend WithEvents lblDisplaySID As Label
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnCheckoutBook As Button
    Friend WithEvents btnReserveBook As Button
    Friend WithEvents btnReportInvalidID As Button
    Friend WithEvents btnRenewBook As Button
    Friend WithEvents btnCheckAccount As Button
    Friend WithEvents btnExit As Button
End Class
