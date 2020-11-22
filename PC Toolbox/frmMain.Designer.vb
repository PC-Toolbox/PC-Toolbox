<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MaterialSkin.Controls.MaterialForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayClick1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MetroTile6 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.TrayClick1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "PC Toolbox is now minimized to tray."
        Me.NotifyIcon1.ContextMenuStrip = Me.TrayClick1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "PC Toolbox"
        Me.NotifyIcon1.Visible = True
        '
        'TrayClick1
        '
        Me.TrayClick1.BackColor = System.Drawing.Color.White
        Me.TrayClick1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ToolStripSeparator1, Me.CheckForUpdatesToolStripMenuItem})
        Me.TrayClick1.Name = "TrayClick1"
        Me.TrayClick1.Size = New System.Drawing.Size(174, 76)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check For Updates"
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(2, 520)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 35)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MetroTile6
        '
        Me.MetroTile6.ActiveControl = Nothing
        Me.MetroTile6.Location = New System.Drawing.Point(498, 314)
        Me.MetroTile6.Name = "MetroTile6"
        Me.MetroTile6.Size = New System.Drawing.Size(185, 175)
        Me.MetroTile6.Style = MetroFramework.MetroColorStyle.Brown
        Me.MetroTile6.TabIndex = 27
        Me.MetroTile6.Text = "Files"
        Me.MetroTile6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile6.TileImage = Global.PC_Toolbox.My.Resources.Resources.files_logo
        Me.MetroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.MetroTile6, "Files")
        Me.MetroTile6.UseSelectable = True
        Me.MetroTile6.UseStyleColors = True
        Me.MetroTile6.UseTileImage = True
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.Location = New System.Drawing.Point(252, 314)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(185, 175)
        Me.MetroTile5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTile5.TabIndex = 26
        Me.MetroTile5.Text = "Scripts"
        Me.MetroTile5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile5.TileImage = Global.PC_Toolbox.My.Resources.Resources.scripts_logo_new
        Me.MetroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.MetroTile5, "Scripts")
        Me.MetroTile5.UseSelectable = True
        Me.MetroTile5.UseTileImage = True
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.Location = New System.Drawing.Point(12, 314)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(185, 175)
        Me.MetroTile4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTile4.TabIndex = 25
        Me.MetroTile4.Text = "Executables"
        Me.MetroTile4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile4.TileImage = Global.PC_Toolbox.My.Resources.Resources.executables_logo
        Me.MetroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.MetroTile4, "Executables")
        Me.MetroTile4.UseSelectable = True
        Me.MetroTile4.UseTileImage = True
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.Location = New System.Drawing.Point(498, 91)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(185, 175)
        Me.MetroTile3.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroTile3.TabIndex = 24
        Me.MetroTile3.Text = "Connectivity"
        Me.MetroTile3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile3.TileImage = Global.PC_Toolbox.My.Resources.Resources.wifi_logo
        Me.MetroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.MetroTile3, "Connectivity")
        Me.MetroTile3.UseSelectable = True
        Me.MetroTile3.UseTileImage = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(252, 91)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(185, 175)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTile2.TabIndex = 23
        Me.MetroTile2.Text = "Registry"
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile2.TileImage = Global.PC_Toolbox.My.Resources.Resources.registry_logo
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.MetroTile2, "Registry")
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(12, 91)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(185, 175)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTile1.TabIndex = 22
        Me.MetroTile1.Text = "Shutdown Manager"
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile1.TileImage = Global.PC_Toolbox.My.Resources.Resources.shutdown_medium
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.MetroTile1, "Shutdown Manager")
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(699, 556)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MetroTile6)
        Me.Controls.Add(Me.MetroTile5)
        Me.Controls.Add(Me.MetroTile4)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PC Toolbox"
        Me.TrayClick1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents TrayClick1 As ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile6 As MetroFramework.Controls.MetroTile
    Friend WithEvents Button2 As Button
End Class
