Imports System.IO
Public Class Main

    Dim WildCards() As String
    Dim upperbound As Integer = 0
    Dim oldUpperbound As Integer = 0
    Dim selection As New List(Of Integer)
    Dim selectionDirs As New List(Of String)
    Dim rootFolderPath As String
    Dim parentFolder As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TEXTBOX_srcDirectory.Text = My.Settings.LastBrowsed
        NUM_results.Value = My.Settings.NoOfResults
        TEXTBOX_extensions.Text = My.Settings.FileExtensions
    End Sub

    'If Main is closed and not just hidden, exit application
    Private Sub Main_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        ' This is only a failsafe to make sure the application will completely stop as desired
        Application.Exit()
    End Sub

    Sub RecursiveSearch(ByVal sDir As String, ByVal Indent As Integer)
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
                        ' This is bad practice
                        If (folder.Contains("Season") = False) Then
                            dirName = folder
                        End If
                    Next

                    upperbound += 1
                    LISTBOX_srcDirectory.Items.Add(FI.Name)
                    LISTBOX_folders.Items.Add(dirName)
                    selectionDirs.Add(FI.ToString)
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

        For i = 0 To (NUM_results.Value - 1)
            Randomize()
            selection.Add(CInt(Math.Floor((upperbound + 1) * Rnd())))
        Next

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
            End If
        Catch ex As ArgumentException
            MsgBox("Dialog Box failed: " & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub BTN_helpMeChoose_Click(sender As Object, e As EventArgs) Handles BTN_helpMeChoose.Click
        RandomSelect()
        My.Settings.Save()

        Browser.Show()
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
            Browser.LISTBOX_selection.Items.Add(LISTBOX_srcDirectory.Items(selection.Item(i)))
            Browser.LISTBOX_folders.Items.Add(LISTBOX_folders.Items(selection(i)))
            Try
                Browser.TEXTBOX_srcDirectory.Items.Add(Chr(34) & selectionDirs.Item(selection(i)) & Chr(34))
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
        Splash.Show()
        Splash.ProgressBar.Visible = False
        Splash.LoadingTimer.Interval *= 2
    End Sub
End Class