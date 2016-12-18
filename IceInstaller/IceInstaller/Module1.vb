Imports System
Imports System.IO
Imports Microsoft.VisualBasic

Module Module1

    Public Sub Main()

        'Get current directory
        Dim currentPath As String = Directory.GetCurrentDirectory

        'Specify the directory
        Dim path As String = "c:\Program Files\Ice"

        'Determine whether the directory exists.
        If Directory.Exists(path) Then
            Console.WriteLine("Ice is already installed.")
            Console.ReadLine()
        Else
            'Try to create the directory.
            Dim di As DirectoryInfo = Directory.CreateDirectory(path)
            Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path))
            Console.ReadLine()
        End If

        'Moving the icon
        If System.IO.File.Exists(currentPath + "\iceicon.ico") = True Then
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("iceicon.ico successfully moved!")
            My.Computer.FileSystem.CopyFile(currentPath + "\iceicon.ico", path + "\iceicon.ico")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("There was an error moving iceicon.ico")
        End If

        'Moving the compiler
        'If System.IO.File.Exists(currentPath + "\Ice.exe") = True Then
        'Console.WriteLine("Ice.exe successfully moved!")
        'My.Computer.FileSystem.CopyFile(currentPath + "\Ice.exe", path + "\Ice.exe")
        'Console.ForegroundColor = ConsoleColor.Green
        'Else
        'Console.ForegroundColor = ConsoleColor.Red
        'Console.WriteLine("There was an error moving Ice.exe")
        'End If

    End Sub

End Module
