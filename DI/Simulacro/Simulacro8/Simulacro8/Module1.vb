Module Module1
    Private Sub clear()
        Console.Clear()
    End Sub

    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        ' En la venta de una revista, aquellos que siendo socios tengan una antigüedad superior a los 5 años se les hace un descuento del 10% y a los socios que sean estudiantes se les hace un descuento del 20%. 
        ' Los descuentos no pueden acumularse. En caso de coincidir se elige el descuento mayor. 
        ' Calcular e imprimir lo que hay que cobrar por la revista a una persona, teniendo en cuenta que los datos que se introducirán desde el teclado son: 
        ' nombre de la persona, precio de la revista, si es o no socio, los años de antigüedad y si es o no estudiante.
        Dim nombre, estudiante, socio As String
        Dim ok As Boolean
        Dim precioRevista, descuento As Double
        Dim anti As Integer

        Console.Write("Escriba su nombre: ")
        nombre = Console.ReadLine()

        Do
            clear()
            Try
                Console.Write("Precio de la revista: ")
                precioRevista = Double.Parse(Console.ReadLine())
                ok = True
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no válido.")
                pausar()
                ok = False
            End Try
        Loop While ok = False

        Do
            clear()
            Try
                Console.Write("Es usted socio (S/N): ")
                socio = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo está pasando vuelve a probar.")
                socio = "kk"
                pausar()
            End Try

        Loop While (socio <> "s") And (socio <> "S") And (socio <> "N") And (socio <> "n")

        Do
            clear()
            Try
                Console.Write("Es usted estudiante (S/N): ")
                estudiante = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo está pasando vuelve a probar.")
                pausar()
                estudiante = "kk"
            End Try

        Loop While (estudiante <> "s") And (estudiante <> "S") And (estudiante <> "N") And (estudiante <> "n")

        If (socio = "S" Or socio = "s") And Not (estudiante = "s" Or estudiante = "S") Then
            Do
                clear()
                Try
                    Console.Write("Años de socio con nosotros: ")
                    anti = Integer.Parse(Console.ReadLine())
                Catch ex As Exception
                    Console.WriteLine("Tipo de dato no válido, pruebe otra vez.")
                    pausar()
                    anti = -1
                End Try
            Loop While anti < 0
        End If

        If (socio = "s" Or socio = "S") And (estudiante = "s" Or estudiante = "S") Then
            descuento = precioRevista * 0.2
            precioRevista -= descuento
        ElseIf (socio = "s" Or socio = "S") And anti > 5
            descuento = precioRevista * 0.1
            precioRevista -= descuento
        End If
        clear()
        Console.WriteLine("Cliente " + nombre + " el total a pagar: {0}", precioRevista)
        pausar()

    End Sub

End Module
