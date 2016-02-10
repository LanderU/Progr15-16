Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Prueba InputBox"
        Label1.Text = "DATOS"
        Label2.Text = "Nombre: "
        Label3.Text = "Apellido: "
        Label4.Text = "Edad: "
        Button1.Text = "Salir"
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""

        Dim nombre As String
        Dim apellido As String
        Dim edad As Integer

        Dim input1 = InputBox(nombre, "Introduzca su nombre")
        Dim input2 = InputBox(apellido, "Introduzca su apellido")
        Dim input3 = InputBox(edad, "Introduzca su edad")

        If input1.Count <> 0 Then
            Label5.Text = input1.ToString
        End If
        If input2.Count <> 0 Then
            Label6.Text = input2.ToString
        End If
        If input3.Count <> 0 Then
            Label7.Text = input3.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
