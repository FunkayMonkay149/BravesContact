<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signinpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Pleassignin = New System.Windows.Forms.Label()
        Me.background1 = New System.Windows.Forms.PictureBox()
        Me.Usernamelabel = New System.Windows.Forms.Label()
        Me.passwordlabel = New System.Windows.Forms.Label()
        Me.usernameinput = New System.Windows.Forms.TextBox()
        Me.passwordinput = New System.Windows.Forms.TextBox()
        Me.loginbutton = New System.Windows.Forms.Button()
        Me.newusertext = New System.Windows.Forms.Label()
        Me.incorrect = New System.Windows.Forms.TextBox()
        CType(Me.background1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pleassignin
        '
        Me.Pleassignin.AutoSize = True
        Me.Pleassignin.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Pleassignin.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pleassignin.ForeColor = System.Drawing.Color.White
        Me.Pleassignin.Location = New System.Drawing.Point(298, 93)
        Me.Pleassignin.Name = "Pleassignin"
        Me.Pleassignin.Size = New System.Drawing.Size(163, 32)
        Me.Pleassignin.TabIndex = 0
        Me.Pleassignin.Text = "Please Sign in"
        Me.Pleassignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'background1
        '
        Me.background1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.background1.Location = New System.Drawing.Point(206, 59)
        Me.background1.Name = "background1"
        Me.background1.Size = New System.Drawing.Size(349, 292)
        Me.background1.TabIndex = 1
        Me.background1.TabStop = False
        '
        'Usernamelabel
        '
        Me.Usernamelabel.AutoSize = True
        Me.Usernamelabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Usernamelabel.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernamelabel.ForeColor = System.Drawing.Color.White
        Me.Usernamelabel.Location = New System.Drawing.Point(240, 132)
        Me.Usernamelabel.Name = "Usernamelabel"
        Me.Usernamelabel.Size = New System.Drawing.Size(122, 32)
        Me.Usernamelabel.TabIndex = 2
        Me.Usernamelabel.Text = "Username"
        Me.Usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'passwordlabel
        '
        Me.passwordlabel.AutoSize = True
        Me.passwordlabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.passwordlabel.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordlabel.ForeColor = System.Drawing.Color.White
        Me.passwordlabel.Location = New System.Drawing.Point(240, 201)
        Me.passwordlabel.Name = "passwordlabel"
        Me.passwordlabel.Size = New System.Drawing.Size(112, 32)
        Me.passwordlabel.TabIndex = 3
        Me.passwordlabel.Text = "Password"
        Me.passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usernameinput
        '
        Me.usernameinput.Location = New System.Drawing.Point(245, 161)
        Me.usernameinput.Name = "usernameinput"
        Me.usernameinput.Size = New System.Drawing.Size(271, 22)
        Me.usernameinput.TabIndex = 4
        '
        'passwordinput
        '
        Me.passwordinput.Location = New System.Drawing.Point(245, 231)
        Me.passwordinput.Name = "passwordinput"
        Me.passwordinput.Size = New System.Drawing.Size(271, 22)
        Me.passwordinput.TabIndex = 5
        '
        'loginbutton
        '
        Me.loginbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.loginbutton.FlatAppearance.BorderSize = 0
        Me.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbutton.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbutton.ForeColor = System.Drawing.Color.White
        Me.loginbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.loginbutton.Location = New System.Drawing.Point(426, 277)
        Me.loginbutton.Name = "loginbutton"
        Me.loginbutton.Size = New System.Drawing.Size(90, 36)
        Me.loginbutton.TabIndex = 6
        Me.loginbutton.Text = "Log In"
        Me.loginbutton.UseVisualStyleBackColor = False
        '
        'newusertext
        '
        Me.newusertext.AutoSize = True
        Me.newusertext.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.newusertext.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newusertext.ForeColor = System.Drawing.Color.AliceBlue
        Me.newusertext.Location = New System.Drawing.Point(242, 290)
        Me.newusertext.Name = "newusertext"
        Me.newusertext.Size = New System.Drawing.Size(110, 28)
        Me.newusertext.TabIndex = 7
        Me.newusertext.Text = "New User?"
        Me.newusertext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'incorrect
        '
        Me.incorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.incorrect.Font = New System.Drawing.Font("Segoe UI Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incorrect.ForeColor = System.Drawing.Color.White
        Me.incorrect.Location = New System.Drawing.Point(245, 66)
        Me.incorrect.Name = "incorrect"
        Me.incorrect.Size = New System.Drawing.Size(271, 25)
        Me.incorrect.TabIndex = 8
        Me.incorrect.Text = "Invalid Username or Password!!!"
        Me.incorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.incorrect.Visible = False
        '
        'Signinpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(781, 440)
        Me.Controls.Add(Me.incorrect)
        Me.Controls.Add(Me.newusertext)
        Me.Controls.Add(Me.loginbutton)
        Me.Controls.Add(Me.passwordinput)
        Me.Controls.Add(Me.usernameinput)
        Me.Controls.Add(Me.passwordlabel)
        Me.Controls.Add(Me.Usernamelabel)
        Me.Controls.Add(Me.Pleassignin)
        Me.Controls.Add(Me.background1)
        Me.Name = "Signinpage"
        Me.Text = "ContactList"
        CType(Me.background1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pleassignin As Label
    Friend WithEvents background1 As PictureBox
    Friend WithEvents Usernamelabel As Label
    Friend WithEvents passwordlabel As Label
    Friend WithEvents usernameinput As TextBox
    Friend WithEvents passwordinput As TextBox
    Friend WithEvents loginbutton As Button
    Friend WithEvents newusertext As Label
    Friend WithEvents incorrect As TextBox
End Class
