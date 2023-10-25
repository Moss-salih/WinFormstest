<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        SqlServerConnectionHelperBindingSource1 = New BindingSource(components)
        SqlServerConnectionHelperBindingSource = New BindingSource(components)
        PanelMain = New Panel()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        IcBtnDoctors = New FontAwesome.Sharp.IconButton()
        IcBtnPatients = New FontAwesome.Sharp.IconButton()
        icbtnDashboard = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        PictureBox1 = New PictureBox()
        PnlTitelBar = New Panel()
        IconBtnClose = New FontAwesome.Sharp.IconButton()
        IconBtnFull = New FontAwesome.Sharp.IconButton()
        IconBtnMini = New FontAwesome.Sharp.IconButton()
        LblFormTitel = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelDeskTop = New Panel()
        PictureBox2 = New PictureBox()
        CType(SqlServerConnectionHelperBindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SqlServerConnectionHelperBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        PanelMain.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PnlTitelBar.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        PanelDeskTop.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SqlServerConnectionHelperBindingSource1
        ' 
        SqlServerConnectionHelperBindingSource1.DataSource = GetType(SqlServerConnectionHelper)
        ' 
        ' SqlServerConnectionHelperBindingSource
        ' 
        SqlServerConnectionHelperBindingSource.DataSource = GetType(SqlServerConnectionHelper)
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PanelMain.Controls.Add(IconButton4)
        PanelMain.Controls.Add(IcBtnDoctors)
        PanelMain.Controls.Add(IcBtnPatients)
        PanelMain.Controls.Add(icbtnDashboard)
        PanelMain.Controls.Add(PanelLogo)
        PanelMain.Dock = DockStyle.Left
        PanelMain.Location = New Point(0, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(220, 567)
        PanelMain.TabIndex = 0
        ' 
        ' IconButton4
        ' 
        IconButton4.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        IconButton4.Dock = DockStyle.Top
        IconButton4.FlatAppearance.BorderSize = 0
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.ForeColor = Color.Gainsboro
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.HospitalUser
        IconButton4.IconColor = Color.Gainsboro
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.IconSize = 32
        IconButton4.ImageAlign = ContentAlignment.MiddleLeft
        IconButton4.Location = New Point(0, 320)
        IconButton4.Name = "IconButton4"
        IconButton4.Padding = New Padding(10, 0, 20, 0)
        IconButton4.Size = New Size(220, 60)
        IconButton4.TabIndex = 4
        IconButton4.Text = "IconButton4"
        IconButton4.TextAlign = ContentAlignment.MiddleLeft
        IconButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton4.UseVisualStyleBackColor = False
        ' 
        ' IcBtnDoctors
        ' 
        IcBtnDoctors.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        IcBtnDoctors.Dock = DockStyle.Top
        IcBtnDoctors.FlatAppearance.BorderSize = 0
        IcBtnDoctors.FlatStyle = FlatStyle.Flat
        IcBtnDoctors.ForeColor = Color.Gainsboro
        IcBtnDoctors.IconChar = FontAwesome.Sharp.IconChar.UserMd
        IcBtnDoctors.IconColor = Color.Gainsboro
        IcBtnDoctors.IconFont = FontAwesome.Sharp.IconFont.Auto
        IcBtnDoctors.IconSize = 32
        IcBtnDoctors.ImageAlign = ContentAlignment.MiddleLeft
        IcBtnDoctors.Location = New Point(0, 260)
        IcBtnDoctors.Name = "IcBtnDoctors"
        IcBtnDoctors.Padding = New Padding(10, 0, 20, 0)
        IcBtnDoctors.Size = New Size(220, 60)
        IcBtnDoctors.TabIndex = 3
        IcBtnDoctors.Text = "Doctors"
        IcBtnDoctors.TextAlign = ContentAlignment.MiddleLeft
        IcBtnDoctors.TextImageRelation = TextImageRelation.ImageBeforeText
        IcBtnDoctors.UseVisualStyleBackColor = False
        ' 
        ' IcBtnPatients
        ' 
        IcBtnPatients.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        IcBtnPatients.Dock = DockStyle.Top
        IcBtnPatients.FlatAppearance.BorderSize = 0
        IcBtnPatients.FlatStyle = FlatStyle.Flat
        IcBtnPatients.ForeColor = Color.Gainsboro
        IcBtnPatients.IconChar = FontAwesome.Sharp.IconChar.Procedures
        IcBtnPatients.IconColor = Color.Gainsboro
        IcBtnPatients.IconFont = FontAwesome.Sharp.IconFont.Auto
        IcBtnPatients.IconSize = 32
        IcBtnPatients.ImageAlign = ContentAlignment.MiddleLeft
        IcBtnPatients.Location = New Point(0, 200)
        IcBtnPatients.Name = "IcBtnPatients"
        IcBtnPatients.Padding = New Padding(10, 0, 20, 0)
        IcBtnPatients.Size = New Size(220, 60)
        IcBtnPatients.TabIndex = 2
        IcBtnPatients.Text = "Patiens"
        IcBtnPatients.TextAlign = ContentAlignment.MiddleLeft
        IcBtnPatients.TextImageRelation = TextImageRelation.ImageBeforeText
        IcBtnPatients.UseVisualStyleBackColor = False
        ' 
        ' icbtnDashboard
        ' 
        icbtnDashboard.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        icbtnDashboard.Dock = DockStyle.Top
        icbtnDashboard.FlatAppearance.BorderSize = 0
        icbtnDashboard.FlatStyle = FlatStyle.Flat
        icbtnDashboard.ForeColor = Color.Gainsboro
        icbtnDashboard.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical
        icbtnDashboard.IconColor = Color.Gainsboro
        icbtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        icbtnDashboard.IconSize = 32
        icbtnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        icbtnDashboard.Location = New Point(0, 140)
        icbtnDashboard.Name = "icbtnDashboard"
        icbtnDashboard.Padding = New Padding(10, 0, 20, 0)
        icbtnDashboard.Size = New Size(220, 60)
        icbtnDashboard.TabIndex = 1
        icbtnDashboard.Text = "DashBoard"
        icbtnDashboard.TextAlign = ContentAlignment.MiddleLeft
        icbtnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        icbtnDashboard.UseVisualStyleBackColor = False
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(PictureBox1)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(220, 140)
        PanelLogo.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(18, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(182, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PnlTitelBar
        ' 
        PnlTitelBar.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        PnlTitelBar.Controls.Add(IconBtnClose)
        PnlTitelBar.Controls.Add(IconBtnFull)
        PnlTitelBar.Controls.Add(IconBtnMini)
        PnlTitelBar.Controls.Add(LblFormTitel)
        PnlTitelBar.Controls.Add(IconCurrentForm)
        PnlTitelBar.Dock = DockStyle.Top
        PnlTitelBar.Location = New Point(220, 0)
        PnlTitelBar.Name = "PnlTitelBar"
        PnlTitelBar.Size = New Size(1294, 75)
        PnlTitelBar.TabIndex = 1
        ' 
        ' IconBtnClose
        ' 
        IconBtnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        IconBtnClose.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        IconBtnClose.FlatAppearance.BorderSize = 0
        IconBtnClose.FlatStyle = FlatStyle.Flat
        IconBtnClose.ForeColor = Color.Gainsboro
        IconBtnClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle
        IconBtnClose.IconColor = Color.Gainsboro
        IconBtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnClose.IconSize = 20
        IconBtnClose.Location = New Point(1253, 5)
        IconBtnClose.Name = "IconBtnClose"
        IconBtnClose.Padding = New Padding(10, 0, 20, 0)
        IconBtnClose.Size = New Size(26, 24)
        IconBtnClose.TabIndex = 7
        IconBtnClose.TextAlign = ContentAlignment.MiddleLeft
        IconBtnClose.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnClose.UseVisualStyleBackColor = False
        ' 
        ' IconBtnFull
        ' 
        IconBtnFull.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        IconBtnFull.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        IconBtnFull.FlatAppearance.BorderSize = 0
        IconBtnFull.FlatStyle = FlatStyle.Flat
        IconBtnFull.ForeColor = Color.Gainsboro
        IconBtnFull.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        IconBtnFull.IconColor = Color.Gainsboro
        IconBtnFull.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnFull.IconSize = 20
        IconBtnFull.Location = New Point(1229, 5)
        IconBtnFull.Name = "IconBtnFull"
        IconBtnFull.Padding = New Padding(10, 0, 20, 0)
        IconBtnFull.Size = New Size(26, 24)
        IconBtnFull.TabIndex = 6
        IconBtnFull.TextAlign = ContentAlignment.MiddleLeft
        IconBtnFull.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnFull.UseVisualStyleBackColor = False
        ' 
        ' IconBtnMini
        ' 
        IconBtnMini.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        IconBtnMini.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        IconBtnMini.FlatAppearance.BorderSize = 0
        IconBtnMini.FlatStyle = FlatStyle.Flat
        IconBtnMini.ForeColor = Color.Gainsboro
        IconBtnMini.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        IconBtnMini.IconColor = Color.Gainsboro
        IconBtnMini.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnMini.IconSize = 20
        IconBtnMini.Location = New Point(1204, 5)
        IconBtnMini.Name = "IconBtnMini"
        IconBtnMini.Padding = New Padding(10, 0, 20, 0)
        IconBtnMini.Size = New Size(28, 24)
        IconBtnMini.TabIndex = 5
        IconBtnMini.TextAlign = ContentAlignment.MiddleLeft
        IconBtnMini.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnMini.UseVisualStyleBackColor = False
        ' 
        ' LblFormTitel
        ' 
        LblFormTitel.AutoSize = True
        LblFormTitel.ForeColor = Color.Gainsboro
        LblFormTitel.Location = New Point(77, 32)
        LblFormTitel.Name = "LblFormTitel"
        LblFormTitel.Size = New Size(61, 25)
        LblFormTitel.TabIndex = 1
        LblFormTitel.Text = "Home"
        LblFormTitel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        IconCurrentForm.ForeColor = Color.Gainsboro
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House
        IconCurrentForm.IconColor = Color.Gainsboro
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.IconSize = 41
        IconCurrentForm.Location = New Point(30, 16)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(54, 41)
        IconCurrentForm.TabIndex = 0
        IconCurrentForm.TabStop = False
        ' 
        ' PanelDeskTop
        ' 
        PanelDeskTop.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        PanelDeskTop.Controls.Add(PictureBox2)
        PanelDeskTop.Dock = DockStyle.Fill
        PanelDeskTop.Location = New Point(220, 75)
        PanelDeskTop.Name = "PanelDeskTop"
        PanelDeskTop.Size = New Size(1294, 492)
        PanelDeskTop.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(480, 118)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(397, 213)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(1514, 567)
        Controls.Add(PanelDeskTop)
        Controls.Add(PnlTitelBar)
        Controls.Add(PanelMain)
        Name = "Form1"
        Text = "Main"
        CType(SqlServerConnectionHelperBindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CType(SqlServerConnectionHelperBindingSource, ComponentModel.ISupportInitialize).EndInit()
        PanelMain.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PnlTitelBar.ResumeLayout(False)
        PnlTitelBar.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        PanelDeskTop.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents SqlServerConnectionHelperBindingSource As BindingSource
    Friend WithEvents SqlServerConnectionHelperBindingSource1 As BindingSource
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents icbtnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IcBtnDoctors As FontAwesome.Sharp.IconButton
    Friend WithEvents IcBtnPatients As FontAwesome.Sharp.IconButton
    Friend WithEvents PnlTitelBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LblFormTitel As Label
    Friend WithEvents PanelDeskTop As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IconBtnMini As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnFull As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnClose As FontAwesome.Sharp.IconButton
End Class
