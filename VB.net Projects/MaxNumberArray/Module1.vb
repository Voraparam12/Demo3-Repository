Module Module1

    Sub Main()
        Dim array(10) As Integer
        Dim i, n, max As Integer
        Console.WriteLine("Enter size of the array:::   ")
        n = Console.ReadLine()
        Console.WriteLine("Enter The elements:::   ")
        For i = 0 To n
            array(i) = Console.ReadLine()
        Next
        max = array(0)
        For i = 0 To n
            If (array(i) > max) Then
                max = array(i)
            End If
        Next
        Console.WriteLine("Largest element:::   {0}", max)
        Console.ReadLine()
    End Sub
End Module
