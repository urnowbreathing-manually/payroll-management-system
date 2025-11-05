<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccmanagementHRA
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
        Me.Txtboxsearch = New System.Windows.Forms.TextBox()
        Me.DataGridViewAccMng = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewAccMng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Management"
        '
        'Txtboxsearch
        '
        Me.Txtboxsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtboxsearch.Location = New System.Drawing.Point(72, 110)
        Me.Txtboxsearch.Name = "Txtboxsearch"
        Me.Txtboxsearch.Size = New System.Drawing.Size(100, 22)
        Me.Txtboxsearch.TabIndex = 1
        '
        'DataGridViewAccMng
        '
        Me.DataGridViewAccMng.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewAccMng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAccMng.Location = New System.Drawing.Point(72, 155)
        Me.DataGridViewAccMng.Name = "DataGridViewAccMng"
        Me.DataGridViewAccMng.Size = New System.Drawing.Size(453, 269)
        Me.DataGridViewAccMng.TabIndex = 2
        '
        'AccmanagementHRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridViewAccMng)
        Me.Controls.Add(Me.Txtboxsearch)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AccmanagementHRA"
        Me.Size = New System.Drawing.Size(830, 570)
        CType(Me.DataGridViewAccMng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txtboxsearch As TextBox
    Friend WithEvents DataGridViewAccMng As DataGridView
End Class
