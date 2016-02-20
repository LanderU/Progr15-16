Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "CALCULADORA"
        Label1.Text = "EUROCALCULADORA"
        Label2.Text = "Importe en Pesetas"
        Label3.Text = "Importe en Euros"
        Button1.Text = "Cambiar €"
        Button2.Text = "Cambiar Pesetas"
        Button3.Text = "Salir"
    End Sub

    Private Sub operaciones(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click
        Dim pulsado As Object = CType(sender, Button)

        If pulsado.Equals(Button1) Then
            If TextBox1.Text.Length = 0 Then
                MsgBox("Escribe la cantidad a cambiar")
            Else
                Dim validar As Boolean
                Dim dato As Double
                Try
                    If CDbl(TextBox1.Text) Then
                        dato = TextBox1.Text
                        validar = True
                    End If
                Catch ex As Exception
                    validar = False
                End Try
                If validar Then
                    Dim resultado As Double = 0
                    resultado = dato / 166.38
                    TextBox2.Text = resultado
                Else
                    MsgBox("Dato no válido")
                End If
            End If
        ElseIf pulsado.Equals(Button2)
            If TextBox2.Text.Length = 0 Then
                MsgBox("Escribe la cantidad a cambiar")
            Else
                Dim validar As Boolean
                Dim dato As Double
                Try
                    If CDbl(TextBox2.Text) Then
                        dato = TextBox2.Text
                        validar = True
                    End If
                Catch ex As Exception
                    validar = False
                End Try
                If validar Then
                    Dim resultado As Double = 0
                    resultado = dato * 166.38
                    TextBox1.Text = resultado
                Else
                    MsgBox("Dato no válido")
                End If
            End If

        Else
            MsgBox("Gracias por usar la calculadora")
            Close()
        End If
    End Sub
    Private Sub controlarRaton(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter, TextBox2.MouseEnter
        Dim entro As Object = CType(sender, TextBox)

        If entro.Equals(TextBox1) Then
            TextBox1.Focus()
            TextBox1.SelectAll()
        Else
            TextBox2.Focus()
            TextBox2.SelectAll()
        End If

    End Sub
End Class
