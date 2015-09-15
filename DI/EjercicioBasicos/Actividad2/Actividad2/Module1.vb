Module Module1

    Sub Main()

        Dim r1, r2, r3, total As Double
        Console.Write("Introduzca el valor para la resistencia: ")
        r1 = Convert.ToDouble(Console.ReadLine())
        Console.Write("Introduzca el valor para la segunda resistencia: ")
        r2 = Convert.ToDouble(Console.ReadLine())
        Console.Write("Introduzca el valor para la tercer resistencia: ")
        r3 = Convert.ToDouble(Console.ReadLine())
        total = 1 / (1 / r1 + 1 / r2 + 1 / r3)
        Console.WriteLine("El resultado es: " + total.ToString())
        Console.WriteLine("Pulse una tecla para salir.")
        Console.ReadKey()

    End Sub

End Module
