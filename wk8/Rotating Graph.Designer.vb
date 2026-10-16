<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.sampleTextBox = New System.Windows.Forms.TextBox()
        Me.Max2Label = New System.Windows.Forms.Label()
        Me.Min2Label = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.volt2Label = New System.Windows.Forms.Label()
        Me.volt1Label = New System.Windows.Forms.Label()
        Me.Max1Label = New System.Windows.Forms.Label()
        Me.Min1Label = New System.Windows.Forms.Label()
        Me.mid1Label = New System.Windows.Forms.Label()
        Me.mid2Label = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'sampleTextBox
        '
        Me.sampleTextBox.Location = New System.Drawing.Point(11, 239)
        Me.sampleTextBox.Name = "sampleTextBox"
        Me.sampleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.sampleTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.sampleTextBox, "Shows samples ")
        '
        'Max2Label
        '
        Me.Max2Label.AutoSize = True
        Me.Max2Label.Location = New System.Drawing.Point(60, 20)
        Me.Max2Label.Name = "Max2Label"
        Me.Max2Label.Size = New System.Drawing.Size(27, 13)
        Me.Max2Label.TabIndex = 1
        Me.Max2Label.Text = "Max"
        Me.ToolTip1.SetToolTip(Me.Max2Label, "Displays max value on channel 2")
        '
        'Min2Label
        '
        Me.Min2Label.AutoSize = True
        Me.Min2Label.Location = New System.Drawing.Point(60, 110)
        Me.Min2Label.Name = "Min2Label"
        Me.Min2Label.Size = New System.Drawing.Size(24, 13)
        Me.Min2Label.TabIndex = 2
        Me.Min2Label.Text = "Min"
        Me.ToolTip1.SetToolTip(Me.Min2Label, "Displays min value on cahnnel 2")
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(12, 290)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exits program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'volt2Label
        '
        Me.volt2Label.AutoSize = True
        Me.volt2Label.Location = New System.Drawing.Point(60, 186)
        Me.volt2Label.Name = "volt2Label"
        Me.volt2Label.Size = New System.Drawing.Size(34, 13)
        Me.volt2Label.TabIndex = 5
        Me.volt2Label.Text = "Volt 2"
        Me.ToolTip1.SetToolTip(Me.volt2Label, "Displays channel 2 voltage")
        '
        'volt1Label
        '
        Me.volt1Label.AutoSize = True
        Me.volt1Label.Location = New System.Drawing.Point(12, 186)
        Me.volt1Label.Name = "volt1Label"
        Me.volt1Label.Size = New System.Drawing.Size(31, 13)
        Me.volt1Label.TabIndex = 6
        Me.volt1Label.Text = "Volt1"
        Me.ToolTip1.SetToolTip(Me.volt1Label, "Displays channel 1 voltage")
        '
        'Max1Label
        '
        Me.Max1Label.AutoSize = True
        Me.Max1Label.Location = New System.Drawing.Point(12, 20)
        Me.Max1Label.Name = "Max1Label"
        Me.Max1Label.Size = New System.Drawing.Size(27, 13)
        Me.Max1Label.TabIndex = 7
        Me.Max1Label.Text = "Max"
        Me.ToolTip1.SetToolTip(Me.Max1Label, "Displays max value on channel 1")
        '
        'Min1Label
        '
        Me.Min1Label.AutoSize = True
        Me.Min1Label.Location = New System.Drawing.Point(12, 110)
        Me.Min1Label.Name = "Min1Label"
        Me.Min1Label.Size = New System.Drawing.Size(24, 13)
        Me.Min1Label.TabIndex = 8
        Me.Min1Label.Text = "Min"
        Me.ToolTip1.SetToolTip(Me.Min1Label, "Displays min value on channel 1")
        '
        'mid1Label
        '
        Me.mid1Label.AutoSize = True
        Me.mid1Label.Location = New System.Drawing.Point(12, 68)
        Me.mid1Label.Name = "mid1Label"
        Me.mid1Label.Size = New System.Drawing.Size(24, 13)
        Me.mid1Label.TabIndex = 9
        Me.mid1Label.Text = "Mid"
        Me.ToolTip1.SetToolTip(Me.mid1Label, "Displays mid value on channel 1")
        '
        'mid2Label
        '
        Me.mid2Label.AutoSize = True
        Me.mid2Label.Location = New System.Drawing.Point(60, 68)
        Me.mid2Label.Name = "mid2Label"
        Me.mid2Label.Size = New System.Drawing.Size(24, 13)
        Me.mid2Label.TabIndex = 10
        Me.mid2Label.Text = "Mid"
        Me.ToolTip1.SetToolTip(Me.mid2Label, "Displays mid value on channel 2")
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(11, 262)
        Me.HScrollBar1.Maximum = 500
        Me.HScrollBar1.Minimum = 50
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(100, 25)
        Me.HScrollBar1.SmallChange = 10
        Me.HScrollBar1.TabIndex = 11
        Me.HScrollBar1.Value = 100
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(435, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 325)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.mid2Label)
        Me.Controls.Add(Me.mid1Label)
        Me.Controls.Add(Me.Min1Label)
        Me.Controls.Add(Me.Max1Label)
        Me.Controls.Add(Me.volt1Label)
        Me.Controls.Add(Me.volt2Label)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Min2Label)
        Me.Controls.Add(Me.Max2Label)
        Me.Controls.Add(Me.sampleTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Graph"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents sampleTextBox As TextBox
    Friend WithEvents Max2Label As Label
    Friend WithEvents Min2Label As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents volt2Label As Label
    Friend WithEvents volt1Label As Label
    Friend WithEvents Max1Label As Label
    Friend WithEvents Min1Label As Label
    Friend WithEvents mid1Label As Label
    Friend WithEvents mid2Label As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
