Module Module1

    Sub Main()
        Dim array(4) As Integer
        Dim i, n As Integer
        Console.WriteLine("The Marks of 5 students::  ")
        array(0) = 23
        array(1) = 45
        array(2) = 46
        array(3) = 67
        array(4) = 12
        For i = 0 To 4
            Console.WriteLine("Output::  {0}", array(i))
        Next
        ReDim Preserve array(10)
        Console.WriteLine("After Entering the marks of more 6 students with the help of dynamic array:::  ")
        array(5) = 34
        array(6) = 89
        array(7) = 88
        array(8) = 27
        array(9) = 67
        array(10) = 78
        For i = 0 To 10
            Console.WriteLine("Output:::  {0}", array(i))
        Next
        Console.ReadLine()
    End Sub

End Module
