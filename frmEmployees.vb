Public Class frmEmployees
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

       
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtEmpID.Text = "" Or txtName.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
            MessageBox.Show("الرجاء تعبئة البيانات الأساسية للموظف!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
      
        txtEmpID.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtPassword.Clear()
        cmbRole.SelectedIndex = -1
        txtEmpID.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtEmpID.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtPassword.Clear()
        cmbRole.SelectedIndex = -1
        txtEmpID.Focus()
    End Sub
End Class