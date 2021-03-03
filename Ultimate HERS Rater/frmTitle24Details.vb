Public Class frmTitle24Details
    'Pulling stored project ID
    Dim ProjectID As Integer = GetProjectID()
    ' Populating DataSet of basic project info
    Dim ProjectInfo As New ProjectInfo(ProjectID)
    Dim data As New DataSet

    Private Sub frmTitle24Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set default form settings
        FillCombos()
        lblNoteMessage.Visible = False
        ptbCal.Visible = False
        MonthCalendar.Visible = False
        btnSaveMain.Enabled = False
        btnSaveAlt.Enabled = False

        'Populate the Form Basics
        lblProjectName.Text = ProjectInfo.GetData("ProjectName", "Basics", ProjectID)
        lblProjectLocation.Text = ProjectInfo.GetData("ProjectLocation", "Basics", ProjectID)
        lblCustomer.Text = ProjectInfo.GetData("CustomerName", "Basics", ProjectID)
        lblDivision.Text = ProjectInfo.GetData("DivisionName", "Basics", ProjectID)
        lblProjectNumber.Text = "You are working in project number [ " & ProjectID.ToString & " ]"

        ' Populate Project Notes Group Box
        ProjectInfo.FindNotes("T24")
        ProjectInfo.LastNote()
        GetNoteInfo()
        CheckNoteCount()
        ResetNoteSave()

        ' Populate Report Review group Box
        FindRevisions()
        lstRevisions.SelectedIndex = ProjectInfo.GetRevisionCount() - 1
        'cmbRevisionFilter.SelectedIndex = -1
        GetRevisionInfo()

        'Populate Versions review group box
        FindVersions(lstRevisions.SelectedValue)
        lstVersions.SelectedIndex = ProjectInfo.GetVersionCount() - 1
        GetVersionInfo()

        'Populate Project Contacts tab
        ProjectInfo.SetContacts()
        If ProjectInfo.GetData("ContactID", "Basics", ProjectID) <> Nothing Then
            cmbMainName.SelectedValue = ProjectInfo.GetData("ContactID", "Basics", ProjectID)
            GetMainContactInfo(cmbMainName.SelectedValue)
        End If

        If ProjectInfo.GetData("AltContactID", "Basics", ProjectID) <> Nothing Then
            cmbAltName.SelectedValue = ProjectInfo.GetData("AltContactID", "Basics", ProjectID)
            GetAltContactInfo(cmbAltName.SelectedValue)
        End If

        GetTradeList()
        lstTradeList.SelectedIndex = lstTradeList.Items.Count - 1
        GetTradeContactInfo(lstTradeList.SelectedValue)

        'Populating Summary Plans List
        GetAllPlans()
        lstPlans.SelectedIndex = -1
        lstPlans.SelectedIndex = -1

        'Populate Invoice DataGrid
        GetInvoices()

        'Populate Plans tab
        lstVerSelector.DisplayMember = "VersionNumber"
        lstVerSelector.ValueMember = "VersionID"
        lstVerSelector.DataSource = data.Tables("Versions")


    End Sub

