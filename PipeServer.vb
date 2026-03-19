Imports System.IO
Imports System.IO.Pipes
Imports System.Threading

Module PipeServer

    Private serverThread As Thread
    Private running As Boolean = False

    Public Sub StartPipeServer()
        If running Then Exit Sub

        running = True
        serverThread = New Thread(AddressOf ServerLoop)
        serverThread.IsBackground = True
        serverThread.Start()
    End Sub

    Private Sub ServerLoop()
        While running
            Try
                Using server As New NamedPipeServerStream("VadminLABnetPipe", PipeDirection.In)
                    server.WaitForConnection()

                    Using sr As New StreamReader(server)
                        Dim message As String = sr.ReadLine()

                        If Not String.IsNullOrWhiteSpace(message) Then
                            StartupRequest.Target = message.Trim()

                            If Application.OpenForms.Count > 0 Then
                                Dim anyForm = Application.OpenForms(0)
                                anyForm.BeginInvoke(New MethodInvoker(AddressOf FormHelper.OpenRequestedFormIfAny))
                            End If
                        End If
                    End Using
                End Using
            Catch
            End Try
        End While
    End Sub

    Public Sub StopPipeServer()
        running = False
    End Sub

End Module