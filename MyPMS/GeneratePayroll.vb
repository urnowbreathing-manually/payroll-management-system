Public Class GeneratePayroll
    Public Shared MainContentPanel As Panel
    Dim dbHandler As DBHandler

    ' mint green
    ' light green
    ' dark sea green

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub

    Private Sub GeneratePayroll_Load(sender As Object, e As EventArgs) Handles Me.Load
        DBHandler = New DBHandler()

        AddHandler txtbxEmployeeName.KeyPress, AddressOf HandleLettersOnly
        dbHandler.RetrieveAllEmployeeData(DGV_EmployeeList)
    End Sub

End Class
