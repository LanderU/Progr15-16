Module Module1
    Function semana(ByRef n) As String
        Console.Write("Introduzca el día de la semana: ")
        n = Integer.Parse(Console.ReadLine())
        If (n < 1) Or (n > 7) Then
            Do
                limpiar()
                Console.Write("Día de la semana invalido, recuerda que la semana va entre los números 1-7")
                pausar()
                limpiar()
                Console.Write("Introduzca el día de la semana: ")
                n = Integer.Parse(Console.ReadLine())
            Loop While n < 1 Or n > 7
        End If
        limpiar()
        Select Case n
            Case 1
                Return "Lunes"
            Case 2
                Return "Martes"
            Case 3
                Return "Miércoles"
            Case 4
                Return "Jueves"
            Case 5
                Return "Viernes"
            Case 6
                Return "Sábado"
            Case 7
                Return "Domingo"
        End Select
    End Function
    Sub limpiar()
        Console.Clear()
    End Sub
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        'Introducir por teclado un número comprendido entre el 1 y el 7 e imprimir el día de la
        'semana al que hace referencia.
        Dim n As Integer
        Console.WriteLine(semana(n))
        pausar()

    End Sub

End Module
