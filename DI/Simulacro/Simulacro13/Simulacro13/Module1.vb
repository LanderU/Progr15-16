Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub

    Sub Main()
        ' Realizar un programa que calcule e imprima la suma de los múltiplos de 5 comprendidos entre dos valores "a" y "b".
        ' El programa no permitirá introducir valores negativos para "a" y "b", verificar que "a" es menor que "b". Si "a" es mayor que "b" intercambiar sus valores.

        Dim a, b, suma, aux As Integer

        Do
            clear()
            Try
                Console.Write("Introduzca un número: ")
                a = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Algo va mal...")
                pausar()
                a = -1
            End Try
        Loop While a < 0

        Do
            clear()
            Try
                Console.Write("Introduzca un número: ")
                b = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Algo va mal...")
                pausar()
                b = -1
            End Try
        Loop While b < 0

        If a > b Then
            aux = a
            a = b
            b = aux
        End If
        Dim index As Integer
        While a <= b
            If index Mod 5 = 0 Then
                suma += index
            End If
        End While
        clear()
        Console.WriteLine("La suma de los multiplos de 5 que hay entre {0} y {1}, es: " & suma, a, b)
        pausar()






    End Sub

End Module
