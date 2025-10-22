<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HR_Dashboard
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
        Me.Lbl_WelcomeMsg = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lbl_PayrollTM_Dynamic = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbl_PayrollP_Dynamic = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_EmpCA_Dynamic = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_TotalEmp_Dynamic = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Pnl_AttendanceT = New System.Windows.Forms.Panel()
        Me.Lbl_AttendanceT = New System.Windows.Forms.Label()
        Me.DGV_AttendanceT = New System.Windows.Forms.DataGridView()
        Me.AttendanceT_Employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceT_TITO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceT_Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pnl_OnLeaveT = New System.Windows.Forms.Panel()
        Me.Lbl_OnLeave = New System.Windows.Forms.Label()
        Me.Pnl_OvertimeT = New System.Windows.Forms.Panel()
        Me.Lbl_OnOvertime = New System.Windows.Forms.Label()
        Me.Pnl_SalarySlips = New System.Windows.Forms.Panel()
        Me.Lbl_SalarySlips = New System.Windows.Forms.Label()
        Me.DGV_SalarySlips = New System.Windows.Forms.DataGridView()
        Me.SalarySlips_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarySlips_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarySlips_Action = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarySlips_Details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Pnl_AttendanceT.SuspendLayout()
        CType(Me.DGV_AttendanceT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_OnLeaveT.SuspendLayout()
        Me.Pnl_OvertimeT.SuspendLayout()
        Me.Pnl_SalarySlips.SuspendLayout()
        CType(Me.DGV_SalarySlips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_WelcomeMsg
        '
        Me.Lbl_WelcomeMsg.AutoSize = True
        Me.Lbl_WelcomeMsg.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Lbl_WelcomeMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_WelcomeMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_WelcomeMsg.Location = New System.Drawing.Point(6, 0)
        Me.Lbl_WelcomeMsg.Name = "Lbl_WelcomeMsg"
        Me.Lbl_WelcomeMsg.Size = New System.Drawing.Size(94, 22)
        Me.Lbl_WelcomeMsg.TabIndex = 1
        Me.Lbl_WelcomeMsg.Text = "Welcome, "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Lbl_WelcomeMsg)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(834, 560)
        Me.SplitContainer1.SplitterDistance = 126
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 2
        Me.SplitContainer1.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(822, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Lbl_PayrollTM_Dynamic)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(618, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(201, 94)
        Me.Panel4.TabIndex = 10
        '
        'Lbl_PayrollTM_Dynamic
        '
        Me.Lbl_PayrollTM_Dynamic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_PayrollTM_Dynamic.AutoSize = True
        Me.Lbl_PayrollTM_Dynamic.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_PayrollTM_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_PayrollTM_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_PayrollTM_Dynamic.Location = New System.Drawing.Point(37, 46)
        Me.Lbl_PayrollTM_Dynamic.Name = "Lbl_PayrollTM_Dynamic"
        Me.Lbl_PayrollTM_Dynamic.Size = New System.Drawing.Size(132, 33)
        Me.Lbl_PayrollTM_Dynamic.TabIndex = 6
        Me.Lbl_PayrollTM_Dynamic.Text = "Php 0.00"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(7, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Payroll This Month"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Lbl_PayrollP_Dynamic)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(413, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(199, 94)
        Me.Panel3.TabIndex = 9
        '
        'Lbl_PayrollP_Dynamic
        '
        Me.Lbl_PayrollP_Dynamic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_PayrollP_Dynamic.AutoSize = True
        Me.Lbl_PayrollP_Dynamic.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_PayrollP_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_PayrollP_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_PayrollP_Dynamic.Location = New System.Drawing.Point(82, 46)
        Me.Lbl_PayrollP_Dynamic.Name = "Lbl_PayrollP_Dynamic"
        Me.Lbl_PayrollP_Dynamic.Size = New System.Drawing.Size(32, 33)
        Me.Lbl_PayrollP_Dynamic.TabIndex = 5
        Me.Lbl_PayrollP_Dynamic.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(32, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pending Payrolls"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Lbl_EmpCA_Dynamic)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(208, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(199, 94)
        Me.Panel2.TabIndex = 8
        '
        'Lbl_EmpCA_Dynamic
        '
        Me.Lbl_EmpCA_Dynamic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_EmpCA_Dynamic.AutoSize = True
        Me.Lbl_EmpCA_Dynamic.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_EmpCA_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_EmpCA_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_EmpCA_Dynamic.Location = New System.Drawing.Point(82, 46)
        Me.Lbl_EmpCA_Dynamic.Name = "Lbl_EmpCA_Dynamic"
        Me.Lbl_EmpCA_Dynamic.Size = New System.Drawing.Size(32, 33)
        Me.Lbl_EmpCA_Dynamic.TabIndex = 4
        Me.Lbl_EmpCA_Dynamic.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(0, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current Active Employees"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Lbl_TotalEmp_Dynamic)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 94)
        Me.Panel1.TabIndex = 7
        '
        'Lbl_TotalEmp_Dynamic
        '
        Me.Lbl_TotalEmp_Dynamic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_TotalEmp_Dynamic.AutoSize = True
        Me.Lbl_TotalEmp_Dynamic.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_TotalEmp_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_TotalEmp_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_TotalEmp_Dynamic.Location = New System.Drawing.Point(78, 46)
        Me.Lbl_TotalEmp_Dynamic.Name = "Lbl_TotalEmp_Dynamic"
        Me.Lbl_TotalEmp_Dynamic.Size = New System.Drawing.Size(32, 33)
        Me.Lbl_TotalEmp_Dynamic.TabIndex = 3
        Me.Lbl_TotalEmp_Dynamic.Text = "0"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(36, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Employees"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Pnl_AttendanceT, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Pnl_OnLeaveT, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Pnl_OvertimeT, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Pnl_SalarySlips, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(828, 423)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Pnl_AttendanceT
        '
        Me.Pnl_AttendanceT.Controls.Add(Me.Lbl_AttendanceT)
        Me.Pnl_AttendanceT.Controls.Add(Me.DGV_AttendanceT)
        Me.Pnl_AttendanceT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_AttendanceT.Location = New System.Drawing.Point(3, 214)
        Me.Pnl_AttendanceT.Name = "Pnl_AttendanceT"
        Me.Pnl_AttendanceT.Size = New System.Drawing.Size(573, 206)
        Me.Pnl_AttendanceT.TabIndex = 10
        '
        'Lbl_AttendanceT
        '
        Me.Lbl_AttendanceT.AutoSize = True
        Me.Lbl_AttendanceT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AttendanceT.Location = New System.Drawing.Point(6, 6)
        Me.Lbl_AttendanceT.Name = "Lbl_AttendanceT"
        Me.Lbl_AttendanceT.Size = New System.Drawing.Size(168, 20)
        Me.Lbl_AttendanceT.TabIndex = 11
        Me.Lbl_AttendanceT.Text = "Today's Attendance"
        '
        'DGV_AttendanceT
        '
        Me.DGV_AttendanceT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGV_AttendanceT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_AttendanceT.BackgroundColor = System.Drawing.Color.MediumAquamarine
        Me.DGV_AttendanceT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_AttendanceT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AttendanceT_Employee, Me.AttendanceT_TITO, Me.AttendanceT_Remarks})
        Me.DGV_AttendanceT.Location = New System.Drawing.Point(3, 29)
        Me.DGV_AttendanceT.Name = "DGV_AttendanceT"
        Me.DGV_AttendanceT.Size = New System.Drawing.Size(567, 173)
        Me.DGV_AttendanceT.TabIndex = 10
        '
        'AttendanceT_Employee
        '
        Me.AttendanceT_Employee.HeaderText = "Employee"
        Me.AttendanceT_Employee.Name = "AttendanceT_Employee"
        '
        'AttendanceT_TITO
        '
        Me.AttendanceT_TITO.HeaderText = "Time-In | Time-Out"
        Me.AttendanceT_TITO.Name = "AttendanceT_TITO"
        '
        'AttendanceT_Remarks
        '
        Me.AttendanceT_Remarks.HeaderText = "Remarks"
        Me.AttendanceT_Remarks.Name = "AttendanceT_Remarks"
        '
        'Pnl_OnLeaveT
        '
        Me.Pnl_OnLeaveT.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Pnl_OnLeaveT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_OnLeaveT.Controls.Add(Me.Lbl_OnLeave)
        Me.Pnl_OnLeaveT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_OnLeaveT.Location = New System.Drawing.Point(582, 3)
        Me.Pnl_OnLeaveT.Name = "Pnl_OnLeaveT"
        Me.Pnl_OnLeaveT.Size = New System.Drawing.Size(243, 205)
        Me.Pnl_OnLeaveT.TabIndex = 6
        '
        'Lbl_OnLeave
        '
        Me.Lbl_OnLeave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_OnLeave.AutoSize = True
        Me.Lbl_OnLeave.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_OnLeave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_OnLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OnLeave.Location = New System.Drawing.Point(57, 7)
        Me.Lbl_OnLeave.Name = "Lbl_OnLeave"
        Me.Lbl_OnLeave.Size = New System.Drawing.Size(140, 22)
        Me.Lbl_OnLeave.TabIndex = 2
        Me.Lbl_OnLeave.Text = "On Leave Today"
        '
        'Pnl_OvertimeT
        '
        Me.Pnl_OvertimeT.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Pnl_OvertimeT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_OvertimeT.Controls.Add(Me.Lbl_OnOvertime)
        Me.Pnl_OvertimeT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_OvertimeT.Location = New System.Drawing.Point(582, 214)
        Me.Pnl_OvertimeT.Name = "Pnl_OvertimeT"
        Me.Pnl_OvertimeT.Size = New System.Drawing.Size(243, 206)
        Me.Pnl_OvertimeT.TabIndex = 8
        '
        'Lbl_OnOvertime
        '
        Me.Lbl_OnOvertime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_OnOvertime.AutoSize = True
        Me.Lbl_OnOvertime.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_OnOvertime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_OnOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OnOvertime.Location = New System.Drawing.Point(41, 9)
        Me.Lbl_OnOvertime.Name = "Lbl_OnOvertime"
        Me.Lbl_OnOvertime.Size = New System.Drawing.Size(163, 22)
        Me.Lbl_OnOvertime.TabIndex = 3
        Me.Lbl_OnOvertime.Text = "On Overtime Today"
        '
        'Pnl_SalarySlips
        '
        Me.Pnl_SalarySlips.Controls.Add(Me.Lbl_SalarySlips)
        Me.Pnl_SalarySlips.Controls.Add(Me.DGV_SalarySlips)
        Me.Pnl_SalarySlips.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_SalarySlips.Location = New System.Drawing.Point(3, 3)
        Me.Pnl_SalarySlips.Name = "Pnl_SalarySlips"
        Me.Pnl_SalarySlips.Size = New System.Drawing.Size(573, 205)
        Me.Pnl_SalarySlips.TabIndex = 9
        '
        'Lbl_SalarySlips
        '
        Me.Lbl_SalarySlips.AutoSize = True
        Me.Lbl_SalarySlips.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SalarySlips.Location = New System.Drawing.Point(3, 5)
        Me.Lbl_SalarySlips.Name = "Lbl_SalarySlips"
        Me.Lbl_SalarySlips.Size = New System.Drawing.Size(166, 20)
        Me.Lbl_SalarySlips.TabIndex = 10
        Me.Lbl_SalarySlips.Text = "Recent Salary Slips"
        '
        'DGV_SalarySlips
        '
        Me.DGV_SalarySlips.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGV_SalarySlips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_SalarySlips.BackgroundColor = System.Drawing.Color.MediumAquamarine
        Me.DGV_SalarySlips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SalarySlips.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalarySlips_Date, Me.SalarySlips_User, Me.SalarySlips_Action, Me.SalarySlips_Details})
        Me.DGV_SalarySlips.Location = New System.Drawing.Point(0, 28)
        Me.DGV_SalarySlips.Name = "DGV_SalarySlips"
        Me.DGV_SalarySlips.Size = New System.Drawing.Size(570, 174)
        Me.DGV_SalarySlips.TabIndex = 9
        '
        'SalarySlips_Date
        '
        Me.SalarySlips_Date.HeaderText = "Date"
        Me.SalarySlips_Date.Name = "SalarySlips_Date"
        '
        'SalarySlips_User
        '
        Me.SalarySlips_User.HeaderText = "User"
        Me.SalarySlips_User.Name = "SalarySlips_User"
        '
        'SalarySlips_Action
        '
        Me.SalarySlips_Action.HeaderText = "Action"
        Me.SalarySlips_Action.Name = "SalarySlips_Action"
        '
        'SalarySlips_Details
        '
        Me.SalarySlips_Details.HeaderText = "Details"
        Me.SalarySlips_Details.Name = "SalarySlips_Details"
        '
        'HR_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "HR_Dashboard"
        Me.Size = New System.Drawing.Size(834, 560)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Pnl_AttendanceT.ResumeLayout(False)
        Me.Pnl_AttendanceT.PerformLayout()
        CType(Me.DGV_AttendanceT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_OnLeaveT.ResumeLayout(False)
        Me.Pnl_OnLeaveT.PerformLayout()
        Me.Pnl_OvertimeT.ResumeLayout(False)
        Me.Pnl_OvertimeT.PerformLayout()
        Me.Pnl_SalarySlips.ResumeLayout(False)
        Me.Pnl_SalarySlips.PerformLayout()
        CType(Me.DGV_SalarySlips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_WelcomeMsg As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Pnl_OnLeaveT As Panel
    Friend WithEvents Lbl_OnLeave As Label
    Friend WithEvents Pnl_AttendanceT As Panel
    Friend WithEvents Pnl_OvertimeT As Panel
    Friend WithEvents Lbl_OnOvertime As Label
    Friend WithEvents Pnl_SalarySlips As Panel
    Friend WithEvents Lbl_SalarySlips As Label
    Friend WithEvents DGV_SalarySlips As DataGridView
    Friend WithEvents Lbl_AttendanceT As Label
    Friend WithEvents DGV_AttendanceT As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbl_EmpCA_Dynamic As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_TotalEmp_Dynamic As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_PayrollTM_Dynamic As Label
    Friend WithEvents Lbl_PayrollP_Dynamic As Label
    Friend WithEvents AttendanceT_Employee As DataGridViewTextBoxColumn
    Friend WithEvents AttendanceT_TITO As DataGridViewTextBoxColumn
    Friend WithEvents AttendanceT_Remarks As DataGridViewTextBoxColumn
    Friend WithEvents SalarySlips_Date As DataGridViewTextBoxColumn
    Friend WithEvents SalarySlips_User As DataGridViewTextBoxColumn
    Friend WithEvents SalarySlips_Action As DataGridViewTextBoxColumn
    Friend WithEvents SalarySlips_Details As DataGridViewTextBoxColumn
End Class
