
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmPatients
    Dim connectionHelper As HospitalDBConnectionHelper
    Dim selectedPatientID As Integer = -1 ' Initialize with an invalid value
    Private ErrorProvider1 As New ErrorProvider()


    Public Sub New()
        InitializeComponent()

        connectionHelper = New HospitalDBConnectionHelper("hospitalDB")
    End Sub
    'function to increment
    Private Function GetNextPatientID() As Integer
        Dim query As String = "SELECT ISNULL(MAX(PatientID), 0) + 1 FROM Patients"

        Using connection As SqlConnection = connectionHelper.GetConnection()
            connection.Open()

            Dim command As SqlCommand = New SqlCommand(query, connection)
            Return Convert.ToInt32(command.ExecuteScalar())
        End Using
    End Function
    ' Create a new patient
    Private Sub CreatePatient()
        Using connection As SqlConnection = connectionHelper.GetConnection()
            connection.Open()
            Dim nextPatientID As Integer = GetNextPatientID()
            Dim query As String = "INSERT INTO Patients (PatientID, FirstName, LastName, Gender, DateOfBirth, PhoneNumber, Email, Address) VALUES (@patientID, @FirstName, @LastName, @Gender, @DateOfBirth, @PhoneNumber, @Email, @Address)"
            Dim command As SqlCommand = New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@PatientID", nextPatientID)
            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            command.Parameters.AddWithValue("@LastName", txtLastName.Text)
            command.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem)
            command.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value)
            command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
            command.Parameters.AddWithValue("@Email", txtEmail.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)

            ' connectionHelper.OpenConnection()
            ' connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            ' connection.CloseConnection()
        End Using
    End Sub

    ' Update an existing patient
    Private Sub UpdatePatient()
        Using connection As SqlConnection = connectionHelper.GetConnection()
            connection.Open()

            Dim query As String = "UPDATE Patients SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, DateOfBirth = @DateOfBirth, PhoneNumber = @PhoneNumber, Email = @Email, Address = @Address WHERE PatientID = @PatientID"
            Dim command As SqlCommand = New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            command.Parameters.AddWithValue("@LastName", txtLastName.Text)
            command.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem)
            command.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value)
            command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
            command.Parameters.AddWithValue("@Email", txtEmail.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@PatientID", selectedPatientID) ' Use selectedPatientIDcommand.Parameters.AddWithValue("@PatientID", txtPatientID.Text)

            ' connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
    End Sub

    ' Delete a patient
    Private Sub DeletePatient(patientID As Integer)
        Using connection As SqlConnection = connectionHelper.GetConnection()
            connection.Open()
            Dim query As String = "DELETE FROM Patients WHERE PatientID = @PatientID"
            Dim command As SqlCommand = New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@PatientID", patientID)

            ' connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
    End Sub

    ' Retrieve patients and display in a DataGridView
    Private Sub RetrievePatients()
        Using connection As SqlConnection = connectionHelper.GetConnection()
            connection.Open()
            Dim query As String = "SELECT * FROM Patients"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
            Dim dataset As DataSet = New DataSet()

            ' connection.Open()
            adapter.Fill(dataset, "Patients")
            connection.Close()

            DataGridView1.DataSource = dataset.Tables("Patients")
        End Using
    End Sub

    ' Load form and retrieve patients on form load
    Private Sub FrmPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RetrievePatients()
            txtPatientID.Hide()
            Label8.Hide()
            btnUpdate.Enabled = False
            btnDelete.Enabled = False



    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ValidateAllControlsAndSetErrorProvider()

        ' Check if any errors exist
        Dim hasErrors As Boolean = False
        For Each control As Control In Me.Controls
            If Not String.IsNullOrEmpty(ErrorProvider1.GetError(control)) Then
                hasErrors = True
                Exit For
            End If
        Next

        If Not hasErrors Then
            CreatePatient()
            RetrievePatients()
            ClearTextBoxes()
        Else
            ' MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        ' First, validate all controls and set error messages
        ValidateAllControlsAndSetErrorProvider()

        ' Check if any errors exist
        Dim hasErrors As Boolean = False
        For Each control As Control In Me.Controls
            If Not String.IsNullOrEmpty(ErrorProvider1.GetError(control)) Then
                hasErrors = True
                Exit For
            End If
        Next

        If Not hasErrors Then
            ' Debugging statement: Check if selectedPatientID is valid
            Debug.WriteLine("Selected Patient ID: " & selectedPatientID.ToString())

            UpdatePatient()
            RetrievePatients()
            ClearTextBoxes()
            MessageBox.Show("Patient record updated successfully.")
        Else
            ' MessageBox.Show("Please correct the errors before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim selectedPatientID As Integer = CInt(DataGridView1.SelectedRows(0).Cells("PatientID").Value)

            ' Delete the record from the database
            DeletePatient(selectedPatientID)

            ' Remove the selected row from the DataGridView
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
            ClearTextBoxes()
            MessageBox.Show("Patient record deleted successfully.")
        End If

    End Sub
    Private Sub SearchPatients(searchTerm As String)
        Dim query As String = "SELECT * FROM Patients WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm"

        Using connection As SqlConnection = connectionHelper.GetConnection()
            connection.Open()

            Dim command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim dataset As DataSet = New DataSet()
            adapter.Fill(dataset, "Patients")

            DataGridView1.DataSource = dataset.Tables("Patients")
        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim searchTerm As String = TxtSearch.Text.Trim()
        SearchPatients(searchTerm)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected PatientID

            selectedPatientID = CInt(DataGridView1.SelectedRows(0).Cells("PatientID").Value)

            ' Populate textboxes with data from the selected row
            txtFirstName.Text = DataGridView1.SelectedRows(0).Cells("FirstName").Value.ToString()
            txtLastName.Text = DataGridView1.SelectedRows(0).Cells("LastName").Value.ToString()
            cmbGender.SelectedItem = DataGridView1.SelectedRows(0).Cells("Gender").Value.ToString()
            dtpDateOfBirth.Value = CDate(DataGridView1.SelectedRows(0).Cells("DateOfBirth").Value)
            txtPhoneNumber.Text = DataGridView1.SelectedRows(0).Cells("PhoneNumber").Value.ToString()
            txtEmail.Text = DataGridView1.SelectedRows(0).Cells("Email").Value.ToString()
            txtAddress.Text = DataGridView1.SelectedRows(0).Cells("Address").Value.ToString()

            ' Enable the Update button
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnCreate.Enabled = False
        Else
            ' No row selected, clear textboxes and disable Update button
            ClearTextBoxes()
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            btnCreate.Enabled = True
        End If
    End Sub
    Private Sub ClearTextBoxes()
        txtFirstName.Clear()
        txtLastName.Clear()
        cmbGender.SelectedIndex = -1
        dtpDateOfBirth.Value = DateTime.Now
        txtPhoneNumber.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
    End Sub

    Private Sub DataGridView1_LostFocus(sender As Object, e As EventArgs)
        ' btnCreate.Enabled = True
        ' btnDelete.Enabled = False
        ' btnUpdate.Enabled = False

    End Sub
    Private Sub ValidateAndSetErrorProvider(ByVal control As Control, ByVal errorMessage As String)
        If TypeOf control Is TextBox Then
            Dim textBox As TextBox = CType(control, TextBox)
            If textBox Is txtFirstName OrElse textBox Is txtLastName Then
                If String.IsNullOrWhiteSpace(textBox.Text) Then
                    ErrorProvider1.SetError(control, errorMessage)
                ElseIf Not textBox.Text.All(Function(c) Char.IsLetter(c) Or Char.IsControl(c)) Then
                    ErrorProvider1.SetError(control, "Only letters are allowed.")
                Else
                    ErrorProvider1.SetError(control, "")
                End If
            ElseIf textBox Is txtPhoneNumber Then
                If String.IsNullOrWhiteSpace(textBox.Text) Then
                    ErrorProvider1.SetError(control, errorMessage)
                ElseIf Not textBox.Text.All(Function(c) Char.IsDigit(c) Or Char.IsControl(c)) Then
                    ErrorProvider1.SetError(control, "Only numbers are allowed.")
                Else
                    ErrorProvider1.SetError(control, "")
                End If
            ElseIf textBox Is txtEmail Then
                If String.IsNullOrWhiteSpace(textBox.Text) Then
                    ErrorProvider1.SetError(control, errorMessage)
                ElseIf Not IsValidEmail(textBox.Text) Then
                    ErrorProvider1.SetError(control, "Invalid email format.")
                Else
                    ErrorProvider1.SetError(control, "")
                End If
            ElseIf textBox Is txtAddress Then
                If String.IsNullOrWhiteSpace(textBox.Text) Then
                    ErrorProvider1.SetError(control, "Address cannot be empty.")
                Else
                    ErrorProvider1.SetError(control, "")
                End If
            Else
                ErrorProvider1.SetError(control, "")
            End If
        ElseIf TypeOf control Is ComboBox AndAlso CType(control, ComboBox).SelectedIndex = -1 Then
            ErrorProvider1.SetError(control, errorMessage)
        Else
            ErrorProvider1.SetError(control, "")
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        ' Basic email format validation using regular expression
        ' This pattern is simplified and may not cover all cases
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function




    Private Sub ValidateComboBoxAndSetErrorProvider(ByVal comboBox As ComboBox, ByVal errorMessage As String)
        If comboBox.SelectedIndex = -1 Then
            ErrorProvider1.SetError(comboBox, errorMessage)
        Else
            ErrorProvider1.SetError(comboBox, "")
        End If
    End Sub

    ' Validate DateOfBirth and set error provider
    Private Sub ValidateDateOfBirthAndSetErrorProvider()
        If dtpDateOfBirth.Value > DateTime.Now Then
            ErrorProvider1.SetError(dtpDateOfBirth, "Invalid date of birth.")
        Else
            ErrorProvider1.SetError(dtpDateOfBirth, "")
        End If
    End Sub
    Private Sub ValidateAllControlsAndSetErrorProvider()
        ValidateAndSetErrorProvider(txtFirstName, "First name is required.")
        ValidateAndSetErrorProvider(txtLastName, "Last name is required.")
        ValidateComboBoxAndSetErrorProvider(cmbGender, "Gender is required.")
        ValidateAndSetErrorProvider(dtpDateOfBirth, "Invalid date of birth.")
        ValidateAndSetErrorProvider(txtPhoneNumber, "Phone number is required.")
        ValidateAndSetErrorProvider(txtEmail, "Email is required.")
        ValidateAndSetErrorProvider(txtAddress, "Address is required.")

        ' Check additional conditions for specific controls, if needed
        ' ValidateAndSetErrorProvider(txtSomeOtherControl, "Some validation message")

        ' Additional custom validation for DateOfBirth
        If dtpDateOfBirth.Value > DateTime.Now Then
            ErrorProvider1.SetError(dtpDateOfBirth, "Invalid date of birth.")
        Else
            ErrorProvider1.SetError(dtpDateOfBirth, "")
        End If
    End Sub


End Class
