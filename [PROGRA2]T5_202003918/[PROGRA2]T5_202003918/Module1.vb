Module Module1

    Sub Main()
        Dim acum, i, indice, num, contador As Integer
        Console.Write("Ingrese numero: ")
        num = Console.ReadLine()
        acum = 1

        For i = 1 To num
            acum = acum * i
        Next
        Console.WriteLine("Factorial: " & acum)
        Console.WriteLine("")
        Console.WriteLine("Multiplos de 4:")


        indice = -1
        contador = 0
        While (indice <= acum)
            indice = indice + 1
            If Not (indice Mod 4 = 0) Then
                Continue While
            Else
                contador = contador + 1
            End If
            Console.WriteLine(indice)
        End While

        Console.WriteLine("Hay " & contador.ToString & " multiplos de 4")

        Console.ReadLine()
    End Sub

End Module
