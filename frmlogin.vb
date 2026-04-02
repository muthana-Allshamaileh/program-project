Imports System.DirectoryServices.ActiveDirectory
Namespace WinFormsApp2
    Public Class frmlogin
        Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        End Sub

        Private Sub btnLogin_Click1(sender As Object, e As EventArgs) Handles btnLogin.Click
            If txtUsername.Text = "admin" And txtPassword.Text = "123" Then
                ' افتح المين
                Dim main As New frmMain()
                main.Show()

                ' أغلق اللوجن نهائياً (بدل Hide استخدم Close إذا عملت الخطوة 1)
                Me.Hide()
            Else
                MessageBox.Show("خطأ")
            End If
        End Sub
        Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
            ' 1. تنظيف المدخلات من الفراغات الزائدة
            Dim user As String = txtUsername.Text.Trim()
            Dim pass As String = txtPassword.Text.Trim()

            ' 2. فحص البيانات (عدلهم حسب شو بدك)
            If user = "admin" And pass = "123" Then

                ' 3. السطر السحري: نفتح المين مباشرة بدون كلمة New
                frmMain.Show()

                ' 4. إخفاء شاشة اللوجن الحالية
                Me.Hide()

            Else
                ' رسالة خطأ احترافية
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ في الدخول",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' تنظيف الحقول للمحاولة مرة ثانية
                txtPassword.Clear()
                txtUsername.Focus()
            End If
        End Sub
        Private Sub frmlogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
            Application.Exit()
        End Sub

        Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        End Sub
        Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtPassword.Focus()
                e.SuppressKeyPress = True

            End If
        End Sub
        Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

        End Sub
    End Class
End Namespace