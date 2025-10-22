Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Display the HR Login
        MainPanel.Dock = DockStyle.None
        Dim HR_Login As New HR_Login(MainPanel)
        HR_Login.Location = New Point((MainPanel.Width - HR_Login.Width) \ 2, (MainPanel.Height - HR_Login.Height) \ 2)
        MainPanel.Controls.Add(HR_Login)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim flowPanel As New FlowLayoutPanel
        'flowPanel.Margin = New Padding(0, 0, 5, 0)
        flowPanel.FlowDirection = FlowDirection.LeftToRight
        'flowPanel.Size = MainPanel.Size
        flowPanel.AutoSize = True

        Dim sideBar As New Sidebar(MainPanel)
        sideBar.Size = New System.Drawing.Size(150, MainPanel.Height)

        Dim generatePayroll As New GeneratePayroll(MainPanel)
        generatePayroll.Size = New System.Drawing.Size(MainPanel.Width, MainPanel.Height)
        'generatePayroll.AutoSize = True

        flowPanel.Controls.Add(sideBar)
        flowPanel.Controls.Add(generatePayroll)

        MainPanel.Dock = DockStyle.None
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(flowPanel)

    End Sub


End Class
