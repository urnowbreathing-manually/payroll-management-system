Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Display the HR Login


        MainPanel.Dock = DockStyle.None
        Dim HR_Login As New HR_Login(MainPanel)
        HR_Login.Location = New Point((MainPanel.Width - HR_Login.Width) \ 2, (MainPanel.Height - HR_Login.Height) \ 2)
        MainPanel.Controls.Add(HR_Login)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MainPanel.Controls.Clear()

        Dim sideBar As New Sidebar(MainPanel)
        sideBar.Dock = DockStyle.Left
        MainPanel.Controls.Add(sideBar)

        Dim generatePayroll As New GeneratePayroll(MainPanel)
        generatePayroll.Dock = DockStyle.Right
        MainPanel.Controls.Add(generatePayroll)

    End Sub


End Class
