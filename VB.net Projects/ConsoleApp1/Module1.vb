Module Module1


    Sub Main(args As String())
        Dim a As Integer = 10
        Do
            Console.Write(a & " ")
            a = a + 1
        Loop Until (a < 20)

        Console.ReadLine()
    End Sub

End Module
