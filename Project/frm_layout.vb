Public Class frm_layout
    Private Sub frm_layout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Image.FromFile("logo.png")
        PictureBox1.BackgroundImageLayout = BackgroundImageLayout.Stretch
        frm_form.TopLevel = False
        Me.Panel1.Controls.Add(frm_form)
        frm_data.TopLevel = False
        Me.Panel1.Controls.Add(frm_data)
        frm_form.Show()
    End Sub

End Class
