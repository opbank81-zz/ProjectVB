<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginPage))
        Me.Password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Register1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Loginbutton = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Password.Location = New System.Drawing.Point(159, 315)
        Me.Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(257, 31)
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
        Me.Username.Location = New System.Drawing.Point(159, 260)
        Me.Username.Margin = New System.Windows.Forms.Padding(4)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(257, 31)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(185, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Register1
        '
        Me.Register1.ActiveBorderThickness = 1
        Me.Register1.ActiveCornerRadius = 20
        Me.Register1.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Register1.ActiveForecolor = System.Drawing.Color.Black
        Me.Register1.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Register1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Register1.BackgroundImage = CType(resources.GetObject("Register1.BackgroundImage"), System.Drawing.Image)
        Me.Register1.ButtonText = "Register"
        Me.Register1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Register1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Register1.IdleBorderThickness = 1
        Me.Register1.IdleCornerRadius = 20
        Me.Register1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Register1.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Register1.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Register1.Location = New System.Drawing.Point(221, 427)
        Me.Register1.Margin = New System.Windows.Forms.Padding(5)
        Me.Register1.Name = "Register1"
        Me.Register1.Size = New System.Drawing.Size(136, 41)
        Me.Register1.TabIndex = 0
        Me.Register1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Loginbutton
        '
        Me.Loginbutton.ActiveBorderThickness = 1
        Me.Loginbutton.ActiveCornerRadius = 20
        Me.Loginbutton.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Loginbutton.ActiveForecolor = System.Drawing.Color.Black
        Me.Loginbutton.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Loginbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Loginbutton.BackgroundImage = CType(resources.GetObject("Loginbutton.BackgroundImage"), System.Drawing.Image)
        Me.Loginbutton.ButtonText = "Login"
        Me.Loginbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Loginbutton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Loginbutton.IdleBorderThickness = 1
        Me.Loginbutton.IdleCornerRadius = 20
        Me.Loginbutton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Loginbutton.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Loginbutton.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Loginbutton.Location = New System.Drawing.Point(221, 376)
        Me.Loginbutton.Margin = New System.Windows.Forms.Padding(5)
        Me.Loginbutton.Name = "Loginbutton"
        Me.Loginbutton.Size = New System.Drawing.Size(136, 41)
        Me.Loginbutton.TabIndex = 0
        Me.Loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Register1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Loginbutton)
        Me.Name = "loginPage"
        Me.Size = New System.Drawing.Size(575, 500)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents Register1 As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents Password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Loginbutton As Bunifu.Framework.UI.BunifuThinButton2

End Class
