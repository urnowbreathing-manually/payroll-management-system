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
        Me.Pnl_Stats1 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Pnl_Stats2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_SalarySlips = New System.Windows.Forms.Button()
        Me.Btn_Attendance = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Pnl_Stats3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_OnOvertime = New System.Windows.Forms.Button()
        Me.Btn_OnLeave = New System.Windows.Forms.Button()
        Me.Pnl_Stats1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        'Pnl_Stats1
        '
        Me.Pnl_Stats1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl_Stats1.BackColor = System.Drawing.Color.Transparent
        Me.Pnl_Stats1.ColumnCount = 4
        Me.Pnl_Stats1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.Pnl_Stats1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.Pnl_Stats1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.Pnl_Stats1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.Pnl_Stats1.Controls.Add(Me.Panel3, 0, 0)
        Me.Pnl_Stats1.Controls.Add(Me.Panel2, 1, 0)
        Me.Pnl_Stats1.Controls.Add(Me.Panel1, 2, 0)
        Me.Pnl_Stats1.Controls.Add(Me.Panel4, 3, 0)
        Me.Pnl_Stats1.Location = New System.Drawing.Point(10, 40)
        Me.Pnl_Stats1.Margin = New System.Windows.Forms.Padding(0)
        Me.Pnl_Stats1.Name = "Pnl_Stats1"
        Me.Pnl_Stats1.RowCount = 1
        Me.Pnl_Stats1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Pnl_Stats1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.Pnl_Stats1.Size = New System.Drawing.Size(830, 100)
        Me.Pnl_Stats1.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumSeaGreen
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
        Me.Lbl_PayrollP_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PayrollP_Dynamic.Location = New System.Drawing.Point(83, 50)
        Me.Lbl_PayrollP_Dynamic.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_PayrollP_Dynamic.Name = "Lbl_PayrollP_Dynamic"
        Me.Lbl_PayrollP_Dynamic.Size = New System.Drawing.Size(26, 27)
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
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
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
        Me.Lbl_EmpCA_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EmpCA_Dynamic.Location = New System.Drawing.Point(80, 50)
        Me.Lbl_EmpCA_Dynamic.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_EmpCA_Dynamic.Name = "Lbl_EmpCA_Dynamic"
        Me.Lbl_EmpCA_Dynamic.Size = New System.Drawing.Size(26, 27)
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
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
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
        Me.Lbl_TotalEmp_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalEmp_Dynamic.Location = New System.Drawing.Point(80, 50)
        Me.Lbl_TotalEmp_Dynamic.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_TotalEmp_Dynamic.Name = "Lbl_TotalEmp_Dynamic"
        Me.Lbl_TotalEmp_Dynamic.Size = New System.Drawing.Size(26, 27)
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
        Me.Panel4.BackColor = System.Drawing.Color.MediumSeaGreen
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
        Me.Lbl_PayrollTM_Dynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PayrollTM_Dynamic.Location = New System.Drawing.Point(33, 50)
        Me.Lbl_PayrollTM_Dynamic.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_PayrollTM_Dynamic.Name = "Lbl_PayrollTM_Dynamic"
        Me.Lbl_PayrollTM_Dynamic.Size = New System.Drawing.Size(100, 27)
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
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Pnl_Stats2)
        Me.Panel5.Controls.Add(Me.Btn_SalarySlips)
        Me.Panel5.Controls.Add(Me.Btn_Attendance)
        Me.Panel5.Location = New System.Drawing.Point(10, 160)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(410, 400)
        Me.Panel5.TabIndex = 24
        '
        'Pnl_Stats2
        '
        Me.Pnl_Stats2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl_Stats2.AutoScroll = True
        Me.Pnl_Stats2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Pnl_Stats2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Stats2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.Pnl_Stats2.Location = New System.Drawing.Point(0, 30)
        Me.Pnl_Stats2.Margin = New System.Windows.Forms.Padding(0)
        Me.Pnl_Stats2.Name = "Pnl_Stats2"
        Me.Pnl_Stats2.Padding = New System.Windows.Forms.Padding(10)
        Me.Pnl_Stats2.Size = New System.Drawing.Size(410, 370)
        Me.Pnl_Stats2.TabIndex = 28
        Me.Pnl_Stats2.WrapContents = False
        '
        'Btn_SalarySlips
        '
        Me.Btn_SalarySlips.BackColor = System.Drawing.Color.GreenYellow
        Me.Btn_SalarySlips.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SalarySlips.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SalarySlips.Location = New System.Drawing.Point(120, 0)
        Me.Btn_SalarySlips.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_SalarySlips.Name = "Btn_SalarySlips"
        Me.Btn_SalarySlips.Size = New System.Drawing.Size(120, 30)
        Me.Btn_SalarySlips.TabIndex = 27
        Me.Btn_SalarySlips.Text = "Salary Slips"
        Me.Btn_SalarySlips.UseVisualStyleBackColor = False
        '
        'Btn_Attendance
        '
        Me.Btn_Attendance.BackColor = System.Drawing.Color.GreenYellow
        Me.Btn_Attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Attendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Attendance.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Attendance.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Attendance.Name = "Btn_Attendance"
        Me.Btn_Attendance.Size = New System.Drawing.Size(120, 30)
        Me.Btn_Attendance.TabIndex = 26
        Me.Btn_Attendance.Text = "Attendance"
        Me.Btn_Attendance.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.Pnl_Stats3)
        Me.Panel6.Controls.Add(Me.Btn_OnOvertime)
        Me.Panel6.Controls.Add(Me.Btn_OnLeave)
        Me.Panel6.Location = New System.Drawing.Point(430, 160)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(410, 400)
        Me.Panel6.TabIndex = 25
        '
        'Pnl_Stats3
        '
        Me.Pnl_Stats3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl_Stats3.AutoScroll = True
        Me.Pnl_Stats3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Pnl_Stats3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Stats3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.Pnl_Stats3.Location = New System.Drawing.Point(0, 30)
        Me.Pnl_Stats3.Margin = New System.Windows.Forms.Padding(0)
        Me.Pnl_Stats3.Name = "Pnl_Stats3"
        Me.Pnl_Stats3.Padding = New System.Windows.Forms.Padding(10)
        Me.Pnl_Stats3.Size = New System.Drawing.Size(410, 370)
        Me.Pnl_Stats3.TabIndex = 30
        Me.Pnl_Stats3.WrapContents = False
        '
        'Btn_OnOvertime
        '
        Me.Btn_OnOvertime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_OnOvertime.BackColor = System.Drawing.Color.GreenYellow
        Me.Btn_OnOvertime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_OnOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_OnOvertime.Location = New System.Drawing.Point(290, 0)
        Me.Btn_OnOvertime.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_OnOvertime.Name = "Btn_OnOvertime"
        Me.Btn_OnOvertime.Size = New System.Drawing.Size(120, 30)
        Me.Btn_OnOvertime.TabIndex = 29
        Me.Btn_OnOvertime.Text = "On Overtime"
        Me.Btn_OnOvertime.UseVisualStyleBackColor = False
        '
        'Btn_OnLeave
        '
        Me.Btn_OnLeave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_OnLeave.BackColor = System.Drawing.Color.GreenYellow
        Me.Btn_OnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_OnLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_OnLeave.Location = New System.Drawing.Point(170, 0)
        Me.Btn_OnLeave.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_OnLeave.Name = "Btn_OnLeave"
        Me.Btn_OnLeave.Size = New System.Drawing.Size(120, 30)
        Me.Btn_OnLeave.TabIndex = 28
        Me.Btn_OnLeave.Text = "On Leave"
        Me.Btn_OnLeave.UseVisualStyleBackColor = False
        '
        'HR_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MyPMS.My.Resources.Resources.MyPMS_2_tansparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Pnl_Stats1)
        Me.Controls.Add(Me.Lbl_WelcomeMsg)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "HR_Dashboard"
        Me.Size = New System.Drawing.Size(850, 570)
        Me.Pnl_Stats1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_WelcomeMsg As Label
    Friend WithEvents Pnl_Stats1 As TableLayoutPanel
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
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btn_SalarySlips As Button
    Friend WithEvents Btn_Attendance As Button
    Friend WithEvents Pnl_Stats2 As FlowLayoutPanel
    Friend WithEvents Pnl_Stats3 As FlowLayoutPanel
    Friend WithEvents Btn_OnOvertime As Button
    Friend WithEvents Btn_OnLeave As Button
End Class
