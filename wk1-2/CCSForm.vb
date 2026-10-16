'Carson Bogart  
'Geran Call
'Fall 22
'Personal Info reader
'This program reads from user inputs to display in two different formats,
'the input data


Option Strict On
Public Class CCSForm

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        ValidateInputs()
        SLDTextBox.Text = $"{FirstTextBox.Text} {LastTextBox.Text}" & "," & $"{CreditMaskedTextBox.Text}" & ", " & $"{ExpirationMonthTextBox.Text}" & " " & $"{YearTextBox.Text}" & "," & $"{CCVTextBox.Text}"
        MultiListBox.Items.Add($"{FirstTextBox.Text} {LastTextBox.Text}")
        MultiListBox.Items.Add($"{CreditMaskedTextBox.Text}")
        MultiListBox.Items.Add($"{ExpirationMonthTextBox.Text}" & "/" & $"{YearTextBox.Text}" & "," & $"{CCVTextBox.Text}")
    End Sub

    'the program below is attempting to validate the user inputs
    'programmer error fix later when validation is better understood
    'validation is supposed to check user inputs to ensure no "rules" are broken
    'tests if "rules" are broken and if so displays error message to user
    'if any are false then then input must be validated
    'in some instances will limit the numbers and ensure the limit isn't reached

    Function ValidateInputs() As Boolean
        Dim allValid As Boolean = True

        If FirstTextBox.Text = "" Then
            AccumulateMessage("Please enter first name")
            FirstTextBox.Focus()
            allValid = False
        ElseIf CStr(FirstTextBox.Text) = CStr(FirstTextBox.Text) Then
            AccumulateMessage("First name has to be letters")
            FirstTextBox.Focus()
            allValid = False
        End If

        If LastTextBox.Text = "" Then
            AccumulateMessage("Please enter last name")
            LastTextBox.Focus()
            allValid = False
        ElseIf CStr(LastTextBox.Text) = CStr(LastTextBox.Text) Then
            AccumulateMessage("Last name has to be letters")
            LastTextBox.Focus()
            allValid = False
        End If

        If CreditMaskedTextBox.Text = "" Then
            AccumulateMessage("Please enter valid credit card number")
            CreditMaskedTextBox.Focus()
            allValid = False
        ElseIf CStr(CreditMaskedTextBox.Text) = CStr(CreditMaskedTextBox.Text) Then
            AccumulateMessage("Credit card must be numbers")
            CreditMaskedTextBox.Focus()
        ElseIf Len(CreditMaskedTextBox.Text) <> 16 Then
            AccumulateMessage("Credit card has to have 16 numbers")
            CreditMaskedTextBox.Focus()
            allValid = False
        End If

        If ExpirationMonthTextBox.Text = "" Then
            AccumulateMessage("Please enter valid expiration month")
            ExpirationMonthTextBox.Focus()
            allValid = False
        ElseIf CInt(ExpirationMonthTextBox.Text) = CInt(ExpirationMonthTextBox.Text) Then
            AccumulateMessage("Credit card must be numbers")
            ExpirationMonthTextBox.Focus()
            allValid = False
        ElseIf Len(ExpirationMonthTextBox.Text) <> 12 Then
            AccumulateMessage("Month must be less than or equal to 12")
            ExpirationMonthTextBox.Focus()
            allValid = False
        End If

        If YearTextBox.Text = "" Then
            AccumulateMessage("Please enter valid expiration year")
            YearTextBox.Focus()
            allValid = False
        ElseIf CBool(CStr(YearTextBox.Text)) = CBool(CStr(YearTextBox.Text)) Then
            AccumulateMessage("Credit card must be numbers")
            YearTextBox.Focus()
            allValid = False
        ElseIf Len(YearTextBox.Text) <> 99 Then
            AccumulateMessage("Month must be 2 digits")
            YearTextBox.Focus()
            allValid = False
        End If

        If CCVTextBox.Text = "" Then
            AccumulateMessage("Please enter valid security code")
            CCVTextBox.Focus()
            allValid = False
        ElseIf CInt(CStr(CCVTextBox.Text)) = CInt(CStr(CCVTextBox.Text)) Then
            AccumulateMessage("CCV must be numbers")
            CCVTextBox.Focus()
            allValid = False
        ElseIf Len(CCVTextBox.Text) <> 999 Then
            AccumulateMessage("CCV must be 3 digits")
            CCVTextBox.Focus()
            allValid = False
        End If


    End Function
    Private Function AccumulateMessage(Optional newMessage As String = "", Optional clear As Boolean = False) As String
        Static _message As String
        Select Case clear
            Case False
                If newMessage <> "" Then
                    _message &= newMessage & vbCrLf
                End If
            Case Else
                _message = ""
        End Select
        Return _message
    End Function
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HelpFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpFormToolStripMenuItem.Click
        Me.Hide()
        HelpForm.Show()
    End Sub
End Class
