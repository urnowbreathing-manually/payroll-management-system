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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_WelcomeMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login Successful!"
        '
        'Lbl_WelcomeMsg
        '
        Me.Lbl_WelcomeMsg.AutoSize = True
        Me.Lbl_WelcomeMsg.Location = New System.Drawing.Point(286, 203)
        Me.Lbl_WelcomeMsg.Name = "Lbl_WelcomeMsg"
        Me.Lbl_WelcomeMsg.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_WelcomeMsg.TabIndex = 1
        Me.Lbl_WelcomeMsg.Text = "Welcome, "
        '
        'HR_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Lbl_WelcomeMsg)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "HR_Dashboard"
        Me.Size = New System.Drawing.Size(834, 560)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_WelcomeMsg As Label
End Class
