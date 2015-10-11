Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub
    Sub Main()
        ' Introducir dos números por teclado. Si el número uno es mayor que el número dos mostrar por pantalla el resultado de la resta. 
        ' Independientemente de si el uno es mayor o no, también queremos visualizar la suma de los dos números.
        Dim n1, n2 As Double
        Dim correcto As Boolean = True
        Do
            clear()
            Try
                Console.Write("Escriba el valor para el primer número: ")
                n1 = Double.Parse(Console.ReadLine())
                correcto = True
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no compatible.")
                correcto = False
                pausar()
            End Try
        Loop While correcto = False
        correcto = True
        Do
            clear()
            Try
                Console.Write("Escriba el valor para el segundo número: ")
                n2 = Double.Parse(Console.ReadLine())
                correcto = True
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no compatible.")
                correcto = False
                pausar()
            End Try
        Loop While correcto = False

        If n1 > n2 Then
            clear()
            Console.WriteLine("El resultado de restar {0} menos {1}, es: " & (n1 - n2), n1, n2)
            pausar()
        End If
        clear()
        Console.WriteLine("El resultado de sumar {0} y {1}, es: " & (n1 + n2), n1, n2)
        pausar()

    End Sub

End Module
