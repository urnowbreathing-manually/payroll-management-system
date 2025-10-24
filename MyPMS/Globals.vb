Module Globals

    Public TblPanel As New TableLayoutPanel

    ' panels for form
    Public DashboardPanel As New Panel With {
       .Dock = DockStyle.Fill
    }

    Public GeneratePayrollPanel As New Panel With {
       .Dock = DockStyle.Fill
    }

    Public SuperMainPanel As New Panel With {
       .Dock = DockStyle.Fill
    }


    ' for generate payroll form hands off
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



    Public Sub HandleLettersOnly(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub
    Public Sub HandleNumbersOnly(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub
    Public Sub HandleNumbersAndPeriodOnly(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Asc(e.KeyChar) = 8 And Not Asc(e.KeyChar) = 46 Then
            e.Handled = True
        End If
    End Sub

End Module
