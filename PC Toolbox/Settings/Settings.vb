﻿Imports MaterialSkin

Public Class Settings




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "English" Then
            My.Settings.Language = "English"

            My.Settings.Save()
        End If

        If ComboBox1.SelectedItem = "Spanish" Then
            My.Settings.Language = "Spanish"

            My.Settings.Save()
        End If


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Dark" Then
            My.Settings.Theme = "Dark"
            Dim SkinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.AddFormToManage(Me)
            My.Settings.Save()
        End If

        If ComboBox2.SelectedItem = "Light" Then
            My.Settings.Theme = "Light"
            Dim SkinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            My.Settings.Save()
        End If
        My.Settings.Save()
    End Sub



    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripMenuItem1.Text = "Version: " + My.Settings.Version



        ' MaterialSkin

        Dim SkinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = "Yes" Then
            My.Settings.RPCShow = "True"
            frmMain.StartClientMain()


            My.Settings.Save()
        End If

        If ComboBox3.SelectedItem = "No" Then
            My.Settings.RPCShow = "False"
            frmMain.RpcClient.Dispose()
            frmScriptMarket.RpcClient.Dispose()

            My.Settings.Save()
        End If
    End Sub


    ' RIP Hide to Tray
End Class