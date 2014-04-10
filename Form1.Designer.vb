<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BOX_srcDirectory = New System.Windows.Forms.GroupBox()
        Me.LISTBOX_srcDirectory = New System.Windows.Forms.ListBox()
        Me.BTN_srcDirectory = New System.Windows.Forms.Button()
        Me.TEXTBOX_srcDirectory = New System.Windows.Forms.TextBox()
        Me.BOX_extensions = New System.Windows.Forms.GroupBox()
        Me.TEXTBOX_extensions = New System.Windows.Forms.TextBox()
        Me.BOX_results = New System.Windows.Forms.GroupBox()
        Me.BTN_helpMeChoose = New System.Windows.Forms.Button()
        Me.NUM_results = New System.Windows.Forms.NumericUpDown()
        Me.LABEL_results = New System.Windows.Forms.Label()
        Me.BOX_srcDirectory.SuspendLayout()
        Me.BOX_extensions.SuspendLayout()
        Me.BOX_results.SuspendLayout()
        CType(Me.NUM_results, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOX_srcDirectory
        '
        Me.BOX_srcDirectory.Controls.Add(Me.LISTBOX_srcDirectory)
        Me.BOX_srcDirectory.Controls.Add(Me.BTN_srcDirectory)
        Me.BOX_srcDirectory.Controls.Add(Me.TEXTBOX_srcDirectory)
        Me.BOX_srcDirectory.Location = New System.Drawing.Point(12, 12)
        Me.BOX_srcDirectory.Name = "BOX_srcDirectory"
        Me.BOX_srcDirectory.Size = New System.Drawing.Size(341, 53)
        Me.BOX_srcDirectory.TabIndex = 0
        Me.BOX_srcDirectory.TabStop = False
        Me.BOX_srcDirectory.Text = "SourceDirectory"
        '
        'LISTBOX_srcDirectory
        '
        Me.LISTBOX_srcDirectory.FormattingEnabled = True
        Me.LISTBOX_srcDirectory.Location = New System.Drawing.Point(6, 45)
        Me.LISTBOX_srcDirectory.Name = "LISTBOX_srcDirectory"
        Me.LISTBOX_srcDirectory.Size = New System.Drawing.Size(294, 17)
        Me.LISTBOX_srcDirectory.TabIndex = 2
        Me.LISTBOX_srcDirectory.Visible = False
        '
        'BTN_srcDirectory
        '
        Me.BTN_srcDirectory.Location = New System.Drawing.Point(306, 16)
        Me.BTN_srcDirectory.Name = "BTN_srcDirectory"
        Me.BTN_srcDirectory.Size = New System.Drawing.Size(25, 23)
        Me.BTN_srcDirectory.TabIndex = 1
        Me.BTN_srcDirectory.Text = "..."
        Me.BTN_srcDirectory.UseVisualStyleBackColor = True
        '
        'TEXTBOX_srcDirectory
        '
        Me.TEXTBOX_srcDirectory.Enabled = False
        Me.TEXTBOX_srcDirectory.Location = New System.Drawing.Point(6, 19)
        Me.TEXTBOX_srcDirectory.Name = "TEXTBOX_srcDirectory"
        Me.TEXTBOX_srcDirectory.Size = New System.Drawing.Size(294, 20)
        Me.TEXTBOX_srcDirectory.TabIndex = 0
        '
        'BOX_extensions
        '
        Me.BOX_extensions.Controls.Add(Me.TEXTBOX_extensions)
        Me.BOX_extensions.Location = New System.Drawing.Point(12, 71)
        Me.BOX_extensions.Name = "BOX_extensions"
        Me.BOX_extensions.Size = New System.Drawing.Size(341, 50)
        Me.BOX_extensions.TabIndex = 1
        Me.BOX_extensions.TabStop = False
        Me.BOX_extensions.Text = "File Extensions (seperate with a space)"
        '
        'TEXTBOX_extensions
        '
        Me.TEXTBOX_extensions.Location = New System.Drawing.Point(6, 19)
        Me.TEXTBOX_extensions.Name = "TEXTBOX_extensions"
        Me.TEXTBOX_extensions.Size = New System.Drawing.Size(294, 20)
        Me.TEXTBOX_extensions.TabIndex = 0
        Me.TEXTBOX_extensions.Text = ".avi .mov .mp4 .mpg .mkv .wmv .asf .asx .dat .rm .rmvb"
        '
        'BOX_results
        '
        Me.BOX_results.Controls.Add(Me.BTN_helpMeChoose)
        Me.BOX_results.Controls.Add(Me.NUM_results)
        Me.BOX_results.Controls.Add(Me.LABEL_results)
        Me.BOX_results.Location = New System.Drawing.Point(12, 127)
        Me.BOX_results.Name = "BOX_results"
        Me.BOX_results.Size = New System.Drawing.Size(341, 50)
        Me.BOX_results.TabIndex = 2
        Me.BOX_results.TabStop = False
        Me.BOX_results.Text = "Results"
        '
        'BTN_helpMeChoose
        '
        Me.BTN_helpMeChoose.Location = New System.Drawing.Point(178, 14)
        Me.BTN_helpMeChoose.Name = "BTN_helpMeChoose"
        Me.BTN_helpMeChoose.Size = New System.Drawing.Size(153, 23)
        Me.BTN_helpMeChoose.TabIndex = 3
        Me.BTN_helpMeChoose.Text = "Help Me Choose!"
        Me.BTN_helpMeChoose.UseVisualStyleBackColor = True
        '
        'NUM_results
        '
        Me.NUM_results.Location = New System.Drawing.Point(105, 18)
        Me.NUM_results.Name = "NUM_results"
        Me.NUM_results.Size = New System.Drawing.Size(56, 20)
        Me.NUM_results.TabIndex = 2
        Me.NUM_results.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'LABEL_results
        '
        Me.LABEL_results.AutoSize = True
        Me.LABEL_results.Location = New System.Drawing.Point(7, 20)
        Me.LABEL_results.Name = "LABEL_results"
        Me.LABEL_results.Size = New System.Drawing.Size(92, 13)
        Me.LABEL_results.TabIndex = 0
        Me.LABEL_results.Text = "Number of results:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 185)
        Me.Controls.Add(Me.BOX_results)
        Me.Controls.Add(Me.BOX_extensions)
        Me.Controls.Add(Me.BOX_srcDirectory)
        Me.Name = "Form1"
        Me.Text = "Help Me Choose!"
        Me.BOX_srcDirectory.ResumeLayout(False)
        Me.BOX_srcDirectory.PerformLayout()
        Me.BOX_extensions.ResumeLayout(False)
        Me.BOX_extensions.PerformLayout()
        Me.BOX_results.ResumeLayout(False)
        Me.BOX_results.PerformLayout()
        CType(Me.NUM_results, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BOX_srcDirectory As System.Windows.Forms.GroupBox
    Friend WithEvents TEXTBOX_srcDirectory As System.Windows.Forms.TextBox
    Friend WithEvents BOX_extensions As System.Windows.Forms.GroupBox
    Friend WithEvents TEXTBOX_extensions As System.Windows.Forms.TextBox
    Friend WithEvents BOX_results As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_helpMeChoose As System.Windows.Forms.Button
    Friend WithEvents NUM_results As System.Windows.Forms.NumericUpDown
    Friend WithEvents LABEL_results As System.Windows.Forms.Label
    Friend WithEvents BTN_srcDirectory As System.Windows.Forms.Button
    Friend WithEvents LISTBOX_srcDirectory As System.Windows.Forms.ListBox

End Class
