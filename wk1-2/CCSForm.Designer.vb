<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CCSForm
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
        Me.PersonalGroupBox = New System.Windows.Forms.GroupBox()
        Me.CreditMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.LastLabel = New System.Windows.Forms.Label()
        Me.LastTextBox = New System.Windows.Forms.TextBox()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.CCVLabel = New System.Windows.Forms.Label()
        Me.CCVTextBox = New System.Windows.Forms.TextBox()
        Me.ExpirationMothLabel = New System.Windows.Forms.Label()
        Me.ExpirationMonthTextBox = New System.Windows.Forms.TextBox()
        Me.CreditCardNumberLabel = New System.Windows.Forms.Label()
        Me.FirstLabel = New System.Windows.Forms.Label()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.SLLabel = New System.Windows.Forms.Label()
        Me.MultiListBox = New System.Windows.Forms.ListBox()
        Me.OutGroupBox = New System.Windows.Forms.GroupBox()
        Me.SLDTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PleaseHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.OutGroupBox.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersonalGroupBox
        '
        Me.PersonalGroupBox.Controls.Add(Me.CreditMaskedTextBox)
        Me.PersonalGroupBox.Controls.Add(Me.LastLabel)
        Me.PersonalGroupBox.Controls.Add(Me.LastTextBox)
        Me.PersonalGroupBox.Controls.Add(Me.YearLabel)
        Me.PersonalGroupBox.Controls.Add(Me.YearTextBox)
        Me.PersonalGroupBox.Controls.Add(Me.CCVLabel)
        Me.PersonalGroupBox.Controls.Add(Me.CCVTextBox)
        Me.PersonalGroupBox.Controls.Add(Me.ExpirationMothLabel)
        Me.PersonalGroupBox.Controls.Add(Me.ExpirationMonthTextBox)
        Me.PersonalGroupBox.Controls.Add(Me.CreditCardNumberLabel)
        Me.PersonalGroupBox.Controls.Add(Me.FirstLabel)
        Me.PersonalGroupBox.Controls.Add(Me.FirstTextBox)
        Me.PersonalGroupBox.Location = New System.Drawing.Point(12, 27)
        Me.PersonalGroupBox.Name = "PersonalGroupBox"
        Me.PersonalGroupBox.Size = New System.Drawing.Size(260, 357)
        Me.PersonalGroupBox.TabIndex = 0
        Me.PersonalGroupBox.TabStop = False
        Me.PersonalGroupBox.Text = "Personal Information"
        '
        'CreditMaskedTextBox
        '
        Me.CreditMaskedTextBox.Location = New System.Drawing.Point(6, 149)
        Me.CreditMaskedTextBox.Mask = "0000-0000-0000-0000"
        Me.CreditMaskedTextBox.Name = "CreditMaskedTextBox"
        Me.CreditMaskedTextBox.Size = New System.Drawing.Size(129, 23)
        Me.CreditMaskedTextBox.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.CreditMaskedTextBox, "Enter credit card number")
        '
        'LastLabel
        '
        Me.LastLabel.AutoSize = True
        Me.LastLabel.Location = New System.Drawing.Point(147, 40)
        Me.LastLabel.Name = "LastLabel"
        Me.LastLabel.Size = New System.Drawing.Size(63, 15)
        Me.LastLabel.TabIndex = 12
        Me.LastLabel.Text = "Last Name"
        '
        'LastTextBox
        '
        Me.LastTextBox.Location = New System.Drawing.Point(147, 58)
        Me.LastTextBox.Name = "LastTextBox"
        Me.LastTextBox.Size = New System.Drawing.Size(107, 23)
        Me.LastTextBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.LastTextBox, "Enter last name here")
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.Location = New System.Drawing.Point(139, 205)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(85, 15)
        Me.YearLabel.TabIndex = 10
        Me.YearLabel.Text = "Expiration (YY)"
        '
        'YearTextBox
        '
        Me.YearTextBox.Location = New System.Drawing.Point(137, 222)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(77, 23)
        Me.YearTextBox.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.YearTextBox, "Enter expiration year here")
        '
        'CCVLabel
        '
        Me.CCVLabel.AutoSize = True
        Me.CCVLabel.Location = New System.Drawing.Point(6, 301)
        Me.CCVLabel.Name = "CCVLabel"
        Me.CCVLabel.Size = New System.Drawing.Size(142, 15)
        Me.CCVLabel.TabIndex = 7
        Me.CCVLabel.Text = "CCV (3 numbers on back)"
        '
        'CCVTextBox
        '
        Me.CCVTextBox.Location = New System.Drawing.Point(6, 319)
        Me.CCVTextBox.Name = "CCVTextBox"
        Me.CCVTextBox.Size = New System.Drawing.Size(77, 23)
        Me.CCVTextBox.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.CCVTextBox, "Enter 3 digit security code here")
        '
        'ExpirationMothLabel
        '
        Me.ExpirationMothLabel.AutoSize = True
        Me.ExpirationMothLabel.Location = New System.Drawing.Point(6, 204)
        Me.ExpirationMothLabel.Name = "ExpirationMothLabel"
        Me.ExpirationMothLabel.Size = New System.Drawing.Size(93, 15)
        Me.ExpirationMothLabel.TabIndex = 5
        Me.ExpirationMothLabel.Text = "Expiration (MM)"
        '
        'ExpirationMonthTextBox
        '
        Me.ExpirationMonthTextBox.Location = New System.Drawing.Point(6, 222)
        Me.ExpirationMonthTextBox.Name = "ExpirationMonthTextBox"
        Me.ExpirationMonthTextBox.Size = New System.Drawing.Size(77, 23)
        Me.ExpirationMonthTextBox.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.ExpirationMonthTextBox, "Enter expiration month here")
        '
        'CreditCardNumberLabel
        '
        Me.CreditCardNumberLabel.AutoSize = True
        Me.CreditCardNumberLabel.Location = New System.Drawing.Point(6, 118)
        Me.CreditCardNumberLabel.Name = "CreditCardNumberLabel"
        Me.CreditCardNumberLabel.Size = New System.Drawing.Size(77, 15)
        Me.CreditCardNumberLabel.TabIndex = 3
        Me.CreditCardNumberLabel.Text = "Credit Card #"
        '
        'FirstLabel
        '
        Me.FirstLabel.AutoSize = True
        Me.FirstLabel.Location = New System.Drawing.Point(6, 40)
        Me.FirstLabel.Name = "FirstLabel"
        Me.FirstLabel.Size = New System.Drawing.Size(62, 15)
        Me.FirstLabel.TabIndex = 1
        Me.FirstLabel.Text = "First name"
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(6, 58)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(119, 23)
        Me.FirstTextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.FirstTextBox, "Enter first name here")
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(145, 17)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(106, 53)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Click to exit program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(6, 17)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(99, 53)
        Me.DisplayButton.TabIndex = 6
        Me.DisplayButton.Text = "Display"
        Me.ToolTip.SetToolTip(Me.DisplayButton, "Click to display input values from personal information")
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.DisplayButton)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(365, 306)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(257, 78)
        Me.ButtonGroupBox.TabIndex = 4
        Me.ButtonGroupBox.TabStop = False
        Me.ButtonGroupBox.Text = "Controls"
        '
        'SLLabel
        '
        Me.SLLabel.AutoSize = True
        Me.SLLabel.Location = New System.Drawing.Point(6, 40)
        Me.SLLabel.Name = "SLLabel"
        Me.SLLabel.Size = New System.Drawing.Size(105, 15)
        Me.SLLabel.TabIndex = 1
        Me.SLLabel.Text = "Single Line Display"
        '
        'MultiListBox
        '
        Me.MultiListBox.FormattingEnabled = True
        Me.MultiListBox.ItemHeight = 15
        Me.MultiListBox.Location = New System.Drawing.Point(12, 161)
        Me.MultiListBox.Name = "MultiListBox"
        Me.MultiListBox.Size = New System.Drawing.Size(306, 94)
        Me.MultiListBox.TabIndex = 4
        Me.MultiListBox.TabStop = False
        '
        'OutGroupBox
        '
        Me.OutGroupBox.Controls.Add(Me.SLDTextBox)
        Me.OutGroupBox.Controls.Add(Me.MultiListBox)
        Me.OutGroupBox.Controls.Add(Me.SLLabel)
        Me.OutGroupBox.Location = New System.Drawing.Point(298, 27)
        Me.OutGroupBox.Name = "OutGroupBox"
        Me.OutGroupBox.Size = New System.Drawing.Size(324, 273)
        Me.OutGroupBox.TabIndex = 1
        Me.OutGroupBox.TabStop = False
        Me.OutGroupBox.Text = "Display"
        '
        'SLDTextBox
        '
        Me.SLDTextBox.Location = New System.Drawing.Point(9, 63)
        Me.SLDTextBox.Name = "SLDTextBox"
        Me.SLDTextBox.ReadOnly = True
        Me.SLDTextBox.Size = New System.Drawing.Size(309, 23)
        Me.SLDTextBox.TabIndex = 5
        Me.SLDTextBox.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PleaseHelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(634, 24)
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
        'PleaseHelpToolStripMenuItem
        '
        Me.PleaseHelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpFormToolStripMenuItem})
        Me.PleaseHelpToolStripMenuItem.Name = "PleaseHelpToolStripMenuItem"
        Me.PleaseHelpToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.PleaseHelpToolStripMenuItem.Text = "Please Help...."
        '
        'HelpFormToolStripMenuItem
        '
        Me.HelpFormToolStripMenuItem.Name = "HelpFormToolStripMenuItem"
        Me.HelpFormToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HelpFormToolStripMenuItem.Text = "Help form"
        '
        'CCSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 396)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.OutGroupBox)
        Me.Controls.Add(Me.PersonalGroupBox)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "CCSForm"
        Me.Text = "Credit Card Scam Form"
        Me.PersonalGroupBox.ResumeLayout(False)
        Me.PersonalGroupBox.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.OutGroupBox.ResumeLayout(False)
        Me.OutGroupBox.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PersonalGroupBox As GroupBox
    Friend WithEvents CCVLabel As Label
    Friend WithEvents CCVTextBox As TextBox
    Friend WithEvents ExpirationMothLabel As Label
    Friend WithEvents ExpirationMonthTextBox As TextBox
    Friend WithEvents CreditCardNumberLabel As Label
    Friend WithEvents FirstLabel As Label
    Friend WithEvents FirstTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents YearLabel As Label
    Friend WithEvents SLLabel As Label
    Friend WithEvents MultiListBox As ListBox
    Friend WithEvents OutGroupBox As GroupBox
    Friend WithEvents SLDTextBox As TextBox
    Friend WithEvents LastLabel As Label
    Friend WithEvents LastTextBox As TextBox
    Friend WithEvents CreditMaskedTextBox As MaskedTextBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PleaseHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpFormToolStripMenuItem As ToolStripMenuItem
End Class
