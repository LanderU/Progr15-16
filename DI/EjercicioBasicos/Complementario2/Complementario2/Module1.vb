Module Module1
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        ' Introducir a través del teclado un número entero positivo y distinto de cero. Posteriormente
        ' imprimir un mensaje indicando si ese número es par o impar.

        Console.Write("Introduzca un valor entero: ")
        Dim n As Integer = Integer.Parse(Console.ReadLine())
        If n <= 0 Then
            Console.WriteLine("Número incorrecto")
            pausar()

        Else
            If n Mod 2 = 0 Then
                Console.WriteLine("El número {0}, es par", n)
                pausar()

            Else
                Console.WriteLine("El número {0}, es impar", n)
                pausar()
            End If
        End If

    End Sub

End Module
