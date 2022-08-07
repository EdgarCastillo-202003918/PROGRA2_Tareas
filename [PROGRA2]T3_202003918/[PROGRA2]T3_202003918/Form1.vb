Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double = TextBox1.Text
        Dim y As Double = TextBox2.Text
        Dim resultado As Object

        If RadioButton1.Checked Then
            resultado = Val(x) + Val(y)
        ElseIf RadioButton2.Checked Then
            resultado = Val(x) - Val(y)
        ElseIf RadioButton3.Checked Then
            resultado = Val(x) * Val(y)
        ElseIf RadioButton4.Checked Then
            resultado = Val(x) / Val(y)
        Else
            MsgBox("Por favor seleccione una operación")
            resultado = "Esperando su selección"
        End If

        Label4.Text = resultado
    End Sub
End Class
