<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QyForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCount = New System.Windows.Forms.Timer(Me.components)
        Me.BinaryButton = New System.Windows.Forms.Button()
        Me.WalkButton = New System.Windows.Forms.Button()
        Me.RampButton = New System.Windows.Forms.Button()
        Me.DACVolt1TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.analog1VScrollBar = New System.Windows.Forms.VScrollBar()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinaryCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WalkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RampToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort
        '
        '
        'Timer
        '
        '
        'TimerCount
        '
        '
        'BinaryButton
        '
        Me.BinaryButton.Location = New System.Drawing.Point(12, 110)
        Me.BinaryButton.Name = "BinaryButton"
        Me.BinaryButton.Size = New System.Drawing.Size(75, 23)
        Me.BinaryButton.TabIndex = 1
        Me.BinaryButton.Text = "Binary Count"
        Me.ToolTip.SetToolTip(Me.BinaryButton, "Counts in binary to 255 then resets")
        Me.BinaryButton.UseVisualStyleBackColor = True
        '
        'WalkButton
        '
        Me.WalkButton.Location = New System.Drawing.Point(12, 173)
        Me.WalkButton.Name = "WalkButton"
        Me.WalkButton.Size = New System.Drawing.Size(75, 23)
        Me.WalkButton.TabIndex = 2
        Me.WalkButton.Text = "Walk"
        Me.ToolTip.SetToolTip(Me.WalkButton, "Walk one bit at a time")
        Me.WalkButton.UseVisualStyleBackColor = True
        '
        'RampButton
        '
        Me.RampButton.Location = New System.Drawing.Point(12, 47)
        Me.RampButton.Name = "RampButton"
        Me.RampButton.Size = New System.Drawing.Size(75, 23)
        Me.RampButton.TabIndex = 0
        Me.RampButton.Text = "Ramp Dac2"
        Me.ToolTip.SetToolTip(Me.RampButton, "Ramps voltage on Analog output 2")
        Me.RampButton.UseVisualStyleBackColor = True
        '
        'DACVolt1TextBox
        '
        Me.DACVolt1TextBox.Location = New System.Drawing.Point(145, 176)
        Me.DACVolt1TextBox.Name = "DACVolt1TextBox"
        Me.DACVolt1TextBox.Size = New System.Drawing.Size(68, 20)
        Me.DACVolt1TextBox.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.DACVolt1TextBox, "Enter value between 3 and 0")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Dac 1 Voltage"
        '
        'analog1VScrollBar
        '
        Me.analog1VScrollBar.Location = New System.Drawing.Point(161, 47)
        Me.analog1VScrollBar.Maximum = 1024
        Me.analog1VScrollBar.Name = "analog1VScrollBar"
        Me.analog1VScrollBar.Size = New System.Drawing.Size(30, 96)
        Me.analog1VScrollBar.TabIndex = 66
        Me.ToolTip.SetToolTip(Me.analog1VScrollBar, "Adjusts brightness on analog output 1")
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(225, 24)
        Me.MenuStrip.TabIndex = 67
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BinaryCountToolStripMenuItem, Me.WalkToolStripMenuItem, Me.RampToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BinaryCountToolStripMenuItem
        '
        Me.BinaryCountToolStripMenuItem.Name = "BinaryCountToolStripMenuItem"
        Me.BinaryCountToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BinaryCountToolStripMenuItem.Text = "Binary Count"
        '
        'WalkToolStripMenuItem
        '
        Me.WalkToolStripMenuItem.Name = "WalkToolStripMenuItem"
        Me.WalkToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WalkToolStripMenuItem.Text = "Walk"
        '
        'RampToolStripMenuItem
        '
        Me.RampToolStripMenuItem.Name = "RampToolStripMenuItem"
        Me.RampToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RampToolStripMenuItem.Text = "Ramp"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(142, 218)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'QyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 253)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.analog1VScrollBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DACVolt1TextBox)
        Me.Controls.Add(Me.RampButton)
        Me.Controls.Add(Me.WalkButton)
        Me.Controls.Add(Me.BinaryButton)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "QyForm"
        Me.Text = "Qy@ Board"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents Timer As Timer
    Friend WithEvents TimerCount As Timer
    Friend WithEvents BinaryButton As Button
    Friend WithEvents WalkButton As Button
    Friend WithEvents RampButton As Button
    Friend WithEvents DACVolt1TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents analog1VScrollBar As VScrollBar
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BinaryCountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WalkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RampToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ExitButton As Button
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
