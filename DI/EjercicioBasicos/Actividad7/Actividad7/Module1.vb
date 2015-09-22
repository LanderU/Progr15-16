Module Module1
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        'Escribe un programa que pida al usuario un
        'número concreto de valores enteros (el usuario nos 
        'dirá cuantos) y nos muestre en pantalla el resultado 
        'acumulado de multiplicar todos ellos.
        Dim cant, total, index, n As Integer
        Console.Write("Escriba el número de números que va a introducir: ")
        cant = Integer.Parse(Console.ReadLine())
        Console.Clear()
        index = 0
        total = 1
        While index < cant
            Console.Write("Escriba el número: ")
            n = Integer.Parse(Console.ReadLine())
            If n <= 0 Then
                Do
                    Console.Clear()
                    Console.WriteLine("Escriba un número entero.")
                    Console.Write("Introduzca el número: ")
                    total = Integer.Parse(Console.ReadLine())
                Loop While total <= 0
                total *= total
            Else

                total *= n
            End If
            index += 1
        End While
        Console.Clear()
        Console.WriteLine("El total es de: " & total)
        pausar()


    End Sub

End Module
