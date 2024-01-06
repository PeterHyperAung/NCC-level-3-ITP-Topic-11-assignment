Imports System.IO

Public Class frm_data
    Private Sub frm_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_result.Text = frm_form.result
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myWriter As StreamWriter = File.CreateText("IronManTriathletes.txt")
        myWriter.WriteLine(lbl_result.Text)
        myWriter.Close()
        MessageBox.Show("Yahoo! Finished!!")
        frm_form.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_generate_Click(sender As Object, e As EventArgs) Handles cmd_generate.Click
        lbl_result.Text = frm_form.result
    End Sub
End Class