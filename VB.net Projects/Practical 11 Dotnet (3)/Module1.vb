Module Module1
    Sub Callbyvalue(ByVal a As Integer, ByVal b As Integer)
        Dim temp As Integer
        temp = a
        a = b
        b = temp
        Console.WriteLine("Value of A:::  {0}", a) ' Printing the value of the variables here itself because in call by value it prints only the formal parameters 
        Console.WriteLine("Value of B:::  {0}", b)
    End Sub

    Sub Callbyreference(ByRef q As Integer, ByRef w As Integer)
        Dim temp As Integer
        temp = q
        q = w
        w = temp
    End Sub

    Sub Main()
        Dim x As Integer = 3
        Dim y As Integer = 4
        Callbyvalue(5, 6)
        Callbyreference(x, y)
        Console.WriteLine("After Swapping X::  {0}", x)
        Console.WriteLine("After Swapping Y::  {0}", y)
        Console.ReadLine()
    End Sub
End Module
