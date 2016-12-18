Module Shell

    Public compileInput As String

    Public Sub Main()

        Console.Title() = "Ice Compiler v1.0"
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Ice Compiler v1.0")
        Console.Write(">>> ")
        Console.ForegroundColor = ConsoleColor.Yellow
        compileInput = Console.ReadLine()
        Compile()

    End Sub

End Module
