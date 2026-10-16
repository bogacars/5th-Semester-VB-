Public Class HelpForm
    Private Sub HelpForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        CCSForm.Show()
    End Sub
End Class