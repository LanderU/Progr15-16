
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "ListBox1"
        ListBox1.Items.Add("Radio")
        ListBox1.Items.Add("Coche")
        ListBox1.Items.Add("Libro")
        ListBox1.Items.Add("Mesa")
        ListBox1.Items.Add("Monitor")
        ListBox1.IntegralHeight = True
        RadioButton1.Text = "Uno"
        RadioButton2.Text = "Múltiple"
        RadioButton3.Text = "Extendida"
        ListBox1.SelectionMode = SelectionMode.None
        Button1.Text = "Limpiar"
        Button2.Text = "Traspasar Selección"
        CheckBox1.Text = "Ordenar"
        CheckBox2.Text = "Mostrar en columnas"
        Button3.Text = "Agregar"
        Button4.Text = "Buscar"
        Button5.Text = "Seleccionar por código"
        ListBox1.Sorted = False


    End Sub

    Private Sub grupoRadioButton(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        Dim seleccionado As Object = CType(sender, RadioButton)
        If seleccionado.Equals(RadioButton1) Then
            ListBox1.SelectionMode = SelectionMode.One
        ElseIf seleccionado.Equals(RadioButton2)
            ListBox1.SelectionMode = SelectionMode.MultiSimple
        Else
            ListBox1.SelectionMode = SelectionMode.MultiExtended


        End If
    End Sub

    Private Sub controlarBotones(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click
        Dim clicado As Object = CType(sender, Object)
        If clicado.Equals(Button1) Then
            TextBox1.Clear()
        ElseIf clicado.Equals(Button2)
            If RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked Then
                For Each kk In ListBox1.SelectedItems
                    TextBox1.Text += kk + vbCrLf
                Next
            Else
                MsgBox("Seleccione un RadioButton")
            End If

        ElseIf clicado.Equals(Button3)

            If TextBox2.Text.Length > 0 Then
                ListBox1.Items.Add(TextBox2.Text)
            Else
                MsgBox("Rellena el TextBox")
            End If
        ElseIf clicado.Equals(Button4)
            Dim aparicion As String = ListBox1.FindString(TextBox2.Text)

            If aparicion = ListBox.NoMatches Then
                MsgBox("No está en la lista")
            Else
                MsgBox("Está")
            End If
        Else
            ListBox1.ClearSelected()
            ListBox1.SelectionMode = SelectionMode.One
            ListBox1.SelectedIndex = CInt(ListBox1.FindString(TextBox2.Text))
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ListBox1.Sorted = True

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            ListBox1.MultiColumn = True
        Else
            ListBox1.MultiColumn = False

        End If
    End Sub

End Class
