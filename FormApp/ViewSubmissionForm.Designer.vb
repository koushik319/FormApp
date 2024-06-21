<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionForm
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
        btnPrevious = New Button()
        btnNext = New Button()
        txtName = New Label()
        txtEmail = New Label()
        txtPhone = New Label()
        txtGitHubLink = New Label()
        txtNameSubmission = New TextBox()
        txtEmailSubmission = New TextBox()
        txtPhoneSubmission = New TextBox()
        txtGitHubLinkSubmission = New TextBox()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(97, 341)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(94, 29)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(475, 341)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(94, 29)
        btnNext.TabIndex = 1
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.AutoSize = True
        txtName.Location = New Point(142, 61)
        txtName.Name = "txtName"
        txtName.Size = New Size(49, 20)
        txtName.TabIndex = 2
        txtName.Text = "Name"
        ' 
        ' txtEmail
        ' 
        txtEmail.AutoSize = True
        txtEmail.Location = New Point(142, 119)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(46, 20)
        txtEmail.TabIndex = 3
        txtEmail.Text = "Email"
        ' 
        ' txtPhone
        ' 
        txtPhone.AutoSize = True
        txtPhone.Location = New Point(142, 178)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(86, 20)
        txtPhone.TabIndex = 4
        txtPhone.Text = "Phone Num"
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.AutoSize = True
        txtGitHubLink.Location = New Point(142, 227)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(151, 20)
        txtGitHubLink.TabIndex = 5
        txtGitHubLink.Text = "Github Link For Task 2"
        ' 
        ' txtNameSubmission
        ' 
        txtNameSubmission.Location = New Point(303, 61)
        txtNameSubmission.Name = "txtNameSubmission"
        txtNameSubmission.ReadOnly = True
        txtNameSubmission.Size = New Size(125, 27)
        txtNameSubmission.TabIndex = 7
        ' 
        ' txtEmailSubmission
        ' 
        txtEmailSubmission.Location = New Point(303, 119)
        txtEmailSubmission.Name = "txtEmailSubmission"
        txtEmailSubmission.ReadOnly = True
        txtEmailSubmission.Size = New Size(125, 27)
        txtEmailSubmission.TabIndex = 8
        ' 
        ' txtPhoneSubmission
        ' 
        txtPhoneSubmission.Location = New Point(303, 178)
        txtPhoneSubmission.Name = "txtPhoneSubmission"
        txtPhoneSubmission.ReadOnly = True
        txtPhoneSubmission.Size = New Size(125, 27)
        txtPhoneSubmission.TabIndex = 9
        ' 
        ' txtGitHubLinkSubmission
        ' 
        txtGitHubLinkSubmission.Location = New Point(303, 227)
        txtGitHubLinkSubmission.Name = "txtGitHubLinkSubmission"
        txtGitHubLinkSubmission.ReadOnly = True
        txtGitHubLinkSubmission.Size = New Size(125, 27)
        txtGitHubLinkSubmission.TabIndex = 10
        ' 
        ' ViewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtGitHubLinkSubmission)
        Controls.Add(txtPhoneSubmission)
        Controls.Add(txtEmailSubmission)
        Controls.Add(txtNameSubmission)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Name = "ViewSubmissionForm"
        Text = "ViewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtName As Label
    Friend WithEvents txtEmail As Label
    Friend WithEvents txtPhone As Label
    Friend WithEvents txtGitHubLink As Label
    Friend WithEvents txtNameSubmission As TextBox
    Friend WithEvents txtEmailSubmission As TextBox
    Friend WithEvents txtPhoneSubmission As TextBox
    Friend WithEvents txtGitHubLinkSubmission As TextBox
End Class
