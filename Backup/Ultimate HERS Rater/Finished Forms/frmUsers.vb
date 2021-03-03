Public Class frmUsers
    Dim DB As New DataBaseWork
    Dim Data As New DataSet
    Dim UserID As Integer = Nothing

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Open DB Connection
        DB.Connect()

        ' Populate Current User List
        GetUsers()
        lstUsers.SelectedIndex = -1

        'Populate Usertype list
        GetUserTypes()
        cmbUserType.SelectedIndex = -1

        'Populate Department list
        GetDepartments()
        cmbDepartment.SelectedIndex = -1

        'Disable Savebutton
        ResetSave()

    End Sub

    Private Sub UserInfo_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged, txtPassword.TextChanged, cmbUserType.SelectedIndexChanged, cmbDepartment.SelectedIndexChanged, optActive.CheckedChanged, optInactive.CheckedChanged
        ' Info has changed enable save button
        btnSaveUser.Enabled = True
        TimerSave.Start()
        ErrorProvider.Clear()

    End Sub

    Private Sub TickerSave() Handles TimerSave.Tick
        If btnSaveUser.BackColor = Color.FromKnownColor(KnownColor.Control) Then
            btnSaveUser.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight)
        Else
            btnSaveUser.BackColor = Color.FromKnownColor(KnownColor.Control)
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
        btnSaveUser.Enabled = False
        TimerSave.Enabled = False
        btnSaveUser.BackColor = Color.FromKnownColor(KnownColor.Control)

    End Sub

    Private Sub GetUsers()
        Dim sql As String

        ' Pull current User list
        sql = "SELECT * FROM Users"
        DB.SetData(sql)
        Data = DB.GetData("Users")

        ' Populate user list
        lstUsers.DisplayMember = "UserName"
        lstUsers.ValueMember = "UserID"
        lstUsers.DataSource = Data.Tables("Users")

        ' Set PrimaryKey
        DB.SetPrimary("Users", "UserID")

    End Sub

    Private Sub GetUserTypes()
        Dim sql As String

        ' Pull user Type list
        sql = "SELECT * FROM UserTypes"
        DB.SetData(sql)
        Data = DB.GetData("UserTypes")

        ' Populate User Type Combo
        cmbUserType.DisplayMember = "UserType"
        cmbUserType.ValueMember = "UserTypeID"
        cmbUserType.DataSource = Data.Tables("UserTypes")

    End Sub

    Private Sub GetDepartments()
        Dim sql As String

        ' Pull Department List
        sql = "SELECT * FROM Departments"
        DB.SetData(sql)
        Data = DB.GetData("Departments")

        ' Populate Department Combo
        cmbDepartment.DisplayMember = "Department"
        cmbDepartment.ValueMember = "DepartmentID"
        cmbDepartment.DataSource = Data.Tables("Departments")

    End Sub

    Private Sub SetUserInfo(ByRef UserInfo As DataRow)
        Dim UserName, PW, UserTypeID, DepartmentID As String
        Dim Active As Integer

        ' Populate Variables
        UserName = txtUserName.Text
        PW = txtPassword.Text
        UserTypeID = cmbUserType.SelectedValue
        DepartmentID = cmbDepartment.SelectedValue

        'Check Contact Status
        If optActive.Checked = False Then
            Active = 0
        Else
            Active = -1
        End If

        ' Populate the DataRow
        UserInfo("UserName") = UserName
        UserInfo("PW") = PW
        UserInfo("UserTypeID") = UserTypeID
        UserInfo("DepartmentID") = DepartmentID
        UserInfo("Active") = Active

    End Sub



    Private Sub txtUserName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserName.Validating
        ' Verify valid UserName
        Dim UserName As String
        Dim Format As New Format

        UserName = txtUserName.Text

        If UserName <> Nothing Then
            ' Check for invalid Characters
            UserName = Format.CheckName(UserName)
            If Format.GetError = True Then
                ErrorProvider.SetError(lblUserName, "Invalid Charactor have been found and removed.")
                txtUserName.Focus()
                txtUserName.SelectAll()
            End If

        End If

    End Sub

    Private Sub btnSaveUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUser.Click
        ' Saving User Info
        Dim UserName, PW, UserTypeID, DepartmentID, sql As String
        Dim UserInfo As DataRow

        ' Populate Variables
        UserName = txtUserName.Text
        PW = txtPassword.Text
        UserTypeID = cmbUserType.SelectedValue
        DepartmentID = cmbDepartment.SelectedValue

        Try
            ' Pull current User list
            Sql = "SELECT * FROM Users"
            DB.SetData(Sql)

            ' Check that all required fields are valid
            If UserName <> Nothing And PW <> Nothing And UserTypeID <> Nothing And DepartmentID <> Nothing Then
                ' check if we are adding or updating user
                If UserID = Nothing Then
                    ' Adding new user
                    UserInfo = Data.Tables("Users").NewRow

                    ' Saving new user info
                    SetUserInfo(UserInfo)

                    ' Adds to dataSet
                    Data.Tables("Users").Rows.Add(UserInfo)

                    ' Set UserID for new User
                    UserID = UserInfo("UserID")

                Else
                    ' Updating User - Find users Record
                    UserInfo = Data.Tables("Users").Rows.Find(UserID)

                    ' Update User info
                    SetUserInfo(UserInfo)

                End If

                ' Updating Table
                DB.UpdateData("Users")

                ' Update User List
                Call GetUsers()
                lstUsers.SelectedValue = UserID

                ' Show saved label
                lblSaved.Visible = True
                TimerSaved.Start()

                'Disable save Button
                ResetSave()

            Else
                If UserName = Nothing Then
                    ErrorProvider.SetError(lblUserName, "Username is required.")
                End If

                If PW = Nothing Then
                    ErrorProvider.SetError(lblPassword, "Password is required.")
                End If

                If UserTypeID = Nothing Then
                    ErrorProvider.SetError(lblUserType, "Usertype is required.")
                End If

                If DepartmentID = Nothing Then
                    ErrorProvider.SetError(lblDepartment, "Department is required.")
                End If

            End If

        Catch
            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        ' Clear Current Info 
        Call ClearUserInfo()
        lstUsers.SelectedIndex = -1
        UserID = Nothing

        ' Disable save Button until changes are made
        ResetSave()

        'Send focus to Name field
        txtUserName.Focus()

    End Sub

    Private Sub ClearUserInfo()
        txtUserName.Text = Nothing
        txtPassword.Text = Nothing
        cmbUserType.SelectedIndex = -1
        cmbDepartment.SelectedIndex = -1
        optActive.Select()
        ResetSave()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Exiting back to main menu

        ' Check if there are unsaved changes
        If btnSaveUser.Enabled = True Then
            ' Unsaved changes found - confirm exit
            If MsgBox("You have unsaved changes." & vbNewLine & "Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' Close DB Connection
                DB.Disconnect()

                ' Exit back to main main menu
                Me.Close()
            Else
                ' Unsaved changes found
                ErrorProvider.SetError(lblUserName, "Unsaved changes found.")
            End If

        Else
            'Close DB connection
            DB.Disconnect()

            ' exit back to main menu
            Me.Close()

        End If

    End Sub

    Private Sub lstUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsers.Click
        'Getting selected user information
        Dim UserName, PW, UserTypeID, DepartmentID As String
        Dim active As Integer
        Dim UserInfo As DataRow

        ' Populate Variables
        UserID = lstUsers.SelectedValue

        ' Check if ID has value
        If UserID <> Nothing Then
            ' Find selected Record 
            UserInfo = Data.Tables("Users").Rows.Find(UserID)

            UserName = UserInfo("UserName").ToString
            PW = UserInfo("PW").ToString
            UserTypeID = UserInfo("UserTypeID").ToString
            DepartmentID = UserInfo("DepartmentID").ToString
            active = UserInfo("Active")

            'Sending back to screen
            txtUserName.Text = UserName
            txtPassword.Text = PW
            cmbUserType.SelectedValue = UserTypeID
            cmbDepartment.SelectedValue = DepartmentID
            If active = -1 Then
                optActive.Checked = True
            Else
                optInactive.Checked = True

            End If

            ' Disable save Button until changes are made
            ResetSave()

        End If

    End Sub

End Class