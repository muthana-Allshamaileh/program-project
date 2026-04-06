Public Class frmSearch

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdbBooks.Checked = True
        SetupGridForBooks()
    End Sub

    Private Sub rdbBooks_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBooks.CheckedChanged
        If rdbBooks.Checked Then SetupGridForBooks()
    End Sub

    Private Sub rdbMembers_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMembers.CheckedChanged
        If rdbMembers.Checked Then SetupGridForMembers()
    End Sub

    Private Sub SetupGridForBooks()

    End Sub

    Private Sub SetupGridForMembers()
  
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dgvResults.Rows.Clear()

        If txtSearch.Text.Trim() = "" Then
            MessageBox.Show("الرجاء إدخال كلمة للبحث", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
    End Sub

End Class