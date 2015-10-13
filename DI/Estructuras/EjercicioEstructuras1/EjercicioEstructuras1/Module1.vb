Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub limpiar()
        Console.Clear()
    End Sub

    Sub Main()
        ' Crea un arrayList con los nombres de 10 alumnos de
        ' clase.Muéstralos ordenados alfabéticamente de forma 
        ' ascendente.Muéstralos en forma descendente. Inserta 
        ' en la primera posición una etiqueta con el código del 
        ' curso y el nombre del tutor. Busca dentro del arrayList 
        ' un nombre que te introducirán desde el teclado y le 
        ' indicaras si está o no en la lista.

        Dim nombreClase As New ArrayList()
        Dim index As Integer = 0
        While index < 2
            limpiar()
            Console.Write("Escriba el nombre de la persona: ")
            nombreClase.Add(Console.ReadLine())
            index += 1
        End While

        nombreClase.Sort()

        Dim obj As Object
        For Each obj In nombreClase
            Console.WriteLine(obj)
            pausar()
        Next
        nombreClase.Reverse()
        limpiar()
        For Each obj In nombreClase
            Console.WriteLine(obj)
            pausar()
        Next
        limpiar()
        nombreClase.Insert(0, "Asignatura: DAM Profesora: Ane")
        nombreClase.Sort()
        For Each obj In nombreClase
            Console.WriteLine(obj)
            pausar()
        Next
        limpiar()
        Console.Write("Escribe el nombre de la persona a buscar: ")
        Dim buscar As String = Console.ReadLine()
        Dim ind As Integer = nombreClase.BinarySearch(buscar)

        If ind < 0 Then
            limpiar()
            Console.WriteLine("El " + buscar + " no está en el arrayList")
            pausar()
        Else
            limpiar()
            Console.WriteLine("El " + buscar + "  está en el arrayList")
            pausar()
        End If

        If nombreClase.Contains(buscar) Then
            limpiar()
            Console.WriteLine("El " + buscar + " está en el arrayList")
            pausar()
        Else
            limpiar()
            Console.WriteLine("El " + buscar + " no está en el arrayList")
            pausar()
        End If


    End Sub

End Module
