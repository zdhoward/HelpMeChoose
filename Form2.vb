Public Class Form2

    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click

        Me.Close()

    End Sub

    Private Sub LISTBOX_selection_DoubleClick(sender As Object, e As EventArgs) Handles LISTBOX_selection.DoubleClick
        System.Diagnostics.Process.Start(TEXTBOX_srcDirectory.Items(LISTBOX_selection.SelectedIndex))
    End Sub

    Private Sub BTN_reroll_Click(sender As Object, e As EventArgs) Handles BTN_reroll.Click
        LISTBOX_selection.Items.Clear()
        Form1.BTN_helpMeChoose.PerformClick()
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

    Private Sub LISTBOX_selection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LISTBOX_selection.SelectedIndexChanged

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
End Class