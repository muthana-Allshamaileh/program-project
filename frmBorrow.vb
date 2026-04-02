Public Class frmBorrow
    Private Sub frmBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvBorrow.ColumnCount = 5
        dgvBorrow.Columns(0).Name = "رقم العملية"
        dgvBorrow.Columns(1).Name = "رقم المستعير"
        dgvBorrow.Columns(2).Name = "رقم الكتاب"
        dgvBorrow.Columns(3).Name = "تاريخ الاستعارة"
        dgvBorrow.Columns(4).Name = "تاريخ الإرجاع"
        dgvBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dtpReturnDate.Value = DateTime.Now.AddDays(10)
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click

        If txtBorrowID.Text = "" Or txtMemberID.Text = "" Or txtBookID.Text = "" Then
            MessageBox.Show("الرجاء إدخال رقم العملية ورقم المستعير والكتاب!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim borrowDate As String = dtpBorrowDate.Value.ToShortDateString()
        Dim returnDate As String = dtpReturnDate.Value.ToShortDateString()
        Dim row As String() = New String() {txtBorrowID.Text, txtMemberID.Text, txtBookID.Text, borrowDate, returnDate}
        dgvBorrow.Rows.Add(row)

        txtBorrowID.Clear()
        txtMemberID.Clear()
        txtBookID.Clear()
        txtBorrowID.Focus()
    End Sub
End Class