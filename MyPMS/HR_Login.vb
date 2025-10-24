Public Class HR_Login
    Public Shared MainContentPanel As Panel
    Private dbHandler As DBHandler
<<<<<<< HEAD


=======
>>>>>>> zantua
    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
        dbHandler = New DBHandler()
    End Sub

    Private Sub HR_Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateTodayLbl.Text = DateTime.Now.ToString("MMMM d, yyyy - hh:mm tt")
        DateTodayLbl.Location = New Point(((Panel1.Width - DateTodayLbl.Width) / 2), DateTodayLbl.Location.Y)
        TxtBox_EmpID.Text = "00001-HRA"
        TxtBox_Password.Text = "admin000"
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        ' Error handling
        If String.IsNullOrWhiteSpace(TxtBox_EmpID.Text) Then
            MessageBox.Show("Employee ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBox_EmpID.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TxtBox_Password.Text) Then
            MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBox_Password.Focus()
            Exit Sub
        End If

        ' Account Verification using DBHandler
        If dbHandler.AuthenticateUser(TxtBox_EmpID.Text, TxtBox_Password.Text) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainContentPanel.Controls.Clear()

            ' Load Sidebar
            Dim sideBar As New Sidebar(MainContentPanel)
            sideBar.Dock = DockStyle.Fill

            ' Load HR_Dashboard
<<<<<<< HEAD
            Dim HR_Dashboard As New HR_Dashboard(DashboardPanel)
            HR_Dashboard.Dock = DockStyle.Fill

            Dim generatePayroll As New GeneratePayroll(GeneratePayrollPanel)
            generatePayroll.Dock = DockStyle.Fill
=======
            Dim HR_Dashboard As New HR_Dashboard(MainContentPanel)
            'HR_Dashboard.Dock = DockStyle.Right
            HR_Dashboard.Anchor = AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right Or AnchorStyles.Top
>>>>>>> zantua

            TblPanel.Dock = DockStyle.Fill
            TblPanel.AutoScroll = True

            TblPanel.ColumnCount = 2
            TblPanel.ColumnStyles.Clear()

            TblPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, sideBar.Width + 5))
            TblPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))

            TblPanel.RowCount = 1
            TblPanel.RowStyles.Clear()
            TblPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100))

            sideBar.Dock = DockStyle.Fill

            ' instead of loading panel everytime, load everything then switch around em
            GeneratePayrollPanel.Controls.Add(generatePayroll)
            DashboardPanel.Controls.Add(HR_Dashboard)

<<<<<<< HEAD

            SuperMainPanel.Controls.Add(GeneratePayrollPanel)
            SuperMainPanel.Controls.Add(DashboardPanel)


            TblPanel.Controls.Add(sideBar, 0, 0)
            TblPanel.Controls.Add(SuperMainPanel, 1, 0)


            MainContentPanel.Controls.Add(TblPanel)
=======
            MainContentPanel.Controls.Add(TblPanel)

>>>>>>> zantua
        Else
            ' Clears both textboxes after incorrect input
            MessageBox.Show("Incorrect Employee ID / Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBox_EmpID.Focus()
            TxtBox_EmpID.Clear()
            TxtBox_Password.Clear()
        End If

    End Sub


End Class
