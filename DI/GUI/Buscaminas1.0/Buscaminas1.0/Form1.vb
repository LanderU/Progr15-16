Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Button37.Enabled = False
    End Sub
    ' Método que recoge el pulsado de todos los botones.
    Private Sub pulsacion(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        ' Hacemos el cast del botón un una variable
        Dim boton_clicado As Button = CType(sender, Button)
        accion_boton(boton_clicado)
    End Sub
    ' Prueba
    Private Sub accion_boton(ByRef boton_clicado)

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Close()
    End Sub
End Class
