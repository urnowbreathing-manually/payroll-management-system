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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnGeneratePayroll = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.DGV_EmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_EmployeeList
        '
        Me.DGV_EmployeeList.AllowUserToAddRows = False
        Me.DGV_EmployeeList.AllowUserToDeleteRows = False
        Me.DGV_EmployeeList.AllowUserToResizeRows = False
        Me.DGV_EmployeeList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGV_EmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_EmployeeList.BackgroundColor = System.Drawing.Color.MediumAquamarine
        Me.DGV_EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_EmployeeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpList_ID, Me.EmpList_EmpName, Me.EmpList_Salary, Me.EmpList_TotalHrs, Me.EmpList_Overtime})
        Me.DGV_EmployeeList.Location = New System.Drawing.Point(20, 350)
        Me.DGV_EmployeeList.Name = "DGV_EmployeeList"
        Me.DGV_EmployeeList.Size = New System.Drawing.Size(799, 190)
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox11, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox10, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox9, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox8, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox7, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox6, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnGeneratePayroll, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 2, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(799, 303)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox11.Location = New System.Drawing.Point(162, 263)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(233, 26)
        Me.TextBox11.TabIndex = 20
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox10.Location = New System.Drawing.Point(560, 212)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(236, 26)
        Me.TextBox10.TabIndex = 19
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox9.Location = New System.Drawing.Point(162, 212)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(233, 26)
        Me.TextBox9.TabIndex = 18
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox8.Location = New System.Drawing.Point(560, 162)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(236, 26)
        Me.TextBox8.TabIndex = 17
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox7.Location = New System.Drawing.Point(162, 162)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(233, 26)
        Me.TextBox7.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox6.Location = New System.Drawing.Point(560, 112)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(236, 26)
        Me.TextBox6.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox5.Location = New System.Drawing.Point(162, 112)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(233, 26)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox4.Location = New System.Drawing.Point(560, 62)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(236, 26)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox3.Location = New System.Drawing.Point(162, 62)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(233, 26)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(560, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(236, 26)
        Me.TextBox2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salary:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 50)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(401, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 50)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tax:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 50)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "E-Mail Address:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(401, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 50)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Deduction:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 50)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Hours:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(401, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 50)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Gross Salary:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 50)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Over Time:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(401, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 50)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Net Salary:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 53)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Payroll Date:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(162, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 26)
        Me.TextBox1.TabIndex = 0
        '
        'btnGeneratePayroll
        '
        Me.btnGeneratePayroll.Location = New System.Drawing.Point(560, 253)
        Me.btnGeneratePayroll.Name = "btnGeneratePayroll"
        Me.btnGeneratePayroll.Size = New System.Drawing.Size(113, 47)
        Me.btnGeneratePayroll.TabIndex = 21
        Me.btnGeneratePayroll.Text = "Button1"
        Me.btnGeneratePayroll.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(401, 253)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 47)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Button2"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GeneratePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DGV_EmployeeList)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "GeneratePayroll"
        Me.Size = New System.Drawing.Size(834, 560)
        CType(Me.DGV_EmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_EmployeeList As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents EmpList_ID As DataGridViewTextBoxColumn
    Friend WithEvents EmpList_EmpName As DataGridViewTextBoxColumn
    Friend WithEvents EmpList_Salary As DataGridViewTextBoxColumn
    Friend WithEvents EmpList_TotalHrs As DataGridViewTextBoxColumn
    Friend WithEvents EmpList_Overtime As DataGridViewTextBoxColumn
    Friend WithEvents btnGeneratePayroll As Button
    Friend WithEvents btnCancel As Button
End Class
