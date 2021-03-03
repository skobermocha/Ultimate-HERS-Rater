Public Class frmLogIn


    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Dim User, PW, sql As String
        Dim DB As New DataBaseWork
        Dim Data As New DataSet
        Dim UserID, UserTypeID, MaxRow, x As Integer

        User = txtUserName.Text.ToLower
        PW = txtPassword.Text.ToLower


        If User <> Nothing And PW <> Nothing Then
            sql = "SELECT UserID, UserName, UserTypeID, PW FROM Users WHERE Active = -1"

            DB.Connect()
            DB.SetData(sql)
            Data = DB.GetData("Users")
            DB.Disconnect()

            ' Check for valid username and password combo
            MaxRow = Data.Tables("Users").Rows.Count
            For x = 0 To MaxRow - 1
                If Data.Tables("Users").Rows(x).Item("UserName").ToString.ToLower = User Then
                    UserID = Data.Tables("Users").Rows(x).Item("UserID")
                    UserTypeID = Data.Tables("Users").Rows(x).Item("UserTypeID")

                    If Data.Tables("Users").Rows(x).Item("PW").ToString.ToLower = PW Then
                        ' Correct Username and password entered - Storing username for later use
                        SetLoggedUser(User, UserID, UserTypeID)

                        ' Continue to main menu
                        frmMainMenu.Show()
                        Me.Close()

                        Exit Sub

                    End If

                End If

            Next
            ' Valid UserName & Password combo not found
            ErrorProvider.SetError(lblUserName, "Invalid user name or password entered")
            txtUserName.Focus()
            txtUserName.SelectAll()

        Else
            If PW = Nothing Then
                'GoTo LogIn_Error
                ErrorProvider.SetError(lblPassword, "Password not entered")
                txtPassword.Focus()

            End If

            If User = Nothing Then
                'GoTo LogIn_Error
                ErrorProvider.SetError(lblUserName, "User name not entered")
                txtUserName.Focus()

            End If

        End If



    End Sub

    Private Sub txtPassword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        txtPassword.SelectAll()

    End Sub

    Private Sub TextBoxChanges(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged, txtPassword.TextChanged
        'Reset Error icons
        ErrorProvider.SetError(lblPassword, "")
        ErrorProvider.SetError(lblUserName, "")

    End Sub
End Class
