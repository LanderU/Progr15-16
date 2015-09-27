Module Module1
    Dim cantidad, n, index, total As Integer
    Sub EntradaDatos()
        Console.Write("Escriba la cantidad de números deseada: ")
        cantidad = Integer.Parse(Console.ReadLine())
    End Sub
    Sub advertencia()
        Console.WriteLine("Escriba un número entero.")
    End Sub
    Function Calcular(ByRef n) As Integer
        index = 0
        total = 1
        While index < cantidad
            Console.Write("Escriba el número a multiplicar: ")
            n = Integer.Parse(Console.ReadLine())
            total *= n
            index += 1
        End While
        Return total
    End Function
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Sub limpiar()
        Console.Clear()
    End Sub
    Sub mostrarTotal(total)
        Console.WriteLine("El total de las multiplicaciones es: " & total)
    End Sub

    Sub Main()
        'Escribe un programa que pida al usuario un
        'número concreto de valores enteros (el usuario nos
        'dirá cuantos) y nos muestre en pantalla el resultado 
        'acumulado de multiplicar todos ellos.
        EntradaDatos()
        limpiar()
        Calcular(n)
        limpiar()
        mostrarTotal(total)
        pausar()


    End Sub

End Module
