<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Favourites
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Favourites))
        Me.BTN_add = New System.Windows.Forms.Button()
        Me.BTN_remove = New System.Windows.Forms.Button()
        Me.LISTBOX_dirs = New System.Windows.Forms.ListBox()
        Me.LISTBOX_dirNames = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BTN_add
        '
        Me.BTN_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_add.Location = New System.Drawing.Point(241, 10)
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.Size = New System.Drawing.Size(43, 23)
        Me.BTN_add.TabIndex = 1
        Me.BTN_add.Text = "Add..."
        Me.BTN_add.UseVisualStyleBackColor = True
        '
        'BTN_remove
        '
        Me.BTN_remove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_remove.Location = New System.Drawing.Point(180, 10)
        Me.BTN_remove.Name = "BTN_remove"
        Me.BTN_remove.Size = New System.Drawing.Size(55, 23)
        Me.BTN_remove.TabIndex = 2
        Me.BTN_remove.Text = "Remove"
        Me.BTN_remove.UseVisualStyleBackColor = True
        '
        'LISTBOX_dirs
        '
        Me.LISTBOX_dirs.Dock = System.Windows.Forms.DockStyle.Top
        Me.LISTBOX_dirs.FormattingEnabled = True
        Me.LISTBOX_dirs.Location = New System.Drawing.Point(0, 0)
        Me.LISTBOX_dirs.Name = "LISTBOX_dirs"
        Me.LISTBOX_dirs.Size = New System.Drawing.Size(284, 4)
        Me.LISTBOX_dirs.TabIndex = 3
        Me.LISTBOX_dirs.Visible = False
        '
        'LISTBOX_dirNames
        '
        Me.LISTBOX_dirNames.Dock = System.Windows.Forms.DockStyle.Top
        Me.LISTBOX_dirNames.FormattingEnabled = True
        Me.LISTBOX_dirNames.Location = New System.Drawing.Point(0, 4)
        Me.LISTBOX_dirNames.Name = "LISTBOX_dirNames"
        Me.LISTBOX_dirNames.Size = New System.Drawing.Size(284, 4)
        Me.LISTBOX_dirNames.TabIndex = 4
        '
        'Favourites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 41)
        Me.Controls.Add(Me.LISTBOX_dirNames)
        Me.Controls.Add(Me.LISTBOX_dirs)
        Me.Controls.Add(Me.BTN_remove)
        Me.Controls.Add(Me.BTN_add)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Favourites"
        Me.Text = "Favourites"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_add As System.Windows.Forms.Button
    Friend WithEvents BTN_remove As System.Windows.Forms.Button
    Friend WithEvents LISTBOX_dirs As System.Windows.Forms.ListBox
    Friend WithEvents LISTBOX_dirNames As System.Windows.Forms.ListBox
End Class
