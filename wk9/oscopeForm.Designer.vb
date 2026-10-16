<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class oscopeForm
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
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.mid2Label = New System.Windows.Forms.Label()
        Me.mid1Label = New System.Windows.Forms.Label()
        Me.Min1Label = New System.Windows.Forms.Label()
        Me.Max1Label = New System.Windows.Forms.Label()
        Me.volt1Label = New System.Windows.Forms.Label()
        Me.volt2Label = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Min2Label = New System.Windows.Forms.Label()
        Me.Max2Label = New System.Windows.Forms.Label()
        Me.sampleTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.saveRateTextBox = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.LabelSample = New System.Windows.Forms.Label()
        Me.CH1Label = New System.Windows.Forms.Label()
        Me.CH2Label = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(12, 242)
        Me.HScrollBar1.Maximum = 5000
        Me.HScrollBar1.Minimum = 300
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(75, 25)
        Me.HScrollBar1.SmallChange = 10
        Me.HScrollBar1.TabIndex = 23
        Me.HScrollBar1.Value = 300
        '
        'mid2Label
        '
        Me.mid2Label.AutoSize = True
        Me.mid2Label.Location = New System.Drawing.Point(187, 190)
        Me.mid2Label.Name = "mid2Label"
        Me.mid2Label.Size = New System.Drawing.Size(24, 13)
        Me.mid2Label.TabIndex = 22
        Me.mid2Label.Text = "Mid"
        '
        'mid1Label
        '
        Me.mid1Label.AutoSize = True
        Me.mid1Label.Location = New System.Drawing.Point(139, 190)
        Me.mid1Label.Name = "mid1Label"
        Me.mid1Label.Size = New System.Drawing.Size(24, 13)
        Me.mid1Label.TabIndex = 21
        Me.mid1Label.Text = "Mid"
        '
        'Min1Label
        '
        Me.Min1Label.AutoSize = True
        Me.Min1Label.Location = New System.Drawing.Point(139, 396)
        Me.Min1Label.Name = "Min1Label"
        Me.Min1Label.Size = New System.Drawing.Size(24, 13)
        Me.Min1Label.TabIndex = 20
        Me.Min1Label.Text = "Min"
        '
        'Max1Label
        '
        Me.Max1Label.AutoSize = True
        Me.Max1Label.Location = New System.Drawing.Point(139, 43)
        Me.Max1Label.Name = "Max1Label"
        Me.Max1Label.Size = New System.Drawing.Size(27, 13)
        Me.Max1Label.TabIndex = 19
        Me.Max1Label.Text = "Max"
        '
        'volt1Label
        '
        Me.volt1Label.AutoSize = True
        Me.volt1Label.Location = New System.Drawing.Point(43, 64)
        Me.volt1Label.Name = "volt1Label"
        Me.volt1Label.Size = New System.Drawing.Size(31, 13)
        Me.volt1Label.TabIndex = 18
        Me.volt1Label.Text = "Volt1"
        '
        'volt2Label
        '
        Me.volt2Label.AutoSize = True
        Me.volt2Label.Location = New System.Drawing.Point(43, 95)
        Me.volt2Label.Name = "volt2Label"
        Me.volt2Label.Size = New System.Drawing.Size(34, 13)
        Me.volt2Label.TabIndex = 17
        Me.volt2Label.Text = "Volt 2"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(12, 415)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 16
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Min2Label
        '
        Me.Min2Label.AutoSize = True
        Me.Min2Label.Location = New System.Drawing.Point(187, 396)
        Me.Min2Label.Name = "Min2Label"
        Me.Min2Label.Size = New System.Drawing.Size(24, 13)
        Me.Min2Label.TabIndex = 15
        Me.Min2Label.Text = "Min"
        '
        'Max2Label
        '
        Me.Max2Label.AutoSize = True
        Me.Max2Label.Location = New System.Drawing.Point(187, 43)
        Me.Max2Label.Name = "Max2Label"
        Me.Max2Label.Size = New System.Drawing.Size(27, 13)
        Me.Max2Label.TabIndex = 14
        Me.Max2Label.Text = "Max"
        '
        'sampleTextBox
        '
        Me.sampleTextBox.Location = New System.Drawing.Point(12, 210)
        Me.sampleTextBox.Name = "sampleTextBox"
        Me.sampleTextBox.Size = New System.Drawing.Size(75, 20)
        Me.sampleTextBox.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(924, 24)
        Me.MenuStrip1.TabIndex = 24
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
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'saveRateTextBox
        '
        Me.saveRateTextBox.Location = New System.Drawing.Point(12, 120)
        Me.saveRateTextBox.Name = "saveRateTextBox"
        Me.saveRateTextBox.Size = New System.Drawing.Size(75, 20)
        Me.saveRateTextBox.TabIndex = 25
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'HistoryButton
        '
        Me.HistoryButton.Location = New System.Drawing.Point(12, 386)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(75, 23)
        Me.HistoryButton.TabIndex = 26
        Me.HistoryButton.Text = "History"
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'LabelSample
        '
        Me.LabelSample.AutoSize = True
        Me.LabelSample.Location = New System.Drawing.Point(12, 190)
        Me.LabelSample.Name = "LabelSample"
        Me.LabelSample.Size = New System.Drawing.Size(42, 13)
        Me.LabelSample.TabIndex = 27
        Me.LabelSample.Text = "Sample"
        '
        'CH1Label
        '
        Me.CH1Label.AutoSize = True
        Me.CH1Label.Location = New System.Drawing.Point(9, 64)
        Me.CH1Label.Name = "CH1Label"
        Me.CH1Label.Size = New System.Drawing.Size(31, 13)
        Me.CH1Label.TabIndex = 28
        Me.CH1Label.Text = "CH1:"
        '
        'CH2Label
        '
        Me.CH2Label.AutoSize = True
        Me.CH2Label.Location = New System.Drawing.Point(9, 95)
        Me.CH2Label.Name = "CH2Label"
        Me.CH2Label.Size = New System.Drawing.Size(31, 13)
        Me.CH2Label.TabIndex = 29
        Me.CH2Label.Text = "CH2:"
        '
        'oscopeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 450)
        Me.Controls.Add(Me.CH2Label)
        Me.Controls.Add(Me.CH1Label)
        Me.Controls.Add(Me.LabelSample)
        Me.Controls.Add(Me.HistoryButton)
        Me.Controls.Add(Me.saveRateTextBox)
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
        Me.Name = "oscopeForm"
        Me.Text = "oscopeForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents mid2Label As Label
    Friend WithEvents mid1Label As Label
    Friend WithEvents Min1Label As Label
    Friend WithEvents Max1Label As Label
    Friend WithEvents volt1Label As Label
    Friend WithEvents volt2Label As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents Min2Label As Label
    Friend WithEvents Max2Label As Label
    Friend WithEvents sampleTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents saveRateTextBox As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents HistoryButton As Button
    Friend WithEvents LabelSample As Label
    Friend WithEvents CH1Label As Label
    Friend WithEvents CH2Label As Label
End Class
