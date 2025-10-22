Public Class HR_Dashboard
    Public Shared MainContentPanel As Panel
    Private dbHandler As DBHandler
    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
        DBHandler = New DBHandler()
    End Sub

    Private Sub HR_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_WelcomeMsg.Text = "Welcome, " + DBHandler.currentUser(1) + " - " + DBHandler.currentUser(4)
    End Sub
End Class
