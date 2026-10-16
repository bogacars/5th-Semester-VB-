<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
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
        Me.PleaLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PleaLabel
        '
        Me.PleaLabel.AutoSize = True
        Me.PleaLabel.Location = New System.Drawing.Point(12, 40)
        Me.PleaLabel.Name = "PleaLabel"
        Me.PleaLabel.Size = New System.Drawing.Size(328, 30)
        Me.PleaLabel.TabIndex = 0
        Me.PleaLabel.Text = "Carson Bogart. Please don't try to input values not accepted, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "was not able to v" &
    "alidate inputs properly"
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 123)
        Me.Controls.Add(Me.PleaLabel)
        Me.Name = "HelpForm"
        Me.Text = "HelpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PleaLabel As Label
End Class
