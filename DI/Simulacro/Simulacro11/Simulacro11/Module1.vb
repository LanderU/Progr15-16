Module Module1
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub menu()
        Console.Write("1.- Comprobar si es primo" + vbCrLf + "2.-Calcular el factorial" + vbCrLf + "3.-Visualizar la tabla de multiplicar" + vbCrLf + "4.-Salir del programa" + vbCrLf + "Opcion: ")
    End Sub
    Private Sub primo(ByRef numero)
        Dim cont As Integer = 0
        For i As Integer = 1 To numero
            If (numero Mod i = 0) Then
                cont += 1
            End If
        Next
        clear()
        If cont > 2 Then
            Console.WriteLine("El número {0}, no es primo", numero)
            pausar()
        Else
            Console.WriteLine("El número {0}, es primo", numero)
            pausar()
        End If
    End Sub
    Private Function factorial(ByVal numero As Integer) As Integer
        If numero <= 1 Then
            Return 1
        Else
            Return factorial(numero - 1) * numero
        End If
    End Function
    Private Sub pedirNuemero()
        Console.Write("Introduzca el número: ")
    End Sub
    Private Sub tablaMultiplicar(ByVal numero)
        Dim index As Integer = 1
        While index <= 10
            Console.WriteLine(numero * index)
            index += 1
            pausar()
        End While
    End Sub

    Sub Main()
        Dim opcion, numero As Integer
        Do
            clear()
            menu()
            Try
                opcion = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("No estás introducioendo bien los datos.")
                opcion = 0

            End Try
            Select Case opcion
                Case 1
                    Do
                        clear()
                        Try
                            pedirNuemero()
                            numero = Integer.Parse(Console.ReadLine())
                        Catch ex As Exception
                            Console.Write("Algo está pasando prueba otra vez.")
                            pausar()
                            numero = 0
                        End Try

                    Loop While numero <= 1
                    primo(numero)
                Case 2
                    clear()
                    Do
                        Try
                            pedirNuemero()
                            numero = Integer.Parse(Console.ReadLine())
                        Catch ex As Exception
                            Console.Write("Algo está pasando prueba otra vez.")
                            pausar()
                            numero = 0
                        End Try

                    Loop While numero <= 1
                    clear()
                    Console.WriteLine(factorial(numero))

                Case 3
                    clear()
                    Do
                        Try
                            pedirNuemero()
                            numero = Integer.Parse(Console.ReadLine())
                        Catch ex As Exception
                            Console.Write("Algo está pasando prueba otra vez.")
                            pausar()
                            numero = 0
                        End Try

                    Loop While numero <= 1
                    Console.WriteLine("Motramos la tabla de multiplicar.")
                    clear()
                    tablaMultiplicar(numero)

                Case 4
                    clear()
                    Console.WriteLine("Gracias por participar.")
                    pausar()
            End Select


        Loop While opcion <> 4

    End Sub

End Module
