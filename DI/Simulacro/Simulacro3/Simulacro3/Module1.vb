Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub

    Sub Main()
        ' Introducir dos números por teclado e impimir un mensaje si el número uno es mayor, menor o igual que el número dos.

        Dim n1, n2 As Double
        Dim correcto As Boolean

        Do
            clear()
            Try
                Console.Write("Introduzca el primero número: ")
                n1 = Double.Parse(Console.ReadLine())
                correcto = True
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no válido.")
                pausar()
                correcto = False
            End Try
        Loop While correcto = False

        Do
            clear()
            Try
                Console.Write("Introduzca el segundo número: ")
                n2 = Double.Parse(Console.ReadLine())
                correcto = True
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no válido.")
                pausar()
                correcto = False
            End Try
        Loop While correcto = False
        clear()
        If n1 > n2 Then
            Console.WriteLine("El primer número {0}, es mayor que el segundo número {1}.", n1, n2)
            pausar()
        ElseIf n1 < n2 Then
            Console.WriteLine("El primer número {0}, es más pequeño que el segundo {1}.", n1, n2)
            pausar()
        Else
            Console.WriteLine("Los dos números son iguales, {0} y {1}.", n1, n2)
            pausar()
        End If

    End Sub

End Module
