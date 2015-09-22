Module Module1
    Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Sub Main()
        'Realizar un programa que pida dos valores y 
        'calcule la suma de todos los números
        'comprendidos entre ellos. (el primer número debe 
        'ser menor que el segundo).

        Dim n1, n2, indice As Integer

        Do
            Console.Write("Escriba un número: ")
            n1 = Integer.Parse(Console.ReadLine())
            Console.Write("Escriba otro número mayor que el primero: ")
            n2 = Integer.Parse(Console.ReadLine())
            Console.Clear()
            If n1 > n2 Then
                Console.WriteLine("Recuerda que el segundo número tiene que ser mayor que el primero")
            End If

        Loop While n1 > n2
        indice = n1
        Dim total As Integer = 0
        While indice < n2
            If indice > n1 Then
                total += indice
            End If
            indice += 1
        End While

        Console.WriteLine("La suma de los valores que hay entre {0} y {1}, es: " & total, n1, n2)
        pausar()

    End Sub

End Module
