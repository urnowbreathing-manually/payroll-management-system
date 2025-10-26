Imports System.Runtime.InteropServices

Public Class ViewPayrollRecord
    Public Shared MainContentPanel As Panel
    Dim handler As New DBHandler()
    Dim PayrollTable As DataGridView

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub

    Private Sub ViewPayrollRecord_Load(sender As Object, e As EventArgs) Handles Me.Load
        PayrollTable = New DataGridView

        handler.LoadPayrollData(PayrollTable)
        'MessageBox.Show("Rows in datagridview1: " & payrolltable.Rows.Count.ToString())
        PopulatePayrollFlowPanel(PayrollTable, FlowLayoutPanel1, "View")
    End Sub
    Public Sub PopulatePayrollFlowPanel(ByVal dgv As DataGridView, flp As FlowLayoutPanel, Optional btnText As String = "")
        flp.Controls.Clear()

        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Dim pnl As New Panel()
                pnl.Width = flp.Width
                pnl.Height = 110
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
                tblRow.RowCount = 4
                tblRow.Dock = DockStyle.Fill
                tblRow.AutoSize = True
                tblRow.Padding = New Padding(0)
                tblRow.Margin = New Padding(0)

                Dim lblName As New Label()
                lblName.Text = row.Cells("name").Value.ToString()
                lblName.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                lblName.AutoSize = True

                Dim lblDateTime As New Label()
                lblDateTime.Text = "Date & Time: " & Convert.ToDateTime(row.Cells("date_time").Value).ToString("yyyy-MM-dd HH:mm")
                lblDateTime.Font = New Font("Segoe UI", 9, FontStyle.Italic)
                lblDateTime.ForeColor = Color.Gray
                lblDateTime.AutoSize = True

                Dim lblEmpID As New Label()
                lblEmpID.Text = "Employee ID: " & row.Cells("employee_id").Value.ToString()
                lblEmpID.Font = New Font("Segoe UI", 10)
                lblEmpID.AutoSize = True

                Dim lblGross As New Label()
                lblGross.Text = "Gross Salary: ₱" & Format(row.Cells("gross_salary").Value, "#,##0.00")
                lblGross.Font = New Font("Segoe UI", 10)
                lblGross.AutoSize = True

                Dim lblSSS As New Label()
                lblSSS.Text = "SSS: ₱" & Format(row.Cells("sss").Value, "#,##0.00")
                lblSSS.Font = New Font("Segoe UI", 10)
                lblSSS.AutoSize = True

                Dim lblPhilHealth As New Label()
                lblPhilHealth.Text = "PhilHealth: ₱" & Format(row.Cells("philhealth").Value, "#,##0.00")
                lblPhilHealth.Font = New Font("Segoe UI", 10)
                lblPhilHealth.AutoSize = True

                Dim lblPagIbig As New Label()
                lblPagIbig.Text = "Pag-IBIG: ₱" & Format(row.Cells("pagibig").Value, "#,##0.00")
                lblPagIbig.Font = New Font("Segoe UI", 10)
                lblPagIbig.AutoSize = True

                Dim lblNet As New Label()
                lblNet.Text = "Net Salary: ₱" & Format(row.Cells("net_salary").Value, "#,##0.00")
                lblNet.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                lblNet.ForeColor = Color.DarkGreen
                lblNet.AutoSize = True

                tblRow.Controls.Add(lblName, 0, 0)
                tblRow.Controls.Add(lblDateTime, 0, 1)
                tblRow.Controls.Add(lblEmpID, 0, 2)
                tblRow.Controls.Add(lblGross, 0, 3)
                tblRow.Controls.Add(lblSSS, 1, 0)
                tblRow.Controls.Add(lblPhilHealth, 1, 1)
                tblRow.Controls.Add(lblPagIbig, 1, 2)

                Dim lblNetContainer As New Label()
                lblNetContainer.Text = lblNet.Text
                lblNetContainer.Font = lblNet.Font
                lblNetContainer.ForeColor = lblNet.ForeColor
                lblNetContainer.Dock = DockStyle.Bottom
                lblNetContainer.TextAlign = ContentAlignment.MiddleRight

                Dim selectBtn As New Button()
                selectBtn.Text = If(String.IsNullOrEmpty(btnText), "Select", btnText)
                selectBtn.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                selectBtn.FlatStyle = FlatStyle.Flat
                selectBtn.BackColor = Color.LightBlue
                selectBtn.Size = New Size(80, 30)
                selectBtn.Margin = New Padding(10, 25, 10, 25)
                selectBtn.Anchor = AnchorStyles.Right
                selectBtn.Cursor = Cursors.Hand

                AddHandler selectBtn.Click, Sub()
                                                MessageBox.Show("Receipt ID: " & row.Cells("receipt_id").Value.ToString())
                                            End Sub

                layout.Controls.Add(tblRow, 0, 0)
                layout.Controls.Add(selectBtn, 1, 0)
                pnl.Controls.Add(layout)
                pnl.Controls.Add(lblNetContainer)

                flp.Controls.Add(pnl)
            End If
        Next
    End Sub



End Class
