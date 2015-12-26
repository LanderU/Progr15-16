Public Class Form1
    ' Array con el tablero 3 = Bomba
    ' Dim tablero = {
    '                    {3, 1, 0, 0, 0, 0}, ' Fila 1
    '                   {1, 0, 1, 0, 0, 0}, ' Fila 2
    '                  {0, 1, 3, 1, 1, 0}, ' Fila 3
    '                 {0, 0, 1, 1, 3, 1}, ' Fila 4
    '                {1, 0, 0, 1, 1, 0}, ' Fila 5
    '               {3, 1, 1, 3, 1, 0}  ' Fila 6
    '         }


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Button37.Enabled = False
    End Sub
    ' Método que recoge el pulsado de todos los botones.
    Private Sub pulsacion(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click
        ' Hacemos el cast del botón un una variable, no es necesario lo hace por si mismo, es por pulcritud mental
        Dim boton_clicado As Button = CType(sender, Button)
        pulsado(boton_clicado)
    End Sub
    Private Sub checkWinner(ByRef boton_clicado)
        If boton_clicado.Equals(Button1) Or boton_clicado.Equals(Button15) Or boton_clicado.Equals(Button23) Or boton_clicado.Equals(Button31) Or boton_clicado.Equals(Button34) Then
            boton_clicado.BackColor = Color.Red
            Label2.Visible = True
            Button37.Enabled = True
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
            Button16.Enabled = False
            Button17.Enabled = False
            Button18.Enabled = False
            Button19.Enabled = False
            Button20.Enabled = False
            Button21.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
            Button25.Enabled = False
            Button26.Enabled = False
            Button27.Enabled = False
            Button28.Enabled = False
            Button29.Enabled = False
            Button30.Enabled = False
            Button31.Enabled = False
            Button32.Enabled = False
            Button33.Enabled = False
            Button34.Enabled = False
            Button35.Enabled = False
            Button36.Enabled = False
        ElseIf Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False And Button10.Enabled = False And Button11.Enabled = False And Button12.Enabled = False And Button13.Enabled = False And Button14.Enabled = False And Button16.Enabled = False And Button17.Enabled = False And Button18.Enabled = False And Button19.Enabled = False And Button20.Enabled = False And Button21.Enabled = False And Button22.Enabled = False And Button24.Enabled = False And Button25.Enabled = False And Button26.Enabled = False And Button27.Enabled = False And Button28.Enabled = False And Button29.Enabled = False And Button30.Enabled = False And Button32.Enabled = False And Button33.Enabled = False And Button35.Enabled = False And Button36.Enabled = False
            Label1.Text = "¡Txapeldun!"
            Button37.Enabled = True
        End If
    End Sub
    ' Controlamos el pulso del botón
    Private Sub pulsado(ByRef boton_clicado)
        boton_clicado.Enabled = False
        If boton_clicado.Equals(Button1) Then
            'checkWinner(boton_clicado)
            boton_clicado.BackColor = Color.Red

        ElseIf boton_clicado.Equals(Button2)
            boton_clicado.text = "1"
            'checkWinner(boton_clicado)
        ElseIf boton_clicado.Equals(Button7)
            boton_clicado.Text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button9)
            boton_clicado.Text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button14)
            boton_clicado.Text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button15)
            'checkWinner(boton_clicado)
        ElseIf boton_clicado.Equals(Button16)
            boton_clicado.text = "1"
            ' checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button17)
            boton_clicado.Text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button21)
            boton_clicado.Text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button22)
            boton_clicado.text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button23)
            'checkWinner(boton_clicado)
            boton_clicado.BackColor = Color.Red

        ElseIf boton_clicado.Equals(Button24)
            boton_clicado.Text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button25)
            boton_clicado.Text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button28)
            boton_clicado.text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button29)
            boton_clicado.Text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button31)
            'checkWinner(boton_clicado)
            boton_clicado.BackColor = Color.Red

        ElseIf boton_clicado.Equals(Button32)
            boton_clicado.Text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button33)
            boton_clicado.Text = "1"
            'checkWinner(boton_clicado)

        ElseIf boton_clicado.Equals(Button34)
            'checkWinner(boton_clicado)
            boton_clicado.BackColor = Color.Red

        ElseIf boton_clicado.Equals(Button35)
            boton_clicado.Text = "1"
            ' checkWinner(boton_clicado)

        Else
            boton_clicado.BackColor = Color.Green
        End If
        checkWinner(boton_clicado)
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Close()
    End Sub
End Class
