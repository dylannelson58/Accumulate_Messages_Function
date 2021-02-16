Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265
'Spring 2021
'Accumulate Messages Function
'https://github.com/dylannelson58/Accumulate_Messages_Function
Module Accumulate_Messages_Function

    Sub Main()
        Dim userInput As String

        Console.WriteLine("What is your name?")
        userInput = Console.ReadLine()
        UserInputCheck(userInput)

        Console.WriteLine("What is your age?")
        userInput = Console.ReadLine()
        UserInputCheck(userInput)

        Console.WriteLine("what is you favorite color?")
        userInput = Console.ReadLine()
        UserInputCheck(userInput)


        MsgBox(UserMessages("", False))
        Console.Read()

    End Sub
    Function UserInputCheck(ByVal userInput As String) As String
        If userInput = "" Then
            Return UserMessages(($"{userInput}"), True)
        Else
            Return UserMessages(($"{userInput}"), False)
        End If
    End Function
    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static messages As String
        If Not clear Then
            messages &= newMessage & vbNewLine
        Else
            messages = ""
        End If
        Return messages
    End Function


End Module
