Module Module1
    Private Sub clear()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        ' En un cursillo de programación se estudian cuatro lenguajes: Visual.net, Cobol, Java y SQL
        ' La nota final del curso depende de una práctica que se realiza en los cuatro lenguajes.
        ' Esta nota es APTO o NO APTO según los criterios siguientes:
        ' Sobresaliente, si APTO en los cuatro lenguajes. Notable si APTO en SQL, Cobol, y uno de los otros dos.
        ' Bien, si APTO en Cobol y SQL. Suficiente, si APTO en SQL y uno entre Java y Visual.Net. Suficiente, si apto en Cobol y uno entre Java y Visual.net.
        ' El resto de los casos Insuficiente.
        ' Imprimir la nota de un alumno recibiendo por teclado la nota en cada uno de los lenguajes.

        Dim visual, cobol, java, sql As String

        Do
            clear()
            Try
                Console.Write("Introduzca la nota del alumno en Visual.net:(APTO/NO APTO) ")
                visual = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo va mal... prueba otra vez")
                pausar()
                visual = "KK"
            End Try

        Loop While visual <> "NO APTO" And visual <> "APTO"

        Do
            clear()
            Try
                Console.Write("Introduzca la nota del alumno en Java:(APTO/NO APTO) ")
                java = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo va mal... prueba otra vez")
                pausar()
                java = "KK"
            End Try

        Loop While java <> "NO APTO" And java <> "APTO"

        Do
            clear()
            Try
                Console.Write("Introduzca la nota del alumno en Cobol:(APTO/NO APTO) ")
                cobol = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo va mal... prueba otra vez")
                pausar()
                cobol = "KK"
            End Try

        Loop While cobol <> "NO APTO" And cobol <> "APTO"

        Do
            clear()
            Try
                Console.Write("Introduzca la nota del alumno en SQL:(APTO/NO APTO) ")
                sql = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Algo va mal... prueba otra vez")
                pausar()
                sql = "KK"
            End Try

        Loop While sql <> "NO APTO" And sql <> "APTO"
        clear()
        If (visual = "APTO") And (cobol = "APTO") And (java = "APTO") And (sql = "APTO") Then
            Console.WriteLine("La nota del alumno es: SOBRESALIENTE")
            pausar()
        ElseIf (sql = "APTO") And (cobol = "APTO") And ((java = "APTO") Or (visual = "APTO"))
            Console.WriteLine("La nota del alumno es: NOTABLE")
            pausar()
        ElseIf (sql = "APTO") And (cobol = "APTO")
            Console.WriteLine("La nota del alumno es: BIEN")
            pausar()
        ElseIf (sql = "APTO" And ((java = "APTO") Or (visual = "APTO"))) Or ((cobol = "APTO") And (java = "APTO") Or (visual = "APTO"))
            Console.WriteLine("La nota del alumno es: SUFICIENTE")
            pausar()
        Else
            Console.WriteLine("La nota del alumno es INSUFICIENTE.")
            pausar()
        End If

    End Sub

End Module
