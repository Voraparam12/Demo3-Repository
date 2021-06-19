Imports System
Public Module Module1
    Public Sub Main()
        Dim a() As Char = {"A", "B", "C", "D", "E"}
        Dim i As Integer = 5
        Dim j As Integer
        While (i >= 0)
            j = 0
            While (j < i)
                Console.Write("{0}", a(j))
                j += 1
            End While
            Console.Write(" ")
            i -= 1
        End While
        Console.ReadKey()
    End Sub
End Module