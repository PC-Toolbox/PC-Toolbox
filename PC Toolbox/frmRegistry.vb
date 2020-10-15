Public Class frmRegistry
    Public drag As Boolean
    Public mousex As Integer
    Public mousey As Integer
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub frmRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("powershell", "-File C:\YourFileLocation")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "TestKey", "This key was automatically created.")
        MsgBox("Test key created.")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Test key removed.")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub GoToTheDebloaterRepositoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToTheDebloaterRepositoryToolStripMenuItem.Click
        Dim debloaterrepos As String = "https://github.com/Sycnex/Windows10Debloater"
        Process.Start(debloaterrepos)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
 "AppLoadedOnce", "Yes")

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "Version", My.Settings.Version)

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "Language", My.Settings.Language)

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "Theme", My.Settings.Theme)


        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "WindowsVersion", frmMain.winver.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Process.Start("regedit.exe")


        Catch ex As Exception
            MsgBox("Unable to open registry.")

        End Try
    End Sub
End Class