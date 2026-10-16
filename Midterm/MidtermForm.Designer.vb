<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MidtermForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ArrayListBox = New System.Windows.Forms.ListBox()
        Me.OddButton = New System.Windows.Forms.Button()
        Me.RandomButton = New System.Windows.Forms.Button()
        Me.ReadButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ControlGroupBox = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ControlGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArrayListBox
        '
        Me.ArrayListBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrayListBox.FormattingEnabled = True
        Me.ArrayListBox.Location = New System.Drawing.Point(17, 19)
        Me.ArrayListBox.Name = "ArrayListBox"
        Me.ArrayListBox.Size = New System.Drawing.Size(436, 199)
        Me.ArrayListBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.ArrayListBox, "Shows output of clicked button")
        '
        'OddButton
        '
        Me.OddButton.Location = New System.Drawing.Point(6, 17)
        Me.OddButton.Name = "OddButton"
        Me.OddButton.Size = New System.Drawing.Size(87, 44)
        Me.OddButton.TabIndex = 1
        Me.OddButton.Text = "Odd Array"
        Me.ToolTip.SetToolTip(Me.OddButton, "Loads listbox/array with odd numbers")
        Me.OddButton.UseVisualStyleBackColor = True
        '
        'RandomButton
        '
        Me.RandomButton.Location = New System.Drawing.Point(103, 19)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(84, 44)
        Me.RandomButton.TabIndex = 2
        Me.RandomButton.Text = "Random Array"
        Me.ToolTip.SetToolTip(Me.RandomButton, "Loads listbox/array with random numbers")
        Me.RandomButton.UseVisualStyleBackColor = True
        '
        'ReadButton
        '
        Me.ReadButton.Location = New System.Drawing.Point(193, 21)
        Me.ReadButton.Name = "ReadButton"
        Me.ReadButton.Size = New System.Drawing.Size(81, 42)
        Me.ReadButton.TabIndex = 3
        Me.ReadButton.Text = "Read"
        Me.ToolTip.SetToolTip(Me.ReadButton, "Reads contents of file and places it into list box")
        Me.ReadButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(280, 21)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(81, 42)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Save"
        Me.ToolTip.SetToolTip(Me.SaveButton, "Saves contents in array to file")
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(367, 19)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(86, 42)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Exits the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ControlGroupBox
        '
        Me.ControlGroupBox.Controls.Add(Me.SaveButton)
        Me.ControlGroupBox.Controls.Add(Me.ExitButton)
        Me.ControlGroupBox.Controls.Add(Me.ReadButton)
        Me.ControlGroupBox.Controls.Add(Me.OddButton)
        Me.ControlGroupBox.Controls.Add(Me.RandomButton)
        Me.ControlGroupBox.Location = New System.Drawing.Point(18, 278)
        Me.ControlGroupBox.Name = "ControlGroupBox"
        Me.ControlGroupBox.Size = New System.Drawing.Size(459, 69)
        Me.ControlGroupBox.TabIndex = 99
        Me.ControlGroupBox.TabStop = False
        Me.ControlGroupBox.Text = "Controls"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(489, 24)
        Me.MenuStrip1.TabIndex = 100
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReadToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ReadToolStripMenuItem
        '
        Me.ReadToolStripMenuItem.Name = "ReadToolStripMenuItem"
        Me.ReadToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReadToolStripMenuItem.Text = "Read"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
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
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.ArrayListBox)
        Me.OutputGroupBox.Location = New System.Drawing.Point(18, 35)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(459, 237)
        Me.OutputGroupBox.TabIndex = 101
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Output"
        '
        'MidtermForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 359)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.ControlGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MidtermForm"
        Me.Text = "Midterm Form"
        Me.ControlGroupBox.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArrayListBox As ListBox
    Friend WithEvents OddButton As Button
    Friend WithEvents RandomButton As Button
    Friend WithEvents ReadButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ControlGroupBox As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutputGroupBox As GroupBox
End Class
