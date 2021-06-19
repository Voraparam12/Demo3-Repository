Module module1
    Sub main()
        'Program with all the loops tried in it
        Dim i As Integer = 0
        Dim choice As Integer
        'Do While (i <= 50)
        'Console.WriteLine("value of i: {0}", i)
        'i = i + 2
        'Loop
        '  Do
        'Console.WriteLine("value of i::: {0}", i)
        'i = i + 2
        'Loop While (i <= 50)

        'For i = 0 To 50
        'Console.WriteLine("Value of I::::  {0}", i)
        'i = i + 1
        'Next

        'While (i <= 50)
        'Console.WriteLine("Value of i:::  {0}", i)
        'i = i + 2
        'End While
        Console.WriteLine("Enter the choice::::   ")
        choice = Console.ReadLine()

        Select Case choice
            Case 1
                Do While (i <= 50)
                    Console.WriteLine("Value of i::: {0}", i)
                    i = i + 2
                Loop
            Case 2
                Do
                    Console.WriteLine("VAlue of I:::  {0}", i)
                    i = i + 2
                Loop While (i <= 50)
            Case 3
                For i = 0 To 50
                    Console.WriteLine("Value of i::::  {0}", i)
                    i = i + 1
                Next
            Case 4
                While (i <= 50)
                    Console.WriteLine("VAlue of I::::  {0}", i)
                    i = i + 2
                End While
        End Select
        Console.ReadLine()
    End Sub
End Module