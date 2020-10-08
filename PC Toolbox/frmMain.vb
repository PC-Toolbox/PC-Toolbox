Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim os As OperatingSystem = Environment.OSVersion
        Label1.Text = os.Version.Major & os.Version.Minor
        If Label1.Text = "62" Then
            'Do nothing, supported version
        End If


        If Label1.Text = "61" Then
            'Do nothing, supported version
        End If

        If Label1.Text = "51" Then
            MsgBox("Windows XP is very old, features may not be supported.")
            Me.Close()
        End If



        My.Computer.Registry.CurrentUser.CreateSubKey("PC Toolbox")

        ' Keys revert back when app closed.
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "UserLoadedAppOnce", "Yes")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
 "UserCreatedTestKey", "No")

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "WinVer", Label1.Text)


        Label1.Text = System.Environment.OSVersion.ToString


        If My.Computer.Name = "MATTY" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox\Developer",
"DEVKEY", "002-VERIFIEDCREATOR")
            devPanel.Visible = True
        End If




        My.Computer.Registry.CurrentUser.CreateSubKey("PC Toolbox\Developer")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox\Developer",
"DEVKEY", "001-USER")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox\Developer",
"HasChangedDEVKEY", "No")

        My.Computer.Registry.CurrentUser.CreateSubKey("PC Toolbox\Debugging")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox\Debugging",
"ModdedVersion", "No")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox\Debugging",
"RegistryTestKey", "This is a test key.")





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

    Private Sub devPanel_Click(sender As Object, e As EventArgs) Handles devPanel.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox\Debugging",
"ModdedVersion", "Yes")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmExecutables.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        NotifyIcon1.ShowBalloonTip(1000)
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        Me.Show()
    End Sub
End Class
