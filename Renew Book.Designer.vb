<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Renew_Book
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAAB = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblList = New System.Windows.Forms.Label()
        Me.lblDisplayRenewBook = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(98, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Renew Book"
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Location = New System.Drawing.Point(95, 97)
        Me.lblBookID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(52, 13)
        Me.lblBookID.TabIndex = 2
        Me.lblBookID.Text = "Book ID :"
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(170, 94)
        Me.txtBookID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(101, 20)
        Me.txtBookID.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(332, 94)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 38)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAAB
        '
        Me.btnAAB.Location = New System.Drawing.Point(332, 153)
        Me.btnAAB.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAAB.Name = "btnAAB"
        Me.btnAAB.Size = New System.Drawing.Size(78, 38)
        Me.btnAAB.TabIndex = 6
        Me.btnAAB.Text = "Add Another Book"
        Me.btnAAB.UseMnemonic = False
        Me.btnAAB.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(332, 206)
        Me.btnBorrow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(78, 38)
        Me.btnBorrow.TabIndex = 7
        Me.btnBorrow.Text = "Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(332, 257)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 38)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Location = New System.Drawing.Point(95, 131)
        Me.lblList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(26, 13)
        Me.lblList.TabIndex = 10
        Me.lblList.Text = "List:"
        '
        'lblDisplayRenewBook
        '
        Me.lblDisplayRenewBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayRenewBook.Location = New System.Drawing.Point(95, 153)
        Me.lblDisplayRenewBook.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplayRenewBook.Name = "lblDisplayRenewBook"
        Me.lblDisplayRenewBook.Size = New System.Drawing.Size(190, 142)
        Me.lblDisplayRenewBook.TabIndex = 11
        '
        'Renew_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDisplayRenewBook)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnAAB)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.lblBookID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Renew_Book"
        Me.Text = "Renew_Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAAB As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblList As Label
    Friend WithEvents lblDisplayRenewBook As Label
End Class
