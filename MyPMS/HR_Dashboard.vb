Imports System.Data
Public Class HR_Dashboard
    Inherits UserControl

    Private db As New DBHandler()
    Private allStats As New List(Of StatsData)

    Private Class StatsData
        Public Property EmployeeName As String
        Public Property EmployeeID As String
        Public Property Role As String
        Public Property Status As String
        Public Property TimeIn As String
        Public Property TimeOut As String
        Public Property Salary As Decimal
    End Class

    Public Sub New(Parent As Panel)
        InitializeComponent()
    End Sub

    Private Sub HR_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Welcome Message retrieved from user info upon loggin in
        Lbl_WelcomeMsg.Text = "Welcome, " + DBHandler.currentUser(1) + " - " + DBHandler.currentUser(4)


        Load_HRDB_Stats()
    End Sub

    Private Sub Load_HRDB_Stats()
        Try
            Pnl_Stats2.Controls.Clear()
            allStats.Clear()

            Dim dt As DataTable = db.Get_HRDB_Stats()

            Lbl_TotalEmp_Dynamic.Text = dt.Rows.Count.ToString

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                Pnl_Stats2.Controls.Add(New Label() With {.Text = "No appointments found.", .Font = New Font("Segoe UI", 12), .AutoSize = True})
                Return
            End If
            For Each row As DataRow In dt.Rows
                Dim app As New StatsData With {
                    .EmployeeName = row.Field(Of String)("EmployeeName"),
                    .EmployeeID = row.Field(Of String)("EmployeeID"),
                    .Role = row.Field(Of String)("Role"),
                    .Status = row.Field(Of String)("Status"),
                    .TimeIn = Integer.Parse(row.Field(Of String)("TimeIn").Replace(",", "")).ToString("00:00:00"),
                    .TimeOut = Integer.Parse(row.Field(Of String)("TimeOut").Replace(",", "")).ToString("00:00:00"),
                    .Salary = row.Field(Of Decimal)("Salary")
                }
                allStats.Add(app)
            Next

            Lbl_PayrollTM_Dynamic.Text = Decimal.Parse(dt.Compute("Sum(Salary)", Nothing)).ToString("F2")
            Lbl_PayrollTM_Dynamic.Text = "Php " + Lbl_PayrollTM_Dynamic.Text
            Lbl_PayrollTM_Dynamic.Location = New Point(((Panel4.Width / 2) - (Lbl_PayrollTM_Dynamic.Width / 2)), Lbl_PayrollTM_Dynamic.Location.Y)

            DisplayStats(allStats.ToList())
        Catch ex As Exception
            MessageBox.Show("Failed to load Dashboard Stats: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayStats(list As List(Of StatsData))
        Pnl_Stats2.Controls.Clear()
        If list.Count = 0 Then
            Pnl_Stats2.Controls.Add(New Label() With {.Text = "No matching appointments found.", .Font = New Font("Segoe UI", 11), .AutoSize = True})
            Return
        End If



        For Each a In list
            Dim instance As New HRDB_Attendance_Instance()
            instance.BackColor = Color.White
            instance.Name_Placeholder.Text = a.EmployeeName
            instance.TimeOut_Placeholder.Text = a.Status
            instance.Status_Placeholder.Text = a.TimeIn
            instance.TimeIn_Placeholder.Text = a.TimeOut

            Pnl_Stats2.Controls.Add(instance)
        Next
    End Sub



End Class
