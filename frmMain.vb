Imports WinFormsApp2.WinFormsApp2

Public Class frmMain

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
    End Sub
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("هل أنت متأكد أنك تريد إغلاق النظام؟", "تأكيد الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New frmMembers()

        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmBooks()
        frm.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim frm As New frmBorrow()
        frm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmEmployees()
        frm.ShowDialog()
    End Sub

    Private Sub btnSearchForm_Click(sender As Object, e As EventArgs) Handles btnSearchForm.Click
        Dim frm As New frmSearch()
        frm.ShowDialog()
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        Dim frm As New frmReturn()
        frm.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub تسجيلخروجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تسجيلخروجToolStripMenuItem.Click
        frmlloo.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub
End Class
