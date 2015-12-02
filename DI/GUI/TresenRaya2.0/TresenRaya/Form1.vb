Public Class Form1
    ' Matriz para conocer el ganador
    Private controlGanador(2, 2) As Integer
    ' Colores para los jugadores
    Private Function colorJugador1()
        Return Color.FromArgb(0, 0, 204)
    End Function
    Private Function colorJugador2()
        Return Color.FromArgb(153, 0, 0)
    End Function
    ' Control del turno
    Private turno As Integer = 1
    ' Botón de salida
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Salimos del programa
        MsgBox("Gracias por jugar al tres en raya.")
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If turno = 1 Then
            Button1.BackColor = colorJugador1()
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True
            controlGanador(0, 0) = turno

        Else
            Button1.BackColor = colorJugador2()
            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True
        End If
        ' Deshabilitamos el botón
        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If turno = 1 Then
            Button2.BackColor = colorJugador1()
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True

        Else
            Button2.BackColor = colorJugador2()

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True
        End If
        ' Deshabilitamos el botón
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If turno = 1 Then
            Button3.BackColor = colorJugador1()
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True

        Else
            Button3.BackColor = colorJugador2()

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True
        End If
        ' Deshabilitamos el botón
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If turno = 1 Then
            Button4.BackColor = colorJugador1()
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True

        Else
            Button4.BackColor = colorJugador2()

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True
        End If
        ' Deshabilitamos el botón
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If turno = 1 Then
            Button5.BackColor = colorJugador1()
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True

        Else
            Button5.BackColor = colorJugador2()

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True
        End If
        ' Deshabilitamos el botón
        Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If turno = 1 Then
            Button6.BackColor = colorJugador1()
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True

        Else
            Button6.BackColor = colorJugador2()

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True
        End If
        ' Deshabilitamos el botón
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If turno = 1 Then
            Button7.BackColor = colorJugador1()
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True

        Else
            Button7.BackColor = colorJugador2()

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True
        End If
        ' Deshabilitamos el botón
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If turno = 1 Then
            Button8.BackColor = colorJugador1()
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True

        Else
            Button8.BackColor = colorJugador2()

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True
        End If
        ' Deshabilitamos el botón
        Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If turno = 1 Then
            Button9.BackColor = colorJugador1()
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True

        Else
            Button9.BackColor = colorJugador2()

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True
        End If
        ' Deshabilitamos el botón
        Button9.Enabled = False
    End Sub
End Class
