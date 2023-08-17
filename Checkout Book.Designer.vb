<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout_Book
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
        Me.lblBorrowerName = New System.Windows.Forms.Label()
        Me.lblBorrowerID = New System.Windows.Forms.Label()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.txtBorrowerID = New System.Windows.Forms.TextBox()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAuthor1 = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTOB = New System.Windows.Forms.Label()
        Me.lblTittleOfBook = New System.Windows.Forms.Label()
        Me.lblGenre1 = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblDateOut1 = New System.Windows.Forms.Label()
        Me.lblDateOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBorrowerName
        '
        Me.lblBorrowerName.AutoSize = True
        Me.lblBorrowerName.Location = New System.Drawing.Point(88, 62)
        Me.lblBorrowerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBorrowerName.Name = "lblBorrowerName"
        Me.lblBorrowerName.Size = New System.Drawing.Size(86, 13)
        Me.lblBorrowerName.TabIndex = 2
        Me.lblBorrowerName.Text = "Borrower Name :"
        '
        'lblBorrowerID
        '
        Me.lblBorrowerID.AutoSize = True
        Me.lblBorrowerID.Location = New System.Drawing.Point(88, 94)
        Me.lblBorrowerID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBorrowerID.Name = "lblBorrowerID"
        Me.lblBorrowerID.Size = New System.Drawing.Size(89, 13)
        Me.lblBorrowerID.TabIndex = 3
        Me.lblBorrowerID.Text = "Borrower ID No. :"
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Location = New System.Drawing.Point(196, 59)
        Me.txtBorrowerName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(141, 20)
        Me.txtBorrowerName.TabIndex = 12
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.Location = New System.Drawing.Point(196, 94)
        Me.txtBorrowerID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.Size = New System.Drawing.Size(135, 20)
        Me.txtBorrowerID.TabIndex = 13
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(91, 142)
        Me.btnCheckout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(87, 35)
        Me.btnCheckout.TabIndex = 14
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(215, 142)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 35)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(156, 197)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 35)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAuthor1
        '
        Me.lblAuthor1.AutoSize = True
        Me.lblAuthor1.Location = New System.Drawing.Point(427, 62)
        Me.lblAuthor1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthor1.Name = "lblAuthor1"
        Me.lblAuthor1.Size = New System.Drawing.Size(44, 13)
        Me.lblAuthor1.TabIndex = 17
        Me.lblAuthor1.Text = "Author :"
        '
        'lblAuthor
        '
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.Location = New System.Drawing.Point(493, 54)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(76, 21)
        Me.lblAuthor.TabIndex = 18
        '
        'lblTOB
        '
        Me.lblTOB.AutoSize = True
        Me.lblTOB.Location = New System.Drawing.Point(407, 97)
        Me.lblTOB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTOB.Name = "lblTOB"
        Me.lblTOB.Size = New System.Drawing.Size(78, 13)
        Me.lblTOB.TabIndex = 19
        Me.lblTOB.Text = "Tittle Of Book :"
        '
        'lblTittleOfBook
        '
        Me.lblTittleOfBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTittleOfBook.Cursor = System.Windows.Forms.Cursors.No
        Me.lblTittleOfBook.Location = New System.Drawing.Point(494, 96)
        Me.lblTittleOfBook.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTittleOfBook.Name = "lblTittleOfBook"
        Me.lblTittleOfBook.Size = New System.Drawing.Size(75, 20)
        Me.lblTittleOfBook.TabIndex = 20
        '
        'lblGenre1
        '
        Me.lblGenre1.AutoSize = True
        Me.lblGenre1.Location = New System.Drawing.Point(443, 130)
        Me.lblGenre1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenre1.Name = "lblGenre1"
        Me.lblGenre1.Size = New System.Drawing.Size(42, 13)
        Me.lblGenre1.TabIndex = 21
        Me.lblGenre1.Text = "Genre :"
        '
        'lblGenre
        '
        Me.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGenre.Location = New System.Drawing.Point(494, 130)
        Me.lblGenre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(75, 20)
        Me.lblGenre.TabIndex = 22
        Me.lblGenre.Text = " "
        '
        'lblDateOut1
        '
        Me.lblDateOut1.AutoSize = True
        Me.lblDateOut1.Location = New System.Drawing.Point(427, 164)
        Me.lblDateOut1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateOut1.Name = "lblDateOut1"
        Me.lblDateOut1.Size = New System.Drawing.Size(56, 13)
        Me.lblDateOut1.TabIndex = 23
        Me.lblDateOut1.Text = "Date Out :"
        '
        'lblDateOut
        '
        Me.lblDateOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateOut.Location = New System.Drawing.Point(494, 163)
        Me.lblDateOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateOut.Name = "lblDateOut"
        Me.lblDateOut.Size = New System.Drawing.Size(76, 20)
        Me.lblDateOut.TabIndex = 24
        '
        'Checkout_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDateOut)
        Me.Controls.Add(Me.lblDateOut1)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblGenre1)
        Me.Controls.Add(Me.lblTittleOfBook)
        Me.Controls.Add(Me.lblTOB)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblAuthor1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.txtBorrowerID)
        Me.Controls.Add(Me.txtBorrowerName)
        Me.Controls.Add(Me.lblBorrowerID)
        Me.Controls.Add(Me.lblBorrowerName)
        Me.Name = "Checkout_Book"
        Me.Text = "Checkout_Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBorrowerName As Label
    Friend WithEvents lblBorrowerID As Label
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents txtBorrowerID As TextBox
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAuthor1 As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblTOB As Label
    Friend WithEvents lblTittleOfBook As Label
    Friend WithEvents lblGenre1 As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblDateOut1 As Label
    Friend WithEvents lblDateOut As Label
End Class
