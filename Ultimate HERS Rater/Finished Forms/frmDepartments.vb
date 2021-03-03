Public Class frmDepartments
    Dim DB As New DataBaseWork
    Dim Data As New DataSet
    Dim DepartmentID As Integer

    Private Sub frmDepartments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set up form

        ' Open DB Connection
        DB.Connect()

        ' Populate Current Department List
        GetDepartments()
        lstDepartments.SelectedIndex = -1

        ' Set default form state
        btnSave.Enabled = False
        DepartmentID = Nothing
        ResetSave()

    End Sub

    Private Sub ResetSave()
        ' Disable save Button until changes are made
        btnSave.Enabled = False
        TimerSave.Enabled = False
        btnSave.BackColor = Color.FromKnownColor(KnownColor.Control)

    End Sub

    Private Sub TickerSave() Handles TimerSave.Tick
        If btnSave.BackColor = Color.FromKnownColor(KnownColor.Control) Then
            btnSave.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight)
        Else
            btnSave.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If

    End Sub

    Private Sub TimerSavedTick() Handles TimerSaved.Tick
        If lblSaved.Visible = True Then
            lblSaved.Visible = False
            TimerSaved.Stop()
        End If

    End Sub

    Private Sub GetDepartments()
        Dim sql As String

        ' Pull current Department list
        sql = "SELECT * FROM Departments"
        DB.SetData(sql)
        Data = DB.GetData("Departments")

        'Set PrimaryKey
        DB.SetPrimary("Departments", "DepartmentID")

        ' Populate Department list
        lstDepartments.DisplayMember = "Department"
        lstDepartments.ValueMember = "DepartmentID"
        lstDepartments.DataSource = Data.Tables("Departments")

    End Sub

    Private Sub txtDepartName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepartName.TextChanged
        ' Info has changed enable save button
        btnSave.Enabled = True
        TimerSave.Start()
        ErrorProvider.Clear()

    End Sub

    Private Sub lstDepartments_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDepartments.Click
        Dim DepartmentName As String
        Dim DepartInfo As DataRow

        'Store selected DepartmentID
        DepartmentID = lstDepartments.SelectedValue

        ' Check if stored ID has value
        If DepartmentID <> Nothing Then
            ' Find selected Record 
            DepartInfo = Data.Tables("Departments").Rows.Find(DepartmentID)

            'Populate Variables
            DepartmentName = DepartInfo("Department")

            'Send back to screen
            txtDepartName.Text = DepartmentName

            ' Disable save Button until changes are made
            ResetSave()

        End If

    End Sub

    Private Sub SetData(ByRef DepartInfo As DataRow)
        Dim DepartmentName As String

        'Populate Variables
        DepartmentName = txtDepartName.Text

        'Fill DataSet
        DepartInfo("Department") = DepartmentName

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Clear Fields
        DepartmentID = Nothing
        txtDepartName.Text = Nothing
        lstDepartments.SelectedIndex = -1
        ResetSave()

        ' Send focus to name field
        txtDepartName.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Saving Department Information
        Dim DepartmentName As String
        Dim DepartInfo As DataRow

        'Populate Variables
        DepartmentName = txtDepartName.Text

        Try
            ' Verify a department name is entered
            If DepartmentName <> Nothing Then
                ' Check if we are adding department
                If DepartmentID = Nothing Then
                    ' Adding a new Department
                    DepartInfo = Data.Tables("Departments").NewRow

                    'Save Department info
                    SetData(DepartInfo)

                    'Updates Dataset
                    Data.Tables("Departments").Rows.Add(DepartInfo)

                    'Set DepartmentID to new department
                    DepartmentID = DepartInfo("DepartmentID")

                Else
                    'Updating current Department

                    'Find Select department records
                    DepartInfo = Data.Tables("Departments").Rows.Find(DepartmentID)

                    'Saves Department Info
                    SetData(DepartInfo)

                End If

                ' Updating Table
                DB.UpdateData("Departments")

                ' Update Department List
                GetDepartments()
                lstDepartments.SelectedValue = DepartmentID

                ' Show saved label
                lblSaved.Visible = True
                btnSave.Enabled = False
                TimerSaved.Start()

                'Disable Save button
                ResetSave()

            Else
                ErrorProvider.SetError(lblDepartName, "Department name is required.")

            End If

        Catch
            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Check for unsaved changes
        If btnSave.Enabled = True Then
            ' Unsaved changes found - confirm exit
            If MsgBox("You have unsaved changes." & vbNewLine & "Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' Close DB Connection
                DB.Disconnect()

                ' Exit back to main main menu
                Me.Close()
            Else
                ' Unsaved changes found
                ErrorProvider.SetError(lblDepartName, "Unsaved changes found.")
            End If

        Else
            'Close DB connection
            DB.Disconnect()

            ' exit back to main menu
            Me.Close()

        End If

    End Sub

End Class