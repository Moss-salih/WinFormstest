<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPatients
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
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        cmbGender = New ComboBox()
        dtpDateOfBirth = New DateTimePicker()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        txtAddress = New TextBox()
        txtPatientID = New TextBox()
        btnCreate = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TxtSearch = New TextBox()
        Label9 = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Anchor = AnchorStyles.None
        txtFirstName.Location = New Point(292, 59)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(274, 31)
        txtFirstName.TabIndex = 0
        ' 
        ' txtLastName
        ' 
        txtLastName.Anchor = AnchorStyles.None
        txtLastName.Location = New Point(761, 63)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(274, 31)
        txtLastName.TabIndex = 1
        ' 
        ' cmbGender
        ' 
        cmbGender.Anchor = AnchorStyles.None
        cmbGender.Items.AddRange(New Object() {"M", "F"})
        cmbGender.Location = New Point(761, 97)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(274, 33)
        cmbGender.TabIndex = 2
        ' 
        ' dtpDateOfBirth
        ' 
        dtpDateOfBirth.Anchor = AnchorStyles.None
        dtpDateOfBirth.Location = New Point(778, 137)
        dtpDateOfBirth.Name = "dtpDateOfBirth"
        dtpDateOfBirth.Size = New Size(234, 31)
        dtpDateOfBirth.TabIndex = 3
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Anchor = AnchorStyles.None
        txtPhoneNumber.Location = New Point(319, 97)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(247, 31)
        txtPhoneNumber.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.None
        txtEmail.Location = New Point(253, 136)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(314, 31)
        txtEmail.TabIndex = 5
        ' 
        ' txtAddress
        ' 
        txtAddress.Anchor = AnchorStyles.None
        txtAddress.Location = New Point(253, 179)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(313, 40)
        txtAddress.TabIndex = 6
        ' 
        ' txtPatientID
        ' 
        txtPatientID.Location = New Point(906, 213)
        txtPatientID.Name = "txtPatientID"
        txtPatientID.Size = New Size(230, 31)
        txtPatientID.TabIndex = 7
        ' 
        ' btnCreate
        ' 
        btnCreate.Anchor = AnchorStyles.None
        btnCreate.BackColor = SystemColors.ButtonFace
        btnCreate.ForeColor = Color.FromArgb(CByte(253), CByte(138), CByte(114))
        btnCreate.Location = New Point(505, 264)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(112, 34)
        btnCreate.TabIndex = 12
        btnCreate.Text = "save"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Anchor = AnchorStyles.None
        btnUpdate.BackColor = SystemColors.ButtonFace
        btnUpdate.ForeColor = Color.FromArgb(CByte(253), CByte(138), CByte(114))
        btnUpdate.Location = New Point(373, 266)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 13
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.None
        btnDelete.BackColor = SystemColors.ButtonFace
        btnDelete.ForeColor = Color.FromArgb(CByte(253), CByte(138), CByte(114))
        btnDelete.Location = New Point(230, 264)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(194, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 15
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        Label2.ForeColor = Color.Gainsboro
        Label2.Location = New Point(655, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 16
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        Label3.ForeColor = Color.Gainsboro
        Label3.Location = New Point(686, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 25)
        Label3.TabIndex = 17
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        Label4.ForeColor = Color.Gainsboro
        Label4.Location = New Point(663, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 18
        Label4.Text = "Date Of Birth"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        Label5.ForeColor = Color.Gainsboro
        Label5.Location = New Point(181, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 25)
        Label5.TabIndex = 19
        Label5.Text = "Phone Number"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        Label6.ForeColor = Color.Gainsboro
        Label6.Location = New Point(193, 140)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 25)
        Label6.TabIndex = 20
        Label6.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        Label7.ForeColor = Color.Gainsboro
        Label7.Location = New Point(181, 194)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 25)
        Label7.TabIndex = 21
        Label7.Text = "Adress"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(1152, 184)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 25)
        Label8.TabIndex = 22
        Label8.Text = "PatientID"
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Anchor = AnchorStyles.None
        TxtSearch.Location = New Point(761, 264)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(333, 31)
        TxtSearch.TabIndex = 23
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.ForeColor = Color.Gainsboro
        Label9.Location = New Point(686, 264)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 25)
        Label9.TabIndex = 24
        Label9.Text = "Search"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Location = New Point(0, 364)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 40
        DataGridView1.Size = New Size(1514, 203)
        DataGridView1.TabIndex = 25
        DataGridView1.ForeColor = ForeColor
        ' 
        ' FrmPatients
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1514, 567)
        Controls.Add(DataGridView1)
        Controls.Add(Label9)
        Controls.Add(TxtSearch)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnCreate)
        Controls.Add(txtFirstName)
        Controls.Add(txtLastName)
        Controls.Add(cmbGender)
        Controls.Add(dtpDateOfBirth)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtAddress)
        Controls.Add(txtPatientID)
        ForeColor = Color.Gainsboro
        Name = "FrmPatients"
        Text = "Patients Details"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private txtFirstName As TextBox
    Private txtLastName As TextBox
    Private cmbGender As ComboBox
    Private dtpDateOfBirth As DateTimePicker
    Private txtPhoneNumber As TextBox
    Private txtEmail As TextBox
    Private txtAddress As TextBox
    Private txtPatientID As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
