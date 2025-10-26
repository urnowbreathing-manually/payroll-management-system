Imports System.Drawing.Text
Imports System.IO
Imports System.Web.UI.Design
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports TheArtOfDevHtmlRenderer.Adapters
' mint green
' light green
' dark sea green
Public Class GeneratePayroll
    Public Shared MainContentPanel As Panel
    Dim dbHandler As DBHandler
    Dim SSSContriTable As New DataGridView

    'functions & form events
    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub
    Private Sub GeneratePayroll_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbHandler = New DBHandler()

        AddHandler txtbxSSS.KeyPress, AddressOf HandleNumbersOnly
        AddHandler txtbxPhilHealth.KeyPress, AddressOf HandleNumbersOnly
        AddHandler txtbxPagIBIG.KeyPress, AddressOf HandleNumbersOnly

        dbHandler.RetrieveAllEmployeeData(DGV_EmployeeList, "", "", 0)
        PopulateEmployeeFlowPanel(DGV_EmployeeList, FlowLayoutPanel1)
        dbHandler.RetrieveSSSContriTable(SSSContriTable)

        ' to get count for the shits in the right
        Dim dgvForCount As New DataGridView
        dbHandler.RetrieveAllEmployeeData(dgvForCount)

        Dim paidCount As Integer = 0
        Dim notPaidCount As Integer = 0
        For Each row As DataGridViewRow In dgvForCount.Rows
            If Not row.IsNewRow Then
                If row.Cells(7).Value = 1 Then
                    paidCount += 1
                ElseIf row.Cells(7).Value = 0 Then
                    notPaidCount += 1
                End If
            End If
        Next

        lblTotalPayroll.Text = paidCount.ToString
        lblPendingPayroll.Text = notPaidCount.ToString

    End Sub
    Public Sub PopulateEmployeeFlowPanel(ByVal dgv As DataGridView, flp As FlowLayoutPanel)
        flp.Controls.Clear()

        If dgv.RowCount < 1 Then
            Dim lblNoFound As New Label()
            lblNoFound.Text = "No employee found"
            lblNoFound.Font = New Font("Segoe UI", 12, FontStyle.Italic)
            lblNoFound.AutoSize = True

            flp.Controls.Add(lblNoFound)
            Return
        End If
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Dim pnl As New Guna2Panel()
                pnl.Width = flp.Width
                pnl.Height = 90
                pnl.Margin = New Padding(5)
                pnl.FillColor = Color.FromArgb(240, 248, 255)
                pnl.BorderStyle = BorderStyle.FixedSingle
                pnl.Padding = New Padding(10, 5, 10, 5)
                pnl.BorderRadius = 10

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
                                                'MessageBox.Show(lblName.Text)
                                                txtbxEmployeeID.Text = lblEmpID.Text.Replace("Employee ID: ", "")
                                                txtbxEmployeeName.Text = lblName.Text
                                                txtbxDepartment.Text = lblDept.Text.Replace("Department: ", "")
                                                txtbxTotalHours.Text = lblHours.Text
                                                txtbxOverTime.Text = lblOvertime.Text
                                                txtbxGrossSalary.Text = lblSalary.Text.Replace("Salary: $", "")
                                                txtbxNetSalary.Text = CalculateNetSalary().ToString()

                                                txtbxSSS.Text = "0"
                                                txtbxPhilHealth.Text = "0"
                                                txtbxPagIBIG.Text = "0"
                                            End Sub

                layout.Controls.Add(tblRow, 0, 0)
                layout.Controls.Add(selectBtn, 1, 0)

                pnl.Controls.Add(layout)
                flp.Controls.Add(pnl)

            End If
        Next

    End Sub
    Private Function CalculateNetSalary()
        Dim sss As Double = 0
        Dim philhealth As Double = 0
        Dim pagIbig As Double = 0
        Dim grossSalary As Double = 0

        If Not String.IsNullOrEmpty(txtbxSSS.Text) Then
            If Not Double.TryParse(txtbxSSS.Text, sss) Then
                MsgBox("Failed to parse SSS value", MsgBoxStyle.Critical, "Error")
            End If
        End If
        If Not String.IsNullOrEmpty(txtbxPhilHealth.Text) Then
            If Not Double.TryParse(txtbxPhilHealth.Text, philhealth) Then
                MsgBox("Failed to parse phil health value", MsgBoxStyle.Critical, "Error")
            End If
        End If
        If Not String.IsNullOrEmpty(txtbxPagIBIG.Text) Then
            If Not Double.TryParse(txtbxPagIBIG.Text, pagIbig) Then
                MsgBox("Failed to parse pagibig value", MsgBoxStyle.Critical, "Error")
            End If
        End If
        If Not String.IsNullOrEmpty(txtbxGrossSalary.Text) Then
            If Not Double.TryParse(txtbxGrossSalary.Text, grossSalary) Then
                MsgBox("Failed to parse gross salary value", MsgBoxStyle.Critical, "Error")
            End If
        End If
        'txtbxNetSalary.Text = (grossSalary - (sss + philhealth + pagIbig)).ToString

        Return (grossSalary - (sss + philhealth + pagIbig))
    End Function







    ' create pdf function
    Private Function CreateReceiptPDF() As String
        Dim receipt As New PdfDocument()
        Dim page As PdfPage = receipt.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)

        Dim titleFont As New XFont("Arial", 16, XFontStyle.Bold)
        Dim regFont As New XFont("Arial", 12)
        Dim boldFont As New XFont("Arial", 12, XFontStyle.Bold)
        Dim textBrush As XBrush = XBrushes.Black

        Dim currentDate As String = Date.Now.ToString("MMMM dd, yyyy hh:mm tt")

        Dim contents As New Dictionary(Of String, String)
        For Each ctrl As Control In pnlPayrollForm.Controls
            If TypeOf ctrl Is Guna2TextBox AndAlso Not String.IsNullOrEmpty(ctrl.Text) Then
                contents(ctrl.Name) = CType(ctrl, Guna2TextBox).Text
            End If
        Next

        Dim marginLeft As Integer = 50
        Dim posY As Integer = 100
        Dim lineHeight As Integer = 20

        gfx.DrawString("Payroll Receipt", titleFont, textBrush, New XRect(marginLeft, posY, page.Width, 40), XStringFormats.TopLeft)
        posY += lineHeight * 2

        gfx.DrawString($"Date: {currentDate}", regFont, textBrush, New XRect(marginLeft, posY, page.Width, 20), XStringFormats.TopLeft)
        posY += lineHeight * 2

        DrawField(gfx, "Employee Name", GetSafeText(contents, "txtbxEmployeeName"), regFont, boldFont, textBrush, marginLeft, posY)
        DrawField(gfx, "Employee ID", GetSafeText(contents, "txtbxEmployeeID"), regFont, boldFont, textBrush, marginLeft, posY)
        DrawField(gfx, "Department", GetSafeText(contents, "txtbxDepartment"), regFont, boldFont, textBrush, marginLeft, posY)
        DrawField(gfx, "Total Hours", GetSafeText(contents, "txtbxTotalHours"), regFont, boldFont, textBrush, marginLeft, posY)
        DrawField(gfx, "Overtime", GetSafeText(contents, "txtbxOverTime"), regFont, boldFont, textBrush, marginLeft, posY)
        DrawField(gfx, "Gross Salary", "₱" & GetSafeText(contents, "txtbxGrossSalary"), regFont, boldFont, textBrush, marginLeft, posY)
        DrawField(gfx, "SSS", "₱" & GetSafeText(contents, "txtbxSSS"), regFont, boldFont, textBrush, marginLeft, posY)
        DrawField(gfx, "PhilHealth", "₱" & GetSafeText(contents, "txtbxPhilHealth"), regFont, boldFont, textBrush, marginLeft, posY)
        DrawField(gfx, "Pag-IBIG", "₱" & GetSafeText(contents, "txtbxPagIBIG"), regFont, boldFont, textBrush, marginLeft, posY)
        DrawField(gfx, "Net Salary", "₱" & GetSafeText(contents, "txtbxNetSalary"), regFont, boldFont, textBrush, marginLeft, posY)

        Dim documentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\MyPMS_Receipts\" & txtbxEmployeeID.Text
        If Not Directory.Exists(documentsPath) Then
            Directory.CreateDirectory(documentsPath)
        End If

        Dim filename As String = $"{Date.Now:yyyyMMdd_HHmmss}_{txtbxEmployeeID.Text}.pdf"
        Dim receiptPath As String = Path.Combine(documentsPath, filename)

        MsgBox(receiptPath)

        Try
            receipt.Save(receiptPath)
            MessageBox.Show($"A receipt has been created at: {receiptPath}", "Receipt Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return receiptPath
        Catch ex As Exception
            MessageBox.Show("Failed to save receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    Private Function GetSafeText(contents As Dictionary(Of String, String), key As String) As String
        If contents.ContainsKey(key) Then
            Return contents(key)
        End If
        Return ""
    End Function
    Private Sub DrawField(gfx As XGraphics, label As String, value As String, regFont As XFont, boldFont As XFont, brush As XBrush, ByRef x As Integer, ByRef y As Integer)
        gfx.DrawString($"{label}:", boldFont, brush, New XRect(x, y, 200, 20), XStringFormats.TopLeft)
        gfx.DrawString(value, regFont, brush, New XRect(x + 150, y, 300, 20), XStringFormats.TopLeft)
        y += 20
    End Sub







    ' controls handlers
    Private Sub SearchEmployee_Button(sender As Object, e As EventArgs) Handles btnSearchEmployee.Click
        If String.IsNullOrEmpty(txtbxSearchEmployee.Text) Then
            Return
        End If

        FlowLayoutPanel1.Controls.Clear()
        DGV_EmployeeList.DataSource = Nothing

        dbHandler.RetrieveAllEmployeeData(DGV_EmployeeList, txtbxSearchEmployee.Text, "", 0)
        PopulateEmployeeFlowPanel(DGV_EmployeeList, FlowLayoutPanel1)

    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If String.IsNullOrEmpty(txtbxEmployeeID.Text) Or txtbxEmployeeID.Text = "" Then
            Return
        End If

        For Each txtbx As Guna2TextBox In pnlPayrollForm.Controls
            txtbx.Text = ""
        Next
    End Sub
    Private Sub GeneratePayroll_Click(sender As Object, e As EventArgs) Handles btnGeneratePayroll.Click
        If String.IsNullOrEmpty(txtbxEmployeeID.Text) Or txtbxEmployeeID.Text = "" Then
            Return
        End If

        txtbxNetSalary.Text = CalculateNetSalary().ToString
        Dim resultPath As String = CreateReceiptPDF()
        If Not String.IsNullOrEmpty(resultPath) Then
            dbHandler.UpdatePaidField(txtbxEmployeeID.Text)
            dbHandler.AddPayrollRecord(txtbxEmployeeID.Text, txtbxEmployeeName.Text, txtbxGrossSalary.Text, txtbxSSS.Text, txtbxPhilHealth.Text, txtbxPagIBIG.Text, txtbxNetSalary.Text, resultPath)
        End If
    End Sub
    Private Sub FilterByDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxFilterByDept.SelectedIndexChanged
        If String.IsNullOrEmpty(cmbbxFilterByDept.Text) Then
            Return
        End If

        FlowLayoutPanel1.Controls.Clear()
        DGV_EmployeeList.DataSource = Nothing

        dbHandler.RetrieveAllEmployeeData(DGV_EmployeeList, cmbbxFilterByDept.Text.Replace(" ", "_"), "department", 0)
        PopulateEmployeeFlowPanel(DGV_EmployeeList, FlowLayoutPanel1)
    End Sub
    Private Sub HandleTextChange(sender As Object, e As EventArgs) Handles txtbxSSS.TextChanged, txtbxPhilHealth.TextChanged, txtbxPagIBIG.TextChanged
        txtbxNetSalary.Text = CalculateNetSalary().ToString
    End Sub

End Class
