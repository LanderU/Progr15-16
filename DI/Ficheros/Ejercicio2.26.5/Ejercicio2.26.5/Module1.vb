Imports System.IO
Imports System.Text
Module Module1
    Private Sub limpiar()
        Console.Clear()
    End Sub
    Private Sub pausar()
        Threading.Thread.Sleep(2000)
    End Sub

    Public Structure Persona
        Dim codigo As Int32
        Dim nombre As String
        Dim direccion As String
        Dim telefono As String
        Dim edad As Integer
    End Structure

    ' Constante de longitud para los registros
    Public Const longitud As Long = 100

    Sub Main()

        ' Desarrolla un programa que nos permita ir grabando en
        ' un fichero los datos de un conjunto de personas. De cada 
        ' persona se quiere guardar un código, el nombre, la dirección, 
        ' el teléfono y la edad. Los códigos de las personas son 
        ' consecutivos(1, 2, 3, 4, 5, etc...).

        Dim path As String = "c:\users\Public\datos.txt"
        ' Creamos el flujo para la creación del fichero.
        Dim flujo As FileStream = New FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)

        ' Flujo de tipo binario

        Dim br As BinaryWriter = New BinaryWriter(flujo)

        ' Instancia
        Dim per As Persona
        per.codigo = 0
        per.codigo += 1
        ' Datos a guardar
        Console.Write("Introduzca su nombre: ")
        per.nombre = Console.ReadLine()
        Console.Write("Introduzca su dirección: ")
        per.direccion = Console.ReadLine()
        Console.Write("Introduzca su teléfono: ")
        per.telefono = Console.ReadLine()
        Console.Write("Introduzca su edad: ")
        per.edad = Int32.Parse(Console.ReadLine())

        ' Escribimos en el fichero
        br.Write(per.codigo)
        br.Write(per.nombre)
        br.Write(per.direccion)
        br.Write(per.telefono)
        br.Write(per.edad)
        ' Cerrmos el flujo
        flujo.Close()
        ' Regeneramos el flujo para leer
        flujo = New FileStream(path, FileMode.Open, FileAccess.Read)
        Dim lector As BinaryReader = New BinaryReader(flujo)
        ' Leemos el fichero
        Console.WriteLine(lector.ReadInt32)
        Console.WriteLine(lector.ReadString)
        Console.WriteLine(lector.ReadString)
        Console.WriteLine(lector.ReadString)
        Console.WriteLine(lector.ReadInt32)
        pausar()
        lector.Close()

    End Sub

End Module
