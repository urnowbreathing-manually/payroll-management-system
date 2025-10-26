Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Display the HR Login
        Sidebar_Panel.Hide()
        Dim HR_Login As New HR_Login(Login_Panel)
        HR_Login.Dock = DockStyle.Fill
        Login_Panel.Controls.Add(HR_Login)
    End Sub

    ' []=======================================[ P A N E L   V I S I B I L I T Y ]==================================[]

    ' Control HR Sidebar Visibility
    Private Sub Btn_Show_Sidebar_Click(sender As Object, e As EventArgs) Handles Btn_Show_Sidebar.Click
        If Login_Panel.Visible = False Then
            If Sidebar_Panel.Visible = False Then
                Sidebar_Panel.Show()
            Else
                Sidebar_Panel.Hide()
            End If
        End If
    End Sub

    ' Hide all HR Employee Panels during Sidebar button press event
    Public Sub HREMP_Panels_Hide()
        Pnl_HR_Dashboard.Hide()
        Pnl_GeneratePayroll.Hide()
    End Sub

    ' Load All HR Employee Panels
    Public Sub HREMP_Panels_Load()

        ' Hide Login Logo Panel
        BG_Logo_Panel.Hide()

        ' Load HR Employee Sidebar
        Dim Sidebar As New Sidebar(Sidebar_Panel)
        Sidebar_Panel.Controls.Add(Sidebar)
        Sidebar.Dock = DockStyle.Fill

        ' Load HR Employee Dashboard
        Me.Controls.Add(Pnl_HR_Dashboard)
        Pnl_HR_Dashboard.Show()
        Dim HR_Dashboard As New HR_Dashboard(Pnl_HR_Dashboard)
        Pnl_HR_Dashboard.Controls.Add(HR_Dashboard)
        HR_Dashboard.Dock = DockStyle.Fill

        ' Load Generate Payroll Dashboard
        Me.Controls.Add(Pnl_GeneratePayroll)
        Pnl_GeneratePayroll.Show()
        Dim GeneratePayroll As New GeneratePayroll(Pnl_GeneratePayroll)
        Pnl_GeneratePayroll.Controls.Add(GeneratePayroll)
        GeneratePayroll.Dock = DockStyle.Fill


    End Sub


End Class
