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
        ' Ejemplo escritura y lectura

        'Path del archivo
        ' Console.Write("Escriba el nombre del fichero que vamos a crear: ")
        ' Dim nombreFichero As String = Console.ReadLine()
        Dim path As String = "C:\Users\Public\kk.txt"
        ' Cramos el fichero en la ruta seleccionada
        Dim fichero As FileStream = File.Create(path)

        ' Escribimos texto dentro del fichero creado
        Dim prueba As Byte() = New UTF8Encoding(True).GetBytes("Hola pajarito sin cola")
        fichero.Write(prueba, 0, prueba.Length)
        fichero.Close()
        ' Creamos la variable en la cual vamos guardar la información
        Dim fileReader As System.IO.StreamReader
        ' le asignamos el path donde tenemos el archivo para leer
        fileReader = My.Computer.FileSystem.OpenTextFileReader(path)
        ' Creamos una variable intermedia donde guardar los datos.
        Dim stringReader As String
        ' Le asignamos el valos a la variable creada antes
        stringReader = fileReader.ReadLine()
        ' Mostramos la salida en vez de en la consola en una caja de texto
        MsgBox(stringReader)

    End Sub

End Module
