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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbl_PayrollP_Dynamic = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_EmpCA_Dynamic = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_TotalEmp_Dynamic = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lbl_PayrollTM_Dynamic = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Pnl_OnLeaveT = New System.Windows.Forms.Panel()
        Me.Lbl_OnLeave = New System.Windows.Forms.Label()
        Me.Pnl_OvertimeT = New System.Windows.Forms.Panel()
        Me.Lbl_OnOvertime = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DGV_SalarySlips = New System.Windows.Forms.DataGridView()
        Me.SalarySlips_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarySlips_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarySlips_Action = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarySlips_Details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lbl_SalarySlips = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DGV_AttendanceT = New System.Windows.Forms.DataGridView()
        Me.AttendanceT_Employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceT_TITO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceT_Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lbl_AttendanceT = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Pnl_OnLeaveT.SuspendLayout()
        Me.Pnl_OvertimeT.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGV_SalarySlips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.DGV_AttendanceT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_WelcomeMsg
        '
        Me.Lbl_WelcomeMsg.AutoSize = True
        Me.Lbl_WelcomeMsg.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_WelcomeMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_WelcomeMsg.Location = New System.Drawing.Point(10, 10)
        Me.Lbl_WelcomeMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_WelcomeMsg.Name = "Lbl_WelcomeMsg"
        Me.Lbl_WelcomeMsg.Size = New System.Drawing.Size(92, 20)
        Me.Lbl_WelcomeMsg.TabIndex = 12
        Me.Lbl_WelcomeMsg.Text = "Welcome, "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 40)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(830, 100)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Lbl_PayrollP_Dynamic)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(202, 100)
        Me.Panel3.TabIndex = 23
        '
        'Lbl_PayrollP_Dynamic
        '
        Me.Lbl_PayrollP_Dynamic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_PayrollP_Dynamic.AutoSize = True
        Me.Lbl_PayrollP_Dynamic.BackColor = System.Drawing.Color.White
        Me.Lbl_PayrollP_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_PayrollP_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_PayrollP_Dynamic.Location = New System.Drawing.Point(83, 50)
        Me.Lbl_PayrollP_Dynamic.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_PayrollP_Dynamic.Name = "Lbl_PayrollP_Dynamic"
        Me.Lbl_PayrollP_Dynamic.Size = New System.Drawing.Size(32, 33)
        Me.Lbl_PayrollP_Dynamic.TabIndex = 5
        Me.Lbl_PayrollP_Dynamic.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(33, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pending Payrolls"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Lbl_EmpCA_Dynamic)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(212, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 100)
        Me.Panel2.TabIndex = 22
        '
        'Lbl_EmpCA_Dynamic
        '
        Me.Lbl_EmpCA_Dynamic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_EmpCA_Dynamic.AutoSize = True
        Me.Lbl_EmpCA_Dynamic.BackColor = System.Drawing.Color.White
        Me.Lbl_EmpCA_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_EmpCA_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_EmpCA_Dynamic.Location = New System.Drawing.Point(80, 50)
        Me.Lbl_EmpCA_Dynamic.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_EmpCA_Dynamic.Name = "Lbl_EmpCA_Dynamic"
        Me.Lbl_EmpCA_Dynamic.Size = New System.Drawing.Size(32, 33)
        Me.Lbl_EmpCA_Dynamic.TabIndex = 4
        Me.Lbl_EmpCA_Dynamic.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(0, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current Active Employees"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Lbl_TotalEmp_Dynamic)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(419, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 100)
        Me.Panel1.TabIndex = 21
        '
        'Lbl_TotalEmp_Dynamic
        '
        Me.Lbl_TotalEmp_Dynamic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_TotalEmp_Dynamic.AutoSize = True
        Me.Lbl_TotalEmp_Dynamic.BackColor = System.Drawing.Color.White
        Me.Lbl_TotalEmp_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_TotalEmp_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_TotalEmp_Dynamic.Location = New System.Drawing.Point(80, 50)
        Me.Lbl_TotalEmp_Dynamic.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_TotalEmp_Dynamic.Name = "Lbl_TotalEmp_Dynamic"
        Me.Lbl_TotalEmp_Dynamic.Size = New System.Drawing.Size(32, 33)
        Me.Lbl_TotalEmp_Dynamic.TabIndex = 3
        Me.Lbl_TotalEmp_Dynamic.Text = "0"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(30, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Employees"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Lbl_PayrollTM_Dynamic)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(626, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(204, 100)
        Me.Panel4.TabIndex = 24
        '
        'Lbl_PayrollTM_Dynamic
        '
        Me.Lbl_PayrollTM_Dynamic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_PayrollTM_Dynamic.AutoSize = True
        Me.Lbl_PayrollTM_Dynamic.BackColor = System.Drawing.Color.White
        Me.Lbl_PayrollTM_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_PayrollTM_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_PayrollTM_Dynamic.Location = New System.Drawing.Point(33, 50)
        Me.Lbl_PayrollTM_Dynamic.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_PayrollTM_Dynamic.Name = "Lbl_PayrollTM_Dynamic"
        Me.Lbl_PayrollTM_Dynamic.Size = New System.Drawing.Size(132, 33)
        Me.Lbl_PayrollTM_Dynamic.TabIndex = 6
        Me.Lbl_PayrollTM_Dynamic.Text = "Php 0.00"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Payroll This Month"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Pnl_OnLeaveT, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Pnl_OvertimeT, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(600, 150)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(240, 410)
        Me.TableLayoutPanel2.TabIndex = 24
        '
        'Pnl_OnLeaveT
        '
        Me.Pnl_OnLeaveT.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Pnl_OnLeaveT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_OnLeaveT.Controls.Add(Me.Lbl_OnLeave)
        Me.Pnl_OnLeaveT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_OnLeaveT.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_OnLeaveT.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Pnl_OnLeaveT.Name = "Pnl_OnLeaveT"
        Me.Pnl_OnLeaveT.Size = New System.Drawing.Size(240, 200)
        Me.Pnl_OnLeaveT.TabIndex = 17
        '
        'Lbl_OnLeave
        '
        Me.Lbl_OnLeave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_OnLeave.AutoSize = True
        Me.Lbl_OnLeave.BackColor = System.Drawing.Color.White
        Me.Lbl_OnLeave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_OnLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OnLeave.Location = New System.Drawing.Point(50, 10)
        Me.Lbl_OnLeave.Margin = New System.Windows.Forms.Padding(0)
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
        Me.Pnl_OvertimeT.Location = New System.Drawing.Point(0, 210)
        Me.Pnl_OvertimeT.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Pnl_OvertimeT.Name = "Pnl_OvertimeT"
        Me.Pnl_OvertimeT.Size = New System.Drawing.Size(240, 200)
        Me.Pnl_OvertimeT.TabIndex = 18
        '
        'Lbl_OnOvertime
        '
        Me.Lbl_OnOvertime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_OnOvertime.AutoSize = True
        Me.Lbl_OnOvertime.BackColor = System.Drawing.Color.White
        Me.Lbl_OnOvertime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_OnOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OnOvertime.Location = New System.Drawing.Point(41, 10)
        Me.Lbl_OnOvertime.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_OnOvertime.Name = "Lbl_OnOvertime"
        Me.Lbl_OnOvertime.Size = New System.Drawing.Size(163, 22)
        Me.Lbl_OnOvertime.TabIndex = 3
        Me.Lbl_OnOvertime.Text = "On Overtime Today"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel6, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(10, 150)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(580, 410)
        Me.TableLayoutPanel3.TabIndex = 27
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DGV_SalarySlips)
        Me.Panel5.Controls.Add(Me.Lbl_SalarySlips)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(580, 200)
        Me.Panel5.TabIndex = 0
        '
        'DGV_SalarySlips
        '
        Me.DGV_SalarySlips.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_SalarySlips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_SalarySlips.BackgroundColor = System.Drawing.Color.MediumAquamarine
        Me.DGV_SalarySlips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SalarySlips.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalarySlips_Date, Me.SalarySlips_User, Me.SalarySlips_Action, Me.SalarySlips_Details})
        Me.DGV_SalarySlips.Location = New System.Drawing.Point(0, 30)
        Me.DGV_SalarySlips.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_SalarySlips.Name = "DGV_SalarySlips"
        Me.DGV_SalarySlips.Size = New System.Drawing.Size(580, 170)
        Me.DGV_SalarySlips.TabIndex = 22
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
        'Lbl_SalarySlips
        '
        Me.Lbl_SalarySlips.AutoSize = True
        Me.Lbl_SalarySlips.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SalarySlips.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_SalarySlips.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_SalarySlips.Name = "Lbl_SalarySlips"
        Me.Lbl_SalarySlips.Size = New System.Drawing.Size(166, 20)
        Me.Lbl_SalarySlips.TabIndex = 23
        Me.Lbl_SalarySlips.Text = "Recent Salary Slips"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DGV_AttendanceT)
        Me.Panel6.Controls.Add(Me.Lbl_AttendanceT)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 210)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(580, 200)
        Me.Panel6.TabIndex = 1
        '
        'DGV_AttendanceT
        '
        Me.DGV_AttendanceT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_AttendanceT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_AttendanceT.BackgroundColor = System.Drawing.Color.MediumAquamarine
        Me.DGV_AttendanceT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_AttendanceT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AttendanceT_Employee, Me.AttendanceT_TITO, Me.AttendanceT_Remarks})
        Me.DGV_AttendanceT.Location = New System.Drawing.Point(0, 30)
        Me.DGV_AttendanceT.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_AttendanceT.Name = "DGV_AttendanceT"
        Me.DGV_AttendanceT.Size = New System.Drawing.Size(580, 170)
        Me.DGV_AttendanceT.TabIndex = 23
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
        'Lbl_AttendanceT
        '
        Me.Lbl_AttendanceT.AutoSize = True
        Me.Lbl_AttendanceT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AttendanceT.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_AttendanceT.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_AttendanceT.Name = "Lbl_AttendanceT"
        Me.Lbl_AttendanceT.Size = New System.Drawing.Size(168, 20)
        Me.Lbl_AttendanceT.TabIndex = 24
        Me.Lbl_AttendanceT.Text = "Today's Attendance"
        '
        'HR_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.MyPMS.My.Resources.Resources.MyPMS_2_tansparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Lbl_WelcomeMsg)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "HR_Dashboard"
        Me.Size = New System.Drawing.Size(850, 570)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Pnl_OnLeaveT.ResumeLayout(False)
        Me.Pnl_OnLeaveT.PerformLayout()
        Me.Pnl_OvertimeT.ResumeLayout(False)
        Me.Pnl_OvertimeT.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DGV_SalarySlips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DGV_AttendanceT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_WelcomeMsg As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbl_PayrollP_Dynamic As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbl_EmpCA_Dynamic As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_TotalEmp_Dynamic As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Lbl_PayrollTM_Dynamic As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Pnl_OnLeaveT As Panel
    Friend WithEvents Lbl_OnLeave As Label
    Friend WithEvents Pnl_OvertimeT As Panel
    Friend WithEvents Lbl_OnOvertime As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DGV_SalarySlips As DataGridView
    Friend WithEvents SalarySlips_Date As DataGridViewTextBoxColumn
    Friend WithEvents SalarySlips_User As DataGridViewTextBoxColumn
    Friend WithEvents SalarySlips_Action As DataGridViewTextBoxColumn
    Friend WithEvents SalarySlips_Details As DataGridViewTextBoxColumn
    Friend WithEvents Lbl_SalarySlips As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DGV_AttendanceT As DataGridView
    Friend WithEvents AttendanceT_Employee As DataGridViewTextBoxColumn
    Friend WithEvents AttendanceT_TITO As DataGridViewTextBoxColumn
    Friend WithEvents AttendanceT_Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Lbl_AttendanceT As Label
End Class
