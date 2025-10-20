Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        MainPanel.Dock = DockStyle.None
        Dim HR_Login As New HR_Login(MainPanel)
        HR_Login.Location = New Point((MainPanel.Width - HR_Login.Width) \ 2,
                             (MainPanel.Height - HR_Login.Height) \ 2)
        MainPanel.Controls.Add(HR_Login)
    End Sub

    Private Sub Btn_Show_Click(sender As Object, e As EventArgs)
        MainPanel.Dock = DockStyle.None
        Dim HR_Login As New HR_Login(MainPanel)

        HR_Login.Location = New Point((MainPanel.Width - HR_Login.Width) \ 2,
                             (MainPanel.Height - HR_Login.Height) \ 2)
        MainPanel.Controls.Add(HR_Login)


    End Sub

    Private Sub Btn_Hide_Click(sender As Object, e As EventArgs)
        MainPanel.Dock = DockStyle.None
        MainPanel.Controls.Clear()
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ReloadContent()
    End Sub

    Private Sub ReloadContent()
        MainPanel.Dock = DockStyle.None
        MainPanel.Controls.Clear()

        Dim HR_Login As New HR_Login(MainPanel)
        HR_Login.Location = New Point((MainPanel.Width - HR_Login.Width) \ 2,
                             (MainPanel.Height - HR_Login.Height) \ 2)

        For Each control As Control In HR_Login.Controls
            If control.Name = "TextBox1" Then
                control.Text = HR_Login.EmployeeID
            ElseIf control.Name = "TextBox2" Then
                control.Text = HR_Login.Password
            End If
        Next

        MainPanel.Controls.Add(HR_Login)
    End Sub
End Class
