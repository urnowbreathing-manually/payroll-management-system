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
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.TxtBox_EmpID = New System.Windows.Forms.TextBox()
        Me.TxtBox_Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTodayLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TestLabel
        '
        Me.TestLabel.AutoSize = True
        Me.TestLabel.Location = New System.Drawing.Point(101, 122)
        Me.TestLabel.Name = "TestLabel"
        Me.TestLabel.Size = New System.Drawing.Size(67, 13)
        Me.TestLabel.TabIndex = 0
        Me.TestLabel.Text = "Employee ID"
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Location = New System.Drawing.Point(175, 225)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(144, 34)
        Me.LoginBtn.TabIndex = 3
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'TxtBox_EmpID
        '
        Me.TxtBox_EmpID.Location = New System.Drawing.Point(175, 119)
        Me.TxtBox_EmpID.Name = "TxtBox_EmpID"
        Me.TxtBox_EmpID.Size = New System.Drawing.Size(143, 20)
        Me.TxtBox_EmpID.TabIndex = 1
        '
        'TxtBox_Password
        '
        Me.TxtBox_Password.Location = New System.Drawing.Point(174, 163)
        Me.TxtBox_Password.Name = "TxtBox_Password"
        Me.TxtBox_Password.Size = New System.Drawing.Size(143, 20)
        Me.TxtBox_Password.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date today"
        '
        'DateTodayLbl
        '
        Me.DateTodayLbl.AutoSize = True
        Me.DateTodayLbl.Location = New System.Drawing.Point(216, 75)
        Me.DateTodayLbl.Name = "DateTodayLbl"
        Me.DateTodayLbl.Size = New System.Drawing.Size(59, 13)
        Me.DateTodayLbl.TabIndex = 6
        Me.DateTodayLbl.Text = "Date today"
        '
        'HR_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.DateTodayLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBox_Password)
        Me.Controls.Add(Me.TxtBox_EmpID)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.TestLabel)
        Me.Name = "HR_Login"
        Me.Size = New System.Drawing.Size(490, 294)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestLabel As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents TxtBox_EmpID As TextBox
    Friend WithEvents TxtBox_Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTodayLbl As Label
End Class
