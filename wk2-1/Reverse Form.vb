Option Strict On
Public Class ReverseForm

    Dim firstString As String 'global variable for firstString to use in ValidateInputs Funtction to test the string input for various conditions
    Dim midString As String 'global used to test midString in the ValidateInputs fucntion for various conditions
    Dim lastString As String 'global to test lastString in ValidateInputs fucntion for various conditions
    Dim eMessage As String = ""
    Private Sub ReverseButton_Click(sender As Object, e As EventArgs) Handles ReverseButton.Click
        If ValidateInputs(True) Then
            InputTextBox.Focus()
            MsgBox(eMessage, MsgBoxStyle.DefaultButton1, "Error Box")
        Else
            SplitStrings()
            OutputTextBox.Text = StringReverse(firstString) + " " + StringReverse(midString) + " " + StringReverse(lastString)
        End If
        'splitStrings()
        'OutputTextBox.Text = StringReverse(firstString) + " " + StringReverse(midString) + " " + StringReverse(lastString)
    End Sub
    Private Function StringReverse(ByVal input As String) As String 'function that reverses the inputs strings and returns the value
        Dim output As String = "" 'sets output to empty string
        Dim chars As Char() = input.ToCharArray() 'creates an array to put the strings into
        For i As Integer = chars.Length - 1 To 0 Step -1 'steps thorugh the array backwards starting at the last character 
            output &= chars(i) ' set the output equal to the reversed string
        Next
        output = LCase(output) 'forces all capitalization to lowercase 
        output = Strings.Replace(output, Strings.Left(output, 1), UCase(Strings.Left(output, 1))) 'replaces the far left with cap



        Return output
    End Function

    Public Sub SplitStrings() 'splits input string into three different strings
        Dim empty1 As Integer 'sets empty1 as integer to subtract/add spaces to correctly read the input strings 
        Dim empty2 As Integer 'sets empty2 as integer to subtract/add spaces to correctly read the input strings

        empty1 = InStr(InputTextBox.Text, " ") 'returns position of the first space in the InputTextBox
        empty2 = InStr(empty1 + 1, InputTextBox.Text, " ") 'starts at the first space in the InputTextBox +1 character

        firstString = Strings.Left(InputTextBox.Text, empty1 - 1) 'starts at the left of the whole string and takes the characters from the first space -1 to grab the whole first string
        midString = Strings.Mid(InputTextBox.Text, empty1 + 1, empty2 - empty1 - 1) 'starts at first space + 1 and goes till the second space - 1 to grab the middle string
        lastString = Strings.Right(InputTextBox.Text, Len(InputTextBox.Text) - empty2) 'gets the length of the whole string then subtracts the second space to grab the last string
    End Sub
    Public Function ValidateInputs(incorrect As Boolean) As Boolean 'function to validate all input strings then returns a boolean to tell user an error
        incorrect = False 'sets the incorrect to false to ensure value is false
        eMessage = "" 'clears eMessage each time function is called

        If InputTextBox.Text = "" Then 'tests to see if InputTextBox is left empty
            incorrect = True 'sets incorrect as true to then return a true value when this statement is present on the InputTextBox
            eMessage += "Please enter text" 'prompts user to enter text
        End If

        Try
            SplitStrings() ' calls the SplitStrings sub to test if any of the below values are true
            If IsNumeric(firstString) Or IsNumeric(midString) Or IsNumeric(lastString) Then 'tests if the numeric values are present in a group of three
                incorrect = True 'sets incorrect as true to return 
                eMessage += "No numeric values" 'populates the eMessage with the string to tell user no numeric values can be used
            End If
        Catch ex As Exception 'if the above code executes with no numeric values catch will execute the below code to test for further validation
            incorrect = True 'sets incorrect to true if conditions are met within the catch
            eMessage += vbCrLf + "Please enter three words" 'prompts user to enter 3 words
        End Try
        Return incorrect 'returns a true if any of the incorrect values are input 
    End Function
    Private Sub ReverseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReverseToolStripMenuItem.Click 'preforms the same function reverse button click sub
        If ValidateInputs(True) Then
            InputTextBox.Focus()
            MsgBox(eMessage, MsgBoxStyle.DefaultButton1, "Error Box")
        Else
            SplitStrings()
            OutputTextBox.Text = StringReverse(firstString) + " " + StringReverse(midString) + " " + StringReverse(lastString)
        End If
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'closes program when exit button is clicked
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close() 'closes program when the exit menu is clicked
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show() 'shows the about form when about is clicked
        Me.Hide() ' hides orignial form when about form is opened
    End Sub
End Class
