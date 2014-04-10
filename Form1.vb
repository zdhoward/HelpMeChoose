﻿Imports System.IO
Public Class Form1

    Dim WildCards() As String
    Dim upperbound As Integer = 0
    Dim oldUpperbound As Integer = 0
    Dim selection As New List(Of Integer)
    Dim selectionDirs As New List(Of String)
    Dim rootFolderPath As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TEXTBOX_srcDirectory.Text = My.Settings.LastBrowsed
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
                    selectionDirs.Add(FI.ToString)
                End If
            Next
        Next
    End Sub

    Sub FolderSearch()

        LISTBOX_srcDirectory.Items.Clear()

        WildCards = Split(TEXTBOX_extensions.Text)

        LISTBOX_srcDirectory.Items.Add(TEXTBOX_srcDirectory)

        DirSearch(TEXTBOX_srcDirectory.Text, 0)

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
        selection.Clear()

        FolderSearch()

        upperbound = oldUpperbound
        For i = 0 To (NUM_results.Value - 1)
            Form2.LISTBOX_selection.Items.Add(LISTBOX_srcDirectory.Items(selection.Item(i)))
            Form2.TEXTBOX_srcDirectory.Items.Add(selectionDirs.Item(selection(i)))
        Next

        Form2.Show()

    End Sub

    Sub Reinitialize()
        upperbound = 0
        oldUpperbound = 0
        selection.Clear()
        selectionDirs.Clear()
    End Sub
End Class