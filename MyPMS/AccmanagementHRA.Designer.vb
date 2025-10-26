<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccmanagementHRA
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
        Me.Txtboxsearch = New System.Windows.Forms.TextBox()
        Me.DataGridViewAccMng = New System.Windows.Forms.DataGridView()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnadduser = New System.Windows.Forms.Button()
        Me.Btnarchive = New System.Windows.Forms.Button()
        CType(Me.DataGridViewAccMng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 40)
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
        Me.Txtboxsearch.Text = "Search"
        '
        'DataGridViewAccMng
        '
        Me.DataGridViewAccMng.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewAccMng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAccMng.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Username, Me.Role, Me.Email, Me.Status})
        Me.DataGridViewAccMng.Location = New System.Drawing.Point(72, 155)
        Me.DataGridViewAccMng.Name = "DataGridViewAccMng"
        Me.DataGridViewAccMng.Size = New System.Drawing.Size(453, 269)
        Me.DataGridViewAccMng.TabIndex = 2
        '
        'Username
        '
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        '
        'Role
        '
        Me.Role.HeaderText = "Role"
        Me.Role.Name = "Role"
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'btnadduser
        '
        Me.btnadduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadduser.Location = New System.Drawing.Point(334, 457)
        Me.btnadduser.Name = "btnadduser"
        Me.btnadduser.Size = New System.Drawing.Size(75, 23)
        Me.btnadduser.TabIndex = 3
        Me.btnadduser.Text = "AddUser"
        Me.btnadduser.UseVisualStyleBackColor = True
        '
        'Btnarchive
        '
        Me.Btnarchive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnarchive.Location = New System.Drawing.Point(435, 457)
        Me.Btnarchive.Name = "Btnarchive"
        Me.Btnarchive.Size = New System.Drawing.Size(75, 23)
        Me.Btnarchive.TabIndex = 4
        Me.Btnarchive.Text = "Archive"
        Me.Btnarchive.UseVisualStyleBackColor = True
        '
        'AccmanagementHRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Btnarchive)
        Me.Controls.Add(Me.btnadduser)
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
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Role As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents btnadduser As Button
    Friend WithEvents Btnarchive As Button
End Class
