Public Class frmConnectivity
    Public drag As Boolean
    Public mousex As Integer
    Public mousey As Integer
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim speedtest As String = "https://www.speedtest.net/"

        Process.Start(speedtest)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

End Class