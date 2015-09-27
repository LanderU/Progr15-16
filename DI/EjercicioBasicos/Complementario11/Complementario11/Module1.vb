Module Module1
    Sub pausar()
        Threading.Thread.Sleep(1000)
    End Sub

    Sub Main()
        ' Visualiza todos los números del 1 al 1000 ambos incluidos.
        Dim n As Integer = 1
        Dim n2 As Integer = 100

        For n = n To n2
            Console.WriteLine(n)
            pausar()

        Next

    End Sub

End Module
