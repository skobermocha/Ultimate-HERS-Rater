Public Class ProjectInfo
    Dim DB As New DataBaseWork
    Dim Data As New DataSet
    Dim ProjectRow, NoteRow As DataRow
    Dim ProjectID, NoteID As Integer
    Dim NoteMarker As Integer = -1

    Public Sub New(ByVal ID As Integer)
        Dim sql As String

        'Store passed ID for use in other methods
        ProjectID = ID

        ' Selecting Basic Customer Info for display
        sql = "SELECT * " & _
                "FROM CustomerProjects INNER JOIN (Customers INNER JOIN CustomerDivisions ON Customers.CustomerID = CustomerDivisions.CustomerID) ON CustomerProjects.DivisionID = CustomerDivisions.DivisionID " & _
                "WHERE CustomerProjects.ProjectID=" & ProjectID

        Try
            ' Open Database Connection
            DB.Connect()

            'Populate Dataset
            DB.SetData(sql)
            Data = DB.GetData("Basics")

            'Close DB connection
            DB.Disconnect()

            ' Set ProjectId as primary Key
            DB.SetPrimary("Basics", "ProjectID")

        Catch
            MsgBox(ErrorToString)
        End Try

    End Sub

    Public Function GetData(ByVal ColName As String, ByVal TableRef As String, ByVal ID As Integer)
        Dim Str As String
        ' Find the row with the project ID specified 
        ProjectRow = Data.Tables(TableRef).Rows.Find(ID)
        Str = ProjectRow(ColName).ToString


        'Returns Data to be used
        Return Str

    End Function

    Public Sub UpdateData(ByVal Info As String, ByVal ColName As String, ByVal TableRef As String, ByVal ID As Integer)
        ' Find the row with the project ID specified 
        ProjectRow = Data.Tables(TableRef).Rows.Find(ID)
        ProjectRow(ColName) = Info

        'Update the table
        DB.UpdateData(TableRef)

    End Sub

    Public Sub DeleteData(ByVal TableRef As String, ByVal ID As Integer)
        ' Find the row with the project ID specified 
        ProjectRow = Data.Tables(TableRef).Rows.Find(ID)
        ProjectRow.Delete()

        'Update the table
        DB.UpdateData(TableRef)

    End Sub

    Public Function FindInvoices()
        Dim Invoices As DataSet
        Dim sql As String

        'Open DB Connection
        DB.Connect()

        'Populate Dataset
        sql = "SELECT InvoiceID, InvoiceNumber as [Invoice Number], InvoiceAmount as [Amount], InvoiceDate as [Date], InvoiceNote as [Memo] " & _
        "FROM Invoices WHERE ProjectID=" & ProjectID & " AND Title24Invoice= -1"
        DB.SetData(sql)
        Invoices = DB.GetData("Invoices")

        'Close DB Connection
        DB.Disconnect()

        'Send back DataSet
        Return Invoices

    End Function

    Public Sub AddInvoice(ByVal iNumber As String, ByVal iAmount As Integer, ByVal iDate As String, ByVal iMemo As String)
        Dim InvoiceInfo As DataRow

        'populating dataset
        FindInvoices()

        'creating new row in dataset
        InvoiceInfo = Data.Tables("Invoices").NewRow

        'populating the new row information
        InvoiceInfo("Invoice Number") = iNumber
        InvoiceInfo("Amount") = iAmount
        InvoiceInfo("Date") = iDate
        InvoiceInfo("Memo") = iMemo

        'Updating data set
        Data.Tables("Invoices").Rows.Add(InvoiceInfo)

        'Updating tables
        DB.UpdateData("Invoices")

    End Sub

