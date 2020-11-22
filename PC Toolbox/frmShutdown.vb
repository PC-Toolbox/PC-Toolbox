Public Class frmShutdown


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("shutdown /a")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Shell("shutdown.exe  /s /t 30s")
        Catch ex As Exception
            MsgBox("Failed to shutdown, do you have permissions?")
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Shell("shutdown.exe  /r /t 30s")
        Catch ex As Exception
            MsgBox("Failed to reboot, do you have permissions?")
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            Shell("shutdown /l /t 30s")
        Catch ex As Exception
            MsgBox("Failed to log the user out. Do you have permissions?")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub
End Class