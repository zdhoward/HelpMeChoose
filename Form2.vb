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

    Private Sub Reinitialize()
        TEXTBOX_srcDirectory.Items.Clear()
        LISTBOX_selection.Items.Clear()
        Form1.Reinitialize()
    End Sub

    Private Sub BTN_play_Click(sender As Object, e As EventArgs) Handles BTN_play.Click
        If (LISTBOX_selection.SelectedItems.Count() = 1) Then
            System.Diagnostics.Process.Start(TEXTBOX_srcDirectory.Items(LISTBOX_selection.SelectedIndex))
        Else
            MsgBox(LISTBOX_selection.SelectedItems.Count.ToString())
            ' Create Playlist
            ' Play playlist
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs)
        LISTBOX_selection.Height = ((LISTBOX_selection.Items.Count + 1) * LISTBOX_selection.ItemHeight)

        'Controls
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

    Private Sub Form2_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        LISTBOX_selection.Height = ((LISTBOX_selection.Items.Count() + 1) * LISTBOX_selection.ItemHeight)
        'Me.Height += (16 * 4)
        Me.Height = LISTBOX_selection.Height + 120
    End Sub
End Class