'Carson Bogart
'Geran Call
'Fall 22
'History Graph

'This porgram builds upon the last program by using the same revolving graph and saves the 2 analog
'voltages in a sequential file with the date and time stamps the samples were taken. The samples are 
'set to once every 1 second. The form will have a show history button where clicking on the button shows
'another form where the saved history can be shown by clicking another button. Within this saved hsitory the
'time stamp is written below the sample. In this form a clear button which will clear the file you are
'currently reading whcih then you have to click the show oscope button again to continue taking samples

Option Strict On
Public Class oscopeForm
    Public receiveByte(18) As Byte 'array recieved from qy@ board
    Private samplesInteger As Integer 'sample integer set from textbox value
    Public fileNameString As String = "C:\Users\clbog\Dropbox\Carson\wk9\history.txt" 'give program file location
    Const CONST_RESOLUTION As Decimal = CDec(3 / 1023) 'have constant resolution to easily change resolution
    Dim rightInteger, bottomInteger, topInteger, leftInteger As Integer 'integers to set labels on form
    Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog
    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.PortName = "COM7" 'selects COM port qy@ board is plugged into
        SerialPort1.BaudRate = 9600 'sets baud rate at 9600
        SerialPort1.DataBits = 8 'sets 8 data bits
        SerialPort1.Parity = IO.Ports.Parity.None 'no parity
        SerialPort1.Open() 'opens and initializes port

        sampleTextBox.Text = CStr(300) 'sets a default value in sample text box on load
        saveRateTextBox.Text = 1.ToString & " s" 'convert value in textbox to string and add an "S"
        Timer2.Interval = 1000 'set timer interval to 1 s

        openFileDialog1.FileName = fileNameString 'prompts user to select a file
        openFileDialog1.ShowDialog() '-/
        fileNameString = openFileDialog1.FileName '/

        Timer1.Enabled = True 'enable timers
        Timer2.Enabled = True '/
    End Sub
    Private Sub Graph_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SerialPort1.Close() 'closes serial port on form close
        FileClose(1) 'close file on close
        Timer1.Enabled = False 'diable timers on form close
        Timer2.Enabled = False '/
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False 'disable timer
        Dim analogRec0HInteger, analogRec0LInteger, analogRec1HInteger, analogRec1LInteger As Integer 'analog received values
        Dim volt1Integer, volt2Integer As Integer 'used to store voltage equiv received from qy@ board
        Dim pen1 As New Pen(Color.Red, 3) 'channel 2 pen
        Dim pen2 As New Pen(Color.Blue, 3) 'channel 1 pen

        Static volts1AInteger(5000), volts2AInteger(5000), minInteger, maxInteger As Integer 'create array to get max and min values from 
        Dim sampleInteger As Integer 'used to set bounds on textbox

        sampleTextBox.Text = CStr(HScrollBar1.Value) 'puts texbox value in scrollbar
        Me.Refresh() 'refresh every time timer ticks
        Me.CreateGraphics.DrawRectangle(Pens.Blue, 140, 30, Me.Width - 25 - 140, Me.Height - 50 - 30) 'redraw each timer tick

        Try
            sampleInteger = CInt(sampleTextBox.Text) 'test the contents in the sample text box
        Catch ex As Exception
            sampleTextBox.Text = CStr(50) 'sets to default value of 50
        End Try


        Dim sendByte(0) As Byte 'requests the analog input data
        sendByte(0) = &H5F  '/


        If sampleInteger < 300 Then sampleTextBox.Text = CStr(300) 'validates the value isn't below the set floor
        If sampleInteger > 5000 Then sampleTextBox.Text = CStr(5000) 'validates the value isn't below the set cieling

        SerialPort1.Write(sendByte, 0, 1) 'transfer data to the qy@ board
        SerialPort1.Read(receiveByte, 0, 10) '/
        analogRec0HInteger = receiveByte(0) 'channel 1 high
        analogRec0LInteger = receiveByte(1) 'channel 1 low
        analogRec1HInteger = receiveByte(2) 'channel 2 high
        analogRec1LInteger = receiveByte(3) 'channel 2 low

        analogRec0HInteger = analogRec0HInteger << 2 'rotate left 2 places
        analogRec0LInteger = (analogRec0LInteger >> 6) 'rotate right 6 places
        volt1Integer = analogRec0HInteger + analogRec0LInteger 'add both bytes together and store them in a variable
        volt1Label.Text = CStr(Math.Round((3 / 1023 * (analogRec0HInteger + analogRec0LInteger)), 2, MidpointRounding.AwayFromZero) & " V")
        'convert value into string and round off unnessecary decimal places then display


        analogRec1HInteger = analogRec1HInteger << 2 'rotate left 2 places
        analogRec1LInteger = CInt(analogRec1LInteger >> 6) 'rotate right 6 places
        volt2Integer = analogRec1HInteger + analogRec1LInteger 'add both bytes together and store them in a variable
        volt2Label.Text = CStr(Math.Round((3 / 1023 * (analogRec1HInteger + analogRec1LInteger)), 2, MidpointRounding.AwayFromZero) & " V")
        'convert value into string and round off unnessecary decimal places then display

        Call Rotate(volts1AInteger) 'call sub to rotate the values in the arrays
        Call Rotate(volts2AInteger) '/

        volts1AInteger(0) = volt1Integer 'sets the value equal to the 0th spot in the array
        volts2AInteger(0) = volt2Integer '/

        CH1Label.ForeColor = Color.Red 'set color of label to red for channel 1
        Max1Label.ForeColor = Color.Red '---/
        mid1Label.ForeColor = Color.Red '--/
        Min1Label.ForeColor = Color.Red '-/
        volt1Label.ForeColor = Color.Red '/
        CH2Label.ForeColor = Color.Blue 'set color of label to blue for channel 2
        Max2Label.ForeColor = Color.Blue '---/
        Min2Label.ForeColor = Color.Blue '--/
        mid2Label.ForeColor = Color.Blue '-/
        volt2Label.ForeColor = Color.Blue '/

        Call Min_Max(volts1AInteger, minInteger, maxInteger) 'gets min max values from array for ch1
        Max1Label.Text = (CONST_RESOLUTION * maxInteger).ToString("N") & " V" 'displays max voltage for ch1
        mid1Label.Text = (CONST_RESOLUTION * maxInteger / 2).ToString("N") & " V" 'displays mid voltage level for ch1
        Min1Label.Text = (CONST_RESOLUTION * minInteger).ToString("N") & " V" 'displays min voltage for ch1
        Call Min_Max(volts2AInteger, minInteger, maxInteger) 'get max and min values from array for ch2
        Max2Label.Text = (CONST_RESOLUTION * maxInteger).ToString("N") & " V" 'display max voltage on ch2
        mid2Label.Text = (CONST_RESOLUTION * maxInteger / 2).ToString("N") & " V" 'display mid voltage on ch2
        Min2Label.Text = (CONST_RESOLUTION * minInteger).ToString("N") & " V" 'display min voltage on ch2

        Call Graph(volts1AInteger, pen1) 'graph the values with the pen color red ch1
        Call Graph(volts2AInteger, pen2) 'graph values with pen color blue ch2

        Try
            sampleInteger = CInt(Val(Trim(saveRateTextBox.Text))) 'test if value of rate equ to samples
        Catch ex As Exception
            sampleInteger = 1 'set equal to one if the above case is true
        End Try

        Timer1.Enabled = True 'enable timer
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
        Dim x1Integer, x2Integer, y1Integer, y2Integer As Integer 'used to draw rectangle for graph
        Dim left As Integer = 60 'set value for labels to display from the left of the form
        Dim top As Integer = 20 'set values for variable label placement
        'set coordinates to draw the rectangle along with the boundaries of the graph
        Dim arrayInteger2() As Integer 'array to get the max and min values


        Max1Label.Left = left + 40 'set position of labels on the horizontal side
        Max2Label.Left = left + 40 '----/
        mid1Label.Left = left + 40 '---/
        mid2Label.Left = left + 40 '--/
        Min1Label.Left = left + 40 '-/
        Min2Label.Left = left + 40 '/
        Max1Label.Top = top 'set labels at top of form 
        Max2Label.Top = top + 20 '/
        mid1Label.Top = CInt(bottomInteger / 2) - 12 'sets at midpoint of form using a variable 
        mid2Label.Top = CInt(bottomInteger / 2) + 5 '/
        Min1Label.Top = bottomInteger - 30 'sets labels at bottom of graph 
        Min2Label.Top = bottomInteger - 13 '/


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
    Private Sub oscopeForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width < 600 Then Me.Width = 600 'forces width to not get smaller than set size
        If Me.Height < 500 Then Me.Height = 500 'forces height to not get smaller than set value
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close() 'close program when button clicked
    End Sub
    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        Me.Hide() 'hide form to show the history form to view saved captures
        historyForm.Show() '/
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'occurs every 1 second
        Timer2.Enabled = False 'disable timers
        Timer1.Enabled = False '/

        Dim validFileBoolean As Boolean = False 'validate if file is valid to open
        Do 'loop until validfile is selected
            Try
                FileOpen(1, fileNameString, OpenMode.Append) 'open file to write the voltage values
                WriteLine(1, volt1Label.Text & " V", volt2Label.Text & " V", Now) 'writes to file voltage values and timestamp
                validFileBoolean = True 'if file is valid then exits loop
            Catch ex As Exception
                validFileBoolean = False 'keeps in the loop if a valid file is not selected
            End Try
        Loop Until validFileBoolean = True 'will only leave if valid file

        FileClose(1) 'close file

        Timer2.Enabled = True 're-enable timers
        Timer1.Enabled = True '/
    End Sub
End Class
