<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContactViewing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactViewing))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.firstname = New System.Windows.Forms.Label()
        Me.FirstInput = New System.Windows.Forms.TextBox()
        Me.Middle = New System.Windows.Forms.Label()
        Me.MiddleInput = New System.Windows.Forms.TextBox()
        Me.First2 = New System.Windows.Forms.Label()
        Me.Firstinput2 = New System.Windows.Forms.TextBox()
        Me.Middle2 = New System.Windows.Forms.Label()
        Me.MiddleInput2 = New System.Windows.Forms.TextBox()
        Me.LogOff = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.search1 = New System.Windows.Forms.Button()
        Me.EmailInput = New System.Windows.Forms.TextBox()
        Me.nameinput = New System.Windows.Forms.TextBox()
        Me.passwordlabel = New System.Windows.Forms.Label()
        Me.Usernamelabel = New System.Windows.Forms.Label()
        Me.ContactList = New System.Windows.Forms.ListBox()
        Me.Create = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(316, 96)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.ForeColor = System.Drawing.Color.White
        Me.Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Add.Location = New System.Drawing.Point(-345, 342)
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
        Me.Search.Location = New System.Drawing.Point(-345, 263)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(90, 37)
        Me.Search.TabIndex = 15
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = False
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.BackColor = System.Drawing.Color.Transparent
        Me.firstname.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.Black
        Me.firstname.Location = New System.Drawing.Point(-239, 304)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(69, 38)
        Me.firstname.TabIndex = 16
        Me.firstname.Text = "First"
        Me.firstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.firstname.Visible = False
        '
        'FirstInput
        '
        Me.FirstInput.Location = New System.Drawing.Point(-244, 346)
        Me.FirstInput.Name = "FirstInput"
        Me.FirstInput.Size = New System.Drawing.Size(110, 28)
        Me.FirstInput.TabIndex = 17
        Me.FirstInput.Visible = False
        '
        'Middle
        '
        Me.Middle.AutoSize = True
        Me.Middle.BackColor = System.Drawing.Color.Transparent
        Me.Middle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle.ForeColor = System.Drawing.Color.Black
        Me.Middle.Location = New System.Drawing.Point(-106, 304)
        Me.Middle.Name = "Middle"
        Me.Middle.Size = New System.Drawing.Size(103, 38)
        Me.Middle.TabIndex = 18
        Me.Middle.Text = "Middle"
        Me.Middle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Middle.Visible = False
        '
        'MiddleInput
        '
        Me.MiddleInput.Location = New System.Drawing.Point(-111, 346)
        Me.MiddleInput.Name = "MiddleInput"
        Me.MiddleInput.Size = New System.Drawing.Size(97, 28)
        Me.MiddleInput.TabIndex = 19
        Me.MiddleInput.Visible = False
        '
        'First2
        '
        Me.First2.AutoSize = True
        Me.First2.BackColor = System.Drawing.Color.Transparent
        Me.First2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First2.ForeColor = System.Drawing.Color.Black
        Me.First2.Location = New System.Drawing.Point(-243, 207)
        Me.First2.Name = "First2"
        Me.First2.Size = New System.Drawing.Size(69, 38)
        Me.First2.TabIndex = 25
        Me.First2.Text = "First"
        Me.First2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.First2.Visible = False
        '
        'Firstinput2
        '
        Me.Firstinput2.Location = New System.Drawing.Point(-244, 267)
        Me.Firstinput2.Name = "Firstinput2"
        Me.Firstinput2.Size = New System.Drawing.Size(110, 28)
        Me.Firstinput2.TabIndex = 26
        Me.Firstinput2.Visible = False
        '
        'Middle2
        '
        Me.Middle2.AutoSize = True
        Me.Middle2.BackColor = System.Drawing.Color.Transparent
        Me.Middle2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle2.ForeColor = System.Drawing.Color.Black
        Me.Middle2.Location = New System.Drawing.Point(-110, 207)
        Me.Middle2.Name = "Middle2"
        Me.Middle2.Size = New System.Drawing.Size(103, 38)
        Me.Middle2.TabIndex = 27
        Me.Middle2.Text = "Middle"
        Me.Middle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Middle2.Visible = False
        '
        'MiddleInput2
        '
        Me.MiddleInput2.Location = New System.Drawing.Point(-111, 267)
        Me.MiddleInput2.Name = "MiddleInput2"
        Me.MiddleInput2.Size = New System.Drawing.Size(97, 28)
        Me.MiddleInput2.TabIndex = 28
        Me.MiddleInput2.Visible = False
        '
        'LogOff
        '
        Me.LogOff.BackColor = System.Drawing.Color.Transparent
        Me.LogOff.BackgroundImage = CType(resources.GetObject("LogOff.BackgroundImage"), System.Drawing.Image)
        Me.LogOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.LogOff.FlatAppearance.BorderSize = 0
        Me.LogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOff.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOff.ForeColor = System.Drawing.Color.White
        Me.LogOff.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LogOff.Location = New System.Drawing.Point(857, 528)
        Me.LogOff.Name = "LogOff"
        Me.LogOff.Size = New System.Drawing.Size(124, 45)
        Me.LogOff.TabIndex = 34
        Me.LogOff.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.Transparent
        Me.Delete.BackgroundImage = CType(resources.GetObject("Delete.BackgroundImage"), System.Drawing.Image)
        Me.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Delete.FlatAppearance.BorderSize = 0
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.White
        Me.Delete.Location = New System.Drawing.Point(53, 291)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(226, 76)
        Me.Delete.TabIndex = 35
        Me.Delete.UseVisualStyleBackColor = False
        '
        'search1
        '
        Me.search1.BackColor = System.Drawing.Color.Transparent
        Me.search1.BackgroundImage = CType(resources.GetObject("search1.BackgroundImage"), System.Drawing.Image)
        Me.search1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.search1.FlatAppearance.BorderSize = 0
        Me.search1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search1.ForeColor = System.Drawing.Color.White
        Me.search1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.search1.Location = New System.Drawing.Point(879, 65)
        Me.search1.Name = "search1"
        Me.search1.Size = New System.Drawing.Size(102, 47)
        Me.search1.TabIndex = 45
        Me.search1.UseVisualStyleBackColor = False
        '
        'EmailInput
        '
        Me.EmailInput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailInput.Location = New System.Drawing.Point(597, 69)
        Me.EmailInput.Name = "EmailInput"
        Me.EmailInput.Size = New System.Drawing.Size(260, 39)
        Me.EmailInput.TabIndex = 44
        '
        'nameinput
        '
        Me.nameinput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameinput.Location = New System.Drawing.Point(355, 69)
        Me.nameinput.Name = "nameinput"
        Me.nameinput.Size = New System.Drawing.Size(236, 39)
        Me.nameinput.TabIndex = 43
        '
        'passwordlabel
        '
        Me.passwordlabel.AutoSize = True
        Me.passwordlabel.BackColor = System.Drawing.Color.White
        Me.passwordlabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordlabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.passwordlabel.Location = New System.Drawing.Point(592, 31)
        Me.passwordlabel.Name = "passwordlabel"
        Me.passwordlabel.Size = New System.Drawing.Size(127, 32)
        Me.passwordlabel.TabIndex = 42
        Me.passwordlabel.Text = "Brave Mail"
        '
        'Usernamelabel
        '
        Me.Usernamelabel.AutoSize = True
        Me.Usernamelabel.BackColor = System.Drawing.Color.White
        Me.Usernamelabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernamelabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Usernamelabel.Location = New System.Drawing.Point(349, 31)
        Me.Usernamelabel.Name = "Usernamelabel"
        Me.Usernamelabel.Size = New System.Drawing.Size(79, 32)
        Me.Usernamelabel.TabIndex = 41
        Me.Usernamelabel.Text = "Name"
        '
        'ContactList
        '
        Me.ContactList.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ContactList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactList.FormattingEnabled = True
        Me.ContactList.ItemHeight = 32
        Me.ContactList.Location = New System.Drawing.Point(355, 143)
        Me.ContactList.Name = "ContactList"
        Me.ContactList.Size = New System.Drawing.Size(626, 354)
        Me.ContactList.TabIndex = 46
        '
        'Create
        '
        Me.Create.BackColor = System.Drawing.Color.Transparent
        Me.Create.BackgroundImage = CType(resources.GetObject("Create.BackgroundImage"), System.Drawing.Image)
        Me.Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Create.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Create.FlatAppearance.BorderSize = 0
        Me.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Create.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create.ForeColor = System.Drawing.Color.White
        Me.Create.Location = New System.Drawing.Point(53, 194)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(226, 76)
        Me.Create.TabIndex = 47
        Me.Create.UseVisualStyleBackColor = False
        '
        'ContactViewing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1002, 713)
        Me.Controls.Add(Me.Create)
        Me.Controls.Add(Me.ContactList)
        Me.Controls.Add(Me.search1)
        Me.Controls.Add(Me.EmailInput)
        Me.Controls.Add(Me.nameinput)
        Me.Controls.Add(Me.passwordlabel)
        Me.Controls.Add(Me.Usernamelabel)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.LogOff)
        Me.Controls.Add(Me.MiddleInput2)
        Me.Controls.Add(Me.Middle2)
        Me.Controls.Add(Me.Firstinput2)
        Me.Controls.Add(Me.First2)
        Me.Controls.Add(Me.MiddleInput)
        Me.Controls.Add(Me.Middle)
        Me.Controls.Add(Me.FirstInput)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Add)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ContactViewing"
        Me.Text = "ContactViewing"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Add As Button
    Friend WithEvents Search As Button
    Friend WithEvents firstname As Label
    Friend WithEvents FirstInput As TextBox
    Friend WithEvents Middle As Label
    Friend WithEvents MiddleInput As TextBox
    Friend WithEvents First2 As Label
    Friend WithEvents Firstinput2 As TextBox
    Friend WithEvents Middle2 As Label
    Friend WithEvents MiddleInput2 As TextBox
    Friend WithEvents LogOff As Button
    Friend WithEvents Delete As Button
    Friend WithEvents search1 As Button
    Friend WithEvents EmailInput As TextBox
    Friend WithEvents nameinput As TextBox
    Friend WithEvents passwordlabel As Label
    Friend WithEvents Usernamelabel As Label
    Friend WithEvents ContactList As ListBox
    Friend WithEvents Create As Button
End Class
