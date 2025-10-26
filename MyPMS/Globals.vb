Module Globals

    Public Pnl_HR_Dashboard As New Panel With {
       .Location = New Point(0, 50),
       .Margin = New Padding(0, 0, 0, 0),
       .Padding = New Padding(0, 0, 0, 0),
       .Size = New Size(850, 570),
       .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right,
       .BackColor = Color.Transparent,
       .BorderStyle = BorderStyle.None
    }

    Public Pnl_GeneratePayroll As New Panel With {
       .Location = New Point(0, 50),
       .Margin = New Padding(0, 0, 0, 0),
       .Padding = New Padding(0, 0, 0, 0),
       .Size = New Size(850, 570),
       .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right,
       .BackColor = Color.Transparent,
       .BorderStyle = BorderStyle.None
    }

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
