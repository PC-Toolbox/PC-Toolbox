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
        Me.winver = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayClick1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TrayClick1.SuspendLayout()
        Me.SuspendLayout()
        '
        'winver
        '
        Me.winver.AutoSize = True
        Me.winver.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.winver.Location = New System.Drawing.Point(843, 650)
        Me.winver.Name = "winver"
        Me.winver.Size = New System.Drawing.Size(54, 13)
        Me.winver.TabIndex = 11
        Me.winver.Text = "%winver%"
        Me.winver.Visible = False
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
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(77, 120)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(157, 38)
        Me.MaterialRaisedButton1.TabIndex = 12
        Me.MaterialRaisedButton1.Text = "Shutdown"
        Me.ToolTip1.SetToolTip(Me.MaterialRaisedButton1, "Shutdown")
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton4
        '
        Me.MaterialRaisedButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton4.Depth = 0
        Me.MaterialRaisedButton4.Location = New System.Drawing.Point(77, 212)
        Me.MaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton4.Name = "MaterialRaisedButton4"
        Me.MaterialRaisedButton4.Primary = True
        Me.MaterialRaisedButton4.Size = New System.Drawing.Size(157, 38)
        Me.MaterialRaisedButton4.TabIndex = 15
        Me.MaterialRaisedButton4.Text = "Registry"
        Me.ToolTip1.SetToolTip(Me.MaterialRaisedButton4, "Registry")
        Me.MaterialRaisedButton4.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton5
        '
        Me.MaterialRaisedButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton5.Depth = 0
        Me.MaterialRaisedButton5.Location = New System.Drawing.Point(77, 314)
        Me.MaterialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton5.Name = "MaterialRaisedButton5"
        Me.MaterialRaisedButton5.Primary = True
        Me.MaterialRaisedButton5.Size = New System.Drawing.Size(157, 38)
        Me.MaterialRaisedButton5.TabIndex = 16
        Me.MaterialRaisedButton5.Text = "Connectivity"
        Me.ToolTip1.SetToolTip(Me.MaterialRaisedButton5, "Connectivity")
        Me.MaterialRaisedButton5.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(77, 409)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(157, 38)
        Me.MaterialRaisedButton2.TabIndex = 17
        Me.MaterialRaisedButton2.Text = "Executables"
        Me.ToolTip1.SetToolTip(Me.MaterialRaisedButton2, "Executables")
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(288, 120)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(157, 38)
        Me.MaterialRaisedButton3.TabIndex = 18
        Me.MaterialRaisedButton3.Text = "Scripts"
        Me.ToolTip1.SetToolTip(Me.MaterialRaisedButton3, "Scripts")
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MaterialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(3, 627)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(111, 36)
        Me.MaterialFlatButton1.TabIndex = 19
        Me.MaterialFlatButton1.Text = "Settings"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(909, 665)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MaterialRaisedButton3)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.MaterialRaisedButton5)
        Me.Controls.Add(Me.MaterialRaisedButton4)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.winver)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.TrayClick1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents winver As Label
    Friend WithEvents TrayClick1 As ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
End Class
