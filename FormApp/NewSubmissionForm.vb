Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class NewSubmissionForm
    Private stopwatch As Stopwatch
    Private timer As Timer

    Private Sub NewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch = New Stopwatch()
        timer = New Timer()
        timer.Interval = 100 ' Update every 100 milliseconds
        AddHandler timer.Tick, AddressOf UpdateStopwatchLabel
        lblStopwatchTime.Text = "0:00:00.00"
    End Sub

    Private Sub UpdateStopwatchLabel(sender As Object, e As EventArgs)
        lblStopwatchTime.Text = String.Format("{0:hh\:mm\:ss\.ff}", stopwatch.Elapsed)
    End Sub

    Private Async Sub btnSaveSubmission_Click(sender As Object, e As EventArgs) Handles btnSaveSubmission.Click
        Await SaveSubmission()
    End Sub

    Private Async Function SaveSubmission() As Task
        Dim name = txtName.Text
        Dim email = txtEmail.Text
        Dim phone = txtPhone.Text
        Dim githubLink = txtGitHubLink.Text
        Dim stopwatchTime = lblStopwatchTime.Text

        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(phone) OrElse String.IsNullOrEmpty(githubLink) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Dim submission As New With {
            .name = name,
            .email = email,
            .phone = phone,
            .github_link = githubLink,
            .stopwatch_time = stopwatchTime
        }

        Dim json As String = JsonConvert.SerializeObject(submission)

        Using client As New HttpClient()
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission saved successfully.")
            Else
                MessageBox.Show("Error saving submission.")
            End If
        End Using
    End Function

    Private Sub NewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            SaveSubmission()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
            btnToggleStopwatch.Text = "Resume Stopwatch"
        Else
            stopwatch.Start()
            timer.Start()
            btnToggleStopwatch.Text = "Pause Stopwatch"
        End If
    End Sub



End Class
