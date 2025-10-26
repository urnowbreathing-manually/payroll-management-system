<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HR_Login
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TestLabel = New System.Windows.Forms.Label()
        Me.TxtBox_EmpID = New System.Windows.Forms.TextBox()
        Me.TxtBox_Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTodayLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TestLabel
        '
        Me.TestLabel.AutoSize = True
        Me.TestLabel.Location = New System.Drawing.Point(110, 130)
        Me.TestLabel.Name = "TestLabel"
        Me.TestLabel.Size = New System.Drawing.Size(77, 13)
        Me.TestLabel.TabIndex = 0
        Me.TestLabel.Text = "Employee ID* :"
        Me.TestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBox_EmpID
        '
        Me.TxtBox_EmpID.Location = New System.Drawing.Point(191, 127)
        Me.TxtBox_EmpID.Name = "TxtBox_EmpID"
        Me.TxtBox_EmpID.Size = New System.Drawing.Size(143, 20)
        Me.TxtBox_EmpID.TabIndex = 1
        '
        'TxtBox_Password
        '
        Me.TxtBox_Password.Location = New System.Drawing.Point(190, 157)
        Me.TxtBox_Password.Name = "TxtBox_Password"
        Me.TxtBox_Password.Size = New System.Drawing.Size(143, 20)
        Me.TxtBox_Password.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password* :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date && Time Today:"
        '
        'DateTodayLbl
        '
        Me.DateTodayLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTodayLbl.AutoSize = True
        Me.DateTodayLbl.BackColor = System.Drawing.SystemColors.Control
        Me.DateTodayLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateTodayLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.DateTodayLbl.Location = New System.Drawing.Point(150, 42)
        Me.DateTodayLbl.Name = "DateTodayLbl"
        Me.DateTodayLbl.Size = New System.Drawing.Size(158, 33)
        Me.DateTodayLbl.TabIndex = 6
        Me.DateTodayLbl.Text = "Date today"
        Me.DateTodayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTodayLbl)
        Me.Panel1.Location = New System.Drawing.Point(20, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 90)
        Me.Panel1.TabIndex = 7
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.LawnGreen
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Location = New System.Drawing.Point(120, 220)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(250, 60)
        Me.LoginBtn.TabIndex = 3
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'HR_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBox_Password)
        Me.Controls.Add(Me.TxtBox_EmpID)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.TestLabel)
        Me.Name = "HR_Login"
        Me.Size = New System.Drawing.Size(500, 300)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestLabel As Label
    Friend WithEvents TxtBox_EmpID As TextBox
    Friend WithEvents TxtBox_Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTodayLbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LoginBtn As Button
End Class
