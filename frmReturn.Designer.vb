<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturn
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
        btnSearch = New Button()
        btnConfirmReturn = New Button()
        txtSearchID = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        dgvReturnDetails = New DataGridView()
        CType(dgvReturnDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.ActiveCaption
        btnSearch.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        btnSearch.Location = New Point(607, 43)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(161, 28)
        btnSearch.TabIndex = 0
        btnSearch.Text = "بحث عن الإستعارة"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnConfirmReturn
        ' 
        btnConfirmReturn.BackColor = SystemColors.ActiveCaption
        btnConfirmReturn.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        btnConfirmReturn.Location = New Point(607, 92)
        btnConfirmReturn.Name = "btnConfirmReturn"
        btnConfirmReturn.Size = New Size(161, 28)
        btnConfirmReturn.TabIndex = 1
        btnConfirmReturn.Text = "تأكيد إرجاع الكتاب"
        btnConfirmReturn.UseVisualStyleBackColor = False
        ' 
        ' txtSearchID
        ' 
        txtSearchID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearchID.Location = New Point(412, 42)
        txtSearchID.Name = "txtSearchID"
        txtSearchID.Size = New Size(139, 29)
        txtSearchID.TabIndex = 2
        txtSearchID.Text = "رقم عملية الإستعارة"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaption
        DateTimePicker1.Location = New Point(555, 191)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(213, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' dgvReturnDetails
        ' 
        dgvReturnDetails.BackgroundColor = SystemColors.Control
        dgvReturnDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReturnDetails.Location = New Point(1, 1)
        dgvReturnDetails.Name = "dgvReturnDetails"
        dgvReturnDetails.Size = New Size(391, 450)
        dgvReturnDetails.TabIndex = 4
        ' 
        ' frmReturn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvReturnDetails)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtSearchID)
        Controls.Add(btnConfirmReturn)
        Controls.Add(btnSearch)
        Name = "frmReturn"
        Text = "إرجاع الكتب"
        CType(dgvReturnDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnConfirmReturn As Button
    Friend WithEvents txtSearchID As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dgvReturnDetails As DataGridView
End Class
