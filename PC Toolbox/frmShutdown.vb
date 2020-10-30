Public Class frmShutdown


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("shutdown /a")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Shell("shutdown.exe  /s /t 30s")
        Catch ex As Exception
            MsgBox("Failed to create shutdown, do you have permissions?")
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Shell("shutdown.exe  /r /t 30s")
        Catch ex As Exception
            MsgBox("Failed to create shutdown, do you have permissions?")
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            MsgBox("Clicking this will instantly log you out. Please save your work.")
            Shell("shutdown /l /t 30s")
        Catch ex As Exception
            MsgBox("Log out attempt failed.")
        End Try
    End Sub
End Class