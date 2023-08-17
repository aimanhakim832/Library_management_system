<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Book
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
        Me.lblNewBook = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.lblShelfNo = New System.Windows.Forms.Label()
        Me.lblBookPublisher = New System.Windows.Forms.Label()
        Me.lblBookAuthor = New System.Windows.Forms.Label()
        Me.txtShelfNo = New System.Windows.Forms.TextBox()
        Me.txtBookPublisher = New System.Windows.Forms.TextBox()
        Me.txtBookAuthor = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDisplayAddBook = New System.Windows.Forms.Label()
        Me.lblList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNewBook
        '
        Me.lblNewBook.AutoSize = True
        Me.lblNewBook.Location = New System.Drawing.Point(145, 51)
        Me.lblNewBook.Name = "lblNewBook"
        Me.lblNewBook.Size = New System.Drawing.Size(57, 13)
        Me.lblNewBook.TabIndex = 0
        Me.lblNewBook.Text = "New Book"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Location = New System.Drawing.Point(80, 101)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(58, 13)
        Me.lblBookTitle.TabIndex = 1
        Me.lblBookTitle.Text = "Book Title:"
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(192, 101)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtBookTitle.TabIndex = 2
        '
        'lblShelfNo
        '
        Me.lblShelfNo.AutoSize = True
        Me.lblShelfNo.Location = New System.Drawing.Point(80, 202)
        Me.lblShelfNo.Name = "lblShelfNo"
        Me.lblShelfNo.Size = New System.Drawing.Size(51, 13)
        Me.lblShelfNo.TabIndex = 4
        Me.lblShelfNo.Text = "Shelf No:"
        '
        'lblBookPublisher
        '
        Me.lblBookPublisher.AutoSize = True
        Me.lblBookPublisher.Location = New System.Drawing.Point(80, 171)
        Me.lblBookPublisher.Name = "lblBookPublisher"
        Me.lblBookPublisher.Size = New System.Drawing.Size(81, 13)
        Me.lblBookPublisher.TabIndex = 5
        Me.lblBookPublisher.Text = "Book Publisher:"
        '
        'lblBookAuthor
        '
        Me.lblBookAuthor.AutoSize = True
        Me.lblBookAuthor.Location = New System.Drawing.Point(80, 139)
        Me.lblBookAuthor.Name = "lblBookAuthor"
        Me.lblBookAuthor.Size = New System.Drawing.Size(69, 13)
        Me.lblBookAuthor.TabIndex = 6
        Me.lblBookAuthor.Text = "Book Author:"
        '
        'txtShelfNo
        '
        Me.txtShelfNo.Location = New System.Drawing.Point(192, 202)
        Me.txtShelfNo.Name = "txtShelfNo"
        Me.txtShelfNo.Size = New System.Drawing.Size(100, 20)
        Me.txtShelfNo.TabIndex = 7
        '
        'txtBookPublisher
        '
        Me.txtBookPublisher.Location = New System.Drawing.Point(192, 168)
        Me.txtBookPublisher.Name = "txtBookPublisher"
        Me.txtBookPublisher.Size = New System.Drawing.Size(100, 20)
        Me.txtBookPublisher.TabIndex = 8
        '
        'txtBookAuthor
        '
        Me.txtBookAuthor.Location = New System.Drawing.Point(192, 139)
        Me.txtBookAuthor.Name = "txtBookAuthor"
        Me.txtBookAuthor.Size = New System.Drawing.Size(100, 20)
        Me.txtBookAuthor.TabIndex = 9
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(86, 245)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 10
        Me.btnAddNew.Text = "Add New "
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(286, 245)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(180, 245)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblDisplayAddBook
        '
        Me.lblDisplayAddBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayAddBook.Location = New System.Drawing.Point(410, 92)
        Me.lblDisplayAddBook.Name = "lblDisplayAddBook"
        Me.lblDisplayAddBook.Size = New System.Drawing.Size(203, 144)
        Me.lblDisplayAddBook.TabIndex = 13
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Location = New System.Drawing.Point(407, 69)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(26, 13)
        Me.lblList.TabIndex = 14
        Me.lblList.Text = "List:"
        '
        'Add_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.lblDisplayAddBook)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.txtBookAuthor)
        Me.Controls.Add(Me.txtBookPublisher)
        Me.Controls.Add(Me.txtShelfNo)
        Me.Controls.Add(Me.lblBookAuthor)
        Me.Controls.Add(Me.lblBookPublisher)
        Me.Controls.Add(Me.lblShelfNo)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.lblBookTitle)
        Me.Controls.Add(Me.lblNewBook)
        Me.Name = "Add_Book"
        Me.Text = "Add_Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewBook As Label
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents lblShelfNo As Label
    Friend WithEvents lblBookPublisher As Label
    Friend WithEvents lblBookAuthor As Label
    Friend WithEvents txtShelfNo As TextBox
    Friend WithEvents txtBookPublisher As TextBox
    Friend WithEvents txtBookAuthor As TextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblDisplayAddBook As Label
    Friend WithEvents lblList As Label
End Class
