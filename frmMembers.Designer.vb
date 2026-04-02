<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembers
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
        txtMemberID = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnAdd = New Button()
        btnEdit = New Button()
        Button3 = New Button()
        btnDelete = New Button()
        dgvMembers = New DataGridView()
        CType(dgvMembers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtMemberID
        ' 
        txtMemberID.Location = New Point(116, 44)
        txtMemberID.Name = "txtMemberID"
        txtMemberID.Size = New Size(172, 23)
        txtMemberID.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(116, 180)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(224, 23)
        txtEmail.TabIndex = 2
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(116, 129)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(172, 23)
        txtPhone.TabIndex = 3
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(116, 85)
        txtName.Name = "txtName"
        txtName.Size = New Size(224, 23)
        txtName.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(39, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 21)
        Label1.TabIndex = 5
        Label1.Text = "SSN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(39, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 21)
        Label2.TabIndex = 6
        Label2.Text = "Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(39, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 21)
        Label3.TabIndex = 7
        Label3.Text = "Phone "
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(39, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 21)
        Label4.TabIndex = 8
        Label4.Text = "email"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ActiveCaption
        btnAdd.Cursor = Cursors.Hand
        btnAdd.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnAdd.Location = New Point(483, 34)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(113, 38)
        btnAdd.TabIndex = 9
        btnAdd.Text = "إضافة "
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.ActiveCaption
        btnEdit.Cursor = Cursors.Hand
        btnEdit.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnEdit.Location = New Point(483, 85)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(113, 39)
        btnEdit.TabIndex = 10
        btnEdit.Text = "تعديل"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button3.Location = New Point(483, 139)
        Button3.Name = "Button3"
        Button3.Size = New Size(113, 36)
        Button3.TabIndex = 11
        Button3.Text = "حظر"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.ActiveCaption
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnDelete.Location = New Point(483, 191)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(113, 37)
        btnDelete.TabIndex = 12
        btnDelete.Text = "حذف"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' dgvMembers
        ' 
        dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMembers.Location = New Point(57, 250)
        dgvMembers.Name = "dgvMembers"
        dgvMembers.Size = New Size(519, 86)
        dgvMembers.TabIndex = 13
        ' 
        ' frmMembers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(637, 372)
        Controls.Add(dgvMembers)
        Controls.Add(btnDelete)
        Controls.Add(Button3)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtName)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtMemberID)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmMembers"
        StartPosition = FormStartPosition.CenterParent
        Text = "شؤون المستعيرين"
        CType(dgvMembers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMemberID As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvMembers As DataGridView
End Class
