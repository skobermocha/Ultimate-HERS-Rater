Imports System
Imports System.IO
Public Class Format

    Dim FormatError As Boolean = False


    Public Function PhoneNumber(ByVal Number As String)
        Dim strTemp As String = Nothing
        Dim strExtension As String = Nothing
        Dim strPhone As String = Nothing
        Dim intResult As Integer

        Const DefaultAreaCode = "209"
        '
        ' Remove all the grouping characters for now. We'll add them back in later.
        strTemp = Number

        strTemp = Replace(strTemp, "(", "")
        strTemp = Replace(strTemp, ")", "")
        strTemp = Replace(strTemp, "-", "")
        strTemp = Replace(strTemp, " ", "")
        strTemp = Replace(strTemp, "X", "x")
        strTemp = Replace(strTemp, "ext", "x")
        strTemp = Replace(strTemp, "ex", "x")
        strTemp = Replace(strTemp, "ext.", "x")
        strTemp = Replace(strTemp, "ex.", "x")

        ' Break up the digits into the number and the extension, if any.
        intResult = InStr(1, strTemp, "x", vbTextCompare)
        If intResult > 0 Then
            strExtension = Mid(strTemp, intResult + 1)
            strPhone = Left(strTemp, intResult - 1)
        Else
            strPhone = strTemp
        End If

        If Left(strPhone, 1) = "1" Then
            strPhone = Mid(strPhone, 2)
        End If

        If Len(strPhone) <> 7 And Len(strPhone) <> 10 Then
            MsgBox("Please enter a valid telephone number.", vbExclamation)
            FormatError = True
            Return Number
            Exit Function
        End If

        ' Prepend the default area code
        If Len(strPhone) = 7 Then
            strPhone = DefaultAreaCode & strPhone
        End If

        ' Build the new phone number
        Number = "(" & Left(strPhone, 3) & ") " _
           & Mid(strPhone, 4, 3) & "-" _
           & Right(strPhone, 4)

        ' Add the extension, if any
        If strExtension <> "" Then
            Number = Number & " x" & strExtension
        End If

        Return Number

    End Function

    Public Function State(ByVal Input As String)
        Dim Output As String

        Output = Input.ToUpper

        ' Check for valid state intial
        If Len(Output) = 2 And InStr(",AL,AK,AZ,AR,CA,CO,CT,DE,DC,FL,GA,HI,ID,IL,IN,I" _
                                & "A,KS,KY,LA,ME,MD,MA,MI,MN,MS,MO,MT,NE,NV,NH,NJ,NM,NY,NC,ND,OH,OK,OR,P" _
                                & "A,RI,SC,SD,TN,TX,UT,VT,VA,WA,WV,WI,WY,", "," & Output & ",") > 0 Then
            Return Output

        Else
            MsgBox("Please enter a valid state intial.")
            FormatError = True
            Return Input
        End If

    End Function

    Public Function ZipCode(ByVal Input As String)
        Dim temp As String

        temp = Replace(Input, "-", "")

        If Len(temp) <> 5 Or Len(temp) <> 9 And IsNumeric(temp) = False Then
            MsgBox("Please enter a valid zip code.")
            FormatError = True
            Return Input
        Else
            Return Input

        End If

    End Function

    Public Function ValidEmail(ByVal Email As String) As Boolean
        Dim extension As New ArrayList
        Dim result As Boolean

        'Exceptable Email extensions
        extension.Add(".com")
        extension.Add(".edu")
        extension.Add(".info")
        extension.Add(".gov")
        extension.Add(".int")
        extension.Add(".mil")
        extension.Add(".net")
        extension.Add(".org")
        extension.Add(".biz")
        extension.Add(".name")
        extension.Add(".museum")
        extension.Add(".coop")
        extension.Add(".aero")
        extension.Add(".pro")
        extension.Add(".tv")

        'Check for an "@" symbol
        If (Email.IndexOf("@") > 0) Then
            ' Check for a valid extension
            For x = 0 To extension.Count - 1
                If Email.Contains(extension(x)) = True Then
                    result = True
                    Exit For
                Else
                    result = False
                End If
            Next
        Else
            result = False
        End If

        ' check result value
        If result = False Then
            ' Send message if result is not valid
            MsgBox("Please enter a valid email address.")
        End If

        Return result

    End Function

    Public Function CheckName(ByVal UserName As String)
        Dim InvalidFileChars As Char() = Path.GetInvalidFileNameChars()
        Dim InvalidChar As Char
        Dim CharIndex As Integer

        ' Checking for invalide Characters
        For Each InvalidChar In InvalidFileChars
            If InStr(InvalidChar, UserName) > 0 Then
                CharIndex = InStr(InvalidChar, UserName)
                UserName = UserName.Remove(CharIndex, 1)
                FormatError = True
            End If
        Next

        ' Return corrected Name
        Return UserName


    End Function

    Public Function CheckDate(ByVal D As String)
        Dim Output As String

        ' Formating the string to remove dashes
        Output = Replace(D, "-", "/")
        Return Output

    End Function

    Public Function GetError()
        Return FormatError
        'reset error
        FormatError = False
    End Function

End Class
