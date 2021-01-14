

Public Class frmRegistry

    'what is this
    'Process.Start("powershell", "-File C:\")






    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub





    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Try
            Process.Start("regedit.exe")


        Catch ex As Exception
            MsgBox("Unable to open registry.")
        End Try
    End Sub

    Private Sub frmRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs)
        Try
            Process.Start("regedit.exe")


        Catch ex As Exception
            MsgBox("Unable to open registry.")

        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Process.Start("regedit.exe")


        Catch ex As Exception
            MsgBox("Unable to open registry.")

        End Try
    End Sub


End Class