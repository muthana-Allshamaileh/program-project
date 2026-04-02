<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtBookID = New TextBox()
        txtTitle = New TextBox()
        txtAuthor = New TextBox()
        cmbCategory = New ComboBox()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        dgvBooks = New DataGridView()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(41, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 21)
        Label1.TabIndex = 0
        Label1.Text = "رقم الكتاب"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(41, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 21)
        Label2.TabIndex = 1
        Label2.Text = "عنوان الكتاب"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(41, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 21)
        Label3.TabIndex = 2
        Label3.Text = "إسم المؤلف"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(41, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 21)
        Label4.TabIndex = 3
        Label4.Text = "التصنيف\القسم"
        ' 
        ' txtBookID
        ' 
        txtBookID.Location = New Point(158, 51)
        txtBookID.Name = "txtBookID"
        txtBookID.Size = New Size(136, 23)
        txtBookID.TabIndex = 4
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(158, 94)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(136, 23)
        txtTitle.TabIndex = 5
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(158, 145)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(136, 23)
        txtAuthor.TabIndex = 6
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"علمي", "أدبي", "تاريخي", "ديني ", "قصص مصورة"})
        cmbCategory.Location = New Point(158, 194)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(136, 23)
        cmbCategory.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ActiveCaption
        btnAdd.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        btnAdd.Location = New Point(425, 42)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(86, 32)
        btnAdd.TabIndex = 8
        btnAdd.Text = "إضافة"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.ActiveCaption
        btnEdit.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        btnEdit.Location = New Point(425, 94)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(86, 34)
        btnEdit.TabIndex = 9
        btnEdit.Text = "تعديل"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.ActiveCaption
        btnDelete.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        btnDelete.Location = New Point(425, 147)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(86, 31)
        btnDelete.TabIndex = 10
        btnDelete.Text = "حذف"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' dgvBooks
        ' 
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Location = New Point(63, 251)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.Size = New Size(410, 85)
        dgvBooks.TabIndex = 11
        ' 
        ' frmBooks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(635, 372)
        Controls.Add(dgvBooks)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(cmbCategory)
        Controls.Add(txtAuthor)
        Controls.Add(txtTitle)
        Controls.Add(txtBookID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmBooks"
        Text = "إدارة الكتب "
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvBooks As DataGridView
End Class
