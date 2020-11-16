Imports MaterialSkin

Public Class frmRegistry



    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Process.Start("powershell", "-File C:\")
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub GoToTheDebloaterRepositoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim debloaterrepos As String = "https://github.com/Sycnex/Windows10Debloater"
        Process.Start(debloaterrepos)
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Try
            Process.Start("regedit.exe")


        Catch ex As Exception
            MsgBox("Unable to open registry. Could be a permission error?")

        End Try
    End Sub

    Private Sub frmRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MaterialSkin
        Dim SkinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
    End Sub


    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Try
            Process.Start("regedit.exe")


        Catch ex As Exception
            MsgBox("Unable to open registry. Is there a permission error? Did you run as admin?")

        End Try
    End Sub
End Class