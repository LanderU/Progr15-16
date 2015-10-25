' Imports necesarios para operar con ficheros
Imports System.IO
Imports System.Text

Module Module1

    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub clear()
        Console.Clear()
    End Sub

    Sub Main()
        ' Desarrolla un programa que cree un fichero,
        ' con el nombre indicado por el usuario, que 
        ' guarde los datos de un conjunto de personas 
        ' (nombre, dirección, teléfono y dirección de 
        ' correo). Posteriormente lee los datos de este 
        ' fichero y visualízalos en pantalla.


        ' Pedimos el nombre del archivo.
        Console.Write("Nombre para el archivo: ")
        ' Guardamos el nombre del archivo.
        Dim nomFichero As String = Console.ReadLine()

        ' Lo añadimos al path, con la extensión por si al usuario se le ha olvidado

        Dim path As String = "C:\users\Public\" + nomFichero + ".txt"

        ' Empezamos con la pedida de datos para el usuario. Le pediremos nombre, dirección, teléfono y dirección de correo electrónico

        Console.Write("Cantidad de ususarios que va a registrar: ")
        Dim cantUsusarios As Integer = Integer.Parse(Console.ReadLine())

        ' Creamos el archivo
        Dim fichero As FileStream = File.Create(path)

        ' Declaración de lo que vamos a escribir.

        Dim nombre As Byte()
        Dim direccion As Byte()
        Dim telefono As Byte()
        Dim email As Byte()
        Dim relleno As Byte()

        For i As Integer = 1 To cantUsusarios
            clear()
            Console.Write("Escriba el nombre: ")
            nombre = New UTF8Encoding(True).GetBytes("Nombre: " + Console.ReadLine() + vbCrLf)
            ' Escribimos dentro del fichero
            fichero.Write(nombre, 0, nombre.Length)
            Console.Write("Escriba la dirección: ")
            direccion = New UTF8Encoding(True).GetBytes("Dirección: " + Console.ReadLine() + vbCrLf)
            ' Escribimos dentro del fichero
            fichero.Write(direccion, 0, direccion.Length)
            Console.Write("Escriba el teléfono: ")
            telefono = New UTF8Encoding(True).GetBytes("Teléfono: " + Console.ReadLine() + vbCrLf)
            ' Escribimos dentro del fichero
            fichero.Write(telefono, 0, telefono.Length)
            Console.Write("Escriba el correo electrónico: ")
            email = New UTF8Encoding(True).GetBytes("Dirección de correo electrónico: " + Console.ReadLine() + vbCrLf)
            ' Escribimos en el fichero
            fichero.Write(email, 0, email.Length)
            ' Escribimos en el fichero
            relleno = New UTF8Encoding(True).GetBytes("-------------------------" + vbCrLf)
            fichero.Write(relleno, 0, relleno.Length)
        Next
        fichero.Close()
        ' Falta la lectura de los datos del fichero PENDIENTE!!!!!

    End Sub

End Module
