<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RunInTray = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TroubleshooterRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckUpdatesForTroubleshooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TroubleshooterV11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TroubleshooterRightClick.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Settings"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 618)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Run Troubleshooter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(164, 618)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Check for Updates"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RunInTray
        '
        Me.RunInTray.AutoSize = True
        Me.RunInTray.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunInTray.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RunInTray.Location = New System.Drawing.Point(12, 84)
        Me.RunInTray.Name = "RunInTray"
        Me.RunInTray.Size = New System.Drawing.Size(312, 23)
        Me.RunInTray.TabIndex = 4
        Me.RunInTray.Text = "Run PC Toolbox in tray when the app is closed?"
        Me.RunInTray.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"English"})
        Me.ComboBox1.Location = New System.Drawing.Point(97, 156)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = "English"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(8, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Language"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(8, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Theme"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Dark", "Light"})
        Me.ComboBox2.Location = New System.Drawing.Point(97, 228)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.Text = "Dark"
        '
        'TroubleshooterRightClick
        '
        Me.TroubleshooterRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckUpdatesForTroubleshooterToolStripMenuItem, Me.ToolStripSeparator1, Me.TroubleshooterV11ToolStripMenuItem})
        Me.TroubleshooterRightClick.Name = "TroubleshooterRightClick"
        Me.TroubleshooterRightClick.Size = New System.Drawing.Size(254, 54)
        '
        'CheckUpdatesForTroubleshooterToolStripMenuItem
        '
        Me.CheckUpdatesForTroubleshooterToolStripMenuItem.Name = "CheckUpdatesForTroubleshooterToolStripMenuItem"
        Me.CheckUpdatesForTroubleshooterToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.CheckUpdatesForTroubleshooterToolStripMenuItem.Text = "Check Updates for Troubleshooter"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(250, 6)
        '
        'TroubleshooterV11ToolStripMenuItem
        '
        Me.TroubleshooterV11ToolStripMenuItem.Enabled = False
        Me.TroubleshooterV11ToolStripMenuItem.Name = "TroubleshooterV11ToolStripMenuItem"
        Me.TroubleshooterV11ToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.TroubleshooterV11ToolStripMenuItem.Text = "Troubleshooter: v1.1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "TroubleshooterRightClick"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(130, 32)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem1.Text = "v0.8-alpha"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(126, 6)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(977, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 30)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 659)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RunInTray)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.TroubleshooterRightClick.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RunInTray As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TroubleshooterRightClick As ContextMenuStrip
    Friend WithEvents CheckUpdatesForTroubleshooterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TroubleshooterV11ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
