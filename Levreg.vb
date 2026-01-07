Imports System.Data.Odbc
Imports System.IO

Public Class Levregf
    Dim dummy As String, status As String
    Private Sub Levregf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Leverantörsregister"
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsourcel.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + databasnamn
        Gnamn.Text = Firmanamn
        dummy = getleverantor("Start")
        skrivatillform()
    End Sub

    Private Sub AvslutaK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub
    Sub skrivatillform()
        llevnamnTB.Text = llevnamn
        SenastTransakL.Text = getsenastLeverantortransak(llevnamn)

        LevNrTB.Text = llevnr

        kollaefterlevdok()
        LAdress1TB.Text = ladress1
        lAdress2TB.Text = ladress2
        LPostnummerTB.Text = lpostnr
        OrtTB.Text = lort
        lLandTB.Text = lland
        LkontaktmanTB.Text = lkontaktman
        LkreditdagarTB.Text = lkreditdagar
        lTelefonTB.Text = ltelefon
        llevtypTB.Text = llevtyp
        llevgruppTB.Text = llevgrupp
        lRegnrTB.Text = lregnr
        LkommentTB.Text = lkomment
        LvalutaTB.Text = lvaluta
        LplusgiroTB.Text = lpostgiro
        LbankgiroTB.Text = lbankgiro
        LbankkontoTB.Text = lbankkonto
        LvartkundnrTB.Text = lvartkundnr
        LnormallevtidTB.Text = lnormlevtid
        lwebadressTB.Text = lurl
        lEpostTB.Text = lepost
        LbankTB.Text = lbank
        LLosenTB.Text = llosen
        LGSMTB.Text = lgsm
        dummy = CountCharacter(lkomment, Chr(10))
        IbanTB.Text = liban
        SwiftTB.Text = lswift

        If dummy > 12 Then
            FlerraderL.Text = "OBS: Flera rader levinfo än visas i rutan!"
        Else
            FlerraderL.Text = ""
        End If
    End Sub
    Function CountCharacter(value As String, ch As String) As Integer

        CountCharacter = 0

        While InStr(value, ch) > 0
            value = Strings.Right(value, (Len(value) - InStr(value, ch)))
            CountCharacter = CountCharacter + 1

        End While

    End Function

    Private Sub llevnamnTB_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles llevnamnTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim dummy As String
            If status <> "Ny" Then
                dummy = getleverantor("LikaNamn")
                skrivatillform()
            End If
            LAdress1TB.Focus()
        End If
    End Sub

    Private Sub llevnamnTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles llevnamnTB.TextChanged
        llevnamn = llevnamnTB.Text
    End Sub
    Private Sub sparalev()
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM levreg "
        mySQL = mySQL + " Where levnamn = '" + llevnamn + "' "
        mySQL = mySQL + " And ClientID = '" + KlientID + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO levreg "
        falt = falt + "ClientId,"
        varden = varden + "'" + KlientID + "',"
        falt = falt + "levnr,"
        varden = varden + "'" + llevnr + "',"
        falt = falt + "levnamn,"
        varden = varden + "'" + llevnamn + "',"
        falt = falt + "adress1,"
        varden = varden + "'" + ladress1 + "',"
        falt = falt + "adress2,"
        varden = varden + "'" + ladress2 + "',"
        falt = falt + "postnummer,"
        varden = varden + "'" + lpostnr + "',"
        falt = falt + "ort,"
        varden = varden + "'" + lort + "',"
        falt = falt + "land,"
        varden = varden + "'" + lland + "',"
        falt = falt + "kontaktperson,"
        varden = varden + "'" + lkontaktman + "',"
        falt = falt + "kreditdagar,"
        varden = varden + "" + CStr(lkreditdagar) + ","
        falt = falt + "telefon,"
        varden = varden + "'" + ltelefon + "',"
        falt = falt + "levtyp,"
        varden = varden + "'" + llevtyp + "',"
        falt = falt + "levgrupp,"
        varden = varden + "'" + llevgrupp + "',"
        falt = falt + "regnr,"
        varden = varden + "'" + lregnr + "',"
        falt = falt + "komment1,"
        varden = varden + "'" + lkomment + "',"
        falt = falt + "valuta,"
        varden = varden + "'" + lvaluta + "',"
        falt = falt + "Postgiro,"
        varden = varden + "'" + lpostgiro + "',"
        falt = falt + "bankgiro,"
        varden = varden + "'" + lbankgiro + "',"
        falt = falt + "bankkonto,"
        varden = varden + "'" + lbankkonto + "',"
        falt = falt + "vartkundnr,"
        varden = varden + "'" + lvartkundnr + "',"
        falt = falt + "Stdlevdagar,"
        varden = varden + "'" + lnormlevtid + "',"
        falt = falt + "url,"
        varden = varden + "'" + lurl + "',"
        falt = falt + "email,"
        varden = varden + "'" + lepost + "',"
        falt = falt + "bank,"
        varden = varden + "'" + lbank + "',"
        falt = falt + "GSM,"
        varden = varden + "'" + lgsm + "',"
        falt = falt + "Iban,"
        varden = varden + "'" + LIBAN + "',"
        falt = falt + "Swift,"
        varden = varden + "'" + LSwift + "',"
        falt = falt + "losen"
        varden = varden + "'" + llosen + "'"
        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        'Stop
        cn.Close()
    End Sub

    Private Sub Bak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bak.Click
        dummy = getleverantor("Bak")
        skrivatillform()
    End Sub

    Private Sub Fram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fram.Click
        dummy = getleverantor("Fram")
        skrivatillform()
    End Sub

    Private Sub Radera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radera.Click
        Dim Message As String = "Vill du verkligen radera denna leverantör permanent ?"
        Dim Caption As String = "Kontrollfråga"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.OKCancel
        Dim Result As DialogResult

        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = 1 Then
            Dim cn As OdbcConnection, mySQL As String
            Dim connStr As String
            connStr = "DSN=" + odbcsourcer + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM levreg "
            mySQL = mySQL + " Where levnamn = '" + llevnamn + "' "
            mySQL = mySQL + " And ClientID = '" + KlientID + "' "
            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()
            cn.Close()
            nolla()
        End If
    End Sub
    Sub nolla()
        LevNrTB.Text = ""
        llevnr = ""
        status = ""
        llevnamnTB.Text = ""
        SenastTransakL.Text = ""
        llevnamn = ""
        LAdress1TB.Text = ""
        ladress1 = ""
        lAdress2TB.Text = ""
        ladress2 = ""
        LPostnummerTB.Text = ""
        lort = ""
        OrtTB.Text = ""
        lpostnr = ""
        lLandTB.Text = ""
        lland = ""
        LkontaktmanTB.Text = ""
        lkontaktman = ""
        LkreditdagarTB.Text = 0
        lkreditdagar = 0
        lTelefonTB.Text = ""
        ltelefon = ""
        llevtypTB.Text = ""
        llevtyp = ""
        llevgruppTB.Text = ""
        llevgrupp = ""
        lRegnrTB.Text = ""
        lregnr = ""
        LkommentTB.Text = ""
        lkomment = ""
        LvalutaTB.Text = ""
        lvaluta = ""
        LplusgiroTB.Text = ""
        lpostgiro = ""
        LbankgiroTB.Text = ""
        lbankgiro = ""
        LbankkontoTB.Text = ""
        lbankkonto = ""
        LvartkundnrTB.Text = ""
        lvartkundnr = ""
        LnormallevtidTB.Text = ""
        lnormlevtid = ""
        lwebadressTB.Text = ""
        lurl = ""
        lEpostTB.Text = ""
        lepost = ""
        LbankTB.Text = ""
        lbank = ""
        LLosenTB.Text = ""
        llosen = ""
        LGSMTB.Text = ""
        lgsm = ""
        LIBAN = ""
        IbanTB.Text = ""
        LSwift = ""
        SwiftTB.Text = ""
    End Sub

    Private Sub NYBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NYBT.Click

        nolla()
        LevNrTB.Text = "L" + getnummer("Next", "Nästa levnr")
        status = "Ny"
    End Sub

    Private Sub LAdress1TB_KeyUp(sender As Object, e As KeyEventArgs) Handles LAdress1TB.KeyUp
        If e.KeyCode = Keys.Enter Then

            lAdress2TB.Focus()
        End If
    End Sub

    Private Sub LAdress1TB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAdress1TB.TextChanged
        ladress1 = LAdress1TB.Text
    End Sub

    Private Sub lAdress2TB_KeyUp(sender As Object, e As KeyEventArgs) Handles lAdress2TB.KeyUp
        If e.KeyCode = Keys.Enter Then

            LPostnummerTB.Focus()
        End If
    End Sub

    Private Sub lAdress2TB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lAdress2TB.TextChanged
        ladress2 = lAdress2TB.Text
    End Sub

    Private Sub LPostnummerTB_KeyUp(sender As Object, e As KeyEventArgs) Handles LPostnummerTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            OrtTB.Focus()
        End If
    End Sub

    Private Sub LPostnummerTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPostnummerTB.TextChanged
        lpostnr = LPostnummerTB.Text
    End Sub

    Private Sub OrtTB_KeyUp(sender As Object, e As KeyEventArgs) Handles OrtTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            lLandTB.Focus()
        End If
    End Sub

    Private Sub OrtTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrtTB.TextChanged
        lort = OrtTB.Text

    End Sub

    Private Sub lLandTB_KeyUp(sender As Object, e As KeyEventArgs) Handles lLandTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            lTelefonTB.Focus()
        End If
    End Sub

    Private Sub lLandTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lLandTB.TextChanged
        lland = lLandTB.Text

    End Sub

    Private Sub lTelefonTB_KeyUp(sender As Object, e As KeyEventArgs) Handles lTelefonTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            LGSMTB.Focus()
        End If
    End Sub

    Private Sub lTelefonTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lTelefonTB.TextChanged
        ltelefon = lTelefonTB.Text
    End Sub

    Private Sub LGSMTB_KeyUp(sender As Object, e As KeyEventArgs) Handles LGSMTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            lEpostTB.Focus()
        End If
    End Sub

    Private Sub LGSMTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LGSMTB.TextChanged
        lgsm = LGSMTB.Text
    End Sub

    Private Sub lEpostTB_KeyUp(sender As Object, e As KeyEventArgs) Handles lEpostTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            lRegnrTB.Focus()
        End If
    End Sub

    Private Sub lEpostTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lEpostTB.TextChanged
        lepost = lEpostTB.Text
    End Sub

    Private Sub lRegnrTB_KeyUp(sender As Object, e As KeyEventArgs) Handles lRegnrTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            LvartkundnrTB.Focus()
        End If
    End Sub

    Private Sub lRegnrTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lRegnrTB.TextChanged
        lregnr = lRegnrTB.Text
    End Sub

    Private Sub LkontaktmanTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LkontaktmanTB.TextChanged
        lkontaktman = LkontaktmanTB.Text
    End Sub

    Private Sub llevgruppTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles llevgruppTB.TextChanged
        llevgrupp = llevgruppTB.Text
    End Sub

    Private Sub llevtypTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles llevtypTB.TextChanged
        llevtyp = llevtypTB.Text
    End Sub

    Private Sub LkommentTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LkommentTB.TextChanged
        lkomment = kommatillpunkt(LkommentTB.Text)

    End Sub

    Private Sub lwebadressTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lwebadressTB.TextChanged
        lurl = lwebadressTB.Text
    End Sub

    Private Sub LvartkundnrTB_KeyUp(sender As Object, e As KeyEventArgs) Handles LvartkundnrTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            LkreditdagarTB.Focus()
        End If
    End Sub

    Private Sub LvartkundnrTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LvartkundnrTB.TextChanged
        lvartkundnr = LvartkundnrTB.Text
    End Sub

    Private Sub LLosenTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LLosenTB.TextChanged
        llosen = LLosenTB.Text
    End Sub

    Private Sub LkreditdagarTB_KeyUp(sender As Object, e As KeyEventArgs) Handles LkreditdagarTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            LplusgiroTB.Focus()
        End If
    End Sub

    Private Sub LkreditdagarTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LkreditdagarTB.TextChanged
        lkreditdagar = nullhantering(LkreditdagarTB.Text, "T")
    End Sub

    Private Sub LvalutaTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LvalutaTB.TextChanged
        lvaluta = LvalutaTB.Text
    End Sub

    Private Sub LplusgiroTB_KeyUp(sender As Object, e As KeyEventArgs) Handles LplusgiroTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            LbankgiroTB.Focus()
        End If
    End Sub

    Private Sub LplusgiroTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LplusgiroTB.TextChanged
        lpostgiro = LplusgiroTB.Text
    End Sub

    Private Sub LbankgiroTB_KeyUp(sender As Object, e As KeyEventArgs) Handles LbankgiroTB.KeyUp
        If e.KeyCode = Keys.Enter Then

            SparaB.Focus()
        End If
    End Sub

    Private Sub LbankgiroTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbankgiroTB.TextChanged
        lbankgiro = LbankgiroTB.Text
    End Sub

    Private Sub LbankTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbankTB.TextChanged
        lbank = LbankTB.Text
    End Sub

    Private Sub LbankkontoTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbankkontoTB.TextChanged
        lbankkonto = LbankkontoTB.Text
    End Sub

    Private Sub LnormallevtidTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LnormallevtidTB.TextChanged
        lnormlevtid = LnormallevtidTB.Text
    End Sub

    Private Sub SparaB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SparaB.Click
        sparalev()
    End Sub

    Private Sub IbanTB_TextChanged(sender As Object, e As EventArgs) Handles IbanTB.TextChanged
        LIBAN = IbanTB.Text
    End Sub

    Private Sub SwiftTB_TextChanged(sender As Object, e As EventArgs) Handles SwiftTB.TextChanged
        LSwift = SwiftTB.Text
    End Sub

    Private Sub LevNrTB_TextChanged(sender As Object, e As EventArgs) Handles LevNrTB.TextChanged
        llevnr = LevNrTB.Text
    End Sub

    Function getsenastLeverantortransak(lv As String)
        ' On Error Resume Next
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, utpris(10) As Double
        Dim myCmd As OdbcCommand
        Dim tabel As OdbcDataReader

        Static startAt As Integer = 1
        mySQL = ""
        connStr = "DSN=" + odbcsourcer + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()

        mySQL = "SELECT top 1 * "
        mySQL = mySQL + " FROM levresarkiv "
        mySQL = mySQL + "where clientid = '" + KlientID + "' "
        mySQL = mySQL + "And Levnamn = '" + lv + "' "
        mySQL = mySQL + " ORDER by fakturadatum desc;"
        myCmd = New OdbcCommand(mySQL, cn)
        tabel = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        If tabel.HasRows = True Then
            tabel.Read()
            getsenastLeverantortransak = nullhantering(tabel("fakturadatum"), "S")
        Else
            getsenastLeverantortransak = "000-00-00"
        End If

        cn.Close()
    End Function

    Private Sub LbankTB_KeyUp(sender As Object, e As KeyEventArgs) Handles LbankTB.KeyUp

    End Sub

    Private Sub KundDokB_Click(sender As Object, e As EventArgs) Handles LevDokB.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = ""
        fd.Title = "Open File Dialog"
        fd.InitialDirectory = levdokmapp + llevnr

        'checkfor files
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            System.Diagnostics.Process.Start(strFileName)
        End If

    End Sub

    Private Sub LevNrTB_KeyUp(sender As Object, e As KeyEventArgs) Handles LevNrTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim dummy As String
            If status <> "Ny" Then
                dummy = getleverantor("LikaNummer")
                skrivatillform()
            End If
            LAdress1TB.Focus()
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Sub kollaefterlevdok()
        On Error Resume Next
        levdokmapp = nullhantering(levdokmapp, "S")
        llevnr = nullhantering(llevnr, "S")
        Dim dir As New IO.DirectoryInfo(levdokmapp + llevnr)

        If dir.Exists Then

        Else
            My.Computer.FileSystem.CreateDirectory(levdokmapp + llevnr)
        End If





        Dim myDir As DirectoryInfo = New DirectoryInfo(levdokmapp + llevnr)
        If (myDir.EnumerateFiles().Any()) Then
            LevDokB.Visible = True
        Else
            LevDokB.Visible = False
        End If

    End Sub
End Class