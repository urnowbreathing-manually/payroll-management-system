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

End Class
