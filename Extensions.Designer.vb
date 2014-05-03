<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Extensions
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
        Me.CHECKLIST_extensions = New System.Windows.Forms.CheckedListBox()
        Me.BTN_add = New System.Windows.Forms.Button()
        Me.BTN_remove = New System.Windows.Forms.Button()
        Me.BTN_done = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CHECKLIST_extensions
        '
        Me.CHECKLIST_extensions.Dock = System.Windows.Forms.DockStyle.Top
        Me.CHECKLIST_extensions.FormattingEnabled = True
        Me.CHECKLIST_extensions.Location = New System.Drawing.Point(0, 0)
        Me.CHECKLIST_extensions.Name = "CHECKLIST_extensions"
        Me.CHECKLIST_extensions.Size = New System.Drawing.Size(284, 4)
        Me.CHECKLIST_extensions.TabIndex = 5
        '
        'BTN_add
        '
        Me.BTN_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_add.Location = New System.Drawing.Point(12, 13)
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.Size = New System.Drawing.Size(43, 23)
        Me.BTN_add.TabIndex = 6
        Me.BTN_add.Text = "Add..."
        Me.BTN_add.UseVisualStyleBackColor = True
        '
        'BTN_remove
        '
        Me.BTN_remove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_remove.Location = New System.Drawing.Point(61, 13)
        Me.BTN_remove.Name = "BTN_remove"
        Me.BTN_remove.Size = New System.Drawing.Size(61, 23)
        Me.BTN_remove.TabIndex = 7
        Me.BTN_remove.Text = "Remove"
        Me.BTN_remove.UseVisualStyleBackColor = True
        '
        'BTN_done
        '
        Me.BTN_done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_done.Location = New System.Drawing.Point(197, 13)
        Me.BTN_done.Name = "BTN_done"
        Me.BTN_done.Size = New System.Drawing.Size(75, 23)
        Me.BTN_done.TabIndex = 8
        Me.BTN_done.Text = "Done"
        Me.BTN_done.UseVisualStyleBackColor = True
        '
        'Extensions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 48)
        Me.Controls.Add(Me.BTN_done)
        Me.Controls.Add(Me.BTN_remove)
        Me.Controls.Add(Me.BTN_add)
        Me.Controls.Add(Me.CHECKLIST_extensions)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Extensions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Extensions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CHECKLIST_extensions As System.Windows.Forms.CheckedListBox
    Friend WithEvents BTN_add As System.Windows.Forms.Button
    Friend WithEvents BTN_remove As System.Windows.Forms.Button
    Friend WithEvents BTN_done As System.Windows.Forms.Button
End Class
