Imports System.Runtime.InteropServices

Public Class ViewPayrollRecord
    Public Shared MainContentPanel As Panel
    Dim handler As New DBHandler()

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub

    Private Sub ViewPayrollRecord_Load(sender As Object, e As EventArgs) Handles Me.Load

        handler.RetrieveAllEmployeeData(DataGridView1)
        MessageBox.Show("Rows in datagridview1: " & DataGridView1.Rows.Count.ToString())
        PopulateEmployeeFlowPanel(DataGridView1, FlowLayoutPanel1, "View")

    End Sub

    'Public Function CreateEmployeeTable(dgv As DataGridView) As TableLayoutPanel
    '    Dim employeeTable As New TableLayoutPanel

    '    employeeTable.ColumnCount = 7
    '    employeeTable.RowCount = 1
    '    employeeTable.BackColor = Color.Red
    '    employeeTable.Width = FlowLayoutPanel1.Width

    '    Dim index As Integer = 0
    '    For Each row As DataGridViewRow In testtable.Rows

    '        Dim emplID As New Label
    '        emplID.Text = row.Cells(0).Value.ToString
    '        emplID.TextAlign = ContentAlignment.MiddleCenter
    '        emplID.Dock = DockStyle.Fill
    '        emplID.ForeColor = Color.White

    '        Dim emplName As New Label
    '        emplName.Text = row.Cells(1).Value.ToString
    '        emplName.TextAlign = ContentAlignment.MiddleCenter
    '        emplName.Dock = DockStyle.Fill
    '        emplName.ForeColor = Color.White

    '        Dim emplDept As New Label
    '        emplDept.Text = row.Cells(1).Value.ToString
    '        emplDept.TextAlign = ContentAlignment.MiddleCenter
    '        emplDept.Dock = DockStyle.Fill
    '        emplDept.ForeColor = Color.White

    '        Dim emplSalary As New Label
    '        emplSalary.Text = row.Cells(1).Value.ToString
    '        emplSalary.TextAlign = ContentAlignment.MiddleCenter
    '        emplSalary.Dock = DockStyle.Fill
    '        emplSalary.ForeColor = Color.White

    '        Dim emplHours As New Label
    '        emplHours.Text = row.Cells(1).Value.ToString
    '        emplHours.TextAlign = ContentAlignment.MiddleCenter
    '        emplHours.Dock = DockStyle.Fill
    '        emplHours.ForeColor = Color.White

    '        Dim emplName As New Label
    '        emplName.Text = row.Cells(1).Value.ToString
    '        emplName.TextAlign = ContentAlignment.MiddleCenter
    '        emplName.Dock = DockStyle.Fill
    '        emplName.ForeColor = Color.White


    '        employeeTable.Controls.Add(emplID, 1, 0)
    '        employeeTable.Controls.Add(employeeLabel, 2, 0)
    '        employeeTable.Controls.Add(employeeLabel, 3, 0)
    '        employeeTable.Controls.Add(employeeLabel, 4, 0)
    '        employeeTable.Controls.Add(employeeLabel, 5, 0)
    '        employeeTable.Controls.Add(employeeLabel, 6, 0)
    '        employeeTable.Controls.Add(employeeLabel, 7, 0)
    '    Next

    '    Return employeeTable
    'End Function

End Class
