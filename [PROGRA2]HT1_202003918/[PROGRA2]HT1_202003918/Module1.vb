Module Module1

    Sub Main()
        Problema5()
    End Sub

    Sub Problema1()
        Dim a, b, c As Integer

        Console.Write("numero a:  ")
        a = Console.ReadLine()
        Console.Write("numero b:  ")
        b = Console.ReadLine()
        Console.Write("numero c:  ")
        c = Console.ReadLine()


        Console.WriteLine("--------------------")
        Console.WriteLine("Resultado")

        If a > b And a > c Then
            Console.WriteLine(a)
            If b > c Then
                Console.WriteLine(b)
                Console.WriteLine(c)
            ElseIf c > b Or c = b Then
                Console.WriteLine(c)
                Console.WriteLine(b)
            End If
        End If

        If b > a And b > c Then
            Console.WriteLine(b)
            If a > c Then
                Console.WriteLine(a)
                Console.WriteLine(c)
            ElseIf c > a Or c = a Then
                Console.WriteLine(c)
                Console.WriteLine(a)
            End If
        End If

        If c > a And c > b Then
            Console.WriteLine(c)
            If a > b Then
                Console.WriteLine(a)
                Console.WriteLine(b)
            ElseIf b > a Or b = a Then
                Console.WriteLine(b)
                Console.WriteLine(a)
            End If
        End If

        If a = b And a > c Then
            Console.WriteLine(a)
            Console.WriteLine(b)
            Console.WriteLine(c)
        End If

        If b = c And b > a Then
            Console.WriteLine(b)
            Console.WriteLine(c)
            Console.WriteLine(a)
        End If

        If a = b = c Then
            Console.WriteLine(a)
            Console.WriteLine(b)
            Console.WriteLine(c)
        End If

        Console.ReadLine()
    End Sub

    Sub Problema2()
        Dim a, b, c As Integer

        Console.Write("numero a:  ")
        a = Console.ReadLine()
        Console.Write("numero b:  ")
        b = Console.ReadLine()
        Console.Write("numero c:  ")
        c = Console.ReadLine()

        Console.WriteLine("--------------------")
        Console.WriteLine("Resultado")

        If a = b And b = c Then
            Console.WriteLine("Equilátero")
        ElseIf a = b And Not a = c Then
            Console.WriteLine("Isosceles")
        ElseIf a = c And Not a = b Then
            Console.WriteLine("Isosceles")
        ElseIf b = c And Not a = b Then
            Console.WriteLine("Isosceles")
        ElseIf Not a = b And Not a = c And Not b = c Then
            Console.WriteLine("Escaleno")
        End If

        Console.ReadLine()
    End Sub

    Sub Problema3()
        Dim numero, suma, indice As Integer
        suma = 0
        Console.Write("Ingrese un numero:  ")
        numero = Console.ReadLine()

        Console.WriteLine("--------------------")
        Console.WriteLine("Resultado")

        For indice = 0 To numero
            Console.WriteLine(indice)
            suma = suma + indice
        Next
        Console.WriteLine("Suma de números: " & suma)

        If (suma Mod 2 = 0) Then
            Console.WriteLine("La suma es par")
        Else
            Console.WriteLine("La suma es impar")
        End If

        Console.ReadLine()
    End Sub

    Sub Problema4()
        Dim numero, indice As Double

        Console.Write("Ingrese un numero:  ")
        numero = Console.ReadLine()

        Console.WriteLine("--------------------")
        Console.WriteLine("Resultado")

        If numero >= 0 Then
            For indice = 0 To numero Step 2
                Console.WriteLine(indice)
            Next
        Else
            For indice = 0 To numero Step -0.5
                Console.WriteLine(indice)
            Next
        End If

        Console.ReadLine()
    End Sub
    Sub Problema5()
        Dim nota1, nota2, nota3, promediofinal As Double

        Console.Write("Matematicas:  ")
        nota1 = Console.ReadLine()
        Console.Write("Fisica:  ")
        nota2 = Console.ReadLine()
        Console.Write("Programacion:  ")
        nota3 = Console.ReadLine()
        promediofinal = (nota1 + nota2 + nota3) / 3

        Console.WriteLine("--------------------")
        Console.WriteLine("Resultado")
        Console.WriteLine("Promedio:  " & promediofinal)

        If promediofinal < 61 Then
            Console.WriteLine("Reprobado")
        ElseIf promediofinal >= 61 And promediofinal <= 80 Then
            Console.WriteLine("Regular")
        ElseIf promediofinal > 80 Then
            Console.WriteLine("Excelente")
        End If

        Console.ReadLine()
    End Sub
End Module
