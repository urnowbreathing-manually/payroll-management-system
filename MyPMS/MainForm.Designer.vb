<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.BackgroundImage = Global.MyPMS.My.Resources.Resources.MyPMS_2_tansparent
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MainPanel.Location = New System.Drawing.Point(12, 45)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(989, 560)
        Me.MainPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.MyPMS.My.Resources.Resources.MyPMS_6_transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(12, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(109, 37)
        Me.Panel1.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1013, 617)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyPMS: Payroll Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents Panel1 As Panel
End Class
