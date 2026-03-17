Imports System.Linq

Module FormHelper

    Public Sub OpenOrActivateForm(Of T As {Form, New})()
        Dim frm As T = Application.OpenForms.OfType(Of T)().FirstOrDefault()

        If frm IsNot Nothing Then
            If frm.WindowState = FormWindowState.Minimized Then
                frm.WindowState = FormWindowState.Normal
            End If

            If Not frm.Visible Then
                frm.Show()
            End If

            frm.BringToFront()
            frm.Activate()
            frm.Focus()
        Else
            frm = New T()
            frm.Show()
        End If
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

            Case "VISITSF"
                OpenOrActivateForm(Of VistsF)()


            Case Else
                OpenOrActivateForm(Of LabHanteringF)()

        End Select

    End Sub

End Module