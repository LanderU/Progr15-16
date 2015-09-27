Module Module1
    Function ToDo(ByRef n1, ByRef n2, ByRef n3) As String
        Console.Write("Intrduzca el primero de los numeros: ")
        n1 = Integer.Parse(Console.ReadLine())
        Console.Write("Introduzca el valor del segundo de los numeros: ")
        n2 = Integer.Parse(Console.ReadLine())
        Console.Write("Introduzca el valor del tercer número: ")
        n3 = Integer.Parse(Console.ReadLine())
        limpiar()
        If (n3 > n2) And (n2 > n1) Then
            Return "Introducidos de manera creciente"
        ElseIf (n1 > n2) And (n2 > n3) Then
            Return "Introducidos de manera decreciente"
        ElseIf (n1 = n2) And (n2 = n3)
            Return "Los tres son iguales"
        ElseIf n1 = n2 Or n1 = n3 Or n2 = n3
            Return "Dos de los números introducidos son iguales"
        End If

    End Function
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Sub limpiar()
        Console.Clear()
    End Sub

    Sub Main()
        ' Introducir tres números a través del teclado. Imprimir un mensaje indicando si los tres
        ' números han sido introducidos ordenados en secuencia creciente, decreciente, o si los tres
        ' son iguales.Considera que dos de ellos puedan ser iguales.
        Dim n1, n2, n3 As Integer
        Console.WriteLine(ToDo(n1, n2, n3))
        pausar()

    End Sub

End Module
