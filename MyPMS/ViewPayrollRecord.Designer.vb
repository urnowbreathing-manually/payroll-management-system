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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbbxDepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbbxSalaryRange = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbbxEwan = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 10
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
        Me.cmbbxDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbbxDepartment.ItemHeight = 30
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
        Me.cmbbxSalaryRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbbxSalaryRange.ItemHeight = 30
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
        'cmbbxEwan
        '
        Me.cmbbxEwan.BackColor = System.Drawing.Color.Transparent
        Me.cmbbxEwan.BorderRadius = 10
        Me.cmbbxEwan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbbxEwan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxEwan.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbbxEwan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbbxEwan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbbxEwan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbbxEwan.ItemHeight = 30
        Me.cmbbxEwan.Location = New System.Drawing.Point(18, 277)
        Me.cmbbxEwan.Name = "cmbbxEwan"
        Me.cmbbxEwan.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.cmbbxEwan.ShadowDecoration.Depth = 10
        Me.cmbbxEwan.ShadowDecoration.Enabled = True
        Me.cmbbxEwan.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 6, 6)
        Me.cmbbxEwan.Size = New System.Drawing.Size(185, 36)
        Me.cmbbxEwan.TabIndex = 4
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Filter"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.cmbbxEwan)
        Me.Guna2Panel2.Controls.Add(Me.cmbbxSalaryRange)
        Me.Guna2Panel2.Controls.Add(Me.cmbbxDepartment)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(922, 157)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.BorderRadius = 4
        Me.Guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 2, 8, 8)
        Me.Guna2Panel2.Size = New System.Drawing.Size(217, 433)
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
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.LimeGreen
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(411, 44)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 10
        Me.Guna2Button1.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.Guna2Button1.ShadowDecoration.Depth = 8
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 6, 6)
        Me.Guna2Button1.Size = New System.Drawing.Size(93, 37)
        Me.Guna2Button1.TabIndex = 2
        Me.Guna2Button1.Text = "Search"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.Controls.Add(Me.Guna2Button1)
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
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(14, 15)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(839, 491)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1156, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(15, 12)
        Me.DataGridView1.TabIndex = 3
        '
        'ViewPayrollRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "ViewPayrollRecord"
        Me.Size = New System.Drawing.Size(1174, 741)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbbxDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbbxSalaryRange As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbbxEwan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
End Class
