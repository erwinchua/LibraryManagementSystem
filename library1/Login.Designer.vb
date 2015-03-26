<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_un = New System.Windows.Forms.TextBox()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(53, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(53, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'txtbox_un
        '
        Me.txtbox_un.Location = New System.Drawing.Point(125, 49)
        Me.txtbox_un.Name = "txtbox_un"
        Me.txtbox_un.Size = New System.Drawing.Size(113, 20)
        Me.txtbox_un.TabIndex = 4
        '
        'txtbox_pass
        '
        Me.txtbox_pass.Location = New System.Drawing.Point(125, 101)
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.Size = New System.Drawing.Size(113, 20)
        Me.txtbox_pass.TabIndex = 5
        Me.txtbox_pass.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(182, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(224, 213)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(45, 23)
        Me.btn_back.TabIndex = 7
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(302, 262)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.txtbox_un)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbox_un As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_pass As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
End Class
