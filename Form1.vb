Imports System.Runtime.InteropServices
Imports System.Windows.Documents
Imports FontAwesome.Sharp

Public Class Form1
    Private currentBtn As IconButton
    Private leftborderBtn As Panel
    Private currentChildForm As Form
    'constructor 
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        leftborderBtn = New Panel()
        leftborderBtn.Size = New Size(7, 60)
        PanelMain.Controls.Add(leftborderBtn)
        ' Add any initialization after the InitializeComponent() call.
        'form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    Private Sub activateButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            diableButton()

            'buttons
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(73, 36, 81)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border
            leftborderBtn.BackColor = customcolor
            leftborderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftborderBtn.Visible = True
            leftborderBtn.BringToFront()
            'current form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customcolor

        End If
    End Sub

    Private Sub diableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub openchildForm(childform As Form)
        'open only form 
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childform
        'end
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        PanelDeskTop.Controls.Add(childform)
        PanelDeskTop.Tag = childform
        childform.BringToFront()
        childform.Show()
        LblFormTitel.Text = childform.Text

    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles icbtnDashboard.Click
        activateButton(sender, Color.FromArgb(253, 138, 114))
        openchildForm(New DashBoard)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IcBtnPatients.Click
        activateButton(sender, Color.FromArgb(253, 138, 114))
        openchildForm(New FrmPatients)

    End Sub

    Private Sub IcBtnDoctors_Click(sender As Object, e As EventArgs) Handles IcBtnDoctors.Click
        activateButton(sender, Color.FromArgb(253, 138, 114))
        openchildForm(New FrmDoctor)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    Private Sub Reset()
        diableButton()
        leftborderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        LblFormTitel.Text = "Home"

    End Sub
    <DllImport("user32.dll")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal Iparam As Integer)

    End Sub

    Private Sub PnlTitelBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTitelBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub IconBtnFull_Click(sender As Object, e As EventArgs) Handles IconBtnFull.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
            'FrmPatients.DataGridView1.Size = New Size(1524, 1000)
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub IconBtnMini_Click(sender As Object, e As EventArgs) Handles IconBtnMini.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub IconBtnClose_Click(sender As Object, e As EventArgs) Handles IconBtnClose.Click
        Application.Exit()
    End Sub
End Class


