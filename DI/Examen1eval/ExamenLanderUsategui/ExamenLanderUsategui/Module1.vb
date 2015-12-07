Module Module1
    Private Sub limpiar()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub problema1(ByRef a, ByRef b)
        entradaDatos(a, b)
        visualizarSuma(MultiplosDeCinco(a, b))


    End Sub
    ' Entrada de datos para el problema1
    Private Sub entradaDatos(ByRef a, ByRef b)
        Do
            limpiar()
            Console.Write("Introduzca el valor de A: ")
            Try
                a = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                a = -1
                Console.WriteLine("Dato no válido prueba otra vez")
                pausar()
            End Try

        Loop While a = -1

        ' Pedida para el dato b

        Do
            limpiar()
            Console.Write("Introduzca el valor de B: ")
            Try
                b = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                b = -1
                Console.WriteLine("Dato no válido prueba otra vez")
                pausar()
            End Try

        Loop While b = -1

    End Sub
    Private Function MultiplosDeCinco(ByRef a, ByRef b) As Integer
        Dim aux As Integer
        ' Intercambiamos los valores
        If a > b Then
            aux = b
            b = a
            a = aux
        End If
        Dim suma As Integer
        For i As Integer = a To b
            If i Mod 5 = 0 Then
                suma += i
            End If
        Next

        Return suma



    End Function
    ' Visualizar la suma de los múltiplos de cinco
    Private Sub visualizarSuma(ByVal suma)
        Console.WriteLine("El total de la suma de los múltiplos es: " & suma)
        pausar()
    End Sub
    Private Sub problema2()
        Dim opcion As String
        Dim nombre(99999) As String
        Dim salario(99999) As Integer
        Dim contador As Integer = 0
        Dim minimo As Integer = Integer.MaxValue
        Dim maximo As Integer = Integer.MinValue
        Dim pMin, pMax As Integer
        Do
            limpiar()
            Console.Write("Introduzca el nombre de la persona: ")
            nombre(contador) = Console.ReadLine()
            ' Console.Write("Escriba el salario de la persona: ")
            Dim checkSalario As Boolean = False
            Do
                If checkSalario = False Then
                    Try
                        limpiar()
                        Console.Write("Escriba el salario de la persona: ")
                        salario(contador) = Integer.Parse(Console.ReadLine())
                        checkSalario = True
                    Catch ex As Exception
                        Console.WriteLine("El salario tiene que ser un número entero.")
                        checkSalario = False
                        Console.Write(checkSalario)
                        pausar()
                    End Try
                End If
            Loop While checkSalario = False
            contador += 1

            If salario.Min < minimo Then
                minimo = salario.Min
                pMin = contador
            End If
            If salario.Max > maximo Then
                maximo = salario.Max
                pMin = contador
            End If
            Console.Write("Para terminar escriba no ó 0: ")
            opcion = Console.ReadLine()
        Loop While opcion <> "no" And opcion <> "0"
        limpiar()
        Console.WriteLine("La persona que menos cobra es: " + nombre(pMin) + " con un sueldo de: " & salario(pMin))
        pausar()
        Console.WriteLine("La persona que más cobra es: " + nombre(pMax) + " con un salario de: " & salario(pMax))
        pausar()
    End Sub
    Sub Main()
        'Mostramos el menú
        Dim opcion As Integer
        Dim a, b As Integer
        Do
            limpiar()
            Console.Write("1- Ejecutar problema 1" + vbCrLf + "2- Ejecutar problema 2" + vbCrLf + "3- Salir del programa" + vbCrLf + "Elige una opción: ")
            Try
                opcion = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                opcion = -1
            End Try
            Select Case opcion
                Case 1
                    limpiar()
                    problema1(a, b)
                    pausar()
                Case 2
                    limpiar()
                    problema2()
                    pausar()
                Case 3
                    limpiar()
                    Console.WriteLine("Gracias por usar nuestro menú")
                    pausar()
                Case Else
                    limpiar()
                    Console.WriteLine("Dato no válido")
                    pausar()
            End Select


        Loop While opcion <> 3



    End Sub

End Module
