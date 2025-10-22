Public Class DBHandler
    'This class will eventually contain all mysql functions
    'For now, hardcoded arrays will be used as pseudodatabases

    Public Shared personnelTable(,) As String = {
                                                    {"0", "Danni G. German", "00001-HRA", "admin000", "HR Admin"},
                                                    {"1", "Hugh E. Jorgan", "00001-HRE", "hr123", "HR"},
                                                    {"3", "Moe E. Lester", "00002-HRE", "hr456", "HR"},
                                                    {"4", "Ayia V. Dickinson", "00001-EMP", "pass123", "Employee"},
                                                    {"5", "Ash H. Hölle", "00002-EMP", "pass456", "Employee"},
                                                    {"6", "Candice N. Üttzë", "00003-EMP", "pass789", "Employee"}
                                                }

    Public Shared currentUser() As String = {"", "", "", "", ""}

    Public Function AuthenticateUser(ByVal employeeID As String, ByVal password As String)
        Dim authenticated As Boolean = False

        For i As Integer = 0 To DBHandler.personnelTable.GetLength(0) - 1
            If (DBHandler.personnelTable(i, 2) = employeeID) And (DBHandler.personnelTable(i, 3) = password) Then
                authenticated = True
                Return authenticated
            End If
        Next

        Return authenticated
    End Function

End Class
