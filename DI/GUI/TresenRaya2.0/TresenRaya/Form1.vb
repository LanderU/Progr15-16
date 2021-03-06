﻿Imports System.IO
Imports System.Text
Imports System
Public Class Form1
    ' Guardamos en un fichero la cantidad de veces que ha ganado un jugador
    Dim pathJ1 As String = "C:\users\Public\ganadorJugador1.txt"
    Dim pathJ2 As String = "C:\users\Public\ganadorJugador2.txt"
    Private Sub partidasGanadasJugador1()

        'Si el archivo no existe lo creamos y lo rellenamos con un 0.
        Dim fichero As FileStream
        Dim contGanador As Byte()

        If Not File.Exists(pathJ1) Then

            fichero = File.Create(pathJ1)
            contGanador = New UTF8Encoding(True).GetBytes(0)
            fichero.Write(contGanador, 0, contGanador.Length)
            fichero.Close()

        End If
        ' Empezamos a operar sobre él
        'Dim kk As Byte()
        'kk = New UTF8Encoding(True).GetBytes(1)
        'fichero.Write(kk, 0, kk.Length)
        'fichero.Close()

        Using leer As New StreamReader(pathJ1)
            Dim linea As Integer = leer.ReadToEnd()
            ' MsgBox(linea) debug
            linea += 1
            leer.Close()
            'Metodo para sobreescriir el archivo, el último parámetro True = Append False = sobreescribir
            My.Computer.FileSystem.WriteAllText(pathJ1, linea, False)
        End Using



    End Sub
    Private Sub partidasGanadasJugador2()
        'Si el archivo no existe lo creamos y lo rellenamos con un 0.
        Dim fichero As FileStream
        Dim contGanador As Byte()

        If Not File.Exists(pathJ2) Then

            fichero = File.Create(pathJ2)
            contGanador = New UTF8Encoding(True).GetBytes(0)
            fichero.Write(contGanador, 0, contGanador.Length)
            fichero.Close()

        End If
        ' Empezamos a operar sobre él
        'Dim kk As Byte()
        'kk = New UTF8Encoding(True).GetBytes(1)
        'fichero.Write(kk, 0, kk.Length)
        'fichero.Close()

        Using leer As New StreamReader(pathJ2)
            Dim linea As Integer = leer.ReadToEnd()
            ' MsgBox(linea) debug
            linea += 1
            leer.Close()
            'Metodo para sobreescriir el archivo, el último parámetro True = Append False = sobreescribir
            My.Computer.FileSystem.WriteAllText(pathJ2, linea, False)
        End Using



    End Sub
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
    ' Deshabilitar botones cuando la partida se ha terminado
    Private Sub deshabilitar()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False


    End Sub
    ' Comprobar ganador
    Private Sub checkWinner(ByRef contador As Integer)

        If contador >= 5 And contador <= 9 Then
            If controlGanador(0, 0) = 1 And controlGanador(0, 1) = 1 And controlGanador(0, 2) = 1 Then
                MsgBox("Jugador 1 gana la partida")
                partidasGanadasJugador1()
                deshabilitar()
                'Close()
            ElseIf controlGanador(0, 0) = 1 And controlGanador(1, 0) = 1 And controlGanador(2, 0) = 1
                MsgBox("Jugador 1 gana la partida")
                partidasGanadasJugador1()
                deshabilitar()
                'Close()
            ElseIf controlGanador(0, 0) = 1 And controlGanador(1, 1) = 1 And controlGanador(2, 2) = 1
                MsgBox("Jugador 1 gana la partida")
                partidasGanadasJugador1()
                deshabilitar()
                'Close()
            ElseIf controlGanador(1, 0) = 1 And controlGanador(1, 1) = 1 And controlGanador(1, 2) = 1
                MsgBox("Jugador 1 gana la partida")
                partidasGanadasJugador1()
                deshabilitar()
                'Close()
            ElseIf controlGanador(2, 0) = 1 And controlGanador(2, 1) = 1 And controlGanador(2, 2) = 1
                MsgBox("Jugador 1 gana la partida")
                partidasGanadasJugador1()
                deshabilitar()
                'Close()
            ElseIf controlGanador(2, 0) = 1 And controlGanador(1, 1) = 1 And controlGanador(0, 2) = 1
                MsgBox("Jugador 1 gana la partida")
                partidasGanadasJugador1()
                deshabilitar()
                'Close()
            ElseIf controlGanador(0, 2) = 1 And controlGanador(1, 2) = 1 And controlGanador(2, 2) = 1
                MsgBox("Jugador 1 gana la partida")
                partidasGanadasJugador1()
                deshabilitar()
                'Close()
            ElseIf controlGanador(0, 1) = 1 And controlGanador(1, 1) = 1 And controlGanador(2, 1) = 1
                MsgBox("Jugadr 1 gana la partida")
                partidasGanadasJugador1()
                deshabilitar()
                'Close()
                ' Comprobar Jugador 2
            ElseIf controlGanador(0, 0) = 2 And controlGanador(0, 1) = 2 And controlGanador(0, 2) = 2 Then
                MsgBox("Jugador 2 gana la partida")
                partidasGanadasJugador2()
                deshabilitar()
                'Close()
            ElseIf controlGanador(0, 0) = 2 And controlGanador(1, 0) = 2 And controlGanador(2, 0) = 2
                MsgBox("Jugador 2 gana la partida")
                partidasGanadasJugador2()
                deshabilitar()
                'Close()
            ElseIf controlGanador(0, 0) = 2 And controlGanador(1, 1) = 2 And controlGanador(2, 2) = 2
                MsgBox("Jugador 2 gana la partida")
                partidasGanadasJugador2()
                deshabilitar()
                'Close()
            ElseIf controlGanador(1, 0) = 2 And controlGanador(1, 1) = 2 And controlGanador(1, 2) = 2
                MsgBox("Jugador 2 gana la partida")
                partidasGanadasJugador2()
                deshabilitar()
                'Close()
            ElseIf controlGanador(2, 0) = 2 And controlGanador(2, 1) = 2 And controlGanador(2, 2) = 2
                partidasGanadasJugador2()
                MsgBox("Jugador 2 gana la partida")
                deshabilitar()
                'Close()
            ElseIf controlGanador(2, 0) = 2 And controlGanador(1, 1) = 2 And controlGanador(0, 2) = 2
                MsgBox("Jugador 2 gana la partida")
                partidasGanadasJugador2()
                deshabilitar()
                'Close()
            ElseIf controlGanador(0, 2) = 2 And controlGanador(1, 2) = 2 And controlGanador(2, 2) = 2
                MsgBox("Jugador 2 gana la partida")
                partidasGanadasJugador2()
                deshabilitar()
                'Close()
            ElseIf controlGanador(0, 1) = 2 And controlGanador(1, 1) = 2 And controlGanador(2, 1) = 2
                MsgBox("Jugador 2 gana la partida")
                partidasGanadasJugador2()
                deshabilitar()
                'Close()
            End If
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
        checkWinner(contador)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Reiniciamos el color y ponemos accesible el botón
        Button1.BackColor = BackColor
        Button1.Enabled = True
        Button2.BackColor = BackColor
        Button2.Enabled = True
        Button3.BackColor = BackColor
        Button3.Enabled = True
        Button4.BackColor = BackColor
        Button4.Enabled = True
        Button5.BackColor = BackColor
        Button5.Enabled = True
        Button6.BackColor = BackColor
        Button6.Enabled = True
        Button7.BackColor = BackColor
        Button7.Enabled = True
        Button8.BackColor = BackColor
        Button8.Enabled = True
        Button9.BackColor = BackColor
        Button9.Enabled = True

        ' Reiniciamos el turno
        Label1.Visible = True
        Label2.Visible = False
        ' Volvemos a poner el turno al jugador 1
        turno = 1

        ' Pisamos los datos del array
        ReDim controlGanador(2, 2)

        contador = 0







    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ' Mostramos en una ventana emergente las veces que ha ganado el jugador 1.
        'Si el archivo no existe lo creamos y lo rellenamos con un 0.
        Dim fichero As FileStream
        Dim contGanador As Byte()

        If Not File.Exists(pathJ1) Then

            fichero = File.Create(pathJ1)
            contGanador = New UTF8Encoding(True).GetBytes(0)
            fichero.Write(contGanador, 0, contGanador.Length)
            fichero.Close()

        End If

        Using leer As New StreamReader(pathJ1)
            Dim linea As Integer = leer.ReadToEnd()
            MsgBox(linea)
            leer.Close()
        End Using

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ' Mostramos en una ventana emergente las veces que ha ganado el jugador 2.
        'Si el archivo no existe lo creamos y lo rellenamos con un 0.
        Dim fichero As FileStream
        Dim contGanador As Byte()

        If Not File.Exists(pathJ2) Then

            fichero = File.Create(pathJ2)
            contGanador = New UTF8Encoding(True).GetBytes(0)
            fichero.Write(contGanador, 0, contGanador.Length)
            fichero.Close()

        End If
        Using leer As New StreamReader(pathJ2)
            Dim linea As Integer = leer.ReadToEnd()
            MsgBox(linea)
            leer.Close()
        End Using
    End Sub
End Class
