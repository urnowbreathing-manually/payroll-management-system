Public Class DBHandler
    ' This class will eventually contain all mysql functions
    ' For now, hardcoded arrays will be used as pseudodatabases

    Public Shared personnelTable(,) As String = {
                                                    {"0", "Danni G. German", "00001-HRA", "admin000", "HR Admin", "Active"},
                                                    {"1", "Hugh E. Jorgan", "00001-HRE", "hr123", "HR", "Active"},
                                                    {"2", "Moe E. Lester", "00002-HRE", "hr456", "HR", "Inactive"},
                                                    {"3", "Ayia V. Dickinson", "00001-EMP", "pass123", "Employee", "Inactive"},
                                                    {"4", "Ash H. Hölle", "00002-EMP", "pass456", "Employee", "Active"},
                                                    {"5", "Candice N. Üttzë", "00003-EMP", "pass789", "Employee", "Active"}
                                                }

    Public Shared currentUser() As String = {"", "", "", "", ""}

    Public Function AuthenticateUser(ByVal employeeID As String, ByVal password As String)
        Dim authenticated As Boolean = False

        For i As Integer = 0 To personnelTable.GetLength(0) - 1
            If (personnelTable(i, 2) = employeeID) And (personnelTable(i, 3) = password) Then
                For j As Integer = 0 To currentUser.GetLength(0) - 1
                    currentUser(j) = personnelTable(i, j)
                Next
                authenticated = True
                Return authenticated
            End If
        Next

        Return authenticated
    End Function

End Class
