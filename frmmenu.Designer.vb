Imports Microsoft.VisualBasic.ApplicationServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        frmborrow = New Button()
        frmbooks = New Button()
        frmsetting = New Button()
        frmreturn = New Button()
        frmmain = New Button()
        frmlogin = New Button()
        frmemployees = New Button()
        SuspendLayout()
        ' 
        ' frmborrow
        ' 
        frmborrow.Font = New Font("Andalus", 10.75F, FontStyle.Bold)
        frmborrow.ForeColor = SystemColors.ControlDarkDark
        frmborrow.Location = New Point(638, 132)
        frmborrow.Name = "frmborrow"
        frmborrow.Size = New Size(150, 42)
        frmborrow.TabIndex = 2
        frmborrow.Text = "شاشة حركة إلاستعارة"
        frmborrow.UseVisualStyleBackColor = True
        ' 
        ' frmbooks
        ' 
        frmbooks.Font = New Font("Andalus", 10.75F, FontStyle.Bold)
        frmbooks.ForeColor = SystemColors.ControlDarkDark
        frmbooks.Location = New Point(638, 24)
        frmbooks.Name = "frmbooks"
        frmbooks.Size = New Size(160, 45)
        frmbooks.TabIndex = 3
        frmbooks.Text = "شاشة إدارة الكتاب"
        frmbooks.UseVisualStyleBackColor = True
        ' 
        ' frmsetting
        ' 
        frmsetting.Font = New Font("Andalus", 10.75F, FontStyle.Bold)
        frmsetting.ForeColor = SystemColors.ControlDarkDark
        frmsetting.Location = New Point(3, 399)
        frmsetting.Name = "frmsetting"
        frmsetting.Size = New Size(160, 39)
        frmsetting.TabIndex = 4
        frmsetting.Text = "شاشة الاعدادات"
        frmsetting.UseVisualStyleBackColor = True
        ' 
        ' frmreturn
        ' 
        frmreturn.Font = New Font("Andalus", 10.75F, FontStyle.Bold)
        frmreturn.ForeColor = SystemColors.ControlDarkDark
        frmreturn.Location = New Point(3, 251)
        frmreturn.Name = "frmreturn"
        frmreturn.Size = New Size(160, 42)
        frmreturn.TabIndex = 5
        frmreturn.Text = "شاشة الخروج"
        frmreturn.UseVisualStyleBackColor = True
        ' 
        ' frmmain
        ' 
        frmmain.Font = New Font("Andalus", 10.75F, FontStyle.Bold)
        frmmain.ForeColor = SystemColors.ControlDarkDark
        frmmain.Location = New Point(3, 132)
        frmmain.Name = "frmmain"
        frmmain.Size = New Size(160, 42)
        frmmain.TabIndex = 6
        frmmain.Text = "الشاشة الرئيسية "
        frmmain.UseVisualStyleBackColor = True
        ' 
        ' frmlogin
        ' 
        frmlogin.Font = New Font("Andalus", 10.75F, FontStyle.Bold)
        frmlogin.ForeColor = SystemColors.ControlDarkDark
        frmlogin.Location = New Point(3, 24)
        frmlogin.Name = "frmlogin"
        frmlogin.Size = New Size(160, 45)
        frmlogin.TabIndex = 8
        frmlogin.Text = "شاشة تسجيل الدخول"
        frmlogin.UseVisualStyleBackColor = True
        ' 
        ' frmemployees
        ' 
        frmemployees.Font = New Font("Andalus", 10.75F, FontStyle.Bold)
        frmemployees.ForeColor = SystemColors.ControlDarkDark
        frmemployees.Location = New Point(638, 251)
        frmemployees.Name = "frmemployees"
        frmemployees.Size = New Size(160, 42)
        frmemployees.TabIndex = 9
        frmemployees.Text = "شاشة سجل الموظفين"
        frmemployees.UseVisualStyleBackColor = True
        ' 
        ' frmmenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(800, 450)
        Controls.Add(frmemployees)
        Controls.Add(frmlogin)
        Controls.Add(frmmain)
        Controls.Add(frmreturn)
        Controls.Add(frmsetting)
        Controls.Add(frmbooks)
        Controls.Add(frmborrow)
        Name = "frmmenu"
        Text = "Menu شاشة ال "
        ResumeLayout(False)
    End Sub
    Friend WithEvents frmborrow As Button
    Friend WithEvents frmbooks As Button
    Friend WithEvents frmsetting As Button
    Friend WithEvents frmreturn As Button
    Friend WithEvents frmmain As Button
    Friend WithEvents frmlogin As Button
    Friend WithEvents frmemployees As Button
End Class
