'Carson Bogart
'GERAN CALL 
'Fall 2022
'wk1-1
'This program allows user input on a text box in feet and when the convert button is pressed it converts to meters
Option Strict On
Public Class Converter
    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        Dim feetDecimal As Decimal 'sets "feetDecimal" as a decimal value to convert user input to decimal
        Dim meterMultiply As Double = 0.3048 'sets the variable to multiply feet by 0.3048 to get meters
        Dim meterAnswer As Decimal 'sets as decimal to display in text box as converted answer in meters

        Try 'will run the code if a decimal is entered into the FeetTextBox
            feetDecimal = CDec(FeetTextBox.Text) 'converts the feet text box to decimal to allow decimal numbers
            meterAnswer = CDec(CStr(feetDecimal * meterMultiply)) 'converts the answer of the multiplied variables to string then decimal
            meterAnswer = Math.Round(meterAnswer, 3) 'rounds the meterAnswer to 3 decimal places
            MeterTextBox.Text = CStr(meterAnswer) 'converts meterAnswer to string to display in MeterTextBox
        Catch ex As Exception 'exception will run if a decimal value isn't present in FeetTextBox
            Dim textString = CStr(FeetTextBox.Text)
            MsgBox("Please enter valid field") 'prompts user to enter correct field
            FeetTextBox.Focus() 'if anything other than decimal is input then the focus is set to this text box
            MeterTextBox.Clear() 'clears output text box when any value other than decimal is attempted to convert
        End Try
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutFormConverter.Show()
        Me.Hide()
    End Sub
End Class
