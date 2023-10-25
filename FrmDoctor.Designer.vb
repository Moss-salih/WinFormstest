<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDoctor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox6 = New TextBox()
        ComboBox1 = New ComboBox()
        btnCreate = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Location = New Point(264, 58)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(233, 31)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.Location = New Point(682, 55)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(260, 31)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.None
        TextBox4.Location = New Point(682, 103)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(204, 31)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.None
        TextBox5.Location = New Point(682, 149)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(260, 31)
        TextBox5.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(156, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 25)
        Label1.TabIndex = 5
        Label1.Text = "First Name "
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.ForeColor = Color.Gainsboro
        Label2.Location = New Point(576, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 25)
        Label2.TabIndex = 6
        Label2.Text = "Last Name "
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.ForeColor = Color.Gainsboro
        Label3.Location = New Point(182, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 25)
        Label3.TabIndex = 7
        Label3.Text = "Adress"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.ForeColor = Color.Gainsboro
        Label4.Location = New Point(539, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 25)
        Label4.TabIndex = 8
        Label4.Text = "Phone Number "
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.ForeColor = Color.Gainsboro
        Label5.Location = New Point(617, 152)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 25)
        Label5.TabIndex = 9
        Label5.Text = "Email "
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.ForeColor = Color.Gainsboro
        Label6.Location = New Point(163, 115)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 25)
        Label6.TabIndex = 10
        Label6.Text = "Specialist"
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.None
        TextBox6.Location = New Point(264, 161)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(233, 31)
        TextBox6.TabIndex = 11
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(264, 109)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(233, 33)
        ComboBox1.TabIndex = 12
        ' 
        ' btnCreate
        ' 
        btnCreate.Anchor = AnchorStyles.None
        btnCreate.BackColor = SystemColors.ButtonFace
        btnCreate.ForeColor = Color.FromArgb(CByte(253), CByte(138), CByte(114))
        btnCreate.Location = New Point(539, 268)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(112, 34)
        btnCreate.TabIndex = 16
        btnCreate.Text = "save"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.None
        btnDelete.BackColor = SystemColors.ButtonFace
        btnDelete.ForeColor = Color.FromArgb(CByte(253), CByte(138), CByte(114))
        btnDelete.Location = New Point(264, 266)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 18
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Anchor = AnchorStyles.None
        btnUpdate.BackColor = SystemColors.ButtonFace
        btnUpdate.ForeColor = Color.FromArgb(CByte(253), CByte(138), CByte(114))
        btnUpdate.Location = New Point(407, 266)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 17
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 367)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1514, 200)
        DataGridView1.TabIndex = 19
        ' 
        ' FrmDoctor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1514, 567)
        Controls.Add(DataGridView1)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnCreate)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "FrmDoctor"
        Text = "Doctors Detials"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
