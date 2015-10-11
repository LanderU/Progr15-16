Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub
    Sub Main()

        'Introducir tres números por teclado. Indicar mediante un mensaje, cual es el más pequeño de los tres.

        Dim n1, n2, n3 As Double
        Dim min As Double = 9999999999
        Dim correcto As Boolean

        Do
            clear()
            Try
                Console.Write("Escriba el primer número: ")
                n1 = Double.Parse(Console.ReadLine())
                correcto = True
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no válido")
                correcto = False
                pausar()

            End Try

        Loop While correcto = False

        If n1 < min Then
            min = n1
        End If

        Do
            clear()
            Try
                Console.Write("Escriba el segundo número: ")
                n2 = Double.Parse(Console.ReadLine())
                correcto = True
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no válido")
                correcto = False
                pausar()

            End Try
        Loop While correcto = False

        If n2 < min Then
            min = n2
        End If

        Do
            clear()
            Try
                Console.Write("Escriba el tercer número: ")
                n3 = Double.Parse(Console.ReadLine())
                correcto = True
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no válido")
                correcto = False
                pausar()

            End Try
        Loop While correcto = False

        If n3 < min Then
            min = n3
        End If
        Console.WriteLine("El número más pequeño que usted ha introducido es: " & min)
        pausar()




    End Sub

End Module
