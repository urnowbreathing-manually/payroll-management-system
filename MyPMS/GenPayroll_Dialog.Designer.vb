<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenPayroll_Dialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenPayroll_Dialog))
        Me.Lbl_Header = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Box_Deduction = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_GeneratePayroll = New System.Windows.Forms.Button()
        Me.Txt_Box_NetSalary = New System.Windows.Forms.TextBox()
        Me.Txt_Box_OverTime = New System.Windows.Forms.TextBox()
        Me.Txt_Box_GrossSalary = New System.Windows.Forms.TextBox()
        Me.Txt_Box_TotalWorkHrs = New System.Windows.Forms.TextBox()
        Me.Txt_Box_PagIBIG = New System.Windows.Forms.TextBox()
        Me.Txt_Box_EMail = New System.Windows.Forms.TextBox()
        Me.Txt_Box_PhilHealth = New System.Windows.Forms.TextBox()
        Me.Txt_Box_EmployeeName = New System.Windows.Forms.TextBox()
        Me.Txt_Box_SSS = New System.Windows.Forms.TextBox()
        Me.Txt_Box_EmployeeID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Header
        '
        Me.Lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Header.AutoSize = True
        Me.Lbl_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Header.Location = New System.Drawing.Point(125, 13)
        Me.Lbl_Header.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_Header.Name = "Lbl_Header"
        Me.Lbl_Header.Size = New System.Drawing.Size(173, 25)
        Me.Lbl_Header.TabIndex = 83
        Me.Lbl_Header.Text = "Generate Payroll"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(210, 460)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 17)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "*Net Salary:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(210, 340)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 17)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "*Gross Salary:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(20, 460)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Pag-IBIG:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(20, 400)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "PhilHealth:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(20, 338)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "SSS:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(210, 260)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "*Overtime:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(20, 259)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 17)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "*Total Work Hours:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(20, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "*Email Address:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Txt_Box_Deduction
        '
        Me.Txt_Box_Deduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_Deduction.Location = New System.Drawing.Point(230, 420)
        Me.Txt_Box_Deduction.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_Deduction.Name = "Txt_Box_Deduction"
        Me.Txt_Box_Deduction.Size = New System.Drawing.Size(160, 23)
        Me.Txt_Box_Deduction.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(210, 400)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "*Deduction:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(20, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "*Employee Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(20, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "*Employee ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancel.Location = New System.Drawing.Point(210, 540)
        Me.Btn_Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(180, 30)
        Me.Btn_Cancel.TabIndex = 70
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_GeneratePayroll
        '
        Me.Btn_GeneratePayroll.BackColor = System.Drawing.Color.LawnGreen
        Me.Btn_GeneratePayroll.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Btn_GeneratePayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GeneratePayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GeneratePayroll.Location = New System.Drawing.Point(20, 540)
        Me.Btn_GeneratePayroll.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_GeneratePayroll.Name = "Btn_GeneratePayroll"
        Me.Btn_GeneratePayroll.Size = New System.Drawing.Size(180, 30)
        Me.Btn_GeneratePayroll.TabIndex = 69
        Me.Btn_GeneratePayroll.Text = "Generate Payroll"
        Me.Btn_GeneratePayroll.UseVisualStyleBackColor = False
        '
        'Txt_Box_NetSalary
        '
        Me.Txt_Box_NetSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_NetSalary.Location = New System.Drawing.Point(230, 480)
        Me.Txt_Box_NetSalary.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_NetSalary.Name = "Txt_Box_NetSalary"
        Me.Txt_Box_NetSalary.Size = New System.Drawing.Size(160, 23)
        Me.Txt_Box_NetSalary.TabIndex = 68
        '
        'Txt_Box_OverTime
        '
        Me.Txt_Box_OverTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_OverTime.Location = New System.Drawing.Point(230, 280)
        Me.Txt_Box_OverTime.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_OverTime.Name = "Txt_Box_OverTime"
        Me.Txt_Box_OverTime.Size = New System.Drawing.Size(160, 23)
        Me.Txt_Box_OverTime.TabIndex = 67
        '
        'Txt_Box_GrossSalary
        '
        Me.Txt_Box_GrossSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_GrossSalary.Location = New System.Drawing.Point(230, 360)
        Me.Txt_Box_GrossSalary.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_GrossSalary.Name = "Txt_Box_GrossSalary"
        Me.Txt_Box_GrossSalary.Size = New System.Drawing.Size(160, 23)
        Me.Txt_Box_GrossSalary.TabIndex = 66
        '
        'Txt_Box_TotalWorkHrs
        '
        Me.Txt_Box_TotalWorkHrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_TotalWorkHrs.Location = New System.Drawing.Point(40, 280)
        Me.Txt_Box_TotalWorkHrs.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_TotalWorkHrs.Name = "Txt_Box_TotalWorkHrs"
        Me.Txt_Box_TotalWorkHrs.Size = New System.Drawing.Size(160, 23)
        Me.Txt_Box_TotalWorkHrs.TabIndex = 65
        '
        'Txt_Box_PagIBIG
        '
        Me.Txt_Box_PagIBIG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_PagIBIG.Location = New System.Drawing.Point(40, 480)
        Me.Txt_Box_PagIBIG.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_PagIBIG.Name = "Txt_Box_PagIBIG"
        Me.Txt_Box_PagIBIG.Size = New System.Drawing.Size(160, 23)
        Me.Txt_Box_PagIBIG.TabIndex = 64
        '
        'Txt_Box_EMail
        '
        Me.Txt_Box_EMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_EMail.Location = New System.Drawing.Point(40, 200)
        Me.Txt_Box_EMail.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_EMail.Name = "Txt_Box_EMail"
        Me.Txt_Box_EMail.Size = New System.Drawing.Size(350, 23)
        Me.Txt_Box_EMail.TabIndex = 63
        '
        'Txt_Box_PhilHealth
        '
        Me.Txt_Box_PhilHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_PhilHealth.Location = New System.Drawing.Point(40, 420)
        Me.Txt_Box_PhilHealth.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_PhilHealth.Name = "Txt_Box_PhilHealth"
        Me.Txt_Box_PhilHealth.Size = New System.Drawing.Size(160, 23)
        Me.Txt_Box_PhilHealth.TabIndex = 62
        '
        'Txt_Box_EmployeeName
        '
        Me.Txt_Box_EmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_EmployeeName.Location = New System.Drawing.Point(40, 90)
        Me.Txt_Box_EmployeeName.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_EmployeeName.Name = "Txt_Box_EmployeeName"
        Me.Txt_Box_EmployeeName.Size = New System.Drawing.Size(350, 23)
        Me.Txt_Box_EmployeeName.TabIndex = 61
        '
        'Txt_Box_SSS
        '
        Me.Txt_Box_SSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_SSS.Location = New System.Drawing.Point(40, 360)
        Me.Txt_Box_SSS.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_SSS.Name = "Txt_Box_SSS"
        Me.Txt_Box_SSS.Size = New System.Drawing.Size(160, 23)
        Me.Txt_Box_SSS.TabIndex = 60
        '
        'Txt_Box_EmployeeID
        '
        Me.Txt_Box_EmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txt_Box_EmployeeID.Location = New System.Drawing.Point(40, 150)
        Me.Txt_Box_EmployeeID.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt_Box_EmployeeID.Name = "Txt_Box_EmployeeID"
        Me.Txt_Box_EmployeeID.Size = New System.Drawing.Size(350, 23)
        Me.Txt_Box_EmployeeID.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Lbl_Header)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 50)
        Me.Panel1.TabIndex = 84
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.MyPMS.My.Resources.Resources.MyPMS_2_tansparent
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(10, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(75, 50)
        Me.Panel2.TabIndex = 85
        '
        'GenPayroll_Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 590)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_Box_Deduction)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_GeneratePayroll)
        Me.Controls.Add(Me.Txt_Box_NetSalary)
        Me.Controls.Add(Me.Txt_Box_OverTime)
        Me.Controls.Add(Me.Txt_Box_GrossSalary)
        Me.Controls.Add(Me.Txt_Box_TotalWorkHrs)
        Me.Controls.Add(Me.Txt_Box_PagIBIG)
        Me.Controls.Add(Me.Txt_Box_EMail)
        Me.Controls.Add(Me.Txt_Box_PhilHealth)
        Me.Controls.Add(Me.Txt_Box_EmployeeName)
        Me.Controls.Add(Me.Txt_Box_SSS)
        Me.Controls.Add(Me.Txt_Box_EmployeeID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GenPayroll_Dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Payroll"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Header As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Box_Deduction As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Btn_GeneratePayroll As Button
    Friend WithEvents Txt_Box_NetSalary As TextBox
    Friend WithEvents Txt_Box_OverTime As TextBox
    Friend WithEvents Txt_Box_GrossSalary As TextBox
    Friend WithEvents Txt_Box_TotalWorkHrs As TextBox
    Friend WithEvents Txt_Box_PagIBIG As TextBox
    Friend WithEvents Txt_Box_EMail As TextBox
    Friend WithEvents Txt_Box_PhilHealth As TextBox
    Friend WithEvents Txt_Box_EmployeeName As TextBox
    Friend WithEvents Txt_Box_SSS As TextBox
    Friend WithEvents Txt_Box_EmployeeID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
