Imports WinFormsApp2.WinFormsApp2

Public Class frmmenu
    Private Sub frmemployees_Click(sender As Object, e As EventArgs) Handles frmemployees.Click
        Dim fEmp As New Global.WinFormsApp2.frmEmployees()
        fEmp.ShowDialog()
    End Sub

    Private Sub frmbooks_Click(sender As Object, e As EventArgs) Handles frmbooks.Click
        Dim fBooks As New Global.WinFormsApp2.frmBooks()
        fBooks.ShowDialog()
    End Sub

    Private Sub frmmain_Click(sender As Object, e As EventArgs) Handles frmmain.Click
        Dim fMain As New Global.WinFormsApp2.frmMain()
        fMain.ShowDialog()
    End Sub

    Private Sub frmborrow_Click(sender As Object, e As EventArgs) Handles frmborrow.Click
        Dim fBorrow As New Global.WinFormsApp2.frmBorrow()
        fBorrow.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles frmreturn.Click
        Dim fReturn As New Global.WinFormsApp2.frmReturn()
        fReturn.ShowDialog()
    End Sub


End Class