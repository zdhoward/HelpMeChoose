Public Class Extensions

    Private Sub Extensions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim checkedExtentsions = ""
        Dim allExtentsions = ""

        For Each ext In CHECKLIST_extensions.CheckedItems
            checkedExtentsions += ext + " "
        Next

        For Each ext In CHECKLIST_extensions.Items
            allExtentsions += ext + " "
        Next

        My.Settings.FileExtensions = checkedExtentsions
        My.Settings.AllExtensions = allExtentsions

        My.Settings.Save()

        Main.TEXTBOX_extensions.Text = checkedExtentsions

    End Sub

    Private Sub Extensions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Favourites
        For Each ext As String In Split(My.Settings.AllExtensions, " ")
            If (ext <> "") Then
                CHECKLIST_extensions.Items.Add(ext)
                If (Main.TEXTBOX_extensions.Text.Contains(ext)) Then
                    CHECKLIST_extensions.SetItemChecked(CHECKLIST_extensions.Items.Count - 1, True)
                End If
                increaseHeight(1)
            End If
        Next

    End Sub

    Private Sub increaseHeight(_height As Integer)
        For i As Integer = 1 To _height
            CHECKLIST_extensions.Height += CHECKLIST_extensions.ItemHeight
            Me.Height += CHECKLIST_extensions.ItemHeight
        Next

    End Sub

    Private Sub decreaseHeight(_height As Integer)
        For i As Integer = 1 To _height
            CHECKLIST_extensions.Height -= CHECKLIST_extensions.ItemHeight
            Me.Height -= CHECKLIST_extensions.ItemHeight
        Next

    End Sub

    Private Sub BTN_remove_Click(sender As Object, e As EventArgs) Handles BTN_remove.Click
        CHECKLIST_extensions.Items.RemoveAt(CHECKLIST_extensions.SelectedIndex)
        decreaseHeight(1)

    End Sub

    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        Dim ext As String = ""
        ext = InputBox("In the format of .avi", "Add an Extension")

        If (CHECKLIST_extensions.Items.IndexOf(ext) = -1) Then
            CHECKLIST_extensions.Items.Add(ext)
            CHECKLIST_extensions.SetItemChecked(CHECKLIST_extensions.Items.Count - 1, True)
            increaseHeight(1)
        Else
            If (CHECKLIST_extensions.GetItemChecked(CHECKLIST_extensions.Items.IndexOf(ext)) = False) Then
                CHECKLIST_extensions.SetItemChecked(CHECKLIST_extensions.Items.IndexOf(ext), True)
            End If
        End If

    End Sub

    Private Sub BTN_done_Click(sender As Object, e As EventArgs) Handles BTN_done.Click
        Me.Close()

    End Sub
End Class