Imports WinFormsApp2.WinFormsApp2

Public Class frmmenu
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles frmmain.Click
        frmmain.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles frmreturn.Click
        frmreturn.Show()
    End Sub

    Private Sub frmbooks_Click(sender As Object, e As EventArgs) Handles frmbooks.Click
        frmbooks.Show()
    End Sub
    Private Sub frmemployees_Click(sender As Object, e As EventArgs) Handles frmemployees.Click
        frmemployees.Show()
    End Sub

    Private Sub frmmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmlogin_Click(sender As Object, e As EventArgs) Handles frmlogin.Click

    End Sub

    Private Sub frmborrow_Click(sender As Object, e As EventArgs) Handles frmborrow.Click
        frmborrow.Show()
    End Sub

    Private Sub frmsetting_Click(sender As Object, e As EventArgs) Handles frmsetting.Click

    End Sub
End Class