Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Cerramos la aplicación")
        Close()
    End Sub

    Private Sub ponerseEncimaBotonSalir(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Cyan
    End Sub

    Private Sub estarFueraBotonSalir(sender As Object, e As EventArgs) Handles Button1.MouseLeave

        Button1.ResetBackColor()

    End Sub

    Private Sub clicarAbajo(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        AddHandler Button2.Click, AddressOf funcionLlamada
    End Sub

    Private Sub funcionLlamada(sender As Object, e As EventArgs)
        Text = "Prueba"
    End Sub
End Class
