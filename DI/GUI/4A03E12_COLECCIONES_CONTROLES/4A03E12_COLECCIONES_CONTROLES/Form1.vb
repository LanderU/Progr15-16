Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "CAMBIO DE COLORES"
        Label2.Text = "Nombre"
        Label3.Text = "1º Apellido"
        Label4.Text = "2º Apellido"
        Button1.Text = "Salir"
        Button2.Text = "Etiquetas Rojas"
        Button3.Text = "Cajas Verdes"
        Button4.Text = "Botones Azules"
    End Sub

    Private Sub botonSalir(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub botonEtiquetasRojas(sender As Object, e As EventArgs) Handles Button2.Click
        For Each control As Control In Me.Controls
            If (TypeOf control Is Label) Then
                control.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub colorBoton(sender As Object, e As EventArgs) Handles Button4.Click
        For Each control As Control In Me.Controls
            If (TypeOf control Is Button) Then
                control.BackColor = Color.Blue
            End If
        Next
    End Sub

    Private Sub colorCajaTexto(sender As Object, e As EventArgs) Handles Button3.Click
        For Each control As Control In Me.Controls
            If (TypeOf control Is TextBox) Then
                control.BackColor = Color.Green
            End If
        Next
    End Sub
End Class
