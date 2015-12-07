Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub entradaDatos()
        Dim dato As String

        Do
            Console.Write("Escriba un número: ")
            dato = Console.ReadLine()
            If leerEntero(dato) Then
                If dato < 8 Then
                    Console.WriteLine("Tienes que meter un dato mayor o igual que 8")
                End If
            End If
        Loop While dato < 8
        procesoMultiplosOcho(dato)
    End Sub
    Function leerEntero(ByRef dato) As Boolean
        Try
            Integer.Parse(dato)
        Catch ex As Exception
            clear()
            Console.WriteLine("Dato no válido prueba de nuevo")
            pausar()
            dato = -1
        End Try
        If dato = -1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub procesoMultiplosOcho(ByRef dato)
        clear()
        Dim i As Integer = 8
        While i <= dato
            If dato Mod i = 0 Then
                Console.WriteLine(i & "-->Es multiplo de 8")
                pausar()
            End If
            i += 1
        End While
    End Sub
    Sub Main()
        'Llamada a la entrada de datos
        entradaDatos()

    End Sub

End Module
