Public Class Form2
    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        Reinitialize()
        Form1.Visible = True
        Me.Close()

    End Sub

    Private Sub LISTBOX_selection_DoubleClick(sender As Object, e As EventArgs) Handles LISTBOX_selection.DoubleClick
        If (LISTBOX_selection.SelectedIndex >= 0) Then
            System.Diagnostics.Process.Start(TEXTBOX_srcDirectory.Items(LISTBOX_selection.SelectedIndex))
        Else
            MsgBox("Please make a selection first")
        End If
    End Sub

    Private Sub BTN_reroll_Click(sender As Object, e As EventArgs) Handles BTN_reroll.Click
        Reinitialize()
        Form1.RandomSelect()

    End Sub

    Private Sub BTN_selectAll_Click(sender As Object, e As EventArgs) Handles BTN_selectAll.Click
        For i As Integer = 0 To LISTBOX_selection.Items.Count - 1
            LISTBOX_selection.SetSelected(i, True)
        Next
    End Sub

    Private Sub BTN_selectNone_Click(sender As Object, e As EventArgs) Handles BTN_selectNone.Click
        For i As Integer = 0 To LISTBOX_selection.Items.Count - 1
            LISTBOX_selection.SetSelected(i, False)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To LISTBOX_selection.Items.Count - 1
            If (LISTBOX_selection.GetSelected(i) = True) Then
                LISTBOX_selection.SetSelected(i, False)
            Else
                LISTBOX_selection.SetSelected(i, True)
            End If
        Next
    End Sub

    Private Sub Reinitialize()
        TEXTBOX_srcDirectory.Items.Clear()
        LISTBOX_selection.Items.Clear()
        Form1.Reinitialize()
    End Sub

    Private Sub BTN_play_Click(sender As Object, e As EventArgs) Handles BTN_play.Click
        For Each path In TEXTBOX_srcDirectory.Items
            startProcess(path)
        Next
    End Sub

    Private Sub LISTBOX_selection_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LISTBOX_selection.MouseDoubleClick
        If (LISTBOX_selection.SelectedIndex >= 0) Then
            startProcess(LISTBOX_selection.SelectedItem.ToString())
        Else
            MsgBox("Please make a selection first")
        End If
    End Sub

    Private Sub startProcess(path As String)
        Try
            If IO.File.Exists(path) Then
                System.Diagnostics.Process.Start(path)
            Else
                MsgBox("File does not exist")
            End If
        Catch win32Ex As System.ComponentModel.Win32Exception
            Throw win32Ex
        Catch dirNotFound As System.IO.DirectoryNotFoundException
            Throw dirNotFound
        Catch fileNotFound As System.IO.FileNotFoundException
            Throw fileNotFound
        Catch pathTooLong As System.IO.PathTooLongException
            Throw pathTooLong
        Catch ioEx As System.IO.IOException
            Throw ioEx
        Catch security As System.Security.SecurityException
            Throw security
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class