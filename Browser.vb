'Imports WMPLib
Public Class Browser
    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        Reinitialize()
        Main.Visible = True
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
        Main.RandomSelect()
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

    ' Reinitialize()
    ' This calls for every required field to be reset and readied for it's next use
    Private Sub Reinitialize()
        TEXTBOX_srcDirectory.Items.Clear()
        LISTBOX_selection.Items.Clear()
        Main.Reinitialize()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To LISTBOX_selection.Items.Count - 1
            If (LISTBOX_selection.GetSelected(i) = True) Then
                LISTBOX_selection.SetSelected(i, False)
            Else
                LISTBOX_selection.SetSelected(i, True)
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
        ' Resize window accordingly
        LISTBOX_selection.Height = ((LISTBOX_selection.Items.Count() + 1) * LISTBOX_selection.ItemHeight)
        LISTBOX_folders.Height = LISTBOX_selection.Height
        Me.Height = LISTBOX_selection.Height + 120

        ' Position Window
        ' This is too complicated and not functioning as desired
        'Me.SetDesktopLocation((Me.Location.X - (Me.Size.Height / 2)), (Me.Location.Y - (Me.Size.Width / 2)))

        ' Set the Minimum and Maximum form sizes as the dynamically generated size
        Me.MinimumSize = New Size(Me.Width, Me.Height)
        Me.MaximumSize = New Size(Screen.PrimaryScreen.Bounds.Width, Me.Height)
    End Sub

    Private Sub CreatePlaylist(ByRef media() As String, ByVal name As String)
        'create playlist
        'Dim newPlayList As WMPLib.IWMPPlaylist = wmpControl.playlistCollection.newPlaylist("soundsToPlay")
        'newPlayList.appendItem(wmpControl.newMedia("C:\Sample1.mp3"))
        'newPlayList.appendItem(wmpControl.newMedia("C:\Sample2.mp3"))
        'play the list
        'wmpControl.Visible = False
        'wmpControl.currentPlaylist = newPlayList
        'wmpControl.stretchToFit = True
        'wmpControl.Ctlcontrols.play()
    End Sub
End Class