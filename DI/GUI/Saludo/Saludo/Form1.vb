Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            TextBox1.Text = "Hola!"
        ElseIf RadioButton2.Checked Then
            TextBox1.Text = "Kaixo!"
        End If
    End Sub
End Class
