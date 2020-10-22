Public Class frmScripts
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmScriptMarket.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class