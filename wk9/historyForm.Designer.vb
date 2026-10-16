<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historyForm
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
        Me.oscopeButton = New System.Windows.Forms.Button()
        Me.showHistoryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowOScopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mid2Label = New System.Windows.Forms.Label()
        Me.mid1Label = New System.Windows.Forms.Label()
        Me.Min1Label = New System.Windows.Forms.Label()
        Me.Max1Label = New System.Windows.Forms.Label()
        Me.Min2Label = New System.Windows.Forms.Label()
        Me.Max2Label = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'oscopeButton
        '
        Me.oscopeButton.Location = New System.Drawing.Point(12, 254)
        Me.oscopeButton.Name = "oscopeButton"
        Me.oscopeButton.Size = New System.Drawing.Size(75, 23)
        Me.oscopeButton.TabIndex = 0
        Me.oscopeButton.Text = "Oscilloscope"
        Me.ToolTip1.SetToolTip(Me.oscopeButton, "Show oscilloscope form")
        Me.oscopeButton.UseVisualStyleBackColor = True
        '
        'showHistoryButton
        '
        Me.showHistoryButton.Location = New System.Drawing.Point(12, 283)
        Me.showHistoryButton.Name = "showHistoryButton"
        Me.showHistoryButton.Size = New System.Drawing.Size(106, 23)
        Me.showHistoryButton.TabIndex = 1
        Me.showHistoryButton.Text = "Show History"
        Me.ToolTip1.SetToolTip(Me.showHistoryButton, "Display saved waveforms\")
        Me.showHistoryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(12, 312)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear file")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(917, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowOScopeToolStripMenuItem, Me.ShowHistoryToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ShowOScopeToolStripMenuItem
        '
        Me.ShowOScopeToolStripMenuItem.Name = "ShowOScopeToolStripMenuItem"
        Me.ShowOScopeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowOScopeToolStripMenuItem.Text = "Show O-Scope"
        '
        'ShowHistoryToolStripMenuItem
        '
        Me.ShowHistoryToolStripMenuItem.Name = "ShowHistoryToolStripMenuItem"
        Me.ShowHistoryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowHistoryToolStripMenuItem.Text = "Show History"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'mid2Label
        '
        Me.mid2Label.AutoSize = True
        Me.mid2Label.Location = New System.Drawing.Point(94, 190)
        Me.mid2Label.Name = "mid2Label"
        Me.mid2Label.Size = New System.Drawing.Size(24, 13)
        Me.mid2Label.TabIndex = 28
        Me.mid2Label.Text = "Mid"
        '
        'mid1Label
        '
        Me.mid1Label.AutoSize = True
        Me.mid1Label.Location = New System.Drawing.Point(46, 190)
        Me.mid1Label.Name = "mid1Label"
        Me.mid1Label.Size = New System.Drawing.Size(24, 13)
        Me.mid1Label.TabIndex = 27
        Me.mid1Label.Text = "Mid"
        '
        'Min1Label
        '
        Me.Min1Label.AutoSize = True
        Me.Min1Label.Location = New System.Drawing.Point(46, 396)
        Me.Min1Label.Name = "Min1Label"
        Me.Min1Label.Size = New System.Drawing.Size(24, 13)
        Me.Min1Label.TabIndex = 26
        Me.Min1Label.Text = "Min"
        '
        'Max1Label
        '
        Me.Max1Label.AutoSize = True
        Me.Max1Label.Location = New System.Drawing.Point(46, 43)
        Me.Max1Label.Name = "Max1Label"
        Me.Max1Label.Size = New System.Drawing.Size(27, 13)
        Me.Max1Label.TabIndex = 25
        Me.Max1Label.Text = "Max"
        '
        'Min2Label
        '
        Me.Min2Label.AutoSize = True
        Me.Min2Label.Location = New System.Drawing.Point(94, 396)
        Me.Min2Label.Name = "Min2Label"
        Me.Min2Label.Size = New System.Drawing.Size(24, 13)
        Me.Min2Label.TabIndex = 24
        Me.Min2Label.Text = "Min"
        '
        'Max2Label
        '
        Me.Max2Label.AutoSize = True
        Me.Max2Label.Location = New System.Drawing.Point(94, 43)
        Me.Max2Label.Name = "Max2Label"
        Me.Max2Label.Size = New System.Drawing.Size(27, 13)
        Me.Max2Label.TabIndex = 23
        Me.Max2Label.Text = "Max"
        '
        'historyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 450)
        Me.Controls.Add(Me.mid2Label)
        Me.Controls.Add(Me.mid1Label)
        Me.Controls.Add(Me.Min1Label)
        Me.Controls.Add(Me.Max1Label)
        Me.Controls.Add(Me.Min2Label)
        Me.Controls.Add(Me.Max2Label)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.showHistoryButton)
        Me.Controls.Add(Me.oscopeButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "historyForm"
        Me.Text = "historyForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents oscopeButton As Button
    Friend WithEvents showHistoryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowOScopeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mid2Label As Label
    Friend WithEvents mid1Label As Label
    Friend WithEvents Min1Label As Label
    Friend WithEvents Max1Label As Label
    Friend WithEvents Min2Label As Label
    Friend WithEvents Max2Label As Label
End Class
