<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroComboBox3 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(9, 81)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(77, 19)
        Me.MaterialLabel1.TabIndex = 15
        Me.MaterialLabel1.Text = "Language:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 143)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel2.TabIndex = 16
        Me.MaterialLabel2.Text = "Theme:"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(-1, 621)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(170, 40)
        Me.MaterialRaisedButton1.TabIndex = 18
        Me.MaterialRaisedButton1.Text = "Check For Updates"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 298)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(321, 19)
        Me.MaterialLabel3.TabIndex = 20
        Me.MaterialLabel3.Text = "Show PC Toolbox as playing game on Discord:"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(543, 79)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(63, 19)
        Me.MaterialLabel4.TabIndex = 22
        Me.MaterialLabel4.Text = "Opacity:"
        Me.MaterialLabel4.Visible = False
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"100%", "80%", "75%", "50%"})
        Me.ComboBox4.Location = New System.Drawing.Point(621, 79)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox4.TabIndex = 21
        Me.ComboBox4.Text = "100%"
        Me.ComboBox4.Visible = False
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"English"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(89, 79)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(175, 29)
        Me.MetroComboBox1.TabIndex = 24
        Me.MetroToolTip1.SetToolTip(Me.MetroComboBox1, "Select Language")
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroComboBox2
        '
        Me.MetroComboBox2.FormattingEnabled = True
        Me.MetroComboBox2.ItemHeight = 23
        Me.MetroComboBox2.Items.AddRange(New Object() {"Dark", "Light"})
        Me.MetroComboBox2.Location = New System.Drawing.Point(77, 143)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.Size = New System.Drawing.Size(187, 29)
        Me.MetroComboBox2.TabIndex = 25
        Me.MetroToolTip1.SetToolTip(Me.MetroComboBox2, "Select Themes")
        Me.MetroComboBox2.UseSelectable = True
        '
        'MetroComboBox3
        '
        Me.MetroComboBox3.FormattingEnabled = True
        Me.MetroComboBox3.ItemHeight = 23
        Me.MetroComboBox3.Items.AddRange(New Object() {"Yes", "No"})
        Me.MetroComboBox3.Location = New System.Drawing.Point(339, 298)
        Me.MetroComboBox3.Name = "MetroComboBox3"
        Me.MetroComboBox3.Size = New System.Drawing.Size(187, 29)
        Me.MetroComboBox3.TabIndex = 26
        Me.MetroToolTip1.SetToolTip(Me.MetroComboBox3, "Select if you want Discord Rich Presence to appear")
        Me.MetroComboBox3.UseSelectable = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(750, 623)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(136, 38)
        Me.MetroLabel1.TabIndex = 28
        Me.MetroLabel1.Text = "Running Version 0.11.5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "v0.11.5-beta+021440"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(176, 623)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(67, 36)
        Me.MaterialFlatButton1.TabIndex = 29
        Me.MaterialFlatButton1.Text = "Credits"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(883, 659)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroComboBox3)
        Me.Controls.Add(Me.MetroComboBox2)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroComboBox3 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
End Class
