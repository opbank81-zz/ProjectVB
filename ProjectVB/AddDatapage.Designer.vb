<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDatapage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDatapage))
        Me.ACData = New System.Windows.Forms.DataGridView()
        Me.NDData = New System.Windows.Forms.DataGridView()
        Me.QData = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Del = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Add = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.DataAccount = New System.Windows.Forms.Label()
        Me.Account = New System.Windows.Forms.Label()
        Me.Data = New System.Windows.Forms.Label()
        CType(Me.ACData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NDData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ACData
        '
        Me.ACData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ACData.Location = New System.Drawing.Point(3, 46)
        Me.ACData.Name = "ACData"
        Me.ACData.Size = New System.Drawing.Size(337, 148)
        Me.ACData.TabIndex = 0
        '
        'NDData
        '
        Me.NDData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NDData.Location = New System.Drawing.Point(346, 46)
        Me.NDData.Name = "NDData"
        Me.NDData.Size = New System.Drawing.Size(423, 148)
        Me.NDData.TabIndex = 0
        '
        'QData
        '
        Me.QData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QData.Location = New System.Drawing.Point(3, 237)
        Me.QData.Name = "QData"
        Me.QData.Size = New System.Drawing.Size(766, 174)
        Me.QData.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Del)
        Me.Panel1.Controls.Add(Me.Add)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 417)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 146)
        Me.Panel1.TabIndex = 0
        '
        'Del
        '
        Me.Del.ActiveBorderThickness = 1
        Me.Del.ActiveCornerRadius = 20
        Me.Del.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Del.ActiveForecolor = System.Drawing.Color.Black
        Me.Del.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Del.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Del.BackgroundImage = CType(resources.GetObject("Del.BackgroundImage"), System.Drawing.Image)
        Me.Del.ButtonText = "Delete"
        Me.Del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Del.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Del.IdleBorderThickness = 1
        Me.Del.IdleCornerRadius = 20
        Me.Del.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Del.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Del.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Del.Location = New System.Drawing.Point(389, 48)
        Me.Del.Margin = New System.Windows.Forms.Padding(5)
        Me.Del.Name = "Del"
        Me.Del.Size = New System.Drawing.Size(136, 41)
        Me.Del.TabIndex = 0
        Me.Del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Add
        '
        Me.Add.ActiveBorderThickness = 1
        Me.Add.ActiveCornerRadius = 20
        Me.Add.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Add.ActiveForecolor = System.Drawing.Color.Black
        Me.Add.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Add.BackgroundImage = CType(resources.GetObject("Add.BackgroundImage"), System.Drawing.Image)
        Me.Add.ButtonText = "Add"
        Me.Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Add.IdleBorderThickness = 1
        Me.Add.IdleCornerRadius = 20
        Me.Add.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Add.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Add.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Add.Location = New System.Drawing.Point(243, 48)
        Me.Add.Margin = New System.Windows.Forms.Padding(5)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(136, 41)
        Me.Add.TabIndex = 0
        Me.Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataAccount
        '
        Me.DataAccount.AutoSize = True
        Me.DataAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DataAccount.Location = New System.Drawing.Point(317, 210)
        Me.DataAccount.Name = "DataAccount"
        Me.DataAccount.Size = New System.Drawing.Size(66, 24)
        Me.DataAccount.TabIndex = 1
        Me.DataAccount.Text = "Label1"
        '
        'Account
        '
        Me.Account.AutoSize = True
        Me.Account.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Account.Location = New System.Drawing.Point(147, 19)
        Me.Account.Name = "Account"
        Me.Account.Size = New System.Drawing.Size(66, 24)
        Me.Account.TabIndex = 2
        Me.Account.Text = "Label1"
        '
        'Data
        '
        Me.Data.AutoSize = True
        Me.Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Data.Location = New System.Drawing.Point(550, 19)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(66, 24)
        Me.Data.TabIndex = 3
        Me.Data.Text = "Label1"
        '
        'AddDatapage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Controls.Add(Me.Data)
        Me.Controls.Add(Me.Account)
        Me.Controls.Add(Me.DataAccount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.QData)
        Me.Controls.Add(Me.NDData)
        Me.Controls.Add(Me.ACData)
        Me.Name = "AddDatapage"
        Me.Size = New System.Drawing.Size(772, 563)
        CType(Me.ACData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NDData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ACData As System.Windows.Forms.DataGridView
    Friend WithEvents NDData As System.Windows.Forms.DataGridView
    Friend WithEvents QData As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Del As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents Add As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents DataAccount As System.Windows.Forms.Label
    Friend WithEvents Account As System.Windows.Forms.Label
    Friend WithEvents Data As System.Windows.Forms.Label

End Class
