Public Class frmRegistry
    Public drag As Boolean
    Public mousex As Integer
    Public mousey As Integer


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("powershell", "-File C:\")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
  "TestKey", "This key was automatically created.")
        Catch ex As Exception
            MsgBox("Failed to create key. Do you have permissions?")
        End Try



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            My.Computer.Registry.CurrentUser.DeleteSubKey(
   "HKEY_CURRENT_USER\PC Toolbox\TestKey")
        Catch ex As Exception
            MsgBox("Failed to delete key. Did you create the test key?")
        End Try



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub GoToTheDebloaterRepositoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim debloaterrepos As String = "https://github.com/Sycnex/Windows10Debloater"
        Process.Start(debloaterrepos)
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Process.Start("regedit.exe")


        Catch ex As Exception
            MsgBox("Unable to open registry.")

        End Try
    End Sub

    Private Sub frmRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class