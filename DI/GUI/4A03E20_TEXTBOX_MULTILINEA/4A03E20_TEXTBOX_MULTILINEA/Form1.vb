Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Añadimos las etiquetas
        Label1.Text = "EDITOR MULTILINEA"
        Label2.Text = "Palabra"
        Label7.Text = "Texto"
        Label3.Text = "Caracteres en el control"
        Label5.Text = "Caracteres seleccionados"
        Label4.Text = "0"
        Label6.Text = "0"
        Button1.Text = "Aceptar"
        Button2.Text = "Limpiar"
        Button3.Text = "Limpiar"
        Button4.Text = "Salir"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox2.Text.Count() = 0) Then
            TextBox2.AppendText(TextBox1.Text)
        Else
            TextBox2.AppendText(" " + TextBox1.Text)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Clear()
    End Sub

    Private Sub contarTextBox1(sender As Object, e As EventArgs) Handles Me.MouseMove
        Label6.Text = TextBox1.SelectedText.Count()

    End Sub

    Private Sub contarCajaCompleta(sender As Object, e As EventArgs) Handles Me.MouseMove
        'If (TextBox2.SelectedText.Count = 0) Then
        'Label4.Text = "0"
        ' Else
        Label4.Text = TextBox2.SelectedText.Count()

        ' End If
    End Sub
End Class
