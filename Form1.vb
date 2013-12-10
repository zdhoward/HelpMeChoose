Imports System.IO
Public Class Form1

    Dim WildCards() As String
    Dim upperbound As Integer = 0
    Dim oldUpperbound As Integer = 0
    Dim selection As New List(Of Integer)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub DirSearch(ByVal sDir As String, ByVal Indent As Integer)
        Try
            For Each d As String In Directory.GetDirectories(sDir)
                If d Like "*.*{4}" Then
                    LISTBOX_srcDirectory.Items.Add(d)
                Else
                    DirSearch(d, 0)
                End If
            Next
        Catch x As System.Exception
            LISTBOX_srcDirectory.Items.Add("**" & x.Message & "**")
        End Try
        For Each f As String In Directory.GetFiles(sDir, "*.*")
            Dim FI As FileInfo = New FileInfo(f)
            For Each wc As String In WildCards
                If FI.Name Like "*" + wc Then
                    upperbound += 1
                    LISTBOX_srcDirectory.Items.Add(FI.Name)
                End If
            Next
        Next
    End Sub

    Sub FolderSearch()

        LISTBOX_srcDirectory.Items.Clear()

        WildCards = Split(TEXTBOX_extensions.Text)

        Dim FD As New FolderBrowserDialog
        If FD.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TEXTBOX_srcDirectory.Text = FD.SelectedPath
            LISTBOX_srcDirectory.Items.Add(TEXTBOX_srcDirectory)
            DirSearch(TEXTBOX_srcDirectory.Text, 0)
        End If

        LISTBOX_srcDirectory.Items.RemoveAt(0)

        Dim selection = New List(Of Integer)
        For i = 0 To (NUM_results.Value - 1)
            selection.Add(CInt(Math.Floor((upperbound + 1) * Rnd())))
            LISTBOX_srcDirectory.Items.Add(CInt(Math.Floor((upperbound + 1) * Rnd())))
        Next
        LISTBOX_srcDirectory.Items.Add(upperbound)
        oldUpperbound = upperbound
        upperbound = 0

    End Sub

    Private Sub BTN_srcDirectory_Click(sender As Object, e As EventArgs) Handles BTN_srcDirectory.Click

        FolderSearch()

    End Sub

    Private Sub BTN_helpMeChoose_Click(sender As Object, e As EventArgs) Handles BTN_helpMeChoose.Click
        upperbound = oldUpperbound
        For i = 0 To (NUM_results.Value - 1)
            Form2.LISTBOX_selection.Items.Add(i)
        Next

        Form2.Show()

    End Sub
End Class
