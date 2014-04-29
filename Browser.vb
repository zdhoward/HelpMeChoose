'Imports WMPLib
Public Class Browser
    Private Declare Sub Sleep Lib "kernal32" (ByVal dwMilliseconds As Long)

    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        Reinitialize()
        Main.Visible = True
        Me.Close()
    End Sub

    Private Sub LISTBOX_selection_DoubleClick(sender As Object, e As EventArgs) Handles LISTBOX_selection.DoubleClick
        OpenSelection()
    End Sub

    Private Sub LISTBOX_selection_SelectedIndexChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub BTN_reroll_Click(sender As Object, e As EventArgs) Handles BTN_reroll.Click
        'Main.oldRandomNums.Clear()
        Reinitialize()
        Main.RandomSelect()
    End Sub

    Private Sub BTN_selectAll_Click(sender As Object, e As EventArgs) Handles BTN_selectAll.Click
        For i As Integer = 0 To LISTBOX_selection.Items.Count - 1
            LISTBOX_selection.SetSelected(i, True)
            LISTBOX_folders.SetSelected(i, True)
            LISTBOX_series.SetSelected(i, True)
        Next
    End Sub

    Private Sub BTN_selectNone_Click(sender As Object, e As EventArgs) Handles BTN_selectNone.Click
        For i As Integer = 0 To LISTBOX_selection.Items.Count - 1
            LISTBOX_selection.SetSelected(i, False)
            LISTBOX_folders.SetSelected(i, False)
            LISTBOX_series.SetSelected(i, False)
        Next
    End Sub

    ' Reinitialize()
    ' This calls for every required field to be reset and readied for it's next use
    Private Sub Reinitialize()
        LISTBOX_srcDirectory.Items.Clear()
        LISTBOX_selection.Items.Clear()
        LISTBOX_folders.Items.Clear()
        LISTBOX_series.Items.Clear()
        Main.Reinitialize()
    End Sub

    Private Sub BTN_play_Click(sender As Object, e As EventArgs) Handles BTN_play.Click
        If (LISTBOX_selection.SelectedItems.Count() = 1) Then
            System.Diagnostics.Process.Start(LISTBOX_srcDirectory.Items(LISTBOX_selection.SelectedIndex))
        Else
            MsgBox(LISTBOX_selection.SelectedItems.Count.ToString())
            ' Create Playlist
            ' Play playlist

            For Each item In LISTBOX_selection.SelectedIndices
                System.Diagnostics.Process.Start(LISTBOX_srcDirectory.Items(item))
            Next
        End If
    End Sub

    Private Sub BTN_invert_Click(sender As Object, e As EventArgs) Handles BTN_invert.Click
        For i As Integer = 0 To LISTBOX_selection.Items.Count - 1
            If (LISTBOX_selection.GetSelected(i) = True) Then
                LISTBOX_selection.SetSelected(i, False)
                LISTBOX_folders.SetSelected(i, False)
                LISTBOX_series.SetSelected(i, False)
            Else
                LISTBOX_selection.SetSelected(i, True)
                LISTBOX_folders.SetSelected(i, True)
                LISTBOX_series.SetSelected(i, True)
            End If
        Next
    End Sub

    Private Sub Browser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ' Make sure if Browser is closed and Main is not intended for use again, close it down
        If (Main.Visible() = False) Then
            Main.Close()
        End If
    End Sub

    Private Sub Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim originalWidth = LISTBOX_selection.Width

        ' Resize window accordingly
        LISTBOX_selection.Height = ((LISTBOX_selection.Items.Count() + 1) * LISTBOX_selection.ItemHeight)
        LISTBOX_folders.Height = LISTBOX_selection.Height
        LISTBOX_series.Height = LISTBOX_selection.Height
        Me.Height = LISTBOX_selection.Height + 120

        ' Resize the text boxes depending on what should show
        If (Main.CHECKBOX_TV.Checked) Then
            ' Show the Series listbox
            Me.LISTBOX_series.Visible = True
            Me.LBL_series.Visible = True
            Me.LISTBOX_selection.Width = originalWidth
        Else
            'Hide the Series listbox and resize what is necessary
            Me.LISTBOX_series.Visible = False
            Me.LBL_series.Visible = False
            Me.LISTBOX_selection.Width = originalWidth + Me.LISTBOX_series.Width
        End If

        ' Position Window
        ' This is too complicated and not functioning as desired
        'Me.SetDesktopLocation((Me.Location.X - (Me.Size.Height / 2)), (Me.Location.Y - (Me.Size.Width / 2)))

        ' Set the Minimum and Maximum form sizes as the dynamically generated size
        Me.MinimumSize = New Size(Me.Width, Me.Height)
        Me.MaximumSize = New Size(Screen.PrimaryScreen.Bounds.Width, Me.Height)
    End Sub

    Private Sub LISTBOX_selection_MouseClick(sender As Object, e As MouseEventArgs) Handles LISTBOX_selection.MouseClick
        LISTBOX_folders.SelectedIndex = -1
        LISTBOX_series.SelectedIndex = -1

        For Each item In LISTBOX_selection.SelectedIndices
            LISTBOX_folders.SetSelected(item, True)
            LISTBOX_series.SetSelected(item, True)
        Next

    End Sub

    Private Sub LISTBOX_folders_DoubleClick(sender As Object, e As EventArgs) Handles LISTBOX_folders.DoubleClick
        OpenSelection()
    End Sub

    Private Sub LISTBOX_folders_MouseClick(sender As Object, e As MouseEventArgs) Handles LISTBOX_folders.MouseClick
        LISTBOX_selection.SelectedIndex = -1
        LISTBOX_series.SelectedIndex = -1

        For Each item In LISTBOX_folders.SelectedIndices
            LISTBOX_selection.SetSelected(item, True)
            LISTBOX_series.SetSelected(item, True)
        Next

    End Sub

    Private Sub LISTBOX_series_DoubleClick(sender As Object, e As EventArgs) Handles LISTBOX_series.DoubleClick
        OpenSelection()
    End Sub

    Private Sub LISTBOX_series_MouseClick(sender As Object, e As MouseEventArgs) Handles LISTBOX_series.MouseClick
        LISTBOX_folders.SelectedIndex = -1
        LISTBOX_selection.SelectedIndex = -1

        For Each item In LISTBOX_series.SelectedIndices
            LISTBOX_folders.SetSelected(item, True)
            LISTBOX_selection.SetSelected(item, True)
        Next

    End Sub

    Private Sub OpenSelection()
        If (LISTBOX_selection.SelectedIndex >= 0) Then
            System.Diagnostics.Process.Start(LISTBOX_srcDirectory.Items(LISTBOX_selection.SelectedIndex))
        Else
            MsgBox("Please make a selection first")
        End If
    End Sub
End Class