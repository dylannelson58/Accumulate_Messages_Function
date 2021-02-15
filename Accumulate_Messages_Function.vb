Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265
'Spring 2021
'Accumulate Messages Function
'https://github.com/dylannelson58/Accumulate_Messages_Function
Module Accumulate_Messages_Function

    Sub Main()

        Dim UserInput As Integer
        Dim problem As Boolean = True

        Console.WriteLine($"Which Message would you like to recall?")
        Console.WriteLine($"1, 2 , 3, 4, 5, or 6?")

        UserInput = CInt(Console.ReadLine)

        If UserInput = CInt("1") Then
            Console.WriteLine("Message 1:")
        ElseIf UserInput = CInt("2") Then
            Console.WriteLine("Message 2:")
        ElseIf UserInput = CInt("3") Then
            Console.WriteLine("Message 3:")
        ElseIf UserInput = CInt("4") Then
            Console.WriteLine("temp = ??")
        ElseIf UserInput = CInt("5") Then
            Console.WriteLine("Message 3:")
        ElseIf UserInput = CInt("6") Then
            Console.WriteLine("Message 6:")
        Else
            While UserInput > 6 And problem = True
                Try
                    UserInput = CInt(Console.ReadLine)
                    problem = False
                Catch ex As Exception
                    Console.WriteLine($"Please enter a number between 1 and 6.")
                    problem = True

                End Try
            End While
        End If

        Console.ReadLine()


    End Sub

End Module
