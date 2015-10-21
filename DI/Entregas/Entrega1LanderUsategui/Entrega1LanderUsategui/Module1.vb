Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub

    Sub Main()
        '1:Crea	 un	 matriz.	 Pide	 que	 se	 introduzca el	 número	 de	 elementos	 la
        'matriz.Cuando  terminemos	de	introducirlos	los	visualizaremos	ordenados.

        Dim cant As Integer
        Do
            clear()
            Try
                Console.Write("Cantidad de posiciones del array: ")
                cant = Integer.Parse(Console.ReadLine())
                If cant <= 0 Then
                    Console.WriteLine("Prueba otra vez.")
                    pausar()
                End If
            Catch ex As Exception
                Console.WriteLine("No es un número")
                cant = -1

            End Try
        Loop While cant <= 0

        Dim matriz As New ArrayList()
        Dim index As Integer = 0
        While index < cant
            Console.Write("Introduzca el dato: ")
            matriz.Add(Console.ReadLine())
            index += 1
        End While
        clear()
        Console.WriteLine("Mostramos los datos ordenados")
        matriz.Sort()
        Dim mostrar As Object
        For Each mostrar In matriz
            Console.WriteLine(mostrar)
            pausar()
        Next


    End Sub

End Module
