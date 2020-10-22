

Imports MaterialSkin
Imports DiscordRPC
Imports DiscordRPC.Logging

Public Class frmMain





    Public RpcClient As DiscordRpcClient
    Public ReadOnly Logger As New ConsoleLogger(LogLevel.Trace, coloured:=True)
    Public ReadOnly Presence As RichPresence = New RichPresence With {
    .Details = "On Menu",
    .State = "v0.11-beta",
    .Assets = New Assets With {.LargeImageKey = "placeholder_1"}
    }





    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MaterialSkin
        Dim SkinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK





        Dim os As OperatingSystem = Environment.OSVersion
        winver.Text = os.Version.Major & os.Version.Minor

        If winver.Text = "62" Then
            'Version Supported
        End If


        If winver.Text = "61" Then
            'Version Supported
        End If



        If winver.Text = "51" Then
            MsgBox("Windows XP is no longer supported on Toolbox.")
            Me.Close()
        End If

        If winver.Text = "60" Then
            MsgBox("Windows Vista is no longer supported on PC Toolbox.")
            Me.Close()
        End If

        StartClientMain()

    End Sub


    Public Sub StartClientMain()
        RpcClient = New DiscordRpcClient("763902765545947157", pipe:=-1, logger:=Logger, autoEvents:=True)
        Presence.Timestamps = New Timestamps(DateTime.UtcNow)
        RpcClient.SetPresence(Presence)
        RpcClient.Initialize()
    End Sub






    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Settings.Show()
    End Sub




    Private Sub OpenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        frmShutdown.Show()
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        frmRegistry.Show()
    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        frmConnectivity.Show()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        frmExecutables.Show()
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        frmScripts.Show()
    End Sub

    Private Sub frmMain_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        frmScriptMarket.RpcClient.Dispose()
        StartClientMain()
    End Sub
End Class
