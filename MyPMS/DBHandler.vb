
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
    Public Function RetrieveAllEmployeeData(dgv As DataGridView)
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM employee_list"
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
    Public Sub PopulateEmployeeFlowPanel(ByVal dgv As DataGridView, flp As FlowLayoutPanel)
        flp.Controls.Clear()

        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Dim pnl As New Panel()
                pnl.Width = flp.Width
                pnl.Height = 90
                pnl.Margin = New Padding(5)
                pnl.BackColor = Color.FromArgb(240, 248, 255)
                pnl.BorderStyle = BorderStyle.FixedSingle
                pnl.Padding = New Padding(10, 5, 10, 5)

                Dim layout As New TableLayoutPanel()
                layout.ColumnCount = 2
                layout.RowCount = 1
                layout.Dock = DockStyle.Fill
                layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))
                layout.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100))

                Dim tblRow As New TableLayoutPanel()
                tblRow.ColumnCount = 2
                tblRow.RowCount = 3
                tblRow.Dock = DockStyle.Fill
                tblRow.AutoSize = True
                tblRow.Padding = New Padding(0)
                tblRow.Margin = New Padding(0)

                Dim lblName As New Label()
                lblName.Text = row.Cells("Name").Value.ToString()
                lblName.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                lblName.AutoSize = True

                Dim lblEmpID As New Label()
                lblEmpID.Text = "Employee ID: " & row.Cells("Employee_ID").Value.ToString()
                lblEmpID.Font = New Font("Segoe UI", 10)
                lblEmpID.AutoSize = True

                Dim lblDept As New Label()
                lblDept.Text = "Department: " & row.Cells("Department").Value.ToString()
                lblDept.Font = New Font("Segoe UI", 10)
                lblDept.AutoSize = True

                Dim lblHours As New Label()
                lblHours.Text = "Hours: " & row.Cells("TotalOfHours").Value.ToString()
                lblHours.Font = New Font("Segoe UI", 10)
                lblHours.AutoSize = True

                Dim lblOvertime As New Label()
                lblOvertime.Text = "Overtime: " & row.Cells("Overtime").Value.ToString()
                lblOvertime.Font = New Font("Segoe UI", 10)
                lblOvertime.ForeColor = Color.DarkBlue
                lblOvertime.AutoSize = True

                Dim lblSalary As New Label()
                lblSalary.Text = "Salary: $" & Format(row.Cells("Salary").Value, "#,##0.00")
                lblSalary.Font = New Font("Segoe UI", 10)
                lblSalary.AutoSize = True

                tblRow.Controls.Add(lblName, 0, 0)
                tblRow.Controls.Add(lblEmpID, 0, 1)
                tblRow.Controls.Add(lblDept, 0, 2)
                tblRow.Controls.Add(lblHours, 1, 0)
                tblRow.Controls.Add(lblOvertime, 1, 1)
                tblRow.Controls.Add(lblSalary, 1, 2)

                Dim selectBtn As New Button()
                selectBtn.Text = "Select"
                selectBtn.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                selectBtn.FlatStyle = FlatStyle.Flat
                selectBtn.BackColor = Color.LightBlue
                selectBtn.Size = New Size(80, 30)
                selectBtn.Margin = New Padding(10, 25, 10, 25)
                selectBtn.Anchor = AnchorStyles.Right
                selectBtn.Cursor = Cursors.Hand
                AddHandler selectBtn.Click, Sub()
                                                MessageBox.Show(lblName.Text)
                                            End Sub

                layout.Controls.Add(tblRow, 0, 0)
                layout.Controls.Add(selectBtn, 1, 0)

                pnl.Controls.Add(layout)
                flp.Controls.Add(pnl)
            End If
        Next
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
