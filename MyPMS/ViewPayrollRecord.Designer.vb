<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewPayrollRecord
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbbxDepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbbxSalaryRange = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblPendingPayroll = New System.Windows.Forms.Label()
        Me.Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalPayroll = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(25, 157)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 2, 8, 8)
        Me.Guna2Panel1.Size = New System.Drawing.Size(868, 518)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Payroll records"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(14, 47)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(839, 459)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filter"
        '
        'cmbbxDepartment
        '
        Me.cmbbxDepartment.BackColor = System.Drawing.Color.Transparent
        Me.cmbbxDepartment.BorderRadius = 10
        Me.cmbbxDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxDepartment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbbxDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbbxDepartment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbbxDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbbxDepartment.ItemHeight = 30
        Me.cmbbxDepartment.Items.AddRange(New Object() {"IT Consultant", "Accountant", "HR Employee", "Manager"})
        Me.cmbbxDepartment.Location = New System.Drawing.Point(18, 89)
        Me.cmbbxDepartment.Name = "cmbbxDepartment"
        Me.cmbbxDepartment.ShadowDecoration.BorderRadius = 4
        Me.cmbbxDepartment.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.cmbbxDepartment.ShadowDecoration.Depth = 10
        Me.cmbbxDepartment.ShadowDecoration.Enabled = True
        Me.cmbbxDepartment.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 6, 6)
        Me.cmbbxDepartment.Size = New System.Drawing.Size(185, 36)
        Me.cmbbxDepartment.TabIndex = 2
        '
        'cmbbxSalaryRange
        '
        Me.cmbbxSalaryRange.BackColor = System.Drawing.Color.Transparent
        Me.cmbbxSalaryRange.BorderRadius = 10
        Me.cmbbxSalaryRange.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbbxSalaryRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxSalaryRange.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbbxSalaryRange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbbxSalaryRange.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbbxSalaryRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbbxSalaryRange.ItemHeight = 30
        Me.cmbbxSalaryRange.Items.AddRange(New Object() {"0-10000", "10000-20000", "20000-30000", "30000-40000", "40000-50000", "50000-Above"})
        Me.cmbbxSalaryRange.Location = New System.Drawing.Point(18, 184)
        Me.cmbbxSalaryRange.Name = "cmbbxSalaryRange"
        Me.cmbbxSalaryRange.ShadowDecoration.BorderRadius = 4
        Me.cmbbxSalaryRange.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.cmbbxSalaryRange.ShadowDecoration.Depth = 10
        Me.cmbbxSalaryRange.ShadowDecoration.Enabled = True
        Me.cmbbxSalaryRange.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 6, 6)
        Me.cmbbxSalaryRange.Size = New System.Drawing.Size(185, 36)
        Me.cmbbxSalaryRange.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Salary range"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.cmbbxSalaryRange)
        Me.Guna2Panel2.Controls.Add(Me.cmbbxDepartment)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(923, 378)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.BorderRadius = 4
        Me.Guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 2, 8, 8)
        Me.Guna2Panel2.Size = New System.Drawing.Size(237, 297)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'txtbxSearch
        '
        Me.txtbxSearch.BackColor = System.Drawing.Color.Transparent
        Me.txtbxSearch.BorderRadius = 10
        Me.txtbxSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxSearch.DefaultText = ""
        Me.txtbxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxSearch.Location = New System.Drawing.Point(21, 44)
        Me.txtbxSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxSearch.PlaceholderText = "Search here"
        Me.txtbxSearch.SelectedText = ""
        Me.txtbxSearch.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.txtbxSearch.ShadowDecoration.Depth = 10
        Me.txtbxSearch.ShadowDecoration.Enabled = True
        Me.txtbxSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 6, 6)
        Me.txtbxSearch.Size = New System.Drawing.Size(383, 37)
        Me.txtbxSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BorderRadius = 10
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.LimeGreen
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(411, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.BorderRadius = 10
        Me.btnSearch.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.btnSearch.ShadowDecoration.Depth = 8
        Me.btnSearch.ShadowDecoration.Enabled = True
        Me.btnSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 6, 6)
        Me.btnSearch.Size = New System.Drawing.Size(93, 37)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.Controls.Add(Me.btnSearch)
        Me.Guna2Panel3.Controls.Add(Me.txtbxSearch)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(25, 22)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.Guna2Panel3.ShadowDecoration.Enabled = True
        Me.Guna2Panel3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 2, 8, 8)
        Me.Guna2Panel3.Size = New System.Drawing.Size(868, 109)
        Me.Guna2Panel3.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1143, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(17, 19)
        Me.DataGridView1.TabIndex = 3
        Me.DataGridView1.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.FillColor = System.Drawing.Color.Salmon
        Me.Panel4.Location = New System.Drawing.Point(923, 263)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 44)
        Me.Panel4.TabIndex = 63
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
        Me.Panel5.FillColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(923, 264)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.ShadowDecoration.Depth = 10
        Me.Panel5.ShadowDecoration.Enabled = True
        Me.Panel5.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 6, 6)
        Me.Panel5.Size = New System.Drawing.Size(237, 83)
        Me.Panel5.TabIndex = 62
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
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.LightGreen
        Me.Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(923, 157)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(237, 44)
        Me.Panel3.TabIndex = 61
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
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderRadius = 10
        Me.Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Panel2.Controls.Add(Me.lblTotalPayroll)
        Me.Panel2.FillColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(923, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.ShadowDecoration.Depth = 10
        Me.Panel2.ShadowDecoration.Enabled = True
        Me.Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 6, 6)
        Me.Panel2.Size = New System.Drawing.Size(237, 83)
        Me.Panel2.TabIndex = 60
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
        'ViewPayrollRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "ViewPayrollRecord"
        Me.Size = New System.Drawing.Size(1174, 741)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbbxDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbbxSalaryRange As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPendingPayroll As Label
    Friend WithEvents Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalPayroll As Label
    Friend WithEvents Label5 As Label
End Class
