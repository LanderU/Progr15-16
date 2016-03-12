Imports System.Data.SqlClient
Public Class Form1

    Dim adaptador As SqlDataAdapter
    Dim conexion As SqlConnection
    Dim sql As String
    Dim ejecutar As SqlCommand
    Dim dataS As DataSet
    Dim controlTupla As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Base de datos
        conexion = New SqlConnection(My.Settings.conect)

        ' Abrimos la conexión
        conexion.Open()

        ' Sentencia SQL para quedarnos con la tabla que queramos.
        sql = "SELECT * FROM productos"

        ' Ejecutamos la consulta.

        ejecutar = New SqlCommand(sql, conexion)


        ' Comprobamos
        Try
            ' Le pasamos al adaptador la consulta con la conexión
            adaptador = New SqlDataAdapter(ejecutar)
            dataS = New DataSet
            adaptador.Fill(dataS, "productos")

        Catch ex As SqlException

            MsgBox("Error en la base de datos, no se puede realizar la conexión.")

        End Try


        ' Definición de los nombres de los controles
        Me.Text = "Ejercicio Fichas en modo Manual"
        Label1.Text = "Código"
        Label2.Text = "Nombre"
        Label3.Text = "Existencias"
        TextBox4.ReadOnly = "True"
        Button1.Text = "Añadir"
        Button2.Text = "Update"
        Button3.Text = "Delete"
        Button4.Text = "<<"
        Button5.Text = "<"
        Button6.Text = ">"
        Button7.Text = ">>"
        Button8.Text = "Salir"

        ' Rellenamos los campos con el primer registro del dataSet
        controlTupla = 0
        TextBox1.Text = dataS.Tables("productos").Rows(controlTupla).Item("cod_prod").ToString
        TextBox2.Text = dataS.Tables("productos").Rows(controlTupla).Item("nombre").ToString
        TextBox3.Text = dataS.Tables("productos").Rows(controlTupla).Item("existencia").ToString
        TextBox4.Text = controlTupla + 1
        conexion.Close()
    End Sub

    Private Sub controlarBotones(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click

        Dim pulsado As Object = CType(sender, Button)

        If pulsado.Equals(Button1) Then
            ' Añadimos un registro nuevo
        ElseIf pulsado.Equals(Button2)
            ' Actualizamos el registro actual
        ElseIf pulsado.Equals(Button3)
            ' Borramos el registro
        ElseIf pulsado.Equals(Button4)
            ' Vamos al primer registro de nuestra BD
            controlTupla = 0
            TextBox1.Text = dataS.Tables("productos").Rows(controlTupla).Item("cod_prod").ToString
            TextBox2.Text = dataS.Tables("productos").Rows(controlTupla).Item("nombre").ToString
            TextBox3.Text = dataS.Tables("productos").Rows(controlTupla).Item("existencia").ToString
            TextBox4.Text = controlTupla + 1
        ElseIf pulsado.Equals(Button5)
            ' Vamos al registro anterior si no estamos en el primero
            If controlTupla = 0 Then
                MsgBox("Ya estás en el primer registro")
            Else
                controlTupla -= 1
                TextBox1.Text = dataS.Tables("productos").Rows(controlTupla).Item("cod_prod").ToString
                TextBox2.Text = dataS.Tables("productos").Rows(controlTupla).Item("nombre").ToString
                TextBox3.Text = dataS.Tables("productos").Rows(controlTupla).Item("existencia").ToString
                TextBox4.Text = controlTupla + 1
            End If
        ElseIf pulsado.Equals(Button6)
            ' Vamos al siguiente registro si no estamos en el último
            If controlTupla = dataS.Tables("productos").Rows.Count Then
                MsgBox("Ya estás en el último registro")
            Else
                controlTupla += 1
                If controlTupla = dataS.Tables("productos").Rows.Count Then
                    MsgBox("Ya estás en el último registro")
                Else
                    TextBox1.Text = dataS.Tables("productos").Rows(controlTupla).Item("cod_prod").ToString
                    TextBox2.Text = dataS.Tables("productos").Rows(controlTupla).Item("nombre").ToString
                    TextBox3.Text = dataS.Tables("productos").Rows(controlTupla).Item("existencia").ToString
                    TextBox4.Text = controlTupla + 1
                End If

            End If
        ElseIf pulsado.Equals(Button7)
                ' Vamos al último registro
                controlTupla = dataS.Tables("productos").Rows.Count - 1
                TextBox1.Text = dataS.Tables("productos").Rows(controlTupla).Item("cod_prod").ToString
                TextBox2.Text = dataS.Tables("productos").Rows(controlTupla).Item("nombre").ToString
                TextBox3.Text = dataS.Tables("productos").Rows(controlTupla).Item("existencia").ToString
            TextBox4.Text = controlTupla + 1
            controlTupla = dataS.Tables("productos").Rows.Count

        Else
                ' Cerramos la conexión con la BD hacemos commit y salimos del programa
                conexion.Close()
            Me.Close()

        End If

    End Sub



End Class
