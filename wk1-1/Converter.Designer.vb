<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Converter
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
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.FeetLabel = New System.Windows.Forms.Label()
        Me.FeetTextBox = New System.Windows.Forms.TextBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.MeterLabel = New System.Windows.Forms.Label()
        Me.MeterTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.ControlGroupBox = New System.Windows.Forms.GroupBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpPleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.ControlGroupBox.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.FeetLabel)
        Me.InputGroupBox.Controls.Add(Me.FeetTextBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(13, 48)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(165, 153)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Input"
        '
        'FeetLabel
        '
        Me.FeetLabel.AutoSize = True
        Me.FeetLabel.Location = New System.Drawing.Point(6, 44)
        Me.FeetLabel.Name = "FeetLabel"
        Me.FeetLabel.Size = New System.Drawing.Size(29, 15)
        Me.FeetLabel.TabIndex = 1
        Me.FeetLabel.Text = "Feet"
        '
        'FeetTextBox
        '
        Me.FeetTextBox.Location = New System.Drawing.Point(6, 62)
        Me.FeetTextBox.Name = "FeetTextBox"
        Me.FeetTextBox.Size = New System.Drawing.Size(153, 23)
        Me.FeetTextBox.TabIndex = 0
        Me.FeetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip.SetToolTip(Me.FeetTextBox, "Input feet to convert to meter(s)")
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.MeterLabel)
        Me.OutputGroupBox.Controls.Add(Me.MeterTextBox)
        Me.OutputGroupBox.Location = New System.Drawing.Point(210, 48)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(182, 153)
        Me.OutputGroupBox.TabIndex = 100
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Output"
        '
        'MeterLabel
        '
        Me.MeterLabel.AutoSize = True
        Me.MeterLabel.Location = New System.Drawing.Point(6, 44)
        Me.MeterLabel.Name = "MeterLabel"
        Me.MeterLabel.Size = New System.Drawing.Size(38, 15)
        Me.MeterLabel.TabIndex = 1
        Me.MeterLabel.Text = "Meter"
        '
        'MeterTextBox
        '
        Me.MeterTextBox.Location = New System.Drawing.Point(6, 62)
        Me.MeterTextBox.Name = "MeterTextBox"
        Me.MeterTextBox.ReadOnly = True
        Me.MeterTextBox.Size = New System.Drawing.Size(168, 23)
        Me.MeterTextBox.TabIndex = 100
        Me.MeterTextBox.TabStop = False
        Me.MeterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip.SetToolTip(Me.MeterTextBox, "Displays converted feet to meters")
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(20, 22)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(118, 76)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Exits program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ConvertButton
        '
        Me.ConvertButton.Location = New System.Drawing.Point(247, 22)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(113, 76)
        Me.ConvertButton.TabIndex = 2
        Me.ConvertButton.Text = "Convert"
        Me.ToolTip.SetToolTip(Me.ConvertButton, "Convert user input to meters")
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'ControlGroupBox
        '
        Me.ControlGroupBox.Controls.Add(Me.ConvertButton)
        Me.ControlGroupBox.Controls.Add(Me.ExitButton)
        Me.ControlGroupBox.Location = New System.Drawing.Point(13, 207)
        Me.ControlGroupBox.Name = "ControlGroupBox"
        Me.ControlGroupBox.Size = New System.Drawing.Size(367, 107)
        Me.ControlGroupBox.TabIndex = 100
        Me.ControlGroupBox.TabStop = False
        Me.ControlGroupBox.Text = "Controls"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpPleaseToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(392, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip1"
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
        'HelpPleaseToolStripMenuItem
        '
        Me.HelpPleaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpPleaseToolStripMenuItem.Name = "HelpPleaseToolStripMenuItem"
        Me.HelpPleaseToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.HelpPleaseToolStripMenuItem.Text = "Help...Please"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 319)
        Me.Controls.Add(Me.ControlGroupBox)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Converter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Converter Feet/Meters"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ControlGroupBox.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ConvertButton As Button
    Friend WithEvents ControlGroupBox As GroupBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents FeetLabel As Label
    Friend WithEvents FeetTextBox As TextBox
    Friend WithEvents MeterLabel As Label
    Friend WithEvents MeterTextBox As TextBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpPleaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
