<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        rdbBooks = New RadioButton()
        rdbMembers = New RadioButton()
        btnSearch = New Button()
        txtSearch = New TextBox()
        dgvResults = New DataGridView()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' rdbBooks
        ' 
        rdbBooks.AutoSize = True
        rdbBooks.Location = New Point(634, 151)
        rdbBooks.Name = "rdbBooks"
        rdbBooks.Size = New Size(97, 19)
        rdbBooks.TabIndex = 0
        rdbBooks.TabStop = True
        rdbBooks.Text = "بحث في الكتب"
        rdbBooks.UseVisualStyleBackColor = True
        ' 
        ' rdbMembers
        ' 
        rdbMembers.AutoSize = True
        rdbMembers.Location = New Point(476, 151)
        rdbMembers.Name = "rdbMembers"
        rdbMembers.Size = New Size(126, 19)
        rdbMembers.TabIndex = 1
        rdbMembers.TabStop = True
        rdbMembers.Text = "بحث في المستعيرين"
        rdbMembers.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.ActiveCaption
        btnSearch.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(656, 44)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 29)
        btnSearch.TabIndex = 2
        btnSearch.Text = "بحث"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(476, 49)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(135, 23)
        txtSearch.TabIndex = 3
        ' 
        ' dgvResults
        ' 
        dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResults.Location = New Point(-1, -1)
        dgvResults.Name = "dgvResults"
        dgvResults.Size = New Size(266, 451)
        dgvResults.TabIndex = 4
        ' 
        ' frmSearch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvResults)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        Controls.Add(rdbMembers)
        Controls.Add(rdbBooks)
        Name = "frmSearch"
        Text = "واجهة البحث و الإستعلام"
        CType(dgvResults, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rdbBooks As RadioButton
    Friend WithEvents rdbMembers As RadioButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvResults As DataGridView
End Class
