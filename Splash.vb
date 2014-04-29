Public NotInheritable Class Splash

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        Dim appVersion As Version = New Version(Application.ProductVersion)

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        'Version.Text = System.String.Format(Version.Text, appVersion.Major, appVersion.Minor, appVersion.Build, appVersion.Revision)
        'Version.Text = System.String.Format(Version.Text, Application.ProductVersion.
        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright

        ' Load Program
        LoadingTimer.Start()

    End Sub

    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        If (ProgressBar.Value < ProgressBar.Maximum) Then
            ProgressBar.PerformStep()
        ElseIf (ProgressBar.Value >= ProgressBar.Maximum) Then
            LoadMain.Start()
        End If

    End Sub

    Private Sub LoadMain_Tick(sender As Object, e As EventArgs) Handles LoadMain.Tick
        Main.Show()
        Me.Close()
        LoadMain.Stop()
    End Sub
End Class
