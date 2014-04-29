Imports System.IO
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

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TEXTBOX_srcDirectory.Text = My.Settings.LastBrowsed
        NUM_results.Value = My.Settings.NoOfResults
        TEXTBOX_extensions.Text = My.Settings.FileExtensions
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

                    upperbound += 1
                    LISTBOX_srcDirectory.Items.Add(FI.Name)
                    LISTBOX_folders.Items.Add(dirName)
                    LISTBOX_series.Items.Add(series)
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
        Splash.Show()
        Splash.ProgressBar.Visible = False
        Splash.LoadingTimer.Interval *= 2
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        MsgBox("This will update soon")
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

End Class