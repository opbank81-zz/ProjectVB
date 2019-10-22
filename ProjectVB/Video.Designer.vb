<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Video
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Video))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Sidebar = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.openfile = New System.Windows.Forms.PictureBox()
        Me.btn_next = New System.Windows.Forms.PictureBox()
        Me.btn_stop = New System.Windows.Forms.PictureBox()
        Me.btn_provious = New System.Windows.Forms.PictureBox()
        Me.btn_play = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Media = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.openfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_stop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_provious, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_play, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Media, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 563)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(772, 563)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Media)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(772, 563)
        Me.Panel4.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Sidebar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.openfile)
        Me.Panel2.Controls.Add(Me.btn_next)
        Me.Panel2.Controls.Add(Me.btn_stop)
        Me.Panel2.Controls.Add(Me.btn_provious)
        Me.Panel2.Controls.Add(Me.btn_play)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 475)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 88)
        Me.Panel2.TabIndex = 0
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.Silver
        Me.Sidebar.BorderRadius = 5
        Me.Sidebar.Location = New System.Drawing.Point(63, 15)
        Me.Sidebar.MaximumValue = 100
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Sidebar.Size = New System.Drawing.Size(651, 10)
        Me.Sidebar.TabIndex = 0
        Me.Sidebar.Value = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(720, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "00:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "00:00"
        '
        'openfile
        '
        Me.openfile.Location = New System.Drawing.Point(247, 41)
        Me.openfile.Name = "openfile"
        Me.openfile.Size = New System.Drawing.Size(40, 40)
        Me.openfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.openfile.TabIndex = 4
        Me.openfile.TabStop = False
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(395, 41)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(40, 40)
        Me.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_next.TabIndex = 3
        Me.btn_next.TabStop = False
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(441, 41)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(40, 40)
        Me.btn_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_stop.TabIndex = 2
        Me.btn_stop.TabStop = False
        '
        'btn_provious
        '
        Me.btn_provious.Location = New System.Drawing.Point(293, 41)
        Me.btn_provious.Name = "btn_provious"
        Me.btn_provious.Size = New System.Drawing.Size(40, 40)
        Me.btn_provious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_provious.TabIndex = 1
        Me.btn_provious.TabStop = False
        '
        'btn_play
        '
        Me.btn_play.Location = New System.Drawing.Point(339, 31)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(50, 50)
        Me.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_play.TabIndex = 0
        Me.btn_play.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Media
        '
        Me.Media.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Media.Enabled = True
        Me.Media.Location = New System.Drawing.Point(0, 0)
        Me.Media.Name = "Media"
        Me.Media.OcxState = CType(resources.GetObject("Media.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Media.Size = New System.Drawing.Size(772, 475)
        Me.Media.TabIndex = 1
        '
        'Video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Video"
        Me.Size = New System.Drawing.Size(772, 563)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.openfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_stop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_provious, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_play, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Media, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_next As System.Windows.Forms.PictureBox
    Friend WithEvents btn_stop As System.Windows.Forms.PictureBox
    Friend WithEvents btn_provious As System.Windows.Forms.PictureBox
    Friend WithEvents btn_play As System.Windows.Forms.PictureBox
    Friend WithEvents openfile As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Sidebar As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Media As AxWMPLib.AxWindowsMediaPlayer

End Class
