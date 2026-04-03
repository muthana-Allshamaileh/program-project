Public Class frmBooks
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvBooks.ColumnCount = 4
        dgvBooks.Columns(0).Name = "رقم الكتاب"
        dgvBooks.Columns(1).Name = "عنوان الكتاب"
        dgvBooks.Columns(2).Name = "اسم المؤلف"
        dgvBooks.Columns(3).Name = "التصنيف"

        dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Label1.Text = "" Or Label2.Text = "" Or Label3.Text = "" Or cmbCategory.Text = "" Then
            MessageBox.Show("الرجاء تعبئة جميع بيانات الكتاب!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim row As String() = New String() {txtBookID.Text, txtTitle.Text, txtAuthor.Text, cmbCategory.Text}
        dgvBooks.Rows.Add(row)


        txtBookID.Clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        cmbCategory.SelectedIndex = -1
        txtBookID.Focus()
    End Sub
End Class