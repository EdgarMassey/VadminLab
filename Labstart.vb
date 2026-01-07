Imports System.Runtime.ConstrainedExecution

Public Class LabstartF
    Private Sub LabstartF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)
        ' odbcsourcer = "VadminODBC"
        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Lab Startmeny "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsourcel.Text = "ODBCsource:" + odbcsource
        databas.Text = "Databasnamn:" + Labdatabasnamn
        Gnamn.Text = Firmanamn
        labmap = "F:\V2012LabDok\"
        Labdatabasnamn = "NMLab"
    End Sub



    Private Sub SparaB_Click(sender As Object, e As EventArgs) Handles ProvHanteringB.Click
        LabHanteringF.Show()
    End Sub

    Private Sub AvslutaB_Click(sender As Object, e As EventArgs) Handles AvslutaB.Click
        System.Diagnostics.Process.Start(sokvag + "VadminMeny.exe")
        Foretag.Close()
        Me.Close()
    End Sub

    Private Sub POLB_Click(sender As Object, e As EventArgs)
        POLstartF.Show()
    End Sub

    Private Sub POLbestB_Click(sender As Object, e As EventArgs) Handles POLbestB.Click
        InleveransF.Show()
    End Sub

    Private Sub POLProdLevB_Click(sender As Object, e As EventArgs)
        ProduktKomponenterF.Show()
    End Sub

    Private Sub BatchreporterB_Click(sender As Object, e As EventArgs) Handles BatchreporterB.Click
        BatchreporterF.Show()
    End Sub

    Private Sub Gnamn_Click(sender As Object, e As EventArgs) Handles Gnamn.Click
        SpecialrutinerB.Visible = True
    End Sub

    Private Sub SpecialrutinerB_Click(sender As Object, e As EventArgs) Handles SpecialrutinerB.Click
        SpecrutinerF.Show()
    End Sub



    Private Sub CalenderB_Click(sender As Object, e As EventArgs) 

        CalenderF.Show()

    End Sub

    Private Sub AnteckB_Click(sender As Object, e As EventArgs) Handles AnteckB.Click
        AnteckningarF.Show()
        AnteckningarF.BringToFront()
        AnteckningarF.Activate()
        AnteckningarF.WindowState = FormWindowState.Normal
    End Sub

    Private Sub LocalaInställningarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalaInställningarToolStripMenuItem.Click
        LokalInstF.Show()
    End Sub

    Private Sub BesokB_Click(sender As Object, e As EventArgs) Handles BesokB.Click
        VistsF.Show()
        VistsF.BringToFront()
        VistsF.Activate()
        VistsF.WindowState = FormWindowState.Normal
    End Sub
End Class