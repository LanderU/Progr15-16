Module Module1
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        ' Crea    un	programa	que	lea la	nota	media	obtenida	por	cada	alumnos	del
        ' curso y la almacene	en	una	matriz.	El	programa	pedirá	el	número	de	alumnos	
        ' de clase	 y	 sus	 correspondiente	 nota	 media.	 Después	 recorreremos	 la	 matriz		
        ' para  calcular	la	media	del	curso	y	se		visualizará	por	pantalla

        Dim alumnos() As Integer = {}
        Dim numAlum As Integer

        Do
            clear()
            Try
                Console.Write("Cantidad de alumnos: ")
                numAlum = Integer.Parse(Console.ReadLine()) - 1
                If numAlum < 0 Then
                    Console.WriteLine("Prueba otra vez.")
                    pausar()
                End If
            Catch ex As Exception
                Console.WriteLine("Dato no valido, prueba de nuevo.")
                pausar()
                numAlum = -1

            End Try

        Loop While numAlum < 0

        ReDim alumnos(numAlum)

        For i As Integer = 0 To alumnos.Length - 1
            Dim nota As Integer
            Do
                clear()
                Try
                    Console.Write("Escriba la nota: ")
                    nota = Integer.Parse(Console.ReadLine())
                Catch ex As Exception
                    Console.WriteLine("Dato no válido.")
                    nota = -1

                End Try

            Loop While nota < 0
            alumnos(i) = nota
        Next

        Console.WriteLine("Mostramos la nota media del curso")

        Dim totalNotas As Integer = 0

        For i As Integer = 0 To alumnos.Length - 1
            totalNotas += alumnos(i)
        Next
        clear()
        Console.WriteLine("La nota media del curso es de: " & totalNotas / alumnos.Length)
        pausar()
    End Sub

End Module
