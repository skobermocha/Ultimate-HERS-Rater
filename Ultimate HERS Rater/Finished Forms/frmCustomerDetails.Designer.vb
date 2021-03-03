<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.grbContacts = New System.Windows.Forms.GroupBox
        Me.txtMobile = New System.Windows.Forms.MaskedTextBox
        Me.txtFax = New System.Windows.Forms.MaskedTextBox
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox
        Me.optActiveContact = New System.Windows.Forms.RadioButton
        Me.optInactiveContact = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.btnSaveContact = New System.Windows.Forms.Button
        Me.btnAddContact = New System.Windows.Forms.Button
        Me.lstContacts = New System.Windows.Forms.ListBox
        Me.lblFax = New System.Windows.Forms.Label
        Me.lblMobile = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.grbDivisions = New System.Windows.Forms.GroupBox
        Me.optActiveDivision = New System.Windows.Forms.RadioButton
        Me.optInactiveDivision = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDivisionName = New System.Windows.Forms.TextBox
        Me.btnSaveDivision = New System.Windows.Forms.Button
        Me.btnAddDivision = New System.Windows.Forms.Button
        Me.lstDivisions = New System.Windows.Forms.ListBox
        Me.lblZipCode = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblStreet = New System.Windows.Forms.Label
        Me.txtZipCode = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtStreet = New System.Windows.Forms.TextBox
        Me.lblDivisionName = New System.Windows.Forms.Label
        Me.grbCustomer = New System.Windows.Forms.GroupBox
        Me.btnAddCustomer = New System.Windows.Forms.Button
        Me.lblCustomerType = New System.Windows.Forms.Label
        Me.cmbCustomerType = New System.Windows.Forms.ComboBox
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.btnSaveCustomer = New System.Windows.Forms.Button
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.grbList = New System.Windows.Forms.GroupBox
        Me.lstCustomers = New System.Windows.Forms.ListBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TimerDiv = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCust = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCont = New System.Windows.Forms.Timer(Me.components)
        Me.lblSaved = New System.Windows.Forms.Label
        Me.TimerSaved = New System.Windows.Forms.Timer(Me.components)
        Me.grbContacts.SuspendLayout()
        Me.grbDivisions.SuspendLayout()
        Me.grbCustomer.SuspendLayout()
        Me.grbList.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbContacts
        '
        Me.grbContacts.Controls.Add(Me.txtMobile)
        Me.grbContacts.Controls.Add(Me.txtFax)
        Me.grbContacts.Controls.Add(Me.txtPhone)
        Me.grbContacts.Controls.Add(Me.optActiveContact)
        Me.grbContacts.Controls.Add(Me.optInactiveContact)
        Me.grbContacts.Controls.Add(Me.Label6)
        Me.grbContacts.Controls.Add(Me.txtName)
        Me.grbContacts.Controls.Add(Me.btnSaveContact)
        Me.grbContacts.Controls.Add(Me.btnAddContact)
        Me.grbContacts.Controls.Add(Me.lstContacts)
        Me.grbContacts.Controls.Add(Me.lblFax)
        Me.grbContacts.Controls.Add(Me.lblMobile)
        Me.grbContacts.Controls.Add(Me.lblPhone)
        Me.grbContacts.Controls.Add(Me.lblEmail)
        Me.grbContacts.Controls.Add(Me.txtEmail)
        Me.grbContacts.Controls.Add(Me.lblName)
        Me.grbContacts.Location = New System.Drawing.Point(233, 282)
        Me.grbContacts.Name = "grbContacts"
        Me.grbContacts.Padding = New System.Windows.Forms.Padding(10)
        Me.grbContacts.Size = New System.Drawing.Size(520, 181)
        Me.grbContacts.TabIndex = 3
        Me.grbContacts.TabStop = False
        Me.grbContacts.Text = "Customer Contacts"
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(119, 142)
        Me.txtMobile.Mask = "(999) 000-0000"
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(100, 22)
        Me.txtMobile.TabIndex = 3
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(225, 143)
        Me.txtFax.Mask = "(999) 000-0000"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(100, 22)
        Me.txtFax.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(13, 142)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 22)
        Me.txtPhone.TabIndex = 2
        '
        'optActiveContact
        '
        Me.optActiveContact.AutoSize = True
        Me.optActiveContact.Location = New System.Drawing.Point(183, 20)
        Me.optActiveContact.Name = "optActiveContact"
        Me.optActiveContact.Size = New System.Drawing.Size(59, 19)
        Me.optActiveContact.TabIndex = 29
        Me.optActiveContact.Text = "Active"
        Me.optActiveContact.UseVisualStyleBackColor = True
        '
        'optInactiveContact
        '
        Me.optInactiveContact.AutoSize = True
        Me.optInactiveContact.Location = New System.Drawing.Point(248, 20)
        Me.optInactiveContact.Name = "optInactiveContact"
        Me.optInactiveContact.Size = New System.Drawing.Size(67, 19)
        Me.optInactiveContact.TabIndex = 28
        Me.optInactiveContact.Text = "Inactive"
        Me.optInactiveContact.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Contact List"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(13, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(312, 22)
        Me.txtName.TabIndex = 0
        '
        'btnSaveContact
        '
        Me.btnSaveContact.Location = New System.Drawing.Point(467, 14)
        Me.btnSaveContact.Name = "btnSaveContact"
        Me.btnSaveContact.Size = New System.Drawing.Size(40, 25)
        Me.btnSaveContact.TabIndex = 5
        Me.btnSaveContact.Text = "Save"
        Me.btnSaveContact.UseVisualStyleBackColor = True
        '
        'btnAddContact
        '
        Me.btnAddContact.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddContact.Location = New System.Drawing.Point(423, 14)
        Me.btnAddContact.Name = "btnAddContact"
        Me.btnAddContact.Size = New System.Drawing.Size(40, 25)
        Me.btnAddContact.TabIndex = 6
        Me.btnAddContact.Text = "Add"
        Me.btnAddContact.UseVisualStyleBackColor = True
        '
        'lstContacts
        '
        Me.lstContacts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstContacts.FormattingEnabled = True
        Me.lstContacts.ItemHeight = 16
        Me.lstContacts.Location = New System.Drawing.Point(331, 42)
        Me.lstContacts.Name = "lstContacts"
        Me.lstContacts.Size = New System.Drawing.Size(176, 116)
        Me.lstContacts.TabIndex = 7
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(222, 125)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(25, 15)
        Me.lblFax.TabIndex = 9
        Me.lblFax.Text = "Fax"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(116, 125)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(45, 15)
        Me.lblMobile.TabIndex = 8
        Me.lblMobile.Text = "Mobile"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(10, 124)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(42, 15)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "Phone"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(10, 74)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(36, 15)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(13, 92)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(312, 22)
        Me.txtEmail.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(10, 26)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(40, 15)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'grbDivisions
        '
        Me.grbDivisions.Controls.Add(Me.optActiveDivision)
        Me.grbDivisions.Controls.Add(Me.optInactiveDivision)
        Me.grbDivisions.Controls.Add(Me.Label7)
        Me.grbDivisions.Controls.Add(Me.txtDivisionName)
        Me.grbDivisions.Controls.Add(Me.btnSaveDivision)
        Me.grbDivisions.Controls.Add(Me.btnAddDivision)
        Me.grbDivisions.Controls.Add(Me.lstDivisions)
        Me.grbDivisions.Controls.Add(Me.lblZipCode)
        Me.grbDivisions.Controls.Add(Me.lblState)
        Me.grbDivisions.Controls.Add(Me.lblCity)
        Me.grbDivisions.Controls.Add(Me.lblStreet)
        Me.grbDivisions.Controls.Add(Me.txtZipCode)
        Me.grbDivisions.Controls.Add(Me.txtState)
        Me.grbDivisions.Controls.Add(Me.txtCity)
        Me.grbDivisions.Controls.Add(Me.txtStreet)
        Me.grbDivisions.Controls.Add(Me.lblDivisionName)
        Me.grbDivisions.Location = New System.Drawing.Point(233, 99)
        Me.grbDivisions.Name = "grbDivisions"
        Me.grbDivisions.Padding = New System.Windows.Forms.Padding(10)
        Me.grbDivisions.Size = New System.Drawing.Size(520, 177)
        Me.grbDivisions.TabIndex = 2
        Me.grbDivisions.TabStop = False
        Me.grbDivisions.Text = "Customer Divisions"
        '
        'optActiveDivision
        '
        Me.optActiveDivision.AutoSize = True
        Me.optActiveDivision.Location = New System.Drawing.Point(183, 22)
        Me.optActiveDivision.Name = "optActiveDivision"
        Me.optActiveDivision.Size = New System.Drawing.Size(59, 19)
        Me.optActiveDivision.TabIndex = 27
        Me.optActiveDivision.Text = "Active"
        Me.optActiveDivision.UseVisualStyleBackColor = True
        '
        'optInactiveDivision
        '
        Me.optInactiveDivision.AutoSize = True
        Me.optInactiveDivision.Location = New System.Drawing.Point(248, 22)
        Me.optInactiveDivision.Name = "optInactiveDivision"
        Me.optInactiveDivision.Size = New System.Drawing.Size(67, 19)
        Me.optInactiveDivision.TabIndex = 26
        Me.optInactiveDivision.Text = "Inactive"
        Me.optInactiveDivision.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(328, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Division List"
        '
        'txtDivisionName
        '
        Me.txtDivisionName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisionName.Location = New System.Drawing.Point(13, 42)
        Me.txtDivisionName.Name = "txtDivisionName"
        Me.txtDivisionName.Size = New System.Drawing.Size(312, 22)
        Me.txtDivisionName.TabIndex = 0
        '
        'btnSaveDivision
        '
        Me.btnSaveDivision.Location = New System.Drawing.Point(467, 14)
        Me.btnSaveDivision.Name = "btnSaveDivision"
        Me.btnSaveDivision.Size = New System.Drawing.Size(40, 25)
        Me.btnSaveDivision.TabIndex = 5
        Me.btnSaveDivision.Text = "Save"
        Me.btnSaveDivision.UseVisualStyleBackColor = True
        '
        'btnAddDivision
        '
        Me.btnAddDivision.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDivision.Location = New System.Drawing.Point(423, 14)
        Me.btnAddDivision.Name = "btnAddDivision"
        Me.btnAddDivision.Size = New System.Drawing.Size(40, 25)
        Me.btnAddDivision.TabIndex = 6
        Me.btnAddDivision.Text = "Add"
        Me.btnAddDivision.UseVisualStyleBackColor = True
        '
        'lstDivisions
        '
        Me.lstDivisions.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDivisions.FormattingEnabled = True
        Me.lstDivisions.ItemHeight = 16
        Me.lstDivisions.Location = New System.Drawing.Point(331, 42)
        Me.lstDivisions.Name = "lstDivisions"
        Me.lstDivisions.Size = New System.Drawing.Size(176, 116)
        Me.lstDivisions.TabIndex = 7
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(261, 125)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(54, 15)
        Me.lblZipCode.TabIndex = 9
        Me.lblZipCode.Text = "Zip Code"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(219, 125)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(36, 15)
        Me.lblState.TabIndex = 8
        Me.lblState.Text = "State"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(10, 125)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(28, 15)
        Me.lblCity.TabIndex = 7
        Me.lblCity.Text = "City"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(10, 77)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(136, 15)
        Me.lblStreet.TabIndex = 6
        Me.lblStreet.Text = "Street Address - Suite #"
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(257, 142)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(68, 22)
        Me.txtZipCode.TabIndex = 4
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(222, 142)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(29, 22)
        Me.txtState.TabIndex = 3
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(13, 142)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(203, 22)
        Me.txtCity.TabIndex = 2
        '
        'txtStreet
        '
        Me.txtStreet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(13, 92)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(312, 22)
        Me.txtStreet.TabIndex = 1
        '
        'lblDivisionName
        '
        Me.lblDivisionName.AutoSize = True
        Me.lblDivisionName.Location = New System.Drawing.Point(10, 24)
        Me.lblDivisionName.Name = "lblDivisionName"
        Me.lblDivisionName.Size = New System.Drawing.Size(40, 15)
        Me.lblDivisionName.TabIndex = 1
        Me.lblDivisionName.Text = "Name"
        '
        'grbCustomer
        '
        Me.grbCustomer.Controls.Add(Me.btnAddCustomer)
        Me.grbCustomer.Controls.Add(Me.lblCustomerType)
        Me.grbCustomer.Controls.Add(Me.cmbCustomerType)
        Me.grbCustomer.Controls.Add(Me.txtCustomerName)
        Me.grbCustomer.Controls.Add(Me.btnSaveCustomer)
        Me.grbCustomer.Controls.Add(Me.lblCustomerName)
        Me.grbCustomer.Location = New System.Drawing.Point(233, 12)
        Me.grbCustomer.Name = "grbCustomer"
        Me.grbCustomer.Padding = New System.Windows.Forms.Padding(10)
        Me.grbCustomer.Size = New System.Drawing.Size(520, 81)
        Me.grbCustomer.TabIndex = 1
        Me.grbCustomer.TabStop = False
        Me.grbCustomer.Text = "Customer Details"
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.Location = New System.Drawing.Point(467, 14)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(40, 25)
        Me.btnAddCustomer.TabIndex = 3
        Me.btnAddCustomer.Text = "Add"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'lblCustomerType
        '
        Me.lblCustomerType.AutoSize = True
        Me.lblCustomerType.Location = New System.Drawing.Point(328, 24)
        Me.lblCustomerType.Name = "lblCustomerType"
        Me.lblCustomerType.Size = New System.Drawing.Size(33, 15)
        Me.lblCustomerType.TabIndex = 26
        Me.lblCustomerType.Text = "Type"
        '
        'cmbCustomerType
        '
        Me.cmbCustomerType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomerType.FormattingEnabled = True
        Me.cmbCustomerType.Location = New System.Drawing.Point(331, 42)
        Me.cmbCustomerType.Name = "cmbCustomerType"
        Me.cmbCustomerType.Size = New System.Drawing.Size(132, 24)
        Me.cmbCustomerType.TabIndex = 1
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(13, 42)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(312, 22)
        Me.txtCustomerName.TabIndex = 0
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Location = New System.Drawing.Point(467, 40)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(40, 25)
        Me.btnSaveCustomer.TabIndex = 2
        Me.btnSaveCustomer.Text = "Save"
        Me.btnSaveCustomer.UseVisualStyleBackColor = True
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(10, 24)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(40, 15)
        Me.lblCustomerName.TabIndex = 1
        Me.lblCustomerName.Text = "Name"
        '
        'grbList
        '
        Me.grbList.Controls.Add(Me.lstCustomers)
        Me.grbList.Location = New System.Drawing.Point(12, 12)
        Me.grbList.Name = "grbList"
        Me.grbList.Size = New System.Drawing.Size(213, 450)
        Me.grbList.TabIndex = 0
        Me.grbList.TabStop = False
        Me.grbList.Text = "Customer List"
        '
        'lstCustomers
        '
        Me.lstCustomers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.ItemHeight = 16
        Me.lstCustomers.Location = New System.Drawing.Point(6, 19)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(201, 420)
        Me.lstCustomers.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(665, 482)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'TimerDiv
        '
        '
        'TimerCust
        '
        '
        'TimerCont
        '
        '
        'lblSaved
        '
        Me.lblSaved.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSaved.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.Red
        Me.lblSaved.Location = New System.Drawing.Point(279, 482)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(207, 14)
        Me.lblSaved.TabIndex = 14
        Me.lblSaved.Text = "Customer Saved"
        Me.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSaved.Visible = False
        '
        'TimerSaved
        '
        Me.TimerSaved.Interval = 1000
        '
        'frmCustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 519)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grbList)
        Me.Controls.Add(Me.grbCustomer)
        Me.Controls.Add(Me.grbDivisions)
        Me.Controls.Add(Me.grbContacts)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCustomerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details"
        Me.grbContacts.ResumeLayout(False)
        Me.grbContacts.PerformLayout()
        Me.grbDivisions.ResumeLayout(False)
        Me.grbDivisions.PerformLayout()
        Me.grbCustomer.ResumeLayout(False)
        Me.grbCustomer.PerformLayout()
        Me.grbList.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbContacts As System.Windows.Forms.GroupBox
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnSaveContact As System.Windows.Forms.Button
    Friend WithEvents btnAddContact As System.Windows.Forms.Button
    Friend WithEvents lstContacts As System.Windows.Forms.ListBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents grbDivisions As System.Windows.Forms.GroupBox
    Friend WithEvents txtDivisionName As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveDivision As System.Windows.Forms.Button
    Friend WithEvents btnAddDivision As System.Windows.Forms.Button
    Friend WithEvents lstDivisions As System.Windows.Forms.ListBox
    Friend WithEvents lblStreet As System.Windows.Forms.Label
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents lblDivisionName As System.Windows.Forms.Label
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grbCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents lblCustomerType As System.Windows.Forms.Label
    Friend WithEvents cmbCustomerType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveCustomer As System.Windows.Forms.Button
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents grbList As System.Windows.Forms.GroupBox
    Friend WithEvents lstCustomers As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents optActiveDivision As System.Windows.Forms.RadioButton
    Friend WithEvents optInactiveDivision As System.Windows.Forms.RadioButton
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents optActiveContact As System.Windows.Forms.RadioButton
    Friend WithEvents optInactiveContact As System.Windows.Forms.RadioButton
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents TimerDiv As System.Windows.Forms.Timer
    Friend WithEvents TimerCust As System.Windows.Forms.Timer
    Friend WithEvents TimerCont As System.Windows.Forms.Timer
    Friend WithEvents lblSaved As System.Windows.Forms.Label
    Friend WithEvents TimerSaved As System.Windows.Forms.Timer
    Friend WithEvents txtMobile As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
End Class
