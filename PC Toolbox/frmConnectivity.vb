Public Class frmConnectivity
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.Network.Ping(My.Settings.PingedIP) Then
            TextBox1.Text = "Connection Successful"
            TextBox1.ForeColor = Color.Green

        Else
            TextBox1.Text = "Connection Unsuccessful"
            TextBox1.ForeColor = Color.Red



        End If




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Network.Ping(TextBox2.Text)
        My.Settings.PingedIP = TextBox2.Text
        My.Settings.Save()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub


    Private Sub frmConnectivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = "IP:" + My.Settings.PingedIP
    End Sub
End Class