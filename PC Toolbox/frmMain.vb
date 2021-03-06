﻿


Imports System.Runtime.InteropServices
Imports DiscordRPC
Imports DiscordRPC.Logging

Public Class frmMain
    Public RpcClient As DiscordRpcClient
    Public ReadOnly Logger As New ConsoleLogger(LogLevel.Trace, coloured:=True)
    Public ReadOnly Presence As RichPresence = New RichPresence With {
    .Details = My.Settings.RPC,
    .State = "",
    .Assets = New Assets With {.LargeImageKey = "pctoolbox", .LargeImageText = "v1.0-snapshot"}
    }
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'We have removed the limitation for Version Support. No intentions of bringing this back for now. But keeping code.

        Dim os As OperatingSystem = Environment.OSVersion
        'If winver.Text = "62" Then
        'Version Supported
        'End If
        'If winver.Text = "61" Then
        'Version Supported
        'End If
        ' If winver.Text = "51" Then
        ' MsgBox("Windows XP devices are not supported on PC Toolbox.")
        'Me.Close()
        'End If
        ' If winver.Text = "60" Then
        'MsgBox("Windows Vista devices are not supported on PC Toolbox.")
        'Me.Close()
        ' End If
        StartClientMain()

    End Sub


    Public Sub StartClientMain()
        RpcClient = New DiscordRpcClient("738510019364126791", pipe:=-1, logger:=Logger, autoEvents:=True)
        Presence.Timestamps = New Timestamps(DateTime.UtcNow)
        RpcClient.SetPresence(Presence)
        RpcClient.Initialize()
    End Sub
    Private Sub OpenToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        frmShutdown.Show()
        My.Settings.RPC = "Shutdown Manager"
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        frmRegistry.Show()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        frmConnectivity.Show()
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Settings.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Settings.Show()
    End Sub

    Private Sub MetroTile6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel1.Paint

    End Sub
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, MetroPanel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub
End Class
