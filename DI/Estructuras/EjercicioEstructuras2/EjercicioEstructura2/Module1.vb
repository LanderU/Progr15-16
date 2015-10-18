Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub

    Structure asignaturas
        Dim nomAsig As String
        Dim nota As String
    End Structure

    Sub Main()

        ' Desarrollar un programa que permita guardar las notas de
        ' los alumnos.El programa debe ir pidiendo el nombre del 
        ' alumno, las asignaturas de las que está matriculado y la 
        ' nota obtenida en cada una de ellas. Hay que tener en 
        ' cuenta que hay seis posibles asignaturas, pero no todos
        ' los alumnos están matriculados de todas.

        Dim al As Integer

        Do
            clear()
            Try
                Console.Write("Número de alumnos a matricular: ")
                al = Integer.Parse(Console.ReadLine()) - 1
                If al < 0 Then
                    Console.WriteLine("Al menos tiene que matricular un alumno.")
                    pausar()
                End If
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no válido")
                al = -1
            End Try

        Loop While al < 0

        Dim alumnos(al) As String
        Dim numAsig As Integer
        ' Array de las asignaturas de las cuales elegiremos
        Dim posiblesAsignaturas() As String = {"VB", "JAVA", "SO", "ENDE", "PDM"}
        ' Array escalonada en la que guardaremos en la primera dimensión el alumno y en la segunda las asignaturas y sus notas
        Dim matriculaAlumnos(al)() As asignaturas
        ' Rellenamos con los datos
        For i As Integer = 0 To alumnos.Length - 1
            Console.Write("Nombre del alumno: ")
            alumnos(i) = Console.ReadLine()
            Do
                Console.Write("Cantidad de asignaturas en la que está matriculado: ")
                numAsig = Integer.Parse(Console.ReadLine()) - 1

            Loop While (numAsig > posiblesAsignaturas.Length) Or (numAsig < posiblesAsignaturas.GetLowerBound(0))
            ' Introducimos la cantidad de asignaturas que va a tener ese alumno.
            matriculaAlumnos(i) = New asignaturas(numAsig) {}
            For asig As Integer = 0 To numAsig
                Console.Write("Nombre de la asignatura: ")
                matriculaAlumnos(i)(asig).nomAsig = Console.ReadLine()
                Console.Write("Nota obtenida en esa asignatura: ")
                matriculaAlumnos(i)(asig).nota = Console.ReadLine()
            Next
        Next

        For i As Integer = 0 To alumnos.Length() - 1
            clear()
            Console.WriteLine("Las notas para el alumno: " + alumnos(i))
            For x As Integer = 0 To numAsig
                Console.WriteLine("Nombre de la asignatura: " + matriculaAlumnos(i)(x).nomAsig)
                Console.WriteLine("Nota obtenida: " + matriculaAlumnos(i)(x).nota)
                pausar()
                

            Next
        Next




    End Sub

End Module
