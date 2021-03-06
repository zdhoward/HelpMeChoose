﻿Imports System.IO
Imports System.Text.RegularExpressions

Public Class Main

    Dim WildCards() As String
    Dim upperbound As Integer = 0
    Dim oldUpperbound As Integer = 0
    Dim selection As New List(Of Integer)
    Dim selectionDirs As New List(Of String)
    Dim rootFolderPath As String
    Dim parentFolder As String
    Public oldRandomNums As New List(Of Integer)

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.LastBrowsed = TEXTBOX_srcDirectory.Text
        My.Settings.Save()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TEXTBOX_srcDirectory.Text = My.Settings.LastBrowsed
        NUM_results.Value = My.Settings.NoOfResults
        TEXTBOX_extensions.Text = My.Settings.FileExtensions
        CHECKBOX_TV.Checked = My.Settings.isTV
    End Sub

    'If Main is closed and not just hidden, exit application
    Private Sub Main_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Sub RecursiveSearch(ByVal sDir As String, ByVal Indent As Integer)
        Dim series As String = ""
        Dim dirName As String = ""

        Try
            For Each d As String In Directory.GetDirectories(sDir)
                If d Like "*.*{4}" Then
                    LISTBOX_srcDirectory.Items.Add(d)
                Else
                    RecursiveSearch(d, 0)
                End If
            Next
        Catch x As System.Exception
            LISTBOX_srcDirectory.Items.Add("**" & x.Message & "**")
        End Try
        For Each f As String In Directory.GetFiles(sDir, "*.*")
            Dim FI As FileInfo = New FileInfo(f)
            For Each wc As String In WildCards
                If FI.Name Like "*" + wc Then
                    For Each folder In Split(sDir, "\")
                        If (folder.Contains("Season") Or folder.Contains("Raw Tapes") Or folder.Contains("Extras") Or folder.Contains("Series") Or Regex.IsMatch(folder, "^[0-9 ]+$") Or Regex.IsMatch(folder, "[Ss][0-9 ]+[Ee][0-9 ]") Or Regex.IsMatch(folder, "[0-9]+[Xx][0-9]+")) Then
                            ' Filter Name
                        Else
                            series = folder
                        End If
                        dirName = folder
                    Next

                    ' Match with Regex ie. "(.avi|.AVI)$"
                    Dim rgx = "("
                    For Each ext In Split(TEXTBOX_extensions.Text)
                        If (ext <> " ") Then
                            rgx += ext.ToLower + "|" + ext.ToUpper + "|"
                        End If
                    Next
                    rgx.Remove(rgx.LastIndexOf("|"))
                    rgx = rgx.Substring(0, rgx.Length - 3)
                    rgx += ")$"

                    If (Regex.IsMatch(FI.Name, rgx)) Then
                        upperbound += 1
                        LISTBOX_srcDirectory.Items.Add(FI.Name)
                        LISTBOX_folders.Items.Add(dirName)
                        LISTBOX_series.Items.Add(series)
                        selectionDirs.Add(FI.ToString)
                    End If

                End If
            Next
        Next
    End Sub

    Sub FolderSearch()
        LISTBOX_srcDirectory.Items.Clear()

        WildCards = Split(TEXTBOX_extensions.Text)

        LISTBOX_srcDirectory.Items.Add(TEXTBOX_srcDirectory)

        RecursiveSearch(TEXTBOX_srcDirectory.Text, 0)

        LISTBOX_srcDirectory.Items.RemoveAt(0)

        GenerateRandomNumbers(NUM_results.Value - 1)

        oldUpperbound = upperbound
        upperbound = 0

    End Sub

    Private Sub BTN_srcDirectory_Click(sender As Object, e As EventArgs) Handles BTN_srcDirectory.Click
        Dim FD As New FolderBrowserDialog
        FD.RootFolder = Environment.SpecialFolder.MyComputer
        FD.SelectedPath = TEXTBOX_srcDirectory.Text

        Try
            If FD.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                TEXTBOX_srcDirectory.Text = FD.SelectedPath
                My.Settings.LastBrowsed = FD.SelectedPath
                My.Settings.Save()
            End If
        Catch ex As ArgumentException
            MsgBox("Dialog Box failed: " & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub BTN_helpMeChoose_Click(sender As Object, e As EventArgs) Handles BTN_helpMeChoose.Click
        RandomSelect()
        Browser.Show()
        Favourites.Hide()
        Extensions.Hide()
        Me.Hide()

    End Sub

    Sub Reinitialize()
        upperbound = 0
        oldUpperbound = 0
        selection.Clear()
        selectionDirs.Clear()

    End Sub

    Sub RandomSelect()
        selection.Clear()

        FolderSearch()

        upperbound = oldUpperbound
        For i = 0 To (NUM_results.Value - 1)

            Try
                Browser.LISTBOX_selection.Items.Add(LISTBOX_srcDirectory.Items(selection.Item(i)))
                Browser.LISTBOX_folders.Items.Add(LISTBOX_folders.Items(selection(i)))
                Browser.LISTBOX_series.Items.Add(LISTBOX_series.Items(selection(i)))
                Browser.LISTBOX_srcDirectory.Items.Add(Chr(34) & selectionDirs.Item(selection(i)) & Chr(34))
            Catch ex As Exception
                ' As of now this appears as "Access denied"
            End Try
        Next

        My.Settings.NoOfResults = NUM_results.Value

    End Sub

    Private Sub FavouritesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavouritesToolStripMenuItem.Click
        Favourites.Show()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("This was created by Zach Howard: http://www.ZachHoward.me")

    End Sub

    Private Sub ApplicationInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationInfoToolStripMenuItem.Click
        'Splash.ProgressBar.Visible = False
        Splash.wait = True
        Splash.Show()
        Splash.LoadingTimer.Interval *= 2

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
            InstallUpdateSyncWithInfo()
    End Sub

    Private Sub GenerateRandomNumbers(amount As Integer)
        Dim num = 0
        Dim done = False

        For i = 0 To (amount)
            ' While num does not equal oldRandomNums
            If (oldRandomNums.Contains(num)) Then
                While (oldRandomNums.Contains(num))
                    Randomize()
                    num = CInt(Math.Floor((upperbound + 1) * Rnd()))
                End While
            Else
                Randomize()
                num = CInt(Math.Floor((upperbound + 1) * Rnd()))
            End If

            selection.Add(num)
            oldRandomNums.Add(num)

        Next
    End Sub

    Private Sub ExtensionMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtensionMenuToolStripMenuItem.Click
        Extensions.Show()
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
                UpdateToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub InstallUpdateSyncWithInfo()
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
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Dim dr As DialogResult = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MessageBox.Show("This application has detected a mandatory update from your current " & _
                        "version to version " & info.MinimumRequiredVersion.ToString() & _
                        ". The application will now install the update and restart.", _
                        "Update Available", MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
                End If

                If (doUpdate) Then
                    Try
                        AD.Update()
                        'MessageBox.Show("The application has been upgraded, and will now restart.")
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        MessageBox.Show("Cannot install the latest version of the application. " & ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later.")
                        Return
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub CHECKBOX_TV_CheckedChanged(sender As Object, e As EventArgs) Handles CHECKBOX_TV.CheckedChanged
        My.Settings.isTV = CHECKBOX_TV.Checked
        My.Settings.Save()

    End Sub
End Class