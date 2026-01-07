Public Class POLstartF
    Private Sub POLstartF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)
        ' odbcsourcer = "VadminODBC"
        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Pol   "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsource.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + Labdatabasnamn
        Gnamn.Text = Firmanamn
    End Sub

    Private Sub AvslutaB_Click(sender As Object, e As EventArgs) Handles AvslutaB.Click
        Me.Close()
    End Sub



    Private Sub KomponenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KomponenterToolStripMenuItem.Click
        ProduktKomponenterF.Show()
    End Sub

    Private Sub LeverantörorToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        LeverantorF.Show()
    End Sub
End Class