#Region "Contact Work"
    Public Sub SetContacts()
        Dim sql As String

        Try
            ' Open Database Connection
            DB.Connect()

            sql = "SELECT CustomerTypes.CustomerTypeID, CustomerTypes.CustomerType, Customers.CustomerName, CustomerDivisions.DivisionName, CustomerContacts.* " & _
            "FROM CustomerTypes INNER JOIN ((Customers INNER JOIN CustomerDivisions ON Customers.CustomerID = CustomerDivisions.CustomerID) INNER JOIN CustomerContacts ON CustomerDivisions.DivisionID = CustomerContacts.DivisionID) ON CustomerTypes.CustomerTypeID = Customers.CustomerTypeID " & _
            "ORDER BY ContactName"

            'Populate Dataset
            DB.SetData(sql)
            If Data.Tables.IndexOf("Contacts") <> -1 Then
                Data.Tables("COntacts").Clear()
            End If
            Data = DB.GetData("Contacts")

            'Close DB connection
            DB.Disconnect()

            ' Set ContactId as primary Key
            DB.SetPrimary("Contacts", "ContactID")


        Catch
            MsgBox(ErrorToString)
        End Try

    End Sub

    Public Function SetTradeContacts()
        Dim sql As String

        Try
            ' Open Database Connection
            DB.Connect()

            sql = "SELECT CustomerTypes.CustomerTypeID, CustomerTypes.CustomerType, TradeContacts.ContactID, TradeContacts.TradeContactID, Customers.CustomerID " & _
            "FROM (((CustomerTypes INNER JOIN Customers ON CustomerTypes.CustomerTypeID = Customers.CustomerTypeID) INNER JOIN CustomerDivisions ON Customers.CustomerID = CustomerDivisions.CustomerID) INNER JOIN CustomerContacts ON CustomerDivisions.DivisionID = CustomerContacts.DivisionID) INNER JOIN TradeContacts ON CustomerContacts.ContactID = TradeContacts.ContactID " & _
            "WHERE TradeContacts.ProjectID=" & ProjectID & " ORDER BY CustomerType"

            'Populate Dataset with Trade contacts
            DB.SetData(sql)
            If Data.Tables.IndexOf("Trades") <> -1 Then
                Data.Tables("Trades").Clear()
            End If
            Data = DB.GetData("Trades")


            'Close DB connection
            DB.Disconnect()

            ' Set TradeContactId as primary Key
            DB.SetPrimary("Trades", "TradeContactID")

        Catch
            MsgBox(ErrorToString)
        End Try

        'Send back dataset
        Return Data

    End Function

    Public Function AddTrade(ByVal ID As Integer)
        Dim sql As String

        sql = "SELECT * FROM TradeContacts"

        Try
            'Open DB connection
            DB.Connect()

            'clear Trades table to only show Trade Contacts table
            DB.SetData(sql)
            Data.Tables("Trades").Clear()
            Data = DB.GetData("Trades")

            ' Find the row with the project ID specified 
            ProjectRow = Data.Tables("Trades").NewRow
            ProjectRow("ProjectID") = ProjectID
            ProjectRow("ContactID") = ID

            'Adding to Dataset
            Data.Tables("Trades").Rows.Add(ProjectRow)

            'Update table
            DB.UpdateData("Trades")

            'Close DB connection
            DB.Disconnect()

            Return ProjectRow("TradeContactID")

        Catch ex As Exception
            MsgBox(ErrorToString)
            Return -1

        End Try

    End Function

    Public Sub DeleteTrade(ByVal ID As Integer)
        Dim sql As String

        sql = "SELECT * FROM TradeContacts"

        Try
            'Open DB connection
            DB.Connect()

            'clear Trades table to only show Trade Contacts table
            DB.SetData(sql)
            Data.Tables("Trades").Clear()
            Data = DB.GetData("Trades")

            'Close DB connection
            DB.Disconnect()

            ' Find the row with the project ID specified 
            DeleteData("Trades", ID)

        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try

    End Sub

#End Region

#Region "Revision Work"
    Public Function SetRevisionInfo(ByVal ID As Integer)
        Dim sql As String

        sql = "SELECT * FROM Revisions WHERE ProjectID =" & ID

        Try
            ' Open Database Connection
            DB.Connect()

            'Populate Dataset
            DB.SetData(sql)
            Data = DB.GetData("Revisions")

            'Close DB connection
            DB.Disconnect()

            ' Set RevisionId as primary Key
            DB.SetPrimary("Revisions", "RevisionID")

            Return Data

        Catch
            MsgBox(ErrorToString)
            Return Nothing

        End Try

    End Function

    Public Function GetRevisionCount()
        Dim Count As Integer

        'Counts the amount of rows to determine the revision count
        Count = Data.Tables("Revisions").Rows.Count

        Return Count

    End Function

    Public Function AddRevision()
        Dim StatusID As Integer
        Dim ID As Integer
        Dim revDate As String = Today

        'Checking if current revision is marked as completed
        If Not IsDBNull(Data.Tables("Revisions").Rows(GetRevisionCount() - 1).Item("StatusID")) = True Then
            StatusID = Data.Tables("Revisions").Rows(GetRevisionCount() - 1).Item("StatusID")
        End If

        If StatusID <> 8 Then
            ' revision is not complete
            MsgBox("Current revision must be completed before a new one can be added.")
            ID = Data.Tables("Revisions").Rows(GetRevisionCount() - 1).Item("RevisionID")
        Else
            ' Preparing to add revision to the dataset
            ProjectRow = Data.Tables("Revisions").NewRow

            'Filling revision information
            ProjectRow("ProjectID") = ProjectID
            ProjectRow("RevisionDate") = revDate

            'Adding to Dataset
            Data.Tables("Revisions").Rows.Add(ProjectRow)

            'Update Table
            DB.UpdateData("Revisions")

            'Retrieving new RevisionID
            ID = ProjectRow("RevisionID")

        End If

        Return ID

    End Function

