Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        '  Crea     una	 matriz	 de	 dos	 dimensiones	 	 y	 a	 continuación	 escribe	 la	 suma
        ' correspondiente  a	 las	 filas	 de	 la	 matriz	 y	 a	 las	 columnas.	 Se	 pedirá	 que	
        ' introduzca el	 número	 de	 fila	 y	 el	 número	 de	 columnas a	 sumar.	 Visualiza	 la	
        ' matriz  junto	a	las	sumas

        Dim array(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        For fila As Integer = 0 To array.GetUpperBound(0)
            For columna As Integer = 0 To array.GetUpperBound(1)
                Console.WriteLine("En la posicion {0}-{1} tenemos: " & array(fila, columna), fila, columna)
                pausar()
            Next
        Next
        Dim filSumar As Integer
        Dim colSumar As Integer
        Console.Write("Fila para sumar: ")
        'filSumar = Integer.Parse(Console.ReadLine())
        ' colSumar = Integer.Parse(Console.ReadLine())

        For i As Integer = 0 To array.GetUpperBound(0)
            Console.WriteLine(array(i, i))
            pausar()
        Next



    End Sub

End Module
