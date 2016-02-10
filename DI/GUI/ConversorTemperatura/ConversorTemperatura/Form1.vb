Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Conversor de temperatura"
        Label1.Font = New Font("Arial", 15)
        Label1.Text = "ºC <==> ºF"
        Label2.Text = "G. Centigrados"
        Label3.Text = "G. Fharenheit"
        Button1.Text = "Convertir a F."
        Button2.Text = "Convertir a G."
        Button3.Text = "Salir"
    End Sub

    Private Sub botones(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click
        Dim pulsado As Object = CType(sender, Button)
        Dim cast As Int16
        Dim valor As Double
        If pulsado.Equals(Button1) Then
            Try
                If CDbl(TextBox1.Text) Then
                    cast = 0
                    valor = CDbl(TextBox1.Text)
                End If
            Catch ex As Exception
                cast = -1
            End Try

            If cast = 0 Then
                ' Hacemos la conversion
                valor = ((valor * 9) / 5) + 32
                TextBox2.Text = valor
            Else
                MsgBox("Escribe un número válido")
            End If



        ElseIf pulsado.Equals(Button2)
            Try
                If CDbl(TextBox2.Text) Then
                    cast = 0
                    valor = CDbl(TextBox2.Text)
                End If
            Catch ex As Exception
                cast = -1
            End Try

            If cast = 0 Then
                ' Hacemos la conversion
                valor = ((valor - 32) * 5) / 9
                TextBox1.Text = valor
            Else
                MsgBox("Escribe un número válido")
            End If
        Else
            Close()
        End If
    End Sub

    Private Sub seleccionarContenido(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter, TextBox2.MouseEnter
        Dim entro As Object = CType(sender, TextBox)
        If entro.Equals(TextBox1) Then
            TextBox1.SelectAll()
        Else
            TextBox2.SelectAll()
        End If
    End Sub
End Class
