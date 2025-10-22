Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Display the HR Login
        MainPanel.Controls.Clear()
        Dim HR_Login As New HR_Login(MainPanel)
        HR_Login.Dock = DockStyle.None
        HR_Login.Location = New Point((MainPanel.Width - HR_Login.Width) \ 2, (MainPanel.Height - HR_Login.Height) \ 2)
        MainPanel.Controls.Add(HR_Login)
    End Sub

End Class
