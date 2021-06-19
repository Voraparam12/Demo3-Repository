Imports System
Module module2
	Sub main()
		Dim a As Integer
		Dim b As Integer
		Console.WriteLine("Enter 2 numbers::  ")
		a = Console.ReadLine()
		b = Console.ReadLine()
		If (a And b) Then
			Console.WriteLine("And Condition is true")
		End If
		If (a Or b) Then
			Console.WriteLine("Or Condition is true")
		End If
		If (a Xor b) Then
			Console.WriteLine("Xor Condition is true")
		End If
		Console.ReadKey()
	End Sub
End Module