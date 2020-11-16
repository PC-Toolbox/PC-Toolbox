Imports MaterialSkin


Public Class frmExecutables
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CommandPromptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandPromptToolStripMenuItem.Click
        Try
            Process.Start("cmd.exe")
        Catch ex As Exception
            MsgBox("Failed to open Command Prompt. Do you have permissions?")
        End Try



    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        Try
            Process.Start("taskmgr.exe")
        Catch ex As Exception
            MsgBox("Failed to open Task Manager. Do you have permission?")
        End Try

    End Sub

    Private Sub ControlPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlPanelToolStripMenuItem.Click
        Try

        Catch ex As Exception

        End Try
        Process.Start("control.exe")
    End Sub

    Private Sub RegeditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegeditToolStripMenuItem.Click
        Try
            Process.Start("regedit.exe")
        Catch ex As Exception
            MsgBox("Failed to open Registry Editor. Do you have permission or did you not run as admin?")
        End Try

    End Sub

    Private Sub ExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExplorerToolStripMenuItem.Click
        Process.Start("explorer.exe")
    End Sub

    Private Sub WinverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinverToolStripMenuItem.Click
        Try
            Process.Start("winver.exe")
        Catch ex As Exception
            MsgBox("Failed to open winver.")
        End Try

    End Sub


    Private Sub WordpadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordpadToolStripMenuItem.Click
        Process.Start("wordpad.exe")
    End Sub

    Private Sub frmExecutables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MaterialSkin
        Dim SkinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
    End Sub

    Private Sub PowershellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowershellToolStripMenuItem.Click
        Try
            Process.Start("powershell.exe")
        Catch ex As Exception
            MsgBox("Unable to run Powershell. Do you have permission?")
        End Try

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Process.Start("explorer.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        Process.Start("notepad.exe")
    End Sub

    Private Sub SnippingToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SnippingToolToolStripMenuItem.Click
        Process.Start("snippingtool")
    End Sub
End Class