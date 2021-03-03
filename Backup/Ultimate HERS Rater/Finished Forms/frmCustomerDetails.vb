Public Class frmCustomerDetails
    Dim DB As New DataBaseWork
    Dim Data As New DataSet
    Dim CustomerID, DivisionID, ContactID As Integer

    Private Sub frmCustomerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Open Db Connection
        DB.Connect()

        'Populate Customer List
        GetCustomers()
        lstCustomers.SelectedIndex = -1

        ' Pulling Customer Types from the database
        GetCustomerTypes()
        cmbCustomerType.SelectedIndex = -1

        ' Set default form Status
        btnSaveContact.Enabled = False
        btnSaveCustomer.Enabled = False
        btnSaveDivision.Enabled = False
        btnAddDivision.Enabled = False
        btnAddContact.Enabled = False
        lblSaved.Visible = False
        CustomerID = Nothing
        DivisionID = Nothing
        ContactID = Nothing

        ' Close Db Connection
        DB.Disconnect()

    End Sub

    Private Sub lstCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCustomers.Click
        ' Once a customer is selected - Update fields
        Try
            'Open DB Connection
            DB.Connect()

            'Store CustomerID
            CustomerID = lstCustomers.SelectedValue

            'Check for selected item
            If Not CustomerID = Nothing Then
                ' Get customer info and populate fields
                GetCustomerInfo(CustomerID)

                ' Enable Adding Divisions
                btnAddDivision.Enabled = True

                ' Lookup Customer Divisions
                GetDivisions(CustomerID)

                ' Check for customer divisions
                If lstDivisions.Items.Count <> 0 Then
                    ' Customer has divisions - choose first one
                    lstDivisions.SelectedIndex = 0

                    ' Store DivisionID
                    DivisionID = lstDivisions.SelectedValue

                    ' Populate Division info and Contactslist
                    GetDivisionInfo(DivisionID)
                    GetContacts(DivisionID)

                    'Enable Adding Contacts
                    btnAddContact.Enabled = True

                    ' Check for Division Contacts
                    If lstContacts.Items.Count <> 0 Then
                        lstContacts.SelectedIndex = 0
                        ContactID = lstContacts.SelectedValue
                        GetContactInfo(ContactID)
                    Else
                        ClearContactInfo()
                    End If

                Else
                    ' Clear Division Fields
                    ClearDivisionInfo()

                    'Clear Contact Fields
                    ClearContactInfo()
                End If
            End If

            ' Diable Save Buttons until text changed
            btnSaveCustomer.Enabled = False
            btnSaveDivision.Enabled = False
            btnSaveContact.Enabled = False
            TimerCust.Enabled = False
            TimerDiv.Enabled = False
            TimerCont.Enabled = False
            ButtonReset(btnSaveCustomer)
            ButtonReset(btnSaveDivision)
            ButtonReset(btnSaveContact)

            'Close DB Connection
            DB.Disconnect()

        Catch
            MsgBox(ErrorToString)
        End Try

    End Sub


    Private Sub lstDivisions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDivisions.Click
        ' Once a customer is selected - Update fields
        Try
            'Open DB Connection
            DB.Connect()

            ' Store Divisions ID
            DivisionID = lstDivisions.SelectedValue

            If Not DivisionID = Nothing Then
                ' Populate Divisions Details Group Box
                GetDivisionInfo(DivisionID)

                'Populate Contacts List
                GetContacts(DivisionID)

                ' Check for Division Contacts
                If lstContacts.Items.Count <> 0 Then
                    ' Division has Contacts - Choose first
                    lstContacts.SelectedIndex = 0
                    ContactID = lstContacts.SelectedValue
                    GetContactInfo(ContactID)

                Else
                    ' Clear Contact Fields
                    ClearContactInfo()

                End If
            End If

            ' Disable Save Buttons until text changed
            btnSaveDivision.Enabled = False
            btnSaveContact.Enabled = False
            TimerDiv.Enabled = False
            TimerCont.Enabled = False
            ButtonReset(btnSaveDivision)
            ButtonReset(btnSaveContact)

            'Close DB Connection
            DB.Disconnect()

        Catch
            MsgBox(ErrorToString)
        End Try

    End Sub

    Private Sub lstContacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstContacts.Click
        ' Once a Contact is selected - Update fields

        Try
            'Open DB Connection
            DB.Connect()

            ' Store Contacts ID
            ContactID = lstContacts.SelectedValue

            If Not ContactID = Nothing Then
                'Populate Contacts Group box 
                GetContactInfo(ContactID)

            End If

            ' Disable save Button until changes are made
            btnSaveContact.Enabled = False
            TimerCont.Enabled = False
            ButtonReset(btnSaveContact)

            'close DB Connection
            DB.Disconnect()

        Catch
            MsgBox(ErrorToString)
        End Try

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

        'set PrimaryKey
        DB.SetPrimary("Customers", "CustomerID")

        'Populate Combobox
        lstCustomers.DisplayMember = "CustomerName"
        lstCustomers.ValueMember = "CustomerID"
        lstCustomers.DataSource = Data.Tables("Customers")

    End Sub

    Private Sub GetCustomerTypes()
        Dim sql As String
        ' Pulling Customer Types from the database
        Sql = "SELECT * FROM CustomerTypes"
        DB.SetData(Sql)
        Data = DB.GetData("CustomerTypes")

        ' Populate Customer Type List
        cmbCustomerType.DisplayMember = "CustomerType"
        cmbCustomerType.ValueMember = "CustomerTypeID"
        cmbCustomerType.DataSource = Data.Tables("CustomerTypes")

    End Sub

    Private Sub GetCustomerInfo(ByVal ID As Integer)
        'Finding Selected Contact info
        Dim CustomerInfo As DataRow
        CustomerInfo = Data.Tables("Customers").Rows.Find(ID)

        'Population Customer Fields
        txtCustomerName.Text = CustomerInfo.Item("CustomerName").ToString
        cmbCustomerType.SelectedValue = CustomerInfo.Item("CustomerTypeID")


    End Sub

    Private Sub SetCustomerInfo(ByRef CustomerInfo As DataRow)
        Dim CustomerName As String
        Dim CustomerTypeID As String

        ' Setup Dataset
        Dim sql = "SELECT * FROM Customers"
        DB.SetData(sql)

        'Populate Variables
        CustomerName = txtCustomerName.Text
        CustomerTypeID = cmbCustomerType.SelectedValue

        ' Check to see if customer info is entered
        If CustomerName <> Nothing And CustomerTypeID <> Nothing Then
            'Populate Data Row
            CustomerInfo("CustomerName") = CustomerName
            CustomerInfo("CustomerTypeID") = CustomerTypeID
        Else
            ' Customer info not entered
            If CustomerName <> Nothing Then
                ErrorProvider.SetError(lblCustomerName, "A customer name is required.")
            End If
            If CustomerTypeID <> Nothing Then
                ErrorProvider.SetError(lblCustomerType, "A customer type is require.")
            End If
        End If

    End Sub

    Private Sub ClearCustomerInfo()
        ' Clear Customer Info
        txtCustomerName.Text = Nothing
        cmbCustomerType.SelectedIndex = -1

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

        'Set Primarykey
        DB.SetPrimary("Divisions", "DivisionID")

        'Populate Divisions List box
        lstDivisions.DisplayMember = "DivisionName"
        lstDivisions.ValueMember = "DivisionID"
        lstDivisions.DataSource = Data.Tables("Divisions")

    End Sub

    Private Sub GetDivisionInfo(ByVal ID As Integer)
        'Finding Selected Contact info
        Dim DivisionInfo As DataRow
        DivisionInfo = Data.Tables("Divisions").Rows.Find(ID)

        ' Populating Division Fields
        txtDivisionName.Text = DivisionInfo.Item("DivisionName").ToString
        txtStreet.Text = DivisionInfo.Item("Street").ToString
        txtCity.Text = DivisionInfo.Item("City").ToString
        txtState.Text = DivisionInfo.Item("State").ToString
        txtZipCode.Text = DivisionInfo.Item("Zipcode").ToString
        If DivisionInfo.Item("Active") = -1 Then
            optActiveDivision.Select()
        Else
            optInactiveDivision.Select()
        End If


    End Sub
    Private Sub SetDivisionInfo(ByRef DivisionInfo As DataRow)
        Dim DivisionName, Street, City, State, zipcode As String
        Dim DivisionActive As Short

        ' Setup Dataset
        Dim sql = "SELECT * FROM CustomerDivisions WHERE CustomerID =" & DivisionID
        DB.SetData(sql)

        'Populate Variables
        DivisionName = txtDivisionName.Text
        Street = txtStreet.Text
        State = txtState.Text
        City = txtCity.Text
        zipcode = txtZipCode.Text

        'Check Division Status
        If optActiveDivision.Checked = False Then
            DivisionActive = 0
        Else
            DivisionActive = -1
        End If

        ' Check for division name entered
        If DivisionName <> Nothing Then
            'Populates DataRow
            DivisionInfo("CustomerID") = CustomerID
            DivisionInfo("DivisionName") = DivisionName
            DivisionInfo("Street") = Street
            DivisionInfo("City") = City
            DivisionInfo("State") = State
            DivisionInfo("ZipCode") = zipcode
            DivisionInfo("Active") = DivisionActive
        Else
            ' division name not entered
            ErrorProvider.SetError(lblDivisionName, "A division name is required.")
        End If


    End Sub

    Private Sub ClearDivisionInfo()
        ' Clear Division Fields
        txtDivisionName.Text = Nothing
        txtStreet.Text = Nothing
        txtCity.Text = Nothing
        txtState.Text = Nothing
        txtZipCode.Text = Nothing
        optActiveDivision.Select()
        GetDivisions(CustomerID)

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

        'Set Primarykey
        DB.SetPrimary("Contacts", "ContactID")

        'Populate Contacts List box
        lstContacts.DisplayMember = "ContactName"
        lstContacts.ValueMember = "ContactID"
        lstContacts.DataSource = Data.Tables("Contacts")

    End Sub
    Private Sub GetContactInfo(ByVal ID As Integer)
        'Finding Selected Contact info
        Dim ContactInfo As DataRow
        ContactInfo = Data.Tables("Contacts").Rows.Find(ID)

        ' Populating Fields from record
        txtName.Text = ContactInfo.Item("ContactName").ToString
        txtEmail.Text = ContactInfo.Item("Email").ToString
        txtPhone.Text = ContactInfo.Item("Phone").ToString
        txtMobile.Text = ContactInfo.Item("Mobile").ToString
        txtFax.Text = ContactInfo.Item("Fax").ToString
        If ContactInfo.Item("Active") = -1 Then
            optActiveContact.Select()
        Else
            optInactiveContact.Select()
        End If

    End Sub

    Private Sub SetContactInfo(ByRef ContactInfo As DataRow)
        Dim ContactName, ContactEmail, ContactPhone, ContactMobile, ContactFax As String
        Dim ContactActive As Short

        ' Setup Dataset
        Dim sql = "SELECT * FROM CustomerContacts WHERE DivisionID =" & ContactID
        DB.SetData(sql)

        ' Populate Variables
        ContactName = txtName.Text
        ContactEmail = txtEmail.Text
        ContactPhone = txtPhone.Text
        ContactMobile = txtMobile.Text
        ContactFax = txtFax.Text
        'Check Contact Status
        If optActiveContact.Checked = False Then
            ContactActive = 0
        Else
            ContactActive = -1
        End If

        'Check for contact name before saving
        If ContactName <> Nothing Then
            ' Populate the DataRow
            ContactInfo("DivisionID") = DivisionID
            ContactInfo("ContactName") = Trim(ContactName)
            ContactInfo("Email") = ContactEmail
            ContactInfo("Phone") = ContactPhone
            ContactInfo("Mobile") = ContactMobile
            ContactInfo("Fax") = ContactFax
            ContactInfo("Active") = ContactActive

        Else
            ' Contact name not entered
            ErrorProvider.SetError(lblName, "A contact name is required.")

        End If

    End Sub

    Private Sub ClearContactInfo()
        ' Clear Contact Fields
        txtName.Text = Nothing
        txtEmail.Text = Nothing
        txtPhone.Text = Nothing
        txtMobile.Text = Nothing
        txtFax.Text = Nothing
        optActiveContact.Select()
        GetContacts(DivisionID)

    End Sub

    Private Sub btnAddCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCustomer.Click
        'Clear Current info
        ClearCustomerInfo()
        lstCustomers.SelectedIndex = -1
        CustomerID = Nothing

        ' Clear Division Info
        ClearDivisionInfo()
        lstDivisions.SelectedIndex = -1
        DivisionID = Nothing

        ' Clear Contacts Info
        ClearContactInfo()
        ContactID = Nothing

        ' Send focus to Customer Name
        txtCustomerName.Focus()

    End Sub

    Private Sub btnAddDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDivision.Click
        ' Clear Current Info
        ClearDivisionInfo()
        lstDivisions.SelectedIndex = -1
        DivisionID = Nothing

        ' Clear Contacts Info
        ClearContactInfo()
        ContactID = Nothing

        ' Send focus to Division Name
        txtDivisionName.Focus()

    End Sub

    Private Sub btnAddContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddContact.Click
        ' Clear Current Info 
        ClearContactInfo()
        lstContacts.SelectedIndex = -1
        ContactID = Nothing

        'Send focus to Name field
        txtName.Focus()

    End Sub

    Private Sub CustomerInfo_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerName.TextChanged, cmbCustomerType.SelectionChangeCommitted
        'Text Changed - Enable Save Button
        btnSaveCustomer.Enabled = True
        BlinkCust()
        ErrorProvider.Clear()

    End Sub

    Private Sub DivisionInfo_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDivisionName.TextChanged, txtStreet.TextChanged, txtCity.TextChanged, txtState.TextChanged, txtZipCode.TextChanged, optActiveDivision.CheckedChanged, optInactiveDivision.CheckedChanged
        'Text Changed - Enable Save Button
        btnSaveDivision.Enabled = True
        BlinkDiv()
        ErrorProvider.Clear()

    End Sub

    Private Sub ContactInfo_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged, txtEmail.TextChanged, optActiveContact.CheckedChanged, optInactiveContact.CheckedChanged
        ' Text Changed = Enable Save button
        btnSaveContact.Enabled = True
        BlinkCont()
        ErrorProvider.Clear()

    End Sub

    Private Sub btnSaveContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveContact.Click
        ' Saving Contact Information
        Dim ContactInfo As DataRow

        'Open DB Connection
        DB.Connect()

        Try

            If DivisionID <> Nothing Then

                ' Check to see if a contact is selected 
                If ContactID = Nothing Then
                    ' Adding a new Contact
                    ContactInfo = Data.Tables("Contacts").NewRow

                    'Saving the Contact info
                    SetContactInfo(ContactInfo)

                    ' Adds to dataSet
                    Data.Tables("Contacts").Rows.Add(ContactInfo)

                    'Set New ContactID as selected
                    ContactID = ContactInfo("ContactID")


                Else
                    ' Updating selected Contact
                    ContactInfo = Data.Tables("Contacts").Rows.Find(ContactID)

                    'Saving the Contact info
                    SetContactInfo(ContactInfo)

                End If

                ' Update Table
                DB.UpdateData("Contacts")

                'Refresh list from DB
                GetContacts(DivisionID)
                lstContacts.SelectedValue = ContactID

                ' Show saved label
                ShowSaved("Contact")

                ' Turn of button flash
                TimerCont.Enabled = False
                ButtonReset(btnSaveContact)

                'Clear any Error messages
                ErrorProvider.SetError(lblName, "")

            Else
                ErrorProvider.SetError(lblDivisionName, "Division is not saved yet")

            End If

        Catch
            ' Error occured
            MsgBox(ErrorToString)

        End Try

        ' Close DB Connection
        DB.Disconnect()

    End Sub

    Private Sub btnSaveDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDivision.Click
        ' Saving Division Information
        Dim DivisionInfo As DataRow

        'Open DB Connection
        DB.Connect()

        Try

            If CustomerID <> Nothing Then

                ' Check to see if a contact is selected 
                If DivisionID = Nothing Then
                    ' Adding a new Contact
                    DivisionInfo = Data.Tables("Divisions").NewRow

                    'Saving the Contact info
                    SetDivisionInfo(DivisionInfo)

                    ' Adds to dataSet
                    Data.Tables("Divisions").Rows.Add(DivisionInfo)

                    'Set New ContactID as selected
                    DivisionID = DivisionInfo("DivisionID")

                Else
                    ' Updating selected Contact
                    DivisionInfo = Data.Tables("Divisions").Rows.Find(DivisionID)

                    'Saving the Contact info
                    SetDivisionInfo(DivisionInfo)

                End If

                ' Update Table
                DB.UpdateData("Divisions")

                'Refresh list from DB
                GetDivisions(CustomerID)
                lstDivisions.SelectedValue = DivisionID

                ' Show saved label
                ShowSaved("Division")

                ' Turn off button flash
                TimerDiv.Enabled = False
                ButtonReset(btnSaveDivision)

                'Clear any Error messages
                ErrorProvider.SetError(lblDivisionName, "")

            Else
                ErrorProvider.SetError(lblCustomerName, "Customer is not saved yet")

            End If

        Catch
            ' Error occured
            MsgBox(ErrorToString)

        End Try

        ' Close DB Connection
        DB.Disconnect()

    End Sub

    Private Sub btnSaveCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCustomer.Click
        ' Saving Customer Information
        Dim CustomerInfo As DataRow

        'Open DB Connection
        DB.Connect()

        Try

            ' Check to see if a Customer is selected 
            If CustomerID = Nothing Then
                ' Adding a new Customer
                CustomerInfo = Data.Tables("Customers").NewRow

                'Saving the Customer info
                SetCustomerInfo(CustomerInfo)

                ' Adds to dataSet
                Data.Tables("Customers").Rows.Add(CustomerInfo)

                'Set New CustomerID as selected
                CustomerID = CustomerInfo("CustomerID")


            Else
                ' Updating selected Customer
                CustomerInfo = Data.Tables("Customers").Rows.Find(CustomerID)

                'Saving the Customer info
                SetCustomerInfo(CustomerInfo)

            End If

            ' Update Table
            DB.UpdateData("Customers")

            'Refresh list from DB
            GetCustomers()
            lstCustomers.SelectedValue = CustomerID

            ' Show saved label
            ShowSaved("Customer")

            'Turn off button flash
            TimerCust.Enabled = False
            ButtonReset(btnSaveCustomer)

            'Clear any Error messages
            ErrorProvider.SetError(lblCustomerName, "")

        Catch
            ' Error occured
            MsgBox(ErrorToString)

        End Try

        'Close DB Connection
        DB.Disconnect()

    End Sub

    Private Sub ZipCode_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZipCode.Validating
        Dim format As New Format
        Dim ZipCode As String

        ZipCode = txtZipCode.Text

        ' Validate state
        If ZipCode <> Nothing Then
            ZipCode = format.ZipCode(ZipCode)
            If format.GetError() = True Then
                txtZipCode.Focus()
            End If
        End If

    End Sub

    Private Sub State_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtState.Validating
        Dim format As New Format
        Dim state As String

        state = txtState.Text

        ' Validate state
        If state <> Nothing Then
            txtState.Text = format.State(state)
            If format.GetError() = True Then
                txtState.Focus()
            End If
        End If

    End Sub

    Private Sub Email_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.Validating
        Dim format As New Format
        Dim email As String

        email = txtEmail.Text

        ' Validate email
        If email <> Nothing Then
            If format.ValidEmail(email) = True Then
                If format.GetError() = True Then
                    txtEmail.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub Fax_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.Validating
        Dim Number As String

        Number = txtFax.Text

        ' Validate number
        ValidatePhone(txtFax, Number)

    End Sub

    Private Sub Mobile_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobile.Validating
        Dim Number As String

        Number = txtMobile.Text

        ' Validate number
        ValidatePhone(txtMobile, Number)

    End Sub

    Private Sub Phone_change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.Validating
        Dim Number As String

        Number = txtPhone.Text

        ' Validate number
        ValidatePhone(txtPhone, Number)

    End Sub

    Private Sub ValidatePhone(ByVal sender As Control, ByVal Input As String)
        Dim format As New Format

        'Check if phone number is entered
        If Input <> Nothing Then
            'Format Number
            sender.Text = format.PhoneNumber(Input)
            If format.GetError() = True Then
                sender.Focus()
            End If
        End If

    End Sub

    Private Sub BlinkDiv()
        TimerDiv.Interval = 500
        TimerDiv.Start()

    End Sub

    Private Sub BlinkCust()
        TimerCust.Interval = 500
        TimerCust.Start()

    End Sub

    Private Sub BlinkCont()
        TimerCont.Interval = 500
        TimerCont.Start()

    End Sub

    Private Sub ShowSaved(ByVal Saver As String)

        lblSaved.Text = Saver & " Saved"
        lblSaved.Visible = True
        TimerSaved.Start()

    End Sub

    Private Sub TimerTick() Handles TimerDiv.Tick
        If btnSaveDivision.BackColor = Color.FromKnownColor(KnownColor.Control) Then
            btnSaveDivision.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight)
        Else
            btnSaveDivision.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If

    End Sub

    Private Sub TimerCustTick() Handles TimerCust.Tick
        If btnSaveCustomer.BackColor = Color.FromKnownColor(KnownColor.Control) Then
            btnSaveCustomer.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight)
        Else
            btnSaveCustomer.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If

    End Sub

    Private Sub TimerContTick() Handles TimerCont.Tick
        If btnSaveContact.BackColor = Color.FromKnownColor(KnownColor.Control) Then
            btnSaveContact.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight)
        Else
            btnSaveContact.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If

    End Sub

    Private Sub timersavedtick() Handles TimerSaved.Tick
        If lblSaved.Visible = True Then
            lblSaved.Visible = False
            TimerSaved.Stop()
        End If

    End Sub

    Private Sub ButtonReset(ByVal Button As Control)
        Button.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button.Enabled = False

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Go back to main menu

        ' Check to see if there are unsaved changes
        If btnSaveContact.Enabled = True Or btnSaveCustomer.Enabled = True Or btnSaveDivision.Enabled = True Then
            ' Unsaved changes present - confirm exit
            If MsgBox("You have unsaved changes." & vbNewLine & "Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' exit to main menu
                frmMainMenu.Show()
                Me.Close()

            Else
                ' Check for unsaved changes at each group box 
                If btnSaveContact.Enabled = True Then
                    ' unsaved Contact changes found
                    ErrorProvider.SetError(lblName, "Unsaved contact changes found.")
                    btnSaveContact.Focus()
                End If

                If btnSaveDivision.Enabled = True Then
                    ' unsaved Division changes found
                    ErrorProvider.SetError(lblDivisionName, "Unsaved division changes found.")
                    btnSaveDivision.Focus()
                End If

                If btnSaveCustomer.Enabled = True Then
                    ' unsaved Customer changes found
                    ErrorProvider.SetError(lblCustomerName, "Unsaved customer changes found.")
                    btnSaveCustomer.Focus()
                End If

            End If
        Else
            ' exit to main menu
            frmMainMenu.Show()
            Me.Close()

        End If

    End Sub




End Class