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
    'Contado
    Private contador As Integer = 0
    ' Comprobar ganador
    Private Sub checkWinner(ByRef contador As Integer)

        If contador > 5 And contador < 9 Then
            If controlGanador(0, 0) = 1 And controlGanador(0, 1) = 1 And controlGanador(0, 2) = 1 Then
                MsgBox("Jugador 1 gana la partida")
                Close()
            ElseIf controlGanador(0, 0) = 1 And controlGanador(1, 0) = 1 And controlGanador(2, 0) = 1
                MsgBox("Jugador 1 gana la partida")
                Close()
            ElseIf controlGanador(0, 0) = 1 And controlGanador(1, 1) = 1 And controlGanador(2, 2) = 1
                MsgBox("Jugador 1 gana la partida")
                Close()
            ElseIf controlGanador(1, 0) = 1 And controlGanador(1, 1) = 1 And controlGanador(1, 2) = 1
                MsgBox("Jugador 1 gana la partida")
                Close()
            ElseIf controlGanador(2, 0) = 1 And controlGanador(2, 1) = 1 And controlGanador(2, 2) = 1
                MsgBox("Jugador 1 gana la partida")
                Close()
            ElseIf controlGanador(2, 0) = 1 And controlGanador(1, 1) = 1 And controlGanador(0, 2) = 1
                MsgBox("Jugador 1 gana la partida")
                Close()
            ElseIf controlGanador(0, 2) = 1 And controlGanador(1, 2) = 1 And controlGanador(2, 2) = 1
                MsgBox("Jugador 1 gana la partida")
                Close()
            ElseIf controlGanador(0, 1) = 1 And controlGanador(1, 1) = 1 And controlGanador(2, 1) = 1
                MsgBox("Jugadr 1 gana la partida")
                Close()
                ' Comprobar Jugador 2
            ElseIf controlGanador(0, 0) = 2 And controlGanador(0, 1) = 2 And controlGanador(0, 2) = 2 Then
                MsgBox("Jugador 2 gana la partida")
                Close()
            ElseIf controlGanador(0, 0) = 2 And controlGanador(1, 0) = 2 And controlGanador(2, 0) = 2
                MsgBox("Jugador 2 gana la partida")
                Close()
            ElseIf controlGanador(0, 0) = 2 And controlGanador(1, 1) = 2 And controlGanador(2, 2) = 2
                MsgBox("Jugador 2 gana la partida")
                Close()
            ElseIf controlGanador(1, 0) = 2 And controlGanador(1, 1) = 2 And controlGanador(1, 2) = 2
                MsgBox("Jugador 2 gana la partida")
                Close()
            ElseIf controlGanador(2, 0) = 2 And controlGanador(2, 1) = 2 And controlGanador(2, 2) = 2
                MsgBox("Jugador 2 gana la partida")
                Close()
            ElseIf controlGanador(2, 0) = 2 And controlGanador(1, 1) = 2 And controlGanador(0, 2) = 2
                MsgBox("Jugador 2 gana la partida")
                Close()
            ElseIf controlGanador(0, 2) = 2 And controlGanador(1, 2) = 2 And controlGanador(2, 2) = 2
                MsgBox("Jugador 2 gana la partida")
                Close()
            ElseIf controlGanador(0, 1) = 2 And controlGanador(1, 1) = 2 And controlGanador(2, 1) = 2
                MsgBox("Jugador 2 gana la partida")
                Close()

            End If
        ElseIf contador = 9
            MsgBox("Empate")
            Close()
        End If



    End Sub

    ' Botón de salida
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Salimos del programa
        MsgBox("Gracias por jugar al tres en raya.")
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Label4.Text = CStr(contador)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If turno = 1 Then
            Button1.BackColor = colorJugador1()
            controlGanador(0, 0) = turno
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True


        Else
            Button1.BackColor = colorJugador2()
            ' cambiamos de turno
            controlGanador(0, 0) = turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True


        End If
        ' Deshabilitamos el botón
        Button1.Enabled = False
        contador += 1
        Label4.Text = CStr(contador)
        checkWinner(contador)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If turno = 1 Then
            Button2.BackColor = colorJugador1()
            controlGanador(0, 1) = turno
            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True



        Else
            Button2.BackColor = colorJugador2()
            controlGanador(0, 1) = turno
            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True


        End If
        ' Deshabilitamos el botón
        Button2.Enabled = False
        contador += 1
        Label4.Text = CStr(contador)
        checkWinner(contador)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If turno = 1 Then
            Button3.BackColor = colorJugador1()
            controlGanador(0, 2) = turno

            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True


        Else
            Button3.BackColor = colorJugador2()
            controlGanador(0, 2) = turno
            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True

        End If
        ' Deshabilitamos el botón
        Button3.Enabled = False
        contador += 1
        Label4.Text = CStr(contador)
        checkWinner(contador)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If turno = 1 Then
            Button4.BackColor = colorJugador1()
            controlGanador(1, 0) = turno

            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True


        Else
            Button4.BackColor = colorJugador2()
            controlGanador(1, 0) = turno

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True

        End If
        ' Deshabilitamos el botón
        Button4.Enabled = False
        contador += 1
        Label4.Text = CStr(contador)
        checkWinner(contador)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If turno = 1 Then
            Button5.BackColor = colorJugador1()
            controlGanador(1, 1) = turno

            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True


        Else
            Button5.BackColor = colorJugador2()
            controlGanador(1, 1) = turno

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True

        End If
        ' Deshabilitamos el botón
        Button5.Enabled = False
        contador += 1
        Label4.Text = CStr(contador)
        checkWinner(contador)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If turno = 1 Then
            Button6.BackColor = colorJugador1()
            controlGanador(1, 2) = turno

            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True


        Else
            Button6.BackColor = colorJugador2()
            controlGanador(1, 2) = turno

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True

        End If
        ' Deshabilitamos el botón
        Button6.Enabled = False
        contador += 1
        Label4.Text = CStr(contador)
        checkWinner(contador)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If turno = 1 Then
            Button7.BackColor = colorJugador1()
            controlGanador(2, 0) = turno

            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True


        Else
            Button7.BackColor = colorJugador2()
            controlGanador(2, 0) = turno

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True

        End If
        ' Deshabilitamos el botón
        Button7.Enabled = False
        contador += 1
        Label4.Text = CStr(contador)
        checkWinner(contador)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If turno = 1 Then
            Button8.BackColor = colorJugador1()
            controlGanador(2, 1) = turno

            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True


        Else
            Button8.BackColor = colorJugador2()
            controlGanador(2, 1) = turno

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True

        End If
        ' Deshabilitamos el botón
        Button8.Enabled = False
        contador += 1
        Label4.Text = CStr(contador)
        checkWinner(contador)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If turno = 1 Then
            Button9.BackColor = colorJugador1()
            controlGanador(2, 2) = turno

            ' cambiamos de turno
            turno = 2
            'Desactivamos el label j1 y activamos el label j2
            Label1.Visible = False
            Label2.Visible = True


        Else
            Button9.BackColor = colorJugador2()
            controlGanador(2, 2) = turno

            ' cambiamos de turno
            turno = 1
            Label2.Visible = False
            Label1.Visible = True

        End If
        ' Deshabilitamos el botón
        Button9.Enabled = False
        contador += 1
        Label4.Text = CStr(contador)
        checkWinner(contador)
    End Sub
End Class
