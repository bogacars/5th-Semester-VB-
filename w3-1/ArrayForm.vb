'Carson Bogart
'RCET 3371
'Array Assignment "grade book"
'Geran Call
'Fall 2022

'This program uses a 2D array which contains a list of all students in a class in the rows of the array. This 2D array will have assignments which can_
'be added to a student then graded according. The maximum class size will be 12 where the user can add students up to 12. The grades for each assignment_
'will be added to each student seperately. This 2D array uses one long string that populates the listbox with some default names and empty strings where_ 
'the program will add items to the listbox by looking at the array till an empty string is present. The assignment grades for each student will be averaged_
'and given to the teacher automatically

Option Strict On
Public Class ArrayForm
    Dim rowQ As Integer = 12 'set global variable for the row to only change it at one spot in the program
    Dim columnQ As Integer = 10 'set global varable for the column to only change at one spot in code
    Dim studentArray(rowQ, columnQ) As String 'set array as global to acsess throughout the program
    Dim passedColoumn As Integer
    Private Sub ArrayForm_Load(sender As Object, e As EventArgs) Handles Me.Load 'when form loads preloads listbox with set values

        For column As Integer = 0 To columnQ 'starts at column 0 to 10 to populate listbox with empty strings
            For row As Integer = 0 To rowQ 'uses row to populate with empty strings
                studentArray(row, column) = "" '/
            Next 'continues till the whole list box is populated
        Next '/

        studentArray(0, 0) = "Names" 'sets prelaoded values on startup
        studentArray(1, 0) = "Carson"  '/////
        studentArray(2, 0) = "Fallon"  '////
        studentArray(3, 0) = "Morgan"  '///
        studentArray(4, 0) = "Jamison" '//
        studentArray(5, 0) = "Geran"   '/

        FillListBox() 'calls fill listbox sub
        AddToComboBoxStudent() 'loads combo box with preloaded values
    End Sub
    Private Sub AddStuButton_Click(sender As Object, e As EventArgs) Handles AddStuButton.Click 'adds new student name to listbox
        For rowCount = 0 To rowQ 'sets variable to find the row count in the array
            If studentArray(rowCount, 0) = "" Then 'when an empty string is present stops and waits for input on text box
                studentArray(rowCount, 0) = AddStudentTextBox.Text 'adds student name in array at the empty string preloaded in
                Exit For 'exits for loop to continue 
            End If 'exits if statement
        Next   'continues to next line of code
        FillListBox() 'calls sub to fill listbox with input values
        AddStudentTextBox.Clear() 'clears when student has been added to avoid adding duplicates
        AddToComboBoxStudent() 'calls sub to add to a combo box
    End Sub
    Private Sub AssignmentButton_Click(sender As Object, e As EventArgs) Handles AssignmentButton.Click 'adds assignment to listbox
        For colCount = 0 To columnQ 'sets variable to find empty coloumns to add assignments to
            If studentArray(0, colCount) = "" Then 'finds empty column
                studentArray(0, colCount) = AssignmentTextBox.Text 'populates empty coloumn with inupt text value
                passedColoumn = colCount 'passes current column count to future sub
                Exit For
            End If
        Next
        FillListBox() 'call filllistbox sub to fill when assignment is input
        AssignmentTextBox.Clear() 'clears textbox to prevent dupilicates
        AddToComboBoxAssignment() 'adds to combobox 
        GradeAdd(passedColoumn) 'takes passed value and brings it to the called sub
    End Sub
    Sub FillListBox() 'sub fills list box with assignment/student name when called
        Dim rowS As String 'variable to add space with column and row on array
        GradeListBox.Items.Clear() 'clear list box before adding to it when called multiple times doesnt stack

        For row As Integer = 0 To rowQ 'sets upper limit as rowQ global variable
            For column As Integer = 0 To columnQ 'sets upper limit as columnQ global varible
                rowS += LSet(studentArray(row, column), 10) 'adds space with lSet in array allows columns in listbox
            Next
            GradeListBox.Items.Add(rowS) 'adds input value on existing rowS variable
            rowS = "" 'clear after values are input to use again
        Next

    End Sub
    Sub AddToComboBoxStudent() 'adds names added with default names to combo box
        Dim comboRow As Integer 'uses rows on array which are names 
        StudentComboBox.Items.Clear() 'clear to remove any unwanted spaces doesnt stack when called multiple times
        Do 'adds array items to combo box
            comboRow += 1 'and
            StudentComboBox.Items.Add($"{studentArray(comboRow, 0)}") 'takes array values and puts them in combo box
        Loop Until studentArray(comboRow, 0) = "" Or comboRow = 12 ' loops until array boundaries are met
    End Sub
    Sub AddToComboBoxAssignment() 'TODO fix
        Dim comboRow As Integer
        StudentComboBox.Items.Clear()
        Do
            comboRow += 1
            AssignmentComboBox.Items.Add($"{studentArray(comboRow, 0)}")
        Loop Until studentArray(comboRow + 1, 0) = "" Or comboRow = 11
    End Sub
    Sub GradeAdd(passedColumn As Integer) 'brings passed cloumn value from sub above
        Dim grade As Integer 'set grade as integer to use to set grades
        Try
            For row = 1 To 12 'runs through rows 1 to 12 becuase 0 is the name section
                If studentArray(row, 0) = "" Then 'checks if the row is empty the exits for loop
                    Exit For                      '/
                ElseIf studentArray(row, passedColumn) = "" Then 'tests if the column is empty with the corresponding row
                    grade = CInt(InputBox($"Enter a grade for {studentArray(row, 0)}")) 'Prompts user to enter grade for specidic student
                    studentArray(row, passedColoumn) = CStr(grade) 'converts grade to string to display in list box 
                End If
                FillListBox() 'call fill listbox to populate with grade
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub
End Class
