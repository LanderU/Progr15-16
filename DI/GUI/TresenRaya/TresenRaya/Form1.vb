Public Class Form1
﻿ 'Colores para los jugadores
    Private Function colorJugador1()
        Return Color.FromArgb(0, 0, 204)
    End Function
    Private Function colorJugador2()
        Return Color.FromArgb(153, 0, 0)
    End Function
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Salimos del programa
        MsgBox("Gracias por jugar al tres en raya.")
        Close()
    End Sub
End Class
