Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim acum, i, num As Integer
        acum = 1
        num = Val(TextBox1.Text)
        If (num > 0) And (num < 13) Then
            For i = 1 To num
                acum = acum * i
            Next
            Label2.Text = acum.ToString
        ElseIf num < 0 Then
            Label2.Text = "Por favor ingrese un número positivo"
        ElseIf num > 13 Then
            Label2.Text = "El valor ingresado es muy grande"
        Else
            Label2.Text = "Por favor ingrese un número"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = ""
        TextBox1.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class
