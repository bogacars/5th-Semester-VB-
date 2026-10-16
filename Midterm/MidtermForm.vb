'Carson Bogart
'Midterm Program
'Fall 2022
'Geran Call

'This program fulls a 2D array with numbers from 1-99 in odd order
'when a button is pressed it displays this 2D array into a list box.
'When another button is pressed it will generate random numbers between
'35-120 and place them into the 2D array. A save button and a read button
'are implemented to save the 2D array contents and to read from an already
'existing file. The contents in the list box currently will be saved. When
'saving the contents the save file will have a comma seperating each element.
'The saved data needs to be in rows and columns. Read button loads array into
'list box. Save button saves listbox contents and clears. The list box is 
'formatted to have 5 columns and 10 rows.


Option Strict On
Public Class MidtermForm
    Dim numbersArrayStr(9, 4) As String 'dim the array capable of holding 50 items becuase 50 odd numbers between 1-99
    Dim rowInt As Integer = 9 'set the amount of rows of array to 10 rows
    Dim columnInt As Integer = 4 'set amount of columns to 5
    Dim valueInt As Integer 'used to load array with odd values
    Dim randomValueInt As Integer 'used to load array with random values in a specific range
    Dim fileNameStr As String = "C:\Users\callgera\Dropbox\1 VB class assignments\F2022\Carson\Midterm\MidtermFILE.txt" 'set file name equal to path used for file to write and read to 
    Dim readBool As Boolean = False 'used to ensure listbox doesn't stack values when read button is pressed

    Private Sub OddButton_Click(sender As Object, e As EventArgs) Handles OddButton.Click 'populates array with odd numbers 1-99
        ArrayListBox.Items.Clear() 'clear listbox to ensure data doesn't stack in listbox
        valueInt = -1 'set value equal to -1 to attain odd values when loading array

        For row As Integer = 0 To rowInt 'start at row 0 and go to set value of 9 for 10 rows
            For column As Integer = 0 To columnInt 'start at column 0 to go to value of 4 to have 5 colums
                valueInt += 2 'increment value by 2 to get odd numbers 1,3,5,....etc
                numbersArrayStr(row, column) = CStr(valueInt) 'loads the array with the value converted to string
            Next
        Next
        FillListBox() 'call sub to fill listbox formatted correctly
    End Sub
    Private Sub RandomButton_Click(sender As Object, e As EventArgs) Handles RandomButton.Click 'populates array with random numbers between 35-120
        ArrayListBox.Items.Clear() 'clear list box to ensure data doesn't stack in list box

        For row As Integer = 0 To rowInt 'start at row 0 and go to set value of 9 for 10 rows
            For column As Integer = 0 To columnInt 'start at column 0 to go to value of 4 to have 5 colums
                randomValueInt = CInt(Int((120 - 35 + 1) * Rnd() + 35)) 'gets random number from 35-120 and loads into randomValueInt
                OddValueCheck(randomValueInt)  'test if the random number is odd in function
                numbersArrayStr(row, column) = (CStr(randomValueInt)) 'if value was odd return odd number and load into array
            Next
        Next
        FillListBox() 'call sub to fill listbox formatted correctly
    End Sub
    Sub FillListBox() 'fills list box with correct format rows/columns
        Dim rowStr As String 'variable string to add array contents in with correct spacing format
        For row As Integer = 0 To UBound(numbersArrayStr, 1) 'starts at row 0 and goes to upper bound set at 9 so 10 rows
            For column As Integer = 0 To UBound(numbersArrayStr, 2) 'starts at column 0 and goes to upper bound set at 4 so 5 columns
                rowStr += LSet(numbersArrayStr(row, column), 10) 'load rowStr with array contents with formatting
            Next
            ArrayListBox.Items.Add(rowStr) 'adds formatted string to listbox
            rowStr = "" 'clear formatted string
        Next
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click, SaveToolStripMenuItem.Click
        WriteFile() 'call sub to write array contents to file
    End Sub
    Private Sub ReadButton_Click(sender As Object, e As EventArgs) Handles ReadButton.Click, ReadToolStripMenuItem.Click
        If readBool = True Then 'tests if the button has already been pressed 
            ArrayListBox.Items.Clear() 'if the button has been pressed ensure list box doesn't continue adding data
        End If
        ReadFile() 'call sub to read from file
    End Sub
    Public Function OddValueCheck(value As Integer) As Integer
        Dim oddInt As Integer 'used to load the returned value with odd number
        If randomValueInt Mod 2 <> 0 Then 'used to divide the random number by 2 to check if remainder is true if so then odd number
            oddInt = randomValueInt 'if value odd set equal to random number to return
        End If
        Return randomValueInt 'returns random number to load into array
    End Function
    Sub WriteFile() 'writes array contents into file
        FileOpen(1, fileNameStr, OpenMode.Output) 'opens file to output mode overwrites anything currently in file
        For row As Integer = 0 To rowInt 'reads row contents in array 
            For column As Integer = 0 To columnInt 'reads column contents in array
                Write(1, numbersArrayStr(row, column)) 'writes row and column contents of array to file 1
            Next
        Next
        FileClose(1) 'closes file written to
        ArrayListBox.Items.Clear() 'clear list box after file close to empty contents in list box
        MsgBox("Items saved to file") 'prompts user that the items have been saved
    End Sub
    Sub ReadFile() 'reads text file and inputs values into array which displays in the list box
        Try
            FileOpen(1, fileNameStr, OpenMode.Input) 'opens same file that was written to to open
            For row As Integer = 0 To rowInt 'reads contents in file and loads into array             
                For column As Integer = 0 To columnInt      '//
                    Input(1, numbersArrayStr(row, column))  '/
                Next
            Next
            FillListBox() 'calls sub to fill list box with correct formatting
            readBool = True 'sets the boolean variable true to ensure listbox doesn't get added onto
            FileClose(1) 'close file read from
        Catch fileNotFound As IO.FileNotFoundException
            MsgBox("Sorry, that file doesn't exist") 'if file doesn't exist prompts user
        End Try
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close() 'close program
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub
End Class

