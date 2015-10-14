Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub

    Structure asignaturas
        Dim nomAsig As String
        Dim nota As Integer
    End Structure

    Sub Main()

        ' Desarrollar un programa que permita guardar las notas de
        ' los alumnos.El programa debe ir pidiendo el nombre del 
        ' alumno, las asignaturas de las que está matriculado y la 
        ' nota obtenida en cada una de ellas. Hay que tener en 
        ' cuenta que hay seis posibles asignaturas, pero no todos
        ' los alumnos están matriculados de todas.
        ' Creamos el array alumnos
        Dim alumnos() As String
        ' Array de las asignaturas de las cuales elegiremos
        Dim posiblesAsignaturas() As String = {"VB", "JAVA", "SO", "ENDE", "PDM"}
        ' Array escalonada en la que guardaremos en la primera dimensión el alumno y en la segunda las asignaturas y sus notas
        Dim matriculaAlumnos()() As asignaturas

        Console.Write("Nombre del alumno: ")
        alumnos(0) = Console.ReadLine()

        Console.Write("Seleccione el número de notas: ")
        Dim numAsignaturas As Integer = Console.ReadLine()

        matriculaAlumnos(0) = New asignaturas(numAsignaturas) {}
        matriculaAlumnos(0)(0).nomAsig = "VB"
        matriculaAlumnos(0)(0).nota = 5




    End Sub

End Module
