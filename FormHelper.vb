Imports System.Linq
Imports System.Runtime.InteropServices

Module FormHelper

    <DllImport("user32.dll")>
    Private Function SetForegroundWindow(hWnd As IntPtr) As Boolean
    End Function

    Public Sub OpenOrActivateForm(Of T As {Form, New})()
        Dim frm As T = Application.OpenForms.OfType(Of T)().FirstOrDefault()

        If frm IsNot Nothing Then
            If frm.WindowState = FormWindowState.Minimized Then
                frm.WindowState = FormWindowState.Normal
            End If

            If Not frm.Visible Then
                frm.Show()
            End If
        Else
            frm = New T()
            frm.Show()
        End If

        frm.TopMost = True
        frm.BringToFront()
        frm.Activate()
        SetForegroundWindow(frm.Handle)
        frm.Focus()
        frm.TopMost = False
    End Sub

    Public Sub OpenRequestedFormIfAny()
        If StartupRequest.Target <> "" Then
            OpenOrActivateFormByName(StartupRequest.Target)
            StartupRequest.Target = ""
        End If
    End Sub

    Public Sub OpenOrActivateFormByName(target As String)

        Select Case StartupRequest.Target.ToUpper()

            Case "LABHANTERINGF"
                OpenOrActivateForm(Of LabHanteringF)()

            Case "INLEVERANSF"
                OpenOrActivateForm(Of InleveransF)()

            Case "PRODREGF"
                OpenOrActivateForm(Of ProdregF)()

            Case "BATCHREPORTERF"
                OpenOrActivateForm(Of BatchreporterF)()

            Case "ANTECKNINGARF"
                OpenOrActivateForm(Of AnteckningarF)()

            Case "VISTSF"
                OpenOrActivateForm(Of VistsF)()


            Case Else
                OpenOrActivateForm(Of LabstartF)()

        End Select

    End Sub

End Module