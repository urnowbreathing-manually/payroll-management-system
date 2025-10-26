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
        Me.Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalPayroll = New System.Windows.Forms.Label()
        Me.Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblPendingPayroll = New System.Windows.Forms.Label()
        Me.pnlPayrollForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGeneratePayroll = New Guna.UI2.WinForms.Guna2Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbxDepartment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxNetSalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxOverTime = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxGrossSalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxTotalHours = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxPagIBIG = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxEmailAddr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxPhilHealth = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxEmployeeName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxSSS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxEmployeeID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSearchEmployee = New Guna.UI2.WinForms.Guna2Button()
        Me.txtbxSearchEmployee = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbbxFilterByDept = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.DGV_EmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlPayrollForm.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
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
        Me.DGV_EmployeeList.BackgroundColor = System.Drawing.Color.White
        Me.DGV_EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_EmployeeList.Location = New System.Drawing.Point(640, 20)
        Me.DGV_EmployeeList.Name = "DGV_EmployeeList"
        Me.DGV_EmployeeList.Size = New System.Drawing.Size(159, 39)
        Me.DGV_EmployeeList.TabIndex = 7
        Me.DGV_EmployeeList.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderRadius = 10
        Me.Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Panel2.Controls.Add(Me.lblTotalPayroll)
        Me.Panel2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Location = New System.Drawing.Point(910, 240)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 83)
        Me.Panel2.TabIndex = 26
        '
        'lblTotalPayroll
        '
        Me.lblTotalPayroll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalPayroll.AutoSize = True
        Me.lblTotalPayroll.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayroll.Location = New System.Drawing.Point(103, 46)
        Me.lblTotalPayroll.Name = "lblTotalPayroll"
        Me.lblTotalPayroll.Size = New System.Drawing.Size(37, 30)
        Me.lblTotalPayroll.TabIndex = 57
        Me.lblTotalPayroll.Text = "23"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.LightGreen
        Me.Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(910, 240)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(237, 44)
        Me.Panel3.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 21)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Total of Payroll this month"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.FillColor = System.Drawing.Color.Salmon
        Me.Panel4.Location = New System.Drawing.Point(910, 346)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 44)
        Me.Panel4.TabIndex = 59
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(205, 21)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Pending payroll this month"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BorderRadius = 10
        Me.Panel5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Panel5.Controls.Add(Me.lblPendingPayroll)
        Me.Panel5.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Location = New System.Drawing.Point(910, 346)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(237, 83)
        Me.Panel5.TabIndex = 58
        '
        'lblPendingPayroll
        '
        Me.lblPendingPayroll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPendingPayroll.AutoSize = True
        Me.lblPendingPayroll.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingPayroll.Location = New System.Drawing.Point(107, 46)
        Me.lblPendingPayroll.Name = "lblPendingPayroll"
        Me.lblPendingPayroll.Size = New System.Drawing.Size(25, 30)
        Me.lblPendingPayroll.TabIndex = 57
        Me.lblPendingPayroll.Text = "5"
        '
        'pnlPayrollForm
        '
        Me.pnlPayrollForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPayrollForm.BorderRadius = 10
        Me.pnlPayrollForm.Controls.Add(Me.btnCancel)
        Me.pnlPayrollForm.Controls.Add(Me.btnGeneratePayroll)
        Me.pnlPayrollForm.Controls.Add(Me.Label16)
        Me.pnlPayrollForm.Controls.Add(Me.Label11)
        Me.pnlPayrollForm.Controls.Add(Me.Label10)
        Me.pnlPayrollForm.Controls.Add(Me.Label9)
        Me.pnlPayrollForm.Controls.Add(Me.DGV_EmployeeList)
        Me.pnlPayrollForm.Controls.Add(Me.Label8)
        Me.pnlPayrollForm.Controls.Add(Me.Label7)
        Me.pnlPayrollForm.Controls.Add(Me.Label6)
        Me.pnlPayrollForm.Controls.Add(Me.Label5)
        Me.pnlPayrollForm.Controls.Add(Me.Label4)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxDepartment)
        Me.pnlPayrollForm.Controls.Add(Me.Label3)
        Me.pnlPayrollForm.Controls.Add(Me.Label2)
        Me.pnlPayrollForm.Controls.Add(Me.Label1)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxNetSalary)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxOverTime)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxGrossSalary)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxTotalHours)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxPagIBIG)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxEmailAddr)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxPhilHealth)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxEmployeeName)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxSSS)
        Me.pnlPayrollForm.Controls.Add(Me.txtbxEmployeeID)
        Me.pnlPayrollForm.FillColor = System.Drawing.Color.WhiteSmoke
        Me.pnlPayrollForm.Location = New System.Drawing.Point(20, 10)
        Me.pnlPayrollForm.Name = "pnlPayrollForm"
        Me.pnlPayrollForm.Size = New System.Drawing.Size(870, 420)
        Me.pnlPayrollForm.TabIndex = 61
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Animated = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(740, 360)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.BorderRadius = 10
        Me.btnCancel.Size = New System.Drawing.Size(120, 45)
        Me.btnCancel.TabIndex = 110
        Me.btnCancel.Text = "Cancel"
        '
        'btnGeneratePayroll
        '
        Me.btnGeneratePayroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGeneratePayroll.Animated = True
        Me.btnGeneratePayroll.BackColor = System.Drawing.Color.Transparent
        Me.btnGeneratePayroll.BorderRadius = 10
        Me.btnGeneratePayroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGeneratePayroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGeneratePayroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGeneratePayroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGeneratePayroll.FillColor = System.Drawing.Color.LimeGreen
        Me.btnGeneratePayroll.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneratePayroll.ForeColor = System.Drawing.Color.White
        Me.btnGeneratePayroll.Location = New System.Drawing.Point(540, 360)
        Me.btnGeneratePayroll.Name = "btnGeneratePayroll"
        Me.btnGeneratePayroll.ShadowDecoration.BorderRadius = 10
        Me.btnGeneratePayroll.Size = New System.Drawing.Size(180, 45)
        Me.btnGeneratePayroll.TabIndex = 109
        Me.btnGeneratePayroll.Text = "Generate Payroll"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(46, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 30)
        Me.Label16.TabIndex = 108
        Me.Label16.Text = "Generate Payroll"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(548, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 21)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Net Salary"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(534, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 21)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Gross Salary"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(558, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 21)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Pag-IBIG"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(548, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 21)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "PhilHealth"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(592, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 21)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "SSS"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Overtime"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 21)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Total of Hours"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 21)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Email address"
        '
        'txtbxDepartment
        '
        Me.txtbxDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxDepartment.BackColor = System.Drawing.Color.Transparent
        Me.txtbxDepartment.BorderRadius = 10
        Me.txtbxDepartment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxDepartment.DefaultText = ""
        Me.txtbxDepartment.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxDepartment.Location = New System.Drawing.Point(198, 180)
        Me.txtbxDepartment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxDepartment.Name = "txtbxDepartment"
        Me.txtbxDepartment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxDepartment.PlaceholderText = ""
        Me.txtbxDepartment.SelectedText = ""
        Me.txtbxDepartment.Size = New System.Drawing.Size(174, 29)
        Me.txtbxDepartment.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Department"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 21)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Employee ID"
        '
        'txtbxNetSalary
        '
        Me.txtbxNetSalary.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxNetSalary.BackColor = System.Drawing.Color.Transparent
        Me.txtbxNetSalary.BorderRadius = 10
        Me.txtbxNetSalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxNetSalary.DefaultText = "0"
        Me.txtbxNetSalary.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxNetSalary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxNetSalary.Location = New System.Drawing.Point(635, 277)
        Me.txtbxNetSalary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxNetSalary.Name = "txtbxNetSalary"
        Me.txtbxNetSalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxNetSalary.PlaceholderText = ""
        Me.txtbxNetSalary.SelectedText = ""
        Me.txtbxNetSalary.Size = New System.Drawing.Size(178, 29)
        Me.txtbxNetSalary.TabIndex = 95
        '
        'txtbxOverTime
        '
        Me.txtbxOverTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxOverTime.BackColor = System.Drawing.Color.Transparent
        Me.txtbxOverTime.BorderRadius = 10
        Me.txtbxOverTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxOverTime.DefaultText = ""
        Me.txtbxOverTime.Enabled = False
        Me.txtbxOverTime.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxOverTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxOverTime.Location = New System.Drawing.Point(198, 323)
        Me.txtbxOverTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxOverTime.Name = "txtbxOverTime"
        Me.txtbxOverTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxOverTime.PlaceholderText = ""
        Me.txtbxOverTime.SelectedText = ""
        Me.txtbxOverTime.Size = New System.Drawing.Size(131, 29)
        Me.txtbxOverTime.TabIndex = 94
        '
        'txtbxGrossSalary
        '
        Me.txtbxGrossSalary.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxGrossSalary.BackColor = System.Drawing.Color.Transparent
        Me.txtbxGrossSalary.BorderRadius = 10
        Me.txtbxGrossSalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxGrossSalary.DefaultText = "0"
        Me.txtbxGrossSalary.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxGrossSalary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxGrossSalary.Location = New System.Drawing.Point(635, 227)
        Me.txtbxGrossSalary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxGrossSalary.Name = "txtbxGrossSalary"
        Me.txtbxGrossSalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxGrossSalary.PlaceholderText = ""
        Me.txtbxGrossSalary.SelectedText = ""
        Me.txtbxGrossSalary.Size = New System.Drawing.Size(178, 29)
        Me.txtbxGrossSalary.TabIndex = 93
        '
        'txtbxTotalHours
        '
        Me.txtbxTotalHours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxTotalHours.BackColor = System.Drawing.Color.Transparent
        Me.txtbxTotalHours.BorderRadius = 10
        Me.txtbxTotalHours.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxTotalHours.DefaultText = ""
        Me.txtbxTotalHours.Enabled = False
        Me.txtbxTotalHours.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTotalHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxTotalHours.Location = New System.Drawing.Point(198, 273)
        Me.txtbxTotalHours.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxTotalHours.Name = "txtbxTotalHours"
        Me.txtbxTotalHours.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxTotalHours.PlaceholderText = ""
        Me.txtbxTotalHours.SelectedText = ""
        Me.txtbxTotalHours.Size = New System.Drawing.Size(131, 29)
        Me.txtbxTotalHours.TabIndex = 92
        '
        'txtbxPagIBIG
        '
        Me.txtbxPagIBIG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxPagIBIG.BackColor = System.Drawing.Color.Transparent
        Me.txtbxPagIBIG.BorderRadius = 10
        Me.txtbxPagIBIG.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxPagIBIG.DefaultText = "0"
        Me.txtbxPagIBIG.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPagIBIG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxPagIBIG.Location = New System.Drawing.Point(635, 177)
        Me.txtbxPagIBIG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxPagIBIG.Name = "txtbxPagIBIG"
        Me.txtbxPagIBIG.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxPagIBIG.PlaceholderText = "Enter Pag-IBIG tax here"
        Me.txtbxPagIBIG.SelectedText = ""
        Me.txtbxPagIBIG.Size = New System.Drawing.Size(178, 29)
        Me.txtbxPagIBIG.TabIndex = 91
        '
        'txtbxEmailAddr
        '
        Me.txtbxEmailAddr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxEmailAddr.BackColor = System.Drawing.Color.Transparent
        Me.txtbxEmailAddr.BorderRadius = 10
        Me.txtbxEmailAddr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxEmailAddr.DefaultText = ""
        Me.txtbxEmailAddr.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmailAddr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxEmailAddr.Location = New System.Drawing.Point(198, 224)
        Me.txtbxEmailAddr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxEmailAddr.Name = "txtbxEmailAddr"
        Me.txtbxEmailAddr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxEmailAddr.PlaceholderText = ""
        Me.txtbxEmailAddr.SelectedText = ""
        Me.txtbxEmailAddr.Size = New System.Drawing.Size(233, 29)
        Me.txtbxEmailAddr.TabIndex = 90
        '
        'txtbxPhilHealth
        '
        Me.txtbxPhilHealth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxPhilHealth.BackColor = System.Drawing.Color.Transparent
        Me.txtbxPhilHealth.BorderRadius = 10
        Me.txtbxPhilHealth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxPhilHealth.DefaultText = "0"
        Me.txtbxPhilHealth.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPhilHealth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxPhilHealth.Location = New System.Drawing.Point(635, 127)
        Me.txtbxPhilHealth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxPhilHealth.Name = "txtbxPhilHealth"
        Me.txtbxPhilHealth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxPhilHealth.PlaceholderText = "Enter PhilHealth tax here"
        Me.txtbxPhilHealth.SelectedText = ""
        Me.txtbxPhilHealth.Size = New System.Drawing.Size(178, 29)
        Me.txtbxPhilHealth.TabIndex = 89
        '
        'txtbxEmployeeName
        '
        Me.txtbxEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxEmployeeName.BackColor = System.Drawing.Color.Transparent
        Me.txtbxEmployeeName.BorderRadius = 10
        Me.txtbxEmployeeName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxEmployeeName.DefaultText = ""
        Me.txtbxEmployeeName.Enabled = False
        Me.txtbxEmployeeName.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmployeeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxEmployeeName.Location = New System.Drawing.Point(198, 130)
        Me.txtbxEmployeeName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxEmployeeName.Name = "txtbxEmployeeName"
        Me.txtbxEmployeeName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxEmployeeName.PlaceholderText = ""
        Me.txtbxEmployeeName.SelectedText = ""
        Me.txtbxEmployeeName.Size = New System.Drawing.Size(297, 29)
        Me.txtbxEmployeeName.TabIndex = 88
        '
        'txtbxSSS
        '
        Me.txtbxSSS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxSSS.BackColor = System.Drawing.Color.Transparent
        Me.txtbxSSS.BorderRadius = 10
        Me.txtbxSSS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxSSS.DefaultText = "0"
        Me.txtbxSSS.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSSS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxSSS.Location = New System.Drawing.Point(635, 77)
        Me.txtbxSSS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxSSS.Name = "txtbxSSS"
        Me.txtbxSSS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxSSS.PlaceholderText = "Enter SSS tax here"
        Me.txtbxSSS.SelectedText = ""
        Me.txtbxSSS.Size = New System.Drawing.Size(178, 29)
        Me.txtbxSSS.TabIndex = 87
        Me.txtbxSSS.Tag = "0"
        '
        'txtbxEmployeeID
        '
        Me.txtbxEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxEmployeeID.BackColor = System.Drawing.Color.Transparent
        Me.txtbxEmployeeID.BorderRadius = 10
        Me.txtbxEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxEmployeeID.DefaultText = ""
        Me.txtbxEmployeeID.Enabled = False
        Me.txtbxEmployeeID.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmployeeID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxEmployeeID.Location = New System.Drawing.Point(198, 80)
        Me.txtbxEmployeeID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxEmployeeID.Name = "txtbxEmployeeID"
        Me.txtbxEmployeeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxEmployeeID.PlaceholderText = ""
        Me.txtbxEmployeeID.SelectedText = ""
        Me.txtbxEmployeeID.Size = New System.Drawing.Size(131, 29)
        Me.txtbxEmployeeID.TabIndex = 86
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel2.Location = New System.Drawing.Point(20, 450)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(870, 278)
        Me.Guna2Panel2.TabIndex = 62
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(850, 258)
        Me.FlowLayoutPanel1.TabIndex = 61
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel3.Controls.Add(Me.Label19)
        Me.Guna2Panel3.Controls.Add(Me.Label18)
        Me.Guna2Panel3.Controls.Add(Me.Label17)
        Me.Guna2Panel3.Controls.Add(Me.Guna2DateTimePicker2)
        Me.Guna2Panel3.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel3.Location = New System.Drawing.Point(910, 10)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(237, 210)
        Me.Guna2Panel3.TabIndex = 63
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 21)
        Me.Label19.TabIndex = 113
        Me.Label19.Text = "Filter"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(20, 130)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 21)
        Me.Label18.TabIndex = 112
        Me.Label18.Text = "To"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 21)
        Me.Label17.TabIndex = 111
        Me.Label17.Text = "From"
        '
        'Guna2DateTimePicker2
        '
        Me.Guna2DateTimePicker2.BorderRadius = 10
        Me.Guna2DateTimePicker2.Checked = True
        Me.Guna2DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker2.Location = New System.Drawing.Point(10, 160)
        Me.Guna2DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.Name = "Guna2DateTimePicker2"
        Me.Guna2DateTimePicker2.Size = New System.Drawing.Size(220, 36)
        Me.Guna2DateTimePicker2.TabIndex = 1
        Me.Guna2DateTimePicker2.Value = New Date(2025, 10, 25, 14, 47, 59, 30)
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.BorderRadius = 10
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(10, 80)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(220, 36)
        Me.Guna2DateTimePicker1.TabIndex = 0
        Me.Guna2DateTimePicker1.Value = New Date(2025, 10, 25, 14, 47, 57, 341)
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 10
        Me.Guna2Panel4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel4.Controls.Add(Me.btnSearchEmployee)
        Me.Guna2Panel4.Controls.Add(Me.txtbxSearchEmployee)
        Me.Guna2Panel4.Controls.Add(Me.Label21)
        Me.Guna2Panel4.Controls.Add(Me.cmbbxFilterByDept)
        Me.Guna2Panel4.Controls.Add(Me.Label20)
        Me.Guna2Panel4.Controls.Add(Me.Label22)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel4.Location = New System.Drawing.Point(910, 450)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(237, 278)
        Me.Guna2Panel4.TabIndex = 114
        '
        'btnSearchEmployee
        '
        Me.btnSearchEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSearchEmployee.Animated = True
        Me.btnSearchEmployee.BorderRadius = 10
        Me.btnSearchEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchEmployee.FillColor = System.Drawing.Color.LimeGreen
        Me.btnSearchEmployee.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearchEmployee.ForeColor = System.Drawing.Color.White
        Me.btnSearchEmployee.Location = New System.Drawing.Point(140, 130)
        Me.btnSearchEmployee.Name = "btnSearchEmployee"
        Me.btnSearchEmployee.Size = New System.Drawing.Size(80, 30)
        Me.btnSearchEmployee.TabIndex = 117
        Me.btnSearchEmployee.Text = "Search"
        '
        'txtbxSearchEmployee
        '
        Me.txtbxSearchEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtbxSearchEmployee.BorderRadius = 10
        Me.txtbxSearchEmployee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxSearchEmployee.DefaultText = ""
        Me.txtbxSearchEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxSearchEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxSearchEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxSearchEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxSearchEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxSearchEmployee.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtbxSearchEmployee.ForeColor = System.Drawing.Color.Black
        Me.txtbxSearchEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxSearchEmployee.Location = New System.Drawing.Point(20, 90)
        Me.txtbxSearchEmployee.Name = "txtbxSearchEmployee"
        Me.txtbxSearchEmployee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxSearchEmployee.PlaceholderText = "Search name"
        Me.txtbxSearchEmployee.SelectedText = ""
        Me.txtbxSearchEmployee.Size = New System.Drawing.Size(200, 30)
        Me.txtbxSearchEmployee.TabIndex = 116
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(20, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 21)
        Me.Label21.TabIndex = 115
        Me.Label21.Text = "Search name"
        '
        'cmbbxFilterByDept
        '
        Me.cmbbxFilterByDept.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbbxFilterByDept.BackColor = System.Drawing.Color.Transparent
        Me.cmbbxFilterByDept.BorderRadius = 10
        Me.cmbbxFilterByDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbbxFilterByDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxFilterByDept.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbbxFilterByDept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbbxFilterByDept.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbbxFilterByDept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbbxFilterByDept.ItemHeight = 30
        Me.cmbbxFilterByDept.Items.AddRange(New Object() {"IT Consultant", "Accountant", "HR Employee", "Manager"})
        Me.cmbbxFilterByDept.Location = New System.Drawing.Point(20, 204)
        Me.cmbbxFilterByDept.Name = "cmbbxFilterByDept"
        Me.cmbbxFilterByDept.Size = New System.Drawing.Size(203, 36)
        Me.cmbbxFilterByDept.TabIndex = 114
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(123, 21)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "Filter Employee"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(18, 182)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(160, 21)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = "Filter by department"
        '
        'GeneratePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.pnlPayrollForm)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "GeneratePayroll"
        Me.Size = New System.Drawing.Size(1174, 741)
        CType(Me.DGV_EmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlPayrollForm.ResumeLayout(False)
        Me.pnlPayrollForm.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_EmployeeList As DataGridView
    Friend WithEvents Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTotalPayroll As Label
    Friend WithEvents Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPendingPayroll As Label
    Friend WithEvents pnlPayrollForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGeneratePayroll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbxDepartment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxNetSalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxOverTime As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxGrossSalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxTotalHours As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxPagIBIG As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxEmailAddr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxPhilHealth As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxEmployeeName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxSSS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxEmployeeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbbxFilterByDept As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btnSearchEmployee As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtbxSearchEmployee As Guna.UI2.WinForms.Guna2TextBox
End Class
