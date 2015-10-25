Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub


    Sub Main()
        'Realiza    un	 programa	 que	 lea	 una	 lista	 de	 valores	 introducidos por	 el
        'teclado. A   continuación, y	 sobre	 la	 lista, se	 tienen que	 buscar	 los	 valores	
        'máximo  y	mínimo	y	mostrarlos	por	pantalla

        Dim lista As New ArrayList
        Dim continuar As String = "s"

        Do
            clear()
            Console.Write("Introduzca el valor en la lista: ")
            lista.Add(Console.ReadLine())
            Console.Write("Añadir más valores a la lista s/n: ")
            continuar = Console.ReadLine().ToLower
        Loop While continuar <> "n"

        lista.Sort()
        Console.WriteLine(lista(0))
        pausar()
        pausar()
        lista.Reverse()
        Console.WriteLine(lista(0))
        pausar()
        pausar()
    End Sub

End Module
