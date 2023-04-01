<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn_Form))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.LogInForm = New System.Windows.Forms.TabPage()
        Me.linkForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.cbLoginType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPassword1 = New System.Windows.Forms.Button()
        Me.txtUserNameLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPasswordLogin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.EmployeeChoice = New System.Windows.Forms.TabPage()
        Me.btnBackToLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnExitGate = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnEntranceGate = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.tabSetNewPass = New System.Windows.Forms.TabPage()
        Me.txtAccountType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsernameCreate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnPassword3 = New System.Windows.Forms.Button()
        Me.btnPassword2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdatePassword = New Guna.UI2.WinForms.Guna2Button()
        Me.requestPassword = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbAccountTypeRequest = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpBdayRequest = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtUsernameRequest = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancenRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.TabControl.SuspendLayout()
        Me.LogInForm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeChoice.SuspendLayout()
        Me.tabSetNewPass.SuspendLayout()
        Me.requestPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.LogInForm)
        Me.TabControl.Controls.Add(Me.EmployeeChoice)
        Me.TabControl.Controls.Add(Me.tabSetNewPass)
        Me.TabControl.Controls.Add(Me.requestPassword)
        Me.TabControl.Location = New System.Drawing.Point(455, 66)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(456, 637)
        Me.TabControl.TabIndex = 0
        '
        'LogInForm
        '
        Me.LogInForm.BackColor = System.Drawing.Color.White
        Me.LogInForm.Controls.Add(Me.linkForgotPassword)
        Me.LogInForm.Controls.Add(Me.cbLoginType)
        Me.LogInForm.Controls.Add(Me.Label3)
        Me.LogInForm.Controls.Add(Me.txtPassword1)
        Me.LogInForm.Controls.Add(Me.PictureBox1)
        Me.LogInForm.Controls.Add(Me.btnPassword1)
        Me.LogInForm.Controls.Add(Me.txtUserNameLogin)
        Me.LogInForm.Controls.Add(Me.txtPasswordLogin)
        Me.LogInForm.Controls.Add(Me.Label1)
        Me.LogInForm.Controls.Add(Me.btnExit)
        Me.LogInForm.Controls.Add(Me.btnLogin)
        Me.LogInForm.Location = New System.Drawing.Point(4, 22)
        Me.LogInForm.Name = "LogInForm"
        Me.LogInForm.Padding = New System.Windows.Forms.Padding(3)
        Me.LogInForm.Size = New System.Drawing.Size(448, 611)
        Me.LogInForm.TabIndex = 0
        Me.LogInForm.Text = "Log In"
        '
        'linkForgotPassword
        '
        Me.linkForgotPassword.AutoSize = True
        Me.linkForgotPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkForgotPassword.Location = New System.Drawing.Point(150, 523)
        Me.linkForgotPassword.Name = "linkForgotPassword"
        Me.linkForgotPassword.Size = New System.Drawing.Size(148, 21)
        Me.linkForgotPassword.TabIndex = 30
        Me.linkForgotPassword.TabStop = True
        Me.linkForgotPassword.Text = "Forgot password?"
        '
        'cbLoginType
        '
        Me.cbLoginType.BackColor = System.Drawing.Color.Transparent
        Me.cbLoginType.BorderColor = System.Drawing.Color.White
        Me.cbLoginType.BorderThickness = 2
        Me.cbLoginType.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.cbLoginType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cbLoginType.DisabledState.ForeColor = System.Drawing.Color.White
        Me.cbLoginType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbLoginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoginType.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cbLoginType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbLoginType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbLoginType.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoginType.ForeColor = System.Drawing.Color.White
        Me.cbLoginType.ItemHeight = 30
        Me.cbLoginType.Items.AddRange(New Object() {"Employee", "Admin", "Manager"})
        Me.cbLoginType.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbLoginType.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbLoginType.Location = New System.Drawing.Point(49, 218)
        Me.cbLoginType.Name = "cbLoginType"
        Me.cbLoginType.Size = New System.Drawing.Size(349, 36)
        Me.cbLoginType.StartIndex = 0
        Me.cbLoginType.TabIndex = 29
        Me.cbLoginType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Who's loggin in?"
        '
        'txtPassword1
        '
        Me.txtPassword1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPassword1.BorderThickness = 2
        Me.txtPassword1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword1.DefaultText = ""
        Me.txtPassword1.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtPassword1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPassword1.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtPassword1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword1.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtPassword1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPassword1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPassword1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPassword1.Location = New System.Drawing.Point(49, 360)
        Me.txtPassword1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword1.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtPassword1.PlaceholderText = ""
        Me.txtPassword1.SelectedText = ""
        Me.txtPassword1.Size = New System.Drawing.Size(310, 41)
        Me.txtPassword1.TabIndex = 7
        Me.txtPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.Software_Design.My.Resources.Resources.Par_KINGS
        Me.PictureBox1.Location = New System.Drawing.Point(50, 57)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btnPassword1
        '
        Me.btnPassword1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnPassword1.BackgroundImage = Global.Software_Design.My.Resources.Resources.hide
        Me.btnPassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPassword1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPassword1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnPassword1.FlatAppearance.BorderSize = 2
        Me.btnPassword1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword1.Location = New System.Drawing.Point(357, 360)
        Me.btnPassword1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPassword1.Name = "btnPassword1"
        Me.btnPassword1.Size = New System.Drawing.Size(41, 41)
        Me.btnPassword1.TabIndex = 22
        Me.btnPassword1.UseVisualStyleBackColor = False
        '
        'txtUserNameLogin
        '
        Me.txtUserNameLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUserNameLogin.BorderThickness = 2
        Me.txtUserNameLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserNameLogin.DefaultText = ""
        Me.txtUserNameLogin.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtUserNameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUserNameLogin.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtUserNameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserNameLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtUserNameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUserNameLogin.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtUserNameLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUserNameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUserNameLogin.Location = New System.Drawing.Point(49, 288)
        Me.txtUserNameLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserNameLogin.Name = "txtUserNameLogin"
        Me.txtUserNameLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserNameLogin.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtUserNameLogin.PlaceholderText = ""
        Me.txtUserNameLogin.SelectedText = ""
        Me.txtUserNameLogin.Size = New System.Drawing.Size(349, 41)
        Me.txtUserNameLogin.TabIndex = 6
        Me.txtUserNameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPasswordLogin
        '
        Me.txtPasswordLogin.AutoSize = True
        Me.txtPasswordLogin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPasswordLogin.Location = New System.Drawing.Point(49, 339)
        Me.txtPasswordLogin.Name = "txtPasswordLogin"
        Me.txtPasswordLogin.Size = New System.Drawing.Size(101, 23)
        Me.txtPasswordLogin.TabIndex = 3
        Me.txtPasswordLogin.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(49, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'btnExit
        '
        Me.btnExit.AutoRoundedCorners = True
        Me.btnExit.BorderRadius = 16
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(229, 444)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 35)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        '
        'btnLogin
        '
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BorderRadius = 16
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(64, 444)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(153, 35)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        '
        'EmployeeChoice
        '
        Me.EmployeeChoice.BackColor = System.Drawing.Color.White
        Me.EmployeeChoice.Controls.Add(Me.btnBackToLogin)
        Me.EmployeeChoice.Controls.Add(Me.Label14)
        Me.EmployeeChoice.Controls.Add(Me.Label13)
        Me.EmployeeChoice.Controls.Add(Me.btnExitGate)
        Me.EmployeeChoice.Controls.Add(Me.Label12)
        Me.EmployeeChoice.Controls.Add(Me.btnEntranceGate)
        Me.EmployeeChoice.Location = New System.Drawing.Point(4, 22)
        Me.EmployeeChoice.Name = "EmployeeChoice"
        Me.EmployeeChoice.Padding = New System.Windows.Forms.Padding(3)
        Me.EmployeeChoice.Size = New System.Drawing.Size(448, 611)
        Me.EmployeeChoice.TabIndex = 3
        Me.EmployeeChoice.Text = "Employee Choice"
        '
        'btnBackToLogin
        '
        Me.btnBackToLogin.AutoRoundedCorners = True
        Me.btnBackToLogin.BorderRadius = 16
        Me.btnBackToLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackToLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackToLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackToLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackToLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBackToLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToLogin.ForeColor = System.Drawing.Color.White
        Me.btnBackToLogin.Location = New System.Drawing.Point(148, 491)
        Me.btnBackToLogin.Name = "btnBackToLogin"
        Me.btnBackToLogin.Size = New System.Drawing.Size(153, 35)
        Me.btnBackToLogin.TabIndex = 41
        Me.btnBackToLogin.Text = "Cancel"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(160, 141)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 23)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "WHICH FORM?"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(299, 388)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 23)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "EXIT"
        '
        'btnExitGate
        '
        Me.btnExitGate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExitGate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExitGate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExitGate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExitGate.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnExitGate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExitGate.ForeColor = System.Drawing.Color.White
        Me.btnExitGate.Image = Global.Software_Design.My.Resources.Resources._exit
        Me.btnExitGate.ImageSize = New System.Drawing.Size(140, 140)
        Me.btnExitGate.Location = New System.Drawing.Point(241, 206)
        Me.btnExitGate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExitGate.Name = "btnExitGate"
        Me.btnExitGate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnExitGate.Size = New System.Drawing.Size(158, 167)
        Me.btnExitGate.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(64, 388)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 23)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "ENTRANCE"
        '
        'btnEntranceGate
        '
        Me.btnEntranceGate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEntranceGate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEntranceGate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEntranceGate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEntranceGate.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnEntranceGate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEntranceGate.ForeColor = System.Drawing.Color.White
        Me.btnEntranceGate.Image = Global.Software_Design.My.Resources.Resources.entrance
        Me.btnEntranceGate.ImageSize = New System.Drawing.Size(160, 160)
        Me.btnEntranceGate.Location = New System.Drawing.Point(34, 206)
        Me.btnEntranceGate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEntranceGate.Name = "btnEntranceGate"
        Me.btnEntranceGate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnEntranceGate.Size = New System.Drawing.Size(158, 167)
        Me.btnEntranceGate.TabIndex = 0
        '
        'tabSetNewPass
        '
        Me.tabSetNewPass.BackColor = System.Drawing.Color.White
        Me.tabSetNewPass.Controls.Add(Me.txtAccountType)
        Me.tabSetNewPass.Controls.Add(Me.Label4)
        Me.tabSetNewPass.Controls.Add(Me.txtUsernameCreate)
        Me.tabSetNewPass.Controls.Add(Me.Label7)
        Me.tabSetNewPass.Controls.Add(Me.Label2)
        Me.tabSetNewPass.Controls.Add(Me.txtPassword3)
        Me.tabSetNewPass.Controls.Add(Me.txtPassword2)
        Me.tabSetNewPass.Controls.Add(Me.btnPassword3)
        Me.tabSetNewPass.Controls.Add(Me.btnPassword2)
        Me.tabSetNewPass.Controls.Add(Me.Label8)
        Me.tabSetNewPass.Controls.Add(Me.Label6)
        Me.tabSetNewPass.Controls.Add(Me.Guna2Button1)
        Me.tabSetNewPass.Controls.Add(Me.btnUpdatePassword)
        Me.tabSetNewPass.Location = New System.Drawing.Point(4, 22)
        Me.tabSetNewPass.Name = "tabSetNewPass"
        Me.tabSetNewPass.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSetNewPass.Size = New System.Drawing.Size(448, 611)
        Me.tabSetNewPass.TabIndex = 4
        Me.tabSetNewPass.Text = "Set New Password"
        '
        'txtAccountType
        '
        Me.txtAccountType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtAccountType.BorderThickness = 2
        Me.txtAccountType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAccountType.DefaultText = ""
        Me.txtAccountType.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtAccountType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtAccountType.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtAccountType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAccountType.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtAccountType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAccountType.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtAccountType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtAccountType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAccountType.Location = New System.Drawing.Point(54, 167)
        Me.txtAccountType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccountType.Name = "txtAccountType"
        Me.txtAccountType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccountType.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtAccountType.PlaceholderText = ""
        Me.txtAccountType.ReadOnly = True
        Me.txtAccountType.SelectedText = ""
        Me.txtAccountType.Size = New System.Drawing.Size(349, 41)
        Me.txtAccountType.TabIndex = 50
        Me.txtAccountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(54, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Account Type:"
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
        Me.txtUsernameCreate.Location = New System.Drawing.Point(54, 235)
        Me.txtUsernameCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsernameCreate.Name = "txtUsernameCreate"
        Me.txtUsernameCreate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsernameCreate.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtUsernameCreate.PlaceholderText = ""
        Me.txtUsernameCreate.ReadOnly = True
        Me.txtUsernameCreate.SelectedText = ""
        Me.txtUsernameCreate.Size = New System.Drawing.Size(349, 41)
        Me.txtUsernameCreate.TabIndex = 48
        Me.txtUsernameCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(54, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(127, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 23)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Set your new password"
        '
        'txtPassword3
        '
        Me.txtPassword3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPassword3.BorderThickness = 2
        Me.txtPassword3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword3.DefaultText = ""
        Me.txtPassword3.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtPassword3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPassword3.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtPassword3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword3.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtPassword3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPassword3.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtPassword3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPassword3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPassword3.Location = New System.Drawing.Point(54, 375)
        Me.txtPassword3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword3.Name = "txtPassword3"
        Me.txtPassword3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword3.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtPassword3.PlaceholderText = ""
        Me.txtPassword3.SelectedText = ""
        Me.txtPassword3.Size = New System.Drawing.Size(313, 41)
        Me.txtPassword3.TabIndex = 41
        Me.txtPassword3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword2
        '
        Me.txtPassword2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPassword2.BorderThickness = 2
        Me.txtPassword2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword2.DefaultText = ""
        Me.txtPassword2.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPassword2.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword2.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtPassword2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPassword2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPassword2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPassword2.Location = New System.Drawing.Point(54, 306)
        Me.txtPassword2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword2.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtPassword2.PlaceholderText = ""
        Me.txtPassword2.SelectedText = ""
        Me.txtPassword2.Size = New System.Drawing.Size(313, 41)
        Me.txtPassword2.TabIndex = 40
        Me.txtPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPassword3
        '
        Me.btnPassword3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnPassword3.BackgroundImage = Global.Software_Design.My.Resources.Resources.hide
        Me.btnPassword3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPassword3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPassword3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnPassword3.FlatAppearance.BorderSize = 2
        Me.btnPassword3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword3.Location = New System.Drawing.Point(365, 375)
        Me.btnPassword3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPassword3.Name = "btnPassword3"
        Me.btnPassword3.Size = New System.Drawing.Size(38, 41)
        Me.btnPassword3.TabIndex = 45
        Me.btnPassword3.UseVisualStyleBackColor = False
        '
        'btnPassword2
        '
        Me.btnPassword2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnPassword2.BackgroundImage = Global.Software_Design.My.Resources.Resources.hide
        Me.btnPassword2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPassword2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPassword2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnPassword2.FlatAppearance.BorderSize = 2
        Me.btnPassword2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword2.Location = New System.Drawing.Point(365, 306)
        Me.btnPassword2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPassword2.Name = "btnPassword2"
        Me.btnPassword2.Size = New System.Drawing.Size(38, 41)
        Me.btnPassword2.TabIndex = 44
        Me.btnPassword2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(54, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 17)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Confirm Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(54, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Passsword:"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 16
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(229, 458)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(153, 35)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Cancel"
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.AutoRoundedCorners = True
        Me.btnUpdatePassword.BorderRadius = 16
        Me.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdatePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdatePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdatePassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnUpdatePassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnUpdatePassword.Location = New System.Drawing.Point(64, 458)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(153, 35)
        Me.btnUpdatePassword.TabIndex = 2
        Me.btnUpdatePassword.Text = "Update Password"
        '
        'requestPassword
        '
        Me.requestPassword.Controls.Add(Me.Label10)
        Me.requestPassword.Controls.Add(Me.Label5)
        Me.requestPassword.Controls.Add(Me.cbAccountTypeRequest)
        Me.requestPassword.Controls.Add(Me.Label15)
        Me.requestPassword.Controls.Add(Me.dtpBdayRequest)
        Me.requestPassword.Controls.Add(Me.txtUsernameRequest)
        Me.requestPassword.Controls.Add(Me.Label9)
        Me.requestPassword.Controls.Add(Me.btnCancenRequest)
        Me.requestPassword.Controls.Add(Me.btnRequest)
        Me.requestPassword.Location = New System.Drawing.Point(4, 22)
        Me.requestPassword.Name = "requestPassword"
        Me.requestPassword.Padding = New System.Windows.Forms.Padding(3)
        Me.requestPassword.Size = New System.Drawing.Size(448, 611)
        Me.requestPassword.TabIndex = 5
        Me.requestPassword.Text = "RequestPassword"
        Me.requestPassword.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(100, 90)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(249, 23)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "REQUEST PASSWORD RESET"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(43, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Account Type:"
        '
        'cbAccountTypeRequest
        '
        Me.cbAccountTypeRequest.BackColor = System.Drawing.Color.Transparent
        Me.cbAccountTypeRequest.BorderColor = System.Drawing.Color.White
        Me.cbAccountTypeRequest.BorderThickness = 0
        Me.cbAccountTypeRequest.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.cbAccountTypeRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cbAccountTypeRequest.DisabledState.ForeColor = System.Drawing.Color.White
        Me.cbAccountTypeRequest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbAccountTypeRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAccountTypeRequest.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cbAccountTypeRequest.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbAccountTypeRequest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbAccountTypeRequest.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAccountTypeRequest.ForeColor = System.Drawing.Color.White
        Me.cbAccountTypeRequest.ItemHeight = 30
        Me.cbAccountTypeRequest.Items.AddRange(New Object() {"Employee", "Manager"})
        Me.cbAccountTypeRequest.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbAccountTypeRequest.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbAccountTypeRequest.Location = New System.Drawing.Point(43, 199)
        Me.cbAccountTypeRequest.Name = "cbAccountTypeRequest"
        Me.cbAccountTypeRequest.Size = New System.Drawing.Size(349, 36)
        Me.cbAccountTypeRequest.StartIndex = 0
        Me.cbAccountTypeRequest.TabIndex = 50
        Me.cbAccountTypeRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(43, 308)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 17)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Birthday:"
        '
        'dtpBdayRequest
        '
        Me.dtpBdayRequest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dtpBdayRequest.BorderThickness = 2
        Me.dtpBdayRequest.Checked = True
        Me.dtpBdayRequest.CustomFormat = "MM/dd/yy"
        Me.dtpBdayRequest.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dtpBdayRequest.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dtpBdayRequest.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.dtpBdayRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dtpBdayRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBdayRequest.Location = New System.Drawing.Point(43, 331)
        Me.dtpBdayRequest.MaxDate = New Date(2010, 12, 31, 0, 0, 0, 0)
        Me.dtpBdayRequest.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpBdayRequest.Name = "dtpBdayRequest"
        Me.dtpBdayRequest.Size = New System.Drawing.Size(349, 36)
        Me.dtpBdayRequest.TabIndex = 48
        Me.dtpBdayRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtpBdayRequest.Value = New Date(2002, 8, 29, 0, 0, 0, 0)
        '
        'txtUsernameRequest
        '
        Me.txtUsernameRequest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameRequest.BorderThickness = 2
        Me.txtUsernameRequest.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsernameRequest.DefaultText = ""
        Me.txtUsernameRequest.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtUsernameRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameRequest.DisabledState.ForeColor = System.Drawing.Color.White
        Me.txtUsernameRequest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsernameRequest.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtUsernameRequest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsernameRequest.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtUsernameRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsernameRequest.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsernameRequest.Location = New System.Drawing.Point(43, 261)
        Me.txtUsernameRequest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsernameRequest.Name = "txtUsernameRequest"
        Me.txtUsernameRequest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsernameRequest.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtUsernameRequest.PlaceholderText = ""
        Me.txtUsernameRequest.SelectedText = ""
        Me.txtUsernameRequest.Size = New System.Drawing.Size(349, 41)
        Me.txtUsernameRequest.TabIndex = 47
        Me.txtUsernameRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(43, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Username:"
        '
        'btnCancenRequest
        '
        Me.btnCancenRequest.AutoRoundedCorners = True
        Me.btnCancenRequest.BorderRadius = 16
        Me.btnCancenRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancenRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancenRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancenRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancenRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancenRequest.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancenRequest.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnCancenRequest.ForeColor = System.Drawing.Color.White
        Me.btnCancenRequest.Location = New System.Drawing.Point(239, 436)
        Me.btnCancenRequest.Name = "btnCancenRequest"
        Me.btnCancenRequest.Size = New System.Drawing.Size(153, 35)
        Me.btnCancenRequest.TabIndex = 3
        Me.btnCancenRequest.Text = "Cancel"
        '
        'btnRequest
        '
        Me.btnRequest.AutoRoundedCorners = True
        Me.btnRequest.BorderRadius = 16
        Me.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRequest.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnRequest.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnRequest.Location = New System.Drawing.Point(74, 436)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(153, 35)
        Me.btnRequest.TabIndex = 2
        Me.btnRequest.Text = "Request"
        '
        'LogIn_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Software_Design.My.Resources.Resources.Login_Form_BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogIn_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn_Form"
        Me.TabControl.ResumeLayout(False)
        Me.LogInForm.ResumeLayout(False)
        Me.LogInForm.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeChoice.ResumeLayout(False)
        Me.EmployeeChoice.PerformLayout()
        Me.tabSetNewPass.ResumeLayout(False)
        Me.tabSetNewPass.PerformLayout()
        Me.requestPassword.ResumeLayout(False)
        Me.requestPassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As TabControl
    Friend WithEvents LogInForm As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPassword1 As Button
    Friend WithEvents txtUserNameLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPasswordLogin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPassword1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmployeeChoice As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnExitGate As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label12 As Label
    Friend WithEvents btnEntranceGate As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnBackToLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbLoginType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tabSetNewPass As TabPage
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdatePassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPassword3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnPassword3 As Button
    Friend WithEvents btnPassword2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsernameCreate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAccountType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents linkForgotPassword As LinkLabel
    Friend WithEvents requestPassword As TabPage
    Friend WithEvents btnCancenRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbAccountTypeRequest As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpBdayRequest As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtUsernameRequest As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
