Public Class GeneratePayroll
    Public Shared MainContentPanel As Panel

    ' mint green
    ' light green
    ' dark sea green

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub

    Private Sub GeneratePayroll_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler txtbxEmployeeName.KeyPress, AddressOf HandleLettersOnly
    End Sub

End Class
