<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RLCircuit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RLCircuit))
        Me.OutputListBox = New System.Windows.Forms.ListBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ResistorTextBox = New System.Windows.Forms.TextBox()
        Me.InductorTextBox = New System.Windows.Forms.TextBox()
        Me.VinTextBox = New System.Windows.Forms.TextBox()
        Me.ResistorLabel = New System.Windows.Forms.Label()
        Me.InductorLabel = New System.Windows.Forms.Label()
        Me.VinLabel = New System.Windows.Forms.Label()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ILabel = New System.Windows.Forms.Label()
        Me.RLabel = New System.Windows.Forms.Label()
        Me.ClearListButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ControlGroupBox = New System.Windows.Forms.GroupBox()
        Me.VLabel = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.InductVoltLabel = New System.Windows.Forms.Label()
        Me.RVLabel = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutputGroupBox.SuspendLayout()
        Me.InputGroupBox.SuspendLayout()
        Me.ControlGroupBox.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'OutputListBox
        '
        Me.OutputListBox.FormattingEnabled = True
        Me.OutputListBox.Location = New System.Drawing.Point(9, 31)
        Me.OutputListBox.Name = "OutputListBox"
        Me.OutputListBox.Size = New System.Drawing.Size(462, 160)
        Me.OutputListBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.OutputListBox, "Outputs the time voltage of the resistor and inductor")
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(125, 14)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(101, 46)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ToolTip.SetToolTip(Me.ClearButton, "Clears the text boxes ")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(6, 14)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(100, 46)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "Calculate"
        Me.ToolTip.SetToolTip(Me.CalculateButton, "Click to calculate the input values")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ResistorTextBox
        '
        Me.ResistorTextBox.Location = New System.Drawing.Point(16, 48)
        Me.ResistorTextBox.Name = "ResistorTextBox"
        Me.ResistorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ResistorTextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.ResistorTextBox, "Insert Resistor value in ohms here")
        '
        'InductorTextBox
        '
        Me.InductorTextBox.Location = New System.Drawing.Point(188, 48)
        Me.InductorTextBox.Name = "InductorTextBox"
        Me.InductorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InductorTextBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.InductorTextBox, "Insert inductor value in Henry's here")
        '
        'VinTextBox
        '
        Me.VinTextBox.Location = New System.Drawing.Point(351, 48)
        Me.VinTextBox.Name = "VinTextBox"
        Me.VinTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VinTextBox.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.VinTextBox, "Enter Vin value in volts here")
        '
        'ResistorLabel
        '
        Me.ResistorLabel.AutoSize = True
        Me.ResistorLabel.Location = New System.Drawing.Point(13, 28)
        Me.ResistorLabel.Name = "ResistorLabel"
        Me.ResistorLabel.Size = New System.Drawing.Size(75, 13)
        Me.ResistorLabel.TabIndex = 6
        Me.ResistorLabel.Text = "Resistor Value"
        '
        'InductorLabel
        '
        Me.InductorLabel.AutoSize = True
        Me.InductorLabel.Location = New System.Drawing.Point(185, 28)
        Me.InductorLabel.Name = "InductorLabel"
        Me.InductorLabel.Size = New System.Drawing.Size(76, 13)
        Me.InductorLabel.TabIndex = 7
        Me.InductorLabel.Text = "Inductor Value"
        '
        'VinLabel
        '
        Me.VinLabel.AutoSize = True
        Me.VinLabel.Location = New System.Drawing.Point(348, 28)
        Me.VinLabel.Name = "VinLabel"
        Me.VinLabel.Size = New System.Drawing.Size(22, 13)
        Me.VinLabel.TabIndex = 8
        Me.VinLabel.Text = "Vin"
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.RVLabel)
        Me.OutputGroupBox.Controls.Add(Me.InductVoltLabel)
        Me.OutputGroupBox.Controls.Add(Me.TimeLabel)
        Me.OutputGroupBox.Controls.Add(Me.OutputListBox)
        Me.OutputGroupBox.Location = New System.Drawing.Point(12, 106)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(486, 207)
        Me.OutputGroupBox.TabIndex = 9
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Output"
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.VLabel)
        Me.InputGroupBox.Controls.Add(Me.ILabel)
        Me.InputGroupBox.Controls.Add(Me.RLabel)
        Me.InputGroupBox.Controls.Add(Me.VinLabel)
        Me.InputGroupBox.Controls.Add(Me.InductorLabel)
        Me.InputGroupBox.Controls.Add(Me.ResistorLabel)
        Me.InputGroupBox.Controls.Add(Me.VinTextBox)
        Me.InputGroupBox.Controls.Add(Me.InductorTextBox)
        Me.InputGroupBox.Controls.Add(Me.ResistorTextBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 26)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(486, 74)
        Me.InputGroupBox.TabIndex = 10
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Input"
        '
        'ILabel
        '
        Me.ILabel.AutoSize = True
        Me.ILabel.Location = New System.Drawing.Point(294, 51)
        Me.ILabel.Name = "ILabel"
        Me.ILabel.Size = New System.Drawing.Size(15, 13)
        Me.ILabel.TabIndex = 10
        Me.ILabel.Text = "H"
        '
        'RLabel
        '
        Me.RLabel.AutoSize = True
        Me.RLabel.Location = New System.Drawing.Point(122, 51)
        Me.RLabel.Name = "RLabel"
        Me.RLabel.Size = New System.Drawing.Size(34, 13)
        Me.RLabel.TabIndex = 9
        Me.RLabel.Text = "Ohms"
        '
        'ClearListButton
        '
        Me.ClearListButton.Location = New System.Drawing.Point(252, 14)
        Me.ClearListButton.Name = "ClearListButton"
        Me.ClearListButton.Size = New System.Drawing.Size(92, 46)
        Me.ClearListButton.TabIndex = 5
        Me.ClearListButton.Text = "Clear List"
        Me.ToolTip.SetToolTip(Me.ClearListButton, "Clears the output list box")
        Me.ClearListButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(376, 14)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(102, 46)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Exits the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ControlGroupBox
        '
        Me.ControlGroupBox.Controls.Add(Me.ClearListButton)
        Me.ControlGroupBox.Controls.Add(Me.ExitButton)
        Me.ControlGroupBox.Controls.Add(Me.CalculateButton)
        Me.ControlGroupBox.Controls.Add(Me.ClearButton)
        Me.ControlGroupBox.Location = New System.Drawing.Point(12, 319)
        Me.ControlGroupBox.Name = "ControlGroupBox"
        Me.ControlGroupBox.Size = New System.Drawing.Size(486, 74)
        Me.ControlGroupBox.TabIndex = 13
        Me.ControlGroupBox.TabStop = False
        Me.ControlGroupBox.Text = "Controls"
        '
        'VLabel
        '
        Me.VLabel.AutoSize = True
        Me.VLabel.Location = New System.Drawing.Point(457, 51)
        Me.VLabel.Name = "VLabel"
        Me.VLabel.Size = New System.Drawing.Size(14, 13)
        Me.VLabel.TabIndex = 11
        Me.VLabel.Text = "V"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(31, 16)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(30, 13)
        Me.TimeLabel.TabIndex = 1
        Me.TimeLabel.Text = "Time"
        '
        'InductVoltLabel
        '
        Me.InductVoltLabel.AutoSize = True
        Me.InductVoltLabel.Location = New System.Drawing.Point(203, 16)
        Me.InductVoltLabel.Name = "InductVoltLabel"
        Me.InductVoltLabel.Size = New System.Drawing.Size(85, 13)
        Me.InductVoltLabel.TabIndex = 2
        Me.InductVoltLabel.Text = "Inductor Voltage"
        '
        'RVLabel
        '
        Me.RVLabel.AutoSize = True
        Me.RVLabel.Location = New System.Drawing.Point(102, 15)
        Me.RVLabel.Name = "RVLabel"
        Me.RVLabel.Size = New System.Drawing.Size(84, 13)
        Me.RVLabel.TabIndex = 3
        Me.RVLabel.Text = "Resistor Voltage"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(503, 24)
        Me.MenuStrip.TabIndex = 14
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ClearListToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
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
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ClearListToolStripMenuItem
        '
        Me.ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem"
        Me.ClearListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearListToolStripMenuItem.Text = "Clear List"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RLCircuit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 399)
        Me.Controls.Add(Me.ControlGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "RLCircuit"
        Me.Text = "RL Circuit"
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.ControlGroupBox.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OutputListBox As ListBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ResistorTextBox As TextBox
    Friend WithEvents InductorTextBox As TextBox
    Friend WithEvents VinTextBox As TextBox
    Friend WithEvents ResistorLabel As Label
    Friend WithEvents InductorLabel As Label
    Friend WithEvents VinLabel As Label
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents ClearListButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ControlGroupBox As GroupBox
    Friend WithEvents ILabel As Label
    Friend WithEvents RLabel As Label
    Friend WithEvents VLabel As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents TimeLabel As Label
    Friend WithEvents InductVoltLabel As Label
    Friend WithEvents RVLabel As Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
