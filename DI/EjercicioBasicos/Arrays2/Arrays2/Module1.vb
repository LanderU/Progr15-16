Module Module1
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub limpiar()
        Console.Clear()
    End Sub
    Private Sub inputDatos(ByRef longi)
        Do
            limpiar()
            Console.Write("Introduzca el tamaño del array de una dimensión: ")
            Try
                longi = Integer.Parse(Console.ReadLine()) - 1

            Catch ex As Exception
                Console.WriteLine("Número invalido, tiene que ser un entero, ni letras ni historias raras.")
                pausar()
                longi = 0
            End Try

        Loop While longi < 0
        Dim array(longi) As String
        Dim index As Integer

        For index = 0 To longi
            limpiar()
            Console.Write("Introduzca el dato a guardar en la posición {0}, del array: ", index)
            array(index) = Console.ReadLine()
        Next
        limpiar()
        Dim opcion As Integer

        Do
            Console.Write("1. Buscar valor en el array" + vbCrLf + "2. Copiar número de elementos del array" + vbCrLf + "3. Inicializar el array" + vbCrLf + "4. Salir" + vbCrLf + "Opcion: ")
            Try
                opcion = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Valor no válido")
                opcion = 0
            End Try
        Loop While opcion < 1 Or opcion > 4

        Select Case opcion
            Case 1
                Console.Write("Escriba el valor a buscar en el array: ")
                Dim buscado As String = Console.ReadLine()
                Dim i As Integer
                Try
                    While (i < array.Length) And (array(i) <> buscado)
                        i += 1
                    End While

                Catch ex As IndexOutOfRangeException
                    Console.WriteLine("El dato, {0} no está en el array", buscado)
                    pausar()
                End Try
                If i < array.Length Then
                    limpiar()
                    Console.WriteLine("El dato está en la posición {0}, y es: " + array(i), i)
                    pausar()
                End If

            Case 2

                limpiar()
                Dim bajo, alto As Integer
                Console.WriteLine("Introduzca el rango del array que quiere copiar")
                Console.WriteLine("Su array va desde la posición {0}, hasta la {1}", array.GetLowerBound(0), array.GetUpperBound(0))
                Console.Write("Intro para continuar...")
                Console.ReadKey()
                Do
                    limpiar()
                    Try
                        Console.Write("Valor por el que empezar: ")
                        bajo = Integer.Parse(Console.ReadLine())

                    Catch ex As Exception
                        limpiar()
                        Console.WriteLine("Introduzca un número, gracias!")
                        bajo = -1
                    End Try
                Loop While (bajo < array.GetLowerBound(0)) Or (bajo > array.GetUpperBound(0))

                Do
                    limpiar()
                    Try
                        Console.Write("Valor por el que terminar: ")
                        alto = Integer.Parse(Console.ReadLine())

                    Catch ex As Exception
                        limpiar()
                        Console.WriteLine("Introduzca un número, gracias!")
                        alto = -1
                    End Try

                Loop While (alto > array.GetUpperBound(0)) Or (alto < array.GetUpperBound(0))

                Dim newArray(alto) As String
                Dim indice As Integer = 0
                Dim indice1 As Integer = bajo
                While indice1 <= alto
                    newArray(indice) = array(indice1)
                    indice1 += 1
                    indice += 1
                End While
                limpiar()
                Console.WriteLine("El nuevo array con lo copiado queda de la siguiente manera: ")

                indice = 0
                If bajo = 0 And alto = 0 Then
                    Console.WriteLine("Lo guardado es: " & newArray(0))
                    pausar()
                Else
                    While indice < newArray.GetUpperBound(0)
                        Console.WriteLine("Lo guardado es: " & newArray(indice))
                        pausar()
                        indice += 1
                    End While
                End If






            Case 3
                Dim redimen As Integer
                Do
                    Try
                        limpiar()
                        Console.Write("Inicializar el array con las posiciones que indiques:  ")
                        redimen = Integer.Parse(Console.ReadLine()) - 1

                    Catch ex As Exception
                        Console.WriteLine("Te has colado, un número entero por favor.")
                        redimen = -1
                    End Try
                Loop While redimen < 0
                ReDim array(redimen)
                limpiar()
                Console.WriteLine("Inicializado el array con {0}, posicion(es)", array.Length)
                pausar()


            Case 4
                Console.WriteLine("Gracias por jugar con los arrays.")
                pausar()
        End Select




    End Sub
    Sub Main()
        ' Desarrolla un ejercicio en el que se cree un array de una dimensión,
        ' del tamano indicado por el usuario. Tras crearlo guarda en el los datos
        ' tecleados por el usuario. A continuación visualiza un menú para que
        ' el usuario pueda realizar distintas tareas: Buscar un valor en el array,
        ' Copiar un numero determinado de elementos, Inicializar el array,
        ' Terminar la ejecucion.
        Dim longi As Integer
        inputDatos(longi)




    End Sub

End Module

