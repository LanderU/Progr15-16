Module Module1
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        ' Introducir por teclado el número de horas trabajadas por un empleado e imprimir el sueldo
        ' que le corresponde cobrar teniendo en cuenta que cada hora normal se paga a 10 y cada
        ' hora extra a 15. Las horas extras son aquellas superiores a las cuarenta.. A la nómina
        ' calculada anteriormente sumarle un plus de 100 teniendo en cuenta el estado civil y el nivel
        ' de estudios del empleado. Esta última información también la obtendremos a través del
        ' teclado.Se podrá utilizar condiciones compuestas. Utiliza el menor numero posible de
        ' condiciones.
        ' Estado civil(S C V D ) Nivel de estudios (P M S). Llevan plus las siguientes
        ' combinaciones: SP VS SM CS VP SS DS

        Dim horas, salario, extra As Integer
        Dim estado, nivelEstudios As String

        Do
            clear()
            Try
                Console.Write("Introduzca el número de horas trabajadas por la persona: ")
                horas = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Tipo de dato no válido.")
                pausar()
            End Try

        Loop While horas < 0

        If horas <= 40 Then
            salario = (horas * 10)
        ElseIf horas > 40 Then
            extra = (horas - 40)
            salario = ((horas - extra) * 10) + (extra * 15)
        End If

        Do
            clear()
            Try
                Console.Write("Introduzca el estado civil(S/C/V/D): ")
                estado = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo ha pasado, intentalo de nuevo.")
                estado = "z"
            End Try

        Loop While (estado <> "s") And (estado <> "S") And (estado <> "c") And (estado <> "C") And (estado <> "v") And (estado <> "V") And (estado <> "d") And (estado <> "D")

        Do
            clear()
            Try
                Console.Write("Introduzca el nivel de estudios(P/M/S): ")
                nivelEstudios = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo ha pasado, intentalo de nuevo.")
                nivelEstudios = "z"
            End Try

        Loop While (nivelEstudios <> "p") And (nivelEstudios <> "P") And (nivelEstudios <> "m") And (nivelEstudios <> "M") And (nivelEstudios <> "s") And (nivelEstudios <> "S")

        If ((estado = "s" Or estado = "S") And (nivelEstudios = "p" Or nivelEstudios = "P")) Or ((estado = "v" Or estado = "V") And (nivelEstudios = "s" Or nivelEstudios = "S")) Or ((estado = "s" Or estado = "S") And (nivelEstudios = "m" Or nivelEstudios = "M")) Or ((estado = "c" Or estado = "C") And (nivelEstudios = "s" Or nivelEstudios = "S")) Or ((estado = "v" Or estado = "V") And (nivelEstudios = "p" Or nivelEstudios = "P")) Or ((estado = "s" Or estado = "S") And (nivelEstudios = "s" Or nivelEstudios = "S")) Or ((estado = "d" Or estado = "D") And (nivelEstudios = "s" Or nivelEstudios = "S")) Then
            salario += 100
        End If
        clear()
        Console.WriteLine("El salario del empleado es el {0}", salario)
        pausar()


    End Sub

End Module
