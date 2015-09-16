Module Module1

    Sub Main()
        REM 1.Realizar un programa que lea una fecha representada por 
        REM dos enteros, mes y año, y dé como resultado el número de 
        REM días de ese mes. Hacer el ejercicio de formas distintas 
        REM (con If, con ElseIf, con Select).

        Dim mes, ano As Int16

        Console.Write("Introduzca el año formato 0000: ")
        ano = Convert.ToInt16(Console.ReadLine())
        Console.Write("Introduzca el número del mes: ")
        mes = Convert.ToInt16(Console.ReadLine())
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine("El mes tiene: " & 31 & " dias, pulse tecla para salir")
                Console.ReadKey()
            Case 4, 6, 9, 11
                Console.WriteLine("El mes tiene: " & 30 & " días, pulse tecla para salir")
                Console.ReadKey()
            Case 2
                If ((ano Mod 4 = 0) And (ano Mod 100 <> 0)) Or (ano Mod 400 = 0) Then
                    Console.WriteLine("El mes tiene: " & 29 & " dias, intro para continuar")
                    Console.ReadKey()

                Else
                    Console.WriteLine("El mes tien: " & 28 & " días, intro para continuar")
                    Console.ReadKey()
                End If
            Case Else
                Console.WriteLine("Te has colado colega, opción no válida")
                Console.ReadKey()
        End Select


    End Sub

End Module
