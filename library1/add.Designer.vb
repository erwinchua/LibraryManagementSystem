<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add
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
        Me.Llbl_edit_yel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_add = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_author = New System.Windows.Forms.Label()
        Me.lbl_noc = New System.Windows.Forms.Label()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Txtbox_category = New System.Windows.Forms.TextBox()
        Me.txtbox_title = New System.Windows.Forms.TextBox()
        Me.txtbox_author = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbox_copies = New System.Windows.Forms.TextBox()
        Me.txbox_search = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_bkid = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lb_bookid = New System.Windows.Forms.Label()
        Me.txtbx_cop1 = New System.Windows.Forms.TextBox()
        Me.txtbx_aut1 = New System.Windows.Forms.TextBox()
        Me.txtbx_tit1 = New System.Windows.Forms.TextBox()
        Me.txtbx_cat1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_bkid2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_edit = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Llbl_edit_yel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_add)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1112, 43)
        Me.Panel1.TabIndex = 0
        '
        'Llbl_edit_yel
        '
        Me.Llbl_edit_yel.AutoSize = True
        Me.Llbl_edit_yel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llbl_edit_yel.ForeColor = System.Drawing.Color.Gold
        Me.Llbl_edit_yel.Location = New System.Drawing.Point(788, 9)
        Me.Llbl_edit_yel.Name = "Llbl_edit_yel"
        Me.Llbl_edit_yel.Size = New System.Drawing.Size(101, 22)
        Me.Llbl_edit_yel.TabIndex = 2
        Me.Llbl_edit_yel.Text = "Edit Books"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(424, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List of Books"
        '
        'lbl_add
        '
        Me.lbl_add.AutoSize = True
        Me.lbl_add.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_add.ForeColor = System.Drawing.Color.Gold
        Me.lbl_add.Location = New System.Drawing.Point(47, 9)
        Me.lbl_add.Name = "lbl_add"
        Me.lbl_add.Size = New System.Drawing.Size(125, 22)
        Me.lbl_add.TabIndex = 0
        Me.lbl_add.Text = "Adding Books"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(13, 121)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(36, 13)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Title:"
        '
        'lbl_author
        '
        Me.lbl_author.AutoSize = True
        Me.lbl_author.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_author.Location = New System.Drawing.Point(13, 146)
        Me.lbl_author.Name = "lbl_author"
        Me.lbl_author.Size = New System.Drawing.Size(48, 13)
        Me.lbl_author.TabIndex = 2
        Me.lbl_author.Text = "Author:"
        '
        'lbl_noc
        '
        Me.lbl_noc.AutoSize = True
        Me.lbl_noc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noc.Location = New System.Drawing.Point(13, 175)
        Me.lbl_noc.Name = "lbl_noc"
        Me.lbl_noc.Size = New System.Drawing.Size(111, 13)
        Me.lbl_noc.TabIndex = 5
        Me.lbl_noc.Text = "Number of Copies:"
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_search.Location = New System.Drawing.Point(273, 321)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(80, 13)
        Me.lbl_search.TabIndex = 12
        Me.lbl_search.Text = "Search Title:"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(16, 210)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(76, 42)
        Me.btn_add.TabIndex = 14
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(6, 318)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(55, 23)
        Me.btn_back.TabIndex = 17
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Txtbox_category
        '
        Me.Txtbox_category.Location = New System.Drawing.Point(86, 95)
        Me.Txtbox_category.Name = "Txtbox_category"
        Me.Txtbox_category.Size = New System.Drawing.Size(124, 20)
        Me.Txtbox_category.TabIndex = 22
        '
        'txtbox_title
        '
        Me.txtbox_title.Location = New System.Drawing.Point(86, 121)
        Me.txtbox_title.Name = "txtbox_title"
        Me.txtbox_title.Size = New System.Drawing.Size(124, 20)
        Me.txtbox_title.TabIndex = 23
        '
        'txtbox_author
        '
        Me.txtbox_author.Location = New System.Drawing.Point(86, 146)
        Me.txtbox_author.Name = "txtbox_author"
        Me.txtbox_author.Size = New System.Drawing.Size(124, 20)
        Me.txtbox_author.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Category:"
        '
        'txtbox_copies
        '
        Me.txtbox_copies.Location = New System.Drawing.Point(130, 172)
        Me.txtbox_copies.Name = "txtbox_copies"
        Me.txtbox_copies.Size = New System.Drawing.Size(105, 20)
        Me.txtbox_copies.TabIndex = 27
        '
        'txbox_search
        '
        Me.txbox_search.Location = New System.Drawing.Point(360, 321)
        Me.txbox_search.Name = "txbox_search"
        Me.txbox_search.Size = New System.Drawing.Size(345, 20)
        Me.txbox_search.TabIndex = 28
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(188, 210)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(72, 42)
        Me.btn_delete.TabIndex = 30
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(276, 49)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(479, 265)
        Me.ListView1.TabIndex = 31
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Book_ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Category"
        Me.ColumnHeader2.Width = 89
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Title"
        Me.ColumnHeader3.Width = 143
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Author"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Copies"
        Me.ColumnHeader5.Width = 236
        '
        'lbl_bkid
        '
        Me.lbl_bkid.AutoSize = True
        Me.lbl_bkid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bkid.Location = New System.Drawing.Point(13, 67)
        Me.lbl_bkid.Name = "lbl_bkid"
        Me.lbl_bkid.Size = New System.Drawing.Size(60, 13)
        Me.lbl_bkid.TabIndex = 20
        Me.lbl_bkid.Text = "Book_ID:"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.lb_bookid)
        Me.Panel2.Controls.Add(Me.txtbx_cop1)
        Me.Panel2.Controls.Add(Me.txtbx_aut1)
        Me.Panel2.Controls.Add(Me.txtbx_tit1)
        Me.Panel2.Controls.Add(Me.txtbx_cat1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lbl_bkid2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lbl_edit)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Location = New System.Drawing.Point(773, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(265, 289)
        Me.Panel2.TabIndex = 33
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Category:"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Number of Copies:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Author:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Title:"
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
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(104, 210)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(78, 42)
        Me.btn_update.TabIndex = 16
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 346)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txbox_search)
        Me.Controls.Add(Me.txtbox_copies)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbox_author)
        Me.Controls.Add(Me.txtbox_title)
        Me.Controls.Add(Me.Txtbox_category)
        Me.Controls.Add(Me.lbl_bkid)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.lbl_noc)
        Me.Controls.Add(Me.lbl_author)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "add"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_add As System.Windows.Forms.Label
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lbl_author As System.Windows.Forms.Label
    Friend WithEvents lbl_noc As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_search As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents Txtbox_category As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_title As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_author As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbox_copies As System.Windows.Forms.TextBox
    Friend WithEvents txbox_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_bkid As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Llbl_edit_yel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_edit As System.Windows.Forms.Label
    Friend WithEvents txtbx_cop1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx_aut1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx_tit1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx_cat1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_bkid2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lb_bookid As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
End Class
