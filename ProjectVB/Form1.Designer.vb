<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Title = New System.Windows.Forms.Panel()
        Me.Close1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minimize = New System.Windows.Forms.PictureBox()
        Me.Footer = New System.Windows.Forms.Panel()
        Me.Menu1 = New System.Windows.Forms.Panel()
        Me.Score = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Home = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LogoMenu = New System.Windows.Forms.PictureBox()
        Me.Mainpage = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Title.SuspendLayout()
        CType(Me.Close1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu1.SuspendLayout()
        CType(Me.LogoMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Title.Controls.Add(Me.Close1)
        Me.Title.Controls.Add(Me.Label1)
        Me.Title.Controls.Add(Me.Minimize)
        Me.Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(992, 41)
        Me.Title.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
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
        Me.Menu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Menu1.Controls.Add(Me.Score)
        Me.Menu1.Controls.Add(Me.BunifuFlatButton3)
        Me.Menu1.Controls.Add(Me.BunifuFlatButton2)
        Me.Menu1.Controls.Add(Me.Home)
        Me.Menu1.Controls.Add(Me.LogoMenu)
        Me.Menu1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menu1.Location = New System.Drawing.Point(0, 41)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(220, 563)
        Me.Menu1.TabIndex = 2
        '
        'Score
        '
        Me.Score.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Score.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Score.BorderRadius = 0
        Me.Score.ButtonText = "BunifuFlatButton4"
        Me.Score.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Score.DisabledColor = System.Drawing.Color.Gray
        Me.Score.Iconcolor = System.Drawing.Color.Transparent
        Me.Score.Iconimage = CType(resources.GetObject("Score.Iconimage"), System.Drawing.Image)
        Me.Score.Iconimage_right = Nothing
        Me.Score.Iconimage_right_Selected = Nothing
        Me.Score.Iconimage_Selected = Nothing
        Me.Score.IconMarginLeft = 0
        Me.Score.IconMarginRight = 0
        Me.Score.IconRightVisible = True
        Me.Score.IconRightZoom = 0.0R
        Me.Score.IconVisible = True
        Me.Score.IconZoom = 90.0R
        Me.Score.IsTab = False
        Me.Score.Location = New System.Drawing.Point(0, 313)
        Me.Score.Name = "Score"
        Me.Score.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Score.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Score.OnHoverTextColor = System.Drawing.Color.White
        Me.Score.selected = False
        Me.Score.Size = New System.Drawing.Size(220, 48)
        Me.Score.TabIndex = 3
        Me.Score.Text = "BunifuFlatButton4"
        Me.Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Score.Textcolor = System.Drawing.Color.White
        Me.Score.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Account"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0.0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 259)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(220, 48)
        Me.BunifuFlatButton3.TabIndex = 2
        Me.BunifuFlatButton3.Text = "Account"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Game"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0.0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 205)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(220, 48)
        Me.BunifuFlatButton2.TabIndex = 1
        Me.BunifuFlatButton2.Text = "Game"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Home
        '
        Me.Home.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Home.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Home.BorderRadius = 0
        Me.Home.ButtonText = "Dashboard"
        Me.Home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home.DisabledColor = System.Drawing.Color.Gray
        Me.Home.Iconcolor = System.Drawing.Color.Transparent
        Me.Home.Iconimage = CType(resources.GetObject("Home.Iconimage"), System.Drawing.Image)
        Me.Home.Iconimage_right = Nothing
        Me.Home.Iconimage_right_Selected = Nothing
        Me.Home.Iconimage_Selected = Nothing
        Me.Home.IconMarginLeft = 0
        Me.Home.IconMarginRight = 0
        Me.Home.IconRightVisible = True
        Me.Home.IconRightZoom = 0.0R
        Me.Home.IconVisible = True
        Me.Home.IconZoom = 90.0R
        Me.Home.IsTab = False
        Me.Home.Location = New System.Drawing.Point(0, 151)
        Me.Home.Name = "Home"
        Me.Home.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Home.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Home.OnHoverTextColor = System.Drawing.Color.White
        Me.Home.selected = False
        Me.Home.Size = New System.Drawing.Size(220, 48)
        Me.Home.TabIndex = 0
        Me.Home.Text = "Dashboard"
        Me.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Home.Textcolor = System.Drawing.Color.White
        Me.Home.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LogoMenu
        '
        Me.LogoMenu.Location = New System.Drawing.Point(57, 23)
        Me.LogoMenu.Name = "LogoMenu"
        Me.LogoMenu.Size = New System.Drawing.Size(100, 100)
        Me.LogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoMenu.TabIndex = 0
        Me.LogoMenu.TabStop = False
        '
        'Mainpage
        '
        Me.Mainpage.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Mainpage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mainpage.Location = New System.Drawing.Point(220, 41)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 637)
        Me.Controls.Add(Me.Mainpage)
        Me.Controls.Add(Me.Menu1)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Title.ResumeLayout(False)
        Me.Title.PerformLayout()
        CType(Me.Close1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu1.ResumeLayout(False)
        CType(Me.LogoMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Panel
    Friend WithEvents Footer As System.Windows.Forms.Panel
    Friend WithEvents Menu1 As System.Windows.Forms.Panel
    Friend WithEvents Mainpage As System.Windows.Forms.Panel
    Friend WithEvents Minimize As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LogoMenu As System.Windows.Forms.PictureBox
    Friend WithEvents Score As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Home As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Close1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse

End Class
