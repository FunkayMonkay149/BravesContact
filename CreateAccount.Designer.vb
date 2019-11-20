<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
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
        Me.createbutton = New System.Windows.Forms.Button()
        Me.passwordinput = New System.Windows.Forms.TextBox()
        Me.usernameinput = New System.Windows.Forms.TextBox()
        Me.passwordlabel = New System.Windows.Forms.Label()
        Me.Usernamelabel = New System.Windows.Forms.Label()
        Me.Pleassignin = New System.Windows.Forms.Label()
        Me.background1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Existingaccount = New System.Windows.Forms.Label()
        Me.incorrect = New System.Windows.Forms.TextBox()
        CType(Me.background1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'createbutton
        '
        Me.createbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.createbutton.FlatAppearance.BorderSize = 0
        Me.createbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createbutton.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createbutton.ForeColor = System.Drawing.Color.White
        Me.createbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.createbutton.Location = New System.Drawing.Point(502, 432)
        Me.createbutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.createbutton.Name = "createbutton"
        Me.createbutton.Size = New System.Drawing.Size(101, 45)
        Me.createbutton.TabIndex = 14
        Me.createbutton.Text = "Create"
        Me.createbutton.UseVisualStyleBackColor = False
        '
        'passwordinput
        '
        Me.passwordinput.Location = New System.Drawing.Point(298, 289)
        Me.passwordinput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.passwordinput.Name = "passwordinput"
        Me.passwordinput.Size = New System.Drawing.Size(304, 26)
        Me.passwordinput.TabIndex = 13
        '
        'usernameinput
        '
        Me.usernameinput.Location = New System.Drawing.Point(298, 208)
        Me.usernameinput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.usernameinput.Name = "usernameinput"
        Me.usernameinput.Size = New System.Drawing.Size(304, 26)
        Me.usernameinput.TabIndex = 12
        '
        'passwordlabel
        '
        Me.passwordlabel.AutoSize = True
        Me.passwordlabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.passwordlabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordlabel.ForeColor = System.Drawing.Color.White
        Me.passwordlabel.Location = New System.Drawing.Point(292, 252)
        Me.passwordlabel.Name = "passwordlabel"
        Me.passwordlabel.Size = New System.Drawing.Size(113, 32)
        Me.passwordlabel.TabIndex = 11
        Me.passwordlabel.Text = "Password"
        Me.passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Usernamelabel
        '
        Me.Usernamelabel.AutoSize = True
        Me.Usernamelabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Usernamelabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernamelabel.ForeColor = System.Drawing.Color.White
        Me.Usernamelabel.Location = New System.Drawing.Point(292, 171)
        Me.Usernamelabel.Name = "Usernamelabel"
        Me.Usernamelabel.Size = New System.Drawing.Size(122, 32)
        Me.Usernamelabel.TabIndex = 10
        Me.Usernamelabel.Text = "Username"
        Me.Usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pleassignin
        '
        Me.Pleassignin.AutoSize = True
        Me.Pleassignin.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Pleassignin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pleassignin.ForeColor = System.Drawing.Color.White
        Me.Pleassignin.Location = New System.Drawing.Point(345, 136)
        Me.Pleassignin.Name = "Pleassignin"
        Me.Pleassignin.Size = New System.Drawing.Size(234, 32)
        Me.Pleassignin.TabIndex = 8
        Me.Pleassignin.Text = "Create Your Account"
        Me.Pleassignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'background1
        '
        Me.background1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.background1.Location = New System.Drawing.Point(250, 69)
        Me.background1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.background1.Name = "background1"
        Me.background1.Size = New System.Drawing.Size(393, 432)
        Me.background1.TabIndex = 9
        Me.background1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(292, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Verify Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(298, 368)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 26)
        Me.TextBox1.TabIndex = 17
        '
        'Existingaccount
        '
        Me.Existingaccount.AutoSize = True
        Me.Existingaccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Existingaccount.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Existingaccount.ForeColor = System.Drawing.Color.AliceBlue
        Me.Existingaccount.Location = New System.Drawing.Point(277, 435)
        Me.Existingaccount.Name = "Existingaccount"
        Me.Existingaccount.Size = New System.Drawing.Size(213, 32)
        Me.Existingaccount.TabIndex = 18
        Me.Existingaccount.Text = "Existing Account?"
        Me.Existingaccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'incorrect
        '
        Me.incorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.incorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incorrect.ForeColor = System.Drawing.Color.White
        Me.incorrect.Location = New System.Drawing.Point(298, 82)
        Me.incorrect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.incorrect.Name = "incorrect"
        Me.incorrect.Size = New System.Drawing.Size(304, 25)
        Me.incorrect.TabIndex = 19
        Me.incorrect.Text = "Passwords Do Not Match!!!"
        Me.incorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.incorrect.Visible = False
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 713)
        Me.Controls.Add(Me.incorrect)
        Me.Controls.Add(Me.Existingaccount)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.createbutton)
        Me.Controls.Add(Me.passwordinput)
        Me.Controls.Add(Me.usernameinput)
        Me.Controls.Add(Me.passwordlabel)
        Me.Controls.Add(Me.Usernamelabel)
        Me.Controls.Add(Me.Pleassignin)
        Me.Controls.Add(Me.background1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CreateAccount"
        Me.Text = "CreateAccount"
        CType(Me.background1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents createbutton As Button
    Friend WithEvents passwordinput As TextBox
    Friend WithEvents usernameinput As TextBox
    Friend WithEvents passwordlabel As Label
    Friend WithEvents Usernamelabel As Label
    Friend WithEvents Pleassignin As Label
    Friend WithEvents background1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Existingaccount As Label
    Friend WithEvents incorrect As TextBox
End Class
