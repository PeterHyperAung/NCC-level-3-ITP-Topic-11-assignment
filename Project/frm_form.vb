Imports System.IO
Imports System.Runtime.InteropServices.ComTypes

Public Class frm_form

    Dim total_data(10) As String
    Dim max As Integer = 10
    Dim len As Integer = 0
    Public form_data_swim As Double
    Public form_data_run As Double
    Public form_data_cycle As Double
    Public result As String

    Private Sub InputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Function validateUserInput(num As String)
        Dim numbers As String = "0123456789"
        For x = 0 To (num.Length - 1)
            Dim temp As Boolean = False
            For y = 0 To (numbers.Length - 1)
                If num(x) = numbers(y) Then
                    temp = True
                    Exit For
                End If
            Next

            If temp = False Then
                Return False
            End If
        Next

        Return True

    End Function

    Function loadFormData()
        form_data_swim = txt_swim.Text
        form_data_run = txt_run.Text
        form_data_cycle = txt_cycle.Text
    End Function

    Function checkEmptinessAndInvalid()
        If (txt_fullname.Text = "") Then
            MessageBox.Show("Name is invalid")
            Return False
        ElseIf (txt_swim.Text = "") Or Not validateUserInput(txt_swim.Text) Then
            MessageBox.Show("Swmming time is invalid")
            Return False
        ElseIf (txt_cycle.Text = "") Or Not validateUserInput(txt_cycle.Text) Then
            MessageBox.Show("Cycling time is invalid")
            Return False
        ElseIf (txt_run.Text = "") Or Not validateUserInput(txt_run.Text) Then
            MessageBox.Show("Running time is invalid")
            Return False
        Else
            loadFormData()
            Return True
        End If
    End Function



    Private Sub cmd_enter_Click(sender As Object, e As EventArgs) Handles cmd_enter.Click

        If checkEmptinessAndInvalid() Then
            If form_data_swim > 40 Then
                MessageBox.Show("Swmming time is invalid")
            ElseIf form_data_cycle > 260 Then
                MessageBox.Show("Cycling time is invalid")
            ElseIf form_data_run > 125 Then
                MessageBox.Show("Running time is invalid")
            Else
                Dim total As String = form_data_swim + form_data_cycle + form_data_run
                For counter = 1 To (3 - total.Length)
                    total = " " + total
                Next
                total_data(len) = $"{total}|{txt_fullname.Text}|{txt_swim.Text}|{txt_cycle.Text}|{txt_run.Text}"
                len += 1
                MessageBox.Show($"Success! {len}")
            End If
        End If



    End Sub

    Private Sub cmd_get_3_Click(sender As Object, e As EventArgs) Handles cmd_get_3.Click
        result = ""
        If len < 3 Then
            MessageBox.Show("You should enter at least 3 athletes.")
        Else
            Array.Sort(total_data)
            result += $"1. {(total_data(max - (len - 1)).Split("|"))(1)} {(total_data(max - (len - 1)).Split("|"))(0)} {vbCrLf}"
            result += $"2. {(total_data(max - (len - 2)).Split("|"))(1)} {(total_data(max - (len - 2)).Split("|"))(0)} {vbCrLf}"
            result += $"3. {(total_data(max - (len - 3)).Split("|"))(1)} {(total_data(max - (len - 3)).Split("|"))(0)} {vbCrLf}"
            frm_data.Show()
            Me.Hide()
        End If



    End Sub
End Class