#Region "Report Review Population"
    Private Sub FindRevisions()

        'Find revisions
        Data = ProjectInfo.SetRevisionInfo(ProjectID)

        'Populate revision list
        lstRevisions.DisplayMember = "RevisionDate"
        lstRevisions.ValueMember = "RevisionID"
        lstRevisions.DataSource = Data.Tables("Revisions")

    End Sub

    Private Sub GetRevisionInfo()
        Dim ID As Integer

        'Store selected list value
        ID = lstRevisions.SelectedValue

        'Check to make sure there are Revisions to find info for
        If ID <> Nothing Then
            'Populate Fields
            txtDateAssigned.Text = ProjectInfo.GetData("AssignedDate", "Revisions", ID)
            txtDateDue.Text = ProjectInfo.GetData("DueDate", "Revisions", ID)
            txtDateCompleted.Text = ProjectInfo.GetData("CompletedDate", "Revisions", ID)
            txtRevDescription.Text = ProjectInfo.GetData("RevisionNote", "Revisions", ID)
            If ProjectInfo.GetData("UserID", "Revisions", ID) <> Nothing Then
                cmbAssignedTo.SelectedValue = ProjectInfo.GetData("UserID", "Revisions", ID)
                cmbRevisionStatus.Enabled = True
            Else
                cmbAssignedTo.SelectedIndex = -1
                cmbRevisionStatus.Enabled = False
            End If
            If ProjectInfo.GetData("StatusID", "Revisions", ID) <> Nothing Then
                cmbRevisionStatus.SelectedValue = Val(ProjectInfo.GetData("StatusID", "Revisions", ID))
            Else
                cmbRevisionStatus.SelectedIndex = -1
            End If

        Else
            ' Show Blank Fields
            txtDateAssigned.Text = Nothing
            txtDateDue.Text = Nothing
            txtDateCompleted.Text = Nothing
            txtRevDescription.Text = Nothing
            cmbAssignedTo.SelectedIndex = -1
            cmbRevisionStatus.SelectedIndex = -1

        End If

    End Sub

    Private Sub btnRevisionAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevisionAdd.Click
        Dim ID As Integer
        'Adding new Revision
        ProjectInfo.SetRevisionInfo(ProjectID)
        ID = ProjectInfo.AddRevision()

        'Clearing fields
        txtDateAssigned.Text = Nothing
        txtDateCompleted.Text = Nothing
        txtDateDue.Text = Nothing
        txtRevDescription.Text = Nothing
        cmbAssignedTo.SelectedIndex = -1
        cmbRevisionStatus.SelectedIndex = -1

        'Updating list box
        FindRevisions()
        lstRevisions.SelectedValue = ID
        GetRevisionInfo()

        'Populate Versions review group box
        FindVersions(lstRevisions.SelectedValue)
        lstVersions.SelectedIndex = ProjectInfo.GetVersionCount() - 1
        GetVersionInfo()

        'Send focus to Description Field
        txtRevDescription.Focus()

    End Sub

    Private Sub lstRevisions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstRevisions.Click
        'Updating Revision info fields
        GetRevisionInfo()

        'Updating Versions info fields
        FindVersions(lstRevisions.SelectedValue)
        lstVersions.SelectedIndex = ProjectInfo.GetVersionCount() - 1
        GetVersionInfo()

    End Sub

    Private Sub FindVersions(ByVal ID As Integer)

        'Populating revisions list box
        data = ProjectInfo.SetVersionsInfo(ID)

        'Populate version list
        lstVersions.DisplayMember = "VersionNumber"
        lstVersions.ValueMember = "VersionID"
        lstVersions.DataSource = data.Tables("Versions")

    End Sub

    Private Sub GetVersionInfo()
        Dim ID As Integer

        ID = lstVersions.SelectedValue

        'Check to make sure there are Version to find info for
        If ID <> Nothing Then
            ' Populate Fields
            txtVersionDate.Text = ProjectInfo.GetData("VersionDate", "Versions", ID)
            txtVerDescription.Text = ProjectInfo.GetData("VersionNote", "Versions", ID)
            If ProjectInfo.GetData("VersionApproved", "Versions", ID) = True Then
                lblVersionApproved.Text = "Approved"
                lblVersionApproved.ForeColor = Color.Black
            Else
                lblVersionApproved.Text = "Not Approved"
                lblVersionApproved.ForeColor = Color.Red
            End If

            If ProjectInfo.GetData("Title24InHouse", "Versions", ID) = True Then
                txtReportsDoneby.Text = "In House"
            Else
                txtReportsDoneby.Text = ProjectInfo.GetData("T24OthersName", "Versions", ID)
            End If

            ' Populate Incentive List
            GetIncentives(ID)

        Else
            'Show Blank Fields
            txtVersionDate.Text = Nothing
            txtReportsDoneby.Text = Nothing
            txtVerDescription.Text = Nothing
            lblVersionApproved.Text = Nothing
            lstIncentives.DataSource = Nothing

        End If

    End Sub

    Private Sub GetIncentives(ByVal ID As Integer)
        ' Populate Incentive List
        Dim sql As String
        Dim db As New DataBaseWork

        sql = "SELECT VersionIncentives.IncentiveTypeID, IncentiveTypes.IncentiveName " & _
        "FROM (RevisionVersions INNER JOIN VersionIncentives ON RevisionVersions.VersionID = VersionIncentives.VersionID) INNER JOIN IncentiveTypes ON VersionIncentives.IncentiveTypeID = IncentiveTypes.IncentiveTypeID " & _
        "WHERE RevisionVersions.VersionID =" & ID

        If ID <> Nothing Then
            db.Connect()
            db.SetData(sql)
            data = db.GetData("Incentives")
            db.Disconnect()

            lstIncentives.DisplayMember = "IncentiveName"
            lstIncentives.ValueMember = "IncentiveTypeID"
            lstIncentives.DataSource = data.Tables("Incentives")
            lstIncentives.SelectedIndex = -1
        End If

    End Sub

    Private Sub lstVersions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVersions.Click
        ' Update Version info fields
        GetVersionInfo()

    End Sub

    Private Sub txtDateDue_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateDue.Enter
        'show calender icon
        If ptbCal.Visible = False Then
            ptbCal.Visible = True
        Else
            ptbCal.Visible = False
        End If

    End Sub

    Private Sub ptbCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbCal.Click
        'Popup calendar Icon for due date
        Dim p As Point = New Point(100, 88)
        MonthCalendar.Location = p
        MonthCalendar.Visible = True

    End Sub

    Private Sub MonthCalendar_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateSelected
        'Popup calendar for Due data
        txtDateDue.Text = MonthCalendar.SelectionStart
        MonthCalendar.Visible = False
        txtDateDue.Focus()

    End Sub

    Private Sub txtDateAssigned_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateAssigned.Validating
        Dim formater As New Format
        Dim D As String

        D = txtDateAssigned.Text

        ' Check for correct data format
        If IsDate(D) = True Or D = Nothing Then
            'Valid Date found, make sure it is correctly formated
            D = formater.CheckDate(D)
            txtDateAssigned.Text = D
            ProjectInfo.SetRevisionInfo(lstRevisions.SelectedValue)
            ProjectInfo.UpdateData(D, "AssignedDate", "Revisions", lstRevisions.SelectedValue)
        Else
            'Invalid Data info found
            MsgBox("Enter Correct Date")
            txtDateAssigned.Focus()
        End If

    End Sub

    Private Sub txtDateDue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateDue.Validating
        Dim formater As New Format
        Dim D As String

        D = txtDateDue.Text

        ' Check for correct data format
        If IsDate(D) = True Or D = Nothing Then
            'Valid Date found, make sure it is correctly formated
            D = formater.CheckDate(D)
            txtDateDue.Text = D
            ProjectInfo.SetRevisionInfo(lstRevisions.SelectedValue)
            ProjectInfo.UpdateData(D, "DueDate", "Revisions", lstRevisions.SelectedValue)
        Else
            'Invalid Data info found
            MsgBox("Enter Correct Date")
            txtDateDue.Focus()
        End If

    End Sub

    Private Sub txtDateCompleted_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateCompleted.Validating
        Dim formater As New Format
        Dim D As String

        D = txtDateCompleted.Text

        ' Check for correct data format
        If IsDate(D) = True Or D = Nothing Then
            'Valid Date found, make sure it is correctly formated
            D = formater.CheckDate(D)
            txtDateCompleted.Text = D
            ProjectInfo.SetRevisionInfo(lstRevisions.SelectedValue)
            ProjectInfo.UpdateData(D, "CompletedDate", "Revisions", lstRevisions.SelectedValue)
        Else
            'Invalid Data info found
            MsgBox("Enter Correct Date")
            txtDateCompleted.Focus()
        End If

    End Sub

    Private Sub txtRevDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRevDescription.Validating
        Dim str As String
        str = txtRevDescription.Text

        'Updating Revision Note
        ProjectInfo.SetRevisionInfo(lstRevisions.SelectedValue)
        ProjectInfo.UpdateData(str, "RevisionNote", "Revisions", lstRevisions.SelectedValue)

    End Sub

    Private Sub cmbAssignedTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAssignedTo.SelectionChangeCommitted
        Dim I As Integer
        I = cmbAssignedTo.SelectedValue

        If I <> Nothing Then
            'Updating Assigned UserID
            ProjectInfo.SetRevisionInfo(lstRevisions.SelectedValue)
            ProjectInfo.UpdateData(I, "UserID", "Revisions", lstRevisions.SelectedValue)

            'Check if revision date has been assigned before
            If txtDateAssigned.Text = Nothing Then
                txtDateAssigned.Text = Today
                txtDateAssigned.Focus()
            End If

            'Check if revision status has been set before
            If cmbRevisionStatus.SelectedValue = Nothing Then
                cmbRevisionStatus.SelectedValue = 1
                ProjectInfo.UpdateData(I, "StatusID", "Revisions", lstRevisions.SelectedValue)
            End If

            'Making status changes enabled
            cmbRevisionStatus.Enabled = True

        Else
            'Disable status changes until revision is assigned
            cmbRevisionStatus.Enabled = False

        End If

    End Sub

    Private Sub cmbRevisionStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRevisionStatus.SelectionChangeCommitted
        Dim I As Integer
        I = cmbRevisionStatus.SelectedValue

        'Updating Revision Status ID
        ProjectInfo.SetRevisionInfo(lstRevisions.SelectedValue)
        ProjectInfo.UpdateData(I, "StatusID", "Revisions", lstRevisions.SelectedValue)

        ' Populating Date information in database for revision status tracking
        ' If statments are to ensure the date has not been entered already
        Select Case cmbRevisionStatus.SelectedValue
            Case 4 ' out for approval
                If ProjectInfo.GetData("OutForApprovalDate", "Revisions", lstRevisions.SelectedValue) = Nothing Then
                    'Set Out for approval date
                    ProjectInfo.UpdateData(Today, "OutForApprovalDate", "Revisions", lstRevisions.SelectedValue)
                End If

            Case 5 ' approved
                If ProjectInfo.GetData("ApprovedDate", "Revisions", lstRevisions.SelectedValue) = Nothing Then
                    'Set Approved Date
                    ProjectInfo.UpdateData(Today, "ApprovedDate", "Revisions", lstRevisions.SelectedValue)
                End If

            Case 8 ' completed
                If ProjectInfo.GetData("CompletedDate", "Revisions", lstRevisions.SelectedValue) = Nothing Then
                    'Set Completed Date
                    txtDateCompleted.Text = Today
                    ProjectInfo.UpdateData(Today, "CompletedDate", "Revisions", lstRevisions.SelectedValue)
                End If

        End Select

    End Sub

    Private Sub txtVersionDate_enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVersionDate.Enter, txtReportsDoneby.Enter, txtVerDescription.Enter
        'Disabling text entry on these fields
        lstVersions.Focus()

    End Sub

    Private Sub GetAllPlans()
        Dim DB As New DataBaseWork
        Dim sql As String

        Try
            'DB conection
            DB.Connect()

            'Filling Plan List on Review Tab
            sql = "SELECT * FROM Plans WHERE ProjectID=" & ProjectID
            DB.SetData(sql)
            Data = DB.GetData("Plans")
            lstPlans.DisplayMember = "PlanName"
            lstPlans.ValueMember = "PlansID"
            lstPlans.DataSource = data.Tables("Plans")

        Catch
            MsgBox(ErrorToString)
        End Try

        'Close DB Connection
        DB.Disconnect()

    End Sub

