Public Class Form1
    ' Array con el tablero 3 = Bomba
    Dim tablero = {
                        {3, 1, 0, 0, 0, 0}, ' Fila 1
                        {1, 0, 1, 0, 0, 0}, ' Fila 2
                        {0, 1, 3, 1, 1, 0}, ' Fila 3
                        {0, 0, 1, 1, 3, 1}, ' Fila 4
                        {1, 0, 0, 1, 1, 0}, ' Fila 5
                        {3, 1, 1, 3, 1, 0}  ' Fila 6
                   }

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
