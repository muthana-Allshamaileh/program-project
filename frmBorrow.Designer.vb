<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrow
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
        txtBorrowID = New TextBox()
        txtMemberID = New TextBox()
        txtBookID = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        dtpBorrowDate = New DateTimePicker()
        dtpReturnDate = New DateTimePicker()
        btnBorrow = New Button()
        btnReturn = New Button()
        dgvBorrow = New DataGridView()
        CType(dgvBorrow, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtBorrowID
        ' 
        txtBorrowID.Location = New Point(209, 48)
        txtBorrowID.Name = "txtBorrowID"
        txtBorrowID.Size = New Size(90, 23)
        txtBorrowID.TabIndex = 0
        ' 
        ' txtMemberID
        ' 
        txtMemberID.Location = New Point(209, 101)
        txtMemberID.Name = "txtMemberID"
        txtMemberID.Size = New Size(90, 23)
        txtMemberID.TabIndex = 1
        ' 
        ' txtBookID
        ' 
        txtBookID.Location = New Point(209, 161)
        txtBookID.Name = "txtBookID"
        txtBookID.Size = New Size(90, 23)
        txtBookID.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(93, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 17)
        Label1.TabIndex = 3
        Label1.Text = "رقم العملية" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(97, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 17)
        Label2.TabIndex = 4
        Label2.Text = "رقم الكتاب"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(97, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 17)
        Label3.TabIndex = 5
        Label3.Text = "رقم المستعير"
        ' 
        ' dtpBorrowDate
        ' 
        dtpBorrowDate.Enabled = False
        dtpBorrowDate.Location = New Point(594, 45)
        dtpBorrowDate.Name = "dtpBorrowDate"
        dtpBorrowDate.Size = New Size(194, 23)
        dtpBorrowDate.TabIndex = 6
        ' 
        ' dtpReturnDate
        ' 
        dtpReturnDate.Location = New Point(594, 143)
        dtpReturnDate.Name = "dtpReturnDate"
        dtpReturnDate.Size = New Size(194, 23)
        dtpReturnDate.TabIndex = 7
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = SystemColors.ActiveCaption
        btnBorrow.Cursor = Cursors.Hand
        btnBorrow.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnBorrow.Location = New Point(433, 40)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(116, 33)
        btnBorrow.TabIndex = 8
        btnBorrow.Text = "إستعارة الكتاب"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = SystemColors.ActiveCaption
        btnReturn.Cursor = Cursors.Hand
        btnReturn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnReturn.Location = New Point(433, 138)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(116, 36)
        btnReturn.TabIndex = 9
        btnReturn.Text = "إرجاع الكتاب" & vbCrLf
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' dgvBorrow
        ' 
        dgvBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrow.Location = New Point(111, 279)
        dgvBorrow.Name = "dgvBorrow"
        dgvBorrow.Size = New Size(545, 124)
        dgvBorrow.TabIndex = 10
        ' 
        ' frmBorrow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(dgvBorrow)
        Controls.Add(btnReturn)
        Controls.Add(btnBorrow)
        Controls.Add(dtpReturnDate)
        Controls.Add(dtpBorrowDate)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtBookID)
        Controls.Add(txtMemberID)
        Controls.Add(txtBorrowID)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmBorrow"
        Text = "حركة الإستعارة"
        CType(dgvBorrow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBorrowID As TextBox
    Friend WithEvents txtMemberID As TextBox
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpBorrowDate As DateTimePicker
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents dgvBorrow As DataGridView
End Class
