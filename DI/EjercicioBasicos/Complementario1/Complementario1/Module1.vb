Module Module1

    Sub Main()
        REM Introducir a través del teclado dos números. Si el número uno es mayor que el segundo,
        REM mostrar por pantalla el resultado de restar al número uno el número dos.

        Dim n1, n2 As Double
        Console.Write("Escriba un número: ")
        n1 = Double.Parse(Console.ReadLine())
        Console.Write("Escriba otro número: ")
        n2 = Double.Parse(Console.ReadLine())
        If n1 > n2 Then
            Console.WriteLine("Restamos a {0}, {1}, " & n1 - n2, n1, n2 & " Pulse cualquier tecla para salir")
            Console.ReadKey()
        Else
            Console.WriteLine("El ejercicio no dice que se haga nada, tecla para salir")
            Console.ReadKey()
        End If
    End Sub

End Module
