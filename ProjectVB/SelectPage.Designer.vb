<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectPage))
        Me.Password1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Email = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Tel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Lastname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Firstname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BteBack = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Btn_Add = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.FM = New System.Windows.Forms.RadioButton()
        Me.Check1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.Password1.Location = New System.Drawing.Point(288, 142)
        Me.Password1.Margin = New System.Windows.Forms.Padding(4)
        Me.Password1.Name = "Password1"
        Me.Password1.Size = New System.Drawing.Size(196, 31)
        Me.Password1.TabIndex = 3
        Me.Password1.Text = "Password"
        Me.Password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Email.Location = New System.Drawing.Point(85, 220)
        Me.Email.Margin = New System.Windows.Forms.Padding(4)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(399, 31)
        Me.Email.TabIndex = 6
        Me.Email.Text = "Email"
        Me.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Tel.Location = New System.Drawing.Point(85, 259)
        Me.Tel.Margin = New System.Windows.Forms.Padding(4)
        Me.Tel.Name = "Tel"
        Me.Tel.Size = New System.Drawing.Size(196, 31)
        Me.Tel.TabIndex = 7
        Me.Tel.Text = "Tel"
        Me.Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Lastname.Location = New System.Drawing.Point(288, 181)
        Me.Lastname.Margin = New System.Windows.Forms.Padding(4)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(196, 31)
        Me.Lastname.TabIndex = 5
        Me.Lastname.Text = "Lastname"
        Me.Lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Firstname.Location = New System.Drawing.Point(85, 181)
        Me.Firstname.Margin = New System.Windows.Forms.Padding(4)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(196, 31)
        Me.Firstname.TabIndex = 4
        Me.Firstname.Text = "Firstname"
        Me.Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Password.Location = New System.Drawing.Point(85, 142)
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
        Me.Username.Location = New System.Drawing.Point(85, 103)
        Me.Username.Margin = New System.Windows.Forms.Padding(4)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(399, 31)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.BteBack.Location = New System.Drawing.Point(288, 404)
        Me.BteBack.Margin = New System.Windows.Forms.Padding(5)
        Me.BteBack.Name = "BteBack"
        Me.BteBack.Size = New System.Drawing.Size(136, 41)
        Me.BteBack.TabIndex = 8
        Me.BteBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Add
        '
        Me.Btn_Add.ActiveBorderThickness = 1
        Me.Btn_Add.ActiveCornerRadius = 20
        Me.Btn_Add.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Btn_Add.ActiveForecolor = System.Drawing.Color.Black
        Me.Btn_Add.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Add.BackgroundImage = CType(resources.GetObject("Btn_Add.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Add.ButtonText = "Add"
        Me.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Add.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Btn_Add.IdleBorderThickness = 1
        Me.Btn_Add.IdleCornerRadius = 20
        Me.Btn_Add.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Add.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Btn_Add.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Btn_Add.Location = New System.Drawing.Point(142, 404)
        Me.Btn_Add.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(136, 41)
        Me.Btn_Add.TabIndex = 9
        Me.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Male.Location = New System.Drawing.Point(110, 308)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(69, 28)
        Me.Male.TabIndex = 8
        Me.Male.TabStop = True
        Me.Male.Text = "Male"
        Me.Male.UseVisualStyleBackColor = True
        '
        'FM
        '
        Me.FM.AutoSize = True
        Me.FM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.FM.Location = New System.Drawing.Point(189, 308)
        Me.FM.Name = "FM"
        Me.FM.Size = New System.Drawing.Size(92, 28)
        Me.FM.TabIndex = 9
        Me.FM.TabStop = True
        Me.FM.Text = "Female"
        Me.FM.UseVisualStyleBackColor = True
        '
        'Check1
        '
        Me.Check1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Check1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Check1.Checked = True
        Me.Check1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Check1.ForeColor = System.Drawing.Color.White
        Me.Check1.Location = New System.Drawing.Point(110, 373)
        Me.Check1.Name = "Check1"
        Me.Check1.Size = New System.Drawing.Size(20, 20)
        Me.Check1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(138, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'SelectPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(575, 500)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Check1)
        Me.Controls.Add(Me.FM)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.Password1)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.BteBack)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Tel)
        Me.Controls.Add(Me.Lastname)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SelectPage"
        Me.Text = "SelectPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Password1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Email As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents BteBack As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents Btn_Add As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents Tel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Lastname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Firstname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Male As System.Windows.Forms.RadioButton
    Friend WithEvents FM As System.Windows.Forms.RadioButton
    Friend WithEvents Check1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
