Public Class AboutForm
    Private Sub AboutForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ReverseForm.Show() 'when about form is closed it opens the default form
    End Sub
End Class