#End Region

#Region "Note Navigation & Population"
    Private Sub GetNoteInfo()
        If ProjectInfo.GetNoteID <> Nothing Then
            'Populate Note data fields
            lblNoteCount.Text = (ProjectInfo.GetNoteMarker + 1).ToString & " of " & ProjectInfo.GetNoteCount.ToString
            lblNoteDate.Text = ProjectInfo.GetNote("DateofNote")
            lblNoteUserName.Text = ProjectInfo.GetNote("UserName")
            txtNoteField.Text = ProjectInfo.GetNote("NoteField")
        Else
            ' Reset fields to nothing
            lblNoteCount.Text = "0 of 0"
            lblNoteDate.Text = Nothing
            lblNoteUserName.Text = Nothing
            txtNoteField.Text = Nothing
        End If

    End Sub

    Private Sub btnNotePrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotePrev.Click
        ' Moving to previous project note
        ProjectInfo.PreviousNote()
        GetNoteInfo()
        CheckNoteCount()
        ResetNoteSave()

    End Sub

    Private Sub btnNoteNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoteNext.Click
        ' Moving to next project note
        ProjectInfo.NextNote()
        GetNoteInfo()
        CheckNoteCount()
        ResetNoteSave()

    End Sub

    Private Sub btnNoteAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoteAdd.Click
        ' Adding project note
        ProjectInfo.ClearNoteID()
        txtNoteField.Text = Nothing
        lblNoteUserName.Text = GetUser()
        lblNoteDate.Text = DateTime.Today
        lblNoteCount.Text = (ProjectInfo.GetNoteCount + 1).ToString & " of " & (ProjectInfo.GetNoteCount + 1).ToString
        btnNoteNext.Enabled = False
        txtNoteField.Focus()

    End Sub

    Private Sub txtNoteField_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoteField.Validating
        'Enable saving Note
        btnNoteSave.Enabled = True
        TimerNoteSave.Enabled = True
        SaveTicker()

    End Sub

    Private Sub btnNoteSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoteSave.Click
        Dim ID As Integer = ProjectInfo.GetNoteID
        Dim NoteText, NoteDate As String
        Dim NoteUserID As Integer

        'Populate Variables
        NoteText = txtNoteField.Text
        NoteDate = lblNoteDate.Text.ToString
        NoteUserID = GetUserID()

        ' Check to make sure a Note has been entered
        If NoteText <> Nothing Then
            ' Check for NoteID to determine if we are adding or updating project note
            ProjectInfo.AddNote(ProjectID, -1, NoteText, NoteDate, NoteUserID)
            ProjectInfo.FindNotes("T24")
            CheckNoteCount()
            lblNoteMessage.Text = "Note Saved"
            lblNoteMessage.Visible = True
            tmrNoteMessage.Start()
            btnNoteAdd.Focus()
            ResetNoteSave()
        Else
            'Provide Error Message
            MsgBox("Can note save blank notes")
            txtNoteField.Focus()
        End If

    End Sub

    Private Sub btnNoteDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoteDelete.Click
        ' Only allow logged in user to delete notes that were left by logged in user
        ProjectInfo.DeleteNote()
        ProjectInfo.FindNotes("T24")
        CheckNoteCount()
        GetNoteInfo()
        lblNoteMessage.Text = "Note Deleted"
        lblNoteMessage.Visible = True
        tmrNoteMessage.Start()
        btnNoteAdd.Focus()

    End Sub

    Private Sub SaveTicker() Handles TimerNoteSave.Tick
        ' Changes the backgorund color of save button to make it flash.
        If btnNoteSave.BackColor = Color.FromKnownColor(KnownColor.Control) Then
            btnNoteSave.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight)
        Else
            btnNoteSave.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If

    End Sub

    Private Sub SavedTicker() Handles tmrNoteMessage.Tick
        ' A note was saved - flash note saved label.
        If lblNoteMessage.Visible = True Then
            lblNoteMessage.Visible = False
            tmrNoteMessage.Stop()
        End If

    End Sub

    Private Sub CheckNoteCount()
        ' Disable Previous Note button if on the First note
        If ProjectInfo.GetNoteMarker < 1 Then
            btnNotePrev.Enabled = False
        Else
            btnNotePrev.Enabled = True
        End If

        'Disable Next Note Button if on last note
        If ProjectInfo.GetNoteMarker + 1 = ProjectInfo.GetNoteCount Then
            btnNoteNext.Enabled = False
        Else
            btnNoteNext.Enabled = True
        End If

    End Sub

    Private Sub ResetNoteSave()
        ' Disable save Button until changes are made
        btnNoteSave.Enabled = False
        TimerNoteSave.Enabled = False
        btnNoteSave.BackColor = Color.FromKnownColor(KnownColor.Control)

    End Sub

