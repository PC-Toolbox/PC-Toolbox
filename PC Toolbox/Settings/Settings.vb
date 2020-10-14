Public Class Settings
    Private Sub RunInTray_CheckedChanged(sender As Object, e As EventArgs) Handles RunInTray.CheckedChanged
        If RunInTray.CheckState = True Then
            My.Settings.CloseOnClick = "Yes"
        End If

        If RunInTray.CheckState = False Then
            My.Settings.CloseOnClick = "No"
        End If
        My.Settings.Save()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "English" Then
            My.Settings.Language = "English"

        End If

        If ComboBox1.SelectedItem = "Spanish" Then
            My.Settings.Language = "Spanish"

        End If

        My.Settings.Save()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Dark" Then
            My.Settings.Theme = "Dark"

        End If

        If ComboBox1.SelectedItem = "Light" Then
            My.Settings.Theme = "Light"

        End If
        My.Settings.Save()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripMenuItem1.Text = "Version: " + My.Settings.Version
    End Sub
End Class