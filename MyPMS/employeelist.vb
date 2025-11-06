Imports System.Data.SqlClient
Imports Mysqlx.Datatypes

Public Class employeelist
    Dim db As New DBHandler
    Dim isEdit = False
    Dim isViewingArchive = False
    Dim MainContentPanel As New Panel

    Public Sub New(Parent As Panel)
        InitializeComponent()
        MainContentPanel = Parent
    End Sub
    Private Sub employeelist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.RetrieveAllEmployeeData(DataGridView1)
        DataGridView1.Columns("ID").Visible = False
        db.RetrieveDepartments(cmbbxDepartment)

        dateBirthDate.MaxDate = Date.Today.AddYears(-18)
        dateHireDate.MaxDate = Date.Today.Date
        AddHandler dateBirthDate.ValueChanged, AddressOf HandleBirthDateValidation
    End Sub




    ' dgv cell click
    Private Sub Cell_click_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        isEdit = True

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        txtbxEmployeeID.Text = row.Cells("Employee_ID").Value.ToString
        txtbxName.Text = If(Not IsDBNull(row.Cells("Name").Value), row.Cells("Name").Value.ToString, "Employee has no name")

        Dim dept = row.Cells("Department").Value.ToString
        Dim index = cmbbxDepartment.Items.IndexOf(dept)
        cmbbxDepartment.SelectedIndex = index

        txtbxSalary.Text = row.Cells("Salary").Value.ToString

        If Not IsDBNull(row.Cells("BirthDate").Value) Then
            dateBirthDate.Value = CType(row.Cells("BirthDate").Value, Date)
        Else dateBirthDate.Enabled = False
        End If

        If Not IsDBNull(row.Cells("HireDate").Value) Then
            dateHireDate.Value = CType(row.Cells("HireDate").Value, Date)
        Else dateHireDate.Enabled = False
        End If
    End Sub




    'listeners & validation
    Private Sub HandleKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxName.KeyPress
        isEdit = False
        txtbxEmployeeID.Text = (1000 + db.GetNewIDValue() + 1).ToString & "-EMP"
    End Sub
    Private Sub HandleBirthDateValidation(sender As Object, e As EventArgs)
        Dim cutoffDate As Date = Date.Today.AddYears(-18)

        If dateBirthDate.Value > cutoffDate Then
            MsgBox("User is less than 18 years old.")
            dateBirthDate.Focus()
        End If
    End Sub
    Private Function ValidateSaveButton()
        If String.IsNullOrEmpty(txtbxEmployeeID.Text) Then
            Return False
        End If
    End Function



    ' buttons
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        isEdit = False

        txtbxEmployeeID.Text = ""
        txtbxName.Text = ""
        cmbbxDepartment.SelectedIndex = 0
        txtbxSalary.Text = ""
        txtbxContactNo.Text = ""
        txtbxEmailAddress.Text = ""
        txtbxStatus.Text = ""

        dateBirthDate.Value = dateBirthDate.MaxDate
        dateHireDate.Value = dateHireDate.MaxDate
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim emplID As String = txtbxEmployeeID.Text
        Dim name As String = txtbxName.Text
        Dim dept As String = cmbbxDepartment.Text
        Dim stat As String = txtbxStatus.Text
        Dim eaddr As String = txtbxEmailAddress.Text
        Dim contact As String = txtbxContactNo.Text
        Dim salary As String = txtbxSalary.Text
        Dim birthdate As String = dateBirthDate.Value.ToString
        Dim hiredate As String = dateHireDate.Value.ToString

        If Not ValidateSaveButton() Then Return

        If isEdit Then
            If db.UpdateEmployee(emplID, name, dept, eaddr, birthdate, contact, salary, hiredate) Then
                MsgBox("Successfully updated new employee!", MsgBoxStyle.Information, "Added updated employee")
                db.RetrieveAllEmployeeData(DataGridView1)
            Else
                MsgBox("Failed to update employee!", MsgBoxStyle.Critical, "Failed to update employee")
            End If
        Else
            If db.AddNewEmployee(emplID, name, dept, eaddr, birthdate, contact, salary, hiredate) Then
                MsgBox("Successfully added new employee!", MsgBoxStyle.Information, "Added new employee")
                db.RetrieveAllEmployeeData(DataGridView1)
                btnCancel_Click(Nothing, Nothing)
            Else
                MsgBox("Failed to add new employee!", MsgBoxStyle.Critical, "Failed to add new employee")
            End If
        End If
    End Sub
    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        If Not ValidateSaveButton() Then Return

        If db.MoveEmployeeToArchive(txtbxEmployeeID.Text) Then
            MsgBox("Successfully archived employee!", MsgBoxStyle.Information, "Archived employee")
            db.RetrieveAllEmployeeData(DataGridView1)
            btnCancel_Click(Nothing, Nothing)
        Else
            MsgBox("Failed to archived employee!", MsgBoxStyle.Critical, "Failed to archived employee")
        End If

    End Sub
    Private Sub btnViewArchive_Click(sender As Object, e As EventArgs) Handles btnViewArchive.Click
        If isViewingArchive = False Then
            Label10.Text = "Employee list archived"

            btnViewArchive.Text = "View actives"
            btnViewArchive.FillColor = Color.LightSteelBlue

            btnArchive.Enabled = False
            btnSave.Text = "Un-archive"

            btnCancel_Click(Nothing, Nothing)
            db.RetrieveAllArchiveEmployeeData(DataGridView1)

            isViewingArchive = True
        Else
            Label10.Text = "Employee list"

            btnViewArchive.Text = "View archive"
            btnViewArchive.FillColor = Color.Gold

            btnArchive.Enabled = True
            btnSave.Text = "Save"

            btnCancel_Click(Nothing, Nothing)
            db.RetrieveAllEmployeeData(DataGridView1)
            isViewingArchive = False
        End If


    End Sub
End Class
