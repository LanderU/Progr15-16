Module Module1
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()

        ' Calcular e imprimir el importe que hay que cobrar a un cliente que compra artículos en un almacén.
        ' Através del teclado nos van a introducir los siguientes datos: precio de compra del artículo, el número de unidades que compra, se introducirá (S/N) indicando si el producto está envasado,
        ' si se paga o no al contado y si el cliente es mayorista o no. Para hacer el cálculo tenemos que tener en cuenta los siguientes datos: si el artículo está encasado se cobra un 5% más,
        ' si el cliente es mayorista se hace un descuento del 20% y si la forma de pago es al contado se hace un descuento del 5%. Los descuentos son acumulativos.

        Dim cantidad As Integer
        Dim precioUnitario, total, descuento As Double
        Dim contado, envasado, mayorista As String

        Do
            clear()
            Try
                Console.Write("Cantidad de producto comprado: ")
                cantidad = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no válido vuelve a intentarlo.")
                pausar()
                cantidad = 0
            End Try

        Loop While cantidad <= 0

        Do
            clear()
            Try
                Console.Write("Introduzca el precio unitario del producto: ")
                precioUnitario = Double.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Tip de dato no válido.")
                pausar()
                precioUnitario = 0

            End Try

        Loop While precioUnitario <= 0

        Do
            clear()
            Try
                Console.Write("Producto envasado (S/N): ")
                envasado = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo raro está pasando prueba otra vez.")
                pausar()
                envasado = "kk"
            End Try

        Loop While (envasado <> "s") And (envasado <> "S") And (envasado <> "n") And (envasado <> "N")

        Do
            clear()
            Try
                Console.Write("Producto mayorista (S/N): ")
                mayorista = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo raro está pasando prueba otra vez.")
                pausar()
                mayorista = "kk"
            End Try

        Loop While mayorista <> "s" And mayorista <> "S" And mayorista <> "n" And mayorista <> "N"

        Do
            clear()
            Try
                Console.Write("Producto pagado al contado (S/N): ")
                contado = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo raro está pasando prueba otra vez.")
                pausar()
                contado = "kk"
            End Try

        Loop While contado <> "s" And contado <> "S" And contado <> "n" And contado <> "N"

        total = cantidad * precioUnitario

        If (envasado = "s" Or envasado = "S") And (contado = "s" Or contado = "S") And (mayorista = "s" Or mayorista = "S") Then
            descuento = total * 0.2
            total -= descuento
        ElseIf (envasado = "n" Or envasado = "N") And (contado = "S" Or contado = "S")
            descuento = total * 0.05
            total -= descuento
        ElseIf (envasado = "n" Or envasado = "N") And (contado = "n" Or contado = "N") And (mayorista = "s" Or mayorista = "S")
            descuento = total * 0.2
            total -= descuento
        End If

        Console.WriteLine("El total a pagar ascienda a un total de: {0}", total)
        pausar()

    End Sub

End Module
