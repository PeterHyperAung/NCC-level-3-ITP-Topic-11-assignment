<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_form
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
        Me.lbl_run = New System.Windows.Forms.Label()
        Me.lbl_cycle = New System.Windows.Forms.Label()
        Me.lbl_swim = New System.Windows.Forms.Label()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.cmd_enter = New System.Windows.Forms.Button()
        Me.txt_run = New System.Windows.Forms.TextBox()
        Me.txt_cycle = New System.Windows.Forms.TextBox()
        Me.txt_swim = New System.Windows.Forms.TextBox()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.cmd_get_3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_run
        '
        Me.lbl_run.AutoSize = True
        Me.lbl_run.Location = New System.Drawing.Point(515, 160)
        Me.lbl_run.Name = "lbl_run"
        Me.lbl_run.Size = New System.Drawing.Size(146, 16)
        Me.lbl_run.TabIndex = 17
        Me.lbl_run.Text = "Running Minimum Time"
        '
        'lbl_cycle
        '
        Me.lbl_cycle.AutoSize = True
        Me.lbl_cycle.Location = New System.Drawing.Point(515, 38)
        Me.lbl_cycle.Name = "lbl_cycle"
        Me.lbl_cycle.Size = New System.Drawing.Size(141, 16)
        Me.lbl_cycle.TabIndex = 16
        Me.lbl_cycle.Text = "Cycling Minimum Time"
        '
        'lbl_swim
        '
        Me.lbl_swim.AutoSize = True
        Me.lbl_swim.Location = New System.Drawing.Point(98, 160)
        Me.lbl_swim.Name = "lbl_swim"
        Me.lbl_swim.Size = New System.Drawing.Size(158, 16)
        Me.lbl_swim.TabIndex = 15
        Me.lbl_swim.Text = "Swimming Minimum Time"
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.Location = New System.Drawing.Point(98, 38)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(68, 16)
        Me.lbl_fullname.TabIndex = 14
        Me.lbl_fullname.Text = "Full Name"
        '
        'cmd_enter
        '
        Me.cmd_enter.Location = New System.Drawing.Point(375, 252)
        Me.cmd_enter.Name = "cmd_enter"
        Me.cmd_enter.Size = New System.Drawing.Size(117, 39)
        Me.cmd_enter.TabIndex = 13
        Me.cmd_enter.Text = "Enter"
        Me.cmd_enter.UseVisualStyleBackColor = True
        '
        'txt_run
        '
        Me.txt_run.Location = New System.Drawing.Point(518, 190)
        Me.txt_run.Name = "txt_run"
        Me.txt_run.Size = New System.Drawing.Size(249, 22)
        Me.txt_run.TabIndex = 12
        '
        'txt_cycle
        '
        Me.txt_cycle.Location = New System.Drawing.Point(518, 68)
        Me.txt_cycle.Name = "txt_cycle"
        Me.txt_cycle.Size = New System.Drawing.Size(249, 22)
        Me.txt_cycle.TabIndex = 11
        '
        'txt_swim
        '
        Me.txt_swim.Location = New System.Drawing.Point(93, 190)
        Me.txt_swim.Name = "txt_swim"
        Me.txt_swim.Size = New System.Drawing.Size(249, 22)
        Me.txt_swim.TabIndex = 10
        '
        'txt_fullname
        '
        Me.txt_fullname.Location = New System.Drawing.Point(93, 68)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(249, 22)
        Me.txt_fullname.TabIndex = 9
        '
        'cmd_get_3
        '
        Me.cmd_get_3.Location = New System.Drawing.Point(375, 313)
        Me.cmd_get_3.Name = "cmd_get_3"
        Me.cmd_get_3.Size = New System.Drawing.Size(117, 39)
        Me.cmd_get_3.TabIndex = 18
        Me.cmd_get_3.Text = "Get Top 3"
        Me.cmd_get_3.UseVisualStyleBackColor = True
        '
        'frm_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 380)
        Me.Controls.Add(Me.cmd_get_3)
        Me.Controls.Add(Me.lbl_run)
        Me.Controls.Add(Me.lbl_cycle)
        Me.Controls.Add(Me.lbl_swim)
        Me.Controls.Add(Me.lbl_fullname)
        Me.Controls.Add(Me.cmd_enter)
        Me.Controls.Add(Me.txt_run)
        Me.Controls.Add(Me.txt_cycle)
        Me.Controls.Add(Me.txt_swim)
        Me.Controls.Add(Me.txt_fullname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "frm_form"
        Me.Text = "InputForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_run As Label
    Friend WithEvents lbl_cycle As Label
    Friend WithEvents lbl_swim As Label
    Friend WithEvents lbl_fullname As Label
    Friend WithEvents cmd_enter As Button
    Friend WithEvents txt_run As TextBox
    Friend WithEvents txt_cycle As TextBox
    Friend WithEvents txt_swim As TextBox
    Friend WithEvents txt_fullname As TextBox
    Friend WithEvents cmd_get_3 As Button
End Class
