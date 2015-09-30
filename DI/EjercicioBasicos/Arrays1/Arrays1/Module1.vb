Module Module1
    Private Sub pedir(ByRef dimension, posiciones)

        Do
            limpiar()
            Console.Write("Escriba el la dimensión que le quieres asignar a la matríz(1-3): ")
            Try
                dimension = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                limpiar()
                Console.WriteLine("Valor no válido")
                pausar()
                dimension = 0
            End Try
        Loop While (dimension < 1) Or (dimension > 3)

        Do
            limpiar()
            Console.Write("Posiciones para el array: ")
            Try
                posiciones = Integer.Parse(Console.ReadLine()) - 1

            Catch ex As Exception
                Console.WriteLine("Valor no válido")
                pausar()
                posiciones = 0
            End Try

        Loop While posiciones <= 0


        Select Case dimension
            Case 1
                pausar()
                Dim array(posiciones) As String
                limpiar()
                Console.WriteLine("Introduzca los datos")
                Dim index As Integer
                For index = 0 To posiciones

                    limpiar()
                    Console.Write("Introduzca el dato para el valor {0}, del array: ", index)
                    array(index) = Console.ReadLine()
                Next
                limpiar()
                Console.WriteLine("Mostramos los datos.")
                pausar()
                limpiar()
                For index = 0 To posiciones
                    Console.WriteLine("Los datos en la posición {0}, de array es: " & array(index), index)
                    pausar()
                Next
            Case 2
                Dim array(posiciones, posiciones) As String
                limpiar()
                Console.WriteLine("Introduzca los datos")
                Dim fila, columna As Integer
                For fila = 0 To posiciones
                    For columna = 0 To posiciones
                        Console.Write("Escriba el valor para la posición {0}, {1}, del array: ", fila, columna)
                        array(fila, columna) = Console.ReadLine()
                    Next
                Next
                limpiar()
                Console.WriteLine("Mostramos los datos.")
                pausar()
                limpiar()
                For fila = 0 To posiciones
                    For columna = 0 To posiciones
                        Console.WriteLine("Los datos introducidos en la posición {0}, {1}, son: " & array(fila, columna), fila, columna)
                        pausar()
                    Next
                Next


            Case 3
                Dim array(posiciones, posiciones, posiciones) As String
                pausar()
                limpiar()
                Console.WriteLine("Introduzca los datos")
                Dim fila, columna, profundidad As Integer
                For fila = 0 To posiciones
                    For columna = 0 To posiciones
                        For profundidad = 0 To posiciones
                            Console.Write("Escriba el valor para la posición {0}, {1}, {2} del array: ", fila, columna, profundidad)
                            array(fila, columna, profundidad) = Console.ReadLine()
                        Next

                    Next
                Next
                limpiar()
                Console.WriteLine("Mostramos los datos.")
                pausar()
                limpiar()
                For fila = 0 To posiciones
                    For columna = 0 To posiciones
                        For profundidad = 0 To posiciones
                            Console.WriteLine("El valor introducido en la posición {0}, {1}, {2}, del array es: " & array(fila, columna, profundidad), fila, columna, profundidad)
                            pausar()
                        Next

                    Next
                Next



        End Select

    End Sub
    Private Sub limpiar()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        ' Crear una matriz con el numero de elementos y la dimensi  ́ on indica-  ́
        ' da por el usuario (1-3). A continuacion el usuario debe teclear valores  ́
        ' para llenar la matriz y por ultimo, debemos visualizar los datos alma-  ́
        ' cenados en la matriz.
        Dim dimension, posiciones As Integer

        pedir(dimension, posiciones)

    End Sub

End Module
