Public NotInheritable Class Splash

    Dim updateAvailable As Boolean
    Public wait As Boolean = False

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'Application title
        If My.Application.Info.Title <> vbNullString Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'MsgBox(My.Application.Deployment.CurrentVersion.Major.ToString)
        If (ApplicationDeployment.IsNetworkDeployed) Then
            Version.Text = System.String.Format(Version.Text, My.Application.Deployment.CurrentVersion.Major, My.Application.Deployment.CurrentVersion.Minor, My.Application.Deployment.CurrentVersion.Build, My.Application.Deployment.CurrentVersion.Revision)
        Else
            Version.Text = "Debugging"
        End If

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright

        ' Load Program
        If (wait) Then
            LoadingTimer.Start()
        Else
            ' LoadingTimer.Start()
            ManualUpdateCheck()
            'LoadMain.Start()

            Main.Show()
            Main.UpdateToolStripMenuItem.Enabled = updateAvailable
            Me.Close()
        End If

    End Sub

    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        If (ProgressBar.Value < ProgressBar.Maximum) Then
            ProgressBar.PerformStep()
        ElseIf (ProgressBar.Value >= ProgressBar.Maximum) Then
            LoadMain.Start()
            LoadingTimer.Stop()
        End If

        If ProgressBar.Value = ProgressBar.Maximum - (ProgressBar.Step * 20) Then
            'LoadingTimer.Stop()
            ManualUpdateCheck()
            'LoadingTimer.Start()
        End If

    End Sub

    Private Sub LoadMain_Tick(sender As Object, e As EventArgs) Handles LoadMain.Tick
        Main.Show()
        Main.UpdateToolStripMenuItem.Enabled = updateAvailable
        Me.Close()
        LoadMain.Stop()
    End Sub

    Private Sub ManualUpdateCheck()
        Dim info As UpdateCheckInfo = Nothing

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                MessageBox.Show("The new version of the application cannot be downloaded at this time. " + ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later. Error: " + dde.Message)
                Return
            Catch ioe As InvalidOperationException
                MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " & ioe.Message)
                Return
            End Try

            If (info.UpdateAvailable) Then
                updateAvailable = True
            Else
                updateAvailable = False
            End If
        End If
    End Sub
End Class