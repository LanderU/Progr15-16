Module Module1
    Private Sub pedirAno()
        Console.Write("Escriba el año, formato (yyyy): ")
    End Sub
    Private Sub pedirMes()
        Console.Write("Escriba el mes, formato (m): ")
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub calcularDias(ByVal ano, ByVal mes)
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                clear()
                Console.WriteLine("El mes seleccionado tiene 31 días.")
                pausar()
            Case 2
                clear()
                If ((ano Mod 4 = 0) And (ano Mod 100 <> 0)) Or (ano Mod 400 = 0) Then
                    Console.WriteLine("Al tratarse de un año bisisesto el mes de febrero tiene 29 días.")
                    pausar()
                Else
                    Console.WriteLine("Al no tratarse de un año bisisesto el mes de febrero tiene 28 días.")
                    pausar()
                End If
            Case 4, 6, 9, 11
                clear()
                Console.WriteLine("El mes seleccionado tiene 30 días.")
                pausar()

        End Select
    End Sub


    Sub Main()
        ' Hacer un programa que acepte una sucesión de fechas y compruebe y nos diga si son correctas o no.
        ' El programa termina en el momento que conteste que no desea continuar. Para controlar que una fecha es válida o no 
        ' se controlará que el mes está entre 1 y 12. Los días no pasarán de 30 ó 31 dependiendo del mes al que pertenezca.
        ' Controlar también si febrero tiene 28 ó 29 días en caso de ser bisiesto.
        Dim continuar As String
        Dim ano, mes As Integer

        Do
            clear()
            Do
                clear()
                Try
                    pedirAno()
                    ano = Integer.Parse(Console.ReadLine())
                Catch ex As Exception
                    Console.WriteLine("Dato no válido.")
                    pausar()
                    ano = -1
                End Try

            Loop While ano <= 0000

            Do
                clear()
                Try
                    pedirMes()
                    mes = Integer.Parse(Console.ReadLine())
                Catch ex As Exception
                    Console.WriteLine("Dato no válido.")
                    pausar()
                    mes = 0
                End Try

            Loop While mes < 1 Or mes > 12
            calcularDias(ano, mes)
            clear()
            Console.Write("Desea continuar (s/n): ")
            continuar = Console.ReadLine()
        Loop While continuar <> "n"


    End Sub

End Module
