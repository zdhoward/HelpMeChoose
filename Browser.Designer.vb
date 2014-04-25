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
        Me.TEXTBOX_srcDirectory = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_addPlaylist = New System.Windows.Forms.Button()
        Me.BTN_exportFiles = New System.Windows.Forms.Button()
        Me.BTN_play = New System.Windows.Forms.Button()
        Me.LISTBOX_folders = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LISTBOX_selection
        '
        Me.LISTBOX_selection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LISTBOX_selection.FormattingEnabled = True
        Me.LISTBOX_selection.Location = New System.Drawing.Point(13, 13)
        Me.LISTBOX_selection.Name = "LISTBOX_selection"
        Me.LISTBOX_selection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LISTBOX_selection.Size = New System.Drawing.Size(249, 17)
        Me.LISTBOX_selection.TabIndex = 0
        '
        'BTN_reroll
        '
        Me.BTN_reroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_reroll.Location = New System.Drawing.Point(284, 71)
        Me.BTN_reroll.Name = "BTN_reroll"
        Me.BTN_reroll.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reroll.TabIndex = 1
        Me.BTN_reroll.Text = "Roll Again!"
        Me.BTN_reroll.UseVisualStyleBackColor = True
        '
        'BTN_back
        '
        Me.BTN_back.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_back.Location = New System.Drawing.Point(12, 71)
        Me.BTN_back.Name = "BTN_back"
        Me.BTN_back.Size = New System.Drawing.Size(75, 23)
        Me.BTN_back.TabIndex = 2
        Me.BTN_back.Text = "< Back"
        Me.BTN_back.UseVisualStyleBackColor = True
        '
        'BTN_selectAll
        '
        Me.BTN_selectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_selectAll.Location = New System.Drawing.Point(203, 42)
        Me.BTN_selectAll.Name = "BTN_selectAll"
        Me.BTN_selectAll.Size = New System.Drawing.Size(75, 23)
        Me.BTN_selectAll.TabIndex = 3
        Me.BTN_selectAll.Text = "Select All"
        Me.BTN_selectAll.UseVisualStyleBackColor = True
        '
        'BTN_selectNone
        '
        Me.BTN_selectNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_selectNone.Location = New System.Drawing.Point(284, 42)
        Me.BTN_selectNone.Name = "BTN_selectNone"
        Me.BTN_selectNone.Size = New System.Drawing.Size(75, 23)
        Me.BTN_selectNone.TabIndex = 4
        Me.BTN_selectNone.Text = "Select None"
        Me.BTN_selectNone.UseVisualStyleBackColor = True
        '
        'TEXTBOX_srcDirectory
        '
        Me.TEXTBOX_srcDirectory.Enabled = False
        Me.TEXTBOX_srcDirectory.FormattingEnabled = True
        Me.TEXTBOX_srcDirectory.Location = New System.Drawing.Point(13, 13)
        Me.TEXTBOX_srcDirectory.Name = "TEXTBOX_srcDirectory"
        Me.TEXTBOX_srcDirectory.Size = New System.Drawing.Size(170, 17)
        Me.TEXTBOX_srcDirectory.TabIndex = 5
        Me.TEXTBOX_srcDirectory.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(12, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Invert Selection"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_addPlaylist
        '
        Me.BTN_addPlaylist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_addPlaylist.Location = New System.Drawing.Point(366, 42)
        Me.BTN_addPlaylist.Name = "BTN_addPlaylist"
        Me.BTN_addPlaylist.Size = New System.Drawing.Size(90, 23)
        Me.BTN_addPlaylist.TabIndex = 7
        Me.BTN_addPlaylist.Text = "Add To Playlist"
        Me.BTN_addPlaylist.UseVisualStyleBackColor = True
        '
        'BTN_exportFiles
        '
        Me.BTN_exportFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_exportFiles.Location = New System.Drawing.Point(366, 13)
        Me.BTN_exportFiles.Name = "BTN_exportFiles"
        Me.BTN_exportFiles.Size = New System.Drawing.Size(90, 23)
        Me.BTN_exportFiles.TabIndex = 8
        Me.BTN_exportFiles.Text = "Export Files.."
        Me.BTN_exportFiles.UseVisualStyleBackColor = True
        '
        'BTN_play
        '
        Me.BTN_play.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_play.Location = New System.Drawing.Point(365, 71)
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
        Me.LISTBOX_folders.Location = New System.Drawing.Point(259, 13)
        Me.LISTBOX_folders.Name = "LISTBOX_folders"
        Me.LISTBOX_folders.Size = New System.Drawing.Size(101, 17)
        Me.LISTBOX_folders.TabIndex = 10
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 106)
        Me.Controls.Add(Me.LISTBOX_folders)
        Me.Controls.Add(Me.BTN_play)
        Me.Controls.Add(Me.BTN_exportFiles)
        Me.Controls.Add(Me.BTN_addPlaylist)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_selectNone)
        Me.Controls.Add(Me.BTN_selectAll)
        Me.Controls.Add(Me.BTN_back)
        Me.Controls.Add(Me.BTN_reroll)
        Me.Controls.Add(Me.TEXTBOX_srcDirectory)
        Me.Controls.Add(Me.LISTBOX_selection)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(404, 38)
        Me.Name = "Browser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HelpMeChoose!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LISTBOX_selection As System.Windows.Forms.ListBox
    Friend WithEvents BTN_reroll As System.Windows.Forms.Button
    Friend WithEvents BTN_back As System.Windows.Forms.Button
    Friend WithEvents BTN_selectAll As System.Windows.Forms.Button
    Friend WithEvents BTN_selectNone As System.Windows.Forms.Button
    Friend WithEvents TEXTBOX_srcDirectory As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTN_addPlaylist As System.Windows.Forms.Button
    Friend WithEvents BTN_exportFiles As System.Windows.Forms.Button
    Friend WithEvents BTN_play As System.Windows.Forms.Button
    Friend WithEvents LISTBOX_folders As System.Windows.Forms.ListBox
End Class
