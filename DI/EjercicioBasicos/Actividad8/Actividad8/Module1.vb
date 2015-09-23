Module Module1
    Dim n1, n2, total As Integer
    Sub EntradaDatos()
        Console.Write("Primer número: ")
        n1 = Integer.Parse(Console.ReadLine())
        Console.Write("Segundo número, recuerda que sea mayor que el primero: ")
        n2 = Integer.Parse(Console.ReadLine())
    End Sub
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Sub limpiar()
        Console.Clear()
    End Sub
    Sub advertencia()
        Console.WriteLine("Primer número menor que el segundo")
    End Sub
    Function CalcularSuma(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        For n1 = n1 To n2
            total = total + n1
        Next
        Return total
    End Function

    Sub Main()
        'Realizar un programa que pida dos valores y
        'calcule la suma de todos los números 
        'comprendidos entre ellos. (el primer número debe 
        'ser menor que el segundo).
        Do
            limpiar()
            EntradaDatos()
            If n1 > n2 Then
                limpiar()
                advertencia()
                pausar()
            End If
        Loop While n1 > n2

        Console.WriteLine("El resultado es: " & CalcularSuma(n1, n2))
        pausar()




    End Sub

End Module