#End Region

#Region "Contact Population"

    Private Sub GetMainContactInfo(ByVal id As Integer)
        'Finds contact details for passed ID
        If id <> Nothing Then
            txtMainEmail.Text = ProjectInfo.GetData("Email", "Contacts", id)
            If txtMainEmail.Text <> Nothing Then
                ToolTip.SetToolTip(txtMainEmail, "Double click to email " & cmbMainName.Text & " about this project.")
            Else
                ToolTip.SetToolTip(txtMainEmail, "")
            End If
            txtMainPhone.Text = ProjectInfo.GetData("Phone", "Contacts", id)
            txtMainMobile.Text = ProjectInfo.GetData("Mobile", "Contacts", id)
            txtMainFax.Text = ProjectInfo.GetData("Fax", "Contacts", id)
            If ProjectInfo.GetData("Active", "Contacts", id) = False Then
                ErrorProvider.SetError(lblMainName, "This is an inactive contact, need to update.")
            Else
                ErrorProvider.SetError(lblMainName, "")
            End If
        End If

    End Sub

    Private Sub GetAltContactInfo(ByVal id As Integer)
        'Finds contact details for passed ID
        If id <> Nothing Then
            txtAltEmail.Text = ProjectInfo.GetData("Email", "Contacts", id)
            If txtAltEmail.Text <> Nothing Then
                ToolTip.SetToolTip(txtAltEmail, "Double click to email " & cmbAltName.Text & " about this project.")
            Else
                ToolTip.SetToolTip(txtAltEmail, "")
            End If
            txtAltPhone.Text = ProjectInfo.GetData("Phone", "Contacts", id)
            txtAltMobile.Text = ProjectInfo.GetData("Mobile", "Contacts", id)
            txtAltFax.Text = ProjectInfo.GetData("Fax", "Contacts", id)
            If ProjectInfo.GetData("Active", "Contacts", id) = False Then
                ErrorProvider.SetError(lblAltName, "This is an inactive contact, need to update.")
            Else
                ErrorProvider.SetError(lblAltName, "")
            End If
        End If

    End Sub

    Private Sub GetTradeList()

        'Finding Trades linked to the project
        data = ProjectInfo.SetTradeContacts()

        lstTradeList.DisplayMember = "CustomerType"
        lstTradeList.ValueMember = "TradeContactID"
        lstTradeList.DataSource = data.Tables("Trades")

    End Sub

    Private Sub GetTradeContactInfo(ByVal id As Integer)
        Dim ContactID As Integer

        'Finds contact details for passed ID
        If id <> Nothing Then
            'Find ContactID for selected TradeID
            ContactID = ProjectInfo.GetData("ContactID", "Trades", id)

            'Populate text fields with contact info
            txtTradeName.Text = ProjectInfo.GetData("ContactName", "Contacts", ContactID)
            txtTradeEmail.Text = ProjectInfo.GetData("Email", "Contacts", ContactID)
            If txtTradeEmail.Text <> Nothing Then
                ToolTip.SetToolTip(txtTradeEmail, "Double click to email " & txtTradeName.Text & " about this project.")
            Else
                ToolTip.SetToolTip(txtTradeEmail, "")
            End If
            txtTradePhone.Text = ProjectInfo.GetData("Phone", "Contacts", ContactID)
            txtTradeMobile.Text = ProjectInfo.GetData("Mobile", "Contacts", ContactID)
            txtTradeFax.Text = ProjectInfo.GetData("Fax", "Contacts", ContactID)
            txtTradeCustomer.Text = ProjectInfo.GetData("CustomerName", "Contacts", ContactID)
            txtTradeDivision.Text = ProjectInfo.GetData("DivisionName", "Contacts", ContactID)
            If ProjectInfo.GetData("Active", "Contacts", ContactID) = False Then
                ErrorProvider.SetError(lblTradeName, "This is an inactive contact, need to update.")
            Else
                ErrorProvider.SetError(lblTradeName, "")
            End If

        End If

    End Sub

    Private Sub lstTradeList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTradeList.Click
        'Update trade contact info
        GetTradeContactInfo(lstTradeList.SelectedValue)

    End Sub

    Private Sub txtTradeEmail_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTradeEmail.DoubleClick, txtMainEmail.DoubleClick, txtAltEmail.DoubleClick
        Dim Email As String
        Dim clickedbtn As TextBox

        'Find calling textbox to determine what contact to email
        If TypeOf sender Is TextBox Then
            clickedbtn = DirectCast(sender, TextBox)
            Select Case clickedbtn.Name
                Case "txtMainEmail"
                    Email = txtMainEmail.Text
                Case "txtAltEmail"
                    Email = txtAltEmail.Text
                Case "txtTradeEmail"
                    Email = txtTradeEmail.Text
                Case Else
                    Email = Nothing
            End Select

            'IF email address is not blank then send email.
            If Email <> Nothing Then
                System.Diagnostics.Process.Start("mailto:" & Email & "?Subject=" & lblProjectName.Text)
            End If

        End If

    End Sub

    Private Sub txtAlt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAltEmail.Enter, txtAltPhone.Enter, txtAltMobile.Enter, txtAltFax.Enter
        ' Disabling text fields
        cmbAltName.Focus()

    End Sub

    Private Sub txtMain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMainEmail.Enter, txtMainPhone.Enter, txtMainMobile.Enter, txtMainFax.Enter
        'Disabling text fields
        cmbMainName.Focus()

    End Sub

    Private Sub txtTrade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTradeCustomer.Enter, txtTradeDivision.Enter, txtTradeName.Enter, txtTradePhone.Enter, txtTradeMobile.Enter, txtTradeFax.Enter, txtTradeEmail.Enter
        'Disabling text fields
        lstTradeList.Focus()

    End Sub

    Private Sub cmbMainName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMainName.SelectionChangeCommitted
        Dim ID As Integer

        ID = cmbMainName.SelectedValue

        'Populate Fields
        GetMainContactInfo(ID)

        'Enabling save button if a value is selected
        If ID <> Nothing Then
            btnSaveMain.Enabled = True
        Else
            btnSaveMain.Enabled = False
        End If

    End Sub

    Private Sub cmbAltName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAltName.SelectionChangeCommitted
        Dim ID As Integer

        ID = cmbAltName.SelectedValue

        'Populate Fields
        GetAltContactInfo(ID)

        'Enabling save button if a value is selected
        If ID <> Nothing Then
            btnSaveAlt.Enabled = True
        Else
            btnSaveAlt.Enabled = False
        End If

    End Sub

    Private Sub SaveContact(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMain.Click, btnSaveAlt.Click
        Dim saver As Button
        Dim DB As New DataBaseWork
        Dim Row As DataRow
        Dim ID As Integer
        Dim sql As String

        ' prepare database info
        sql = "SELECT ProjectID, ContactID, AltContactID FROM CustomerProjects WHERE ProjectID =" & ProjectID
        DB.Connect()
        DB.SetData(sql)
        Data = DB.GetData("Project")
        DB.SetPrimary("Project", "ProjectID")
        DB.Disconnect()

        'Find the row for the project were are working in
        Row = Data.Tables("Project").Rows.Find(ProjectID)

        'Determine saving sender button
        If TypeOf sender Is Button Then
            saver = DirectCast(sender, Button)
            Select Case saver.Name
                Case "btnSaveMain"
                    ID = cmbMainName.SelectedValue
                    Row("ContactID") = ID
                    cmbMainName.Focus()
                    btnSaveMain.Enabled = False
                Case "btnSaveAlt"
                    ID = cmbAltName.SelectedValue
                    Row("AltContactID") = ID
                    cmbAltName.Focus()
                    btnSaveAlt.Enabled = False
            End Select

            'Update table
            DB.UpdateData("Project")

        End If
    End Sub

    Private Sub btnDeleteTrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteTrade.Click
        Dim ID As Integer

        ID = lstTradeList.SelectedValue

        If ID <> Nothing Then
            'Verify user wants to delete contact
            If MsgBox("Are you sure you want to delete this trade contact?", MsgBoxStyle.YesNo) = vbYes Then
                'Delete trade ID from table
                ProjectInfo.SetTradeContacts()
                ProjectInfo.DeleteTrade(ID)
                GetTradeList()
                ID = lstTradeList.SelectedValue
                GetTradeContactInfo(ID)

            End If

        End If

    End Sub

    Private Sub btnAddTrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTrade.Click
        Dim AddTrade As New frmAddTradeContact
        Dim ContactID, NewID As Integer
        AddTrade.ShowDialog()

        ContactID = AddTrade.GetID

        AddTrade.Dispose()

        'Adding to table
        If ContactID <> -1 Then
            Dim count As Integer
            Dim TContactID As Integer

            count = lstTradeList.Items.Count

            For x = 0 To count - 1
                lstTradeList.SelectedIndex = x

                TContactID = ProjectInfo.GetData("ContactID", "Trades", lstTradeList.SelectedValue)

                If TContactID = ContactID Then
                    MsgBox("That contact exists already.")
                    GetTradeContactInfo(lstTradeList.SelectedValue)
                    Exit Sub
                End If

            Next

            NewID = ProjectInfo.AddTrade(ContactID)


        End If

        'Update the trade List
        GetTradeList()
        GetTradeContactInfo(NewID)
        lstTradeList.SelectedValue = NewID

    End Sub

#End Region

    Private Sub GetInvoices()

        'Populate invoices data grid
        data = ProjectInfo.FindInvoices()
        dtgInvoice.DataSource = data.Tables("Invoices")

        'Formatting the data grid columns
        dtgInvoice.DefaultCellStyle.NullValue = "--"
        dtgInvoice.Columns("Amount").DefaultCellStyle.Format = "C"
        dtgInvoice.Columns("Amount").DefaultCellStyle.NullValue = "$" & "0.00"
        dtgInvoice.Columns("InvoiceID").Visible = False

    End Sub

    Private Sub btnAddInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddInvoice.Click, btnEditInvoice.Click
        Dim AddInvoice As New frmInvoiceDetails
        Dim InvoiceID As Integer
        Dim iNumber As String
        Dim iAmount As Integer
        Dim iDate As String
        Dim iMemo As String
        Dim saver As Button
        Try
            'Find who called the procedure
            saver = DirectCast(sender, Button)
            InvoiceID = dtgInvoice.SelectedCells(0).Value

            If saver.Name = "btnEditInvoice" Then
                AddInvoice.SetID(InvoiceID)
            End If

            'Show Invoice Details dialog
            AddInvoice.ShowDialog()

            If AddInvoice.CheckForCancel = False Then
                'Getting information from the invoice details form
                iNumber = AddInvoice.GetNumber
                iAmount = AddInvoice.GetAmount
                iDate = AddInvoice.GetDate
                iMemo = AddInvoice.GetMemo

                Select Case saver.Name
                    Case "btnAddInvoice"
                        'adding a new invoice to data set
                        ProjectInfo.AddInvoice(iNumber, iAmount, iDate, iMemo)
                    Case "btnEditInvoice"
                        'Updating table information
                        ProjectInfo.FindInvoices()
                        ProjectInfo.UpdateData(iNumber, "Invoice Number", "Invoices", InvoiceID)
                        ProjectInfo.UpdateData(iAmount, "Amount", "Invoices", InvoiceID)
                        ProjectInfo.UpdateData(iDate, "Date", "Invoices", InvoiceID)
                        ProjectInfo.UpdateData(iMemo, "Memo", "Invoices", InvoiceID)
                End Select

                'Update Data grid
                GetInvoices()
            End If

            ' Dump information 
            AddInvoice.Dispose()

        Catch
            MsgBox(ErrorToString)
        End Try

    End Sub

    Private Sub FillCombos()
        Dim DB As New DataBaseWork
        Dim sql As String

        Try
            'Open DB Connection
            DB.Connect()

            'Filling AssignedTo Combo option.
            sql = "SELECT UserID, UserName FROM Users WHERE DepartmentID = 1 ORDER BY UserName"
            DB.SetData(sql)
            data = DB.GetData("Users")
            cmbAssignedTo.DisplayMember = "UserName"
            cmbAssignedTo.ValueMember = "UserID"
            cmbAssignedTo.DataSource = data.Tables("Users")

            'Filling Status Combo option.
            sql = "SELECT * FROM RevisionStatusTypes ORDER BY StatusID"
            DB.SetData(sql)
            data = DB.GetData("StatusTypes")
            cmbRevisionStatus.DisplayMember = "Status"
            cmbRevisionStatus.ValueMember = "StatusID"
            cmbRevisionStatus.DataSource = data.Tables("StatusTypes")

            'Filling Main & Alt Contact Combo options.
            sql = "SELECT ContactID, ContactName FROM CustomerContacts WHERE DivisionID =" & ProjectInfo.GetData("CustomerDivisions.DivisionID", "Basics", ProjectID) & " ORDER BY ContactName"
            DB.SetData(sql)
            data = DB.GetData("Contacts")
            cmbMainName.DisplayMember = "ContactName"
            cmbMainName.ValueMember = "ContactID"
            cmbMainName.DataSource = data.Tables("Contacts")
            cmbMainName.SelectedValue = -1

            cmbAltName.DisplayMember = "ContactName"
            cmbAltName.ValueMember = "ContactID"
            cmbAltName.DataSource = data.Tables("Contacts")
            cmbAltName.SelectedValue = -1

        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try

        ' Close Db Connection
        DB.Disconnect()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Exiting back to main Menu
        frmMainMenu.Show()
        Me.Close()

    End Sub

End Class