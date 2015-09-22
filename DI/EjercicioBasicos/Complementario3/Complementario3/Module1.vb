Module Module1
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        ' Introducir dos números por teclado. Si el número uno es mayor que el número dos mostrar
        ' por pantalla el resultado de la resta. Independientemente de si el uno es mayor o no,
        ' también queremos visualizar la suma de los dos números.
        Dim n1, n2 As Double
        Console.Write("Escriba un número: ")
        n1 = Double.Parse(Console.ReadLine())
        Console.Write("Introduzca otro número: ")
        n2 = Double.Parse(Console.ReadLine())

        If n1 > n2 Then
            Console.WriteLine("El resultado de restar {0}, y {1} es: " & n1 - n2, n1, n2)
            pausar()
        End If
        Console.WriteLine("La suma de {0} y de {1} es: " & n1 + n2, n1, n2)
        pausar()
    End Sub

End Module
