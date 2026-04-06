Public Class frmMembers
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

     
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtMemberID.Text = "" Or txtName.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Then
            MessageBox.Show("الرجاء تعبئة جميع الحقول قبل الإضافة!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
      

        txtMemberID.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtMemberID.Focus()
    End Sub
End Class