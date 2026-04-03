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
        dgvResults.Columns.Clear()
        dgvResults.ColumnCount = 4
        dgvResults.Columns(0).Name = "رقم الكتاب"
        dgvResults.Columns(1).Name = "عنوان الكتاب"
        dgvResults.Columns(2).Name = "اسم المؤلف"
        dgvResults.Columns(3).Name = "حالة الكتاب"
        dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub SetupGridForMembers()
        dgvResults.Columns.Clear()
        dgvResults.ColumnCount = 4
        dgvResults.Columns(0).Name = "رقم المستعير"
        dgvResults.Columns(1).Name = "اسم المستعير"
        dgvResults.Columns(2).Name = "رقم الهاتف"
        dgvResults.Columns(3).Name = "الكتب المستعارة حالياً"
        dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dgvResults.Rows.Clear()

        If txtSearch.Text.Trim() = "" Then
            MessageBox.Show("الرجاء إدخال كلمة للبحث", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If rdbBooks.Checked Then
            dgvResults.Rows.Add(New String() {"B-101", txtSearch.Text, "اسم المؤلف هنا", "متاح"})
        Else
            dgvResults.Rows.Add(New String() {"M-202", txtSearch.Text, "0790000000", "كتابين"})
        End If
    End Sub

End Class