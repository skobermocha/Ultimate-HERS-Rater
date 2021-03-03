Public Class frmProjectDetails
    Dim DB As New DataBaseWork
    Dim Data As New DataSet
    Dim CustomerID, DivisionID, ContactID, ProjectID As Integer

    Private Sub frmProjectDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Open Db Connection
        DB.Connect()

        'Populate Customer List
        GetCustomers()
        cmbCustomer.SelectedIndex = -1

        'Populate Project type list
        GetProjectTypes()
        cmbProjectType.SelectedIndex = -1

        ' Set default form Status
        ResetSave()
        btnAdd.Enabled = False
        lblSaved.Visible = False
        CustomerID = Nothing
        DivisionID = Nothing
        ContactID = Nothing

    End Sub

    Private Sub GetProjectTypes()
        Dim sql As String
        ' Pulling Project Types from the database
        Sql = "SELECT * FROM ProjectTypes"
        DB.SetData(Sql)
        Data = DB.GetData("ProjectType")

        ' Populate Customer Type List
        cmbProjectType.DisplayMember = "ProjectType"
        cmbProjectType.ValueMember = "ProjectTypeID"
        cmbProjectType.DataSource = Data.Tables("ProjectType")

    End Sub

    Private Sub GetCustomers()
        Dim sql As String

        ' pulling Customer information from the database
        sql = "SELECT * FROM Customers"
        DB.SetData(sql)

        ' Populate Customer List with current Customers
        If Not Data.Tables.IndexOf("Customers") = -1 Then
            Data.Tables("Customers").Clear()
        End If
        Data = DB.GetData("Customers")

        'Set Primary Key
        DB.SetPrimary("Customers", "CustomerID")

        'Populate Customer List box
        cmbCustomer.DisplayMember = "CustomerName"
        cmbCustomer.ValueMember = "CustomerID"
        cmbCustomer.DataSource = Data.Tables("Customers")

    End Sub

    Private Sub GetDivisions(ByVal ID As Integer)
        Dim sql As String

        ' pull Customer Divisions from database
        sql = "SELECT * FROM CustomerDivisions WHERE CustomerID =" & ID
        DB.SetData(sql)

        'Clear Divisions records if there are any existing
        If Not Data.Tables.IndexOf("Divisions") = -1 Then
            Data.Tables("Divisions").Clear()
        End If
        Data = DB.GetData("Divisions")

        'Set Primary Key
        DB.SetPrimary("Divisions", "DivisionID")

        'Populate Divisions List box
        cmbDivision.DisplayMember = "DivisionName"
        cmbDivision.ValueMember = "DivisionID"
        cmbDivision.DataSource = Data.Tables("Divisions")

    End Sub

    Private Sub GetContacts(ByVal ID As Integer)
        Dim sql As String

        ' Pull contact information from database
        sql = "SELECT * FROM CustomerContacts WHERE DivisionID =" & ID
        DB.SetData(sql)

        'Clear Contacts records if there are any existing
        If Not Data.Tables.IndexOf("Contacts") = -1 Then
            Data.Tables("Contacts").Clear()
        End If
        Data = DB.GetData("Contacts")

        'Set Primary Key
        DB.SetPrimary("Contacts", "ContactID")

        'Populate Contacts List box
        cmbContact.DisplayMember = "ContactName"
        cmbContact.ValueMember = "ContactID"
        cmbContact.DataSource = Data.Tables("Contacts")

    End Sub

    Private Sub GetProjects(ByVal ID As Integer)
        Dim sql As String

        ' Pull Project information from database
        sql = "SELECT ProjectID, CustomerID, DivisionID, ContactID, ProjectName, ProjectLocation, ProjectTypeID, Active FROM CustomerProjects WHERE DivisionID =" & ID
        DB.SetData(sql)

        'Clear Projects records if there are any existing
        If Not Data.Tables.IndexOf("Projects") = -1 Then
            Data.Tables("Projects").Clear()
        End If
        Data = DB.GetData("Projects")

        'Set Primary Key
        DB.SetPrimary("Projects", "ProjectID")

        'Populate Projects List box
        lstProjects.DisplayMember = "ProjectName"
        lstProjects.ValueMember = "ProjectID"
        lstProjects.DataSource = Data.Tables("Projects")

    End Sub

    Private Sub GetProjectInfo(ByVal ID As Integer)
        'Populate Projects Group box 

        'Finding Selected Contact info
        Dim ProjectInfo As DataRow
        ProjectInfo = Data.Tables("Projects").Rows.Find(ID)

        ' Populating Fields from record
        txtName.Text = ProjectInfo.Item("ProjectName").ToString
        txtLocation.Text = ProjectInfo.Item("ProjectLocation").ToString
        cmbContact.SelectedValue = ProjectInfo.Item("ContactID").ToString
        cmbProjectType.SelectedValue = ProjectInfo.Item("ProjectTypeID")
        If ProjectInfo.Item("Active") = -1 Then
            optActive.Select()
        Else
            optInactive.Select()
        End If

    End Sub

    Private Sub ClearProjectInfo()
        ' Clear Project Fields
        txtName.Text = Nothing
        txtLocation.Text = Nothing
        cmbContact.SelectedIndex = -1
        cmbProjectType.SelectedIndex = -1

    End Sub

    Private Sub SetProjectInfo(ByRef ProjectInfo As DataRow)
        Dim ProjectName, Location, ProjectTypeID, sql As String
        Dim Active As Short

        ' Pull contact information from database
        sql = "SELECT ProjectID, CustomerID, DivisionID, ContactID, ProjectName, ProjectLocation, ProjectTypeID, Active FROM CustomerProjects WHERE DivisionID =" & DivisionID
        DB.SetData(sql)

        ' Populate Variables
        ProjectName = txtName.Text
        Location = txtLocation.Text
        ProjectTypeID = cmbProjectType.SelectedValue
        ContactID = cmbContact.SelectedValue

        'Check Contact Status
        If optActive.Checked = False Then
            Active = 0
        Else
            Active = -1
        End If

        ' Populate the DataRow
        ProjectInfo("CustomerID") = CustomerID
        ProjectInfo("DivisionID") = DivisionID
        ProjectInfo("ContactID") = ContactID
        ProjectInfo("ProjectName") = Trim(ProjectName)
        ProjectInfo("ProjectLocation") = Trim(Location)
        ProjectInfo("ProjectTypeID") = ProjectTypeID
        ProjectInfo("Active") = Active

    End Sub

    Private Sub cmbCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomer.SelectionChangeCommitted
        ' Once a customer is selected - Update fields

        Try
            'Store CustomerID
            CustomerID = cmbCustomer.SelectedValue

            'Check for selected item
            If CustomerID <> Nothing Then

                ' Lookup Customer Divisions
                GetDivisions(CustomerID)

                ' Check for customer divisions
                If cmbDivision.Items.Count <> 0 Then
                    ' Customer has divisions - choose first one
                    cmbDivision.SelectedIndex = 0

                    ' Store DivisionID
                    DivisionID = cmbDivision.SelectedValue

                    ' Populate Contacts list
                    GetContacts(DivisionID)
                    cmbContact.SelectedIndex = -1

                    ' Populate Projects List
                    GetProjects(DivisionID)
                    lstProjects.SelectedIndex = -1
                    ClearProjectInfo()

                    'Enable adding Projects
                    btnAdd.Enabled = True

                Else
                    ' Clear Division Fields
                    GetDivisions(Nothing)

                    ' Clear Projects List
                    GetProjects(Nothing)
                    ClearProjectInfo()

                    'Clear Contact Fields
                    GetContacts(Nothing)

                End If

            End If

            'Disable Save Button
            ResetSave()

        Catch
            MsgBox(ErrorToString)
        End Try

    End Sub

    Private Sub cmbDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectionChangeCommitted
        ' Once a Division is selected - Update fields

        Try
            ' Check for Division selected
            If DivisionID <> Nothing Then
                ' Store DivisionID
                DivisionID = cmbDivision.SelectedValue

                ' Populate Contacts list
                GetContacts(DivisionID)
                cmbContact.SelectedIndex = -1

                ' Populate Projects List
                GetProjects(DivisionID)
                lstProjects.SelectedIndex = -1
                ClearProjectInfo()

            Else
                ' Clear Projects List
                GetProjects(Nothing)

                'Clear Contact Fields
                GetContacts(Nothing)

            End If

            ' Disable save Button until changes are made
            ResetSave()

        Catch
            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub lstProjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProjects.Click
        ' Once a Project is selected - Update fields

        Try
            ' Store Contacts ID
            ProjectID = lstProjects.SelectedValue

            If Not ProjectID = Nothing Then
                'Populate Projects Group box 
                GetProjectInfo(ProjectID)

            End If

            ' Disable save Button until changes are made
            ResetSave()

        Catch
            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub TickerSave() Handles TimerSave.Tick
        If btnSave.BackColor = Color.FromKnownColor(KnownColor.Control) Then
            btnSave.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight)
        Else
            btnSave.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If

    End Sub

    Private Sub timersavedtick() Handles TimerSaved.Tick
        If lblSaved.Visible = True Then
            lblSaved.Visible = False
            TimerSaved.Stop()
        End If

    End Sub

    Private Sub ResetSave()
        ' Disable save Button until changes are made
        btnSave.Enabled = False
        TimerSave.Enabled = False
        btnSave.BackColor = Color.FromKnownColor(KnownColor.Control)

    End Sub

    Private Sub ProjectInfo_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged, txtLocation.TextChanged, cmbContact.SelectionChangeCommitted, cmbProjectType.SelectionChangeCommitted, optActive.CheckedChanged, optInactive.CheckedChanged
        ' Text Changed = Enable Save button
        btnSave.Enabled = True
        TimerSave.Start()
        ErrorProvider.Clear()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Saving Project Information
        Dim ProjectName, Location, ProjectTypeID As String
        Dim ProjectInfo As DataRow

        ' Populate Variables
        ProjectName = txtName.Text
        Location = txtLocation.Text
        ProjectTypeID = cmbProjectType.SelectedValue
        ContactID = cmbContact.SelectedValue


        Try
            'Check for Project name before saving
            If ProjectName <> Nothing And Location <> Nothing And cmbContact.SelectedIndex <> -1 And cmbProjectType.SelectedIndex <> -1 Then

                ' Check to see if a contact is selected 
                If ProjectID = Nothing Then

                    ' Adding a new Project
                    ProjectInfo = Data.Tables("Projects").NewRow

                    'Saving the Project info
                    SetProjectInfo(ProjectInfo)

                    ' Adds to dataSet
                    Data.Tables("Projects").Rows.Add(ProjectInfo)

                    'Set New ContactID as selected
                    ProjectID = ProjectInfo("ProjectID")


                Else
                    ' Updating selected Contact
                    ProjectInfo = Data.Tables("Projects").Rows.Find(ProjectID)

                    'Saving the Contact info
                    SetProjectInfo(ProjectInfo)

                End If

                ' Update Table
                DB.UpdateData("Projects")

                'Refresh list from DB
                GetProjects(DivisionID)
                lstProjects.SelectedValue = ProjectID

                ' Show saved label
                lblSaved.Visible = True
                TimerSaved.Start()

                'Disable Save button
                ResetSave()

            Else
                ' Project name not entered
                If ProjectName = Nothing Then
                    ErrorProvider.SetError(lblName, "A project name is required.")
                End If
                ' Project Location not entered
                If Location = Nothing Then
                    ErrorProvider.SetError(lblLocation, "A project location is required.")
                End If
                ' Project Contact not entered
                If ContactID = -1 Then
                    ErrorProvider.SetError(lblContact, "A project contact is required.")
                End If
                ' Project type not entered
                If ProjectTypeID = -1 Then
                    ErrorProvider.SetError(lblProjectType, "A project type is required.")
                End If

            End If
        Catch
            ' Error occured
            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Clear Current Info 
        ClearProjectInfo()
        lstProjects.SelectedIndex = -1
        ProjectID = Nothing

        ' Disable save Button until changes are made
        ResetSave()

        'Send focus to Name field
        txtName.Focus()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Exiting back to main menu

        ' Check for any unsaved changes
        If btnSave.Enabled = True Then
            ' Unsaved changes found - confirm exit
            If MsgBox("You have unsaved changes." & vbNewLine & "Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' exit to main menu
                ' Close Db Connection
                DB.Disconnect()

                ' Back to Main Menu
                frmMainMenu.Show()
                Me.Close()
            Else
                ' show unsaved changes
                ErrorProvider.SetError(lblName, "Unsaved project changes found.")
                btnSave.Focus()

            End If
        Else
            ' Close Db Connection
            DB.Disconnect()

            ' Back to Main Menu
            frmMainMenu.Show()
            Me.Close()

        End If

        ' Close Db Connection
        DB.Disconnect()

        ' Back to Main Menu
        frmMainMenu.Show()
        Me.Close()

    End Sub

End Class