Public Class frmInvoiceDetails
    Dim PassedID As Integer = -1
    Dim iNumber As String
    Dim iAmount As Integer
    Dim iDate As String
    Dim iMemo As String
    Dim cancelled As Boolean = False

    Public Sub SetID(ByVal InvoiceID As Integer)
        'Storing ID for use later
        PassedID = InvoiceID

    End Sub

    Private Sub txtInvoiceDate_Validating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInvoiceDate.Validating
        Dim Format As New Format
        Dim tempDate As String

        tempDate = txtInvoiceDate.Text

        'Check for correct date input
        If IsDate(tempDate) = True Then
            'format date
            txtInvoiceDate.Text = Format.CheckDate(tempDate)
        Else
            If tempDate = Nothing Then
                txtInvoiceDate.Text = Nothing
            Else
                MsgBox("Enter valid Date")
            End If

        End If

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        cancelled = True

        'Close with out saving
        Me.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'storing entered information
        iNumber = txtInvoiceNumber.Text.ToString
        iAmount = Val(txtInvoiceAmount.Value)
        iDate = txtInvoiceDate.Text
        iMemo = txtInvoiceMemo.Text

        'Save and close
        Me.Close()

    End Sub

    Public Function GetNumber()
        Return iNumber

    End Function

    Public Function GetAmount()
        Return iAmount

    End Function

    Public Function GetDate()
        Return iDate

    End Function

    Public Function GetMemo()
        Return iMemo

    End Function

    Public Function CheckForCancel()
        Return cancelled

    End Function

    Private Sub txtInvoiceAmount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInvoiceAmount.Enter
        txtInvoiceAmount.Select()

    End Sub

    Private Sub frmInvoiceDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Check if we are loading data for a passed ID
        If PassedID <> -1 Then
            'Load info for the passed ID
            GetInvoiceInfo()
        End If

    End Sub

    Private Sub GetInvoiceInfo()
        Dim db As New DataBaseWork
        Dim Data As New DataSet
        Dim InvoiceInfo As DataRow
        Dim sql As String

        sql = "SELECT * FROM Invoices"

        Try
            'Find invoices
            db.Connect()
            db.SetData(sql)
            Data = db.GetData("Invoices")
            db.Disconnect()

            'Find Row of information for id
            InvoiceInfo = Data.Tables("Invoices").Rows.Find(PassedID)

            'Populate fields with existing information
            txtInvoiceNumber.Text = InvoiceInfo("InvoiceNumber").ToString
            txtInvoiceAmount.Value = InvoiceInfo("InvoiceAmount").ToString
            txtInvoiceDate.Text = InvoiceInfo("InvoiceDate").ToString
            txtInvoiceMemo.Text = InvoiceInfo("InvoiceNote").ToString
        Catch
            MsgBox(ErrorToString)
        End Try


    End Sub

End Class