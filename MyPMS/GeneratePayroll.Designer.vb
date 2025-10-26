<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GeneratePayroll
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGV_EmployeeList = New System.Windows.Forms.DataGridView()
        Me.EmpList_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpList_EmpName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpList_Salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpList_TotalHrs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpList_Overtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Btn_GeneratePayroll = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_SalarySlips = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DGV_EmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_EmployeeList
        '
        Me.DGV_EmployeeList.AllowUserToAddRows = False
        Me.DGV_EmployeeList.AllowUserToDeleteRows = False
        Me.DGV_EmployeeList.AllowUserToResizeRows = False
        Me.DGV_EmployeeList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_EmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_EmployeeList.BackgroundColor = System.Drawing.Color.MediumAquamarine
        Me.DGV_EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_EmployeeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpList_ID, Me.EmpList_EmpName, Me.EmpList_Salary, Me.EmpList_TotalHrs, Me.EmpList_Overtime})
        Me.DGV_EmployeeList.Location = New System.Drawing.Point(0, 30)
        Me.DGV_EmployeeList.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_EmployeeList.Name = "DGV_EmployeeList"
        Me.DGV_EmployeeList.Size = New System.Drawing.Size(830, 410)
        Me.DGV_EmployeeList.TabIndex = 7
        '
        'EmpList_ID
        '
        Me.EmpList_ID.HeaderText = "ID"
        Me.EmpList_ID.Name = "EmpList_ID"
        '
        'EmpList_EmpName
        '
        Me.EmpList_EmpName.HeaderText = "Employee Name"
        Me.EmpList_EmpName.Name = "EmpList_EmpName"
        '
        'EmpList_Salary
        '
        Me.EmpList_Salary.HeaderText = "Salary"
        Me.EmpList_Salary.Name = "EmpList_Salary"
        '
        'EmpList_TotalHrs
        '
        Me.EmpList_TotalHrs.HeaderText = "Total Hours"
        Me.EmpList_TotalHrs.Name = "EmpList_TotalHrs"
        '
        'EmpList_Overtime
        '
        Me.EmpList_Overtime.HeaderText = "Ovetime"
        Me.EmpList_Overtime.Name = "EmpList_Overtime"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(276, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0, 0, 25, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 80)
        Me.Panel2.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(105, 40)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 30)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "23"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.LightGreen
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(-2, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(251, 30)
        Me.Panel3.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(51, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 25)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Total Payrolls"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Salmon
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Location = New System.Drawing.Point(-2, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(253, 30)
        Me.Panel4.TabIndex = 59
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(229, 25)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Total Pending Payrolls"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Location = New System.Drawing.Point(577, 10)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(253, 80)
        Me.Panel5.TabIndex = 58
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(115, 40)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 30)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "5"
        '
        'Btn_GeneratePayroll
        '
        Me.Btn_GeneratePayroll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_GeneratePayroll.BackColor = System.Drawing.Color.LawnGreen
        Me.Btn_GeneratePayroll.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btn_GeneratePayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GeneratePayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_GeneratePayroll.Location = New System.Drawing.Point(18, 30)
        Me.Btn_GeneratePayroll.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_GeneratePayroll.Name = "Btn_GeneratePayroll"
        Me.Btn_GeneratePayroll.Size = New System.Drawing.Size(240, 40)
        Me.Btn_GeneratePayroll.TabIndex = 70
        Me.Btn_GeneratePayroll.Text = "Generate Payroll"
        Me.Btn_GeneratePayroll.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Lbl_SalarySlips)
        Me.Panel1.Controls.Add(Me.DGV_EmployeeList)
        Me.Panel1.Location = New System.Drawing.Point(10, 120)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(830, 440)
        Me.Panel1.TabIndex = 71
        '
        'Lbl_SalarySlips
        '
        Me.Lbl_SalarySlips.AutoSize = True
        Me.Lbl_SalarySlips.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SalarySlips.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_SalarySlips.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_SalarySlips.Name = "Lbl_SalarySlips"
        Me.Lbl_SalarySlips.Size = New System.Drawing.Size(166, 20)
        Me.Lbl_SalarySlips.TabIndex = 24
        Me.Lbl_SalarySlips.Text = "Recent Salary Slips"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_GeneratePayroll, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(830, 100)
        Me.TableLayoutPanel1.TabIndex = 72
        '
        'GeneratePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.MyPMS.My.Resources.Resources.MyPMS_2_tansparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "GeneratePayroll"
        Me.Size = New System.Drawing.Size(850, 570)
        CType(Me.DGV_EmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_EmployeeList As DataGridView
    Friend WithEvents EmpList_ID As DataGridViewTextBoxColumn
    Friend WithEvents EmpList_EmpName As DataGridViewTextBoxColumn
    Friend WithEvents EmpList_Salary As DataGridViewTextBoxColumn
    Friend WithEvents EmpList_TotalHrs As DataGridViewTextBoxColumn
    Friend WithEvents EmpList_Overtime As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Btn_GeneratePayroll As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_SalarySlips As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
