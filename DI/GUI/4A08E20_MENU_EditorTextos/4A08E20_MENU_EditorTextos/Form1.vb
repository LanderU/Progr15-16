Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.SizeChanged
        Me.Text = "Editor de Textos"
        ' Barra de scroll
        TextBox1.ScrollBars = ScrollBars.Both
        ' Alinear el textbox
        TextBox1.Top = MenuStrip1.Bottom
        TextBox1.Left = 0
        TextBox1.Width = Me.ClientSize.Width
        TextBox1.Height = Me.ClientSize.Height
        ' Formato(estilo de letra tamaño etc) por defecto del TextBox
        TextBox1.Font = New Font("Arial", 10)
        TextBox1.BackColor = Color.White
        TextBox1.ForeColor = Color.Black
        ' Chekear los botones en el menú
        BlancoToolStripMenuItem.Checked = True
        NegroToolStripMenuItem.Checked = True
        ArielToolStripMenuItem.Checked = True
        ToolStripMenuItem2.Checked = True
    End Sub

    Private Sub controlarMenu(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click, AcercaDeToolStripMenuItem.Click, CopiarToolStripMenuItem.Click, CortarToolStripMenuItem.Click, PegarToolStripMenuItem.Click, NewCourierToolStripMenuItem.Click, ArielToolStripMenuItem.Click, SymbolToolStripMenuItem.Click, BlancoToolStripMenuItem.Click, VerdeToolStripMenuItem.Click, AzulToolStripMenuItem.Click, NegroToolStripMenuItem.Click, AzulToolStripMenuItem1.Click, VerdeToolStripMenuItem1.Click, ToolStripMenuItem2.Click, ToolStripMenuItem3.Click, ToolStripMenuItem4.Click
        Dim seleccionado As Object = CType(sender, ToolStripMenuItem)
        If seleccionado.Equals(SalirToolStripMenuItem) Then
            Close()
        ElseIf seleccionado.Equals(AcercaDeToolStripMenuItem)
            ' Creamos una nueva ventana
            Dim acercade As Form = New Form()
            acercade.Text = "Contacta con nosotros"
            'Creamo un nuevo textbox para nuestra información y lo añadimos a los controles del nuevo formulario
            Dim textboxacercade As TextBox = New TextBox
            acercade.Controls.Add(textboxacercade)
            ' Le damos las dimensiones que queremos para que se vea bien nuestro texto
            textboxacercade.ReadOnly = True
            textboxacercade.AutoSize = False
            textboxacercade.Size = New Size(200, 25)
            textboxacercade.Location = New Point(50, 100)
            textboxacercade.Text = "Correo del mantenedor: lander.usategui@gmail.com"
            ' Ocultamos el anterior form (el que se carga al iniciar)
            Me.Hide()
            ' Mostramos el nuevo formulario con showDialog, lo dejamos en ejecución gasta pulsar la "x"
            acercade.ShowDialog()
            ' Eliminamos de memoria el formulario creado
            acercade.Dispose()
            ' Volvemos a mostrar la ventana inicial
            Me.Show()
        ElseIf seleccionado.Equals(CortarToolStripMenuItem)
            If TextBox1.SelectedText.Count = 0 Then
                MsgBox(" No has seleccionado nada que cortar")
            Else
                Clipboard.SetText(TextBox1.SelectedText)
                TextBox1.SelectedText = ""
            End If
        ElseIf seleccionado.Equals(CopiarToolStripMenuItem)
            If TextBox1.SelectedText.Count = 0 Then
                MsgBox("No has seleccionado nada que copiar")
            Else
                Clipboard.SetText(TextBox1.SelectedText)
            End If
        ElseIf seleccionado.Equals(PegarToolStripMenuItem)
            TextBox1.Text += Clipboard.GetText
        ElseIf seleccionado.Equals(NewCourierToolStripMenuItem)
            NewCourierToolStripMenuItem.Checked = True
            ArielToolStripMenuItem.Checked = False
            SymbolToolStripMenuItem.Checked = False
            If ToolStripMenuItem2.Checked Then
                TextBox1.Font = New Font("New Courier", 10)
            ElseIf ToolStripMenuItem3.Checked
                TextBox1.Font = New Font("New Courier", 12)
            Else
                TextBox1.Font = New Font("New Courier", 24)
            End If
        ElseIf seleccionado.Equals(ArielToolStripMenuItem)
            ArielToolStripMenuItem.Checked = True
            SymbolToolStripMenuItem.Checked = False
            NewCourierToolStripMenuItem.Checked = False
            If ToolStripMenuItem2.Checked Then
                TextBox1.Font = New Font("Arial", 10)
            ElseIf ToolStripMenuItem3.Checked
                TextBox1.Font = New Font("Arial", 12)
            Else
                TextBox1.Font = New Font("Arial", 24)
            End If
        ElseIf seleccionado.Equals(SymbolToolStripMenuItem)
            ArielToolStripMenuItem.Checked = False
            SymbolToolStripMenuItem.Checked = True
            NewCourierToolStripMenuItem.Checked = False
            If ToolStripMenuItem2.Checked Then
                TextBox1.Font = New Font("Symbol", 10)
            ElseIf ToolStripMenuItem3.Checked
                TextBox1.Font = New Font("Symbol", 12)
            Else
                TextBox1.Font = New Font("Symbol", 24)
            End If
        ElseIf seleccionado.Equals(ToolStripMenuItem2)
            ToolStripMenuItem3.Checked = False
            ToolStripMenuItem4.Checked = False
            ToolStripMenuItem2.Checked = True
            If ArielToolStripMenuItem.Checked Then
                TextBox1.Font = New Font("Arial", 10)
            ElseIf SymbolToolStripMenuItem.Checked
                TextBox1.Font = New Font("Symbol", 10)
            Else
                TextBox1.Font = New Font("New Curier", 10)
            End If
        ElseIf seleccionado.Equals(ToolStripMenuItem3)
            ToolStripMenuItem3.Checked = True
            ToolStripMenuItem4.Checked = False
            ToolStripMenuItem2.Checked = False
            If ArielToolStripMenuItem.Checked Then
                TextBox1.Font = New Font("Arial", 12)
            ElseIf SymbolToolStripMenuItem.Checked
                TextBox1.Font = New Font("Symbol", 12)
            Else
                TextBox1.Font = New Font("New Curier", 12)
            End If
        ElseIf seleccionado.Equals(ToolStripMenuItem4)
            ToolStripMenuItem3.Checked = False
            ToolStripMenuItem4.Checked = True
            ToolStripMenuItem2.Checked = False
            If ArielToolStripMenuItem.Checked Then
                TextBox1.Font = New Font("Arial", 24)
            ElseIf SymbolToolStripMenuItem.Checked
                TextBox1.Font = New Font("Symbol", 24)
            Else
                TextBox1.Font = New Font("New Curier", 24)
            End If
        ElseIf seleccionado.Equals(BlancoToolStripMenuItem)
            VerdeToolStripMenuItem.Checked = False
            AzulToolStripMenuItem.Checked = False
            BlancoToolStripMenuItem.Checked = True
            TextBox1.BackColor = Color.White
        ElseIf seleccionado.Equals(VerdeToolStripMenuItem)
            VerdeToolStripMenuItem.Checked = True
            AzulToolStripMenuItem.Checked = False
            BlancoToolStripMenuItem.Checked = False
            TextBox1.BackColor = Color.Green
        ElseIf seleccionado.Equals(AzulToolStripMenuItem)
            VerdeToolStripMenuItem.Checked = False
            AzulToolStripMenuItem.Checked = True
            BlancoToolStripMenuItem.Checked = False
            TextBox1.BackColor = Color.Blue
        ElseIf seleccionado.Equals(NegroToolStripMenuItem)
            NegroToolStripMenuItem.Checked = True
            AzulToolStripMenuItem1.Checked = False
            VerdeToolStripMenuItem1.Checked = False
            TextBox1.ForeColor = Color.Black
        ElseIf seleccionado.Equals(AzulToolStripMenuItem1)
            NegroToolStripMenuItem.Checked = False
            AzulToolStripMenuItem1.Checked = True
            VerdeToolStripMenuItem1.Checked = False
            TextBox1.ForeColor = Color.Blue
        Else
            NegroToolStripMenuItem.Checked = False
            AzulToolStripMenuItem1.Checked = False
            VerdeToolStripMenuItem1.Checked = True
            TextBox1.ForeColor = Color.Green
        End If
    End Sub
End Class