#End Region

#Region "Version Work"

    Public Function SetVersionsInfo(ByVal ID As Integer)
        Dim sql As String

        sql = "SELECT * FROM RevisionVersions WHERE RevisionID =" & ID

        Try
            ' Open Database Connection
            DB.Connect()

            'Populate Dataset
            DB.SetData(sql)
            If Not Data.Tables.IndexOf("Versions") = -1 Then
                Data.Tables("Versions").Clear()
            End If
            Data = DB.GetData("Versions")

            'Close DB connection
            DB.Disconnect()

            ' Set VersionId as primary Key
            DB.SetPrimary("Versions", "VersionID")

            Return Data

        Catch
            MsgBox(ErrorToString)
            Return Nothing

        End Try

    End Function

    Public Function GetVersionCount()
        Dim Count As Integer

        'Counts the amount of rows to determine the revision count
        Count = Data.Tables("Versions").Rows.Count

        Return Count

    End Function

#End Region

#Region "Note Navigation"
    Public Sub FindNotes(Optional ByVal Filter As String = "")
        Dim sql As String

        'Open DB Connection
        DB.Connect()

        'find project notes
        Select Case Filter
            Case "T24"
                'Filtering to find only Title24 Notes
                sql = "SELECT ProjectNotes.*, Users.Username " & _
                "FROM ProjectNotes INNER JOIN Users ON ProjectNotes.UserID = Users.UserID " & _
                "WHERE Title24Note = -1 AND ProjectID =" & ProjectID

            Case "Testing"
                'Filtering to find only Testing Notes
                sql = "SELECT ProjectNotes.*, Users.Username " & _
                "FROM ProjectNotes INNER JOIN Users ON ProjectNotes.UserID = Users.UserID " & _
                "WHERE Title24Note = 0 AND ProjectID =" & ProjectID
            Case Else
                'Find all Project Notes
                sql = "SELECT ProjectNotes.*, Users.Username " & _
                "FROM ProjectNotes INNER JOIN Users ON ProjectNotes.UserID = Users.UserID " & _
                "WHERE ProjectID =" & ProjectID
        End Select

        DB.SetData(sql)
        If Not Data.Tables.IndexOf("Notes") = -1 Then
            Data.Tables("Notes").Clear()
        End If
        Data = DB.GetData("Notes")

        If NoteMarker > -1 Then
            NoteRow = Data.Tables("Notes").Rows(NoteMarker)
        End If

        ' Set primary key
        DB.SetPrimary("Notes", "ProjectNoteID")

        'Close DB Connection
        DB.Disconnect()

    End Sub

    Public Sub LastNote()
        Dim NoteCount As Integer

        'Count Note records
        NoteCount = GetNoteCount()

        ' Set Note marker to last Note
        NoteMarker = NoteCount - 1

        'Find the last note in dataset
        If NoteMarker <> -1 Then
            NoteRow = Data.Tables("Notes").Rows(NoteMarker)

            'Set NoteID
            NoteID = NoteRow("ProjectNoteID")
        End If

    End Sub

    Public Function GetNoteCount()
        Dim Count As Integer

        'Get Note Count and return
        Count = Data.Tables("Notes").Rows.Count
        Return Count

    End Function

    Public Function GetNoteMarker()
        Return NoteMarker

    End Function

    Public Sub NextNote()
        'Moving Note marker to next space
        NoteMarker = NoteMarker + 1

        'Find the last note in dataset
        NoteRow = Data.Tables("Notes").Rows(NoteMarker)

        'Set NoteID
        NoteID = NoteRow("ProjectNoteID")

    End Sub

    Public Sub PreviousNote()
        'Moving Note marker to Previous space
        NoteMarker = NoteMarker - 1

        'Find the last note in dataset
        NoteRow = Data.Tables("Notes").Rows(NoteMarker)

        'Set NoteID
        NoteID = NoteRow("ProjectNoteID")

    End Sub

    Public Function GetNote(ByVal Field As String)
        Dim str As String

        'Returning Project Notes information
        str = NoteRow(Field).ToString
        Return str

    End Function

    Public Function GetNoteID()
        Return NoteID

    End Function

    Public Sub ClearNoteID()
        ' Set Note ID
        NoteID = Nothing

    End Sub

    Public Sub AddNote(ByVal ProjectID As Integer, ByVal T24 As Integer, ByVal NoteField As String, ByVal nDate As String, ByVal UserID As Integer)
        Dim sql As String

        Try
            'open DB connection
            DB.Connect()

            ' Setup Notes Table
            Data.Tables("Notes").Clear()
            sql = "SELECT * FROM ProjectNotes WHERE ProjectID =" & ProjectID & " AND Title24Note=-1"
            DB.SetData(sql)
            DB.GetData("Notes")

            ' Check for NoteID to determine if we are adding or updating project note
            If NoteID = Nothing Then
                ' Preparing to add note to the dataset
                NoteRow = Data.Tables("Notes").NewRow

                'Adding new note info
                NoteRow("ProjectID") = ProjectID
                NoteRow("Title24Note") = T24
                NoteRow("NoteField") = NoteField
                NoteRow("DateofNote") = nDate
                NoteRow("UserID") = UserID

                'Adding to Dataset
                Data.Tables("Notes").Rows.Add(NoteRow)

                'Set Note ID
                NoteID = NoteRow("ProjectNoteID")
                NoteMarker = GetNoteCount() - 1

            Else
                'Preparing to update note info
                NoteRow = Data.Tables("Notes").Rows.Find(NoteID)

                'Adding new note info
                NoteRow("ProjectID") = ProjectID
                NoteRow("Title24Note") = T24
                NoteRow("NoteField") = NoteField
                NoteRow("DateofNote") = nDate
                NoteRow("UserID") = UserID

            End If

            'Update table
            DB.UpdateData("Notes")

        Catch
            MsgBox(ErrorToString)
        End Try

        'Close DB Connection
        DB.Disconnect()

    End Sub

    Public Sub DeleteNote()
        Dim sql As String
        Dim i, c As Integer

        'open DB connection
        DB.Connect()

        Try
            ' Setup Notes Table
            Data.Tables("Notes").Clear()
            sql = "SELECT * FROM ProjectNotes WHERE ProjectID =" & ProjectID & " AND Title24Note=-1"
            DB.SetData(sql)
            DB.GetData("Notes")

            'Preparing to update note info
            NoteRow = Data.Tables("Notes").Rows.Find(NoteID)
            'find index of next note
            i = Data.Tables("Notes").Rows.IndexOf(NoteRow) + 1

            ' Only Allow logged in user to delete notes left by logged in user OR ADMINS
            If NoteRow("UserID") = GetUserID() Or GetUserTypeID() = 1 Then
                'Remove from dataset
                NoteRow.Delete()

                'Update table
                DB.UpdateData("Notes")
                c = GetNoteCount()

                'Moving to next note in dataset - if last note was not just deleted
                Select Case c
                    Case Is = 0
                        NoteID = Nothing
                        NoteRow = Nothing
                        NoteMarker = -1
                    Case Is = i
                        'Getting NoteID of next note
                        NoteID = Data.Tables("Notes").Rows(i - 1).Item("ProjectNoteID")
                        NoteMarker = i - 1
                    Case Is > i
                        'Getting NoteID of next note
                        NoteID = Data.Tables("Notes").Rows(i - 1).Item("ProjectNoteID")
                        NoteMarker = i - 1
                    Case Is < i
                        NoteID = Data.Tables("Notes").Rows(i - 2).Item("ProjectNoteID")
                        NoteMarker = i - 2
                End Select
            Else
                'show error message
                MsgBox("You don't have sufficient rights to delete notes from other users.")
            End If
        Catch
            MsgBox(ErrorToString)
        End Try

        ' Close DB connection
        DB.Disconnect()

    End Sub

#End Region

End Class
