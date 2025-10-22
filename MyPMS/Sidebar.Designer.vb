<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sidebar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Btn_Logout = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Btn_Logout)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 560)
        Me.Panel1.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(3, 277)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 45)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Attendance"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(3, 226)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(144, 45)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Reports"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Btn_Logout
        '
        Me.Btn_Logout.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Logout.Location = New System.Drawing.Point(3, 491)
        Me.Btn_Logout.Name = "Btn_Logout"
        Me.Btn_Logout.Size = New System.Drawing.Size(144, 45)
        Me.Btn_Logout.TabIndex = 5
        Me.Btn_Logout.Text = "Logout"
        Me.Btn_Logout.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(3, 440)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 45)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Settings"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(3, 175)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 45)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Payroll"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(3, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Requests"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 45)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Employees"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dashboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Sidebar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Name = "Sidebar"
        Me.Size = New System.Drawing.Size(150, 560)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Logout As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
