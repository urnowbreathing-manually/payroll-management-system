Public Class Sidebar
    Public Shared MainContentPanel As Panel

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub

    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        MainContentPanel.Controls.Clear()

        ' Load Sidebar
        Dim sideBar As New Sidebar(MainContentPanel)
        sideBar.Dock = DockStyle.Left
        MainContentPanel.Controls.Add(sideBar)

        ' Load HR_Dashboard
        Dim HR_Dashboard As New HR_Dashboard(MainContentPanel)
        HR_Dashboard.Dock = DockStyle.Right
        MainContentPanel.Controls.Add(HR_Dashboard)
    End Sub

    Private Sub Btn_Payroll_Click(sender As Object, e As EventArgs) Handles Btn_Payroll.Click
        MainContentPanel.Controls.Clear()

        Dim sideBar As New Sidebar(MainContentPanel)
        sideBar.Dock = DockStyle.Left
        MainContentPanel.Controls.Add(sideBar)

        Dim generatePayroll As New GeneratePayroll(MainContentPanel)
        generatePayroll.Dock = DockStyle.Right
        MainContentPanel.Controls.Add(generatePayroll)
    End Sub

    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click
        MainContentPanel.Controls.Clear()

        'Clear current user info when logging out
        DBHandler.currentUser = {"", "", "", "", ""}

        Dim HR_Login As New HR_Login(MainContentPanel)
        HR_Login.Dock = DockStyle.None
        HR_Login.Location = New Point((MainContentPanel.Width - HR_Login.Width) \ 2, (MainContentPanel.Height - HR_Login.Height) \ 2)
        MainContentPanel.Controls.Add(HR_Login)

    End Sub
End Class
