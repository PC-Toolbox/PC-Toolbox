<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form
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
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.TrayClick1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.TrayClick1.Name = "TrayClick1"
        Me.TrayClick1.Size = New System.Drawing.Size(174, 54)
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check For Updates"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CloseToolStripMenuItem.Text = "Close PC Toolbox"
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.Location = New System.Drawing.Point(12, 242)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(185, 175)
        Me.MetroTile4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTile4.TabIndex = 25
        Me.MetroTile4.Text = "Quick Run"
        Me.MetroTile4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile4.TileImage = Global.PC_Toolbox.My.Resources.Resources.executables_logo
        Me.MetroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.MetroTile4, "Executables")
        Me.MetroTile4.UseSelectable = True
        Me.MetroTile4.UseTileImage = True
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.Location = New System.Drawing.Point(498, 22)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(185, 175)
        Me.MetroTile3.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroTile3.TabIndex = 24
        Me.MetroTile3.Text = "Connection"
        Me.MetroTile3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile3.TileImage = Global.PC_Toolbox.My.Resources.Resources.wifi_logo
        Me.MetroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.MetroTile3, "Connectivity")
        Me.MetroTile3.UseSelectable = True
        Me.MetroTile3.UseTileImage = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(252, 22)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(185, 175)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTile2.TabIndex = 23
        Me.MetroTile2.Text = "Registry"
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile2.TileImage = Global.PC_Toolbox.My.Resources.Resources.registry_logo
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.MetroTile2, "Registry")
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(12, 22)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(185, 175)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTile1.TabIndex = 22
        Me.MetroTile1.Text = "Shutdown Manager"
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile1.TileImage = Global.PC_Toolbox.My.Resources.Resources.shutdown_medium
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.MetroTile1, "Shutdown Manager")
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(226, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 35)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(705, 471)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MetroTile4)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents Button2 As Button
End Class
