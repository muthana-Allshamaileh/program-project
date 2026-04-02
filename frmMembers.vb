Public Class frmMembers
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvMembers.ColumnCount = 4
        dgvMembers.Columns(0).Name = "رقم المستعير"
        dgvMembers.Columns(1).Name = "اسم المستعير"
        dgvMembers.Columns(2).Name = "رقم الهاتف"
        dgvMembers.Columns(3).Name = "البريد الإلكتروني"

        dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtMemberID.Text = "" Or txtName.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Then
            MessageBox.Show("الرجاء تعبئة جميع الحقول قبل الإضافة!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim row As String() = New String() {txtMemberID.Text, txtName.Text, txtPhone.Text, txtEmail.Text}
        dgvMembers.Rows.Add(row)

        txtMemberID.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtMemberID.Focus()
    End Sub
End Class