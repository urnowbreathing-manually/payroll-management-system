<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRDB_Attendance_Instance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Name_Placeholder = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimeIn_Placeholder = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimeOut_Placeholder = New System.Windows.Forms.Label()
        Me.Status_Placeholder = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Name_Placeholder
        '
        Me.Name_Placeholder.AutoSize = True
        Me.Name_Placeholder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Placeholder.Location = New System.Drawing.Point(80, 10)
        Me.Name_Placeholder.Name = "Name_Placeholder"
        Me.Name_Placeholder.Size = New System.Drawing.Size(47, 13)
        Me.Name_Placeholder.TabIndex = 1
        Me.Name_Placeholder.Text = "<Name>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time-In:"
        '
        'TimeIn_Placeholder
        '
        Me.TimeIn_Placeholder.AutoSize = True
        Me.TimeIn_Placeholder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeIn_Placeholder.Location = New System.Drawing.Point(80, 40)
        Me.TimeIn_Placeholder.Name = "TimeIn_Placeholder"
        Me.TimeIn_Placeholder.Size = New System.Drawing.Size(73, 13)
        Me.TimeIn_Placeholder.TabIndex = 3
        Me.TimeIn_Placeholder.Text = "<HH:MM:SS>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Time-Out:"
        '
        'TimeOut_Placeholder
        '
        Me.TimeOut_Placeholder.AutoSize = True
        Me.TimeOut_Placeholder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeOut_Placeholder.Location = New System.Drawing.Point(280, 40)
        Me.TimeOut_Placeholder.Name = "TimeOut_Placeholder"
        Me.TimeOut_Placeholder.Size = New System.Drawing.Size(73, 13)
        Me.TimeOut_Placeholder.TabIndex = 5
        Me.TimeOut_Placeholder.Text = "<HH:MM:SS>"
        '
        'Status_Placeholder
        '
        Me.Status_Placeholder.AutoSize = True
        Me.Status_Placeholder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_Placeholder.Location = New System.Drawing.Point(280, 10)
        Me.Status_Placeholder.Name = "Status_Placeholder"
        Me.Status_Placeholder.Size = New System.Drawing.Size(49, 13)
        Me.Status_Placeholder.TabIndex = 7
        Me.Status_Placeholder.Text = "<Status>"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(220, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Status:"
        '
        'HRDB_Attendance_Instance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Status_Placeholder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TimeOut_Placeholder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TimeIn_Placeholder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Name_Placeholder)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Name = "HRDB_Attendance_Instance"
        Me.Size = New System.Drawing.Size(370, 70)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Name_Placeholder As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TimeIn_Placeholder As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TimeOut_Placeholder As Label
    Friend WithEvents Status_Placeholder As Label
    Friend WithEvents Label4 As Label
End Class
