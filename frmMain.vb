Public Class frmMain

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
    End Sub
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("هل أنت متأكد أنك تريد إغلاق النظام؟", "تأكيد الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

End Class
