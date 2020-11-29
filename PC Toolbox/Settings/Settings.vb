Imports MaterialSkin

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Yes" Then
            My.Settings.RPCShow = "True"
            frmMain.StartClientMain()
            My.Settings.Save()
        End If
        If ComboBox1.SelectedItem = "No" Then
            My.Settings.RPCShow = "False"
            frmMain.RpcClient.Dispose()
            My.Settings.Save()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Dark" Then
            My.Settings.Theme = "Dark"
            Dim SkinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
            SkinManager.Theme = MaterialSkinManager.Themes.DARK

            My.Settings.Save()
        End If
        If ComboBox2.SelectedItem = "Light" Then
            My.Settings.Theme = "Light"
            Dim SkinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance

            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            My.Settings.Save()
        End If
        My.Settings.Save()
    End Sub
End Class