Public Class Sidebar
    Public Shared MainContentPanel As Panel
    Public FocusedButton As Button
    Public PreviousButton As Button

    'Public FocusedPanel As New Panel
    'Public PreviousPanel As New Panel

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub

    Private Sub Sidebar_Load(sender As Object, e As EventArgs) Handles Me.Load
        FocusedButton = Btn_Dashboard
        PreviousButton = Btn_Dashboard

        'FocusedPanel = DashboardPanel
        'PreviousPanel = DashboardPanel
    End Sub

    Private Sub HandleButtonFocused(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click, Btn_Attendance.Click, Btn_Employees.Click, Btn_Logout.Click, Btn_Payroll.Click, Btn_Reports.Click, Btn_Requests.Click, Btn_Settings.Click
        PreviousButton = FocusedButton
        FocusedButton = CType(sender, Button)

        'PreviousPanel = FocusedPanel

        FocusedButton.BackColor = Color.DarkSeaGreen
        If Not PreviousButton.Name = FocusedButton.Name Then
            PreviousButton.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        If FocusedButton.Name = PreviousButton.Name Then
            Return
        End If

        MainForm.HREMP_Panels_Hide()
        Pnl_HR_Dashboard.Show()

    End Sub

    Private Sub Btn_Payroll_Click(sender As Object, e As EventArgs) Handles Btn_Payroll.Click
        If FocusedButton.Name = PreviousButton.Name Then
            Return
        End If

        MainForm.HREMP_Panels_Hide()
        Pnl_GeneratePayroll.Show()
    End Sub

    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click
        ' Clear current user info when logging out
        DBHandler.currentUser = {"", "", "", "", ""}

        ' Load Login
        MainForm.HREMP_Panels_Hide()
        MainForm.Sidebar_Panel.Hide()
        MainForm.Login_Panel.Show()

    End Sub

End Class
