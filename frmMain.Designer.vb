<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        MenuStrip1 = New MenuStrip()
        النوافذToolStripMenuItem = New ToolStripMenuItem()
        إدارةالكتبوالمؤلفينToolStripMenuItem = New ToolStripMenuItem()
        الإستعارةToolStripMenuItem = New ToolStripMenuItem()
        الإرجاعToolStripMenuItem = New ToolStripMenuItem()
        إدارةالأعضاءToolStripMenuItem = New ToolStripMenuItem()
        إدارةالكتبToolStripMenuItem = New ToolStripMenuItem()
        إدارةالمؤلفينToolStripMenuItem = New ToolStripMenuItem()
        الإستعارةوالإسترجاعToolStripMenuItem = New ToolStripMenuItem()
        إدارةالأعضاءToolStripMenuItem1 = New ToolStripMenuItem()
        إدارةالموظفينToolStripMenuItem1 = New ToolStripMenuItem()
        ملفToolStripMenuItem = New ToolStripMenuItem()
        إعداداتToolStripMenuItem = New ToolStripMenuItem()
        أخذنسخةإحتياطيةToolStripMenuItem = New ToolStripMenuItem()
        تسجيلخروجToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        lblEmpName = New ToolStripStatusLabel()
        lblDate = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        btnSearchForm = New Button()
        btnReturnBook = New Button()
        Panel2 = New Panel()
        Button1 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.Items.AddRange(New ToolStripItem() {النوافذToolStripMenuItem, إدارةالكتبوالمؤلفينToolStripMenuItem, إدارةالأعضاءToolStripMenuItem, الإستعارةوالإسترجاعToolStripMenuItem, ملفToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.MdiWindowListItem = النوافذToolStripMenuItem
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' النوافذToolStripMenuItem
        ' 
        النوافذToolStripMenuItem.Name = "النوافذToolStripMenuItem"
        النوافذToolStripMenuItem.Size = New Size(51, 20)
        النوافذToolStripMenuItem.Text = "النوافذ"
        ' 
        ' إدارةالكتبوالمؤلفينToolStripMenuItem
        ' 
        إدارةالكتبوالمؤلفينToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {الإستعارةToolStripMenuItem, الإرجاعToolStripMenuItem})
        إدارةالكتبوالمؤلفينToolStripMenuItem.Name = "إدارةالكتبوالمؤلفينToolStripMenuItem"
        إدارةالكتبوالمؤلفينToolStripMenuItem.Size = New Size(62, 20)
        إدارةالكتبوالمؤلفينToolStripMenuItem.Text = "العمليات"
        ' 
        ' الإستعارةToolStripMenuItem
        ' 
        الإستعارةToolStripMenuItem.Name = "الإستعارةToolStripMenuItem"
        الإستعارةToolStripMenuItem.Size = New Size(118, 22)
        الإستعارةToolStripMenuItem.Text = "الإستعارة"
        ' 
        ' الإرجاعToolStripMenuItem
        ' 
        الإرجاعToolStripMenuItem.Name = "الإرجاعToolStripMenuItem"
        الإرجاعToolStripMenuItem.Size = New Size(118, 22)
        الإرجاعToolStripMenuItem.Text = "الإرجاع"
        ' 
        ' إدارةالأعضاءToolStripMenuItem
        ' 
        إدارةالأعضاءToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {إدارةالكتبToolStripMenuItem, إدارةالمؤلفينToolStripMenuItem})
        إدارةالأعضاءToolStripMenuItem.Name = "إدارةالأعضاءToolStripMenuItem"
        إدارةالأعضاءToolStripMenuItem.Size = New Size(60, 20)
        إدارةالأعضاءToolStripMenuItem.Text = "الملفات "
        ' 
        ' إدارةالكتبToolStripMenuItem
        ' 
        إدارةالكتبToolStripMenuItem.Name = "إدارةالكتبToolStripMenuItem"
        إدارةالكتبToolStripMenuItem.Size = New Size(141, 22)
        إدارةالكتبToolStripMenuItem.Text = "إدارة الكتب"
        ' 
        ' إدارةالمؤلفينToolStripMenuItem
        ' 
        إدارةالمؤلفينToolStripMenuItem.Name = "إدارةالمؤلفينToolStripMenuItem"
        إدارةالمؤلفينToolStripMenuItem.Size = New Size(141, 22)
        إدارةالمؤلفينToolStripMenuItem.Text = "إدارة المؤلفين"
        ' 
        ' الإستعارةوالإسترجاعToolStripMenuItem
        ' 
        الإستعارةوالإسترجاعToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {إدارةالأعضاءToolStripMenuItem1, إدارةالموظفينToolStripMenuItem1})
        الإستعارةوالإسترجاعToolStripMenuItem.Name = "الإستعارةوالإسترجاعToolStripMenuItem"
        الإستعارةوالإسترجاعToolStripMenuItem.Size = New Size(79, 20)
        الإستعارةوالإسترجاعToolStripMenuItem.Text = "المستخدمين"
        ' 
        ' إدارةالأعضاءToolStripMenuItem1
        ' 
        إدارةالأعضاءToolStripMenuItem1.Name = "إدارةالأعضاءToolStripMenuItem1"
        إدارةالأعضاءToolStripMenuItem1.Size = New Size(147, 22)
        إدارةالأعضاءToolStripMenuItem1.Text = "إدارة الأعضاء "
        ' 
        ' إدارةالموظفينToolStripMenuItem1
        ' 
        إدارةالموظفينToolStripMenuItem1.Name = "إدارةالموظفينToolStripMenuItem1"
        إدارةالموظفينToolStripMenuItem1.Size = New Size(147, 22)
        إدارةالموظفينToolStripMenuItem1.Text = "إدارة الموظفين"
        ' 
        ' ملفToolStripMenuItem
        ' 
        ملفToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {إعداداتToolStripMenuItem, أخذنسخةإحتياطيةToolStripMenuItem, تسجيلخروجToolStripMenuItem})
        ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        ملفToolStripMenuItem.Size = New Size(50, 20)
        ملفToolStripMenuItem.Text = "النظام"
        ' 
        ' إعداداتToolStripMenuItem
        ' 
        إعداداتToolStripMenuItem.Name = "إعداداتToolStripMenuItem"
        إعداداتToolStripMenuItem.Size = New Size(180, 22)
        إعداداتToolStripMenuItem.Text = "إعدادات "
        ' 
        ' أخذنسخةإحتياطيةToolStripMenuItem
        ' 
        أخذنسخةإحتياطيةToolStripMenuItem.Name = "أخذنسخةإحتياطيةToolStripMenuItem"
        أخذنسخةإحتياطيةToolStripMenuItem.Size = New Size(180, 22)
        أخذنسخةإحتياطيةToolStripMenuItem.Text = "أخذ نسخة إحتياطية "
        ' 
        ' تسجيلخروجToolStripMenuItem
        ' 
        تسجيلخروجToolStripMenuItem.Name = "تسجيلخروجToolStripMenuItem"
        تسجيلخروجToolStripMenuItem.Size = New Size(180, 22)
        تسجيلخروجToolStripMenuItem.Text = "تسجيل خروج"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = SystemColors.ActiveCaption
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblEmpName, lblDate})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblEmpName
        ' 
        lblEmpName.Name = "lblEmpName"
        lblEmpName.Size = New Size(72, 17)
        lblEmpName.Text = "إسم الموظف"
        ' 
        ' lblDate
        ' 
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(77, 17)
        lblDate.Text = "التاريخ والوقت"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SlateGray
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnSearchForm)
        Panel1.Controls.Add(btnReturnBook)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(132, 404)
        Panel1.TabIndex = 4
        ' 
        ' btnSearchForm
        ' 
        btnSearchForm.Cursor = Cursors.Hand
        btnSearchForm.FlatAppearance.BorderSize = 0
        btnSearchForm.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnSearchForm.FlatAppearance.MouseOverBackColor = Color.OrangeRed
        btnSearchForm.FlatStyle = FlatStyle.Flat
        btnSearchForm.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnSearchForm.ForeColor = SystemColors.ButtonFace
        btnSearchForm.Image = CType(resources.GetObject("btnSearchForm.Image"), Image)
        btnSearchForm.ImageAlign = ContentAlignment.MiddleLeft
        btnSearchForm.Location = New Point(1, 44)
        btnSearchForm.Name = "btnSearchForm"
        btnSearchForm.Padding = New Padding(3, 0, 0, 0)
        btnSearchForm.Size = New Size(123, 57)
        btnSearchForm.TabIndex = 7
        btnSearchForm.Text = "البحث والإستعلام"
        btnSearchForm.TextAlign = ContentAlignment.MiddleLeft
        btnSearchForm.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSearchForm.UseVisualStyleBackColor = True
        ' 
        ' btnReturnBook
        ' 
        btnReturnBook.Cursor = Cursors.Hand
        btnReturnBook.FlatAppearance.BorderSize = 0
        btnReturnBook.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnReturnBook.FlatAppearance.MouseOverBackColor = Color.OrangeRed
        btnReturnBook.FlatStyle = FlatStyle.Flat
        btnReturnBook.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnReturnBook.ForeColor = SystemColors.ButtonFace
        btnReturnBook.Image = CType(resources.GetObject("btnReturnBook.Image"), Image)
        btnReturnBook.ImageAlign = ContentAlignment.MiddleLeft
        btnReturnBook.Location = New Point(-1, 322)
        btnReturnBook.Name = "btnReturnBook"
        btnReturnBook.Padding = New Padding(3, 0, 0, 0)
        btnReturnBook.Size = New Size(126, 56)
        btnReturnBook.TabIndex = 6
        btnReturnBook.Text = "إرجاع الكتب "
        btnReturnBook.TextAlign = ContentAlignment.MiddleLeft
        btnReturnBook.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReturnBook.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(128, 48)
        Panel2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatAppearance.MouseOverBackColor = Color.OrangeRed
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(0, -1)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(3, 0, 0, 0)
        Button1.Size = New Size(123, 47)
        Button1.TabIndex = 0
        Button1.Text = "الرئيسية"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button5.FlatAppearance.MouseOverBackColor = Color.OrangeRed
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Button5.ForeColor = SystemColors.ButtonFace
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(-1, 269)
        Button5.Name = "Button5"
        Button5.Padding = New Padding(3, 0, 0, 0)
        Button5.Size = New Size(126, 56)
        Button5.TabIndex = 4
        Button5.Text = "حركة الإستعارة"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.TextImageRelation = TextImageRelation.ImageBeforeText
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.FlatAppearance.MouseOverBackColor = Color.OrangeRed
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(-1, 206)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(3, 0, 0, 0)
        Button4.Size = New Size(126, 57)
        Button4.TabIndex = 3
        Button4.Text = "شؤون المستعيرين"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.FlatAppearance.MouseOverBackColor = Color.OrangeRed
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(-2, 142)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(3, 0, 0, 0)
        Button3.Size = New Size(126, 58)
        Button3.TabIndex = 2
        Button3.Text = "سجل الموظفين"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.FlatAppearance.MouseOverBackColor = Color.OrangeRed
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(2, 94)
        Button2.Name = "Button2"
        Button2.Size = New Size(126, 57)
        Button2.TabIndex = 1
        Button2.Text = "إدارة الكتب"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "frmMain"
        Text = "نظام إدارة المكتبة - الشاشة الرئيسية"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents إدارةالكتبوالمؤلفينToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents إدارةالأعضاءToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الإستعارةوالإسترجاعToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblEmpName As ToolStripStatusLabel
    Friend WithEvents lblDate As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents النوافذToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents إعداداتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents أخذنسخةإحتياطيةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents تسجيلخروجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الإستعارةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الإرجاعToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents إدارةالكتبToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents إدارةالمؤلفينToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents إدارةالأعضاءToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents إدارةالموظفينToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents btnSearchForm As Button


End Class
