Module Module1
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub


    Sub Main()
        ' Crea    una	matriz	con	los	nombre	de	todos	los	alumnos	de	clase.	Se	pide	el
        ' número  de	alumnos	de	clases	y	sus	nombres.	Podremos	interrumpir	la	entrada	
        ' de   datos	 pulsando	 [Ctrl][Z] ([Ctrl][Z] =	 nothing).	 Se	 preguntará	 si	 se	 desea	
        ' visualizar  la	lista	completa, en	cualquier	caso	se	podrá	introducir	un	número	y
        ' nos devolverá el	nombre	del	alumnos	que	se	tecleó	en	esa	posición.

        Dim alumnos() As String

        Dim numAlumnos As Integer

        Dim tecla As String

        Do
            clear()
            Try
                Console.Write("Escriba la cantidad de alumnos a matricular: ")
                numAlumnos = Integer.Parse(Console.ReadLine()) - 1
                If numAlumnos < 0 Then
                    Console.WriteLine("Vuelve a intentarlo.")
                    pausar()
                End If
            Catch ex As Exception
                Console.WriteLine("Dato no válido.")
                numAlumnos = Integer.MinValue
                pausar()
            End Try

        Loop While numAlumnos < 0

        ReDim alumnos(numAlumnos)

        clear()

        For k As Integer = 0 To numAlumnos
            Console.Write("Introduzca el nombre del alumno: ")
            tecla = Console.ReadLine()
            If tecla = Nothing Then
                Exit For
            Else
                alumnos(k) = tecla
            End If
        Next
        Dim i As Integer = 0

        While alumnos(i) <> Nothing
            Console.WriteLine(alumnos(i))
            pausar()
            i += 1
        End While



    End Sub

End Module
