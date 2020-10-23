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
        Me.components = New System.ComponentModel.Container()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
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
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(-4, 621)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(170, 40)
        Me.MaterialRaisedButton1.TabIndex = 18
        Me.MaterialRaisedButton1.Text = "Check For Updates"
        Me.ToolTip1.SetToolTip(Me.MaterialRaisedButton1, "Check For Updates")
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(8, 298)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(145, 19)
        Me.MaterialLabel3.TabIndex = 20
        Me.MaterialLabel3.Text = "Show Rich Presense"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox3.Location = New System.Drawing.Point(182, 296)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox3.TabIndex = 19
        Me.ComboBox3.Text = "Yes"
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
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(12, 264)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(314, 19)
        Me.MaterialLabel5.TabIndex = 23
        Me.MaterialLabel5.Text = "Discord is Required to use the Rich Presense."
        Me.ToolTip1.SetToolTip(Me.MaterialLabel5, "Well... no duh")
        Me.MaterialLabel5.Visible = False
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
        Me.MetroComboBox2.UseSelectable = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(883, 659)
        Me.Controls.Add(Me.MetroComboBox2)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.ComboBox3)
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
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
End Class
