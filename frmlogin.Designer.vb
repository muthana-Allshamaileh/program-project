Namespace WinFormsApp2
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmlogin
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
            txtUsername = New TextBox()
            txtPassword = New TextBox()
            btnLogin = New Button()
            Button2 = New Button()
            Label1 = New Label()
            SuspendLayout()
            ' 
            ' txtUsername
            ' 
            txtUsername.BackColor = SystemColors.ScrollBar
            txtUsername.BorderStyle = BorderStyle.FixedSingle
            txtUsername.Cursor = Cursors.IBeam
            txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txtUsername.ForeColor = SystemColors.WindowFrame
            txtUsername.Location = New Point(296, 172)
            txtUsername.Name = "txtUsername"
            txtUsername.Size = New Size(214, 29)
            txtUsername.TabIndex = 0
            txtUsername.Text = "email"
            ' 
            ' txtPassword
            ' 
            txtPassword.BackColor = SystemColors.ScrollBar
            txtPassword.BorderStyle = BorderStyle.FixedSingle
            txtPassword.Cursor = Cursors.IBeam
            txtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txtPassword.ForeColor = SystemColors.WindowFrame
            txtPassword.Location = New Point(296, 207)
            txtPassword.Name = "txtPassword"
            txtPassword.Size = New Size(214, 29)
            txtPassword.TabIndex = 1
            txtPassword.Text = "password"
            ' 
            ' btnLogin
            ' 
            btnLogin.BackColor = Color.Snow
            btnLogin.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btnLogin.ForeColor = Color.Maroon
            btnLogin.Location = New Point(296, 355)
            btnLogin.Name = "btnLogin"
            btnLogin.Size = New Size(95, 39)
            btnLogin.TabIndex = 2
            btnLogin.Text = "login"
            btnLogin.UseVisualStyleBackColor = False
            ' 
            ' Button2
            ' 
            Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            Button2.ForeColor = Color.DarkGoldenrod
            Button2.Location = New Point(417, 355)
            Button2.Name = "Button2"
            Button2.Size = New Size(93, 39)
            Button2.TabIndex = 5
            Button2.Text = "sign up"
            Button2.UseVisualStyleBackColor = True
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.BackColor = Color.Transparent
            Label1.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
            Label1.ForeColor = Color.DimGray
            Label1.ImageAlign = ContentAlignment.MiddleLeft
            Label1.Location = New Point(254, 37)
            Label1.Name = "Label1"
            Label1.Size = New Size(317, 40)
            Label1.TabIndex = 6
            Label1.Text = "المكتبة الالكترونية الحديثة"
            ' 
            ' frmlogin
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.DarkGray
            BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
            BackgroundImageLayout = ImageLayout.Stretch
            ClientSize = New Size(800, 450)
            Controls.Add(Label1)
            Controls.Add(Button2)
            Controls.Add(btnLogin)
            Controls.Add(txtPassword)
            Controls.Add(txtUsername)
            Name = "frmlogin"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Login"
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents txtUsername As TextBox
        Friend WithEvents txtPassword As TextBox
        Friend WithEvents btnLogin As Button
        Friend WithEvents Button2 As Button
        Friend WithEvents Label1 As Label

    End Class
End Namespace