Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Prueba Menú"
        ToolStripMenuItem1.Text = "Menú"
        ToolStripMenuItem2.Text = "Copiar"
        ToolStripMenuItem3.Text = "Cortar"
        ToolStripMenuItem4.Text = "Pegar"
        TextBox1.ContextMenuStrip = ContextMenuStrip1
        ' Lo ignora
        'ToolStripMenuItem2.ShortcutKeys = Keys.Control.C
        'ToolStripMenuItem2.ShowShortcutKeys = True

    End Sub

    Private Sub pulsarItemMenu(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click, ToolStripMenuItem3.Click, ToolStripMenuItem4.Click
        Dim opcion As Object = CType(sender, ToolStripMenuItem)
        If opcion.Equals(ToolStripMenuItem2) Then
            If TextBox1.Text.Count = 0 Then
                MsgBox("No hay nada que copiar")
            Else
                Clipboard.SetText(TextBox1.SelectedText)
            End If
        ElseIf opcion.Equals(ToolStripMenuItem3)
            If TextBox1.Text.Count = 0 Then
                MsgBox("No hay nada que cortar")
            Else
                Clipboard.SetText(TextBox1.SelectedText)
                'depurar
                'TextBox1.SelectedText.Remove(TextBox1.SelectionStart, TextBox1.SelectionLength - 1)
                TextBox1.SelectedText = ""
            End If
        Else
            If Clipboard.GetText.Count = 0 Then
                MsgBox("No hay nada que pegar")
            Else
                TextBox1.Text += Clipboard.GetText
            End If
        End If
    End Sub
    Private Sub botonDerecho(sender As Object, e As EventArgs) Handles MayusculasToolStripMenuItem.Click, MinúsculasToolStripMenuItem.Click, ArialToolStripMenuItem.Click, TimesNewRomanToolStripMenuItem.Click, CalibriToolStripMenuItem.Click
        Dim seleccionado As Object = CType(sender, ToolStripMenuItem)
        If seleccionado.Equals(MayusculasToolStripMenuItem) Then
            TextBox1.Text = TextBox1.Text.ToUpper
        ElseIf seleccionado.Equals(MinúsculasToolStripMenuItem)
            TextBox1.Text = TextBox1.Text.ToLower
        ElseIf seleccionado.Equals(ArialToolStripMenuItem)
            TextBox1.Font = New Font("Arial", 14)
        ElseIf seleccionado.Equals(TimesNewRomanToolStripMenuItem)
            TextBox1.Font = New Font("Times New Roman", 14)
        Else
            TextBox1.Font = New Font("Calibri", 14)
        End If

    End Sub
End Class
