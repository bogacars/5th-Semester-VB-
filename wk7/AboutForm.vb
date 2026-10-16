Public Class AboutForm
    Private Sub AboutForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        RollTheDice.Show() 'show original form
    End Sub
End Class