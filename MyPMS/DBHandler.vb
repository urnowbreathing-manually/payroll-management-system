
Imports MySql.Data.MySqlClient

''﻿Imports MySql.Data.MySqlClient

Public Class DBHandler
    ' This class will eventually contain all mysql functions
    Public Shared currentUser() As String = {"", "", "", "", "", "", "", "", ""}


    ' denina connection string dont remove
    Private ConnectionString As String = "server=localhost;user=root;database=MyPMS;port=3306;password=washer22456;"
    'Private ConnectionString As String = "server=localhost;user=root;database=MyPMS;port=3306;password=;"



    Private conn As MySqlConnection
    Public Sub New()
        conn = New MySqlConnection(ConnectionString)
    End Sub



    ' for GeneratePayroll Form to retrieve all employee data
    Public Function RetrieveAllEmployeeData(dgv As DataGridView)
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM employees"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        dgv.DataSource = dt
                    Else
                        Console.WriteLine("No records found.")
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            Console.WriteLine("Error retrieving data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function



    ' Method to authenticate user (unchanged)
    Public Function AuthenticateUser(EmployeeID As String, Password As String) As Boolean
        Dim sql As String = "SELECT ID, Employee_Name, Employee_ID, Password, Role, Status, TIME_FORMAT(TimeIn, '%h:%i %p'), TIME_FORMAT(TimeOut, '%h:%i %p'), Salary FROM EmployeeTable WHERE Employee_ID = @EmployeeID AND Password = @Password"
        Dim authenticated As Boolean = False

        Try
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID)
                cmd.Parameters.AddWithValue("@password", Password)

                Using dReader As MySqlDataReader = cmd.ExecuteReader()
                    If dReader.Read() Then
                        authenticated = True
                        currentUser = {
                                        dReader("ID").ToString(), dReader("Employee_Name").ToString(), EmployeeID, Password,
                                        dReader("Role").ToString(), dReader("Status").ToString(), dReader("TIME_FORMAT(TimeIn, '%h:%i %p')").ToString(),
                                        dReader("TIME_FORMAT(TimeOut, '%h:%i %p')").ToString(), dReader("Salary").ToString()
                                    }
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return authenticated
    End Function
    'Public Function AuthenticateUser(ByVal employeeID As String, ByVal password As String)
    '    Dim authenticated As Boolean = False

    '    For i As Integer = 0 To personnelTable.GetLength(0) - 1
    '        If (personnelTable(i, 2) = employeeID) And (personnelTable(i, 3) = password) Then
    '            For j As Integer = 0 To currentUser.GetLength(0) - 1
    '                currentUser(j) = personnelTable(i, j)
    '            Next
    '            authenticated = True
    '            Return authenticated
    '        End If
    '    Next

    '    Return authenticated
    'End Function

End Class
