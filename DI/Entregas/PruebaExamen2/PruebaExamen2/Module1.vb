Module Module1
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub entradaDeDatoConAjusteArray()
        Dim dato As String
        Dim arrayRandom() As Object
        Do
            clear()
            Console.Write("Escriba el tamaño del array: ")
            dato = Console.ReadLine()
            If leerEntero(dato) = False Then
                dato = -1
            End If
        Loop While dato = -1

        ReDim arrayRandom(dato - 1)
        rellenarArray(arrayRandom)
        imprimirArray(arrayRandom)


    End Sub

    Private Function leerEntero(ByRef dato) As Boolean
        Try
            Integer.Parse(dato)
        Catch ex As Exception
            Console.WriteLine("Dato no válido, prueba de nuevo")
            pausar()
            dato = -1
        End Try
        If dato = -1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub rellenarArray(ByRef arrayRandom())
        Dim aleatorio As Random = New Random()

        For i As Integer = 0 To arrayRandom.GetUpperBound(0)
            arrayRandom(i) = aleatorio.Next(0, 501)
        Next

    End Sub
    Private Sub imprimirArray(ByRef arrayRandom)
        clear()
        Console.WriteLine("Orden de entrada de los datos: ")
        For l As Integer = 0 To arrayRandom.getUpperBound(0)
            Console.WriteLine("Posicion: " & l + 1 & " " & arrayRandom(l))
            pausar()
        Next
        Console.WriteLine("Orden inverso de entrada de los datos: ")

        Dim i As Integer = arrayRandom.GetUpperBound(0)

        While i >= 0
            Console.WriteLine("En la posición: " & i + 1 & " " & arrayRandom(i))
            pausar()
            i -= 1

        End While

        imprimirMaximoMinimo(arrayRandom)

    End Sub

    Private Sub imprimirMaximoMinimo(ByVal arrayRandom())
        Console.WriteLine("El máximo del array es: " & arrayRandom.Max)
        Console.WriteLine("El mínimo del array es: " & arrayRandom.Min)
        pausar()
    End Sub

    Sub Main()
        entradaDeDatoConAjusteArray()
    End Sub

End Module
