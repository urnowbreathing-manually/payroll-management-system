Public Class HR_Login
    Public Shared MainContentPanel As Panel
    Private dbHandler As DBHandler

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

            ' Hide HR Login Panel
            MainForm.Login_Panel.Hide()

            ' Load all HR Employee Panels
            MainForm.HREMP_Panels_Load()

        Else
            ' Clears both textboxes after incorrect input
            MessageBox.Show("Incorrect Employee ID / Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBox_EmpID.Focus()
            TxtBox_EmpID.Clear()
            TxtBox_Password.Clear()
        End If

    End Sub


End Class
