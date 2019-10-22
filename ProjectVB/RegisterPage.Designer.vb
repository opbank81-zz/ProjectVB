<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterPage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterPage))
        Me.Password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Firstname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Lastname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Tel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Email = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BteBack = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnRegis = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Password1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Check1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.FM = New System.Windows.Forms.RadioButton()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Password
        '
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Password.HintForeColor = System.Drawing.Color.Empty
        Me.Password.HintText = ""
        Me.Password.isPassword = True
        Me.Password.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Password.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Password.LineThickness = 1
        Me.Password.Location = New System.Drawing.Point(81, 141)
        Me.Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(196, 31)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Username
        '
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Username.HintForeColor = System.Drawing.Color.Empty
        Me.Username.HintText = ""
        Me.Username.isPassword = False
        Me.Username.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Username.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Username.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Username.LineThickness = 1
        Me.Username.Location = New System.Drawing.Point(81, 102)
        Me.Username.Margin = New System.Windows.Forms.Padding(4)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(399, 31)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Firstname
        '
        Me.Firstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Firstname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Firstname.HintForeColor = System.Drawing.Color.Empty
        Me.Firstname.HintText = ""
        Me.Firstname.isPassword = False
        Me.Firstname.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Firstname.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Firstname.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Firstname.LineThickness = 1
        Me.Firstname.Location = New System.Drawing.Point(81, 180)
        Me.Firstname.Margin = New System.Windows.Forms.Padding(4)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(196, 31)
        Me.Firstname.TabIndex = 4
        Me.Firstname.Text = "Firstname"
        Me.Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Lastname
        '
        Me.Lastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Lastname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Lastname.HintForeColor = System.Drawing.Color.Empty
        Me.Lastname.HintText = ""
        Me.Lastname.isPassword = False
        Me.Lastname.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Lastname.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Lastname.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Lastname.LineThickness = 1
        Me.Lastname.Location = New System.Drawing.Point(284, 180)
        Me.Lastname.Margin = New System.Windows.Forms.Padding(4)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(196, 31)
        Me.Lastname.TabIndex = 5
        Me.Lastname.Text = "Lastname"
        Me.Lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Tel
        '
        Me.Tel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Tel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Tel.HintForeColor = System.Drawing.Color.Empty
        Me.Tel.HintText = ""
        Me.Tel.isPassword = False
        Me.Tel.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Tel.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Tel.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Tel.LineThickness = 1
        Me.Tel.Location = New System.Drawing.Point(81, 258)
        Me.Tel.Margin = New System.Windows.Forms.Padding(4)
        Me.Tel.Name = "Tel"
        Me.Tel.Size = New System.Drawing.Size(196, 31)
        Me.Tel.TabIndex = 7
        Me.Tel.Text = "Tel"
        Me.Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Email
        '
        Me.Email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Email.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Email.HintForeColor = System.Drawing.Color.Empty
        Me.Email.HintText = ""
        Me.Email.isPassword = False
        Me.Email.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Email.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Email.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Email.LineThickness = 1
        Me.Email.Location = New System.Drawing.Point(81, 219)
        Me.Email.Margin = New System.Windows.Forms.Padding(4)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(399, 31)
        Me.Email.TabIndex = 6
        Me.Email.Text = "Email"
        Me.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BteBack
        '
        Me.BteBack.ActiveBorderThickness = 1
        Me.BteBack.ActiveCornerRadius = 20
        Me.BteBack.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BteBack.ActiveForecolor = System.Drawing.Color.Black
        Me.BteBack.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BteBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BteBack.BackgroundImage = CType(resources.GetObject("BteBack.BackgroundImage"), System.Drawing.Image)
        Me.BteBack.ButtonText = "Back"
        Me.BteBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BteBack.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BteBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BteBack.IdleBorderThickness = 1
        Me.BteBack.IdleCornerRadius = 20
        Me.BteBack.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BteBack.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BteBack.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BteBack.Location = New System.Drawing.Point(284, 404)
        Me.BteBack.Margin = New System.Windows.Forms.Padding(5)
        Me.BteBack.Name = "BteBack"
        Me.BteBack.Size = New System.Drawing.Size(136, 41)
        Me.BteBack.TabIndex = 0
        Me.BteBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnRegis
        '
        Me.BtnRegis.ActiveBorderThickness = 1
        Me.BtnRegis.ActiveCornerRadius = 20
        Me.BtnRegis.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnRegis.ActiveForecolor = System.Drawing.Color.Black
        Me.BtnRegis.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnRegis.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnRegis.BackgroundImage = CType(resources.GetObject("BtnRegis.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegis.ButtonText = "Register"
        Me.BtnRegis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegis.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BtnRegis.IdleBorderThickness = 1
        Me.BtnRegis.IdleCornerRadius = 20
        Me.BtnRegis.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRegis.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BtnRegis.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BtnRegis.Location = New System.Drawing.Point(138, 404)
        Me.BtnRegis.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnRegis.Name = "BtnRegis"
        Me.BtnRegis.Size = New System.Drawing.Size(136, 41)
        Me.BtnRegis.TabIndex = 0
        Me.BtnRegis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Password1
        '
        Me.Password1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Password1.HintForeColor = System.Drawing.Color.Empty
        Me.Password1.HintText = ""
        Me.Password1.isPassword = True
        Me.Password1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Password1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Password1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Password1.LineThickness = 1
        Me.Password1.Location = New System.Drawing.Point(284, 141)
        Me.Password1.Margin = New System.Windows.Forms.Padding(4)
        Me.Password1.Name = "Password1"
        Me.Password1.Size = New System.Drawing.Size(196, 31)
        Me.Password1.TabIndex = 3
        Me.Password1.Text = "Password"
        Me.Password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(211, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        '
        'Check1
        '
        Me.Check1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Check1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Check1.Checked = True
        Me.Check1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Check1.ForeColor = System.Drawing.Color.White
        Me.Check1.Location = New System.Drawing.Point(183, 368)
        Me.Check1.Name = "Check1"
        Me.Check1.Size = New System.Drawing.Size(20, 20)
        Me.Check1.TabIndex = 11
        '
        'FM
        '
        Me.FM.AutoSize = True
        Me.FM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.FM.Location = New System.Drawing.Point(284, 303)
        Me.FM.Name = "FM"
        Me.FM.Size = New System.Drawing.Size(92, 28)
        Me.FM.TabIndex = 13
        Me.FM.TabStop = True
        Me.FM.Text = "Female"
        Me.FM.UseVisualStyleBackColor = True
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Male.Location = New System.Drawing.Point(205, 303)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(69, 28)
        Me.Male.TabIndex = 12
        Me.Male.TabStop = True
        Me.Male.Text = "Male"
        Me.Male.UseVisualStyleBackColor = True
        '
        'RegisterPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Check1)
        Me.Controls.Add(Me.FM)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.Password1)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.BteBack)
        Me.Controls.Add(Me.BtnRegis)
        Me.Controls.Add(Me.Tel)
        Me.Controls.Add(Me.Lastname)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Name = "RegisterPage"
        Me.Size = New System.Drawing.Size(575, 500)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Firstname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Lastname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Tel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents BtnRegis As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents BteBack As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents Email As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Password1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Check1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents FM As System.Windows.Forms.RadioButton
    Friend WithEvents Male As System.Windows.Forms.RadioButton

End Class
