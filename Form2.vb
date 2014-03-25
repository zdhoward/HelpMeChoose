Public Class Form2

    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click

        Me.Close()

    End Sub

    Private Sub LISTBOX_selection_DoubleClick(sender As Object, e As EventArgs) Handles LISTBOX_selection.DoubleClick
        System.Diagnostics.Process.Start(TEXTBOX_srcDirectory.Items(LISTBOX_selection.SelectedIndex))
    End Sub

End Class