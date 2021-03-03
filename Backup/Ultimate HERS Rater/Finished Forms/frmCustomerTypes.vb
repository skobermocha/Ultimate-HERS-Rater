Public Class frmCustomerTypes
    Dim DB As New DataBaseWork
    Dim Data As New DataSet
    Dim CustomerTypeID As String

    Private Sub frmDepartments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set up form

        ' Open DB Connection
        DB.Connect()

        ' Populate Current Department List
        Call GetCustomerTypes()

        ' Disable save Button until changes are made
        ResetSave()

        ' Set default form state
        btnSave.Enabled = False
        CustomerTypeID = Nothing

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

    Private Sub GetCustomerTypes()
        Dim sql As String

        ' Pull current Department list
        sql = "SELECT * FROM CustomerTypes"
        DB.SetData(sql)
        Data = DB.GetData("CustomerTypes")

        ' Populate Department list
        lstTypes.DisplayMember = "CustomerType"
        lstTypes.ValueMember = "CustomerTypeID"
        lstTypes.DataSource = Data.Tables("CustomerTypes")
        lstTypes.SelectedIndex = -1

        'Set primaryKey
        DB.SetPrimary("CustomerTypes", "CustomerTypeID")

    End Sub

    Private Sub txtDepartName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtType.TextChanged
        ' Info has changed enable save button
        btnSave.Enabled = True
        TimerSave.Start()
        ErrorProvider.Clear()

    End Sub

    Private Sub lstDepartments_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTypes.Click
        Dim TypeName As String
        Dim TypeInfo As DataRow

        CustomerTypeID = lstTypes.SelectedValue

        If CustomerTypeID <> Nothing Then
            ' Find selected Record 
            TypeInfo = Data.Tables("CustomerTypes").Rows.Find(CustomerTypeID)

            'Populate Variables
            TypeName = TypeInfo("CustomerType")

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
        TypeInfo("CustomerType") = TypeName

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Clear Fields
        CustomerTypeID = Nothing
        txtType.Text = Nothing
        lstTypes.SelectedIndex = -1
        ResetSave()

        'Sending focus to name field
        txtType.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Saving Department Information
        Dim TypeName As String
        Dim TypeInfo As DataRow

        'Populate Variables
        TypeName = txtType.Text

        Try
            ' Verify a department name is entered
            If TypeName <> Nothing Then
                ' Check if we are adding department
                If CustomerTypeID = Nothing Then
                    ' Adding a new Department
                    TypeInfo = Data.Tables("CustomerTypes").NewRow

                    'Save Department info
                    Call SetData(TypeInfo)

                    'Updates Dataset
                    Data.Tables("CustomerTypes").Rows.Add(TypeInfo)

                    'Set DepartmentID to new department
                    CustomerTypeID = TypeInfo("CustomerTypes")

                Else
                    'Updating current Department

                    'Find Select department records
                    TypeInfo = Data.Tables("CustomerTypes").Rows.Find(CustomerTypeID)

                    'Saves Department Info
                    Call SetData(TypeInfo)

                End If

                ' Updating Table
                DB.UpdateData("CustomerTypes")

                ' Update Department List
                Call GetCustomerTypes()
                lstTypes.SelectedValue = CustomerTypeID

                ' Show saved label
                lblSaved.Visible = True
                TimerSaved.Start()
                ResetSave()

            Else
                ErrorProvider.SetError(lblType, "Customer type name is required.")

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