Module Module1
    Function comprobar(n, n2, n3) As Double
        Dim menor As Double = 999999999999999999
        Console.Write("Introduzca un número: ")
        n = Double.Parse(Console.ReadLine())
        Console.Write("Introduzca otro número: ")
        n2 = Double.Parse(Console.ReadLine())
        Console.Write("Introduzca el último número: ")
        n3 = Double.Parse(Console.ReadLine())
        If n < menor Then
            menor = n
        End If
        If n2 < menor Then
            menor = n2
        End If
        If n3 < menor Then
            menor = n3
        End If
        Return menor
    End Function

    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Sub Main()
        ' Introducir tres números por teclado. Indicar mediante un mensaje, cual es el mas pequeño
        ' de los tres.
        Dim n, n2, n3 As Double
        Console.WriteLine("El número más pequeño de los introducidos es: " & comprobar(n, n2, n3))
        pausar()


    End Sub

End Module
