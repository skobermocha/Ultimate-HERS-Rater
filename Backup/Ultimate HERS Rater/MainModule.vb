
Module MainModule
    Dim LoggedUser As String
    Dim LoggedUserID As Integer
    Dim LoggedUserTypeID As Integer
    Dim LookupCaller As String
    Dim WorkingProjectID As Integer

    Public Sub SetLoggedUser(ByVal User As String, ByVal UserID As Integer, ByVal UserTypeID As Integer)
        'Setting Logged in UserName for public use
        LoggedUser = User
        LoggedUserID = UserID
        LoggedUserTypeID = UserTypeID

    End Sub

    Public Function GetUser()
        'Return Logged in username
        Return LoggedUser

    End Function

    Public Function GetUserID()
        'returns Logged in User ID
        Return LoggedUserID

    End Function

    Public Function GetUserTypeID()
        'Returns User Type ID
        Return LoggedUserTypeID

    End Function

    Public Sub SetLookupType(ByVal Looker As String)
        ' What kind of Project lookup is going on
        LookupCaller = Looker

    End Sub

    Public Function GetLookupType()
        Return LookupCaller

    End Function

    Public Sub SetProjectID(ByVal ProjectID As Integer)
        'Storing Project ID for later use
        WorkingProjectID = ProjectID

    End Sub

    Public Function GetProjectID()
        'Returns current Project ID
        Return WorkingProjectID

    End Function

    Public Function UserIsAdmin(ByVal ID As Integer) As Boolean
        Dim Db As New DataBaseWork
        Dim Data As New DataSet
        Dim sql As String

        ' Open DB Connection
        Db.Connect()

        'Pull Userinfo
        sql = "SELECT UserTypeID FROM Users WHERE UserID = " & ID
        Db.SetData(sql)
        Data = Db.GetData("Users")

        'Close DB connection
        Db.Disconnect()

        ' Check if user is admin - 1 equals Admin Rights
        If Data.Tables("Users").Rows(0).Item("UserTypeID") = 1 Then
            ' User IS Admin
            Return True
        Else
            ' User is NOT Admin
            Return False
        End If

    End Function

End Module
