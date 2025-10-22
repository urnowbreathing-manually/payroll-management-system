Public Class HR_Login

    Public Shared MainContentPanel As Panel
    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub

    Private Sub HR_Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateTodayLbl.Text = Date.Now.Date.ToString

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        MainContentPanel.Dock = DockStyle.None
        MainContentPanel.Controls.Clear()
    End Sub
End Class
