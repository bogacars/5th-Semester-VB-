'Carson Bogart
'Geran Call
'Fall 22
'Rotating graph

'this program uses the two analog inputs from the qy@ board an0 and an1 to plot
'the values on a rotating graph. Each of th inputs is a different color on the graph
'chanel 1 is blue an0 and chanel 2 is red an1. The samples are changeable by a scroll
'bar which will update the sample text box displaying the current number of samples
'From the top labels to the bottom it shows; max for chanel 1, mid for chanel 1
'and min for chanel 1. Also shown the last label is the voltage of that chanel. 
'The same concept applies to channel 2 which is red instead of blue. The graph
'and the labels auto size with the form while only allowing a specific height 
'and width before not allowing anymore resizing to be done.

Option Strict On
Public Class Form1
    Public receiveByte(18) As Byte 'array recieved from qy@ board
    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.PortName = "COM7" 'selects COM port qy@ board is plugged into
        SerialPort1.BaudRate = 9600 'sets baud rate at 9600
        SerialPort1.DataBits = 8 'sets 8 data bits
        SerialPort1.Parity = IO.Ports.Parity.None 'no parity
        SerialPort1.Open() 'opens and initializes port

        sampleTextBox.Text = CStr(50) 'sets a default value in sample text box on load

        Timer1.Enabled = True 'enable timer
    End Sub
    Private Sub Graph_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SerialPort1.Close() 'closes serial port on form close
        Timer1.Enabled = False 'disables timer
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False 'disable timer
        Dim analogRec0HInteger, analogRec0LInteger, analogRec1HInteger, analogRec1LInteger As Integer 'analog received values
        Dim volt1Integer, volt2Integer As Integer 'used to store voltage equiv received from qy@ board
        Dim pen1 As New Pen(Color.Red, 3) 'channel 2 pen
        Dim pen2 As New Pen(Color.Blue, 3) 'channel 1 pen


        Static volts1AInteger(500), volts2AInteger(500), minInteger, maxInteger As Integer 'create array to get max and min values from 
        Dim sampleInteger As Integer 'used to set bounds on textbox

        sampleTextBox.Text = CStr(HScrollBar1.Value) 'puts texbox value in scrollbar

        Me.Refresh() 'refresh every time timer ticks
        Me.CreateGraphics.DrawRectangle(Pens.Blue, 140, 30, Me.Width - 25 - 140, Me.Height - 50 - 30) 'redraw each timer tick

        Try
            sampleInteger = CInt(sampleTextBox.Text) 'test the contents in the sample text box
        Catch ex As Exception
            sampleTextBox.Text = CStr(50) 'sets to default value of 50
        End Try

        If sampleInteger < 50 Then sampleTextBox.Text = CStr(50) 'validates the value isn't below the set floor
        If sampleInteger > 500 Then sampleTextBox.Text = CStr(500) 'validates the value isn't below the set cieling 

        Dim sendByte(0) As Byte 'requests the analog input data
        sendByte(0) = &H5F  '/



        SerialPort1.Write(sendByte, 0, 1) 'transfer data to the qy@ board
        SerialPort1.Read(receiveByte, 0, 10) '/
        analogRec0HInteger = receiveByte(0) 'channel 1 high
        analogRec0LInteger = receiveByte(1) 'channel 1 low
        analogRec1HInteger = receiveByte(2) 'channel 2 high
        analogRec1LInteger = receiveByte(3) 'channel 2 low

        analogRec0HInteger = analogRec0HInteger << 2 'rotate left 2 places
        analogRec0LInteger = (analogRec0LInteger >> 6) 'rotate right 6 places
        volt1Integer = analogRec0HInteger + analogRec0LInteger 'add both bytes together and store them in a variable
        volt1Label.Text = CStr(Math.Round((3 / 1023 * (analogRec0HInteger + analogRec0LInteger)), 2, MidpointRounding.AwayFromZero))
        'convert value into string and round off unnessecary decimal places then display



        analogRec1HInteger = analogRec1HInteger << 2 'rotate left 2 places
        analogRec1LInteger = CInt(analogRec1LInteger >> 6) 'rotate right 6 places
        volt2Integer = analogRec1HInteger + analogRec1LInteger 'add both bytes together and store them in a variable
        volt2Label.Text = CStr(Math.Round((3 / 1023 * (analogRec1HInteger + analogRec1LInteger)), 2, MidpointRounding.AwayFromZero))
        'convert value into string and round off unnessecary decimal places then display

        Call Rotate(volts1AInteger)
        Call Rotate(volts2AInteger)

        volts1AInteger(0) = volt1Integer
        volts2AInteger(0) = volt2Integer



        Max1Label.ForeColor = Color.Blue
        mid1Label.ForeColor = Color.Blue
        Min1Label.ForeColor = Color.Blue
        volt1Label.ForeColor = Color.Blue
        Max2Label.ForeColor = Color.Red
        Min2Label.ForeColor = Color.Red
        mid2Label.ForeColor = Color.Red
        volt2Label.ForeColor = Color.Red


        Call Min_Max(volts1AInteger, minInteger, maxInteger)
        Max1Label.Text = CStr(maxInteger)
        mid1Label.Text = CStr(maxInteger / 2)
        Min1Label.Text = CStr(minInteger)
        Call Min_Max(volts2AInteger, minInteger, maxInteger)
        Max2Label.Text = CStr(maxInteger)
        mid2Label.Text = CStr(maxInteger / 2)
        Min2Label.Text = CStr(minInteger)

        Call Graph(volts1AInteger, pen1)
        Call Graph(volts2AInteger, pen2)

        Timer1.Enabled = True
    End Sub

    Private Sub Rotate(ByVal ary() As Integer)
        For i As Integer = UBound(ary, 1) To 1 Step -1 'start at ubound of array and count down 1 at a time
            ary(i) = ary(i - 1) 'shift contents of array down
        Next
    End Sub

    Private Sub Min_Max(ByVal arry As Array, ByRef min As Integer, ByRef max As Integer)
        Dim arrayInteger() As Integer 'get max and min values from array

        arrayInteger = CType(arry, Integer()) 'convert contents to type
        min = arrayInteger(0) 'sets min to 0 of array
        max = arrayInteger(0) 'sets max to max value in array

        For i As Integer = 0 To CInt(sampleTextBox.Text) 'start at 0 in array and go to value in textbox
            If arrayInteger(i) < min Then min = arrayInteger(i) 'sets boundaries lower
            If arrayInteger(i) > max Then max = arrayInteger(i) 'sets boundaries higher
        Next

        If min = 1023 Then min = 1022 'changes the min if ever above 1023 to 1022
        If min = max Then max = min + 1 '/
    End Sub
    Private Sub Graph(ByVal arry As Array, ByVal pen1 As Pen)
        Dim minInteger, maxInteger As Integer 'use variables to set max and min
        Dim yscaleSingle, xscaleSingle As Single 'variables to load y and x scale
        Dim x1Integer, x2Integer, y1Integer, y2Integer, rightInteger, bottomInteger, topInteger, leftInteger As Integer
        'set coordinates to draw the rectangle along with the boundaries of the graph
        Dim arrayInteger2() As Integer 'array to get the max and min values

        bottomInteger = Me.Height - 50 'sets boundaries for graph on form
        rightInteger = Me.Width - 25 '--/
        leftInteger = 140 '-/
        topInteger = 30 '/

        arrayInteger2 = CType(arry, Integer()) 'convert array object to data type
        Call Min_Max(arrayInteger2, minInteger, maxInteger) 'get min and max for yscale
        yscaleSingle = CSng((bottomInteger - topInteger) / (maxInteger - minInteger)) 'set yscale
        xscaleSingle = CSng((rightInteger - leftInteger) / CInt(sampleTextBox.Text)) 'set xscale

        x1Integer = leftInteger 'draw x scale on graph
        y1Integer = CInt(bottomInteger - (arrayInteger2(0) - minInteger) * yscaleSingle) 'draw y scale on graph

        For i As Integer = 0 To CInt(sampleTextBox.Text) 'start at zero and continue until the value of the text box
            x2Integer = CInt((i * xscaleSingle) + leftInteger) 'sets value on the x2 integer
            y2Integer = bottomInteger - CInt((arrayInteger2(i) - minInteger) * yscaleSingle) 'set value on y2 integer
            Me.CreateGraphics.DrawLine(pen1, x1Integer, y1Integer, x2Integer, y2Integer) 'draw the graph
            x1Integer = x2Integer : y1Integer = y2Integer 'set value to start at previous coordinates
        Next
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width < 450 Then Me.Width = 450 'forces width to not get smaller than set size
        If Me.Height < 375 Then Me.Height = 375 'forces height to not get smaller than set value
        ExitButton.Top = Me.ClientRectangle.Bottom - 30 'moves when form resize
        Max1Label.Top = Me.Height - 344 '---------/
        mid1Label.Top = Me.Height - 300 '--------/
        Min1Label.Top = Me.Height - 255 '-------/ 
        Max2Label.Top = Me.Height - 344 '------/
        mid2Label.Top = Me.Height - 300 '-----/
        Min2Label.Top = Me.Height - 255 '----/
        volt1Label.Top = Me.Height - 190 '---/
        volt2Label.Top = Me.Height - 190 '--/
        sampleTextBox.Top = Me.Height - 150 '-/
        HScrollBar1.Top = Me.Height - 120 '/
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close() 'close program when button clicked
    End Sub
End Class
