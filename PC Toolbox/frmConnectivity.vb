Public Class frmConnectivity
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.Network.Ping("8.8.8.8") Then
            TextBox1.Text = "Connection Successful"
            TextBox1.ForeColor = Color.Green
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
"ConnectionCheck", "Online")
        Else
            TextBox1.Text = "Connection Unsuccessful"
            TextBox1.ForeColor = Color.Red
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
"ConnectionCheck", "Offline")
        End If




    End Sub
End Class