Public Class frmBooks
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Label1.Text = "" Or Label2.Text = "" Or Label3.Text = "" Or cmbCategory.Text = "" Then
            MessageBox.Show("الرجاء تعبئة جميع بيانات الكتاب!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
      


        txtBookID.Clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        cmbCategory.SelectedIndex = -1
        txtBookID.Focus()
    End Sub
End Class