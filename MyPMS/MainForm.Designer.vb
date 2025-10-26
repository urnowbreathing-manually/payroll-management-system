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
        Me.Navbar = New System.Windows.Forms.Panel()
        Me.Btn_Show_Sidebar = New System.Windows.Forms.Button()
        Me.Navbar_Header = New System.Windows.Forms.Label()
        Me.Sidebar_Panel = New System.Windows.Forms.Panel()
        Me.Login_Panel = New System.Windows.Forms.Panel()
        Me.BG_Logo_Panel = New System.Windows.Forms.Panel()
        Me.Navbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Navbar
        '
        Me.Navbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Navbar.BackColor = System.Drawing.Color.LightGreen
        Me.Navbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Navbar.Controls.Add(Me.Btn_Show_Sidebar)
        Me.Navbar.Controls.Add(Me.Navbar_Header)
        Me.Navbar.Location = New System.Drawing.Point(0, 0)
        Me.Navbar.Margin = New System.Windows.Forms.Padding(0)
        Me.Navbar.Name = "Navbar"
        Me.Navbar.Size = New System.Drawing.Size(850, 50)
        Me.Navbar.TabIndex = 1
        '
        'Btn_Show_Sidebar
        '
        Me.Btn_Show_Sidebar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Btn_Show_Sidebar.BackgroundImage = Global.MyPMS.My.Resources.Resources.MyPMS_6_transparent
        Me.Btn_Show_Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Show_Sidebar.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine
        Me.Btn_Show_Sidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Show_Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Show_Sidebar.Name = "Btn_Show_Sidebar"
        Me.Btn_Show_Sidebar.Size = New System.Drawing.Size(150, 50)
        Me.Btn_Show_Sidebar.TabIndex = 2
        Me.Btn_Show_Sidebar.UseVisualStyleBackColor = False
        '
        'Navbar_Header
        '
        Me.Navbar_Header.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Navbar_Header.AutoSize = True
        Me.Navbar_Header.BackColor = System.Drawing.Color.Transparent
        Me.Navbar_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Navbar_Header.Location = New System.Drawing.Point(390, 10)
        Me.Navbar_Header.Name = "Navbar_Header"
        Me.Navbar_Header.Size = New System.Drawing.Size(71, 31)
        Me.Navbar_Header.TabIndex = 1
        Me.Navbar_Header.Text = "Text"
        '
        'Sidebar_Panel
        '
        Me.Sidebar_Panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Sidebar_Panel.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Sidebar_Panel.Location = New System.Drawing.Point(0, 50)
        Me.Sidebar_Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.Sidebar_Panel.Name = "Sidebar_Panel"
        Me.Sidebar_Panel.Size = New System.Drawing.Size(150, 570)
        Me.Sidebar_Panel.TabIndex = 2
        '
        'Login_Panel
        '
        Me.Login_Panel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Login_Panel.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Login_Panel.Location = New System.Drawing.Point(175, 185)
        Me.Login_Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.Login_Panel.Name = "Login_Panel"
        Me.Login_Panel.Size = New System.Drawing.Size(500, 300)
        Me.Login_Panel.TabIndex = 3
        '
        'BG_Logo_Panel
        '
        Me.BG_Logo_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BG_Logo_Panel.BackColor = System.Drawing.Color.Transparent
        Me.BG_Logo_Panel.BackgroundImage = Global.MyPMS.My.Resources.Resources.MyPMS_2_tansparent
        Me.BG_Logo_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BG_Logo_Panel.Location = New System.Drawing.Point(0, 50)
        Me.BG_Logo_Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.BG_Logo_Panel.Name = "BG_Logo_Panel"
        Me.BG_Logo_Panel.Size = New System.Drawing.Size(850, 570)
        Me.BG_Logo_Panel.TabIndex = 4
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(850, 620)
        Me.Controls.Add(Me.Login_Panel)
        Me.Controls.Add(Me.Sidebar_Panel)
        Me.Controls.Add(Me.Navbar)
        Me.Controls.Add(Me.BG_Logo_Panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyPMS: Payroll Management System"
        Me.Navbar.ResumeLayout(False)
        Me.Navbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Navbar As Panel
    Friend WithEvents Navbar_Header As Label
    Friend WithEvents Sidebar_Panel As Panel
    Friend WithEvents Login_Panel As Panel
    Friend WithEvents Btn_Show_Sidebar As Button
    Friend WithEvents BG_Logo_Panel As Panel
End Class
