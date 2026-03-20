Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace My
    Partial Friend Class MyApplication

        <DllImport("shell32.dll", CharSet:=CharSet.Unicode)>
        Private Shared Function SetCurrentProcessExplicitAppUserModelID(appID As String) As Integer
        End Function

        Private Sub MyApplication_Startup(
            sender As Object,
            e As StartupEventArgs
        ) Handles Me.Startup

            SetCurrentProcessExplicitAppUserModelID("Binar.VadminLAB")

            StartupRequest.Target = GetTargetArg(e.CommandLine)
        End Sub

        Private Sub MyApplication_StartupNextInstance(
            sender As Object,
            e As StartupNextInstanceEventArgs
        ) Handles Me.StartupNextInstance

            StartupRequest.Target = GetTargetArg(e.CommandLine)

            If Me.MainForm IsNot Nothing Then
                If Me.MainForm.WindowState = FormWindowState.Minimized Then
                    Me.MainForm.WindowState = FormWindowState.Normal
                End If

                Me.MainForm.Activate()
            End If

            FormHelper.OpenRequestedFormIfAny()

            e.BringToForeground = True
        End Sub

        Private Function GetTargetArg(args As IEnumerable(Of String)) As String
            Dim list = args.ToList()

            For i As Integer = 0 To list.Count - 1
                If String.Equals(list(i), "/TARGET", StringComparison.OrdinalIgnoreCase) AndAlso i < list.Count - 1 Then
                    Return list(i + 1)
                End If
            Next

            Return ""
        End Function

    End Class
End Namespace
