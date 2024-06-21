Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ViewSubmissionForm

    Private Async Sub ViewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
    End Sub

    Private Async Function LoadSubmissions() As Task
        Try
            Using client As New HttpClient()
                Dim response = Await client.GetAsync("http://localhost:3200/read") ' Adjust the URL and index as needed
                If response.IsSuccessStatusCode Then
                    Dim jsonString = Await response.Content.ReadAsStringAsync()
                    Dim submission = JsonConvert.DeserializeObject(Of Submission)(jsonString)
                    DisplaySubmission(submission)
                Else
                    MessageBox.Show("Error loading submission.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the submission: " & ex.Message)
        End Try
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        ' Clear existing data in the form
        txtNameSubmission.Clear()
        txtEmailSubmission.Clear()
        txtPhoneSubmission.Clear()
        txtGitHubLinkSubmission.Clear()

        ' Display the submission in the form
        If submission IsNot Nothing Then
            txtNameSubmission.Text = submission.name
            txtEmailSubmission.Text = submission.email
            txtPhoneSubmission.Text = submission.phone
            txtGitHubLinkSubmission.Text = submission.github_link
        Else
            MessageBox.Show("No submission found.")
        End If
    End Sub

    ' Define the Submission class to map the JSON response
    Private Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
    End Class

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ' Handle Previous button click
        ' Add your logic to navigate to the previous submission
        MessageBox.Show("Previous button clicked.")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Handle Next button click
        ' Add your logic to navigate to the next submission
        MessageBox.Show("Next button clicked.")
    End Sub

End Class
