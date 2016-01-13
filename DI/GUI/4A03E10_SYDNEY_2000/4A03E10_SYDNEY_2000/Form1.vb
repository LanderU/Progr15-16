Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Deshabilitamos los textBox
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.ReadOnly = True

        ' Deshabilitamos los botones campeón y salir

        Button5.Enabled = False
        Button6.Enabled = False


    End Sub
    Private Sub comprobar()
        If (Button1.Enabled = False) And (Button2.Enabled = False) And (Button3.Enabled = False) And (Button4.Enabled = False) Then
            Button5.Enabled = True
        End If
    End Sub

    ' Array de los botones
    Dim botones() As Object = {Button1, Button2, Button3, Button4}
    Private Sub pressButton(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click
        Dim pulsado As Button = CType(sender, Button)
        If pulsado.Equals(Button1) Then
            TextBox1.Text = "12"
        ElseIf pulsado.Equals(Button2)
            TextBox2.Text = "28"
        ElseIf pulsado.Equals(Button3)
            TextBox3.Text = "2"
        ElseIf pulsado.Equals(Button4)
            TextBox4.Text = "55"
        ElseIf pulsado.Equals(Button5)
            TextBox5.Text = "¡¡AUSTRALIA!!"
            Button6.Enabled = True
        ElseIf pulsado.Equals(Button6)
            Close()
        End If
        ' Desactivamos el botón
        pulsado.Enabled = False
        comprobar()

    End Sub

    Private Sub limpiarConAlentrarelMouse(sender As Object, e As EventArgs) Handles TextBox5.MouseEnter
        ' Depurar
        ' For Each bot As Button In botones
        '     bot.Enabled = True
        ' Next
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = False

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()


    End Sub


End Class
