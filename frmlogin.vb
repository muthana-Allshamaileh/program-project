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

        Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
            Dim user As String = txtUsername.Text.Trim()
            Dim pass As String = txtPassword.Text.Trim()

            If user = "admin" And pass = "123" Then

                frmMain.lblEmpName.Text = "الموظف: " & user
                frmMain.Show()
                Me.Hide()

            Else
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ في الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error)
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