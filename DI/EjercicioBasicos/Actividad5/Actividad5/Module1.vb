Module Module1
    'Realizar un programa que a través de un menú permita
    'realizar las operaciones de sumar, restar, multiplicar, 
    'dividir y salir. Las operaciones constarán solamente de
    'dos operandos.
    ' #######################################################
    ' Módulo para pausar
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    ' Módulo para limpiar la consola
    Sub limpiar()
        Console.Clear()
    End Sub
    ' Mostrar continuar
    Sub seguir()
        Console.Write("Desea realizar otra operación (si/no): ")
    End Sub
    ' Agradecimientos
    Sub thanks()
        Console.Write("Gracias por usar la calculadora de Lander!!")
    End Sub
    Sub Main()
        ' Declaraciones de variables
        Dim continuar As String
        Dim opcion As Int16
        Dim n1, n2, total As Double

        Do
            REM Mostramos el menú vbCrLf--> Salto de línea equivalente a "\n"
            Console.Write("1- Sumar" + vbCrLf + "2- Restar" + vbCrLf + "3- Multiplicar" + vbCrLf + "4- Dividir" + vbCrLf + "5- Salir" + vbCrLf + "Opcion: ")
            opcion = Convert.ToInt16(Console.ReadLine())
            Select Case opcion
                Case 1
                    Console.Write("Primer número a sumar: ")
                    n1 = Convert.ToDouble(Console.ReadLine())
                    Console.Write("Segundo número a sumar: ")
                    n2 = Convert.ToDouble(Console.ReadLine())
                    total = n1 + n2
                    Console.WriteLine("El resultado de sumar {0} y {1}, es {2}", n1, n2, total)
                    pausar()
                    limpiar()
                    seguir()
                    continuar = Console.ReadLine()

                    If continuar = "si" Then
                        ' Limpiamos la consola para que nos salga el menú limpio
                        limpiar()
                    Else
                        limpiar()
                        thanks()
                        pausar()
                    End If
                Case 2
                    Console.Write("Primer número a restar: ")
                    n1 = Convert.ToDouble(Console.ReadLine())
                    Console.Write("Segundo número a restar: ")
                    n2 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("El resultado de restar {0} y {1},es " & n1 - n2, n1, n2)
                    pausar()
                    limpiar()
                    seguir()
                    continuar = Console.ReadLine()
                    If continuar = "si" Then
                        limpiar()
                    Else
                        limpiar()
                        thanks()
                        pausar()
                    End If
                Case 3
                    Console.Write("Primer número a multiplicar: ")
                    n1 = Convert.ToDouble(Console.ReadLine())
                    Console.Write("Segundo número a multiplicar: ")
                    n2 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("El resultado de multiplicar {0} y {1}, es " & n1 * n2, n1, n2)
                    pausar()
                    limpiar()
                    seguir()
                    continuar = Console.ReadLine()
                    If continuar = "si" Then
                        limpiar()
                    Else
                        limpiar()
                        thanks()
                        pausar()
                    End If
                Case 4
                    Console.Write("Número a dividir: ")
                    n1 = Convert.ToDouble(Console.ReadLine())
                    Console.Write("Número por el que se va a dividir: ")
                    n2 = Convert.ToDouble(Console.ReadLine())
                    If n1 = 0 Or n2 = 0 Then
                        Console.WriteLine("No se puede dividir entre 0")
                        pausar()
                        Console.WriteLine("Salimos al menú otra vez")
                        pausar()
                        limpiar()
                        continuar = "si"
                    Else
                        Console.WriteLine("El resultado de dividir {0} y {1}, es " & n1 / n2, n1, n2)
                        pausar()
                        limpiar()
                        seguir()
                        continuar = Console.ReadLine()
                        If continuar = "si" Then
                            limpiar()
                        Else
                            limpiar()
                            thanks()
                            pausar()
                        End If
                    End If
                Case 5
                    limpiar()
                    thanks()
                    pausar()
                    continuar = "no"

            End Select
        Loop While continuar <> "no"
    End Sub

End Module
