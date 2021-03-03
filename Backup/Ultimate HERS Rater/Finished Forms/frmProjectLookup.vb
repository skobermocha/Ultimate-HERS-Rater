Public Class frmProjectLookup
    Dim DB As New DataBaseWork
    Dim Data As New DataSet

    Private Sub frmProjectLookup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Open Db Connection
        DB.Connect()

        'Populate Customer List
        GetCustomers()
        cmbCustomer.SelectedIndex = -1

        ' Populate project list - with all projects
        GetAllProjects()
        cmbName.SelectedIndex = -1

        'Set form defaults
        btnNameLookup.Enabled = False
        cmbDivision.Enabled = False

    End Sub

    Private Sub GetCustomers()
        Dim sql As String

        

        ' pulling Customer information from the database
        sql = "SELECT DISTINCT Customers.* " & _
        "FROM Customers INNER JOIN CustomerProjects ON Customers.CustomerID = CustomerProjects.CustomerID " & _
        "WHERE ((('count')>'0')) ORDER BY CustomerName;"
        DB.SetData(sql)

        ' Populate Customer List with current Customers
        If Not Data.Tables.IndexOf("Customers") = -1 Then
            Data.Tables("Customers").Clear()
        End If
        Data = DB.GetData("Customers")
        cmbCustomer.DisplayMember = "CustomerName"
        cmbCustomer.ValueMember = "CustomerID"
        cmbCustomer.DataSource = Data.Tables("Customers")


    End Sub

    Private Sub GetDivisions(ByVal ID As Integer)
        Dim sql As String
        

        ' pull Customer Divisions from database
        sql = "SELECT DISTINCT CustomerDivisions.* " & _
        "FROM CustomerDivisions INNER JOIN CustomerProjects ON CustomerDivisions.DivisionID = CustomerProjects.DivisionID " & _
        "WHERE ((('count')>'0') AND CustomerDivisions.CustomerID=" & ID & ") ORDER BY DivisionName;"
        DB.SetData(sql)

        'Clear Divisions records if there are any existing
        If Not Data.Tables.IndexOf("Divisions") = -1 Then
            Data.Tables("Divisions").Clear()
        End If
        Data = DB.GetData("Divisions")

        'Populate Divisions List box
        cmbDivision.DisplayMember = "DivisionName"
        cmbDivision.ValueMember = "DivisionID"
        cmbDivision.DataSource = Data.Tables("Divisions")


    End Sub

    Private Sub GetCustProjects(ByVal ID As Integer)
        Dim sql As String

        ' Pull Project information from database
        sql = "SELECT ProjectID, CustomerID, DivisionID, ProjectName FROM CustomerProjects WHERE CustomerID =" & ID & " ORDER BY ProjectName"
        DB.SetData(sql)

        'Clear Project records if there are any existing
        If Not Data.Tables.IndexOf("Projects") = -1 Then
            Data.Tables("Projects").Clear()
        End If
        Data = DB.GetData("Projects")

        'Populate Project List box
        cmbName.DisplayMember = "ProjectName"
        cmbName.ValueMember = "ProjectID"
        cmbName.DataSource = Data.Tables("Projects")

    End Sub

    Private Sub GetDivProjects(ByVal ID As Integer)
        Dim sql As String

        ' Pull Project information from database
        sql = "SELECT ProjectID, CustomerID, DivisionID, ProjectName FROM CustomerProjects WHERE DivisionID =" & ID & " ORDER BY ProjectName"
        DB.SetData(sql)

        'Clear Project records if there are any existing
        If Not Data.Tables.IndexOf("Projects") = -1 Then
            Data.Tables("Projects").Clear()
        End If
        Data = DB.GetData("Projects")

        'Populate Project List box
        cmbName.DisplayMember = "ProjectName"
        cmbName.ValueMember = "ProjectID"
        cmbName.DataSource = Data.Tables("Projects")

    End Sub

    Private Sub GetAllProjects()
        Dim sql As String

        ' Populate project list - with all projects
        sql = "SELECT ProjectID, CustomerID, DivisionID, ProjectName FROM CustomerProjects ORDER BY ProjectName"
        DB.SetData(Sql)
        Data = DB.GetData("Projects")
        cmbName.DisplayMember = "ProjectName"
        cmbName.ValueMember = "ProjectID"
        cmbName.DataSource = Data.Tables("Projects")

    End Sub

    Private Sub cmbCustomer_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomer.SelectionChangeCommitted
        Dim CustomerID As Integer

        ' once customer changed - update fields
        Try
            CustomerID = cmbCustomer.SelectedValue
            If CustomerID <> Nothing Then
                'Filter Divisions
                cmbDivision.Enabled = True
                GetDivisions(CustomerID)
                cmbDivision.SelectedIndex = -1
                'Filter Projects to all customer projects
                GetCustProjects(CustomerID)
                cmbName.SelectedIndex = -1
            Else
                'clear Divisions and get all projects
                cmbDivision.Enabled = False
                cmbDivision.DataSource = Nothing
                GetAllProjects()
            End If
        Catch
            MsgBox(ErrorToString)
        End Try

    End Sub

    Private Sub cmbDivision_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectionChangeCommitted
        Dim DivisionID, CustomerID As Integer

        ' once Division changed - update fields
        Try
            CustomerID = cmbCustomer.SelectedValue
            DivisionID = cmbDivision.SelectedValue
            If DivisionID <> Nothing Then
                GetDivProjects(DivisionID)
                cmbName.SelectedIndex = -1
            Else
                'clear Project List
                cmbName.DataSource = Nothing
                GetCustProjects(CustomerID)
            End If
        Catch
        End Try

    End Sub

    Private Sub cmbName_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbName.SelectionChangeCommitted
        ' Once Project change = update fields
        If cmbName.SelectedValue <> Nothing Then
            btnNameLookup.Enabled = True
            btnNameLookup.Focus()
        Else
            btnNameLookup.Enabled = False
            cmbName.Focus()
        End If

    End Sub

    Private Sub btnNameLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNameLookup.Click
        'Check for a selected project name
        If cmbName.SelectedValue <> Nothing Then
            ' Lookup Project by Name
            SetProjectID(cmbName.SelectedValue)
            ProjectLookup("Name")
        Else
            ' Invalid name
            ErrorProvider.SetError(lblProjectNumber, "Invalid Project Number.")
        End If

    End Sub

    Private Sub btnNbrLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNbrLookup.Click
        ' Check for an input
        If txtProjectNumber.Text <> Nothing Then
            ' Lookup Project by number
            SetProjectID(txtProjectNumber.Text)
            ProjectLookup("Number")
        Else
            ' Invalid Number
            ErrorProvider.SetError(lblProjectNumber, "Invalid Project Number.")
        End If

    End Sub

    Private Sub ProjectLookup(ByVal caller As String)
        Dim ProjectID As Integer

        'retrieve stored ID
        ProjectID = GetProjectID()

        ' Check if the number is valid
        If IsNumeric(ProjectID) = True Then
            'What project lookup type is being done
            caller = GetLookupType()

            Select Case caller
                Case "btnTitle24"
                    ' Lookup Title24
                    frmTitle24Details.Show()
                    Me.Close()

                Case "btnTesting"
                    'Lookup Testing
                    MsgBox("Testing")

                Case "btnBid"
                    'Lookup Bids
                    MsgBox("Bids")

            End Select

        Else
            'What Control ordered the lookup
            Select Case caller
                Case "Number"
                    ' Invalid Number
                    ErrorProvider.SetError(lblProjectNumber, "Invalid Project Number.")
                Case "Name"
                    ' Invalid Project Name  
                    ErrorProvider.SetError(lblName, "Invalid Project Chosen.")
            End Select

        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Back to main menu
        frmMainMenu.Show()
        Me.Close()

    End Sub


End Class