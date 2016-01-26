Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = "Fuente"
        GroupBox2.Text = "Color"
        RadioButton1.Text = "Tahoma"
        RadioButton2.Text = "Garamond"
        RadioButton3.Text = "Comic Sans"
        RadioButton1.Font = New Font("Tahoma", 12)
        RadioButton2.Font = New Font("Garamond", 12)
        RadioButton3.Font = New Font("Comic Sans MS", 12)
        RadioButton4.BackColor = Color.Green
        RadioButton5.BackColor = Color.Blue
        RadioButton6.BackColor = Color.Yellow
        RadioButton4.Text = "Verde"
        RadioButton5.Text = "Azul"
        RadioButton6.Text = "Amarillo"

    End Sub

    Private Sub pulsarCheckBoxGrupo1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        Dim seleccionado As Object = CType(sender, RadioButton)
        If seleccionado.Equals(RadioButton1) Then
            TextBox1.Font = New Font("Tahoma", 12)
        ElseIf seleccionado.Equals(RadioButton2)
            TextBox1.Font = New Font("Garamond", 12)
        Else
            TextBox1.Font = New Font("Commic Sans MS", 12)
        End If
    End Sub

    Private Sub pulsarCheckBoxGrupo2(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged
        Dim seleccionado As Object = CType(sender, RadioButton)
        If seleccionado.Equals(RadioButton4) Then
            TextBox1.BackColor = Color.Green
        ElseIf seleccionado.Equals(RadioButton5)
            TextBox1.BackColor = Color.Blue
        Else
            TextBox1.BackColor = Color.Yellow
        End If
    End Sub
End Class
