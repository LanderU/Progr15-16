Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub
    Sub Main()

        ' Introducir a través del teclado un número entero positivo y distinto de 0.
        ' Posteriormente imprimir un mensaje indicando si ese número es par o impar.

        Dim n As Integer
        Do
            clear()
            Console.Write("Introduzca un número entero positivo y distinto de 0: ")
            Try
                n = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Número no válido vuelva a intetntarlo.")
                pausar()
                n = 0
            End Try

        Loop While n <= 0
        clear()
        If n Mod 2 = 0 Then
            Console.WriteLine("{0}, es un número par.", n)
            pausar()
        Else
            Console.WriteLine("{0}, es un número impar", n)
            pausar()
        End If


    End Sub

End Module
