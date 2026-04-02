<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtEmpID = New TextBox()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cmbRole = New ComboBox()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        Label5 = New Label()
        dgvEmployees = New DataGridView()
        Panel1 = New Panel()
        btnReset = New Button()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtEmpID
        ' 
        txtEmpID.Location = New Point(119, 25)
        txtEmpID.Name = "txtEmpID"
        txtEmpID.Size = New Size(222, 23)
        txtEmpID.TabIndex = 0
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(119, 74)
        txtName.Name = "txtName"
        txtName.Size = New Size(222, 23)
        txtName.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(119, 114)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(222, 23)
        txtPhone.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(119, 152)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(222, 23)
        txtPassword.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.RosyBrown
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 17)
        Label1.TabIndex = 4
        Label1.Text = "رقم الموظف"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.RosyBrown
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(12, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 17)
        Label2.TabIndex = 5
        Label2.Text = "إسم الموظف"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.RosyBrown
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(12, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 17)
        Label3.TabIndex = 6
        Label3.Text = "رقم الهاتف"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.RosyBrown
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(12, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 17)
        Label4.TabIndex = 7
        Label4.Text = "كلمة المرور"
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"مدير نظام", "أمين مكتبة", "موظف إستقبال"})
        cmbRole.Location = New Point(119, 196)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(222, 23)
        cmbRole.TabIndex = 8
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.YellowGreen
        btnAdd.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        btnAdd.Location = New Point(254, 257)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(87, 30)
        btnAdd.TabIndex = 9
        btnAdd.Text = "إضافة"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.RosyBrown
        btnEdit.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        btnEdit.Location = New Point(254, 360)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(87, 30)
        btnEdit.TabIndex = 10
        btnEdit.Text = "تعديل"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Maroon
        btnDelete.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        btnDelete.Location = New Point(254, 310)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(87, 30)
        btnDelete.TabIndex = 11
        btnDelete.Text = "حذف"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.RosyBrown
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(12, 197)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 17)
        Label5.TabIndex = 12
        Label5.Text = "الصلاحيات"
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(3, 0)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.Size = New Size(438, 450)
        dgvEmployees.TabIndex = 13
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(btnReset)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtEmpID)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(txtPhone)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(cmbRole)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(435, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(365, 450)
        Panel1.TabIndex = 14
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        btnReset.Location = New Point(254, 408)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(87, 30)
        btnReset.TabIndex = 14
        btnReset.Text = "إلغاء"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' frmEmployees
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(dgvEmployees)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmEmployees"
        Text = "سجل الموظفين"
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnReset As Button
End Class
