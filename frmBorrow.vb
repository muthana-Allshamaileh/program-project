Public Class frmBorrow
    Private Sub frmBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click

        If txtBorrowID.Text = "" Or txtMemberID.Text = "" Or txtBookID.Text = "" Then
            MessageBox.Show("الرجاء إدخال رقم العملية ورقم المستعير والكتاب!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim borrowDate As String = dtpBorrowDate.Value.ToShortDateString()
        Dim returnDate As String = dtpReturnDate.Value.ToShortDateString()
       

        txtBorrowID.Clear()
        txtMemberID.Clear()
        txtBookID.Clear()
        txtBorrowID.Focus()
    End Sub
End Class