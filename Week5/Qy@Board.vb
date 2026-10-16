'Carson Bogart
'Assignment 5
'Geran Call
'Fall 22

'This program connects to the Qy@ board at the moment it will take user input from a button and walk a
'a binary count on the digital outputs from 0 to 255 and reset. This will execute 1 time from a button
'press and can be done as many times as desired. It also takes user input from a button press to walk 1
'on the digital outputs counting from 1,2,4,8,16,32,64,128 lighting leds accordingly. This will execute
'25 times and clear the values once completed. The next function also takes user input from a button press
'and will ramp up the output on analog out 2. This will start with the output led off and slowly will start
'to gain brightness. Once this output value equals the value of 1024 it will reset, turning the LED off and 
'resseting the function. All funcitons up to this point will reset once they have executed to specifications
'this will ensure the user can use these funcitons as many times as desired. The DAC 1 output will follow a
'text box input to change the brightness of the output of analog 1. The textbox with input values will update
'the scroll bar the text box is the control of the scroll bar. The scroll bar is able to update the textboxs value
'this value is converted to a voltage then displayed on the analog output.


Option Strict On
Imports System.IO.Ports
Public Class QyForm
    Dim recievebytes(18) As Byte 'set array to recieve data from qy@ board
    Dim ValueInt As Integer = 0  'used to keep track of value on digital output
    Dim CountInt As Integer 'used to walk digital outputs and count up in binary
    Dim BinaryCountBool As Boolean = False 'variable to act as check box and when true counts binary
    Dim WalkBool As Boolean = False 'act as check box when true walks on digital outputs
    Dim RampBool As Boolean = False 'act as check box when true ramps up value on analog out 2
    Dim CountTimesInt As Integer    'used to keep track of iteration of how many times counted
    Dim VarDacInt As Integer 'used in ramp sub
    Dim AnalogOutH1, AnalogOutL1 As Integer 'two bytes of data for analog output 1
    Dim AnalogOutH0, AnalogOutL0 As Integer 'two bytes of data for analog output 0
    Dim InputVariableString As String 'used to read from text box to convert to voltage
    Dim InvertedScrollBar As Integer 'used to invert scroll bar to make bottom at 0

    Private Sub QyForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort.PortName = "COM3" 'setup port name found in device manager usb qy@ board is connected 
        SerialPort.BaudRate = 9600 'sets baud rate at 9600      
        SerialPort.DataBits = 8 '8 data bits
        SerialPort.StopBits = IO.Ports.StopBits.One '1 stop bit
        SerialPort.Parity = IO.Ports.Parity.None 'no parity
        SerialPort.Open() 'initialize and open port
        Timer.Enabled = True 'turn timer on
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Enabled = False 'disable timer 
        Dim sendByte(9) As Byte 'array to send all of the data in one packet

        sendByte(0) = 48 'request digital input data
        sendByte(1) = 95 'request analog input data all of the analog data
        sendByte(2) = 32 'start digital out data
        sendByte(3) = CByte(ValueInt) 'digital out data
        sendByte(4) = 65 'analog 0 output start
        Try
            sendByte(5) = CByte(AnalogOutH0) 'analog 0 data high 8 bits in one byte
            sendByte(6) = CByte(AnalogOutL0) 'analog 0 low 2 bits in one type
        Catch ex As Exception
            DACVolt1TextBox.Text = "0"
        End Try
        sendByte(7) = 66 'analog 1 output start data
        sendByte(8) = CByte(AnalogOutH1) 'analog 1 data high 8 bits
        sendByte(9) = CByte(AnalogOutL1) 'analog 1 data low 2 bits
        SerialPort.Write(sendByte, 0, 10) 'start data transfer to send 10 bytes

        Timer.Enabled = True 'enable timer
    End Sub
    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        SerialPort.Read(recievebytes, 0, 18) 'recieve up to 18 bytes
    End Sub
    Private Sub TimerCount_Tick(sender As Object, e As EventArgs) Handles TimerCount.Tick '2nd timer 
        If BinaryCountBool = True Then 'check the binary bool value if true button pressed
            If CountInt <> 256 Then 'test if count is not equal to 256
                ValueInt = CountInt 'set count and value equal to count on digital out
                CountInt += 1 'increment count by 1 after each check
            End If
            If CountInt = 255 Or CountInt = 256 Then 'test if count is 255 or 256 to reset 
                BinaryCountBool = False 'disable boolean variable
                ValueInt = 0 'clear variables to clear output values
                CountInt = 0 '/
            End If
        End If
        If WalkBool = True Then 'check if the walk bool is true button pressed
            'CCLabel.Text = CStr(CountInt) 'used to display the count on the outputs
            'ITRLabel.Text = CStr(CountTimesInt) 'used to show how many iterations have been done

            If CountTimesInt = 25 Then 'check if iteration is 25 to clear
                WalkBool = False 'set bool value false to exit if 
                CountInt = 0 'clear values to clear output values
                ValueInt = 0 '/
                CountTimesInt = 0 'set iteration to zero 
            Else                      'test if count is not equal to 8
                If CountInt <> 8 Then '/
                    ValueInt = CInt(2 ^ CountInt) 'set value equ to value of 2^count to walk the outputs
                    CountInt += 1 'increment count by 1 
                    If CountInt = 8 Then 'test if count equal to 8
                        CountInt = 0 'set count to zero to continue counting
                        CountTimesInt += 1 'add one to the iteration
                    End If
                End If
            End If
        End If
        If RampBool = True Then 'test if bool value true button pressed
            VarDacInt += 1 'increment variable to add to analog out
            'AN1Label.Text = CStr(VarDacInt) 'shows vardacint current value
            AnalogOutH1 = CInt((CInt(VarDacInt)) / 4) 'right shift 2 times
            AnalogOutL1 = CInt(CInt(VarDacInt)) 'adds value to low register
            If AnalogOutH1 = 256 Then AnalogOutH1 = 255 'make sure value on low byte isn't 256
            AnalogOutL1 = AnalogOutL1 And &H3 'AND the low byte with b'11'

            If VarDacInt = 1024 Then 'test if variable at 1024 to reset output
                RampBool = False 'set bool to false 
                AnalogOutH1 = 0 'clear anaolg output values turn led off
                AnalogOutL1 = 0 '/
                CountInt = 0 'clear count
                VarDacInt = 0 'clear variable dac
            End If
        End If
    End Sub
    Private Sub BinaryButton_Click(sender As Object, e As EventArgs) Handles BinaryButton.Click, BinaryCountToolStripMenuItem.Click
        BinaryCountBool = True 'if button pressed binary count execute
        WalkBool = False 'ensure the program will not execute these at the same time
        RampBool = False '/
        CountInt = 0 'set count to 0 to start binary count at 0
        TimerCount.Enabled = True 'enable 2nd timer
    End Sub
    Private Sub WalkButton_Click(sender As Object, e As EventArgs) Handles WalkButton.Click, WalkToolStripMenuItem.Click
        WalkBool = True 'if button pressed walk will execute
        BinaryCountBool = False 'ensure program only runs walk when button pressed
        RampBool = False        '/
        ValueInt = 0 'start value at 0 to walk from 1
        CountInt = 0 '/
        CountTimesInt = 0 'start iteration at 0 to ensure all 25 iterations are met
        TimerCount.Enabled = True 'enable 2nd timer
    End Sub
    Private Sub RampButton_Click(sender As Object, e As EventArgs) Handles RampButton.Click, RampToolStripMenuItem.Click
        RampBool = True 'if button pressed ramp Dac executes
        BinaryCountBool = False 'ensures program only runs Dac when button pressed
        WalkBool = False        '/
        CountInt = 0 'start at zero for full resolution
        VarDacInt = 0 '/
        TimerCount.Enabled = True 'enable timer
    End Sub
    Private Sub DACVolt1TextBox_TextChanged(sender As Object, e As EventArgs) Handles DACVolt1TextBox.TextChanged
        Try
            InputVariableString = CStr(((CDbl(DACVolt1TextBox.Text) * 1024) / 3)) 'convert input text box to voltage value
            AnalogOutH0 = CInt(CInt(InputVariableString) / 4) 'right shift 2 times
            AnalogOutL0 = CInt(CInt(InputVariableString)) 'adds value to low register
            If AnalogOutH0 = 256 Then AnalogOutH0 = 255 'make sure value on low byte isn't 256
            AnalogOutL0 = AnalogOutL0 And &H3 'AND the low byte with b'11'
            analog1VScrollBar.Value = 1024 - CInt(InputVariableString) 'subtract 1024 from input string to update scroll bar value
        Catch ex As Exception
            DACVolt1TextBox.Text = "" 'throws exception if text box is empty
        End Try
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide() 'hides main form
        AboutForm.Show() 'show about form
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close() 'close program
    End Sub
    Private Sub analog1VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles analog1VScrollBar.Scroll
        InvertedScrollBar = 1023 - analog1VScrollBar.Value 'inverts scroll bar
        DACVolt1TextBox.Text = CStr((3 / 1024) * (InvertedScrollBar)) 'convert text box to voltage
    End Sub
End Class
