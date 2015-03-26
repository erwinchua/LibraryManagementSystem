<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeinfo
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox_un = New System.Windows.Forms.TextBox()
        Me.txtbox_newpass = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "New Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Reset Account"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "New Username:"
        '
        'txtbox_un
        '
        Me.txtbox_un.Location = New System.Drawing.Point(124, 84)
        Me.txtbox_un.Name = "txtbox_un"
        Me.txtbox_un.Size = New System.Drawing.Size(130, 20)
        Me.txtbox_un.TabIndex = 25
        '
        'txtbox_newpass
        '
        Me.txtbox_newpass.Location = New System.Drawing.Point(124, 112)
        Me.txtbox_newpass.Name = "txtbox_newpass"
        Me.txtbox_newpass.Size = New System.Drawing.Size(130, 20)
        Me.txtbox_newpass.TabIndex = 26
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(143, 157)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_submit.TabIndex = 27
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'changeinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 262)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txtbox_newpass)
        Me.Controls.Add(Me.txtbox_un)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "changeinfo"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbox_un As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_newpass As System.Windows.Forms.TextBox
    Friend WithEvents btn_submit As System.Windows.Forms.Button
End Class
