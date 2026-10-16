'Carson Bogart
'Spring 22
'Geran Call
'Stans Grocery
'This program reads any grocery.txt file and populates an array with the values of the .txt file.
'The text file is dimensioned 5 columns by 8 rows which means a total of 40 items on the file. This program loads
'a combo box with the values of a selected file. In each aisle there is 8 items and has 5 aisles that is the format
'of the text file. The customers of this grocery store are able to search for items by entering text into the combo box.
'When searching the customer will be shown the location and the item number, if the customer searches something that isn't 
'in the store (text file) the customer will be prompted that the item is not in stock at the store. When the customer types
' "zzz" the program exits. 


Option Strict On
Option Compare Text
Option Explicit On
Public Class StansForm
    Dim fileNameString As String = "C:\Users\callgera\Dropbox\1 VB class assignments\F2022\Carson\Stans\Grocery.txt" '
    Dim foodString(8, 5) As String 'dimensions the foodstring array to load the txt file into
    '
    Private Sub StansForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'form load sub to start on load
        LocationLabel.Text = "Enter an item to search above" 'populates this label on load to tell user to search
    End Sub    'ends form load sub
    Sub FileOpenSub() 'sub that uses file dialog to enable user to choose a file to add to array
        Dim validFileInt, goodFileInt As Int32 'used to test if the file is valid to insert in array
        Dim lookFileNameString As String = "C:\Grocery.txt" 'used to have a general area to search for on computer for txt file
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog 'creates openfiledialog to show user file dialog to select a file
        Do 'start file open loop
            Try 'tests to see if the file is valid to open 
                FileOpen(1, lookFileNameString, OpenMode.Input) 'open file 1 and searches for the path using input mode
                validFileInt = 0 'set validFileInt as zero
            Catch ex As Exception
                validFileInt = 1 'set validFileInt as 1
                openFileDialog1.FileName = lookFileNameString 'openfiledialog for the grocery.txt
                openFileDialog1.ShowDialog() 'shows user dialog to select file
                lookFileNameString = openFileDialog1.FileName 'sets used file as the string
            End Try
            Try
                ContentOfFile() 'adds new file contents to the combo box
            Catch ex As Exception
            End Try
        Loop Until validFileInt = goodFileInt 'loops until the two set int32 are equal
    End Sub

    Sub ContentOfFile() 'adds file contents to the combo box
        Dim variableString As String 'used to load values into the array
        FileOpen(1, fileNameString, OpenMode.Input) 'open file selected from fileopen sub
        For row = 1 To 8 'display all 8 rows
            For column = 1 To 5 'display all 5 columns
                Input(1, variableString) 'uses file 1 and the variable string to input into array 
                FoodComboBox.Items.Add(variableString) 'adds variable string to combo box to view all contents in text file
                foodString(row, column) = variableString 'adds variable string to array which is all contents of text file
            Next
        Next
        FileClose(1) 'close file to prevent issues when trying to open again
    End Sub
    Sub SearchTextFile()
        Dim enteredBoolean As Boolean = False 'used to test if a value has been entered into the combo box to search
        LocationLabel.Text = "" 'clears label text to ensure no values stack onto existing text
        If FoodComboBox.Text <> "" Then 'if the combo box is not equal to empty then the text in the label box is = to combo box text
            If FoodComboBox.Text = "zzz" Then 'when zzz is typed in combo box exit program
                CloseProgram()                '/
            End If
            LocationLabel.Text = FoodComboBox.Text 'checks to see if text has been entered in combo box
        Else
            LocationLabel.Text = CStr(FoodComboBox.SelectedItem) 'sets the label equal to the selected item in the combo box
        End If
        For row = 1 To UBound(foodString, 1) 'searches the rows to upper bounds of the array value
            For col = 1 To UBound(foodString, 2) 'searches the columns to upper bound of array for searched value
                If LocationLabel.Text = CStr(foodString(row, col)) Then 'if entered text is equal to value in array then it will display location and item
                    LocationLabel.Text = ("The item searched: " + CStr(LocationLabel.Text) + " can be found on aisle " + CStr(row) + " item number is " + CStr(col))
                    enteredBoolean = True 'sets to true to see that a value was entered
                End If
            Next
        Next
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub FileButton_Click(sender As Object, e As EventArgs) Handles FileButton.Click
        FileOpenSub()
    End Sub
    Sub CloseProgram()
        Me.Close()
    End Sub
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchTextFile()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        SearchTextFile()
    End Sub
    Private Sub FileSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileSelectToolStripMenuItem.Click
        FileOpenSub()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub
End Class
