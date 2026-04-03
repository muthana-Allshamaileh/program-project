Public Class frmReturn
    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvReturnDetails.ColumnCount = 5
        dgvReturnDetails.Columns(0).Name = "رقم العملية"
        dgvReturnDetails.Columns(1).Name = "رقم المستعير"
        dgvReturnDetails.Columns(2).Name = "رقم الكتاب"
        dgvReturnDetails.Columns(3).Name = "تاريخ الاستعارة"
        dgvReturnDetails.Columns(4).Name = "تاريخ الإرجاع المتوقع"

        dgvReturnDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearchID.Text = "" Then
            MessageBox.Show("الرجاء إدخال رقم العملية أو رقم المستعير للبحث!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        dgvReturnDetails.Rows.Clear()
        Dim dummyRow As String() = New String() {txtSearchID.Text, "M-101", "B-205", "01/01/2026", "11/01/2026"}
        dgvReturnDetails.Rows.Add(dummyRow)
    End Sub


    Private Sub btnConfirmReturn_Click(sender As Object, e As EventArgs) Handles btnConfirmReturn.Click
        If dgvReturnDetails.Rows.Count = 0 OrElse dgvReturnDetails.Rows(0).IsNewRow Then
            MessageBox.Show("لا يوجد بيانات استعارة لتأكيد إرجاعها. الرجاء البحث أولاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        MessageBox.Show("تم إرجاع الكتاب بنجاح ", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtSearchID.Clear()
        dgvReturnDetails.Rows.Clear()
        txtSearchID.Focus()
    End Sub

End Class