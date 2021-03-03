Public Class AddTradeContact
    Dim DB As New DataBaseWork
    Dim Data As New DataSet
    Dim sql As String
    Dim TradeID As Integer = -1

    Private Sub AddTradeContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set form default status
        btnSave.Enabled = False
        cmbCustomers.Enabled = False
        cmbDivisions.Enabled = False
        cmbContacts.Enabled = False

        'Populate Customer types
        sql = "SELECT * From CustomerTypes WHERE CustomerTypeID <> 2 ORDER BY CustomerType"
        DB.Connect()
        DB.SetData(sql)
        Data = DB.GetData("Types")
        DB.Disconnect()

        lstTradetypes.DisplayMember = "CustomerType"
        lstTradetypes.ValueMember = "CustomerTypeID"
        lstTradetypes.DataSource = Data.Tables("Types")
        lstTradetypes.SelectedIndex = -1

    End Sub

    Private Sub lstTradetypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTradetypes.Click
        Dim type As Integer

        ' Updating Lists

        type = lstTradetypes.SelectedValue

        If type <> Nothing Then
            cmbCustomers.Enabled = True

            'Populate customer combo with customers of selected trade
            sql = "SELECT * FROM Customers WHERE CustomerTypeID=" & type
            DB.Connect()
            DB.SetData(sql)
            If Data.Tables.IndexOf("Customers") <> -1 Then
                Data.Tables("Customers").Clear()
            End If
            Data = DB.GetData("Customers")
            DB.Disconnect()

            cmbCustomers.DisplayMember = "CustomerName"
            cmbCustomers.ValueMember = "CustomerID"
            cmbCustomers.DataSource = Data.Tables("Customers")
            cmbCustomers.SelectedIndex = -1

            'Disable other combos until customer is chosen
            cmbDivisions.Enabled = False
            cmbContacts.Enabled = False

        Else
            'Disable other combos until customer is chosen
            cmbDivisions.Enabled = False
            cmbContacts.Enabled = False
            cmbCustomers.Enabled = False

        End If

    End Sub

    Private Sub cmbCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomers.SelectionChangeCommitted
        Dim ID As Integer

        ID = cmbCustomers.SelectedValue

        If ID <> Nothing Then
            cmbDivisions.Enabled = True

            'Populate Division Combo
            sql = "SELECT DivisionID, DivisionName FROM CustomerDivisions WHERE CustomerID=" & ID
            DB.Connect()
            DB.SetData(sql)
            If Data.Tables.IndexOf("Divisions") <> -1 Then
                Data.Tables("Divisions").Clear()
            End If
            Data = DB.GetData("Divisions")
            DB.Disconnect()

            cmbDivisions.DisplayMember = "DivisionName"
            cmbDivisions.ValueMember = "DivisionID"
            cmbDivisions.DataSource = Data.Tables("Divisions")
            cmbDivisions.SelectedIndex = -1

            'Disable other combos
            cmbContacts.Enabled = False

        Else
            cmbDivisions.Enabled = False
            cmbContacts.Enabled = False

        End If

    End Sub

    Private Sub cmbDivisions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivisions.SelectionChangeCommitted
        Dim ID As Integer

        ID = cmbDivisions.SelectedValue

        If ID <> Nothing Then
            cmbContacts.Enabled = True

            'Populate Division Combo
            sql = "SELECT ContactID, ContactName FROM CustomerContacts WHERE DivisionID=" & ID
            DB.Connect()
            DB.SetData(sql)
            If Data.Tables.IndexOf("Contacts") <> -1 Then
                Data.Tables("Contact").Clear()
            End If
            Data = DB.GetData("Contacts")
            DB.Disconnect()

            cmbContacts.DisplayMember = "ContactName"
            cmbContacts.ValueMember = "ContactID"
            cmbContacts.DataSource = Data.Tables("Contacts")
            cmbContacts.SelectedIndex = -1

            'Disable other combos
            btnSave.Enabled = False

        Else
            cmbContacts.Enabled = False
            btnSave.Enabled = False

        End If

    End Sub

    Private Sub cmbContacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbContacts.SelectionChangeCommitted
        Dim ID As Integer

        ID = cmbContacts.SelectedValue

        If ID <> Nothing Then
            btnSave.Enabled = True
            TradeID = ID
        Else
            btnSave.Enabled = False

        End If


    End Sub

    Private Sub Closer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click, btnCancel.Click

        Me.Close()

    End Sub



    Public Function GetID()
        Return TradeID

    End Function


End Class