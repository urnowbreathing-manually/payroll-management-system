Public Class GeneratePayroll
    Public Shared MainContentPanel As Panel

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub

    Private Sub GeneratePayroll_Load(sender As Object, e As EventArgs) Handles Me.Load
        'AddHandler EmployeeNameTxtBox.KeyPress, AddressOf HandleLettersOnly
        'AddHandler ContactNoTxtBox.KeyPress, AddressOf HandleNumbersOnly
    End Sub

End Class
