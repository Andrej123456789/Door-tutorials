Imports System
Imports System.Net.NetworkInformation
Imports System.Text

Module Program

    Dim Path As String = "C:\>"

    Sub Main()

        Dim start As Integer
        start = 1
        Dim quit As Integer
        quit = 2

        Dim command As String = Nothing

        Console.WriteLine("
            ringwormGO COMMAND OS
            Commands from Python OS, but final file is '.exe'
        ")

        Console.WriteLine(" ")
        Console.Write("(©) 2021 - ringwormGO and Door Comapny ~ contact: ringwormgo@gmail.com")
        Console.WriteLine(" ")
        Console.WriteLine("Welcome")
        Console.WriteLine("Type command: ")
        Console.WriteLine(" ")
        Console.Write("C:\>")

        command = Console.ReadLine()

        If command = "print" Then
            Call Ispis()
        ElseIf command = "while" Then
            Call Tijekom()
        ElseIf command = "clear" Then
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        ElseIf command = "backcolor" Then
            Call ColorBack()
        ElseIf command = "forecolor" Then
            Call ForeColor()
        ElseIf command = "help" Then
            Call Help()
        ElseIf command = "about" Then
            Call About()
        ElseIf command = "cd" Then
            Call Directory()
        ElseIf command = "ee - floppy" Then
            Call Floppy()
        ElseIf command = "exit" Then
            Environment.Exit(0)
        ElseIf command = "ping" Then
            Call Ping()
        Else
            Console.Clear()
            Console.WriteLine("Error...!!")
            Call Main()
        End If
    End Sub

    Sub Terminal()
        Dim command As String = Nothing

        Dim Type As String = "Type command: "
        Dim C_Drive As String = "C:\>"
        Dim C_Windows As String = "C:\Windows>"

        'Console.WriteLine("
        'ringwormGO COMMAND OS
        'Commands from Python OS, but final file is '.exe'
        '")

        'Console.WriteLine(" ")
        'Console.Write("(©) 2021 - ringwormGO and Door Comapny ~ contact: ringwormgo@gmail.com")
        'Console.WriteLine(" ")
        'Console.WriteLine("Welcome")
        'Console.WriteLine(Type)
        'Console.WriteLine(" ")
        'Console.Write(C_Drive)

        command = Console.ReadLine()

        If command = "print" Then
            Call Ispis()
        ElseIf command = "while" Then
            Call Tijekom()
        ElseIf command = "clear" Then
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        ElseIf command = "backcolor" Then
            Call ColorBack()
        ElseIf command = "forecolor" Then
            Call ForeColor()
        ElseIf command = "help" Then
            Call Help()
        ElseIf command = "about" Then
            Call About()
        ElseIf command = "cd" Then
            Call Directory()
        ElseIf command = "ee - floppy" Then
            Call Floppy()
        ElseIf command = "exit" Then
            Environment.Exit(0)
        ElseIf command = "ping" Then
            Call Ping()
        Else
            Console.Clear()
            Console.WriteLine("Error...!!")
            Call Main()
        End If
    End Sub

    Sub Tijekom()
        Dim ToDo As String = Nothing
        Dim i As Integer = 0

        Console.WriteLine("Type word to show: ")

        ToDo = Console.ReadLine()

        While i < 100
            Console.WriteLine(i & " " & ToDo)
            i += 1
        End While

        Console.Write(Path)
        Call Terminal()
    End Sub

    Sub Ispis()
        Dim print As String = Nothing

        Console.WriteLine("Type whats you want to print on screen.")
        print = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("Your result is: " & print)

        If print = "from input" Then
            Dim fstring As String = StringVariables()
            Dim iint As Int32 = Intvariables()
            Console.WriteLine("String variable: " & fstring)
            Console.WriteLine("Int variable: " & iint)
            Call Main()
        End If

        Console.Write(Path)
        Call Terminal()
    End Sub

    Sub ColorBack()
        Dim color As String = Nothing

        Console.WriteLine("Type your color: ")

        color = Console.ReadLine()

        If color = "dark-red" Then
            Console.BackgroundColor = ConsoleColor.DarkRed
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        End If

        If color = "blue" Then
            Console.BackgroundColor = ConsoleColor.Blue
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        End If

        If color = "red" Then
            Console.BackgroundColor = ConsoleColor.Red
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        End If

        If color = "black" Then
            Console.BackgroundColor = ConsoleColor.Black
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        End If

        If color = "green" Then
            Console.BackgroundColor = ConsoleColor.Green
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        End If

        If color = "yellow" Then
            Console.BackgroundColor = ConsoleColor.Yellow
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        Else
            Console.Clear()
            Call Main()
        End If

    End Sub

    Sub ForeColor()
        Dim color As String = Nothing

        Console.WriteLine("Type your color: ")

        color = Console.ReadLine()

        If color = "dark-red" Then
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        End If

        If color = "blue" Then
            Console.ForegroundColor = ConsoleColor.Blue
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        End If

        If color = "red" Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        End If

        If color = "black" Then
            Console.ForegroundColor = ConsoleColor.Black
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        End If

        If color = "green" Then
            Console.ForegroundColor = ConsoleColor.Green
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        End If

        If color = "yellow" Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.Clear()
            Console.Write(Path)
            Call Terminal()
        Else
            Console.Clear()
            Call Main()
        End If
    End Sub

    Sub Help()
        Console.Clear()
        Console.WriteLine("print = print a string; ispis slova, znakova i brojeva. ~ If you for trey print 'from input' then you print a two variable; Ako pokušate ispisati 'from input' ispišete dvije varijable.")
        Console.WriteLine("while = 100 times print some string; 100 puta ispisuje rijeè, znak ili broj")
        'Console.WriteLine("cd = change directory; mijenja direktorij")
        Console.WriteLine("About = about, verzija")
        Console.WriteLine("forecolor = text color, boja teksta; backcolor = background color,  boja pozadine")
        Console.WriteLine("Colors/Boje: dark-red, red (crvena), black (crna, zadana), blue (plava), green (zelena), ...")
        Console.Write(Path)
        Call Terminal()
    End Sub

    Sub About()
        Console.WriteLine("v1/3.0.0")
        Console.WriteLine("--------------------------------------------------------------------")
        Console.WriteLine("Your PC name: " & Environment.MachineName)
        Console.Write(Environment.OSVersion)
        Console.Write(" ")
        Console.Write("HOST OS verison")
        Console.WriteLine("")
        Console.WriteLine("User name: " & Environment.UserName)
        Console.WriteLine("32-bit or 64-bit HOST OS; True = 64-bit: " & Environment.Is64BitOperatingSystem)
        Console.WriteLine("System directory: " & Environment.SystemDirectory)
        Console.WriteLine("64-bit procesor: " & Environment.Is64BitProcess)
        Console.WriteLine("--------------------------------------------------------------------")
        Console.Write(Path)
        Call Terminal()
    End Sub

    Sub Directory()
        Dim dir As String = Nothing


        Console.WriteLine("Type virtual directory: ")

        dir = Console.ReadLine()

        Console.Clear()
        Console.Write(dir)
        Call Terminal()
    End Sub

    Sub Floppy()
        Console.WriteLine("%%%%&&&&..............%%%/  ")
        Console.WriteLine("%%%%&&&&.........&&&..%%%%%   ")
        Console.WriteLine("%%%%&&&&.........&&&..%%%%%%%")
        Console.WriteLine("%%%%&&&&.........&&&..%%%%%%% ")
        Console.WriteLine("%%%%&&&&.........,,,..%%%%%%%")
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%")
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ")
        Console.WriteLine("%%%%  _________________ .%%%%")
        Console.WriteLine("%%%%  _________________ .%%%%")
        Console.WriteLine("%%%%  _________________ .%%%%")
        Console.WriteLine("%%%%  _________________ .%%%%")
        Console.WriteLine("%%%%  _________________ .%%%%")
        Console.WriteLine("%%%%  _________________ .%%%%")
        Console.WriteLine("%&&%                    ,%&&%")
        Console.WriteLine("%&&%%%%%%%%%%%%%%%%%%%%%%%&&%")
        Console.WriteLine("%&&%%%%%%%%%%%%%%%%%%%%%%%&&%")
        Console.WriteLine(" ")
        Console.Write(Path)
        Call Terminal()
    End Sub

    Public Function StringVariables()
        Dim Stringinput As String = Nothing
        Console.WriteLine("Type your string variable: ")
        Stringinput = Console.ReadLine()
        Return Stringinput
        Call Terminal()
    End Function

    Public Function Intvariables()
        Dim Intinput As String = Nothing
        Console.WriteLine("Type your int variable: ")
        Intinput = Console.ReadLine()
        Return Intinput
        Call Terminal()
    End Function

    Sub ispisVarijable()
        Dim fstring As String = StringVariables()
        Dim iint As Int32 = Intvariables()
        Console.WriteLine(" ")
        Console.WriteLine(fstring)
        Console.WriteLine(iint)
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
            Console.Write(Path)
            Call Terminal()
        Else
            Console.WriteLine("Error...!!")
            Call Terminal()
        End If
    End Sub
End Module