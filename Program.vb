Namespace WinFormsApp2
    Public Class Program
        <STAThread>
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)


            Dim login As New frmlogin()
            Application.Run(login)
        End Sub
    End Class
End Namespace