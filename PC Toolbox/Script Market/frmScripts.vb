Imports MaterialSkin

Public Class frmScripts




    Private Sub frmScripts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MaterialSkin
        Dim SkinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)
        frmScriptMarket.Show()
    End Sub
End Class