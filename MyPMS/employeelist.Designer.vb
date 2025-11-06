<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employeelist
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbxSearchEmployee = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbbxFilterByDept = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbxEmployeeID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxContactNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxEmailAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dateBirthDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dateHireDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbbxDepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtbxStatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnViewArchive = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnArchive = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtbxSalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtbxSearchEmployee)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.cmbbxFilterByDept)
        Me.Panel3.Location = New System.Drawing.Point(26, 400)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1301, 312)
        Me.Panel3.TabIndex = 29
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BorderRadius = 10
        Me.btnSearch.FillColor = System.Drawing.Color.SpringGreen
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(477, 16)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.BorderRadius = 10
        Me.btnSearch.ShadowDecoration.Enabled = True
        Me.btnSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.btnSearch.Size = New System.Drawing.Size(110, 38)
        Me.btnSearch.TabIndex = 73
        Me.btnSearch.Text = "Search"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 21)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Search"
        '
        'txtbxSearchEmployee
        '
        Me.txtbxSearchEmployee.BackColor = System.Drawing.Color.Transparent
        Me.txtbxSearchEmployee.BorderRadius = 10
        Me.txtbxSearchEmployee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxSearchEmployee.DefaultText = ""
        Me.txtbxSearchEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxSearchEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxSearchEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxSearchEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxSearchEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxSearchEmployee.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxSearchEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbxSearchEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxSearchEmployee.Location = New System.Drawing.Point(93, 17)
        Me.txtbxSearchEmployee.Name = "txtbxSearchEmployee"
        Me.txtbxSearchEmployee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxSearchEmployee.PlaceholderText = ""
        Me.txtbxSearchEmployee.SelectedText = ""
        Me.txtbxSearchEmployee.ShadowDecoration.BorderRadius = 10
        Me.txtbxSearchEmployee.ShadowDecoration.Enabled = True
        Me.txtbxSearchEmployee.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.txtbxSearchEmployee.Size = New System.Drawing.Size(363, 34)
        Me.txtbxSearchEmployee.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(839, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 21)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Filter by Department"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 76)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1261, 218)
        Me.DataGridView1.TabIndex = 75
        '
        'cmbbxFilterByDept
        '
        Me.cmbbxFilterByDept.BackColor = System.Drawing.Color.Transparent
        Me.cmbbxFilterByDept.BorderRadius = 10
        Me.cmbbxFilterByDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbbxFilterByDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxFilterByDept.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbbxFilterByDept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbbxFilterByDept.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbbxFilterByDept.ForeColor = System.Drawing.Color.Black
        Me.cmbbxFilterByDept.ItemHeight = 30
        Me.cmbbxFilterByDept.Location = New System.Drawing.Point(1007, 15)
        Me.cmbbxFilterByDept.Name = "cmbbxFilterByDept"
        Me.cmbbxFilterByDept.ShadowDecoration.BorderRadius = 10
        Me.cmbbxFilterByDept.ShadowDecoration.Enabled = True
        Me.cmbbxFilterByDept.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.cmbbxFilterByDept.Size = New System.Drawing.Size(210, 36)
        Me.cmbbxFilterByDept.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(37, 23)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 37)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Employee list"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(324, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 21)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Contact no."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(326, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 21)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Email address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Department"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Employee name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 21)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(326, 181)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 21)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Civil Status"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(572, 93)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 21)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Birth date"
        '
        'txtbxEmployeeID
        '
        Me.txtbxEmployeeID.BackColor = System.Drawing.Color.Transparent
        Me.txtbxEmployeeID.BorderRadius = 10
        Me.txtbxEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxEmployeeID.DefaultText = ""
        Me.txtbxEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxEmployeeID.Enabled = False
        Me.txtbxEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxEmployeeID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxEmployeeID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbxEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxEmployeeID.Location = New System.Drawing.Point(21, 43)
        Me.txtbxEmployeeID.Name = "txtbxEmployeeID"
        Me.txtbxEmployeeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxEmployeeID.PlaceholderText = ""
        Me.txtbxEmployeeID.SelectedText = ""
        Me.txtbxEmployeeID.ShadowDecoration.BorderRadius = 10
        Me.txtbxEmployeeID.ShadowDecoration.Enabled = True
        Me.txtbxEmployeeID.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.txtbxEmployeeID.Size = New System.Drawing.Size(177, 34)
        Me.txtbxEmployeeID.TabIndex = 49
        '
        'txtbxName
        '
        Me.txtbxName.BackColor = System.Drawing.Color.Transparent
        Me.txtbxName.BorderRadius = 10
        Me.txtbxName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxName.DefaultText = ""
        Me.txtbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxName.Location = New System.Drawing.Point(19, 123)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxName.PlaceholderText = ""
        Me.txtbxName.SelectedText = ""
        Me.txtbxName.ShadowDecoration.BorderRadius = 10
        Me.txtbxName.ShadowDecoration.Enabled = True
        Me.txtbxName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.txtbxName.Size = New System.Drawing.Size(267, 34)
        Me.txtbxName.TabIndex = 50
        '
        'txtbxContactNo
        '
        Me.txtbxContactNo.BackColor = System.Drawing.Color.Transparent
        Me.txtbxContactNo.BorderRadius = 10
        Me.txtbxContactNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxContactNo.DefaultText = ""
        Me.txtbxContactNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxContactNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxContactNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxContactNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxContactNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxContactNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxContactNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbxContactNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxContactNo.Location = New System.Drawing.Point(313, 123)
        Me.txtbxContactNo.Name = "txtbxContactNo"
        Me.txtbxContactNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxContactNo.PlaceholderText = ""
        Me.txtbxContactNo.SelectedText = ""
        Me.txtbxContactNo.ShadowDecoration.BorderRadius = 10
        Me.txtbxContactNo.ShadowDecoration.Enabled = True
        Me.txtbxContactNo.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.txtbxContactNo.Size = New System.Drawing.Size(200, 34)
        Me.txtbxContactNo.TabIndex = 53
        '
        'txtbxEmailAddress
        '
        Me.txtbxEmailAddress.BackColor = System.Drawing.Color.Transparent
        Me.txtbxEmailAddress.BorderRadius = 10
        Me.txtbxEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxEmailAddress.DefaultText = ""
        Me.txtbxEmailAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxEmailAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxEmailAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxEmailAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxEmailAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxEmailAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxEmailAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbxEmailAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxEmailAddress.Location = New System.Drawing.Point(313, 43)
        Me.txtbxEmailAddress.Name = "txtbxEmailAddress"
        Me.txtbxEmailAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxEmailAddress.PlaceholderText = ""
        Me.txtbxEmailAddress.SelectedText = ""
        Me.txtbxEmailAddress.ShadowDecoration.BorderRadius = 10
        Me.txtbxEmailAddress.ShadowDecoration.Enabled = True
        Me.txtbxEmailAddress.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.txtbxEmailAddress.Size = New System.Drawing.Size(200, 34)
        Me.txtbxEmailAddress.TabIndex = 54
        '
        'dateBirthDate
        '
        Me.dateBirthDate.BackColor = System.Drawing.Color.Transparent
        Me.dateBirthDate.BorderRadius = 10
        Me.dateBirthDate.Checked = True
        Me.dateBirthDate.FillColor = System.Drawing.Color.White
        Me.dateBirthDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateBirthDate.Location = New System.Drawing.Point(557, 117)
        Me.dateBirthDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateBirthDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateBirthDate.Name = "dateBirthDate"
        Me.dateBirthDate.ShadowDecoration.BorderRadius = 10
        Me.dateBirthDate.ShadowDecoration.Enabled = True
        Me.dateBirthDate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.dateBirthDate.Size = New System.Drawing.Size(228, 36)
        Me.dateBirthDate.TabIndex = 56
        Me.dateBirthDate.Value = New Date(2025, 11, 5, 21, 25, 33, 854)
        '
        'dateHireDate
        '
        Me.dateHireDate.BackColor = System.Drawing.Color.Transparent
        Me.dateHireDate.BorderRadius = 10
        Me.dateHireDate.Checked = True
        Me.dateHireDate.FillColor = System.Drawing.Color.White
        Me.dateHireDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateHireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateHireDate.Location = New System.Drawing.Point(557, 203)
        Me.dateHireDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateHireDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateHireDate.Name = "dateHireDate"
        Me.dateHireDate.ShadowDecoration.BorderRadius = 10
        Me.dateHireDate.ShadowDecoration.Enabled = True
        Me.dateHireDate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.dateHireDate.Size = New System.Drawing.Size(228, 36)
        Me.dateHireDate.TabIndex = 58
        Me.dateHireDate.Value = New Date(2025, 11, 5, 21, 25, 33, 854)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(572, 179)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 21)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Hire date"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.Controls.Add(Me.cmbbxDepartment)
        Me.Guna2Panel1.Controls.Add(Me.txtbxStatus)
        Me.Guna2Panel1.Controls.Add(Me.btnViewArchive)
        Me.Guna2Panel1.Controls.Add(Me.btnCancel)
        Me.Guna2Panel1.Controls.Add(Me.btnArchive)
        Me.Guna2Panel1.Controls.Add(Me.btnSave)
        Me.Guna2Panel1.Controls.Add(Me.txtbxSalary)
        Me.Guna2Panel1.Controls.Add(Me.Label15)
        Me.Guna2Panel1.Controls.Add(Me.dateHireDate)
        Me.Guna2Panel1.Controls.Add(Me.Label13)
        Me.Guna2Panel1.Controls.Add(Me.dateBirthDate)
        Me.Guna2Panel1.Controls.Add(Me.txtbxEmailAddress)
        Me.Guna2Panel1.Controls.Add(Me.txtbxContactNo)
        Me.Guna2Panel1.Controls.Add(Me.txtbxName)
        Me.Guna2Panel1.Controls.Add(Me.txtbxEmployeeID)
        Me.Guna2Panel1.Controls.Add(Me.Label12)
        Me.Guna2Panel1.Controls.Add(Me.Label11)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(26, 74)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1301, 282)
        Me.Guna2Panel1.TabIndex = 59
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
        Me.cmbbxDepartment.ForeColor = System.Drawing.Color.Black
        Me.cmbbxDepartment.ItemHeight = 30
        Me.cmbbxDepartment.Location = New System.Drawing.Point(18, 205)
        Me.cmbbxDepartment.Name = "cmbbxDepartment"
        Me.cmbbxDepartment.ShadowDecoration.BorderRadius = 10
        Me.cmbbxDepartment.ShadowDecoration.Enabled = True
        Me.cmbbxDepartment.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.cmbbxDepartment.Size = New System.Drawing.Size(248, 36)
        Me.cmbbxDepartment.TabIndex = 72
        '
        'txtbxStatus
        '
        Me.txtbxStatus.BackColor = System.Drawing.Color.Transparent
        Me.txtbxStatus.BorderRadius = 10
        Me.txtbxStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxStatus.DefaultText = ""
        Me.txtbxStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbxStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxStatus.Location = New System.Drawing.Point(313, 205)
        Me.txtbxStatus.Name = "txtbxStatus"
        Me.txtbxStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxStatus.PlaceholderText = ""
        Me.txtbxStatus.SelectedText = ""
        Me.txtbxStatus.ShadowDecoration.BorderRadius = 10
        Me.txtbxStatus.ShadowDecoration.Enabled = True
        Me.txtbxStatus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.txtbxStatus.Size = New System.Drawing.Size(200, 34)
        Me.txtbxStatus.TabIndex = 71
        '
        'btnViewArchive
        '
        Me.btnViewArchive.BackColor = System.Drawing.Color.Transparent
        Me.btnViewArchive.BorderRadius = 10
        Me.btnViewArchive.FillColor = System.Drawing.Color.Gold
        Me.btnViewArchive.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewArchive.ForeColor = System.Drawing.Color.Black
        Me.btnViewArchive.Location = New System.Drawing.Point(1162, 37)
        Me.btnViewArchive.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewArchive.Name = "btnViewArchive"
        Me.btnViewArchive.ShadowDecoration.BorderRadius = 10
        Me.btnViewArchive.ShadowDecoration.Enabled = True
        Me.btnViewArchive.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.btnViewArchive.Size = New System.Drawing.Size(110, 38)
        Me.btnViewArchive.TabIndex = 70
        Me.btnViewArchive.Text = "View Archive"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.FillColor = System.Drawing.Color.Gray
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(1162, 205)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.BorderRadius = 10
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.btnCancel.Size = New System.Drawing.Size(110, 38)
        Me.btnCancel.TabIndex = 69
        Me.btnCancel.Text = "Clear"
        '
        'btnArchive
        '
        Me.btnArchive.BackColor = System.Drawing.Color.Transparent
        Me.btnArchive.BorderRadius = 10
        Me.btnArchive.FillColor = System.Drawing.Color.Gold
        Me.btnArchive.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchive.ForeColor = System.Drawing.Color.Black
        Me.btnArchive.Location = New System.Drawing.Point(1162, 147)
        Me.btnArchive.Margin = New System.Windows.Forms.Padding(4)
        Me.btnArchive.Name = "btnArchive"
        Me.btnArchive.ShadowDecoration.BorderRadius = 10
        Me.btnArchive.ShadowDecoration.Enabled = True
        Me.btnArchive.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.btnArchive.Size = New System.Drawing.Size(110, 38)
        Me.btnArchive.TabIndex = 68
        Me.btnArchive.Text = "Archive"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 10
        Me.btnSave.FillColor = System.Drawing.Color.SpringGreen
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(1162, 89)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.BorderRadius = 10
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.btnSave.Size = New System.Drawing.Size(110, 38)
        Me.btnSave.TabIndex = 67
        Me.btnSave.Text = "Save"
        '
        'txtbxSalary
        '
        Me.txtbxSalary.BackColor = System.Drawing.Color.Transparent
        Me.txtbxSalary.BorderRadius = 10
        Me.txtbxSalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxSalary.DefaultText = ""
        Me.txtbxSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxSalary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbxSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxSalary.Location = New System.Drawing.Point(559, 45)
        Me.txtbxSalary.Name = "txtbxSalary"
        Me.txtbxSalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxSalary.PlaceholderText = ""
        Me.txtbxSalary.SelectedText = ""
        Me.txtbxSalary.ShadowDecoration.BorderRadius = 10
        Me.txtbxSalary.ShadowDecoration.Enabled = True
        Me.txtbxSalary.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 5, 5)
        Me.txtbxSalary.Size = New System.Drawing.Size(200, 34)
        Me.txtbxSalary.TabIndex = 66
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(572, 19)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 21)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Salary"
        '
        'employeelist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "employeelist"
        Me.Size = New System.Drawing.Size(1360, 732)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbxEmployeeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxContactNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxEmailAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dateBirthDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dateHireDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtbxSalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnViewArchive As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnArchive As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtbxStatus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbbxDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbbxFilterByDept As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbxSearchEmployee As Guna.UI2.WinForms.Guna2TextBox
End Class
