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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signinpage))
        Me.Usernamelabel = New System.Windows.Forms.Label()
        Me.passwordlabel = New System.Windows.Forms.Label()
        Me.headerusernameinput = New System.Windows.Forms.TextBox()
        Me.headerpasswordinput = New System.Windows.Forms.TextBox()
        Me.loginbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.save_icon = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.createbutton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.usernameinput = New System.Windows.Forms.TextBox()
        Me.passwordinput = New System.Windows.Forms.TextBox()
        Me.verifypassword = New System.Windows.Forms.TextBox()
        Me.incorrect = New System.Windows.Forms.TextBox()
        Me.incorrect2 = New System.Windows.Forms.TextBox()
        CType(Me.save_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Usernamelabel
        '
        Me.Usernamelabel.AutoSize = True
        Me.Usernamelabel.BackColor = System.Drawing.Color.White
        Me.Usernamelabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernamelabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Usernamelabel.Location = New System.Drawing.Point(353, 22)
        Me.Usernamelabel.Name = "Usernamelabel"
        Me.Usernamelabel.Size = New System.Drawing.Size(122, 32)
        Me.Usernamelabel.TabIndex = 2
        Me.Usernamelabel.Text = "Username"
        '
        'passwordlabel
        '
        Me.passwordlabel.AutoSize = True
        Me.passwordlabel.BackColor = System.Drawing.Color.White
        Me.passwordlabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordlabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.passwordlabel.Location = New System.Drawing.Point(602, 22)
        Me.passwordlabel.Name = "passwordlabel"
        Me.passwordlabel.Size = New System.Drawing.Size(113, 32)
        Me.passwordlabel.TabIndex = 3
        Me.passwordlabel.Text = "Password"
        '
        'headerusernameinput
        '
        Me.headerusernameinput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerusernameinput.Location = New System.Drawing.Point(359, 61)
        Me.headerusernameinput.Name = "headerusernameinput"
        Me.headerusernameinput.Size = New System.Drawing.Size(236, 39)
        Me.headerusernameinput.TabIndex = 4
        '
        'headerpasswordinput
        '
        Me.headerpasswordinput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerpasswordinput.Location = New System.Drawing.Point(601, 61)
        Me.headerpasswordinput.Name = "headerpasswordinput"
        Me.headerpasswordinput.Size = New System.Drawing.Size(260, 39)
        Me.headerpasswordinput.TabIndex = 5
        '
        'loginbutton
        '
        Me.loginbutton.BackColor = System.Drawing.Color.Transparent
        Me.loginbutton.BackgroundImage = CType(resources.GetObject("loginbutton.BackgroundImage"), System.Drawing.Image)
        Me.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.loginbutton.FlatAppearance.BorderSize = 0
        Me.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbutton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbutton.ForeColor = System.Drawing.Color.White
        Me.loginbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.loginbutton.Location = New System.Drawing.Point(888, 53)
        Me.loginbutton.Name = "loginbutton"
        Me.loginbutton.Size = New System.Drawing.Size(102, 47)
        Me.loginbutton.TabIndex = 6
        Me.loginbutton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 70)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Create Account"
        '
        'save_icon
        '
        Me.save_icon.BackColor = System.Drawing.Color.Transparent
        Me.save_icon.Image = CType(resources.GetObject("save_icon.Image"), System.Drawing.Image)
        Me.save_icon.Location = New System.Drawing.Point(570, 274)
        Me.save_icon.Name = "save_icon"
        Me.save_icon.Size = New System.Drawing.Size(130, 98)
        Me.save_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.save_icon.TabIndex = 11
        Me.save_icon.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(570, 388)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(570, 502)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(130, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(714, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 32)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Save New Contacts"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(714, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 32)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Add Email Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(714, 535)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 32)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Easy Access"
        '
        'createbutton
        '
        Me.createbutton.BackColor = System.Drawing.Color.Transparent
        Me.createbutton.BackgroundImage = CType(resources.GetObject("createbutton.BackgroundImage"), System.Drawing.Image)
        Me.createbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.createbutton.FlatAppearance.BorderSize = 0
        Me.createbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createbutton.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createbutton.ForeColor = System.Drawing.Color.White
        Me.createbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.createbutton.Location = New System.Drawing.Point(41, 579)
        Me.createbutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.createbutton.Name = "createbutton"
        Me.createbutton.Size = New System.Drawing.Size(101, 45)
        Me.createbutton.TabIndex = 17
        Me.createbutton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(35, 455)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 32)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Verify Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(35, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 32)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(35, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 32)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Username"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(577, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(338, 54)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Features Available"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(316, 96)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'usernameinput
        '
        Me.usernameinput.Location = New System.Drawing.Point(229, 295)
        Me.usernameinput.Name = "usernameinput"
        Me.usernameinput.Size = New System.Drawing.Size(206, 29)
        Me.usernameinput.TabIndex = 25
        '
        'passwordinput
        '
        Me.passwordinput.Location = New System.Drawing.Point(229, 380)
        Me.passwordinput.Name = "passwordinput"
        Me.passwordinput.Size = New System.Drawing.Size(206, 29)
        Me.passwordinput.TabIndex = 26
        '
        'verifypassword
        '
        Me.verifypassword.Location = New System.Drawing.Point(229, 460)
        Me.verifypassword.Name = "verifypassword"
        Me.verifypassword.Size = New System.Drawing.Size(206, 29)
        Me.verifypassword.TabIndex = 27
        '
        'incorrect
        '
        Me.incorrect.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.incorrect.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incorrect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.incorrect.Location = New System.Drawing.Point(41, 502)
        Me.incorrect.Name = "incorrect"
        Me.incorrect.Size = New System.Drawing.Size(394, 32)
        Me.incorrect.TabIndex = 28
        Me.incorrect.Text = "Passwords Do Not Match!!!"
        Me.incorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.incorrect.Visible = False
        '
        'incorrect2
        '
        Me.incorrect2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.incorrect2.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incorrect2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.incorrect2.Location = New System.Drawing.Point(359, 106)
        Me.incorrect2.Name = "incorrect2"
        Me.incorrect2.Size = New System.Drawing.Size(503, 32)
        Me.incorrect2.TabIndex = 29
        Me.incorrect2.Text = "Incorrect Username/Password"
        Me.incorrect2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.incorrect2.Visible = False
        '
        'Signinpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1002, 713)
        Me.Controls.Add(Me.incorrect2)
        Me.Controls.Add(Me.incorrect)
        Me.Controls.Add(Me.verifypassword)
        Me.Controls.Add(Me.passwordinput)
        Me.Controls.Add(Me.usernameinput)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.createbutton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.save_icon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loginbutton)
        Me.Controls.Add(Me.headerpasswordinput)
        Me.Controls.Add(Me.headerusernameinput)
        Me.Controls.Add(Me.passwordlabel)
        Me.Controls.Add(Me.Usernamelabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Name = "Signinpage"
        Me.Text = "ContactList"
        CType(Me.save_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Usernamelabel As Label
    Friend WithEvents passwordlabel As Label
    Friend WithEvents headerusernameinput As TextBox
    Friend WithEvents headerpasswordinput As TextBox
    Friend WithEvents loginbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents save_icon As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents createbutton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents usernameinput As TextBox
    Friend WithEvents passwordinput As TextBox
    Friend WithEvents verifypassword As TextBox
    Friend WithEvents incorrect As TextBox
    Friend WithEvents incorrect2 As TextBox
End Class
