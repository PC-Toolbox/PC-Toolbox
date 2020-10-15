

Public Class frmMain

    ' Dont mind this stuff all of it is dims and rich presense
    Public drag As Boolean
    Public mousex As Integer
    Public mousey As Integer




    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        Dim os As OperatingSystem = Environment.OSVersion
        winver.Text = os.Version.Major & os.Version.Minor
        If winver.Text = "62" Then
            'Version Supported
        End If


        If winver.Text = "61" Then
            'Version Supported
        End If

        If winver.Text = "51" Then
            MsgBox("Windows XP is no longer supported for PC Toolbox.")
            Me.Close()
        End If


        ' Registry Keys
        My.Computer.Registry.CurrentUser.CreateSubKey("PC Toolbox")


        ' Keys revert back when app closed.
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "AppLoadedOnce", "Yes")

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "Version", My.Settings.Version)

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "Language", My.Settings.Language)

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "Theme", My.Settings.Theme)





        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "WindowsVersion", winver.Text)






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmShutdown.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmRegistry.Show()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmConnectivity.Show()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmScripts.Show()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmExecutables.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        If My.Settings.CloseOnClick = "No" Then
            Me.Close()
        End If

        If My.Settings.CloseOnClick = "Yes" Then
            NotifyIcon1.ShowBalloonTip(1000)
            Me.Hide()
            Settings.Hide()
            frmRegistry.Hide()
            frmExecutables.Hide()
            frmScriptMarket.Hide()
            frmScripts.Hide()
            frmShutdown.Hide()
        End If
        My.Settings.Save()
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        Me.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Settings.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
        Me.Close()
        Me.Close()
        Me.Close()
        Me.Close()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmScriptMarket.Show()
        Me.Hide()
        Settings.Hide()
        frmRegistry.Hide()
        frmExecutables.Hide()
        frmScripts.Hide()
        frmShutdown.Hide()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        frmScriptMarket.Show()
    End Sub



    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub
End Class
