Module Module1
    Function comprobaciones(ByRef n1, ByRef n2) As String
        Console.Write("Introduzca un número: ")
        n1 = Double.Parse(Console.ReadLine())
        Console.Write("Introduzca el segundo número: ")
        n2 = Double.Parse(Console.ReadLine())
        limpiar()
        If n1 > n2 Then
            Return "El número uno es mayor que el dos"
        ElseIf n2 > n1
            Return "El número dos es mayor que el uno"
        Else
            Return "Ambos son iguales"
        End If
    End Function
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Sub limpiar()
        Console.Clear()
    End Sub

    Sub Main()
        ' Introducir dos números por teclado e imprimir un mensaje indicando si el número
        ' es mayor, menor o igual que el número dos.
        Dim n1, n2 As Double
        Console.WriteLine(comprobaciones(n1, n2))
        pausar()

    End Sub




End Module
