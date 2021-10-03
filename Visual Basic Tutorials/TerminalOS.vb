'YouTube link: https://www.youtube.com/watch?v=FHcHZXSlz_w

Imports System
Imports System.Net.NetworkInformation
Imports System.Text

Module Program
    Sub Main()
        While True
            Console.Write("C:\>")
            Command()
        End While
    End Sub

    Sub Command()
        Dim input As String = Nothing
        input = Console.ReadLine()

        'Commands
        If input = "forecolor:red" Then
            Console.ForegroundColor = ConsoleColor.Red
        ElseIf input = "forecolor:green" Then
            Console.ForegroundColor = ConsoleColor.Green
        ElseIf input = "ping" Then
            Ping()
        End If

    End Sub

    Sub Ping()
        Dim host As String
        Dim pingSender As New Ping()
        Dim options As New PingOptions()

        ' Prompt user for location to ping:
        Console.WriteLine("Enter server name to ping:")
        host = Console.ReadLine()

        ' Create a buffer of 32 bytes of data to be transmitted. 
        Dim data As String = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Dim buffer As Byte() = Encoding.ASCII.GetBytes(data)
        Dim timeout As Integer = 250
        Dim reply As PingReply = pingSender.Send(host, timeout, buffer, options)
        If reply.Status = IPStatus.Success Then
            Console.WriteLine("Address: {0}", reply.Address.ToString())
            Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime)
            Console.WriteLine("Time to live: {0}", reply.Options.Ttl)
            Console.WriteLine("Buffer size: {0}", reply.Buffer.Length)

            Console.WriteLine(" ")
            Call Main()
        Else
            Console.WriteLine("Error...!!")
            Call Main()
        End If
    End Sub
End Module
