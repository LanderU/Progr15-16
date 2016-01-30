Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Prueba ComboBox"
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDown
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        Button1.Text = "Agregar valores"
        Label1.Text = "Mostrar Valor seleccionado"
        Button2.Text = "Añadir nombre"
        Button3.Text = "Eliminar valor"

        ' Lo ignora
        'ComboBox3.DropDownStyle = ComboBoxStyle.Simple
        ' Añadir controles a mano
        ' Creamos el control
        'Dim ComboBox4 As Object
        ' Le damos una localización
        'ComboBox4.Location = New Point(15, 15)
        ' Lo añadimos a la lista de los controloes
        'Me.Controls.Add(ComboBox4)
    End Sub

    Private Sub agregarValores(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.AddRange(New String() {"Amarillo", "Rojo", "Azul", "Verde"})
        ComboBox2.Items.AddRange(New String() {"Lander", "Ixone", "Gabriel", "Ane"})
        ComboBox3.Items.AddRange(New String() {"Ciudad del Cabo", "Madrid", "Barcelona", "Calcuta"})
    End Sub

    Private Sub controlBotonesAñadirEliminar(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click
        Dim pulsado As Object = CType(sender, Button)
        If pulsado.Equals(Button2) Then
            If TextBox2.Text.Count = 0 Then
                MsgBox("Introduzca un nombre por favor")
            Else
                Dim encontrado As Int16 = ComboBox2.FindString(TextBox2.Text)
                If encontrado <> -1 Then
                    MsgBox("El nombre ya está en la lista")
                Else
                    ComboBox2.Items.Add(TextBox2.Text)
                    TextBox2.Clear()
                End If

            End If
        Else
            If TextBox3.Text.Count = 0 Then
                MsgBox("Seleccione algo que borrar")
            Else
                Dim buscar As Int16 = ComboBox1.FindString(TextBox3.Text)
                Dim buscar2 As Int16 = ComboBox2.FindString(TextBox3.Text)
                Dim buscar3 As Int16 = ComboBox3.FindString(TextBox3.Text)
                If (buscar = -1) And (buscar2 = -1) And (buscar3 = -1) Then
                    MsgBox("No puede buscarse el dato, compruebelo")
                ElseIf buscar <> -1
                    ComboBox1.Items.RemoveAt(buscar)
                ElseIf buscar2 <> -1
                    ComboBox2.Items.RemoveAt(buscar2)
                ElseIf buscar3 <> -1
                    ComboBox3.Items.RemoveAt(buscar3)
                End If
            End If
        End If
    End Sub

    Private Sub mostrarSeleccion(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged, ComboBox3.SelectedIndexChanged
        Dim seleccion As Object = CType(sender, ComboBox)
        If seleccion.Equals(ComboBox1) Then
            TextBox1.Text = ComboBox1.SelectedItem
        ElseIf seleccion.Equals(ComboBox2)
            TextBox1.Text = ComboBox2.SelectedItem
        Else
            TextBox1.Text = ComboBox3.SelectedItem
        End If

    End Sub
End Class
