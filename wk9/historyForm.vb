'Carson Bogart
'Geran Call
'Fall 22
'Revolving graph

Option Strict On
Imports System.ComponentModel
Public Class historyForm
    Const CONST_RESOLUTION As Single = (3 / 1023) 'set constant resolution with 3v
    Dim v1Single(), v2Single() As Single 'single dimension arrays for the voltage values
    Dim nowString() As String 'used to display the timestamps on the graph
    Private Sub oscopeButton_Click(sender As Object, e As EventArgs) Handles oscopeButton.Click, ShowOScopeToolStripMenuItem.Click
        Me.Close() 'close form when the oscope button is pressed
    End Sub
    Private Sub showHistoryButton_Click(sender As Object, e As EventArgs) Handles showHistoryButton.Click, ShowHistoryToolStripMenuItem.Click
        Dim doneBoolean As Boolean = False 'boolean value to validate 
        Dim minSingle, maxSingle As Single 'minimum and maximum value to set the max and min values from array
        Dim tempString As String 'string used to write the contents of the file to the graph
        Dim ptr As Integer = 1 'file start at location 1

        Me.Refresh() 'refresh graph to draw again

        Me.CreateGraphics.DrawRectangle(Pens.Blue, 140, 30, Me.Width - 25 - 140, Me.Height - 50 - 30)
        'draw rectangle to show boundaries of graph
        ReDim Preserve v1Single(ptr - 1) 'redim the array to clear array
        ReDim Preserve v2Single(ptr - 1) '-/
        ReDim Preserve nowString(ptr - 1) '/
        Do
            Try
                FileOpen(1, oscopeForm.fileNameString, OpenMode.Input) 'open file under file name used in oscope form
                tempString = oscopeForm.fileNameString 'set value equal to file name
                doneBoolean = True 'leaves do loop to indicate done reading
            Catch ex As Exception
                doneBoolean = False 'continue loop still reading
            End Try
        Loop Until doneBoolean = True 'leave loop when done reading

        Do Until EOF(1)
            ReDim Preserve v1Single(ptr - 1) 'start at 0 in file
            ReDim Preserve v2Single(ptr - 1) '-/
            ReDim Preserve nowString(ptr - 1) '/
            Input(1, tempString) 'read first column in file
            v1Single(ptr - 1) = CSng(Val(tempString)) 'reads voltage value without saved "V"
            Input(1, tempString) 'reads second column in file
            v2Single(ptr - 1) = CSng(Val(tempString)) 'reads voltage value without saved "V"
            Input(1, nowString(ptr - 1)) 'read third column in file

            ptr += 1 'increment locating to save to array 
        Loop

        FileClose(1) 'file close

        If UBound(v1Single) < 2 Or UBound(v1Single) = Nothing Then Exit Sub 'dont graph if nothing read from file

        Dim pen1 As New Pen(Color.Red, 3) 'pens to draw ch1 and ch2 graph
        Dim pen2 As New Pen(Color.Blue, 3) '/

        Max1Label.ForeColor = Color.Red 'sets lable for ch1 red
        mid1Label.ForeColor = Color.Red '-/
        Min1Label.ForeColor = Color.Red '/

        Max2Label.ForeColor = Color.Blue 'sets label for ch2 blue
        Min2Label.ForeColor = Color.Blue '-/
        mid2Label.ForeColor = Color.Blue '/

        Call Min_Max(v1Single, minSingle, maxSingle) 'gets min max values from array for ch1
        Max1Label.Text = (CONST_RESOLUTION * maxSingle).ToString("N") & " V" 'displays max voltage for ch1
        mid1Label.Text = (CONST_RESOLUTION * maxSingle / 2).ToString("N") & " V" 'displays mid voltage level for ch1
        Min1Label.Text = (CONST_RESOLUTION * minSingle).ToString("N") & " V" 'displays min voltage for ch1
        Call Min_Max(v2Single, minSingle, maxSingle) 'get max and min values from array for ch2
        Max2Label.Text = (CONST_RESOLUTION * maxSingle).ToString("N") & " V" 'display max voltage on ch2
        mid2Label.Text = (CONST_RESOLUTION * maxSingle / 2).ToString("N") & " V" 'display mid voltage on ch2
        Min2Label.Text = (CONST_RESOLUTION * minSingle).ToString("N") & " V" 'display min voltage on ch2

        Call graph(v1Single, pen1) 'graph ch1 with pen1
        Call graph(v2Single, pen2) 'graph ch2 with pen2

        Dim font As New Font("Times New Roman", 8) 'create font to draw the time stamps

        Dim aInteger As Integer 'used to display time that measurement was taken
        For i As Integer = 140 To Me.Width Step CInt((Me.Width - 195) / 5) 'get width to draw the label along bottom
            aInteger = CInt((UBound(nowString) / (Me.Width - 195)) * (i - 140)) '/
            If aInteger > UBound(nowString) Then Exit For 'displays time only
            Me.CreateGraphics.DrawString(Mid(nowString(aInteger), 2, 10), font, Brushes.Black, i - 30, Me.Height - 95)
            Me.CreateGraphics.DrawString(Mid(nowString(aInteger), 13, 8), font, Brushes.Black, i - 30, Me.Height - 80)
            'draw the strings displaying time stamp
        Next
    End Sub
    Private Sub Min_Max(ByVal arry() As Single, ByRef min As Single, ByRef max As Single)

        min = arry(0) 'sets min to 0 of array
        max = arry(0) 'sets max to max value in array
        For i As Integer = 0 To UBound(arry) 'start at 0 in array and go to value in textbox
            If arry(i) < min Then min = arry(i) 'sets boundaries lower
            If arry(i) > max Then max = arry(i) 'sets boundaries higher
        Next

        If min = max Then max = min + CSng(0.02) 'prevents from a divide by zero error
    End Sub
    Private Sub graph(ByVal arry() As Single, ByVal pen1 As Pen)
        Dim minSingle, maxSingle As Single
        Dim yscaleSingle, xscaleSingle As Single
        Dim x1Integer, x2Integer, y1Integer, y2Integer, rightInteger, bottomInteger, leftInteger, topInteger As Integer

        'create border boundaries of drawn graph
        bottomInteger = Me.Height - 50 'set bottom of where the pen can draw
        rightInteger = Me.Width - 25 'set the max right position
        leftInteger = 140 'set value for left integer to display label
        topInteger = 30 '/

        Call Min_Max(arry, minSingle, maxSingle) 'get min and max for yscale
        yscaleSingle = CSng((bottomInteger - topInteger) / (maxSingle - minSingle)) 'set yscale
        xscaleSingle = CSng((rightInteger - leftInteger) / UBound(arry)) 'set xscale

        x1Integer = leftInteger 'draw graph
        y1Integer = CInt(bottomInteger - (arry(0) - minSingle) * yscaleSingle) '/

        For i As Integer = 0 To UBound(arry) 'execute until the upper bound of array met
            x2Integer = CInt((i * xscaleSingle) + leftInteger) 'set x2 with the xscale and left int
            y2Integer = bottomInteger - CInt((arry(i) - minSingle) * yscaleSingle) 'set y2 with bottom int with array iteration
            Me.CreateGraphics.DrawLine(pen1, x1Integer, y1Integer, x2Integer, y2Integer) 'draws line with pen 1 
            x1Integer = x2Integer : y1Integer = y2Integer 'set value for next loop to not reset starting position
        Next
    End Sub
    Private Sub historyForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        oscopeForm.Show() 'show oscilloscope form 
    End Sub
    Private Sub historyForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width < 500 Then Me.Width = 500 'forces width to not get smaller than set size
        If Me.Height < 455 Then Me.Height = 455 'forces height to not get smaller than set value
        Call showHistoryButton_Click(sender, e) 'call graph to resize graph
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        FileOpen(1, oscopeForm.fileNameString, OpenMode.Output) 'clears file 
        FileClose(1) 'closes file
        Me.Refresh() 'refresh file to clear graph
    End Sub
End Class