Imports MySql.Data.MySqlClient

Public Class Reports_UC
    Dim db As New DBHandler
    Dim MainContentPanel As New Panel

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub
    Private Sub Reports_UC_Load(sender As Object, e As EventArgs) Handles Me.Load
        db.RetrieveAllEmployeeData(dgvEmployeeList)
        db.LoadPayrollData(dgvPayrollRecord)
        db.GetTotalNetSalary(dgvTotalPerDept, 2)
        db.GetTotalNetSalary(dgvTotalHoursPerDept, 3)
        db.GetTotalNetSalary(dgvTotalOvertimePerDept, 4)

        LoadTotalNetSalaryPerDept()
        LoadTotalHoursPerDept()
        LoadTotalOvertimePerDept()
    End Sub


    Private Sub LoadTotalNetSalaryPerDept()
        Chart1.Series.Clear()
        Chart1.Titles.Clear()

        Dim salesSeries As New System.Windows.Forms.DataVisualization.Charting.Series("Payroll each department")
        salesSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column

        If dgvTotalPerDept Is Nothing Then
            MessageBox.Show("dgvTotalPerDept is not initialized!")
            MessageBox.Show("dgvTotalPerDept row count: " & dgvTotalPerDept.RowCount.ToString)
            Return
        Else
            For Each r As DataGridViewRow In dgvTotalPerDept.Rows
                If r.IsNewRow Then Continue For
                If r.Cells(0).Value Is Nothing OrElse r.Cells(1).Value Is Nothing Then Continue For

                Dim dept As String = r.Cells(0).Value.ToString()
                Dim totalSalary As Decimal
                If Decimal.TryParse(r.Cells(1).Value.ToString(), totalSalary) Then
                    salesSeries.Points.AddXY(dept, totalSalary)
                End If
            Next

        End If

        Chart1.Series.Add(salesSeries)
        Chart1.Titles.Clear()
        Chart1.Titles.Add("Total of Net Salary per department")
    End Sub
    Private Sub LoadTotalHoursPerDept()
        Chart2.Series.Clear()
        Chart2.Titles.Clear()

        Dim pieSeries As New System.Windows.Forms.DataVisualization.Charting.Series("Total of Hours per Department")
        pieSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        pieSeries.IsValueShownAsLabel = True
        pieSeries.LabelFormat = "#,##0.##"
        pieSeries.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Chart2.Legends.Clear()
        Chart2.Legends.Add("Legend")
        Chart2.Legends(0).Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right

        If dgvTotalHoursPerDept Is Nothing Then
            MessageBox.Show("dgvTotalHoursPerDept is not initialized!")
            Return
        End If

        For Each r As DataGridViewRow In dgvTotalHoursPerDept.Rows
            If r.IsNewRow Then Continue For
            If r.Cells(0).Value Is Nothing OrElse r.Cells(1).Value Is Nothing Then Continue For

            Dim dept As String = r.Cells(0).Value.ToString()
            Dim totalHours As Decimal

            If Decimal.TryParse(r.Cells(1).Value.ToString(), totalHours) Then
                pieSeries.Points.AddXY(dept, totalHours)
            End If
        Next

        Chart2.Series.Add(pieSeries)
        Chart2.Titles.Add("Total of Hours per Department")

        'Chart2.ChartAreas(0).Area3DStyle.Enable3D = True
        'Chart2.ChartAreas(0).Area3DStyle.Inclination = 40
        'Chart2.ChartAreas(0).Area3DStyle.Rotation = 25
    End Sub
    Private Sub LoadTotalOvertimePerDept()
        Chart3.Series.Clear()
        Chart3.Titles.Clear()

        Dim salesSeries As New System.Windows.Forms.DataVisualization.Charting.Series("Total of Hours per department")
        salesSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column

        If dgvTotalOvertimePerDept Is Nothing Then
            MessageBox.Show("dgvTotalOvertimePerDept is not initialized!")
            MessageBox.Show("dgvTotalOvertimePerDept row count: " & dgvTotalOvertimePerDept.RowCount.ToString)
            Return
        Else
            For Each r As DataGridViewRow In dgvTotalOvertimePerDept.Rows
                If r.IsNewRow Then Continue For
                If r.Cells(0).Value Is Nothing OrElse r.Cells(1).Value Is Nothing Then Continue For

                Dim dept As String = r.Cells(0).Value.ToString()
                Dim totalSalary As Decimal
                If Decimal.TryParse(r.Cells(1).Value.ToString(), totalSalary) Then
                    salesSeries.Points.AddXY(dept, totalSalary)
                End If
            Next

        End If

        Chart3.Series.Add(salesSeries)
        Chart3.Titles.Clear()
        Chart3.Titles.Add("Total of Hours per department")
    End Sub


End Class
