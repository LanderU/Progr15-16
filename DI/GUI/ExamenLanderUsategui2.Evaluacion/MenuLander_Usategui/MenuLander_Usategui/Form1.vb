Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Prueba con opciones de menú"
        Label1.Text = "Introducir valor"
        Button1.Text = "Habilitar/Deshabilitar"
        Button2.Text = "Mostrar/Ocultar"
        Button3.Text = "Cambiar nombre"
        TextBox1.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub controlarMenu(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click, PegarToolStripMenuItem.Click, CopiarToolStripMenuItem.Click, CortarToolStripMenuItem.Click
        Dim seleccionMenu As Object = CType(sender, ToolStripMenuItem)

        If seleccionMenu.Equals(SalirToolStripMenuItem) Then
            Close()
        ElseIf seleccionMenu.Equals(PegarToolStripMenuItem)
            If Clipboard.GetText.Length = 0 Then
                MsgBox("No has seleccionado nada para copiar")
            Else
                If Clipboard.GetText.Length = 0 Then
                    MsgBox("No hay nada que pegar")
                Else
                    TextBox1.Text += Clipboard.GetText
                End If
            End If
        ElseIf seleccionMenu.Equals(CortarToolStripMenuItem)
            If TextBox1.Text.Length = 0 Then
                MsgBox("Escribe algo en el textBox para cortar")
            Else
                If TextBox1.SelectedText.Length = 0 Then
                    MsgBox("Seleciona lo que quieres cortar")
                Else
                    Clipboard.SetText(TextBox1.SelectedText)
                    TextBox1.SelectedText = ""
                End If
            End If
        Else
            If TextBox1.Text.Length = 0 Then
                MsgBox("Escribe algo para poder copiar")
            Else
                If TextBox1.SelectedText.Length = 0 Then
                    MsgBox("Selecciona algo para copiar")
                Else
                    Clipboard.SetText(TextBox1.SelectedText)
                End If

            End If
        End If

    End Sub
    Private Sub controlBotones(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click
        Dim pulsado As Object = CType(sender, Button)

        If pulsado.Equals(Button1) Then
            If MenuStrip1.Enabled = True Then
                MenuStrip1.Enabled = False
            Else
                MenuStrip1.Enabled = True
            End If

        ElseIf pulsado.Equals(Button2)

            If MainMenuStrip.Visible = True Then
                MainMenuStrip.Visible = False
            Else
                MainMenuStrip.Visible = True
            End If
        Else

            Me.Text = "Lander"


        End If
    End Sub

    Private Sub ArialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArialToolStripMenuItem.Click
        TextBox1.Font = New Font("Arial", 12)
    End Sub

    Private Sub TimesNewRomanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimesNewRomanToolStripMenuItem.Click
        TextBox1.Font = New Font("Times New Roman", 14)
    End Sub

    Private Sub ComicSansToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComicSansToolStripMenuItem.Click
        TextBox1.Font = New Font("Comic Sans", 18)
    End Sub

    Private Sub MinusculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinusculasToolStripMenuItem.Click
        TextBox1.Text = TextBox1.Text.ToLower

    End Sub

    Private Sub MayusculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MayusculasToolStripMenuItem.Click
        TextBox1.Text = TextBox1.Text.ToUpper
    End Sub
End Class
