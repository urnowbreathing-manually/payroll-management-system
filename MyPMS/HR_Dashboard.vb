Public Class HR_Dashboard
    Public Shared MainContentPanel As Panel
    Private dbHandler As DBHandler
    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
        dbHandler = New DBHandler()
    End Sub

    Private Sub HR_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Welcome Message retrieved from user info upon loggin in
        Lbl_WelcomeMsg.Text = "Welcome, " + DBHandler.currentUser(1) + " - " + DBHandler.currentUser(4)

        ' Total number of employees, including HR
        'Lbl_TotalEmp_Dynamic.Text = dbHandler.personnelTable.GetLength(0).ToString

        'Dim totalEmployees As Integer = dbHandler.personnelTable.GetLength(0)
        'Dim ActiveEmployees As Integer = totalEmployees
        'For i As Integer = 0 To dbHandler.personnelTable.GetLength(0) - 1
        '    If dbHandler.personnelTable(i, 5) = "Inactive" Then
        '        ActiveEmployees -= 1
        '    End If
        'Next

        '' Number of currently active employees
        'Lbl_EmpCA_Dynamic.Text = ActiveEmployees

    End Sub


End Class
