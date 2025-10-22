Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class HR_Login

    Public Shared MainContentPanel As Panel
    Private dbHandler As DBHandler

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
        dbHandler = New DBHandler()
    End Sub

    Private Sub HR_Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateTodayLbl.Text = Date.Now.Date.ToString

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        'Clear current user info when logging out
        DBHandler.currentUser = {"", "", "", "", ""}

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
            Dim HR_Dashboard As New HR_Dashboard(MainContentPanel)
            HR_Dashboard.Dock = DockStyle.Fill
            MainContentPanel.Controls.Add(HR_Dashboard)
        Else
            MessageBox.Show("Incorrect Employee ID / Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBox_EmpID.Focus()
        End If

    End Sub



End Class
