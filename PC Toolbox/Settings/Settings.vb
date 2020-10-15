Public Class Settings
    Public drag As Boolean
    Public mousex As Integer
    Public mousey As Integer

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