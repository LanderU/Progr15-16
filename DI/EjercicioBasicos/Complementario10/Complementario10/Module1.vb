Module Module1
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Sub limpiar()
        Console.Clear()
    End Sub

    Sub Main()
        ' Realiza un programa que visualice 25 nombres introducidos por teclado.
        Dim nombres(24) As String
        Dim index As Integer = 0

        While index < nombres.Length
            Console.Write("Nombre a introducir: ")
            nombres(index) = Console.ReadLine()
            index += 1
        End While
        index = 0
        limpiar()
        While index < nombres.Length
            Console.WriteLine(nombres(index))
            pausar()
            index += 1
        End While

    End Sub

End Module
