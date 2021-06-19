Module Module1

    Sub Main()
        Dim array1(3, 3), array2(3, 3), array3(3, 3) As Integer
        Dim i, j As Integer
        Console.WriteLine("Enter the elements of First Matrix:::  ")
        For i = 0 To 2
            For j = 0 To 2
                array1(i, j) = Console.ReadLine()
            Next
            Console.WriteLine(" ")
        Next
        Console.WriteLine("Enter The elements of second matrix:::  ")
        For i = 0 To 2
            For j = 0 To 2
                array2(i, j) = Console.ReadLine()
            Next
            Console.WriteLine(" ")
        Next
        Console.WriteLine("Addition of 2 matrices:::  ")
        For i = 0 To 2
            For j = 0 To 2
                array3(i, j) = array1(i, j) + array2(i, j)
                Console.WriteLine("Output:::  {0}", array3(i, j))
            Next
            Console.WriteLine(" ")
        Next
        Console.ReadLine()
    End Sub

End Module
