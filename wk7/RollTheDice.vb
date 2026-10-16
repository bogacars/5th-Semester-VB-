'Carson Bogart
'Roll the dice (and graph them)
'Fall 2022
'Geran Call

'This program that rolls 3 dice and graphs the results in a picture box and displays the total numbers rolled
'The graph is graphed when the roll button is pressed on the form and three lines show the rolls at 3 different
'spots within the rolls. The graph and whole form is dynamically resizeable where the controls will follow with 
'the resize of the form. Along with the graph below the bar displays the number and the number of times that number
'was rolled. Each of the 3 dice are rolled 10,000 times then the numbers are graphed within the picture box
Option Strict On
Public Class RollTheDice
    Dim diceSumInteger, totalsInteger(18) As Integer 'dimension array to put max values from each roll into
    'diceSum adds the total random numbers of the three dice
    Dim rollBoolean As Boolean = False
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click, RollToolStripMenuItem.Click
        Dim d1Single, d2Single, d3Single, pointerSingle As Single 'dice single values and a pointer used to 
        'load array

        Randomize(DateAndTime.Timer) 'seed timer to randomize numbers
        For pointerSingle = 1 To 10000 'Load array with sums of rolls
            d1Single = (Int((Rnd() * 6) + 1)) 'randomize the value of the first, second, and third dice
            d2Single = (Int(Rnd() * 6) + 1)   '//
            d3Single = (Int(Rnd() * 6) + 1)   '/
            diceSumInteger = CInt(d1Single + d2Single + d3Single) 'add all dice values and load into sum integer
            totalsInteger(diceSumInteger) += 1 'add one to step through the array to load values
            'If ymax < diesum Then ymax = diesum
        Next pointerSingle
        rollBoolean = True
        Call Plot(totalsInteger) 'call sub to plot the totals array in bar format
        Call LabelGraph(totalsInteger) 'call sub to label graph with numbers of rolls and etc
    End Sub
    Private Sub Plot(ByVal arry() As Integer)
        Dim graph As Graphics = PictureBox1.CreateGraphics 'set a variable equal to the picture box graphics
        Dim yMaxInteger, pointerInteger As Integer 'variables used to set max in array and draw the bar graph
        Dim xScaleSingle, yScaleSingle, x1Single, y1Single, DWidthSingle, DHeightSingle As Single 'single variables
        'used to set the height/width of the picturebox, draw the bar graph values from the array and the scale of the
        'drawing using the height and width variables
        Dim myFont As New Font("courier new", 3 + (PictureBox1.Width \ 100)) 'font used to draw string at font size
        'dynamic to the form size
        DWidthSingle = PictureBox1.Width - 4 'set the width to start drawing
        DHeightSingle = PictureBox1.Height - 50 'set the height to start drawing
        yMaxInteger = Max(arry) 'get the max value from the max of the array 
        PictureBox1.Refresh() 'refresh the picture box to prevent pictures from stacking in box
        yScaleSingle = CSng(DHeightSingle / yMaxInteger) 'set scale dependent on set height
        xScaleSingle = CSng(DWidthSingle / 18) 'set xscale depending on amount of bar graphs desired and width
        For pointerInteger = 3 To 18 'Draw Bar Graph
            x1Single = (pointerInteger - 2) * xScaleSingle 'start at position 1 on the x scale
            y1Single = DHeightSingle - (arry(pointerInteger) * yScaleSingle) 'how many pixels from top
            graph.DrawRectangle(Pens.Azure, x1Single, y1Single, xScaleSingle - 5, DHeightSingle - y1Single) 'draws bar graphs
            'using the x and y values with a buffer between them so the graphs arent touching (-5)
        Next
    End Sub
    Private Sub LabelGraph(ByVal arry() As Integer)
        Dim graph As Graphics = PictureBox1.CreateGraphics 'allow the picture box to have graphics
        Dim myfont As New Font("courier new", 3 + (PictureBox1.Width \ 100)) 'sets font size depending on picurebox width
        For i As Integer = 0 To 15 'label graph with values rolled from array
            graph.DrawString(CStr(i + 3), myfont, Brushes.Yellow, 'draw the dice values rolled below the graph
            CSng(((PictureBox1.Width / 18) * i + 15) + PictureBox1.Width / 35), 'writes depending on width of picture box
            PictureBox1.Height - 40) 'labels graph
            graph.DrawString(CStr(arry(i + 3)), myfont, Brushes.Tomato, 'draw total values from dice rolls and displays
            CSng(((PictureBox1.Width / 18) * i + 26) + (PictureBox1.Width / 70)), 'the values below the number
            PictureBox1.Height - 20) 'labels graph
        Next i 'continues to next itteration

        For i = 1 To 3 'draw measurement lines 3 of them 
            graph.DrawString(CStr(CInt(Max(arry)) - (CInt(Max(arry)) / 4) * i), 'draw lables of the line position
            Font, Brushes.Red, 0, CSng((PictureBox1.Height - 10) / 4) * i) 'on the label line
            graph.DrawLine(Pens.OrangeRed, (0), (((PictureBox1.Height - 10) \ 4) * i), 'draw the lines in three different positions
            PictureBox1.Width, (((PictureBox1.Height - 10) \ 4) * i)) 'draw lines from the left of the picture box to the max width 
        Next
    End Sub

    Private Sub RollTheDice_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        If Me.Width < 400 Then Me.Width = 500 'sets a minimum width that the window is allowed to shrink
        If Me.Height < 400 Then Me.Height = 500 'sets a minimum height the window is allowed to shrink
        PictureBox1.Width = Me.Width - PictureBox1.Left - 25 'sets boarder right and left of the picture box
        PictureBox1.Height = Me.Height - PictureBox1.Top - 100 'sets boarder above and below the picture box
        RollButton.Top = Me.Height - (PictureBox1.Top + 65) 'adjust the button height position when the form is resized
        RollButton.Left = Me.Width - 195 'adjusts the width position when form is resized
        ExitButton.Top = Me.Height - (PictureBox1.Top + 65) 'adjust the button height position when the form is resized
        ExitButton.Left = Me.Width - 105 'adjusts the width position when form is resized
        If rollBoolean = True Then 'fixes graph showing up without clicking roll button when resizing form
            Plot(totalsInteger) 'resize graph with form resize
            LabelGraph(totalsInteger) 'resize labels with form resize
        End If
    End Sub

    Private Function Max(ByVal arry() As Integer) As Integer 'get the max value from the array
        Max = arry(0) 'start at the lowest bar in the array bar number 3
        For i As Integer = 0 To UBound(arry) 'start at zero and go to upper bounds of array
            If arry(i) > Max Then Max = arry(i) 'makes the max value the max value if greater than array max
        Next
    End Function

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show() 'show the about form 
        Me.Hide() 'hide the original form
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close() 'exits the program
    End Sub
End Class
