<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Title = New System.Windows.Forms.Panel()
        Me.Footer = New System.Windows.Forms.Panel()
        Me.Menu1 = New System.Windows.Forms.Panel()
        Me.Mainpage = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Contect = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Account1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.AddData = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Games = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Logout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Midia = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Profile = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LogoMenu = New System.Windows.Forms.PictureBox()
        Me.Close1 = New System.Windows.Forms.PictureBox()
        Me.Minimize = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Title.SuspendLayout()
        Me.Menu1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LogoMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Title.Controls.Add(Me.Close1)
        Me.Title.Controls.Add(Me.Minimize)
        Me.Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(992, 41)
        Me.Title.TabIndex = 0
        '
        'Footer
        '
        Me.Footer.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Footer.Location = New System.Drawing.Point(0, 604)
        Me.Footer.Name = "Footer"
        Me.Footer.Size = New System.Drawing.Size(992, 33)
        Me.Footer.TabIndex = 1
        '
        'Menu1
        '
        Me.Menu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Menu1.Controls.Add(Me.Contect)
        Me.Menu1.Controls.Add(Me.Account1)
        Me.Menu1.Controls.Add(Me.AddData)
        Me.Menu1.Controls.Add(Me.Games)
        Me.Menu1.Controls.Add(Me.Logout)
        Me.Menu1.Controls.Add(Me.Midia)
        Me.Menu1.Controls.Add(Me.Profile)
        Me.Menu1.Controls.Add(Me.LogoMenu)
        Me.Menu1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menu1.Location = New System.Drawing.Point(0, 0)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(220, 563)
        Me.Menu1.TabIndex = 2
        '
        'Mainpage
        '
        Me.Mainpage.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Mainpage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mainpage.Location = New System.Drawing.Point(220, 0)
        Me.Mainpage.Name = "Mainpage"
        Me.Mainpage.Size = New System.Drawing.Size(772, 563)
        Me.Mainpage.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Mainpage)
        Me.Panel1.Controls.Add(Me.Menu1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 563)
        Me.Panel1.TabIndex = 4
        '
        'Contect
        '
        Me.Contect.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Contect.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Contect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Contect.BorderRadius = 0
        Me.Contect.ButtonText = "     Contect"
        Me.Contect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Contect.DisabledColor = System.Drawing.Color.Gray
        Me.Contect.Iconcolor = System.Drawing.Color.Transparent
        Me.Contect.Iconimage = Global.ProjectVB.My.Resources.Resources.web_management
        Me.Contect.Iconimage_right = Nothing
        Me.Contect.Iconimage_right_Selected = Nothing
        Me.Contect.Iconimage_Selected = Nothing
        Me.Contect.IconMarginLeft = 0
        Me.Contect.IconMarginRight = 0
        Me.Contect.IconRightVisible = True
        Me.Contect.IconRightZoom = 0.0R
        Me.Contect.IconVisible = True
        Me.Contect.IconZoom = 90.0R
        Me.Contect.IsTab = False
        Me.Contect.Location = New System.Drawing.Point(3, 325)
        Me.Contect.Name = "Contect"
        Me.Contect.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Contect.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Contect.OnHoverTextColor = System.Drawing.Color.White
        Me.Contect.selected = False
        Me.Contect.Size = New System.Drawing.Size(217, 48)
        Me.Contect.TabIndex = 9
        Me.Contect.Text = "     Contect"
        Me.Contect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Contect.Textcolor = System.Drawing.Color.White
        Me.Contect.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Account1
        '
        Me.Account1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Account1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Account1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Account1.BorderRadius = 0
        Me.Account1.ButtonText = "     Account"
        Me.Account1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Account1.DisabledColor = System.Drawing.Color.Gray
        Me.Account1.Iconcolor = System.Drawing.Color.Transparent
        Me.Account1.Iconimage = Global.ProjectVB.My.Resources.Resources.transfer
        Me.Account1.Iconimage_right = Nothing
        Me.Account1.Iconimage_right_Selected = Nothing
        Me.Account1.Iconimage_Selected = Nothing
        Me.Account1.IconMarginLeft = 0
        Me.Account1.IconMarginRight = 0
        Me.Account1.IconRightVisible = True
        Me.Account1.IconRightZoom = 0.0R
        Me.Account1.IconVisible = True
        Me.Account1.IconZoom = 90.0R
        Me.Account1.IsTab = False
        Me.Account1.Location = New System.Drawing.Point(3, 271)
        Me.Account1.Name = "Account1"
        Me.Account1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Account1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Account1.OnHoverTextColor = System.Drawing.Color.White
        Me.Account1.selected = False
        Me.Account1.Size = New System.Drawing.Size(217, 48)
        Me.Account1.TabIndex = 8
        Me.Account1.Text = "     Account"
        Me.Account1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Account1.Textcolor = System.Drawing.Color.White
        Me.Account1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'AddData
        '
        Me.AddData.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AddData.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddData.BorderRadius = 0
        Me.AddData.ButtonText = "     Add Data"
        Me.AddData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddData.DisabledColor = System.Drawing.Color.Gray
        Me.AddData.Iconcolor = System.Drawing.Color.Transparent
        Me.AddData.Iconimage = Global.ProjectVB.My.Resources.Resources.add
        Me.AddData.Iconimage_right = Nothing
        Me.AddData.Iconimage_right_Selected = Nothing
        Me.AddData.Iconimage_Selected = Nothing
        Me.AddData.IconMarginLeft = 0
        Me.AddData.IconMarginRight = 0
        Me.AddData.IconRightVisible = True
        Me.AddData.IconRightZoom = 0.0R
        Me.AddData.IconVisible = True
        Me.AddData.IconZoom = 90.0R
        Me.AddData.IsTab = False
        Me.AddData.Location = New System.Drawing.Point(3, 379)
        Me.AddData.Name = "AddData"
        Me.AddData.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddData.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AddData.OnHoverTextColor = System.Drawing.Color.White
        Me.AddData.selected = False
        Me.AddData.Size = New System.Drawing.Size(217, 48)
        Me.AddData.TabIndex = 7
        Me.AddData.Text = "     Add Data"
        Me.AddData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddData.Textcolor = System.Drawing.Color.White
        Me.AddData.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Games
        '
        Me.Games.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Games.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Games.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Games.BorderRadius = 0
        Me.Games.ButtonText = "     Games"
        Me.Games.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Games.DisabledColor = System.Drawing.Color.Gray
        Me.Games.Iconcolor = System.Drawing.Color.Transparent
        Me.Games.Iconimage = Global.ProjectVB.My.Resources.Resources.puzzle
        Me.Games.Iconimage_right = Nothing
        Me.Games.Iconimage_right_Selected = Nothing
        Me.Games.Iconimage_Selected = Nothing
        Me.Games.IconMarginLeft = 0
        Me.Games.IconMarginRight = 0
        Me.Games.IconRightVisible = True
        Me.Games.IconRightZoom = 0.0R
        Me.Games.IconVisible = True
        Me.Games.IconZoom = 90.0R
        Me.Games.IsTab = False
        Me.Games.Location = New System.Drawing.Point(3, 161)
        Me.Games.Name = "Games"
        Me.Games.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Games.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Games.OnHoverTextColor = System.Drawing.Color.White
        Me.Games.selected = False
        Me.Games.Size = New System.Drawing.Size(217, 48)
        Me.Games.TabIndex = 5
        Me.Games.Text = "     Games"
        Me.Games.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Games.Textcolor = System.Drawing.Color.White
        Me.Games.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Logout
        '
        Me.Logout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logout.BorderRadius = 0
        Me.Logout.ButtonText = "     Logout"
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.DisabledColor = System.Drawing.Color.Gray
        Me.Logout.Iconcolor = System.Drawing.Color.Transparent
        Me.Logout.Iconimage = Global.ProjectVB.My.Resources.Resources.logout
        Me.Logout.Iconimage_right = Nothing
        Me.Logout.Iconimage_right_Selected = Nothing
        Me.Logout.Iconimage_Selected = Nothing
        Me.Logout.IconMarginLeft = 0
        Me.Logout.IconMarginRight = 0
        Me.Logout.IconRightVisible = True
        Me.Logout.IconRightZoom = 0.0R
        Me.Logout.IconVisible = True
        Me.Logout.IconZoom = 90.0R
        Me.Logout.IsTab = False
        Me.Logout.Location = New System.Drawing.Point(3, 512)
        Me.Logout.Name = "Logout"
        Me.Logout.Normalcolor = System.Drawing.Color.Empty
        Me.Logout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Logout.OnHoverTextColor = System.Drawing.Color.White
        Me.Logout.selected = False
        Me.Logout.Size = New System.Drawing.Size(217, 48)
        Me.Logout.TabIndex = 4
        Me.Logout.Text = "     Logout"
        Me.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logout.Textcolor = System.Drawing.Color.White
        Me.Logout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Midia
        '
        Me.Midia.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Midia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Midia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Midia.BorderRadius = 0
        Me.Midia.ButtonText = "     Music And Video"
        Me.Midia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Midia.DisabledColor = System.Drawing.Color.Gray
        Me.Midia.Iconcolor = System.Drawing.Color.Transparent
        Me.Midia.Iconimage = CType(resources.GetObject("Midia.Iconimage"), System.Drawing.Image)
        Me.Midia.Iconimage_right = Nothing
        Me.Midia.Iconimage_right_Selected = Nothing
        Me.Midia.Iconimage_Selected = Nothing
        Me.Midia.IconMarginLeft = 0
        Me.Midia.IconMarginRight = 0
        Me.Midia.IconRightVisible = True
        Me.Midia.IconRightZoom = 0.0R
        Me.Midia.IconVisible = True
        Me.Midia.IconZoom = 90.0R
        Me.Midia.IsTab = False
        Me.Midia.Location = New System.Drawing.Point(3, 217)
        Me.Midia.Name = "Midia"
        Me.Midia.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Midia.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Midia.OnHoverTextColor = System.Drawing.Color.White
        Me.Midia.selected = False
        Me.Midia.Size = New System.Drawing.Size(217, 48)
        Me.Midia.TabIndex = 3
        Me.Midia.Text = "     Music And Video"
        Me.Midia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Midia.Textcolor = System.Drawing.Color.White
        Me.Midia.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Profile
        '
        Me.Profile.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Profile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Profile.BorderRadius = 0
        Me.Profile.ButtonText = "     Profile"
        Me.Profile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Profile.DisabledColor = System.Drawing.Color.Gray
        Me.Profile.Iconcolor = System.Drawing.Color.Transparent
        Me.Profile.Iconimage = Global.ProjectVB.My.Resources.Resources.team
        Me.Profile.Iconimage_right = Nothing
        Me.Profile.Iconimage_right_Selected = Nothing
        Me.Profile.Iconimage_Selected = Nothing
        Me.Profile.IconMarginLeft = 0
        Me.Profile.IconMarginRight = 0
        Me.Profile.IconRightVisible = True
        Me.Profile.IconRightZoom = 0.0R
        Me.Profile.IconVisible = True
        Me.Profile.IconZoom = 90.0R
        Me.Profile.IsTab = False
        Me.Profile.Location = New System.Drawing.Point(3, 109)
        Me.Profile.Name = "Profile"
        Me.Profile.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Profile.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Profile.OnHoverTextColor = System.Drawing.Color.White
        Me.Profile.selected = False
        Me.Profile.Size = New System.Drawing.Size(217, 48)
        Me.Profile.TabIndex = 1
        Me.Profile.Text = "     Profile"
        Me.Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Profile.Textcolor = System.Drawing.Color.White
        Me.Profile.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LogoMenu
        '
        Me.LogoMenu.Location = New System.Drawing.Point(75, 21)
        Me.LogoMenu.Name = "LogoMenu"
        Me.LogoMenu.Size = New System.Drawing.Size(70, 70)
        Me.LogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoMenu.TabIndex = 0
        Me.LogoMenu.TabStop = False
        '
        'Close1
        '
        Me.Close1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close1.Location = New System.Drawing.Point(956, 11)
        Me.Close1.Name = "Close1"
        Me.Close1.Size = New System.Drawing.Size(24, 24)
        Me.Close1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Close1.TabIndex = 3
        Me.Close1.TabStop = False
        '
        'Minimize
        '
        Me.Minimize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimize.Location = New System.Drawing.Point(926, 11)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(24, 24)
        Me.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Minimize.TabIndex = 1
        Me.Minimize.TabStop = False
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0.0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 351)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(220, 48)
        Me.BunifuFlatButton4.TabIndex = 3
        Me.BunifuFlatButton4.Text = "BunifuFlatButton4"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 637)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.Title.ResumeLayout(False)
        Me.Menu1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.LogoMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Panel
    Friend WithEvents Footer As System.Windows.Forms.Panel
    Friend WithEvents Menu1 As System.Windows.Forms.Panel
    Friend WithEvents Mainpage As System.Windows.Forms.Panel
    Friend WithEvents Minimize As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LogoMenu As System.Windows.Forms.PictureBox
    Friend WithEvents Midia As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Profile As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Close1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Logout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Games As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents AddData As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Account1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Contect As Bunifu.Framework.UI.BunifuFlatButton

End Class
