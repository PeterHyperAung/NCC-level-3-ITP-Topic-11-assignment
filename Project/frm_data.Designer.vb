<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_data
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_result = New System.Windows.Forms.Label()
        Me.lbl_label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmd_generate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_result
        '
        Me.lbl_result.AutoSize = True
        Me.lbl_result.Location = New System.Drawing.Point(317, 117)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(80, 16)
        Me.lbl_result.TabIndex = 0
        Me.lbl_result.Text = "Placeholder"
        '
        'lbl_label
        '
        Me.lbl_label.AutoSize = True
        Me.lbl_label.Location = New System.Drawing.Point(315, 87)
        Me.lbl_label.Name = "lbl_label"
        Me.lbl_label.Size = New System.Drawing.Size(147, 16)
        Me.lbl_label.TabIndex = 1
        Me.lbl_label.Text = "No Name  Lowest Time"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(423, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmd_generate
        '
        Me.cmd_generate.Location = New System.Drawing.Point(259, 332)
        Me.cmd_generate.Name = "cmd_generate"
        Me.cmd_generate.Size = New System.Drawing.Size(136, 40)
        Me.cmd_generate.TabIndex = 3
        Me.cmd_generate.Text = "Regenerate Top 3"
        Me.cmd_generate.UseVisualStyleBackColor = True
        '
        'frm_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmd_generate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_label)
        Me.Controls.Add(Me.lbl_result)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_data"
        Me.Text = "Top 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_result As Label
    Friend WithEvents lbl_label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmd_generate As Button
End Class
