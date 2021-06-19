Module Module1
    Sub sample()
        Console.WriteLine("Name: Hasnain Makada")
    End Sub
    Sub Area(ByVal r As Integer)
        Console.WriteLine("Enter the radius to calculate area:::  ")
        r = Console.ReadLine()
        Dim Pi As Double = 3.14
        Dim c As Double
        c = Pi * r * r
        Console.WriteLine("Area of circle::  {0}", c)
    End Sub
    Sub square(ByVal l As Integer, ByVal x As Integer)
        Console.WriteLine("Enter the length of Square:::  ")
        l = Console.ReadLine()
        x = l * l
        Console.WriteLine("Area Of Square::  {0}", x)
    End Sub
    Sub Cube(ByVal a As Integer, ByVal b As Integer, ByVal q As Integer)
        Dim w As Integer
        Console.WriteLine("Enter 3 numbers to multiply:::  ")
        a = Console.ReadLine()
        b = Console.ReadLine()
        q = Console.ReadLine()
        w = a * b * q
        Console.WriteLine("Multiplication of 3 numbers:::  {0}", w)
    End Sub
    Sub main()
        sample()
        Area(0)
        square(0, 0)
        Cube(3, 4, 5)
        Console.ReadLine()
    End Sub
End Module
