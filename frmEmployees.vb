Public Class frmEmployees
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvEmployees.ColumnCount = 5
        dgvEmployees.Columns(0).Name = "رقم موظف"
        dgvEmployees.Columns(1).Name = "الاسم"
        dgvEmployees.Columns(2).Name = "رقم لهاتف"
        dgvEmployees.Columns(3).Name = "الصلاحية"
        dgvEmployees.Columns(4).Name = "كلمة المرور"
        dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtEmpID.Text = "" Or txtName.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
            MessageBox.Show("الرجاء تعبئة البيانات الأساسية للموظف!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim row As String() = New String() {txtEmpID.Text, txtName.Text, txtPhone.Text, cmbRole.Text, txtPassword.Text}
        dgvEmployees.Rows.Add(row)
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