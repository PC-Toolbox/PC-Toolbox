
Public Class frmConnectivity

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.Network.Ping(My.Settings.PingedIP) Then
            Label2.Text = "Connection Successful"
            Label2.ForeColor = Color.Green
        Else
            Label2.Text = "Connection Unsuccessful"
            Label2.ForeColor = Color.Red
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Network.Ping(TextBox2.Text)
        My.Settings.PingedIP = TextBox2.Text
        My.Settings.Save()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub frmConnectivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = "IP:" + My.Settings.PingedIP
        TextBox2.Text = My.Settings.PingedIP
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim speedtest As String = "https://www.speedtest.net/"
        Process.Start(speedtest)
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.PingedIP = "8.8.8.8"
    End Sub
End Class