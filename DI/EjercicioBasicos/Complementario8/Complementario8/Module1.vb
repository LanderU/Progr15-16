Module Module1
    Sub mostrar()
        Dim opcion As Char
        Console.Write("A- Procesador de Texto" + vbCrLf + "B-Hoja de Cálculo" + vbCrLf + "C-Base de Datos" + vbCrLf + "Introduzca una opción: ")
        opcion = Char.Parse(Console.ReadLine())
        limpiar()
        Select Case opcion
            Case "A", "a"
                Console.WriteLine("Procesador de Texto")
            Case "B", "b"
                Console.WriteLine("Hoja de Cálculo")
            Case "C", "c"
                Console.WriteLine("Base de datos")
            Case Else
                Console.WriteLine("Opcion no válida")
        End Select
    End Sub
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Sub limpiar()
        Console.Clear()
    End Sub

    Sub Main()
        ' Visualizar un menú como el siguiente y cuando el usuario elija una opción mostrar un
        ' mensaje indicando la opción elegida. Si no elige ninguna de ella, indicaremos que es una
        ' opción incorrecta.
        ' A-Procesador de Texto
        ' B-Hoja de Calculo
        ' C-Base de Datos
        ' Introduzca una opción
        mostrar()
        pausar()

    End Sub

End Module
