<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExecutables
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
        Me.Favorites = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandPromptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegeditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowershellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupPolicyEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddExecutableAsFavoriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAsFavoriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WordpadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoryShortcutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PCToolboxShortcutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScriptMarketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetFavoritesListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Favorites.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Favorites
        '
        Me.Favorites.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddExecutableAsFavoriteToolStripMenuItem, Me.RemoveAsFavoriteToolStripMenuItem, Me.ToolStripSeparator3, Me.ResetFavoritesListToolStripMenuItem})
        Me.Favorites.Name = "ContextMenuStrip1"
        Me.Favorites.Size = New System.Drawing.Size(216, 76)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem, Me.DirectoryShortcutsToolStripMenuItem, Me.PCToolboxShortcutsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 102)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(453, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommandPromptToolStripMenuItem, Me.TaskManagerToolStripMenuItem, Me.ControlPanelToolStripMenuItem, Me.RegeditToolStripMenuItem, Me.PowershellToolStripMenuItem, Me.ToolStripSeparator1, Me.ExplorerToolStripMenuItem, Me.WinverToolStripMenuItem, Me.GroupPolicyEditorToolStripMenuItem, Me.WordpadToolStripMenuItem})
        Me.BasicToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(132, 25)
        Me.BasicToolStripMenuItem.Text = "All Executables"
        '
        'CommandPromptToolStripMenuItem
        '
        Me.CommandPromptToolStripMenuItem.Name = "CommandPromptToolStripMenuItem"
        Me.CommandPromptToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CommandPromptToolStripMenuItem.Text = "Command Prompt"
        Me.CommandPromptToolStripMenuItem.ToolTipText = "cmd"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        Me.TaskManagerToolStripMenuItem.ToolTipText = "taskmgr"
        '
        'ControlPanelToolStripMenuItem
        '
        Me.ControlPanelToolStripMenuItem.Name = "ControlPanelToolStripMenuItem"
        Me.ControlPanelToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ControlPanelToolStripMenuItem.Text = "Control Panel"
        Me.ControlPanelToolStripMenuItem.ToolTipText = "control"
        '
        'RegeditToolStripMenuItem
        '
        Me.RegeditToolStripMenuItem.Name = "RegeditToolStripMenuItem"
        Me.RegeditToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RegeditToolStripMenuItem.Text = "Regedit"
        Me.RegeditToolStripMenuItem.ToolTipText = "regedit"
        '
        'PowershellToolStripMenuItem
        '
        Me.PowershellToolStripMenuItem.Name = "PowershellToolStripMenuItem"
        Me.PowershellToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PowershellToolStripMenuItem.Text = "Powershell"
        Me.PowershellToolStripMenuItem.ToolTipText = "powershell"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        'ExplorerToolStripMenuItem
        '
        Me.ExplorerToolStripMenuItem.Name = "ExplorerToolStripMenuItem"
        Me.ExplorerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExplorerToolStripMenuItem.Text = "Explorer"
        '
        'WinverToolStripMenuItem
        '
        Me.WinverToolStripMenuItem.Name = "WinverToolStripMenuItem"
        Me.WinverToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.WinverToolStripMenuItem.Text = "Winver"
        '
        'GroupPolicyEditorToolStripMenuItem
        '
        Me.GroupPolicyEditorToolStripMenuItem.Name = "GroupPolicyEditorToolStripMenuItem"
        Me.GroupPolicyEditorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.GroupPolicyEditorToolStripMenuItem.Text = "Group Policy Editor"
        '
        'AddExecutableAsFavoriteToolStripMenuItem
        '
        Me.AddExecutableAsFavoriteToolStripMenuItem.Name = "AddExecutableAsFavoriteToolStripMenuItem"
        Me.AddExecutableAsFavoriteToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.AddExecutableAsFavoriteToolStripMenuItem.Text = "Add Executable as Favorite"
        '
        'RemoveAsFavoriteToolStripMenuItem
        '
        Me.RemoveAsFavoriteToolStripMenuItem.Name = "RemoveAsFavoriteToolStripMenuItem"
        Me.RemoveAsFavoriteToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.RemoveAsFavoriteToolStripMenuItem.Text = "Remove as Favorite"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 53)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(654, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 30)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'WordpadToolStripMenuItem
        '
        Me.WordpadToolStripMenuItem.Name = "WordpadToolStripMenuItem"
        Me.WordpadToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.WordpadToolStripMenuItem.Text = "Wordpad"
        '
        'DirectoryShortcutsToolStripMenuItem
        '
        Me.DirectoryShortcutsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CToolStripMenuItem, Me.DToolStripMenuItem})
        Me.DirectoryShortcutsToolStripMenuItem.Name = "DirectoryShortcutsToolStripMenuItem"
        Me.DirectoryShortcutsToolStripMenuItem.Size = New System.Drawing.Size(148, 25)
        Me.DirectoryShortcutsToolStripMenuItem.Text = "Directory Shortcuts"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.CToolStripMenuItem.Text = "C:\"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DToolStripMenuItem.Text = "D:\"
        '
        'PCToolboxShortcutsToolStripMenuItem
        '
        Me.PCToolboxShortcutsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScriptMarketToolStripMenuItem, Me.ToolStripSeparator2})
        Me.PCToolboxShortcutsToolStripMenuItem.Name = "PCToolboxShortcutsToolStripMenuItem"
        Me.PCToolboxShortcutsToolStripMenuItem.Size = New System.Drawing.Size(165, 25)
        Me.PCToolboxShortcutsToolStripMenuItem.Text = "PC Toolbox Shortcuts"
        '
        'ScriptMarketToolStripMenuItem
        '
        Me.ScriptMarketToolStripMenuItem.Image = Global.PC_Toolbox.My.Resources.Resources.ScriptMarket_v1
        Me.ScriptMarketToolStripMenuItem.Name = "ScriptMarketToolStripMenuItem"
        Me.ScriptMarketToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ScriptMarketToolStripMenuItem.Text = "Script Market"
        Me.ScriptMarketToolStripMenuItem.ToolTipText = "Script Market"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(212, 6)
        '
        'ResetFavoritesListToolStripMenuItem
        '
        Me.ResetFavoritesListToolStripMenuItem.Name = "ResetFavoritesListToolStripMenuItem"
        Me.ResetFavoritesListToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ResetFavoritesListToolStripMenuItem.Text = "Reset Favorites List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(152, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "WIP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Executables"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'frmExecutables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(705, 550)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmExecutables"
        Me.Text = "frmExecutables"
        Me.Favorites.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Favorites As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BasicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommandPromptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PowershellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WinverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegeditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupPolicyEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddExecutableAsFavoriteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveAsFavoriteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WordpadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoryShortcutsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PCToolboxShortcutsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScriptMarketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ResetFavoritesListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
