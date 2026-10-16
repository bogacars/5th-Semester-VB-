'Carson Bogart
'Geran Call
'Fall 2022
'RL Cirucit solver


'This program takes user input and puts the input values into the instantaneous current formula to solve for the voltage of the resistotr at a specific time set by the resisitor
'and inductor value to find the tau. The tau is then incremented by 0.5 in a for loop then displayed in an output list box. The voltage of the inductor is solved by taking the input
'value of the input VIN and subtracting that value by the voltage on the inductor at that time

Option Strict On

Class RLCircuit
    Dim tau As Double   'sets tau as a double global variable to set tau as 1 value, L/R in a sub
    Dim currentInductor As Double   'sets currentInductor as a double global to set
    Dim time As Double     'set time as global double to use as a variable in the for loop to add to the existing time
    Dim vin As Integer      'sets vin as global to solve for inductor and resistor voltage
    Dim voltageInductor As Double   'sets voltageInductor as global to use to solve for the voltage of the resistor
    Dim voltageResistor As Double   'set voltageResistor to global to use in solving for the voltage of the inductor
    Dim currentFinal As Double      'set currentFinal to global to use to find the current of the inductor at a time in intervals of 0.5
    Dim testIfValid As Boolean      'sets the testIfValid as boolean to use in the validate function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click       'when clicked the below code executes 
        ResistorTextBox.Clear()     'clears resistor text box
        InductorTextBox.Clear()     'clears inductor text box
        VinTextBox.Clear()          'clears VIN text box
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()      'closes the program
    End Sub

    Function Validation(testIfValid As Boolean) As Boolean 'function to test the inputs and validate that the correct value is input
        testIfValid = True 'sets testIfValid as true so if any of the below code is invalid then the function returns a false

        If IsNumeric(ResistorTextBox.Text) = False Or ResistorTextBox.Text = " " Then 'tests the resistor text box to see if numeric values or if it is empty
            testIfValid = False 'sets the variable as false so the function will return a false 
            MsgBox("Please enter a numeric resistor value")  'prompts the user to enter a value into the textbox
            ResistorTextBox.Focus() 'sets the focus to the resistor text box
        End If 'moves to next validation step

        If IsNumeric(InductorTextBox.Text) = False Or InductorTextBox.Text = " " Then   'tests the inductor text box to see if numeric values are used or if its empty
            testIfValid = False 'sets the variable as false so the function will return a false
            MsgBox("Please enter a numeric inductor value") 'promtps the user to enter a numeric value
            InductorTextBox.Focus() 'focouses on the inductor text box
        End If 'moves to the next validation step

        If IsNumeric(VinTextBox.Text) = False Or VinTextBox.Text = " " Then 'tests vin text box to see if numeric values are used or if its empty
            testIfValid = False 'sets the variable as false so the function will return a false
            MsgBox("Please enter a numeric voltage") 'promtps the user to enter a numeric value
            VinTextBox.Focus() 'focuses on the vin text box
        End If 'moves to the return of the function 

        Return testIfValid 'returns a false if any of the validation tests were met meaning validation is needed
    End Function
    Sub TauandCurrentValue() 'sub that gathers the tau and currentFinal to then use when the calculatebutton is pressed
        tau = CDbl(InductorTextBox.Text) / CDbl(ResistorTextBox.Text)  'takes the inductor and resistor text box and converts them to dbl to find tau by dividing them
        currentFinal = CDbl(VinTextBox.Text) / CDbl(ResistorTextBox.Text) 'takes the vin and resistor text box and converts them to dbl to find the current final used in the calculate sub
    End Sub


    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click 'when the calculate button is pressed the below code executes
        If Validation(True) Then 'if the validation is true runs the two subs to find the voltage of the resistor and the inductor with the time
            TauandCurrentValue() 'goes to the tauandcurrentvalue sub to execute the code when validation is needed
            CalculateValues()    'goes to the calculatevaluse sub when no validation is needed
        Else

        End If

    End Sub
    Sub CalculateValues()   'calculates the values needed to display in the list box
        Dim formattedTimeString As String 'creates a time string to later add "engineering" notation format
        Dim formattedVoltageResistor As String  'creates a voltageResistor string to later add "engineering" notation format
        Dim formattedVoltageInductor As String  'creates a voltageInductor string to later add "engineering" notation format


        For i = 0 To (5.5 * tau) Step (0.5 * tau) 'executes the below loop 11 times and displays them in a list box



            currentInductor = currentFinal - ((currentFinal - 0) * 2.71828182845904 ^ (-i / tau)) 'instantaneous current equation to find the voltage of the resistor
            time = i * tau 'multiplies the iterations by tau to get the time at each iteration 
            voltageResistor = currentInductor * CDbl(ResistorTextBox.Text) 'uses the instantaneous value from the above formula and the user input resistor value to find the voltage on the resistor
            voltageInductor = CDbl(VinTextBox.Text) - voltageResistor   'uses the input VIN value and the voltage on the resistor to find the voltage remaining on the inductor
            formattedTimeString = Format(time, "E") 'adds the engineering notation to the time section string
            formattedVoltageResistor = Format(voltageResistor, "E") 'adds the engineering notation to the voltageResistor section string
            formattedVoltageInductor = Format(voltageInductor, "E") 'adds the engineering notation to the voltageInductor section string


            OutputListBox.Items.Add(formattedTimeString.PadLeft(10) & vbTab & formattedVoltageResistor.PadLeft(10) & vbTab & formattedVoltageInductor.PadLeft(10)) 'adds each "time", "VL", and "VR" to the list box with 10 spaces to the left of all of them
        Next 'executes the loop until done 11 times
    End Sub
    Private Sub ClearListButton_Click(sender As Object, e As EventArgs) Handles ClearListButton.Click
        OutputListBox.Items.Clear() 'clears the list box when the button is pressed
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub
End Class
