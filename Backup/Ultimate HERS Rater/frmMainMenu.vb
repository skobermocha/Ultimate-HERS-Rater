Public Class frmMainMenu

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim UserTypeID As Integer

        UserTypeID = GetUserTypeID()

        ' Check for Admin rights on load
        If UserIsAdmin(UserTypeID) <> True Then
            EditUsersToolStripMenuItem.Enabled = False
            EditDepartmentsToolStripMenuItem.Enabled = False
            Title24OptionsToolStripMenuItem.Enabled = False
            TestingOptionsToolStripMenuItem.Enabled = False
            CustomerOptionsToolStripMenuItem.Enabled = False
            SettingsToolStripMenuItem.Enabled = False

        End If

    End Sub

    Private Sub btnCreateCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateCustomer.Click
        frmCustomerDetails.Show()
        Me.Close()

    End Sub

    Private Sub btnEditCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCustomer.Click
        frmCustomerDetails.Show()
        Me.Show()

    End Sub

    Private Sub btnTitle24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTitle24.Click
        'Setup Project Lookup type called
        SetLookupType("btnTitle24")

        'Open Project Lookup form
        frmProjectLookup.Show()
        Me.Close()

    End Sub

    Private Sub btnTesting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTesting.Click
        'Setup Project Lookup type called
        SetLookupType("btnTesting")

        'Open Project Lookup form
        frmProjectLookup.Show()
        Me.Close()

    End Sub

    Private Sub btnBid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBid.Click
        'Setup Project Lookup type called
        SetLookupType("btnBid")

        'Open Project Lookup form
        frmProjectLookup.Show()
        Me.Close()

    End Sub

    Private Sub btnCreateProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateProject.Click
        frmProjectDetails.Show()
        Me.Close()

    End Sub

    Private Sub btnEditProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditProject.Click
        frmProjectDetails.Show()
        Me.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exit Program
        Me.Close()

    End Sub

    Private Sub LogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click, btnLogOut.Click
        ' Logging out of program

        ' Clear logged user info
        SetLoggedUser(Nothing, Nothing, Nothing)

        ' Exit to Login Window
        frmLogIn.Show()
        Me.Close()

    End Sub

    Private Sub ChangeMyPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeMyPasswordToolStripMenuItem.Click
        ' User is changing password
        Dim PWscreen As New frmChangePassword
        PWscreen.ShowDialog()

    End Sub

    Private Sub EditUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUsersToolStripMenuItem.Click
        ' Admin Changing User Info
        Dim EditUsers As New frmUsers
        EditUsers.ShowDialog()

    End Sub

    Private Sub EditDepartmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDepartmentsToolStripMenuItem.Click
        ' Admin Changing Department info
        Dim Depart As New frmDepartments
        Depart.ShowDialog()

    End Sub

    Private Sub EditCustomerTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCustomerTypesToolStripMenuItem.Click
        ' Admin Changing Customer type info
        Dim CustType As New frmCustomerTypes
        CustType.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Dim About As New frmAbout
        'About.ShowDialog()

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub

    Private Sub EditReportTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditReportTypesToolStripMenuItem.Click
        ' Admin Changing Incentive type info
        Dim IncentiveType As New frmIncentivePrograms
        IncentiveType.ShowDialog()

    End Sub

End Class