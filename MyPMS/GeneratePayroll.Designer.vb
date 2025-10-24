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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGeneratePayroll = New System.Windows.Forms.Button()
        Me.txtbxNetSalary = New System.Windows.Forms.TextBox()
        Me.txtbxOverTime = New System.Windows.Forms.TextBox()
        Me.txtbxGrossSalary = New System.Windows.Forms.TextBox()
        Me.txtbxTotalHours = New System.Windows.Forms.TextBox()
        Me.txtbxPagIBIG = New System.Windows.Forms.TextBox()
        Me.txtbxEmailAddr = New System.Windows.Forms.TextBox()
        Me.txtbxPhilHealth = New System.Windows.Forms.TextBox()
        Me.txtbxEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtbxSSS = New System.Windows.Forms.TextBox()
        Me.txtbxEmployeeID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.DGV_EmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.DGV_EmployeeList.Location = New System.Drawing.Point(980, 220)
        Me.DGV_EmployeeList.Name = "DGV_EmployeeList"
        Me.DGV_EmployeeList.Size = New System.Drawing.Size(159, 209)
        Me.DGV_EmployeeList.TabIndex = 7
        Me.DGV_EmployeeList.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnGeneratePayroll)
        Me.Panel1.Controls.Add(Me.txtbxNetSalary)
        Me.Panel1.Controls.Add(Me.txtbxOverTime)
        Me.Panel1.Controls.Add(Me.txtbxGrossSalary)
        Me.Panel1.Controls.Add(Me.txtbxTotalHours)
        Me.Panel1.Controls.Add(Me.txtbxPagIBIG)
        Me.Panel1.Controls.Add(Me.txtbxEmailAddr)
        Me.Panel1.Controls.Add(Me.txtbxPhilHealth)
        Me.Panel1.Controls.Add(Me.txtbxEmployeeName)
        Me.Panel1.Controls.Add(Me.txtbxSSS)
        Me.Panel1.Controls.Add(Me.txtbxEmployeeID)
        Me.Panel1.Location = New System.Drawing.Point(20, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(823, 432)
        Me.Panel1.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 30)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Generate Payroll"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(523, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 21)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Net Salary"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(509, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 21)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Gross Salary"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(533, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 21)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Pag-IBIG"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(523, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 21)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "PhilHealth"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(567, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 21)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "SSS"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Overtime"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 21)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Total of Hours"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 21)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Email address"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(173, 179)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 29)
        Me.TextBox1.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Department"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 21)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Employee ID"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(698, 360)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 47)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnGeneratePayroll
        '
        Me.btnGeneratePayroll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGeneratePayroll.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGeneratePayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneratePayroll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneratePayroll.Location = New System.Drawing.Point(570, 360)
        Me.btnGeneratePayroll.Name = "btnGeneratePayroll"
        Me.btnGeneratePayroll.Size = New System.Drawing.Size(113, 47)
        Me.btnGeneratePayroll.TabIndex = 43
        Me.btnGeneratePayroll.Text = "Generate Payroll"
        Me.btnGeneratePayroll.UseVisualStyleBackColor = False
        '
        'txtbxNetSalary
        '
        Me.txtbxNetSalary.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxNetSalary.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxNetSalary.Location = New System.Drawing.Point(610, 276)
        Me.txtbxNetSalary.Name = "txtbxNetSalary"
        Me.txtbxNetSalary.Size = New System.Drawing.Size(178, 29)
        Me.txtbxNetSalary.TabIndex = 41
        '
        'txtbxOverTime
        '
        Me.txtbxOverTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxOverTime.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxOverTime.Location = New System.Drawing.Point(173, 322)
        Me.txtbxOverTime.Name = "txtbxOverTime"
        Me.txtbxOverTime.Size = New System.Drawing.Size(131, 29)
        Me.txtbxOverTime.TabIndex = 40
        '
        'txtbxGrossSalary
        '
        Me.txtbxGrossSalary.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxGrossSalary.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxGrossSalary.Location = New System.Drawing.Point(610, 226)
        Me.txtbxGrossSalary.Name = "txtbxGrossSalary"
        Me.txtbxGrossSalary.Size = New System.Drawing.Size(178, 29)
        Me.txtbxGrossSalary.TabIndex = 39
        '
        'txtbxTotalHours
        '
        Me.txtbxTotalHours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxTotalHours.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTotalHours.Location = New System.Drawing.Point(173, 272)
        Me.txtbxTotalHours.Name = "txtbxTotalHours"
        Me.txtbxTotalHours.Size = New System.Drawing.Size(131, 29)
        Me.txtbxTotalHours.TabIndex = 38
        '
        'txtbxPagIBIG
        '
        Me.txtbxPagIBIG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxPagIBIG.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPagIBIG.Location = New System.Drawing.Point(610, 176)
        Me.txtbxPagIBIG.Name = "txtbxPagIBIG"
        Me.txtbxPagIBIG.Size = New System.Drawing.Size(178, 29)
        Me.txtbxPagIBIG.TabIndex = 37
        '
        'txtbxEmailAddr
        '
        Me.txtbxEmailAddr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxEmailAddr.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmailAddr.Location = New System.Drawing.Point(173, 223)
        Me.txtbxEmailAddr.Name = "txtbxEmailAddr"
        Me.txtbxEmailAddr.Size = New System.Drawing.Size(233, 29)
        Me.txtbxEmailAddr.TabIndex = 36
        '
        'txtbxPhilHealth
        '
        Me.txtbxPhilHealth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxPhilHealth.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPhilHealth.Location = New System.Drawing.Point(610, 126)
        Me.txtbxPhilHealth.Name = "txtbxPhilHealth"
        Me.txtbxPhilHealth.Size = New System.Drawing.Size(178, 29)
        Me.txtbxPhilHealth.TabIndex = 35
        '
        'txtbxEmployeeName
        '
        Me.txtbxEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxEmployeeName.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmployeeName.Location = New System.Drawing.Point(173, 129)
        Me.txtbxEmployeeName.Name = "txtbxEmployeeName"
        Me.txtbxEmployeeName.Size = New System.Drawing.Size(297, 29)
        Me.txtbxEmployeeName.TabIndex = 34
        '
        'txtbxSSS
        '
        Me.txtbxSSS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxSSS.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSSS.Location = New System.Drawing.Point(610, 76)
        Me.txtbxSSS.Name = "txtbxSSS"
        Me.txtbxSSS.Size = New System.Drawing.Size(178, 29)
        Me.txtbxSSS.TabIndex = 33
        '
        'txtbxEmployeeID
        '
        Me.txtbxEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxEmployeeID.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmployeeID.Location = New System.Drawing.Point(173, 79)
        Me.txtbxEmployeeID.Name = "txtbxEmployeeID"
        Me.txtbxEmployeeID.Size = New System.Drawing.Size(131, 29)
        Me.txtbxEmployeeID.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(906, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 83)
        Me.Panel2.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(103, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 30)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "23"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.LightGreen
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(906, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(237, 44)
        Me.Panel3.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(60, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 21)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Total of Payroll"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Salmon
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Location = New System.Drawing.Point(906, 110)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 44)
        Me.Panel4.TabIndex = 59
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(182, 21)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Total of Pending payroll"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(906, 110)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(237, 83)
        Me.Panel5.TabIndex = 58
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(107, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 30)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "5"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(20, 460)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1120, 220)
        Me.FlowLayoutPanel1.TabIndex = 60
        '
        'GeneratePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV_EmployeeList)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "GeneratePayroll"
        Me.Size = New System.Drawing.Size(1174, 693)
        CType(Me.DGV_EmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_EmployeeList As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnGeneratePayroll As Button
    Friend WithEvents txtbxNetSalary As TextBox
    Friend WithEvents txtbxOverTime As TextBox
    Friend WithEvents txtbxGrossSalary As TextBox
    Friend WithEvents txtbxTotalHours As TextBox
    Friend WithEvents txtbxPagIBIG As TextBox
    Friend WithEvents txtbxEmailAddr As TextBox
    Friend WithEvents txtbxPhilHealth As TextBox
    Friend WithEvents txtbxEmployeeName As TextBox
    Friend WithEvents txtbxSSS As TextBox
    Friend WithEvents txtbxEmployeeID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
