Module Module1
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Sub Main()
        Dim rnd As Random = New Random()
        Dim nro = rnd.Next(0, 100)
        Dim intentos, n As Integer
        pausar()

        Do
            clear()
            Try
                Console.Write("Introduzca el número: (0-100): ")
                n = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("un número válido por favor")
                intentos -= 1
            End Try
            If n = nro Then
                Console.WriteLine("Has ganado el número era {0}", n)
                pausar()
                intentos = 3
            ElseIf n > nro
                Console.WriteLine("El número que buscamos es más pequeño que {0}", n)
                pausar()
                intentos += 1
            Else
                Console.WriteLine("El número que buscamos es más grande que {0}", n)
                pausar()
                intentos += 1
            End If
        Loop While intentos < 3
        clear()
        Console.WriteLine("Gracias por jugar")
        pausar()


    End Sub

End Module
