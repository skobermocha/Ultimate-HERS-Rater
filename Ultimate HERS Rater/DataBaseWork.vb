Public Class DataBaseWork
    Dim Connection As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter

    Public Sub Connect()
        Connection.ConnectionString = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source = C:\codingprojects\ultimate-hers-rater\DuctTestersDB.accdb"
        Connection.Open()

    End Sub

    Public Sub SetData(ByVal sql As String)
        da = New OleDb.OleDbDataAdapter(sql, Connection)

    End Sub

    Public Function GetData(ByVal RefName As String)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, RefName)
        Return ds

    End Function

    Public Sub UpdateData(ByVal RefName As String)
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        da.Update(ds, RefName)

    End Sub

    Public Sub SetPrimary(ByVal TableRef As String, ByVal KeyRef As String)
        ' Set PrimaryKey
        Dim PrimaryKey() As DataColumn = {ds.Tables(TableRef).Columns(KeyRef)}
        ds.Tables(TableRef).PrimaryKey = PrimaryKey

    End Sub

    Public Sub Disconnect()
        Connection.Close()

    End Sub

End Class
