Module Module1
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        ' Introducir por teclado un número comprendido entre el 1 y el 7 e imprimir el día de la semana al que hace referencia.
        Dim dia As Integer

        Do
            clear()
            Try
                Console.Write("Escriba el día de la semana (1-7): ")
                dia = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no válido.")
                pausar()
                dia = 0
            End Try

        Loop While dia < 1 Or dia > 7

        Select Case dia
            Case 1
                clear()
                Console.WriteLine("El día seleccionado es el LUNES.")
                pausar()
            Case 2
                clear()
                Console.WriteLine("El día seleccionado es el MARTES.")
                pausar()
            Case 3
                clear()
                Console.WriteLine("El día seleccionado es el MIÉRCOLES.")
                pausar()
            Case 4
                clear()
                Console.WriteLine("El día seleccionado es el JUEVES.")
                pausar()
            Case 5
                clear()
                Console.WriteLine("El día seleccionado es el VIERNES.")
                pausar()
            Case 6
                clear()
                Console.WriteLine("El día seleccionado es el SÁBADO.")
                pausar()
            Case 7
                clear()
                Console.WriteLine("El día seleccionado es el DOMINGO.")
                pausar()
        End Select

    End Sub

End Module
