<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Txtbox_search = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbox_copies = New System.Windows.Forms.TextBox()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.txtbox_author = New System.Windows.Forms.TextBox()
        Me.txtbox_title = New System.Windows.Forms.TextBox()
        Me.Txtbox_category = New System.Windows.Forms.TextBox()
        Me.lbl_bkid = New System.Windows.Forms.Label()
        Me.lbl_noc = New System.Windows.Forms.Label()
        Me.lbl_author = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lb_bookid = New System.Windows.Forms.Label()
        Me.txtbx_cop1 = New System.Windows.Forms.TextBox()
        Me.txtbx_aut1 = New System.Windows.Forms.TextBox()
        Me.txtbx_tit1 = New System.Windows.Forms.TextBox()
        Me.txtbx_cat1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_bkid2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_edit = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1041, 37)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(37, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Add Books"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(467, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventory of Books"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(335, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "List of Books with Maintenance"
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(32, 340)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(49, 23)
        Me.btn_back.TabIndex = 18
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(306, 68)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(453, 247)
        Me.ListView1.TabIndex = 19
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Book_ID"
        Me.ColumnHeader1.Width = 67
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Category"
        Me.ColumnHeader2.Width = 73
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Title"
        Me.ColumnHeader3.Width = 97
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Author"
        Me.ColumnHeader4.Width = 142
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Copies"
        Me.ColumnHeader5.Width = 67
        '
        'Txtbox_search
        '
        Me.Txtbox_search.Location = New System.Drawing.Point(393, 329)
        Me.Txtbox_search.Name = "Txtbox_search"
        Me.Txtbox_search.Size = New System.Drawing.Size(340, 20)
        Me.Txtbox_search.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Search Title:"
        '
        'txtbox_copies
        '
        Me.txtbox_copies.Location = New System.Drawing.Point(138, 173)
        Me.txtbox_copies.Name = "txtbox_copies"
        Me.txtbox_copies.Size = New System.Drawing.Size(105, 20)
        Me.txtbox_copies.TabIndex = 36
        '
        'lbl_category
        '
        Me.lbl_category.AutoSize = True
        Me.lbl_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category.Location = New System.Drawing.Point(20, 96)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(61, 13)
        Me.lbl_category.TabIndex = 35
        Me.lbl_category.Text = "Category:"
        '
        'txtbox_author
        '
        Me.txtbox_author.Location = New System.Drawing.Point(94, 147)
        Me.txtbox_author.Name = "txtbox_author"
        Me.txtbox_author.Size = New System.Drawing.Size(124, 20)
        Me.txtbox_author.TabIndex = 34
        '
        'txtbox_title
        '
        Me.txtbox_title.Location = New System.Drawing.Point(94, 122)
        Me.txtbox_title.Name = "txtbox_title"
        Me.txtbox_title.Size = New System.Drawing.Size(124, 20)
        Me.txtbox_title.TabIndex = 33
        '
        'Txtbox_category
        '
        Me.Txtbox_category.Location = New System.Drawing.Point(94, 96)
        Me.Txtbox_category.Name = "Txtbox_category"
        Me.Txtbox_category.Size = New System.Drawing.Size(124, 20)
        Me.Txtbox_category.TabIndex = 32
        '
        'lbl_bkid
        '
        Me.lbl_bkid.AutoSize = True
        Me.lbl_bkid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bkid.Location = New System.Drawing.Point(21, 68)
        Me.lbl_bkid.Name = "lbl_bkid"
        Me.lbl_bkid.Size = New System.Drawing.Size(60, 13)
        Me.lbl_bkid.TabIndex = 31
        Me.lbl_bkid.Text = "Book_ID:"
        '
        'lbl_noc
        '
        Me.lbl_noc.AutoSize = True
        Me.lbl_noc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noc.Location = New System.Drawing.Point(21, 176)
        Me.lbl_noc.Name = "lbl_noc"
        Me.lbl_noc.Size = New System.Drawing.Size(111, 13)
        Me.lbl_noc.TabIndex = 30
        Me.lbl_noc.Text = "Number of Copies:"
        '
        'lbl_author
        '
        Me.lbl_author.AutoSize = True
        Me.lbl_author.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_author.Location = New System.Drawing.Point(21, 147)
        Me.lbl_author.Name = "lbl_author"
        Me.lbl_author.Size = New System.Drawing.Size(48, 13)
        Me.lbl_author.TabIndex = 29
        Me.lbl_author.Text = "Author:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(21, 122)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(36, 13)
        Me.lbl_title.TabIndex = 28
        Me.lbl_title.Text = "Title:"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(32, 228)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(76, 42)
        Me.btn_add.TabIndex = 37
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.lb_bookid)
        Me.Panel2.Controls.Add(Me.txtbx_cop1)
        Me.Panel2.Controls.Add(Me.txtbx_aut1)
        Me.Panel2.Controls.Add(Me.txtbx_tit1)
        Me.Panel2.Controls.Add(Me.txtbx_cat1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lbl_bkid2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lbl_edit)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Location = New System.Drawing.Point(765, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(265, 289)
        Me.Panel2.TabIndex = 34
        '
        'lb_bookid
        '
        Me.lb_bookid.AutoSize = True
        Me.lb_bookid.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bookid.Location = New System.Drawing.Point(9, 57)
        Me.lb_bookid.Name = "lb_bookid"
        Me.lb_bookid.Size = New System.Drawing.Size(57, 15)
        Me.lb_bookid.TabIndex = 42
        Me.lb_bookid.Text = "Book_ID:"
        '
        'txtbx_cop1
        '
        Me.txtbx_cop1.Location = New System.Drawing.Point(127, 162)
        Me.txtbx_cop1.Name = "txtbx_cop1"
        Me.txtbx_cop1.Size = New System.Drawing.Size(105, 20)
        Me.txtbx_cop1.TabIndex = 41
        '
        'txtbx_aut1
        '
        Me.txtbx_aut1.Location = New System.Drawing.Point(76, 133)
        Me.txtbx_aut1.Name = "txtbx_aut1"
        Me.txtbx_aut1.Size = New System.Drawing.Size(124, 20)
        Me.txtbx_aut1.TabIndex = 40
        '
        'txtbx_tit1
        '
        Me.txtbx_tit1.Location = New System.Drawing.Point(76, 108)
        Me.txtbx_tit1.Name = "txtbx_tit1"
        Me.txtbx_tit1.Size = New System.Drawing.Size(124, 20)
        Me.txtbx_tit1.TabIndex = 39
        '
        'txtbx_cat1
        '
        Me.txtbx_cat1.Location = New System.Drawing.Point(76, 82)
        Me.txtbx_cat1.Name = "txtbx_cat1"
        Me.txtbx_cat1.Size = New System.Drawing.Size(124, 20)
        Me.txtbx_cat1.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Category:"
        '
        'lbl_bkid2
        '
        Me.lbl_bkid2.AutoSize = True
        Me.lbl_bkid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bkid2.Location = New System.Drawing.Point(73, 57)
        Me.lbl_bkid2.Name = "lbl_bkid2"
        Me.lbl_bkid2.Size = New System.Drawing.Size(0, 13)
        Me.lbl_bkid2.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Number of Copies:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Author:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Title:"
        '
        'lbl_edit
        '
        Me.lbl_edit.AutoSize = True
        Me.lbl_edit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edit.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_edit.Location = New System.Drawing.Point(9, 12)
        Me.lbl_edit.Name = "lbl_edit"
        Me.lbl_edit.Size = New System.Drawing.Size(78, 17)
        Me.lbl_edit.TabIndex = 0
        Me.lbl_edit.Text = "Edit Here:"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(95, 226)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 42)
        Me.btn_save.TabIndex = 32
        Me.btn_save.Text = "Save Update"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(123, 228)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(78, 42)
        Me.btn_update.TabIndex = 43
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 375)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txtbox_copies)
        Me.Controls.Add(Me.lbl_category)
        Me.Controls.Add(Me.txtbox_author)
        Me.Controls.Add(Me.txtbox_title)
        Me.Controls.Add(Me.Txtbox_category)
        Me.Controls.Add(Me.lbl_bkid)
        Me.Controls.Add(Me.lbl_noc)
        Me.Controls.Add(Me.lbl_author)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txtbox_search)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "inventory"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Txtbox_search As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtbox_copies As System.Windows.Forms.TextBox
    Friend WithEvents lbl_category As System.Windows.Forms.Label
    Friend WithEvents txtbox_author As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_title As System.Windows.Forms.TextBox
    Friend WithEvents Txtbox_category As System.Windows.Forms.TextBox
    Friend WithEvents lbl_bkid As System.Windows.Forms.Label
    Friend WithEvents lbl_noc As System.Windows.Forms.Label
    Friend WithEvents lbl_author As System.Windows.Forms.Label
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lb_bookid As System.Windows.Forms.Label
    Friend WithEvents txtbx_cop1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx_aut1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx_tit1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx_cat1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_bkid2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_edit As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
End Class
