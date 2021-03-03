Public Class frmIncentivePrograms
    Dim DB As New DataBaseWork
    Dim Data As New DataSet
    Dim IncentiveTypeID As String

    Private Sub frmIncentivePrograms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set up form

        ' Open DB Connection
        DB.Connect()

        ' Populate Current Incentive List
        GetIncentiveTypes()

        ' Disable save Button until changes are made
        ResetSave()

        ' Set default form state
        btnSave.Enabled = False
        IncentiveTypeID = Nothing

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

    Private Sub GetIncentiveTypes()
        Dim sql As String

        ' Pull current incentive list
        sql = "SELECT * FROM IncentiveTypes"
        DB.SetData(sql)
        Data = DB.GetData("IncentiveTypes")

        ' Populate Department list
        lstTypes.DisplayMember = "IncentiveName"
        lstTypes.ValueMember = "IncentiveTypeID"
        lstTypes.DataSource = Data.Tables("IncentiveTypes")
        lstTypes.SelectedIndex = -1

        ' Set PrimaryKey
        DB.SetPrimary("IncentiveTypes", "IncentiveTypeID")

    End Sub

    Private Sub TextChanges(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtType.TextChanged
        ' Info has changed enable save button
        btnSave.Enabled = True
        TimerSave.Start()
        ErrorProvider.Clear()

    End Sub

    Private Sub lstTypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTypes.Click
        Dim TypeName As String
        Dim TypeInfo As DataRow

        IncentiveTypeID = lstTypes.SelectedValue

        If IncentiveTypeID <> Nothing Then
            ' Find selected Record 
            TypeInfo = Data.Tables("IncentiveTypes").Rows.Find(IncentiveTypeID)

            'Populate Variables
            TypeName = TypeInfo("IncentiveName")

            'Send back to screen
            txtType.Text = TypeName

            ' Disable save Button until changes are made
            ResetSave()

        End If



    End Sub

    Private Sub SetData(ByRef TypeInfo As DataRow)
        Dim TypeName As String

        'Populate Variables
        TypeName = txtType.Text

        'Fill DataSet
        TypeInfo("IncentiveName") = TypeName

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Clear Fields
        IncentiveTypeID = Nothing
        txtType.Text = Nothing
        lstTypes.SelectedIndex = -1
        ResetSave()

        'Send focus to name field
        txtType.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Saving incentive Information
        Dim TypeName As String
        Dim TypeInfo As DataRow

        'Populate Variables
        TypeName = txtType.Text

        Try
            ' Verify a incentive name is entered
            If TypeName <> Nothing Then
                ' Check if we are adding department
                If IncentiveTypeID = Nothing Then
                    ' Adding a new Department
                    TypeInfo = Data.Tables("IncentiveTypes").NewRow

                    'Save incentive info
                    Call SetData(TypeInfo)

                    'Updates Dataset
                    Data.Tables("IncentiveTypes").Rows.Add(TypeInfo)

                    'Set incentiveid to new department
                    IncentiveTypeID = TypeInfo("IncentiveTypeID")

                Else
                    'Updating current incentive

                    'Find Select incentive records
                    TypeInfo = Data.Tables("IncentiveTypes").Rows.Find(IncentiveTypeID)

                    'Saves incentive Info
                    Call SetData(TypeInfo)

                End If

                ' Updating Table
                DB.UpdateData("IncentiveTypes")

                ' Update Department List
                Call GetIncentiveTypes()
                lstTypes.SelectedValue = IncentiveTypeID

                ' Show saved label
                lblSaved.Visible = True
                btnSave.Enabled = False
                TimerSaved.Start()

                ' Turn of button flash
                TimerSave.Enabled = False
                btnSave.BackColor = Color.FromKnownColor(KnownColor.Control)
                ErrorProvider.Clear()

            Else
                ErrorProvider.SetError(lblType, "Incentive name is required.")

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
                ErrorProvider.SetError(lblType, "Unsaved changes found.")
            End If

        Else
            'Close DB connection
            DB.Disconnect()

            ' exit back to main menu
            Me.Close()

        End If

    End Sub

End Class