<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdates
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updateBar = New System.Windows.Forms.ProgressBar()
        Me.updateLabel = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "There is a new update for PC Toolbox"
        '
        'updateBar
        '
        Me.updateBar.Location = New System.Drawing.Point(58, 482)
        Me.updateBar.Name = "updateBar"
        Me.updateBar.Size = New System.Drawing.Size(699, 23)
        Me.updateBar.TabIndex = 1
        Me.updateBar.Visible = False
        '
        'updateLabel
        '
        Me.updateLabel.AutoSize = True
        Me.updateLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.updateLabel.Location = New System.Drawing.Point(54, 508)
        Me.updateLabel.Name = "updateLabel"
        Me.updateLabel.Size = New System.Drawing.Size(134, 20)
        Me.updateLabel.TabIndex = 2
        Me.updateLabel.Text = "Installing Update..."
        Me.updateLabel.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Install"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(535, 425)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Skip Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(308, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "The newest version is %version_number%"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(393, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 28)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Remind Later"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(806, 536)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.updateLabel)
        Me.Controls.Add(Me.updateBar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdates"
        Me.Text = "PC Toolbox (New Update)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents updateBar As ProgressBar
    Friend WithEvents updateLabel As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
End Class
