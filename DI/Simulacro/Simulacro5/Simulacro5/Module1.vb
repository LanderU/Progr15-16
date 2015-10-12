Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub
    Sub Main()

        ' Introducir tres números a través del teclado. Imprimir un mensaje indicando si los tres números han sido 
        ' introducidos ordenador en secuencia creciente, decreciente o si los tres son iguales. 
        ' Considera que dos de ellos pueden ser iguales.

        Dim n1, n2, n3 As Double
        Dim ok As Boolean
        Do
            clear()
            Try
                Console.Write("Escriba el valor para el primer número: ")
                n1 = Double.Parse(Console.ReadLine())
                ok = True
            Catch ex As Exception
                Console.WriteLine("El tipo de dato introduciodo no es válido.")
                pausar()
                ok = False
            End Try

        Loop While ok = False

        Do
            Try
                clear()
                Console.Write("Escriba el valor para el segundo número: ")
                n2 = Double.Parse(Console.ReadLine())
                ok = True
            Catch ex As Exception
                Console.WriteLine("El tipo de dato introduciodo no es válido.")
                pausar()
                ok = False

            End Try

        Loop While ok = False

        Do
            Try
                clear()
                Console.Write("Escriba el valor para el tercer número: ")
                n3 = Double.Parse(Console.ReadLine())
                ok = True
            Catch ex As Exception
                Console.WriteLine("El tipo de dato introduciodo no es válido.")
                pausar()
                ok = False

            End Try

        Loop While ok = False
        clear()
        If (n3 > n2) And (n2 > n1) Then
            Console.WriteLine("Los números han sido introducidos de manera ascendente: {0}, {1}, {2}.", n1, n2, n3)
            pausar()
        ElseIf (n1 > n2) And (n2 > n3) Then
            Console.WriteLine("Los números han sido introducidos de manera descendente.{0}, {1}, {2}.", n1, n2, n3)
            pausar()
        ElseIf (n1 = n2) Or (n2 = n3) Or (n1 = n3) Then
            Console.WriteLine("Dos de los números son iguales.{0}, {1}, {2}.", n1, n2, n3)
            pausar()
            Console.WriteLine()

        End If



    End Sub

End Module
