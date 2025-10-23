Public Class Sidebar
    Public Shared MainContentPanel As Panel
    Public FocusedButton As Button
    Public PreviousButton As Button

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub

    Private Sub Sidebar_Load(sender As Object, e As EventArgs) Handles Me.Load
        FocusedButton = Btn_Dashboard
        PreviousButton = Btn_Dashboard
    End Sub

    Private Sub HandleButtonFocused(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click, Btn_Attendance.Click, Btn_Employees.Click, Btn_Logout.Click, Btn_Payroll.Click, Btn_Reports.Click, Btn_Requests.Click, Btn_Settings.Click
        PreviousButton = FocusedButton
        FocusedButton = CType(sender, Button)

        FocusedButton.BackColor = Color.DarkSeaGreen
        If Not PreviousButton.Name = FocusedButton.Name Then
            PreviousButton.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        If FocusedButton.Name = PreviousButton.Name Then
            Return
        End If

        Dim HR_Dashboard As New HR_Dashboard(MainContentPanel)
        HR_Dashboard.Dock = DockStyle.Fill

        TblPanel.Controls.RemoveAt(1)
        TblPanel.Controls.Add(HR_Dashboard, 1, 0)
    End Sub

    Private Sub Btn_Payroll_Click(sender As Object, e As EventArgs) Handles Btn_Payroll.Click
        If FocusedButton.Name = PreviousButton.Name Then
            Return
        End If

        PreviousButton = FocusedButton
        FocusedButton = CType(sender, Button)

        Dim generatePayroll As New GeneratePayroll(MainContentPanel)
        generatePayroll.Dock = DockStyle.Fill

        TblPanel.Controls.RemoveAt(1)
        TblPanel.Controls.Add(generatePayroll, 1, 0)
    End Sub

    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click
        MainContentPanel.Controls.Clear()

        ' Clear current user info when logging out
        DBHandler.currentUser = {"", "", "", "", ""}

        ' Load Login
        Dim HR_Login As New HR_Login(MainContentPanel)
        HR_Login.Dock = DockStyle.None
        HR_Login.Location = New Point((MainContentPanel.Width - HR_Login.Width) \ 2, (MainContentPanel.Height - HR_Login.Height) \ 2)
        MainContentPanel.Controls.Add(HR_Login)

    End Sub

End Class
