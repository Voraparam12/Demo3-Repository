Module Module1
    Function Area(ByVal r As Integer) As Double
        Dim pi As Double = 3.14
        Dim c As Double
        c = pi * r * r
        Return c
    End Function

    Function Square(ByVal l As Integer, ByVal result As Double) As Double
        result = l * l
        Return result
    End Function

    Function Multiplication(ByVal a As Integer, ByVal b As Integer, ByVal f As Double) As Integer 'Assignning the value of first parameter to a varible as it was showing error
        Dim d As Integer
        d = a * b * f
        Return d
    End Function

    Sub Main()
        Dim ans As Double
        Dim radius As Double
        Dim length As Integer
        Dim answer As Integer
        Dim r As Integer
        Dim q As Integer
        Dim final As Integer
        Console.WriteLine("Enter Radius to Calculate Area::: ")
        radius = Console.ReadLine()
        ans = Area(radius)
        Console.WriteLine("Area Of Circle::::  {0}", ans)
        Console.WriteLine("Enter the Length Of square::  ")
        length = Console.ReadLine()
        answer = Square(length, answer)
        Console.WriteLine("Area Of Square:::  {0}", answer)
        Console.WriteLine("Enter the value of 2 varibles And the 3rd one is fixed::   ")
        r = Console.ReadLine()
        q = Console.ReadLine()
        final = Multiplication(5, r, q)
        Console.WriteLine("Multiplication of 3 numbers:::  {0}", final)
        Console.ReadLine()
    End Sub
End Module
