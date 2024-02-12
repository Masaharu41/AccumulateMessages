'Owen Fujii
'RCET 2265
'Spring 2024
'Accumulated Messages
'https://github.com/Masaharu41/AccumulateMessages.git

Option Explicit On
Option Strict On

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        ' Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(ByRef newMessage As String, ByVal clear As Boolean) As String
        Dim accumulatedMessages$
        Static priorMessages As String
        'If structure to clear or enter normal code
        If clear = True Then
            priorMessages = ""
            accumulatedMessages = ""
        ElseIf clear = False Then
            'Multi use If structure which rejects when the input is "" 
            'Will track and accumulate the string values until a clear statement is applied.
            'Contains the special ReadBack case that will return the accumulated data
            If newMessage = "" Then
                accumulatedMessages = ""
            ElseIf newMessage = "ReadBack" Then
                accumulatedMessages = priorMessages
            Else
                accumulatedMessages = priorMessages & newMessage & vbCrLf
                priorMessages = accumulatedMessages
            End If
        End If

        Return accumulatedMessages
    End Function

    'Sub main()
    '    sayGoodBye()
    '    'tellMeASecret()
    '    Console.Read()
    'End Sub

    'Public Sub sayGoodBye()
    '    Console.WriteLine("Later dudes...")
    'End Sub
    'Public Sub tellMeASecret()
    '    Console.WriteLine("Hush...")
    'End Sub
End Module
