<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewSubmissionForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtName = New TextBox()
        txtGitHubLink = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        btnSaveSubmission = New Button()
        Label6 = New Label()
        btnToggleStopwatch = New Button()
        lblStopwatchTime = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(225, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(225, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(225, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 2
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(225, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 20)
        Label4.TabIndex = 3
        Label4.Text = "Github Link for Task 2"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(390, 52)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 4
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(390, 209)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(125, 27)
        txtGitHubLink.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(390, 156)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(125, 27)
        txtPhone.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(390, 109)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 7
        ' 
        ' btnSaveSubmission
        ' 
        btnSaveSubmission.Location = New Point(244, 341)
        btnSaveSubmission.Name = "btnSaveSubmission"
        btnSaveSubmission.Size = New Size(239, 29)
        btnSaveSubmission.TabIndex = 10
        btnSaveSubmission.Text = "Save Submission (CTRL + S)"
        btnSaveSubmission.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(182, 312)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 20)
        Label6.TabIndex = 12
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Location = New Point(124, 268)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(250, 29)
        btnToggleStopwatch.TabIndex = 13
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T )"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(409, 277)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(74, 20)
        lblStopwatchTime.TabIndex = 14
        lblStopwatchTime.Text = "0:00:00.00"
        ' 
        ' NewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStopwatchTime)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(Label6)
        Controls.Add(btnSaveSubmission)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "NewSubmissionForm"
        Text = "NewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSaveSubmission As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblStopwatchTime As Label
End Class
