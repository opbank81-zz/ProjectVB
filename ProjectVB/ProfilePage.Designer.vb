<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfilePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfilePage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Update1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Email = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Lname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Fname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Update1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 650)
        Me.Panel1.TabIndex = 0
        '
        'Update1
        '
        Me.Update1.ActiveBorderThickness = 1
        Me.Update1.ActiveCornerRadius = 20
        Me.Update1.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Update1.ActiveForecolor = System.Drawing.Color.Black
        Me.Update1.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Update1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Update1.BackgroundImage = CType(resources.GetObject("Update1.BackgroundImage"), System.Drawing.Image)
        Me.Update1.ButtonText = "Update"
        Me.Update1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Update1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Update1.IdleBorderThickness = 1
        Me.Update1.IdleCornerRadius = 20
        Me.Update1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Update1.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Update1.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Update1.Location = New System.Drawing.Point(308, 427)
        Me.Update1.Margin = New System.Windows.Forms.Padding(5)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(136, 41)
        Me.Update1.TabIndex = 9
        Me.Update1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Tel)
        Me.Panel3.Controls.Add(Me.Email)
        Me.Panel3.Controls.Add(Me.Password)
        Me.Panel3.Controls.Add(Me.Lname)
        Me.Panel3.Controls.Add(Me.Fname)
        Me.Panel3.Controls.Add(Me.Username)
        Me.Panel3.Location = New System.Drawing.Point(86, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(609, 268)
        Me.Panel3.TabIndex = 1
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
        Me.Tel.Location = New System.Drawing.Point(304, 178)
        Me.Tel.Margin = New System.Windows.Forms.Padding(4)
        Me.Tel.Name = "Tel"
        Me.Tel.Size = New System.Drawing.Size(257, 31)
        Me.Tel.TabIndex = 16
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
        Me.Email.Location = New System.Drawing.Point(4, 178)
        Me.Email.Margin = New System.Windows.Forms.Padding(4)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(257, 31)
        Me.Email.TabIndex = 15
        Me.Email.Text = "Email"
        Me.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Password
        '
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Password.HintForeColor = System.Drawing.Color.Empty
        Me.Password.HintText = ""
        Me.Password.isPassword = False
        Me.Password.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Password.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Password.LineThickness = 1
        Me.Password.Location = New System.Drawing.Point(304, 4)
        Me.Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(257, 31)
        Me.Password.TabIndex = 13
        Me.Password.Text = "Password"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Lname
        '
        Me.Lname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Lname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Lname.HintForeColor = System.Drawing.Color.Empty
        Me.Lname.HintText = ""
        Me.Lname.isPassword = False
        Me.Lname.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Lname.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Lname.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Lname.LineThickness = 1
        Me.Lname.Location = New System.Drawing.Point(304, 85)
        Me.Lname.Margin = New System.Windows.Forms.Padding(4)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(257, 31)
        Me.Lname.TabIndex = 12
        Me.Lname.Text = "Lastname"
        Me.Lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Fname
        '
        Me.Fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Fname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Fname.HintForeColor = System.Drawing.Color.Empty
        Me.Fname.HintText = ""
        Me.Fname.isPassword = False
        Me.Fname.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Fname.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Fname.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Fname.LineThickness = 1
        Me.Fname.Location = New System.Drawing.Point(4, 85)
        Me.Fname.Margin = New System.Windows.Forms.Padding(4)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(257, 31)
        Me.Fname.TabIndex = 11
        Me.Fname.Text = "Firstname"
        Me.Fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Username.Location = New System.Drawing.Point(4, 4)
        Me.Username.Margin = New System.Windows.Forms.Padding(4)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(257, 31)
        Me.Username.TabIndex = 10
        Me.Username.Text = "Username"
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ProfilePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ProfilePage"
        Me.Size = New System.Drawing.Size(772, 650)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Update1 As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents Tel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Email As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Lname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Fname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Username As Bunifu.Framework.UI.BunifuMaterialTextbox

End Class
