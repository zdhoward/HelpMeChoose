<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.LISTBOX_selection = New System.Windows.Forms.ListBox()
        Me.BTN_reroll = New System.Windows.Forms.Button()
        Me.BTN_back = New System.Windows.Forms.Button()
        Me.BTN_selectAll = New System.Windows.Forms.Button()
        Me.BTN_selectNone = New System.Windows.Forms.Button()
        Me.LISTBOX_srcDirectory = New System.Windows.Forms.ListBox()
        Me.BTN_invert = New System.Windows.Forms.Button()
        Me.BTN_addPlaylist = New System.Windows.Forms.Button()
        Me.BTN_exportFiles = New System.Windows.Forms.Button()
        Me.BTN_play = New System.Windows.Forms.Button()
        Me.LISTBOX_folders = New System.Windows.Forms.ListBox()
        Me.LISTBOX_series = New System.Windows.Forms.ListBox()
        Me.LBL_file = New System.Windows.Forms.Label()
        Me.LBL_series = New System.Windows.Forms.Label()
        Me.LBL_folder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LISTBOX_selection
        '
        Me.LISTBOX_selection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LISTBOX_selection.FormattingEnabled = True
        Me.LISTBOX_selection.Location = New System.Drawing.Point(12, 19)
        Me.LISTBOX_selection.Name = "LISTBOX_selection"
        Me.LISTBOX_selection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LISTBOX_selection.Size = New System.Drawing.Size(202, 17)
        Me.LISTBOX_selection.TabIndex = 0
        '
        'BTN_reroll
        '
        Me.BTN_reroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_reroll.Location = New System.Drawing.Point(341, 76)
        Me.BTN_reroll.Name = "BTN_reroll"
        Me.BTN_reroll.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reroll.TabIndex = 1
        Me.BTN_reroll.Text = "Roll Again!"
        Me.BTN_reroll.UseVisualStyleBackColor = True
        '
        'BTN_back
        '
        Me.BTN_back.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_back.Location = New System.Drawing.Point(12, 76)
        Me.BTN_back.Name = "BTN_back"
        Me.BTN_back.Size = New System.Drawing.Size(75, 23)
        Me.BTN_back.TabIndex = 2
        Me.BTN_back.Text = "< Back"
        Me.BTN_back.UseVisualStyleBackColor = True
        '
        'BTN_selectAll
        '
        Me.BTN_selectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_selectAll.Location = New System.Drawing.Point(260, 47)
        Me.BTN_selectAll.Name = "BTN_selectAll"
        Me.BTN_selectAll.Size = New System.Drawing.Size(75, 23)
        Me.BTN_selectAll.TabIndex = 3
        Me.BTN_selectAll.Text = "Select All"
        Me.BTN_selectAll.UseVisualStyleBackColor = True
        '
        'BTN_selectNone
        '
        Me.BTN_selectNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_selectNone.Location = New System.Drawing.Point(341, 47)
        Me.BTN_selectNone.Name = "BTN_selectNone"
        Me.BTN_selectNone.Size = New System.Drawing.Size(75, 23)
        Me.BTN_selectNone.TabIndex = 4
        Me.BTN_selectNone.Text = "Select None"
        Me.BTN_selectNone.UseVisualStyleBackColor = True
        '
        'LISTBOX_srcDirectory
        '
        Me.LISTBOX_srcDirectory.Enabled = False
        Me.LISTBOX_srcDirectory.FormattingEnabled = True
        Me.LISTBOX_srcDirectory.Location = New System.Drawing.Point(12, 19)
        Me.LISTBOX_srcDirectory.Name = "LISTBOX_srcDirectory"
        Me.LISTBOX_srcDirectory.Size = New System.Drawing.Size(121, 17)
        Me.LISTBOX_srcDirectory.TabIndex = 5
        Me.LISTBOX_srcDirectory.Visible = False
        '
        'BTN_invert
        '
        Me.BTN_invert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_invert.Location = New System.Drawing.Point(12, 47)
        Me.BTN_invert.Name = "BTN_invert"
        Me.BTN_invert.Size = New System.Drawing.Size(90, 23)
        Me.BTN_invert.TabIndex = 6
        Me.BTN_invert.Text = "Invert Selection"
        Me.BTN_invert.UseVisualStyleBackColor = True
        '
        'BTN_addPlaylist
        '
        Me.BTN_addPlaylist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_addPlaylist.Location = New System.Drawing.Point(423, 47)
        Me.BTN_addPlaylist.Name = "BTN_addPlaylist"
        Me.BTN_addPlaylist.Size = New System.Drawing.Size(90, 23)
        Me.BTN_addPlaylist.TabIndex = 7
        Me.BTN_addPlaylist.Text = "Add To Playlist"
        Me.BTN_addPlaylist.UseVisualStyleBackColor = True
        '
        'BTN_exportFiles
        '
        Me.BTN_exportFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_exportFiles.Location = New System.Drawing.Point(423, 13)
        Me.BTN_exportFiles.Name = "BTN_exportFiles"
        Me.BTN_exportFiles.Size = New System.Drawing.Size(90, 23)
        Me.BTN_exportFiles.TabIndex = 8
        Me.BTN_exportFiles.Text = "Export Files.."
        Me.BTN_exportFiles.UseVisualStyleBackColor = True
        '
        'BTN_play
        '
        Me.BTN_play.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_play.Location = New System.Drawing.Point(422, 76)
        Me.BTN_play.Name = "BTN_play"
        Me.BTN_play.Size = New System.Drawing.Size(90, 23)
        Me.BTN_play.TabIndex = 9
        Me.BTN_play.Text = "Play"
        Me.BTN_play.UseVisualStyleBackColor = True
        '
        'LISTBOX_folders
        '
        Me.LISTBOX_folders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LISTBOX_folders.FormattingEnabled = True
        Me.LISTBOX_folders.Location = New System.Drawing.Point(315, 19)
        Me.LISTBOX_folders.Name = "LISTBOX_folders"
        Me.LISTBOX_folders.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LISTBOX_folders.Size = New System.Drawing.Size(101, 17)
        Me.LISTBOX_folders.TabIndex = 10
        '
        'LISTBOX_series
        '
        Me.LISTBOX_series.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LISTBOX_series.FormattingEnabled = True
        Me.LISTBOX_series.Location = New System.Drawing.Point(214, 19)
        Me.LISTBOX_series.Name = "LISTBOX_series"
        Me.LISTBOX_series.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LISTBOX_series.Size = New System.Drawing.Size(101, 17)
        Me.LISTBOX_series.TabIndex = 11
        '
        'LBL_file
        '
        Me.LBL_file.AutoSize = True
        Me.LBL_file.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_file.Location = New System.Drawing.Point(12, 3)
        Me.LBL_file.Name = "LBL_file"
        Me.LBL_file.Size = New System.Drawing.Size(27, 13)
        Me.LBL_file.TabIndex = 12
        Me.LBL_file.Text = "File"
        '
        'LBL_series
        '
        Me.LBL_series.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_series.AutoSize = True
        Me.LBL_series.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_series.Location = New System.Drawing.Point(211, 3)
        Me.LBL_series.Name = "LBL_series"
        Me.LBL_series.Size = New System.Drawing.Size(42, 13)
        Me.LBL_series.TabIndex = 13
        Me.LBL_series.Text = "Series"
        '
        'LBL_folder
        '
        Me.LBL_folder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_folder.AutoSize = True
        Me.LBL_folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_folder.Location = New System.Drawing.Point(312, 3)
        Me.LBL_folder.Name = "LBL_folder"
        Me.LBL_folder.Size = New System.Drawing.Size(42, 13)
        Me.LBL_folder.TabIndex = 14
        Me.LBL_folder.Text = "Folder"
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 111)
        Me.Controls.Add(Me.LBL_folder)
        Me.Controls.Add(Me.LBL_series)
        Me.Controls.Add(Me.LBL_file)
        Me.Controls.Add(Me.LISTBOX_series)
        Me.Controls.Add(Me.LISTBOX_folders)
        Me.Controls.Add(Me.BTN_play)
        Me.Controls.Add(Me.BTN_exportFiles)
        Me.Controls.Add(Me.BTN_addPlaylist)
        Me.Controls.Add(Me.BTN_invert)
        Me.Controls.Add(Me.BTN_selectNone)
        Me.Controls.Add(Me.BTN_selectAll)
        Me.Controls.Add(Me.BTN_back)
        Me.Controls.Add(Me.BTN_reroll)
        Me.Controls.Add(Me.LISTBOX_srcDirectory)
        Me.Controls.Add(Me.LISTBOX_selection)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(404, 38)
        Me.Name = "Browser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HelpMeChoose!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LISTBOX_selection As System.Windows.Forms.ListBox
    Friend WithEvents BTN_reroll As System.Windows.Forms.Button
    Friend WithEvents BTN_back As System.Windows.Forms.Button
    Friend WithEvents BTN_selectAll As System.Windows.Forms.Button
    Friend WithEvents BTN_selectNone As System.Windows.Forms.Button
    Friend WithEvents LISTBOX_srcDirectory As System.Windows.Forms.ListBox
    Friend WithEvents BTN_invert As System.Windows.Forms.Button
    Friend WithEvents BTN_addPlaylist As System.Windows.Forms.Button
    Friend WithEvents BTN_exportFiles As System.Windows.Forms.Button
    Friend WithEvents BTN_play As System.Windows.Forms.Button
    Friend WithEvents LISTBOX_folders As System.Windows.Forms.ListBox
    Friend WithEvents LISTBOX_series As System.Windows.Forms.ListBox
    Friend WithEvents LBL_file As System.Windows.Forms.Label
    Friend WithEvents LBL_series As System.Windows.Forms.Label
    Friend WithEvents LBL_folder As System.Windows.Forms.Label
End Class
