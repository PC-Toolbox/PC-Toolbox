<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExecutables
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
        Me.Favorites = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddExecutableAsFavoriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAsFavoriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetFavoritesListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.WordpadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Favorites.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Favorites
        '
        Me.Favorites.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddExecutableAsFavoriteToolStripMenuItem, Me.RemoveAsFavoriteToolStripMenuItem, Me.ToolStripSeparator3, Me.ResetFavoritesListToolStripMenuItem})
        Me.Favorites.Name = "ContextMenuStrip1"
        Me.Favorites.Size = New System.Drawing.Size(216, 76)
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
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(16, 104)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(128, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommandPromptToolStripMenuItem, Me.TaskManagerToolStripMenuItem, Me.ControlPanelToolStripMenuItem, Me.RegeditToolStripMenuItem, Me.PowershellToolStripMenuItem, Me.ToolStripSeparator1, Me.ExplorerToolStripMenuItem, Me.WinverToolStripMenuItem, Me.WordpadToolStripMenuItem, Me.NotepadToolStripMenuItem})
        Me.BasicToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(120, 25)
        Me.BasicToolStripMenuItem.Text = "Recomended"
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
        Me.RegeditToolStripMenuItem.Text = "Registry Editor"
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
        'WordpadToolStripMenuItem
        '
        Me.WordpadToolStripMenuItem.Name = "WordpadToolStripMenuItem"
        Me.WordpadToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.WordpadToolStripMenuItem.Text = "Wordpad"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(199, 104)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(334, 29)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripSeparator2, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripSeparator4, Me.ToolStripMenuItem8})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(206, 25)
        Me.ToolStripMenuItem1.Text = "Directory Shortcuts [WIP]"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(242, 26)
        Me.ToolStripMenuItem7.Text = "Open Explorer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(239, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(242, 26)
        Me.ToolStripMenuItem2.Text = "C:\"
        Me.ToolStripMenuItem2.ToolTipText = "cmd"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(242, 26)
        Me.ToolStripMenuItem3.Text = "D:\"
        Me.ToolStripMenuItem3.ToolTipText = "taskmgr"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(242, 26)
        Me.ToolStripMenuItem9.Text = "E:\"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(242, 26)
        Me.ToolStripMenuItem10.Text = "E:\"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(239, 6)
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(242, 26)
        Me.ToolStripMenuItem8.Text = "C:\Windows\system32"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'frmExecutables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(765, 550)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmExecutables"
        Me.Text = "Executables"
        Me.Favorites.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
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
    Friend WithEvents AddExecutableAsFavoriteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveAsFavoriteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordpadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ResetFavoritesListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
End Class
