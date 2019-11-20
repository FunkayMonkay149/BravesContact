<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactViewing
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
        Me.background2 = New System.Windows.Forms.PictureBox()
        Me.Welcometext = New System.Windows.Forms.Label()
        Me.Contactlist = New System.Windows.Forms.ListBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.FirstInput = New System.Windows.Forms.TextBox()
        Me.firstname = New System.Windows.Forms.Label()
        Me.MiddleInput = New System.Windows.Forms.TextBox()
        Me.Middle = New System.Windows.Forms.Label()
        Me.LastInput = New System.Windows.Forms.TextBox()
        Me.Last = New System.Windows.Forms.Label()
        Me.EmailInput = New System.Windows.Forms.TextBox()
        Me.Emailaddress = New System.Windows.Forms.Label()
        Me.X1 = New System.Windows.Forms.Button()
        Me.X2 = New System.Windows.Forms.Button()
        Me.emailinput2 = New System.Windows.Forms.TextBox()
        Me.emailaddress2 = New System.Windows.Forms.Label()
        Me.lastinput2 = New System.Windows.Forms.TextBox()
        Me.Last2 = New System.Windows.Forms.Label()
        Me.MiddleInput2 = New System.Windows.Forms.TextBox()
        Me.Middle2 = New System.Windows.Forms.Label()
        Me.Firstinput2 = New System.Windows.Forms.TextBox()
        Me.First2 = New System.Windows.Forms.Label()
        Me.LogOff = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.background2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'background2
        '
        Me.background2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.background2.Location = New System.Drawing.Point(35, 11)
        Me.background2.Name = "background2"
        Me.background2.Size = New System.Drawing.Size(715, 68)
        Me.background2.TabIndex = 11
        Me.background2.TabStop = False
        '
        'Welcometext
        '
        Me.Welcometext.AutoSize = True
        Me.Welcometext.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Welcometext.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcometext.ForeColor = System.Drawing.Color.White
        Me.Welcometext.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Welcometext.Location = New System.Drawing.Point(43, 10)
        Me.Welcometext.Name = "Welcometext"
        Me.Welcometext.Size = New System.Drawing.Size(255, 64)
        Me.Welcometext.TabIndex = 12
        Me.Welcometext.Text = "Welcome," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            Your contacts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Contactlist
        '
        Me.Contactlist.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Contactlist.FormattingEnabled = True
        Me.Contactlist.ItemHeight = 17
        Me.Contactlist.Location = New System.Drawing.Point(48, 219)
        Me.Contactlist.Name = "Contactlist"
        Me.Contactlist.Size = New System.Drawing.Size(702, 191)
        Me.Contactlist.TabIndex = 13
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.ForeColor = System.Drawing.Color.White
        Me.Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Add.Location = New System.Drawing.Point(48, 103)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(90, 37)
        Me.Add.TabIndex = 14
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Search.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.ForeColor = System.Drawing.Color.White
        Me.Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Search.Location = New System.Drawing.Point(48, 160)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(90, 37)
        Me.Search.TabIndex = 15
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = False
        '
        'FirstInput
        '
        Me.FirstInput.Location = New System.Drawing.Point(149, 110)
        Me.FirstInput.Name = "FirstInput"
        Me.FirstInput.Size = New System.Drawing.Size(110, 25)
        Me.FirstInput.TabIndex = 17
        Me.FirstInput.Visible = False
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.firstname.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.White
        Me.firstname.Location = New System.Drawing.Point(144, 81)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(59, 32)
        Me.firstname.TabIndex = 16
        Me.firstname.Text = "First"
        Me.firstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.firstname.Visible = False
        '
        'MiddleInput
        '
        Me.MiddleInput.Location = New System.Drawing.Point(282, 112)
        Me.MiddleInput.Name = "MiddleInput"
        Me.MiddleInput.Size = New System.Drawing.Size(97, 25)
        Me.MiddleInput.TabIndex = 19
        Me.MiddleInput.Visible = False
        '
        'Middle
        '
        Me.Middle.AutoSize = True
        Me.Middle.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Middle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle.ForeColor = System.Drawing.Color.White
        Me.Middle.Location = New System.Drawing.Point(277, 81)
        Me.Middle.Name = "Middle"
        Me.Middle.Size = New System.Drawing.Size(90, 32)
        Me.Middle.TabIndex = 18
        Me.Middle.Text = "Middle"
        Me.Middle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Middle.Visible = False
        '
        'LastInput
        '
        Me.LastInput.Location = New System.Drawing.Point(405, 110)
        Me.LastInput.Name = "LastInput"
        Me.LastInput.Size = New System.Drawing.Size(110, 25)
        Me.LastInput.TabIndex = 21
        Me.LastInput.Visible = False
        '
        'Last
        '
        Me.Last.AutoSize = True
        Me.Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Last.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last.ForeColor = System.Drawing.Color.White
        Me.Last.Location = New System.Drawing.Point(400, 81)
        Me.Last.Name = "Last"
        Me.Last.Size = New System.Drawing.Size(56, 32)
        Me.Last.TabIndex = 20
        Me.Last.Text = "Last"
        Me.Last.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Last.Visible = False
        '
        'EmailInput
        '
        Me.EmailInput.Location = New System.Drawing.Point(529, 110)
        Me.EmailInput.Name = "EmailInput"
        Me.EmailInput.Size = New System.Drawing.Size(191, 25)
        Me.EmailInput.TabIndex = 23
        Me.EmailInput.Visible = False
        '
        'Emailaddress
        '
        Me.Emailaddress.AutoSize = True
        Me.Emailaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Emailaddress.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emailaddress.ForeColor = System.Drawing.Color.White
        Me.Emailaddress.Location = New System.Drawing.Point(524, 81)
        Me.Emailaddress.Name = "Emailaddress"
        Me.Emailaddress.Size = New System.Drawing.Size(163, 32)
        Me.Emailaddress.TabIndex = 22
        Me.Emailaddress.Text = "Email Address"
        Me.Emailaddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Emailaddress.Visible = False
        '
        'X1
        '
        Me.X1.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.X1.FlatAppearance.BorderSize = 0
        Me.X1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.X1.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.X1.ForeColor = System.Drawing.Color.White
        Me.X1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.X1.Location = New System.Drawing.Point(726, 110)
        Me.X1.Name = "X1"
        Me.X1.Size = New System.Drawing.Size(23, 22)
        Me.X1.TabIndex = 24
        Me.X1.Text = "X"
        Me.X1.UseVisualStyleBackColor = False
        Me.X1.Visible = False
        '
        'X2
        '
        Me.X2.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.X2.FlatAppearance.BorderSize = 0
        Me.X2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.X2.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.X2.ForeColor = System.Drawing.Color.White
        Me.X2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.X2.Location = New System.Drawing.Point(726, 168)
        Me.X2.Name = "X2"
        Me.X2.Size = New System.Drawing.Size(23, 22)
        Me.X2.TabIndex = 33
        Me.X2.Text = "X"
        Me.X2.UseVisualStyleBackColor = False
        Me.X2.Visible = False
        '
        'emailinput2
        '
        Me.emailinput2.Location = New System.Drawing.Point(529, 168)
        Me.emailinput2.Name = "emailinput2"
        Me.emailinput2.Size = New System.Drawing.Size(191, 25)
        Me.emailinput2.TabIndex = 32
        Me.emailinput2.Visible = False
        '
        'emailaddress2
        '
        Me.emailaddress2.AutoSize = True
        Me.emailaddress2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.emailaddress2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailaddress2.ForeColor = System.Drawing.Color.White
        Me.emailaddress2.Location = New System.Drawing.Point(524, 138)
        Me.emailaddress2.Name = "emailaddress2"
        Me.emailaddress2.Size = New System.Drawing.Size(163, 32)
        Me.emailaddress2.TabIndex = 31
        Me.emailaddress2.Text = "Email Address"
        Me.emailaddress2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.emailaddress2.Visible = False
        '
        'lastinput2
        '
        Me.lastinput2.Location = New System.Drawing.Point(405, 168)
        Me.lastinput2.Name = "lastinput2"
        Me.lastinput2.Size = New System.Drawing.Size(110, 25)
        Me.lastinput2.TabIndex = 30
        Me.lastinput2.Visible = False
        '
        'Last2
        '
        Me.Last2.AutoSize = True
        Me.Last2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Last2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last2.ForeColor = System.Drawing.Color.White
        Me.Last2.Location = New System.Drawing.Point(400, 138)
        Me.Last2.Name = "Last2"
        Me.Last2.Size = New System.Drawing.Size(56, 32)
        Me.Last2.TabIndex = 29
        Me.Last2.Text = "Last"
        Me.Last2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Last2.Visible = False
        '
        'MiddleInput2
        '
        Me.MiddleInput2.Location = New System.Drawing.Point(282, 168)
        Me.MiddleInput2.Name = "MiddleInput2"
        Me.MiddleInput2.Size = New System.Drawing.Size(97, 25)
        Me.MiddleInput2.TabIndex = 28
        Me.MiddleInput2.Visible = False
        '
        'Middle2
        '
        Me.Middle2.AutoSize = True
        Me.Middle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Middle2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle2.ForeColor = System.Drawing.Color.White
        Me.Middle2.Location = New System.Drawing.Point(277, 138)
        Me.Middle2.Name = "Middle2"
        Me.Middle2.Size = New System.Drawing.Size(90, 32)
        Me.Middle2.TabIndex = 27
        Me.Middle2.Text = "Middle"
        Me.Middle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Middle2.Visible = False
        '
        'Firstinput2
        '
        Me.Firstinput2.Location = New System.Drawing.Point(149, 168)
        Me.Firstinput2.Name = "Firstinput2"
        Me.Firstinput2.Size = New System.Drawing.Size(110, 25)
        Me.Firstinput2.TabIndex = 26
        Me.Firstinput2.Visible = False
        '
        'First2
        '
        Me.First2.AutoSize = True
        Me.First2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.First2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First2.ForeColor = System.Drawing.Color.White
        Me.First2.Location = New System.Drawing.Point(144, 138)
        Me.First2.Name = "First2"
        Me.First2.Size = New System.Drawing.Size(59, 32)
        Me.First2.TabIndex = 25
        Me.First2.Text = "First"
        Me.First2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.First2.Visible = False
        '
        'LogOff
        '
        Me.LogOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.LogOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.LogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOff.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOff.ForeColor = System.Drawing.Color.White
        Me.LogOff.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LogOff.Location = New System.Drawing.Point(660, 422)
        Me.LogOff.Name = "LogOff"
        Me.LogOff.Size = New System.Drawing.Size(90, 38)
        Me.LogOff.TabIndex = 34
        Me.LogOff.Text = "Log Off"
        Me.LogOff.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(48, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 38)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ContactViewing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LogOff)
        Me.Controls.Add(Me.X2)
        Me.Controls.Add(Me.emailinput2)
        Me.Controls.Add(Me.emailaddress2)
        Me.Controls.Add(Me.lastinput2)
        Me.Controls.Add(Me.Last2)
        Me.Controls.Add(Me.MiddleInput2)
        Me.Controls.Add(Me.Middle2)
        Me.Controls.Add(Me.Firstinput2)
        Me.Controls.Add(Me.First2)
        Me.Controls.Add(Me.X1)
        Me.Controls.Add(Me.EmailInput)
        Me.Controls.Add(Me.Emailaddress)
        Me.Controls.Add(Me.LastInput)
        Me.Controls.Add(Me.Last)
        Me.Controls.Add(Me.MiddleInput)
        Me.Controls.Add(Me.Middle)
        Me.Controls.Add(Me.FirstInput)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Contactlist)
        Me.Controls.Add(Me.Welcometext)
        Me.Controls.Add(Me.background2)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ContactViewing"
        Me.Text = "ContactViewing"
        CType(Me.background2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents background2 As PictureBox
    Friend WithEvents Welcometext As Label
    Friend WithEvents Contactlist As ListBox
    Friend WithEvents Add As Button
    Friend WithEvents Search As Button
    Friend WithEvents FirstInput As TextBox
    Friend WithEvents firstname As Label
    Friend WithEvents MiddleInput As TextBox
    Friend WithEvents Middle As Label
    Friend WithEvents LastInput As TextBox
    Friend WithEvents Last As Label
    Friend WithEvents EmailInput As TextBox
    Friend WithEvents Emailaddress As Label
    Friend WithEvents X1 As Button
    Friend WithEvents X2 As Button
    Friend WithEvents emailinput2 As TextBox
    Friend WithEvents emailaddress2 As Label
    Friend WithEvents lastinput2 As TextBox
    Friend WithEvents Last2 As Label
    Friend WithEvents MiddleInput2 As TextBox
    Friend WithEvents Middle2 As Label
    Friend WithEvents Firstinput2 As TextBox
    Friend WithEvents First2 As Label
    Friend WithEvents LogOff As Button
    Friend WithEvents Button1 As Button
End Class
