Option Strict On
'Carson Bogart
'Etch-a-sketch
'Fall 2022
'Geran Call

'This program interfaces with the Qy@ board that uses a picture box and analog inputs 0 and 1
'to move the cursors to move the drawing position in the picture box. It is able to change the color
'of the drawing tool when a new color is desired an entire color pallete will pop up on a button click.
'When the erase button is clicked the picture box will shake and erase the contents of the picture box. A
'button will draw waveforms sine, cosine, and tangent waves all in different colors with a 10x10 scope
'graticule (10 verticle lines, 10 horizontal lines like an oscilloscope display).
Imports System.IO.Ports

Public Class EtchForm

    Dim recieveBytes(18) As Byte  'set array to recieve data from qy@ board
    Dim MainPen As New Pen(Color.Black) 'set default pen color
    Dim x1int, y1int, x2int, y2int As Integer
    Dim oldX, oldY As Integer
    Dim qyBool As Boolean = False

    Private Sub EtchASketchForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort1.PortName = "COM7" 'setup port name found in device manager usb qy@ board is connected
        SerialPort1.BaudRate = 9600 'sets baud rate at 9600 
        SerialPort1.DataBits = 8 '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None 'no parity
        SerialPort1.Open() 'initialize and open port
        Timer1.Enabled = True 'turn timer on
        PictureBox.BackColor = Color.White 'load form at default white
        x1int = 0
        x2int = 0
        y1int = 0
        y2int = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim AnalogRec0H, AnalogRec0L As Integer 'used to recieve the high and low bytes of analog from qy@board
        Dim graphs As Graphics = PictureBox.CreateGraphics 'used to created graphics

        Timer1.Enabled = False 'disable timer

        'analog input 0
        AnalogRec0H = recieveBytes(1) 'recieve high byte
        AnalogRec0L = recieveBytes(2) 'receieve low byte
        AnalogRec0H = AnalogRec0H * 4 'shift bits left 2 spots
        AnalogRec0L = CInt(AnalogRec0H / 64) 'right shift bits 4 spots
        y2int = CInt((PictureBox.Height / 1023)) * (AnalogRec0H + AnalogRec0L) 'used to convert the analog values into steps in picture box

        'analog input 1
        AnalogRec0H = recieveBytes(3) 'recieve high byte
        AnalogRec0L = recieveBytes(4) 'recieve low byte
        AnalogRec0H = AnalogRec0H * 4 'shift bits left 2 spots
        AnalogRec0L = CInt(AnalogRec0H / 64) 'righ shift bits 4 spots
        x2int = CInt((PictureBox.Width / 1023) * (AnalogRec0H + AnalogRec0L)) 'used to convert analog values into steps

        If qyBool = True Then
            graphs.DrawLine(Pens.Black, x1int, y1int, x2int, y2int) 'reads analog input and draws according to value
            graphs.Dispose() 'dispose graph to start new graph
            x1int = x2int : y1int = y2int 'set the x and y values equal to each other
        End If

        Dim sendByte(9) As Byte 'send all data in one packet
        sendByte(0) = 48 'request digital input
        sendByte(1) = 95 'request analog input
        SerialPort1.Write(sendByte, 0, 10) 'start data transfer

        Timer1.Enabled = True 'enable timer 

    End Sub


    Sub MouseDraw(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Dim G As Graphics = PictureBox.CreateGraphics 'used to create graphics in the picture box
        G.DrawLine(Me.MainPen, x1, y1, x2, y2) 'draws line from where the mouse is
        G.Dispose() 'clear the graphics
    End Sub
    Private Sub PictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox.MouseDown, PictureBox.MouseMove
        'Allows the user to draw
        'Using the left mouse button click
        Dim MyPoint As Point 'set points x and y
        MyPoint.Y = 0        '//
        MyPoint.X = 0        '/
        Me.Text = $"({e.X},{e.Y}) Button: {e.Button.ToString} Color: {Me.MainPen.Color.ToString}" 'displays to user what button is pressed
        'Shows user what button on mouse is clicked
        Select Case e.Button.ToString 'depending on the button pressed a case will be selected
            Case "Left" 'calls the mouse draw subroutine to draw on the picture box
                MouseDraw(oldX, oldY, e.X, e.Y) '/ 
            Case "Middle" 'clicking the middle button will display a color menu for the user to select a different color
                ColorDialog.ShowDialog()                '//
                Me.MainPen.Color = ColorDialog.Color    '/
            Case "Right"
            Case "None"
            Case Else 'if an unkown button is pressed will notify user
                MsgBox("What did you just press?")  '/
        End Select
        oldX = e.X 'used to start points at where the mouse is at on the picture box
        oldY = e.Y  '/
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        Shake() 'call sub to shake screen
        PictureBox.BackColor = Color.White 'set background color to white
        PictureBox.Refresh() 'clears picture box contents
    End Sub
    Sub Shake()
        Dim offset As Integer = 100 'set variable a constant to shake the screen
        For var As Integer = 1 To 10 'loops 1 to 10 times shaking the picture box then erasing it
            offset *= -1 'will move picture box by factor of -1
            PictureBox.Left += offset '/
            System.Threading.Thread.Sleep(100) 'allow user to see that the screen is actually shaking
        Next
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click, ChangeColorToolStripMenuItem.Click
        ColorDialog.ShowDialog() 'shows color dialog for user to select color
        Me.MainPen.Color = ColorDialog.Color 'sets the pen color as selected color
    End Sub

    Private Sub QyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles QyCheckBox.CheckedChanged
        qyBool = True 'sets boolean true to use qy@ board to draw
    End Sub

    Private Sub EtchForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width < 400 Then Me.Width = 500 'sets a minimum width that the window is allowed to shrink
        If Me.Height < 400 Then Me.Height = 500 'sets a minimum height the window is allowed to shrink
        PictureBox.Width = Me.Width - PictureBox.Left - 25 'sets boarder right and left of the picture box
        PictureBox.Height = Me.Height - PictureBox.Top - 100 'sets boarder above and below the picture box
        ClearButton.Left = Me.Width - (ClearButton.Width + ExitButton.Width) - 35 'allows the controls to adapt to form change width wise
        ExitButton.Left = Me.Width - (ClearButton.Width + ExitButton.Width) + 55  '////
        DrawWButton.Left = Me.Width - (ClearButton.Width + ExitButton.Width) - 125 '///
        ColorButton.Left = Me.Width - (ClearButton.Width + ExitButton.Width) - 215 '//
        QyCheckBox.Left = Me.Width - (ClearButton.Width + ExitButton.Width) - 315  '/
        ClearButton.Top = Me.Height - (PictureBox.Top + 65) 'allows controls to adapt to form change height wise
        ExitButton.Top = Me.Height - (PictureBox.Top + 65)  '////
        DrawWButton.Top = Me.Height - (PictureBox.Top + 65) '///
        ColorButton.Top = Me.Height - (PictureBox.Top + 65) '//
        QyCheckBox.Top = Me.Height - (PictureBox.Top + 65)  '/
    End Sub
    Private Sub DrawWButton_Click(sender As Object, e As EventArgs) Handles DrawWButton.Click, DrawWaveformToolStripMenuItem.Click
        Dim graph As Graphics = PictureBox.CreateGraphics 'used to create graphics on the picture box
        Dim fudge, radius, angle As Single 'used to draw waveforms and a boarder on the inside of the picture box
        Dim x1, x2, y1, y2, drawHeight, drawWidth As Single 'used to draw waveforms in correct location
        Dim gratX1, gratX2, gratY1, gratY2 As Single 'used to draw graticules to show 10x10 scope
        Dim pen As New Pen(Color.Black) 'sets a variable for the pen to have default color
        pen.Width = 1 'sets the thickness of the pen


        PictureBox.Height = Me.Height - 115 'resizes the picture box depending on form size
        PictureBox.Width = Me.Width - 70    '/
        graph.Clear(Color.Gray) 'sets picture box background to gray when graph is desired
        fudge = 5I 'used to create a boarder on the inside of the picture box to show boundaries
        drawHeight = PictureBox.Height - fudge 'subtract the height and the fudge for a small frame
        drawWidth = PictureBox.Width - fudge   '/
        graph.DrawRectangle(Pens.Gray, 0, 0, drawWidth, drawHeight) 'draws the boarder in the picture box


        gratY1 = 0 'set values equal to zero
        gratY2 = 0 '/
        For i = 1 To 10 'loops from 1 - 10 in the y scale to draw lines
            gratX1 = 0 '/
            gratY1 += CInt(PictureBox.Height \ 10) 'draws a graticule every 1 section in the horizontal direction
            gratX2 = PictureBox.Width 'line draws until the pitcure box width
            gratY2 += CInt(PictureBox.Height \ 10) 'draws lines until the bottom of the picture box is met
            graph.DrawLine(pen, gratX1, gratY1, gratX2, gratY2) 'draws the lines each iteration
        Next
        gratX1 = 0 'set values to equal zero to start at zero
        gratX2 = 0 '/
        For i = 1 To 10 'loops through 10 times to create vertical graticules
            gratX1 += CInt(PictureBox.Width \ 10) '///
            gratY1 = 0                            '//
            gratX2 += CInt(PictureBox.Width \ 10) '/
            graph.DrawLine(pen, gratX1, gratY1, gratX2, gratY2) 'draw lines each iteration
        Next

        radius = drawHeight / 2 'draw sine wave starting at the halfway point in the picture box
        x1 = 0 : y1 = drawHeight / 2 '/
        For angle = 0 To 360 Step 1.0 'loop from 0 to 360 degrees to show whole sine wave
            y2 = CSng(-radius * Math.Sin(angle / 57.3) + drawHeight / 2) 'convert values to radians
            x2 = angle * drawWidth / 360 'convert to radians
            graph.DrawLine(Pens.YellowGreen, x1, y1, x2, y2) 'draw sine wave
            x1 = x2 : y1 = y2 'start at the same position each time
        Next

        x1 = 0 : y1 = drawHeight / 4 'draw cosine wave starting at quarter point in picture box
        For angle = 0 To 360 Step 1.0 'loop from 0 to 360 degrees to show whole sine wave

            y2 = CSng(radius * Math.Cos((angle / 57.3)) + drawHeight / 2) 'convert values to radians
            x2 = angle * drawWidth / 360 'convert to radians
            graph.DrawLine(Pens.Salmon, x1, y1, x2, y2) 'draw cosine wave
            x1 = x2 : y1 = y2 'start at the same position each time
        Next

        x1 = 0 : y1 = drawHeight / 4 'draw cosine wave starting at quarter point in picture box
        For angle = 0 To 360 Step 1.0 'loop from 0 to 360 degrees to show whole sine wave

            y2 = CSng(radius * Math.Tan((angle / 57.3)) + drawHeight / 2) 'convert values to radians
            x2 = angle * drawWidth / 360 'convert values to radians
            graph.DrawLine(Pens.Orange, x1, y1, x2, y2) 'draw tangent wave
            x1 = x2 : y1 = y2 'start at the same position each time
        Next
        pen.Dispose() 'clear pen value
        graph.Dispose() 'clear graph value
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close() 'close program
    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        SerialPort1.Read(recieveBytes, 0, 18) 'recieve bytes
    End Sub
End Class
