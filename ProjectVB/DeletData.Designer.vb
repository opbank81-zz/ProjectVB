<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeletData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeletData))
        Me.BteBack = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Del1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Index1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.SuspendLayout()
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
        Me.BteBack.Location = New System.Drawing.Point(253, 175)
        Me.BteBack.Margin = New System.Windows.Forms.Padding(5)
        Me.BteBack.Name = "BteBack"
        Me.BteBack.Size = New System.Drawing.Size(136, 41)
        Me.BteBack.TabIndex = 9
        Me.BteBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Del1
        '
        Me.Del1.ActiveBorderThickness = 1
        Me.Del1.ActiveCornerRadius = 20
        Me.Del1.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Del1.ActiveForecolor = System.Drawing.Color.Black
        Me.Del1.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Del1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Del1.BackgroundImage = CType(resources.GetObject("Del1.BackgroundImage"), System.Drawing.Image)
        Me.Del1.ButtonText = "Delete"
        Me.Del1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Del1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Del1.IdleBorderThickness = 1
        Me.Del1.IdleCornerRadius = 20
        Me.Del1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Del1.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Del1.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Del1.Location = New System.Drawing.Point(107, 175)
        Me.Del1.Margin = New System.Windows.Forms.Padding(5)
        Me.Del1.Name = "Del1"
        Me.Del1.Size = New System.Drawing.Size(136, 41)
        Me.Del1.TabIndex = 10
        Me.Del1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Index1
        '
        Me.Index1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Index1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Index1.HintForeColor = System.Drawing.Color.Empty
        Me.Index1.HintText = ""
        Me.Index1.isPassword = False
        Me.Index1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Index1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Index1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Index1.LineThickness = 1
        Me.Index1.Location = New System.Drawing.Point(145, 90)
        Me.Index1.Margin = New System.Windows.Forms.Padding(4)
        Me.Index1.Name = "Index1"
        Me.Index1.Size = New System.Drawing.Size(189, 31)
        Me.Index1.TabIndex = 11
        Me.Index1.Text = "Record Index"
        Me.Index1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DeletData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(494, 230)
        Me.Controls.Add(Me.Index1)
        Me.Controls.Add(Me.Del1)
        Me.Controls.Add(Me.BteBack)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DeletData"
        Me.Text = "DeletData"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents BteBack As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents Del1 As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents Index1 As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
