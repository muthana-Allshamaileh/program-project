Namespace WinFormsApp2 ' تأكد أن هذا هو اسم مشروعك
    Public Class Program
        <STAThread>
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            ' هون بنحكي للبرنامج: افتح اللوجن فقط!
            Dim login As New frmlogin()
            Application.Run(login)
        End Sub
    End Class
End Namespace