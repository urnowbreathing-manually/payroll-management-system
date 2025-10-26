
Imports Guna.UI2.WinForms
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





    ' hands off
    ' for GeneratePayroll Form to retrieve all employee data
    Public Function RetrieveAllEmployeeData(dgv As DataGridView, Optional filterStr As String = "", Optional filterField As String = "", Optional paidField As Boolean? = Nothing) As Boolean
        Try
            conn.Open()

            Dim query As String = "SELECT * FROM employee_list"
            Dim conditions As New List(Of String)
            Dim cmd As New MySqlCommand()

            ' Filtering conditions
            If Not String.IsNullOrWhiteSpace(filterStr) Then
                If String.IsNullOrWhiteSpace(filterField) Then
                    conditions.Add("(Name LIKE @filter OR Employee_ID LIKE @filter)")
                    cmd.Parameters.AddWithValue("@filter", "%" & filterStr & "%")
                Else
                    conditions.Add(filterField & " = @filterstr")
                    cmd.Parameters.AddWithValue("@filterstr", filterStr)
                End If
            End If

            If paidField.HasValue Then
                conditions.Add("paid = @paid")
                cmd.Parameters.AddWithValue("@paid", paidField.Value)
            End If

            If conditions.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", conditions)
            End If

            cmd.CommandText = query
            cmd.Connection = conn

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                Dim dt As New DataTable()
                dt.Load(reader)
                dgv.DataSource = dt
            End Using

            Return True

        Catch ex As MySqlException
            Console.WriteLine("Error retrieving data: " & ex.Message)
            Return False

        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function
    Public Function RetrieveSSSContriTable(dgv As DataGridView, Optional filter As String = "")
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM sss_contri_table"
            If Not filter = "" Then
                'query &= " where @filter"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            If Not filter = "" Then

            End If

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    dgv.DataSource = dt
                Else
                    Console.WriteLine("No records found.")
                End If
            End Using
        Catch ex As MySqlException
            Console.WriteLine("Error retrieving data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function
    Public Function UpdatePaidField(ByVal employeeID As String)
        Dim query As String = "UPDATE employee_list SET paid = TRUE WHERE employee_id = @id"

        Try
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                ' Add parameter to prevent SQL injection
                cmd.Parameters.AddWithValue("@id", employeeID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Payment status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No record found with that ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            conn.Close()
        End Try
    End Function







    ' for view payroll record
    Public Sub LoadPayrollData(dgv As DataGridView)
        Dim query As String = " SELECT * FROM payroll_record"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgv.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading payroll data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Public Sub AddPayrollRecord(ByVal emplID As String, ByVal name As String, ByVal grossSalary As Double, ByVal sss As Double, ByVal philhealth As Double, ByVal pagibig As Double, ByVal netSalary As Double, ByVal path As String)
        Dim query As String = "INSERT INTO payroll_record  (date_time, name, employee_id, gross_salary, sss, philhealth, pagibig, net_salary, receipt_path) VALUES (@date_time, @name, @employee_id, @gross_salary, @sss, @philhealth, @pagibig, @net_salary, @path);"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@date_time", DateTime.Now)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@employee_id", emplID)
                cmd.Parameters.AddWithValue("@gross_salary", grossSalary)
                cmd.Parameters.AddWithValue("@sss", sss)
                cmd.Parameters.AddWithValue("@philhealth", philhealth)
                cmd.Parameters.AddWithValue("@pagibig", pagibig)
                cmd.Parameters.AddWithValue("@net_salary", netSalary)
                cmd.Parameters.AddWithValue("@path", path)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Payroll record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error adding payroll record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub







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
