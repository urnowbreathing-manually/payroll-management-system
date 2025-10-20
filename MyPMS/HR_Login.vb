Public Class HR_Login

    Public Shared MainContentPanel As Panel
    Public Shared EmployeeID As String = ""
    Public Shared Password As String = ""

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub

    Private Sub HR_Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateTodayLbl.Text = Date.Now.Date.ToString

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        EmployeeID &= e.KeyChar
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Password &= e.KeyChar
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        MainContentPanel.Dock = DockStyle.None
        MainContentPanel.Controls.Clear()
    End Sub
End Class
