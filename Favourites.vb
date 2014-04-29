Public Class Favourites

    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        Dim FD As New FolderBrowserDialog
        FD.RootFolder = Environment.SpecialFolder.MyComputer

        Try
            If FD.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                LISTBOX_dirNames.Items.Add(FD.SelectedPath(0) + ":\ ... " + Path.GetFileName(FD.SelectedPath))
                LISTBOX_dirs.Items.Add(FD.SelectedPath)
                increaseHeight(1)
                My.Settings.LastBrowsed = FD.SelectedPath
            End If
        Catch ex As ArgumentException
            MsgBox("Dialog Box failed: " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BTN_remove_Click(sender As Object, e As EventArgs) Handles BTN_remove.Click
        If (LISTBOX_dirs.SelectedIndex >= 0) Then
            LISTBOX_dirs.Items.RemoveAt(LISTBOX_dirs.SelectedIndex)
            decreaseHeight(1)
        End If
    End Sub

    Private Sub increaseHeight(_height As Integer)
        For i As Integer = 1 To _height
            LISTBOX_dirNames.Height += LISTBOX_dirNames.ItemHeight
            Me.Height += LISTBOX_dirs.ItemHeight
        Next
    End Sub

    Private Sub decreaseHeight(_height As Integer)
        For i As Integer = 1 To _height
            LISTBOX_dirNames.Height -= LISTBOX_dirNames.ItemHeight
            Me.Height -= LISTBOX_dirs.ItemHeight
        Next
    End Sub

    Private Sub LISTBOX_dirNames_DoubleClick(sender As Object, e As EventArgs) Handles LISTBOX_dirNames.DoubleClick
        If (LISTBOX_dirNames.SelectedIndex >= 0) Then
            Main.TEXTBOX_srcDirectory.Text = LISTBOX_dirs.Items.Item(LISTBOX_dirNames.SelectedIndex)
        End If
    End Sub

    Private Sub Favourites_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Save Favourites
        Dim txtFavourites = ""
        For Each item In LISTBOX_dirs.Items
            If (item.Equals("") = False) Then
                txtFavourites += "|" + item
            End If
        Next
        My.Settings.Favourites = txtFavourites

    End Sub

    Private Sub Favourites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Favourites
        For Each fav As String In Split(My.Settings.Favourites, "|")
            If (fav.Equals("") = False) Then
                LISTBOX_dirs.Items.Add(fav)
                LISTBOX_dirNames.Items.Add(fav(0) + ":\ ... " + Path.GetFileName(fav))
                increaseHeight(1)
            End If
        Next
    End Sub
End Class