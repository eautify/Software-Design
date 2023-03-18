<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAccountType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpBday = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtUsernameCreate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbAccountTypeDelete = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancelDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpBDAYDelete = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUsernameDelete = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtLastNameReset = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFirstNameReset = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBoxRequest = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbAccountTypeReset = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpBdayReset = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtUsernameReset = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnResetPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCancel2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeading.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1281, 28)
        Me.lblHeading.TabIndex = 3
        Me.lblHeading.Text = "Admin Form"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1281, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 28)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel9.Controls.Add(Me.txtLastName)
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Controls.Add(Me.txtFirstName)
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.cbAccountType)
        Me.Panel9.Controls.Add(Me.Label15)
        Me.Panel9.Controls.Add(Me.dtpBday)
        Me.Panel9.Controls.Add(Me.txtUsernameCreate)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.btnCancel)
        Me.Panel9.Controls.Add(Me.btnCreate)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Location = New System.Drawing.Point(77, 50)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(565, 600)
        Me.Panel9.TabIndex = 11
        '
        'txtLastName
        '
        Me.txtLastName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtLastName.BorderThickness = 2
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(107, 307)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(349, 41)
        Me.txtLastName.TabIndex = 49
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(107, 286)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 17)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtFirstName.BorderThickness = 2
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(107, 233)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(349, 41)
        Me.txtFirstName.TabIndex = 47
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(107, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 17)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(107, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Account Type:"
        '
        'cbAccountType
        '
        Me.cbAccountType.BackColor = System.Drawing.Color.Transparent
        Me.cbAccountType.BorderColor = System.Drawing.Color.White
        Me.cbAccountType.BorderThickness = 0
        Me.cbAccountType.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.cbAccountType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cbAccountType.DisabledState.ForeColor = System.Drawing.Color.White
        Me.cbAccountType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAccountType.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cbAccountType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbAccountType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbAccountType.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAccountType.ForeColor = System.Drawing.Color.White
        Me.cbAccountType.ItemHeight = 30
        Me.cbAccountType.Items.AddRange(New Object() {"Employee", "Manager"})
        Me.cbAccountType.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbAccountType.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbAccountType.Location = New System.Drawing.Point(110, 89)
        Me.cbAccountType.Name = "cbAccountType"
        Me.cbAccountType.Size = New System.Drawing.Size(349, 36)
        Me.cbAccountType.StartIndex = 0
        Me.cbAccountType.TabIndex = 44
        Me.cbAccountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(107, 360)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 17)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Birthday:"
        '
        'dtpBday
        '
        Me.dtpBday.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dtpBday.BorderThickness = 2
        Me.dtpBday.Checked = True
        Me.dtpBday.CustomFormat = "MM/dd/yy"
        Me.dtpBday.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dtpBday.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dtpBday.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.dtpBday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dtpBday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBday.Location = New System.Drawing.Point(107, 380)
        Me.dtpBday.MaxDate = New Date(2010, 12, 31, 0, 0, 0, 0)
        Me.dtpBday.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpBday.Name = "dtpBday"
        Me.dtpBday.Size = New System.Drawing.Size(349, 36)
        Me.dtpBday.TabIndex = 42
        Me.dtpBday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtpBday.Value = New Date(2002, 8, 29, 0, 0, 0, 0)
        '
        'txtUsernameCreate
        '
        Me.txtUsernameCreate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameCreate.BorderThickness = 2
        Me.txtUsernameCreate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsernameCreate.DefaultText = ""
        Me.txtUsernameCreate.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtUsernameCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameCreate.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtUsernameCreate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsernameCreate.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtUsernameCreate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsernameCreate.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtUsernameCreate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameCreate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsernameCreate.Location = New System.Drawing.Point(107, 157)
        Me.txtUsernameCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsernameCreate.Name = "txtUsernameCreate"
        Me.txtUsernameCreate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsernameCreate.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtUsernameCreate.PlaceholderText = ""
        Me.txtUsernameCreate.SelectedText = ""
        Me.txtUsernameCreate.Size = New System.Drawing.Size(349, 41)
        Me.txtUsernameCreate.TabIndex = 36
        Me.txtUsernameCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(107, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Username:"
        '
        'btnCancel
        '
        Me.btnCancel.AutoRoundedCorners = True
        Me.btnCancel.BorderRadius = 16
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(285, 439)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(153, 35)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        '
        'btnCreate
        '
        Me.btnCreate.AutoRoundedCorners = True
        Me.btnCreate.BorderRadius = 16
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnCreate.Location = New System.Drawing.Point(126, 439)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(153, 35)
        Me.btnCreate.TabIndex = 32
        Me.btnCreate.Text = "Create Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(204, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 23)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Create Account"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(674, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 600)
        Me.Panel2.TabIndex = 12
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Panel4)
        Me.Panel8.Controls.Add(Me.Panel3)
        Me.Panel8.Location = New System.Drawing.Point(709, 50)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(565, 600)
        Me.Panel8.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.cbAccountTypeDelete)
        Me.Panel4.Controls.Add(Me.btnDelete)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.btnCancelDelete)
        Me.Panel4.Controls.Add(Me.dtpBDAYDelete)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtUsernameDelete)
        Me.Panel4.Location = New System.Drawing.Point(39, 705)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(475, 348)
        Me.Panel4.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(62, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 17)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Account Type:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(158, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 23)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Delete Account"
        '
        'cbAccountTypeDelete
        '
        Me.cbAccountTypeDelete.BackColor = System.Drawing.Color.Transparent
        Me.cbAccountTypeDelete.BorderColor = System.Drawing.Color.White
        Me.cbAccountTypeDelete.BorderThickness = 0
        Me.cbAccountTypeDelete.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.cbAccountTypeDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cbAccountTypeDelete.DisabledState.ForeColor = System.Drawing.Color.White
        Me.cbAccountTypeDelete.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbAccountTypeDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAccountTypeDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cbAccountTypeDelete.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbAccountTypeDelete.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbAccountTypeDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAccountTypeDelete.ForeColor = System.Drawing.Color.White
        Me.cbAccountTypeDelete.ItemHeight = 30
        Me.cbAccountTypeDelete.Items.AddRange(New Object() {"Employee", "Manager"})
        Me.cbAccountTypeDelete.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbAccountTypeDelete.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbAccountTypeDelete.Location = New System.Drawing.Point(62, 79)
        Me.cbAccountTypeDelete.Name = "cbAccountTypeDelete"
        Me.cbAccountTypeDelete.Size = New System.Drawing.Size(349, 36)
        Me.cbAccountTypeDelete.StartIndex = 0
        Me.cbAccountTypeDelete.TabIndex = 53
        Me.cbAccountTypeDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
        Me.btnDelete.AutoRoundedCorners = True
        Me.btnDelete.BorderRadius = 16
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(80, 265)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(153, 35)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "Delete Account"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(62, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Birthday:"
        '
        'btnCancelDelete
        '
        Me.btnCancelDelete.AutoRoundedCorners = True
        Me.btnCancelDelete.BorderRadius = 16
        Me.btnCancelDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancelDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancelDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancelDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDelete.ForeColor = System.Drawing.Color.White
        Me.btnCancelDelete.Location = New System.Drawing.Point(239, 265)
        Me.btnCancelDelete.Name = "btnCancelDelete"
        Me.btnCancelDelete.Size = New System.Drawing.Size(153, 35)
        Me.btnCancelDelete.TabIndex = 47
        Me.btnCancelDelete.Text = "Cancel"
        '
        'dtpBDAYDelete
        '
        Me.dtpBDAYDelete.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dtpBDAYDelete.BorderThickness = 2
        Me.dtpBDAYDelete.Checked = True
        Me.dtpBDAYDelete.CustomFormat = "MM/dd/yy"
        Me.dtpBDAYDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dtpBDAYDelete.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dtpBDAYDelete.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.dtpBDAYDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dtpBDAYDelete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBDAYDelete.Location = New System.Drawing.Point(62, 211)
        Me.dtpBDAYDelete.MaxDate = New Date(2010, 12, 31, 0, 0, 0, 0)
        Me.dtpBDAYDelete.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpBDAYDelete.Name = "dtpBDAYDelete"
        Me.dtpBDAYDelete.Size = New System.Drawing.Size(349, 36)
        Me.dtpBDAYDelete.TabIndex = 51
        Me.dtpBDAYDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtpBDAYDelete.Value = New Date(2002, 8, 29, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(62, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 17)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Username:"
        '
        'txtUsernameDelete
        '
        Me.txtUsernameDelete.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameDelete.BorderThickness = 2
        Me.txtUsernameDelete.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsernameDelete.DefaultText = ""
        Me.txtUsernameDelete.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtUsernameDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameDelete.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtUsernameDelete.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsernameDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtUsernameDelete.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsernameDelete.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtUsernameDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameDelete.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsernameDelete.Location = New System.Drawing.Point(62, 141)
        Me.txtUsernameDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsernameDelete.Name = "txtUsernameDelete"
        Me.txtUsernameDelete.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsernameDelete.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtUsernameDelete.PlaceholderText = ""
        Me.txtUsernameDelete.SelectedText = ""
        Me.txtUsernameDelete.Size = New System.Drawing.Size(349, 41)
        Me.txtUsernameDelete.TabIndex = 49
        Me.txtUsernameDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtLastNameReset)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txtFirstNameReset)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.btnDecline)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.ListBoxRequest)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cbAccountTypeReset)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.dtpBdayReset)
        Me.Panel3.Controls.Add(Me.txtUsernameReset)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnResetPassword)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.btnCancel2)
        Me.Panel3.Location = New System.Drawing.Point(39, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(475, 640)
        Me.Panel3.TabIndex = 66
        '
        'txtLastNameReset
        '
        Me.txtLastNameReset.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtLastNameReset.BorderThickness = 2
        Me.txtLastNameReset.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastNameReset.DefaultText = ""
        Me.txtLastNameReset.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtLastNameReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtLastNameReset.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtLastNameReset.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastNameReset.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtLastNameReset.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtLastNameReset.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtLastNameReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtLastNameReset.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtLastNameReset.Location = New System.Drawing.Point(62, 404)
        Me.txtLastNameReset.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastNameReset.Name = "txtLastNameReset"
        Me.txtLastNameReset.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastNameReset.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtLastNameReset.PlaceholderText = ""
        Me.txtLastNameReset.SelectedText = ""
        Me.txtLastNameReset.Size = New System.Drawing.Size(349, 41)
        Me.txtLastNameReset.TabIndex = 69
        Me.txtLastNameReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(62, 387)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 17)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "Last Name:"
        '
        'txtFirstNameReset
        '
        Me.txtFirstNameReset.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtFirstNameReset.BorderThickness = 2
        Me.txtFirstNameReset.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstNameReset.DefaultText = ""
        Me.txtFirstNameReset.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtFirstNameReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtFirstNameReset.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtFirstNameReset.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstNameReset.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtFirstNameReset.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtFirstNameReset.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtFirstNameReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtFirstNameReset.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtFirstNameReset.Location = New System.Drawing.Point(62, 346)
        Me.txtFirstNameReset.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstNameReset.Name = "txtFirstNameReset"
        Me.txtFirstNameReset.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstNameReset.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtFirstNameReset.PlaceholderText = ""
        Me.txtFirstNameReset.SelectedText = ""
        Me.txtFirstNameReset.Size = New System.Drawing.Size(349, 41)
        Me.txtFirstNameReset.TabIndex = 67
        Me.txtFirstNameReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(62, 329)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 17)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "First Name:"
        '
        'btnDecline
        '
        Me.btnDecline.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDecline.FlatAppearance.BorderSize = 0
        Me.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecline.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecline.ForeColor = System.Drawing.Color.White
        Me.btnDecline.Location = New System.Drawing.Point(336, 172)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(75, 25)
        Me.btnDecline.TabIndex = 65
        Me.btnDecline.Text = "Decline"
        Me.btnDecline.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(62, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 17)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Password reset requests:"
        '
        'ListBoxRequest
        '
        Me.ListBoxRequest.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListBoxRequest.FormattingEnabled = True
        Me.ListBoxRequest.ItemHeight = 16
        Me.ListBoxRequest.Location = New System.Drawing.Point(62, 82)
        Me.ListBoxRequest.Name = "ListBoxRequest"
        Me.ListBoxRequest.Size = New System.Drawing.Size(349, 84)
        Me.ListBoxRequest.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(62, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Account Type:"
        '
        'cbAccountTypeReset
        '
        Me.cbAccountTypeReset.BackColor = System.Drawing.Color.Transparent
        Me.cbAccountTypeReset.BorderColor = System.Drawing.Color.White
        Me.cbAccountTypeReset.BorderThickness = 0
        Me.cbAccountTypeReset.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.cbAccountTypeReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cbAccountTypeReset.DisabledState.ForeColor = System.Drawing.Color.White
        Me.cbAccountTypeReset.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbAccountTypeReset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAccountTypeReset.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cbAccountTypeReset.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbAccountTypeReset.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbAccountTypeReset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAccountTypeReset.ForeColor = System.Drawing.Color.White
        Me.cbAccountTypeReset.ItemHeight = 30
        Me.cbAccountTypeReset.Items.AddRange(New Object() {"Employee", "Manager"})
        Me.cbAccountTypeReset.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbAccountTypeReset.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbAccountTypeReset.Location = New System.Drawing.Point(62, 235)
        Me.cbAccountTypeReset.Name = "cbAccountTypeReset"
        Me.cbAccountTypeReset.Size = New System.Drawing.Size(349, 36)
        Me.cbAccountTypeReset.StartIndex = 0
        Me.cbAccountTypeReset.TabIndex = 61
        Me.cbAccountTypeReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(62, 445)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Birthday:"
        '
        'dtpBdayReset
        '
        Me.dtpBdayReset.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dtpBdayReset.BorderThickness = 2
        Me.dtpBdayReset.Checked = True
        Me.dtpBdayReset.CustomFormat = "MM/dd/yy"
        Me.dtpBdayReset.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dtpBdayReset.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dtpBdayReset.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.dtpBdayReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dtpBdayReset.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBdayReset.Location = New System.Drawing.Point(62, 462)
        Me.dtpBdayReset.MaxDate = New Date(2010, 12, 31, 0, 0, 0, 0)
        Me.dtpBdayReset.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpBdayReset.Name = "dtpBdayReset"
        Me.dtpBdayReset.Size = New System.Drawing.Size(349, 36)
        Me.dtpBdayReset.TabIndex = 59
        Me.dtpBdayReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtpBdayReset.Value = New Date(2002, 8, 29, 0, 0, 0, 0)
        '
        'txtUsernameReset
        '
        Me.txtUsernameReset.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameReset.BorderThickness = 2
        Me.txtUsernameReset.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsernameReset.DefaultText = ""
        Me.txtUsernameReset.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtUsernameReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameReset.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtUsernameReset.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsernameReset.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtUsernameReset.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsernameReset.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtUsernameReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameReset.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsernameReset.Location = New System.Drawing.Point(62, 288)
        Me.txtUsernameReset.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsernameReset.Name = "txtUsernameReset"
        Me.txtUsernameReset.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsernameReset.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtUsernameReset.PlaceholderText = ""
        Me.txtUsernameReset.SelectedText = ""
        Me.txtUsernameReset.Size = New System.Drawing.Size(349, 41)
        Me.txtUsernameReset.TabIndex = 58
        Me.txtUsernameReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(62, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Username:"
        '
        'btnResetPassword
        '
        Me.btnResetPassword.AutoRoundedCorners = True
        Me.btnResetPassword.BorderRadius = 16
        Me.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResetPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnResetPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnResetPassword.Location = New System.Drawing.Point(80, 524)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(153, 35)
        Me.btnResetPassword.TabIndex = 56
        Me.btnResetPassword.Text = "Reset Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(163, 12)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 23)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Forgot Password"
        '
        'btnCancel2
        '
        Me.btnCancel2.AutoRoundedCorners = True
        Me.btnCancel2.BorderRadius = 16
        Me.btnCancel2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel2.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnCancel2.ForeColor = System.Drawing.Color.White
        Me.btnCancel2.Location = New System.Drawing.Point(239, 524)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(153, 35)
        Me.btnCancel2.TabIndex = 41
        Me.btnCancel2.Text = "Cancel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 701)
        Me.Panel1.TabIndex = 0
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminForm"
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpBday As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtUsernameCreate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCancel2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbAccountType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnResetPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbAccountTypeReset As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpBdayReset As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtUsernameReset As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBoxRequest As ListBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbAccountTypeDelete As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCancelDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpBDAYDelete As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUsernameDelete As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDecline As Button
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtLastNameReset As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFirstNameReset As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
End Class
