Imports MaterialSkin


Public Class frmExecutables
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CommandPromptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandPromptToolStripMenuItem.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        Process.Start("taskmgr.exe")
    End Sub

    Private Sub ControlPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlPanelToolStripMenuItem.Click
        Process.Start("control.exe")
    End Sub

    Private Sub RegeditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegeditToolStripMenuItem.Click
        Process.Start("regedit.exe")
    End Sub

    Private Sub ExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExplorerToolStripMenuItem.Click
        Process.Start("explorer.exe")
    End Sub

    Private Sub WinverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinverToolStripMenuItem.Click
        Process.Start("winver.exe")
    End Sub

    Private Sub ServicesmscToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start("services.msc")
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
        Process.Start("powershell.exe")
    End Sub

    Private Sub ScriptMarketToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmScriptMarket.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Process.Start("explorer.exe")
    End Sub
End Class