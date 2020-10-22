Imports DiscordRPC
Imports DiscordRPC.Logging
Imports MaterialSkin
Public Class frmScriptMarket

    Public RpcClient As DiscordRpcClient
    Public ReadOnly Logger As New ConsoleLogger(LogLevel.Trace, coloured:=True)
    Public ReadOnly Presence As RichPresence = New RichPresence With {
    .Details = "Looking for Scripts",
    .State = "v0.11-beta",
    .Assets = New Assets With {.LargeImageKey = "scriptmarket"}
    }




    Private Sub frmScriptMarket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MaterialSkin
        Dim SkinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub StartClientScript()
        RpcClient = New DiscordRpcClient("766072036534517770", pipe:=-1, logger:=Logger, autoEvents:=True)
        Presence.Timestamps = New Timestamps(DateTime.UtcNow)
        RpcClient.SetPresence(Presence)
        RpcClient.Initialize()
    End Sub

    Private Sub frmScriptMarket_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        StartClientScript()
        frmMain.RpcClient.Dispose()
    End Sub

    Private Sub frmScriptMarket_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RpcClient.Dispose()
        frmMain.StartClientMain()
    End Sub
End Class