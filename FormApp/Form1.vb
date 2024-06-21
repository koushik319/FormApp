Public Class Form1

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if Ctrl+V is pressed
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Simulate a click on the "View Submissions" button
            btnViewSubmissions.PerformClick()
        End If

        ' Check if Ctrl+N is pressed
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Simulate a click on the "Create New Submission" button
            btnCreateSubmission.PerformClick()
        End If
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ' Create an instance of the ViewSubmissionForm
        Dim viewSubmissionForm As New ViewSubmissionForm()

        ' Show the ViewSubmissionForm
        viewSubmissionForm.Show()
    End Sub



    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        ' Create an instance of NewSubmissionForm
        ' Dim newSubmissionForm As New lblStopwatchTime()'

        ' Show the form as a dialog (modal)
        NewSubmissionForm.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
