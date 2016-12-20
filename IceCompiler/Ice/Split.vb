Imports System.IO

Module Split

    Public Sub Split()

        'Spilts string into array of lines
        Dim strList As New List(Of String)
        Using reader As New StringReader(compileInput)
            While reader.Peek() <> -1
                strList.Add(reader.ReadLine())
            End While
        End Using

        Compile.Compile()

    End Sub

End Module
