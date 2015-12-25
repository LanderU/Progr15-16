Public Class Form1
    ' Definición del tablero de juego 3 = Bomba
    Private Sub tablero()
        Button1.Text = "3"
        Button2.Text = "1"
        Button3.Text = "0"
        Button4.Text = "0"
        Button5.Text = "0"
        Button6.Text = "0"
        Button7.Text = "1"
        Button8.Text = "0"
        Button9.Text = "1"
        Button10.Text = "0"
        Button11.Text = "0"
        Button12.Text = "0"
        Button13.Text = "0"
        Button14.Text = "1"
        Button15.Text = "3"
        Button16.Text = "1"
        Button17.Text = "1"
        Button18.Text = "0"
        Button19.Text = "0"
        Button20.Text = "0"
        Button21.Text = "1"
        Button22.Text = "1"
        Button23.Text = "3"
        Button24.Text = "1"
        Button25.Text = "1"
        Button26.Text = "0"
        Button27.Text = "0"
        Button28.Text = "1"
        Button29.Text = "1"
        Button30.Text = "0"
        Button31.Text = "3"
        Button32.Text = "1"
        Button33.Text = "1"
        Button34.Text = "3"
        Button35.Text = "1"
        Button36.Text = "0"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Button37.Enabled = False
    End Sub
    ' Método que recoge el pulsado de todos los botones.
    Private Sub pulsacion(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click
        ' Hacemos el cast del botón un una variable, no es necesario lo hace por si mismo, es por pulcritud mental
        Dim boton_clicado As Button = CType(sender, Button)
        pulsado(boton_clicado)
    End Sub
    ' Controlamos el pulso del botón
    Private Sub pulsado(ByRef boton_clicado)

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Close()
    End Sub
End Class
