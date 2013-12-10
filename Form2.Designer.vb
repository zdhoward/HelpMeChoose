<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.LISTBOX_selection = New System.Windows.Forms.ListBox()
        Me.BTN_reroll = New System.Windows.Forms.Button()
        Me.BTN_back = New System.Windows.Forms.Button()
        Me.BTN_selectAll = New System.Windows.Forms.Button()
        Me.BTN_selectNone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LISTBOX_selection
        '
        Me.LISTBOX_selection.FormattingEnabled = True
        Me.LISTBOX_selection.Location = New System.Drawing.Point(13, 13)
        Me.LISTBOX_selection.Name = "LISTBOX_selection"
        Me.LISTBOX_selection.Size = New System.Drawing.Size(268, 186)
        Me.LISTBOX_selection.TabIndex = 0
        '
        'BTN_reroll
        '
        Me.BTN_reroll.Location = New System.Drawing.Point(206, 230)
        Me.BTN_reroll.Name = "BTN_reroll"
        Me.BTN_reroll.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reroll.TabIndex = 1
        Me.BTN_reroll.Text = "Roll Again!"
        Me.BTN_reroll.UseVisualStyleBackColor = True
        '
        'BTN_back
        '
        Me.BTN_back.Location = New System.Drawing.Point(13, 230)
        Me.BTN_back.Name = "BTN_back"
        Me.BTN_back.Size = New System.Drawing.Size(75, 23)
        Me.BTN_back.TabIndex = 2
        Me.BTN_back.Text = "< Back"
        Me.BTN_back.UseVisualStyleBackColor = True
        '
        'BTN_selectAll
        '
        Me.BTN_selectAll.Location = New System.Drawing.Point(125, 201)
        Me.BTN_selectAll.Name = "BTN_selectAll"
        Me.BTN_selectAll.Size = New System.Drawing.Size(75, 23)
        Me.BTN_selectAll.TabIndex = 3
        Me.BTN_selectAll.Text = "Select All"
        Me.BTN_selectAll.UseVisualStyleBackColor = True
        '
        'BTN_selectNone
        '
        Me.BTN_selectNone.Location = New System.Drawing.Point(206, 201)
        Me.BTN_selectNone.Name = "BTN_selectNone"
        Me.BTN_selectNone.Size = New System.Drawing.Size(75, 23)
        Me.BTN_selectNone.TabIndex = 4
        Me.BTN_selectNone.Text = "Select None"
        Me.BTN_selectNone.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 265)
        Me.Controls.Add(Me.BTN_selectNone)
        Me.Controls.Add(Me.BTN_selectAll)
        Me.Controls.Add(Me.BTN_back)
        Me.Controls.Add(Me.BTN_reroll)
        Me.Controls.Add(Me.LISTBOX_selection)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LISTBOX_selection As System.Windows.Forms.ListBox
    Friend WithEvents BTN_reroll As System.Windows.Forms.Button
    Friend WithEvents BTN_back As System.Windows.Forms.Button
    Friend WithEvents BTN_selectAll As System.Windows.Forms.Button
    Friend WithEvents BTN_selectNone As System.Windows.Forms.Button
End Class
