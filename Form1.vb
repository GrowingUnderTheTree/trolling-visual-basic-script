Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DialogResult = MessageBox.Show("Do you want to click it?", "You sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = vbYes Then
            DialogResult = MessageBox.Show("Yeah it's safe go click it", "You sure bro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If DialogResult = vbYes Then
                MessageBox.Show("Ok go click this :)", "Here gae", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            MessageBox.Show("nega", "Warned you", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MessageBox.Show("HEHE", "HEHEHEHEHE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            WebBrowser1.Navigate(New Uri("https://www.youtube.com/watch?v=dQw4w9WgXcQ"))

        End If

    End Sub

End Class