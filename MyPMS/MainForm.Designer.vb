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
        Me.Logo = New System.Windows.Forms.Panel()
        Me.Navbar = New System.Windows.Forms.Panel()
        Me.Navbar_Header = New System.Windows.Forms.Label()
        Me.Navbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.BackgroundImage = Global.MyPMS.My.Resources.Resources.MyPMS_2_tansparent
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MainPanel.Location = New System.Drawing.Point(0, 50)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1010, 570)
        Me.MainPanel.TabIndex = 0
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Logo.BackgroundImage = Global.MyPMS.My.Resources.Resources.MyPMS_6_transparent
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Logo.Location = New System.Drawing.Point(0, 0)
        Me.Logo.Margin = New System.Windows.Forms.Padding(0)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(145, 50)
        Me.Logo.TabIndex = 0
        '
        'Navbar
        '
        Me.Navbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Navbar.BackColor = System.Drawing.Color.LightGreen
        Me.Navbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Navbar.Controls.Add(Me.Navbar_Header)
        Me.Navbar.Controls.Add(Me.Logo)
        Me.Navbar.Location = New System.Drawing.Point(0, 0)
        Me.Navbar.Margin = New System.Windows.Forms.Padding(0)
        Me.Navbar.Name = "Navbar"
        Me.Navbar.Size = New System.Drawing.Size(1010, 50)
        Me.Navbar.TabIndex = 1
        '
        'Navbar_Header
        '
        Me.Navbar_Header.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Navbar_Header.AutoSize = True
        Me.Navbar_Header.BackColor = System.Drawing.Color.Transparent
        Me.Navbar_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Navbar_Header.Location = New System.Drawing.Point(470, 10)
        Me.Navbar_Header.Name = "Navbar_Header"
        Me.Navbar_Header.Size = New System.Drawing.Size(71, 31)
        Me.Navbar_Header.TabIndex = 1
        Me.Navbar_Header.Text = "Text"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1010, 620)
        Me.Controls.Add(Me.Navbar)
        Me.Controls.Add(Me.MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyPMS: Payroll Management System"
        Me.Navbar.ResumeLayout(False)
        Me.Navbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents Logo As Panel
    Friend WithEvents Navbar As Panel
    Friend WithEvents Navbar_Header As Label
End Class
