<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StansForm))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FoodComboBox = New System.Windows.Forms.ComboBox()
        Me.FileButton = New System.Windows.Forms.Button()
        Me.GroceryLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(201, 197)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(93, 46)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Click to exit program or type ""zzz"" into combo box")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FoodComboBox
        '
        Me.FoodComboBox.FormattingEnabled = True
        Me.FoodComboBox.Location = New System.Drawing.Point(12, 56)
        Me.FoodComboBox.Name = "FoodComboBox"
        Me.FoodComboBox.Size = New System.Drawing.Size(124, 21)
        Me.FoodComboBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.FoodComboBox, "Enter a desired item or search here")
        '
        'FileButton
        '
        Me.FileButton.Location = New System.Drawing.Point(201, 145)
        Me.FileButton.Name = "FileButton"
        Me.FileButton.Size = New System.Drawing.Size(95, 46)
        Me.FileButton.TabIndex = 2
        Me.FileButton.Text = "File Select"
        Me.ToolTip.SetToolTip(Me.FileButton, "Click to select file to load items from ")
        Me.FileButton.UseVisualStyleBackColor = True
        '
        'GroceryLabel
        '
        Me.GroceryLabel.AutoSize = True
        Me.GroceryLabel.Location = New System.Drawing.Point(11, 29)
        Me.GroceryLabel.Name = "GroceryLabel"
        Me.GroceryLabel.Size = New System.Drawing.Size(125, 13)
        Me.GroceryLabel.TabIndex = 100
        Me.GroceryLabel.Text = "Carson's (Stan's) Grocery"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(201, 98)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(93, 45)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.ToolTip.SetToolTip(Me.SearchButton, "Click to search once an item in selected or input on combo box")
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(136, 64)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(0, 13)
        Me.LocationLabel.TabIndex = 50
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(306, 24)
        Me.MenuStrip.TabIndex = 101
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.SearchToolStripMenuItem, Me.FileSelectToolStripMenuItem})
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
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'FileSelectToolStripMenuItem
        '
        Me.FileSelectToolStripMenuItem.Name = "FileSelectToolStripMenuItem"
        Me.FileSelectToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FileSelectToolStripMenuItem.Text = "File Select"
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
        'StansForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 243)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.GroceryLabel)
        Me.Controls.Add(Me.FileButton)
        Me.Controls.Add(Me.FoodComboBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "StansForm"
        Me.Text = "Carson's Grocery"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As Button
    Friend WithEvents FoodComboBox As ComboBox
    Friend WithEvents FileButton As Button
    Friend WithEvents GroceryLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents LocationLabel As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileSelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
