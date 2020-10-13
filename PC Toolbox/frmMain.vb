Public Class frmMain
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
            MsgBox("Windows XP is no longer supported for PC Toolbox. Legacy versions wil be released soon!")
            Me.Close()
        End If


        ' Registry Keys
        My.Computer.Registry.CurrentUser.CreateSubKey("PC Toolbox")


        ' Keys revert back when app closed.
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "UserLoadedAppOnce", "Yes")

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "UpToDate", "Undefined")

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "Language", "en-US")




        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "Windows Version", winver.Text)






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
        If Settings.RunInTray.CheckState = True Then
            NotifyIcon1.ShowBalloonTip(1000)
            Me.Hide()
        Else
            Me.Close()

        End If
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        Me.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmAdministration.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Settings.Show()
    End Sub
End Class
