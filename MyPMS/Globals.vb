Module Globals

    Public TblPanel As New TableLayoutPanel

    ' panels for form
    'Public DashboardPanel As New Panel With {
    '   .Dock = DockStyle.Fill
    '}

    'Public GeneratePayrollPanel As New Panel With {
    '   .Dock = DockStyle.Fill
    '}

    'Public SuperMainPanel As New Panel With {
    '   .Dock = DockStyle.Fill
    '}


    Public Sub HandleLettersOnly(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub


    Public Sub HandleNumbersOnly(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Public Sub HandleNumbersAndPeriodOnly(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Asc(e.KeyChar) = 8 And Not Asc(e.KeyChar) = 46 Then
            e.Handled = True
        End If
    End Sub

End Module
