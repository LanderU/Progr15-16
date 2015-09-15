Module Module1

    Sub Main()
        ' Declaración de las variables
        Dim opcion As Int16
        Dim cantidad, total As Double
        ' Mostramos el menú
        Console.WriteLine("1- Euros-->Dolar")
        Console.WriteLine("2- Dolar-->Euros")
        Console.Write("Seleccione una de las opciones: ")
        opcion = Convert.ToInt16(Console.ReadLine())
        Console.WriteLine(opcion)
        If opcion <> 1 And opcion <> 2 Then
            Console.WriteLine("Te has equivocado pulse cualquier tecla para salir")
            Console.ReadKey()
        Else
            Select Case opcion
                Case 1
                    Dim coeficiente As Double = 1.13
                    Console.Write("Cantidad de euros a convertir a dolares: ")
                    cantidad = Convert.ToDouble(Console.ReadLine())
                    total = cantidad * coeficiente
                    Console.WriteLine("La cantidad en dolares equivale a: " + total.ToString())
                    Console.WriteLine("Pulse cualquier tecla para salir")
                    Console.ReadKey()
                Case 2
                    Dim coeficiente As Double = 0.89
                    Console.Write("Cantidad de dolares a convertir en euros: ")
                    cantidad = Convert.ToDouble(Console.ReadLine())
                    total = cantidad * coeficiente
                    Console.WriteLine("La cantidad de dolares es: " + total.ToString())
                    Console.WriteLine("Pulse cualquier tecla para salir")
                    Console.ReadKey()
            End Select
        End If







    End Sub

End Module
