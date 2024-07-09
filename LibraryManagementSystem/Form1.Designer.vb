<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblYearPublished = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtYearPublished = New System.Windows.Forms.TextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(63, 46)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(38, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(63, 87)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(57, 20)
        Me.lblAuthor.TabIndex = 1
        Me.lblAuthor.Text = "Author"
        '
        'lblYearPublished
        '
        Me.lblYearPublished.AutoSize = True
        Me.lblYearPublished.Location = New System.Drawing.Point(63, 122)
        Me.lblYearPublished.Name = "lblYearPublished"
        Me.lblYearPublished.Size = New System.Drawing.Size(116, 20)
        Me.lblYearPublished.TabIndex = 2
        Me.lblYearPublished.Text = "Year Published"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(63, 162)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(54, 20)
        Me.lblGenre.TabIndex = 3
        Me.lblGenre.Text = "Genre"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(267, 43)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 26)
        Me.txtTitle.TabIndex = 4
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(267, 87)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(100, 26)
        Me.txtAuthor.TabIndex = 5
        '
        'txtYearPublished
        '
        Me.txtYearPublished.Location = New System.Drawing.Point(267, 122)
        Me.txtYearPublished.Name = "txtYearPublished"
        Me.txtYearPublished.Size = New System.Drawing.Size(100, 26)
        Me.txtYearPublished.TabIndex = 6
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(267, 162)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(100, 26)
        Me.txtGenre.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(423, 24)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 31)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(423, 71)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 36)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(423, 124)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(423, 176)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dgvBooks
        '
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Location = New System.Drawing.Point(43, 235)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.RowHeadersWidth = 62
        Me.dgvBooks.RowTemplate.Height = 28
        Me.dgvBooks.Size = New System.Drawing.Size(726, 119)
        Me.dgvBooks.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.txtYearPublished)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblYearPublished)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblYearPublished As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvBooks As DataGridView
End Class
