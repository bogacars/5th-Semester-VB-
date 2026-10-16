<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrayForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GradeListBox = New System.Windows.Forms.ListBox()
        Me.AddStudentLabel = New System.Windows.Forms.Label()
        Me.AddStuButton = New System.Windows.Forms.Button()
        Me.AddStudentTextBox = New System.Windows.Forms.TextBox()
        Me.AssignmentButton = New System.Windows.Forms.Button()
        Me.AssignmentTextBox = New System.Windows.Forms.TextBox()
        Me.StudentComboBox = New System.Windows.Forms.ComboBox()
        Me.AssignmentComboBox = New System.Windows.Forms.ComboBox()
        Me.AssignmentLabel = New System.Windows.Forms.Label()
        Me.StudentComboLabel = New System.Windows.Forms.Label()
        Me.AssignmnetLabel = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GradeButton = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(518, 367)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(102, 48)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Click to exit program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GradeListBox
        '
        Me.GradeListBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeListBox.FormattingEnabled = True
        Me.GradeListBox.Location = New System.Drawing.Point(12, 25)
        Me.GradeListBox.Name = "GradeListBox"
        Me.GradeListBox.Size = New System.Drawing.Size(605, 277)
        Me.GradeListBox.TabIndex = 2
        Me.GradeListBox.TabStop = False
        Me.ToolTip.SetToolTip(Me.GradeListBox, "Output array here")
        '
        'AddStudentLabel
        '
        Me.AddStudentLabel.AutoSize = True
        Me.AddStudentLabel.Location = New System.Drawing.Point(12, 323)
        Me.AddStudentLabel.Name = "AddStudentLabel"
        Me.AddStudentLabel.Size = New System.Drawing.Size(66, 13)
        Me.AddStudentLabel.TabIndex = 7
        Me.AddStudentLabel.Text = "Add Student"
        '
        'AddStuButton
        '
        Me.AddStuButton.Location = New System.Drawing.Point(8, 365)
        Me.AddStuButton.Name = "AddStuButton"
        Me.AddStuButton.Size = New System.Drawing.Size(104, 48)
        Me.AddStuButton.TabIndex = 1
        Me.AddStuButton.Text = "Add Student"
        Me.ToolTip.SetToolTip(Me.AddStuButton, "Click to add student from input text above")
        Me.AddStuButton.UseVisualStyleBackColor = True
        '
        'AddStudentTextBox
        '
        Me.AddStudentTextBox.Location = New System.Drawing.Point(8, 339)
        Me.AddStudentTextBox.Name = "AddStudentTextBox"
        Me.AddStudentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddStudentTextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.AddStudentTextBox, "Enter student name here")
        '
        'AssignmentButton
        '
        Me.AssignmentButton.Location = New System.Drawing.Point(118, 367)
        Me.AssignmentButton.Name = "AssignmentButton"
        Me.AssignmentButton.Size = New System.Drawing.Size(102, 47)
        Me.AssignmentButton.TabIndex = 3
        Me.AssignmentButton.Text = "Assignment Add"
        Me.ToolTip.SetToolTip(Me.AssignmentButton, "Add assignment from text box above")
        Me.AssignmentButton.UseVisualStyleBackColor = True
        '
        'AssignmentTextBox
        '
        Me.AssignmentTextBox.Location = New System.Drawing.Point(118, 339)
        Me.AssignmentTextBox.Name = "AssignmentTextBox"
        Me.AssignmentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AssignmentTextBox.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.AssignmentTextBox, "Enter assignmnet to add here")
        '
        'StudentComboBox
        '
        Me.StudentComboBox.FormattingEnabled = True
        Me.StudentComboBox.Location = New System.Drawing.Point(388, 358)
        Me.StudentComboBox.Name = "StudentComboBox"
        Me.StudentComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StudentComboBox.TabIndex = 6
        '
        'AssignmentComboBox
        '
        Me.AssignmentComboBox.FormattingEnabled = True
        Me.AssignmentComboBox.Location = New System.Drawing.Point(237, 358)
        Me.AssignmentComboBox.Name = "AssignmentComboBox"
        Me.AssignmentComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AssignmentComboBox.TabIndex = 4
        '
        'AssignmentLabel
        '
        Me.AssignmentLabel.AutoSize = True
        Me.AssignmentLabel.Location = New System.Drawing.Point(115, 323)
        Me.AssignmentLabel.Name = "AssignmentLabel"
        Me.AssignmentLabel.Size = New System.Drawing.Size(83, 13)
        Me.AssignmentLabel.TabIndex = 14
        Me.AssignmentLabel.Text = "Add Assignment"
        '
        'StudentComboLabel
        '
        Me.StudentComboLabel.AutoSize = True
        Me.StudentComboLabel.Location = New System.Drawing.Point(243, 342)
        Me.StudentComboLabel.Name = "StudentComboLabel"
        Me.StudentComboLabel.Size = New System.Drawing.Size(44, 13)
        Me.StudentComboLabel.TabIndex = 15
        Me.StudentComboLabel.Text = "Student"
        '
        'AssignmnetLabel
        '
        Me.AssignmnetLabel.AutoSize = True
        Me.AssignmnetLabel.Location = New System.Drawing.Point(385, 342)
        Me.AssignmnetLabel.Name = "AssignmnetLabel"
        Me.AssignmnetLabel.Size = New System.Drawing.Size(61, 13)
        Me.AssignmnetLabel.TabIndex = 16
        Me.AssignmnetLabel.Text = "Assignment"
        '
        'GradeButton
        '
        Me.GradeButton.Location = New System.Drawing.Point(339, 392)
        Me.GradeButton.Name = "GradeButton"
        Me.GradeButton.Size = New System.Drawing.Size(75, 23)
        Me.GradeButton.TabIndex = 5
        Me.GradeButton.Text = "Grade"
        Me.ToolTip.SetToolTip(Me.GradeButton, "Grade button")
        Me.GradeButton.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(626, 24)
        Me.MenuStrip.TabIndex = 17
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
        'ArrayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 426)
        Me.Controls.Add(Me.GradeButton)
        Me.Controls.Add(Me.AssignmnetLabel)
        Me.Controls.Add(Me.StudentComboLabel)
        Me.Controls.Add(Me.AssignmentLabel)
        Me.Controls.Add(Me.AssignmentComboBox)
        Me.Controls.Add(Me.StudentComboBox)
        Me.Controls.Add(Me.AssignmentTextBox)
        Me.Controls.Add(Me.AssignmentButton)
        Me.Controls.Add(Me.AddStudentTextBox)
        Me.Controls.Add(Me.AddStuButton)
        Me.Controls.Add(Me.AddStudentLabel)
        Me.Controls.Add(Me.GradeListBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "ArrayForm"
        Me.Text = "Grade Book"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents GradeListBox As ListBox
    Friend WithEvents AddStudentLabel As Label
    Friend WithEvents AddStuButton As Button
    Friend WithEvents AddStudentTextBox As TextBox
    Friend WithEvents AssignmentButton As Button
    Friend WithEvents AssignmentTextBox As TextBox
    Friend WithEvents StudentComboBox As ComboBox
    Friend WithEvents AssignmentComboBox As ComboBox
    Friend WithEvents AssignmentLabel As Label
    Friend WithEvents StudentComboLabel As Label
    Friend WithEvents AssignmnetLabel As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents GradeButton As Button
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
