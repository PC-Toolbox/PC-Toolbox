Public Class frmShutdown
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Shell("shutdown.exe  /s /t 30s")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Shell("shutdown.exe  /r /t 30s")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Shell("shutdown /l")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("shutdown /a")
    End Sub
End Class