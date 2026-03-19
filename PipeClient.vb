Imports System.IO
Imports System.IO.Pipes

Module PipeClient

    Public Function SendTargetToRunningInstance(target As String) As Boolean
        Try
            Using client As New NamedPipeClientStream(".", "VadminLABnetPipe", PipeDirection.Out)
                client.Connect(500)

                Using sw As New StreamWriter(client)
                    sw.AutoFlush = True
                    sw.WriteLine(target)
                End Using
            End Using

            Return True
        Catch
            Return False
        End Try
    End Function

End Module
