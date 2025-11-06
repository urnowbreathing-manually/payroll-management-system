
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



    '======== denina part start (forms: generate payroll, view payroll record, employee list) ========

    ' hands off
    Public Function RetrieveDepartments(cmb As ComboBox) As Boolean
        Try
            conn.Open()

            'Dim query As String = "SELECT Employee_ID , Name, Department, TotalOfHours, Overtime, Paid, Salary FROM employee_list"
            Dim query As String = "SELECT * FROM department_types"
            Dim conditions As New List(Of String)
            Dim cmd As New MySqlCommand(query, conn)

            Dim Reader = cmd.ExecuteReader

            While Reader.Read()
                'If Not IsDBNull(Reader("name")) Then cmb.Items.Add(Reader("name"))
                cmb.Items.Add(Reader("name"))
            End While

            Return True

        Catch ex As MySqlException
            Console.WriteLine("Error retrieving departments: " & ex.Message)
            Return False

        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function
    Public Function GetNewIDValue() As Integer
        Try
            conn.Open()

            Dim query As String = "SELECT MAX(ID) AS `MAX` FROM employee_list"
            Dim conditions As New List(Of String)
            Dim cmd As New MySqlCommand(query, conn)
            Dim maxId = 0

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    If Not reader.IsDBNull(0) Then
                        maxId = reader.GetInt32(0)
                    End If
                End If
            End Using

            Return maxId

        Catch ex As MySqlException
            Console.WriteLine("Error retrieving new ID: " & ex.Message)
            Return False

        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function


    ' for GeneratePayroll Form to retrieve all employee data
    Public Function RetrieveAllEmployeeData(dgv As DataGridView, Optional filterStr As String = "", Optional filterField As String = "", Optional paidField As Boolean? = Nothing) As Boolean
        Try
            dgv.DataSource = Nothing
            conn.Open()

            'Dim query As String = "SELECT Employee_ID , Name, Department, TotalOfHours, Overtime, Paid, Salary FROM employee_list"
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
                'dgv.Columns.Remove("Paid")
            End Using

            Return True

        Catch ex As MySqlException
            Console.WriteLine("Error retrieving data: " & ex.Message)
            Return False

        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function
    Public Function RetrieveAllArchiveEmployeeData(dgv As DataGridView, Optional filterStr As String = "", Optional filterField As String = "", Optional paidField As Boolean? = Nothing) As Boolean
        Try
            dgv.DataSource = Nothing
            conn.Open()

            'Dim query As String = "SELECT Employee_ID , Name, Department, TotalOfHours, Overtime, Paid, Salary FROM employee_list"
            Dim query As String = "SELECT * FROM employee_archive"
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
                'dgv.Columns.Remove("Paid")
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
    Public Sub LoadPayrollData(dgv As DataGridView, Optional name As String = "", Optional department As String = "", Optional salary As String = "")
        Dim query As String = " SELECT * FROM payroll_record"

        Dim range() As String
        Dim range1 As Decimal = 0
        Dim range2 As Decimal = 0

        If Not String.IsNullOrEmpty(department) Then
            query &= " WHERE department = @dept"
        ElseIf Not String.IsNullOrEmpty(name) Then
            query &= " WHERE name like @name"
        ElseIf Not String.IsNullOrEmpty(salary) Then
            range = salary.Split("-"c)

            For i As Integer = 0 To range.Length - 1
                range(i) = range(i).Trim()
            Next

            If salary.Contains("Above") Then
                range1 = Convert.ToDecimal(range(0))
                range2 = 500000D
            Else
                range1 = Convert.ToDecimal(range(0))
                range2 = Convert.ToDecimal(range(1))
            End If

            query &= " WHERE gross_salary between @range1 and @range2"
        End If

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)

                If Not String.IsNullOrEmpty(department) Then
                    cmd.Parameters.AddWithValue("@dept", department)
                ElseIf Not String.IsNullOrEmpty(name) Then
                    cmd.Parameters.AddWithValue("@name", "%" & name & "%")
                ElseIf Not String.IsNullOrEmpty(salary) Then
                    cmd.Parameters.AddWithValue("@range1", range1)
                    cmd.Parameters.AddWithValue("@range2", range2)
                End If


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
    Public Sub AddPayrollRecord(ByVal emplID As String, ByVal name As String, ByVal grossSalary As Double, ByVal sss As Double, ByVal philhealth As Double, ByVal pagibig As Double, ByVal netSalary As Double, ByVal department As String, ByVal path As String, ByVal total_hour As String, ByVal overtime As String)
        Dim query As String = "INSERT INTO payroll_record (date_time, name, employee_id, department, gross_salary, sss, philhealth, pagibig, net_salary, receipt_path, total_hour, overtime) VALUES (@date_time, @name, @employee_id, @department, @gross_salary, @sss, @philhealth, @pagibig, @net_salary, @path, @th, @ov);"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@date_time", DateTime.Now)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@employee_id", emplID)
                cmd.Parameters.AddWithValue("@department", department)
                cmd.Parameters.AddWithValue("@gross_salary", grossSalary)
                cmd.Parameters.AddWithValue("@sss", sss)
                cmd.Parameters.AddWithValue("@philhealth", philhealth)
                cmd.Parameters.AddWithValue("@pagibig", pagibig)
                cmd.Parameters.AddWithValue("@net_salary", netSalary)
                cmd.Parameters.AddWithValue("@path", path)
                cmd.Parameters.AddWithValue("@th", total_hour)
                cmd.Parameters.AddWithValue("@ov", overtime)


                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Payroll record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error adding payroll record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub



    ' for reports form
    Public Function GetTotalNetSalary(dgv As DataGridView, Optional filter As Integer = -1) As Decimal
        Dim total As Decimal = 0D
        Dim query As String = "SELECT SUM(net_salary) AS total_net_salary FROM payroll_record;"

        If filter = 1 Then
            query = "SELECT SUM(net_salary) AS total_net_salary FROM payroll_record;"
        ElseIf filter = 2 Then
            ' total net sal per dept
            query = "SELECT Department, SUM(net_salary) AS total_net_salary FROM payroll_record GROUP BY Department;"
        ElseIf filter = 3 Then
            ' total hours per dept
            query = "SELECT Department, sum(total_hours) as total_hour FROM mypms.payroll_record GROUP BY Department;"
        ElseIf filter = 4 Then
            ' total overtime per dept
            query = "SELECT Department, sum(overtime) as overtime FROM mypms.payroll_record GROUP BY Department;"
        End If

        Try
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                'If perDept = False Then
                Dim result = cmd.ExecuteScalar()
                'If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                '    total = Convert.ToDecimal(result)
                'Else
                '    total = 0D
                'End If
                'Else
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgv.DataSource = dt
                'End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database error retrieving total net salary: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return total
    End Function


    'for employee list form
    Public Function AddNewEmployee(Employee_ID As Integer,
                                   Name As String,
                                   Department As String,
                                   EmailAddress As String,
                                   BirthDate As Date,
                                   ContactNo As String,
                                   Salary As Decimal,
                                   HireDate As Date) As Boolean
        Dim query As String = "INSERT INTO employee_list (Employee_ID, Name, Department, EmailAddress, BirthDate, ContactNo, Salary, HireDate) " &
                              "VALUES (@Employee_ID, @Name, @Department, @EmailAddress, @BirthDate, @ContactNo, @Salary, @HireDate);"

        Try
            Using conn As New MySqlConnection(ConnectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Employee_ID", Employee_ID)
                    cmd.Parameters.AddWithValue("@Name", Name)
                    cmd.Parameters.AddWithValue("@Department", Department)
                    cmd.Parameters.AddWithValue("@EmailAddress", EmailAddress)
                    cmd.Parameters.AddWithValue("@BirthDate", BirthDate)
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNo)
                    cmd.Parameters.AddWithValue("@Salary", Salary)
                    cmd.Parameters.AddWithValue("@HireDate", HireDate)

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    Return rowsAffected > 0
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
            Return False
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function UpdateEmployee(Employee_ID As String,
                                   Name As String,
                                   Department As String,
                                   EmailAddress As String,
                                   BirthDate As Date,
                                   ContactNo As String,
                                   Salary As Decimal,
                                   HireDate As Date) As Boolean

        Dim query As String = "UPDATE employee_list SET " &
                              "Name = @Name, " &
                              "Department = @Department, " &
                              "EmailAddress = @EmailAddress, " &
                              "BirthDate = @BirthDate, " &
                              "ContactNo = @ContactNo, " &
                              "Salary = @Salary, " &
                              "HireDate = @HireDate " &
                              "WHERE Employee_ID = @Employee_ID;"

        Try
            Using conn As New MySqlConnection(ConnectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Employee_ID", Employee_ID)
                    cmd.Parameters.AddWithValue("@Name", Name)
                    cmd.Parameters.AddWithValue("@Department", Department)
                    cmd.Parameters.AddWithValue("@EmailAddress", EmailAddress)
                    cmd.Parameters.AddWithValue("@BirthDate", BirthDate)
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNo)
                    cmd.Parameters.AddWithValue("@Salary", Salary)
                    cmd.Parameters.AddWithValue("@HireDate", HireDate)

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    Return rowsAffected > 0
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
            Return False
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function MoveEmployeeToArchive(Employee_ID As String) As Boolean
        Dim insertQuery As String = "INSERT INTO employee_archive (Employee_ID, Name, Department, EmailAddress, BirthDate, ContactNo, Salary, HireDate) " &
                                    "SELECT Employee_ID, Name, Department, EmailAddress, BirthDate, ContactNo, Salary, HireDate " &
                                    "FROM employee_list WHERE Employee_ID = @Employee_ID;"

        Dim deleteQuery As String = "DELETE FROM employee_list WHERE Employee_ID = @Employee_ID;"

        Try
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()

                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Using insertCmd As New MySqlCommand(insertQuery, conn, transaction)
                        insertCmd.Parameters.AddWithValue("@Employee_ID", Employee_ID)
                        Dim insertedRows As Integer = insertCmd.ExecuteNonQuery()

                        If insertedRows = 0 Then
                            transaction.Rollback()
                            Return False
                        End If
                    End Using

                    Using deleteCmd As New MySqlCommand(deleteQuery, conn, transaction)
                        deleteCmd.Parameters.AddWithValue("@Employee_ID", Employee_ID)
                        deleteCmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                    Return True
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
            Return False
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    ' ======== denina part end (forms: generate payroll, view payroll record, employee list) ========








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
