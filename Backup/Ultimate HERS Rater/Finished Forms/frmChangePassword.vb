Public Class frmChangePassword

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close form
        Me.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Saving new password - after verifying original

        Dim OldPassword, NewPassword, ConfirmPassword, sql As String
        Dim UserID As Integer
        Dim DB As New DataBaseWork
        Dim Data As New DataSet
        Dim UserInfo As DataRow
        
        ' Populate Variables
        OldPassword = txtOld.Text
        NewPassword = txtNew.Text
        ConfirmPassword = txtConfirm.Text
        UserID = GetUserID()

        Try

            ' Open DB Connection
            DB.Connect()

            ' Pull Current Password for loggedin User.
            sql = "SELECT * FROM Users"
            DB.SetData(sql)
            Data = DB.GetData("Users")

            'Set Primary key in datatable
            DB.SetPrimary("Users", "UserID")
            UserInfo = Data.Tables("Users").Rows.Find(UserID)

            ' Check for matching Old Password
            If OldPassword.ToLower = UserInfo("PW").ToString.ToLower Then
                ' Check for matching New and Confirm passwords
                If NewPassword = ConfirmPassword Then
                    'Populate DataRow information
                    UserInfo("PW") = NewPassword

                    ' Update Table
                    DB.UpdateData("Users")

                    MsgBox("Password Updated")
                    txtOld.Text = Nothing
                    txtNew.Text = Nothing
                    txtConfirm.Text = Nothing
                    Me.Close()

                Else
                    ' New and Confirm do not match
                    ErrorProvider.SetError(lblNew, "New password not confirmed correctly.")

                End If

            Else
                ' Old Password not correct
                ErrorProvider.SetError(lblOld, "Old password not valid.")

            End If

            ' Close DB Connection
            DB.Disconnect()

        Catch
            MsgBox(ErrorToString)

        End Try

    End Sub


End Class