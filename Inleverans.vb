Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class InleveransF
    Dim r As Integer, c As Integer
    Dim status As String
    Private Sub InleveransF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Beställningar "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsourcel.Text = "ODBCsource:" + odbcsourcer

        databas.Text = "Databasnamn:" + databasnamn
        Gnamn.Text = Firmanamn

        makegrid("")

        DatumTB.Text = today
        LvartreferensTB.Text = defaultref

        AvslutaK.Select()

        nolla()
        BestNRTB.Text = bestnr
        LLevnamnTB.Focus()

    End Sub

    Private Function makegrid(ByVal typ As String)
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()


        With (Me.DataGridView1.Columns)
            .Add("", "Produktnr")
            .Add("", "Bestnr")
            .Add("", "Produktnamn")
            .Add("", "Ber.Lev.")
            .Add("", "PF")
            .Add("", "Antal")
            .Add("", "Enhet")
            .Add("", "Ant.Lev")
            .Add("", "Rest")
            .Add("", "Inpris")
            .Add("", "Summa")
            .Add("", "Status")
        End With
        With Me.DataGridView1.Rows
            For Me.r = 1 To 100
                .Add("")
            Next r
        End With
        r = 0
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.RowHeadersWidth = 40
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 80

        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(4).Width = 60
        DataGridView1.Columns(5).Width = 60


        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        DataGridView1.Columns(6).Width = 80
        DataGridView1.Columns(7).Width = 80
        DataGridView1.Columns(8).Width = 80
        DataGridView1.Columns(9).Width = 80
        DataGridView1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns.Item(9).DefaultCellStyle.Format = "n2"


        DataGridView1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns.Item(10).DefaultCellStyle.Format = "n2"

        DataGridView1.Columns(10).Width = 80
        DataGridView1.Columns(11).Width = 80

        DataGridView1.Visible = True
        makegrid = ""

    End Function

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub

    Private Sub LLevnamnTB_KeyUp(sender As Object, e As KeyEventArgs) Handles LLevnamnTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim dummy As String
            dummy = getleverantor("LikaNamn")
            skrivatillform()
            LAdress1TB.Focus()
        End If
    End Sub




    Private Sub KundnamnTB_TextChanged(sender As Object, e As EventArgs) Handles LLevnamnTB.TextChanged
        llevnamn = LLevnamnTB.Text
    End Sub
    Sub skrivatillform()
        LLevnrTB.Text = llevnr
        LLevnamnTB.Text = llevnamn
        LAdress1TB.Text = ladress1
        LAdress2TB.Text = ladress2
        LPostnummerTB.Text = lpostnr
        LOrtTB.Text = lort
        LLandTB.Text = lland
        LTelefonTB.Text = ltelefon
        LKommentTB.Text = lkomment
        LvartkundnrTB.Text = lvartkundnr
        LnormallevtidTB.Text = lnormlevtid
        LEpostTB.Text = lepost
        BestNRTB.Text = bestnr
    End Sub

    Private Sub Bak_Click(sender As Object, e As EventArgs) Handles Bak.Click

        getleverantor("Bak")
        skrivatillform()
    End Sub

    Private Sub Fram_Click(sender As Object, e As EventArgs) Handles Fram.Click
        getleverantor("Fram")
        skrivatillform()
    End Sub

    Private Sub LAdress1TB_TextChanged(sender As Object, e As EventArgs) Handles LAdress1TB.TextChanged
        ladress1 = LAdress1TB.Text

    End Sub

    Private Sub LAdress2TB_TextChanged(sender As Object, e As EventArgs) Handles LAdress2TB.TextChanged
        ladress2 = LAdress2TB.Text
    End Sub

    Private Sub LPostnummerTB_TextChanged(sender As Object, e As EventArgs) Handles LPostnummerTB.TextChanged
        lpostnr = LPostnummerTB.Text
    End Sub

    Private Sub LOrtTB_TextChanged(sender As Object, e As EventArgs) Handles LOrtTB.TextChanged
        lort = LOrtTB.Text
    End Sub

    Private Sub LLandTB_TextChanged(sender As Object, e As EventArgs) Handles LLandTB.TextChanged
        lland = LLandTB.Text
    End Sub

    Private Sub LTelefonTB_TextChanged(sender As Object, e As EventArgs) Handles LTelefonTB.TextChanged
        ltelefon = LTelefonTB.Text
    End Sub

    Private Sub LEpostTB_TextChanged(sender As Object, e As EventArgs) Handles LEpostTB.TextChanged
        lepost = LEpostTB.Text
    End Sub

    Private Sub LMarkningTB_TextChanged(sender As Object, e As EventArgs) Handles LMarkningTB.TextChanged
        markning = LMarkningTB.Text
    End Sub

    Private Sub LKommentTB_TextChanged(sender As Object, e As EventArgs) Handles LKommentTB.TextChanged
        lkomment = LKommentTB.Text
    End Sub

    Private Sub LvartkundnrTB_TextChanged(sender As Object, e As EventArgs) Handles LvartkundnrTB.TextChanged
        lvartkundnr = LvartkundnrTB.Text
    End Sub

    Private Sub LvartreferensTB_TextChanged(sender As Object, e As EventArgs) Handles LvartreferensTB.TextChanged
        varref = LvartreferensTB.Text
    End Sub

    Private Sub DatumTB_TextChanged(sender As Object, e As EventArgs) Handles DatumTB.TextChanged
        ldatum = DatumTB.Text

    End Sub

    Private Sub LnormallevtidTB_TextChanged(sender As Object, e As EventArgs) Handles LnormallevtidTB.TextChanged
        lnormlevtid = LnormallevtidTB.Text
    End Sub


    Private Sub LInLevtypTB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LInLevtypTB.SelectedIndexChanged
        linlevtyp = LInLevtypTB.Text
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        r = Me.DataGridView1.CurrentRow.Index
        c = DataGridView1.CurrentCell.ColumnIndex
        If r > rr Then rr = r
        rmaxl.Text = rr
        rrl.Text = r

    End Sub




    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        Dim dummy As String
        r = Me.DataGridView1.CurrentRow.Index
        c = DataGridView1.CurrentCell.ColumnIndex
        If r > rr Then rr = r

        rmaxl.Text = rr
        If e.KeyCode = Keys.Enter Then
            If c = 0 Then
                pprodnr = DataGridView1.Item(0, rr - 1).Value
                dummy = hamptaprodukt("LikaNr")
                If dummy = "No" Then

                    DataGridView1.CurrentCell = DataGridView1.Item(0, r - 1)
                    SendKeys.Send("{LEFT}")
                    Exit Sub
                End If


                DataGridView1.Item(0, r - 1).Value = pprodnr
                DataGridView1.Item(1, r - 1).Value = pbestnr
                DataGridView1.Item(2, r - 1).Value = pprodnamn
                DataGridView1.Item(4, r - 1).Value = pprisfaktor
                DataGridView1.Item(5, r - 1).Value = 1 'antal
                DataGridView1.Item(6, r - 1).Value = pEnhet
                DataGridView1.Item(7, r - 1).Value = 0 'antal lev
                DataGridView1.Item(8, r - 1).Value = 0 ' antal rest
                '  DataGridView1.Item(9, r - 1).Value = pinpris
                DataGridView1.Item(10, r - 1).Value = (DataGridView1.Item(4, r - 1).Value) * (DataGridView1.Item(9, r - 1).Value) * (DataGridView1.Item(5, r - 1).Value) 'rad summa
                DataGridView1.Item(11, r - 1).Value = "Registrerad"
                DataGridView1.CurrentCell = DataGridView1.Item(5, r - 1)
            ElseIf c = 5 Then
                DataGridView1.Item(10, r - 1).Value = (DataGridView1.Item(4, r - 1).Value) * (DataGridView1.Item(9, r - 1).Value) * (DataGridView1.Item(5, r - 1).Value)
                DataGridView1.CurrentCell = DataGridView1.Item(9, r - 1)
            ElseIf c = 9 Then
                DataGridView1.Item(10, r - 1).Value = (DataGridView1.Item(4, r - 1).Value) * (DataGridView1.Item(9, r - 1).Value) * (DataGridView1.Item(5, r - 1).Value)
                DataGridView1.CurrentCell = DataGridView1.Item(0, r)
            End If

            summering()
        End If



    End Sub
    Private Sub summering()
        Dim summabest As Double
        summabest = 0
        For i As Integer = 0 To rr
            summabest = summabest + nullhantering(DataGridView1.Rows(i).Cells(10).Value, "T")
        Next
        SummaL.Text = Format(summabest, "#######0.00")
        rmaxl.Text = rr
    End Sub
    Private Sub sparaBEST()
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM Bestallningsreg "
        mySQL = mySQL + " Where BestallningsID = '" + nullhantering((bestnr), "S") + "' "
        mySQL = mySQL + " And ClientID = '" + KlientID + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()


        For i As Integer = 0 To rr - 1
            pprodnr = nullhantering(DataGridView1.Rows(i).Cells(0).Value, "S")
            pbestnr = nullhantering(DataGridView1.Rows(i).Cells(1).Value, "S")
            pprodnamn = nullhantering(DataGridView1.Rows(i).Cells(2).Value, "S")
            pEnhet = nullhantering(DataGridView1.Rows(i).Cells(6).Value, "S")
            pprisfaktor = nullhantering(DataGridView1.Rows(i).Cells(4).Value, "T")
            pantal = nullhantering(DataGridView1.Rows(i).Cells(5).Value, "T")
            pinpris = nullhantering(DataGridView1.Rows(i).Cells(9).Value, "T")
            psumma = nullhantering(DataGridView1.Rows(i).Cells(10).Value, "T")
            levdatum = nullhantering(DataGridView1.Rows(i).Cells(3).Value, "S")
            lantlev = nullhantering(DataGridView1.Rows(i).Cells(7).Value, "S")
            lrestad = nullhantering(DataGridView1.Rows(i).Cells(8).Value, "T")
            lstatus = nullhantering(DataGridView1.Rows(i).Cells(11).Value, "S")

            falt = "" : varden = ""
            mySQL = "INSERT INTO Bestallningsreg "
            falt = falt + "clientid,"
            varden = varden + "'" + KlientID + "',"
            falt = falt + "MyTimeStamp,"
            varden = varden + "'" + gettimestamp() + "',"
            falt = falt + "BestallningsID,"
            varden = varden + "'" + nullhantering(bestnr, "S") + "',"
            falt = falt + "Regdatum,"
            varden = varden + "'" + DatumTB.Text + "',"
            falt = falt + "Levdatum,"
            varden = varden + "'" + nullhantering(levdatum, "S") + "',"
            falt = falt + "Levnr,"
            varden = varden + "'" + nullhantering(llevnr, "S") + "',"
            falt = falt + "Leverantor,"
            varden = varden + "'" + nullhantering(llevnamn, "S") + "',"
            falt = falt + "Adress1,"
            varden = varden + "'" + nullhantering(ladress1, "S") + "',"
            falt = falt + "Adress2,"
            varden = varden + "'" + nullhantering(ladress2, "S") + "',"
            falt = falt + "Postnr,"
            varden = varden + "'" + nullhantering(lpostnr, "S") + "',"
            falt = falt + "Ort,"
            varden = varden + "'" + nullhantering(lort, "S") + "',"
            falt = falt + "Land,"
            varden = varden + "'" + nullhantering(lland, "S") + "',"
            falt = falt + "Telefon,"
            varden = varden + "'" + nullhantering(ltelefon, "S") + "',"
            falt = falt + "epost,"
            varden = varden + "'" + nullhantering(lepost, "S") + "',"
            falt = falt + "Valuta,"
            varden = varden + "'" + "SEK" + "',"
            falt = falt + "Anteckning,"
            varden = varden + "'" + nullhantering(lkomment, "S") + "',"
            falt = falt + "Markning,"
            varden = varden + "'" + nullhantering(markning, "S") + "',"
            falt = falt + "Vartkundnr,"
            varden = varden + "'" + nullhantering(lvartkundnr, "S") + "',"
            falt = falt + "Varref,"
            varden = varden + "'" + nullhantering(varref, "S") + "',"
            falt = falt + "Inleveranstyp,"
            varden = varden + "'" + nullhantering(linlevtyp, "S") + "',"
            falt = falt + "Normallevtid,"
            varden = varden + "" + CStr(nullhantering(lnormlevtid, "T")) + ","
            falt = falt + "Prodnummer,"
            varden = varden + "'" + nullhantering(pprodnr, "S") + "',"
            falt = falt + "Bestnummer,"
            varden = varden + "'" + nullhantering(pbestnr, "S") + "',"
            falt = falt + "Prodnamn,"
            varden = varden + "'" + kommatillpunkt(nullhantering(pprodnamn, "S")) + "',"
            falt = falt + "antal,"
            varden = varden + "" + kommatillpunkt(CStr(nullhantering(pantal, "T"))) + ","
            falt = falt + "inpris,"
            varden = varden + "" + kommatillpunkt(CStr(nullhantering(pinpris, "T"))) + ","
            falt = falt + "prisfaktor,"
            varden = varden + "" + kommatillpunkt(CStr(nullhantering(pprisfaktor, "T"))) + ","
            falt = falt + "radsumma,"
            varden = varden + "" + kommatillpunkt(CStr(nullhantering(psumma, "T"))) + ","
            falt = falt + "Enhet,"
            varden = varden + "'" + nullhantering(pEnhet, "S") + "',"
            falt = falt + "Ordning,"
            varden = varden + "" + CStr(i) + ","
            falt = falt + "Status,"
            varden = varden + "'" + lstatus + "',"
            falt = falt + "Antlev,"
            varden = varden + "" + kommatillpunkt(CStr(nullhantering(lantlev, "T"))) + ","
            falt = falt + "Restad,"
            varden = varden + "" + kommatillpunkt(CStr(nullhantering(lrestad, "T"))) + ","
            falt = falt + "Rest"
            varden = varden + "" + kommatillpunkt(CStr(nullhantering(prest, "T"))) + ""
            mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
            myCmd = New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()
        Next i
        cn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sparaBEST()
        If InStr(BestNRTB.Text, "-") = 0 Then
            BestNRTB.Text = getnummer("Next", "Nästa bestallnummer")
        End If
        nolla()
    End Sub

    Function getbest(ByVal bestnr As String)
        On Error Resume Next
        Dim n As Integer
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, utpris(10) As Double
        Dim myCmd As OdbcCommand
        Dim tabel As OdbcDataReader


        connStr = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM BestallningsReg "
        mySQL = mySQL + "Where BestallningsID = " & "'" + bestnr + "'"
        mySQL = mySQL + " And clientid = '" + KlientID + "' "
        'mySQL = mySQL + " order by Mytimestamp "
        myCmd = New OdbcCommand(mySQL, cn)
        tabel = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        n = 1
        getbest = "Yes"

        While tabel.Read()
            LLevnrTB.Text = nullhantering(tabel("Levnr"), "S") : llevnr = LLevnrTB.Text
            BestNRTB.Text = nullhantering(tabel("BestallningsID"), "S") : bestnr = c
            LLevnamnTB.Text = nullhantering(tabel("Leverantor"), "S") : llevnamn = LLevnamnTB.Text
            LAdress1TB.Text = nullhantering(tabel("adress1"), "S") : ladress1 = LAdress1TB.Text
            LAdress2TB.Text = nullhantering(tabel("adress2"), "S") : ladress2 = LAdress2TB.Text
            LPostnummerTB.Text = nullhantering(tabel("Postnr"), "S") : lpostnr = LPostnummerTB.Text
            LOrtTB.Text = nullhantering(tabel("ort"), "S") : lort = LOrtTB.Text
            LLandTB.Text = nullhantering(tabel("land"), "S") : lland = LLandTB.Text
            LTelefonTB.Text = nullhantering(tabel("telefon"), "S") : ltelefon = LTelefonTB.Text
            LEpostTB.Text = nullhantering(tabel("epost"), "S") : lepost = LEpostTB.Text
            DatumTB.Text = nullhantering(tabel("Regdatum"), "S") : ldatum = DatumTB.Text
            LnormallevtidTB.Text = nullhantering(tabel("Normallevtid"), "S") : lnormlevtid = LnormallevtidTB.Text
            LInLevtypTB.Text = nullhantering(tabel("Inleveranstyp"), "S") : linlevtyp = LInLevtypTB.Text
            LKommentTB.Text = nullhantering(tabel("Anteckning"), "S") : lkomment = LKommentTB.Text
            LMarkningTB.Text = nullhantering(tabel("Markning"), "S") : markning = LMarkningTB.Text
            LvartreferensTB.Text = nullhantering(tabel("Varref"), "S") : varref = LvartreferensTB.Text
            LvartkundnrTB.Text = nullhantering(tabel("Vartkundnr"), "S") : lvartkundnr = LvartkundnrTB.Text



            DataGridView1.Item(0, n - 1).Value = nullhantering(tabel("Prodnummer"), "S")
            DataGridView1.Item(1, n - 1).Value = nullhantering(tabel("Bestnummer"), "S")
            DataGridView1.Update()
            DataGridView1.Item(2, n - 1).Value = nullhantering(tabel("Prodnamn"), "S")


            If nullhantering(tabel("Prisfaktor"), "T") = 0 Then

                GoTo slutloop
            End If

            DataGridView1.Item(6, n - 1).Value = nullhantering(tabel("Enhet"), "S")
            DataGridView1.Item(4, n - 1).Value = nullhantering(tabel("Prisfaktor"), "T")
            DataGridView1.Item(5, n - 1).Value = nullhantering(tabel("Antal"), "T")
            DataGridView1.Item(9, n - 1).Value = nullhantering(tabel("Inpris"), "T")
            DataGridView1.Item(10, n - 1).Value = nullhantering(tabel("radsumma"), "T")
            DataGridView1.Item(3, n - 1).Value = nullhantering(tabel("levdatum"), "S")
            DataGridView1.Item(7, n - 1).Value = nullhantering(tabel("antlev"), "T")
            DataGridView1.Item(8, n - 1).Value = nullhantering(tabel("Restad"), "T")
            DataGridView1.Item(11, n - 1).Value = nullhantering(tabel("Status"), "S")

slutloop:
            n = n + 1
        End While

        rr = n - 1 : rmax = rr
        rmaxl.Text = rr

        DataGridView1.CurrentCell = DataGridView1.Item(0, rr - 1)
        DataGridView1.RefreshEdit()
        summering()
        cn.Close()
        DataGridView1.Focus()



        'rr = n - 2 : rmax = rr
        'summering()
        'cn.Close()

        'DataGridView1.Focus()
        'DataGridView1.CurrentCell = DataGridView1.Item(0, rmax)
    End Function



    Sub nolla()
        makegrid("")
        llevnr = ""
        llevnamn = ""
        ladress1 = ""
        ladress2 = ""
        lpostnr = ""
        lort = ""
        lland = ""
        ltelefon = ""
        lepost = ""
        markning = ""
        lkomment = ""
        lvartkundnr = ""
        varref = ""
        ldatum = ""
        lnormlevtid = 0
        linlevtyp = "Beställning"
        LInLevtypTB.Text = "Beställning"
        rr = 0

        skrivatillform()

        summering()

        getinneliggandebest()

        bestnr = getnummer("Kolla", "Nästa bestallnummer")

        skrivatillform()
        LLevnamnTB.Focus()

    End Sub


    Private Sub NyB_Click(sender As Object, e As EventArgs) Handles NyB.Click

        nolla()
        status = "Ny"
    End Sub
    Sub getinneliggandebest()
        BestNRTB.Items.Clear()
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, l As Integer
        connStr = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = " SELECT        bestallningsID, Leverantor"
        mySQL = mySQL + " FROM bestallningsreg "
        mySQL = mySQL + " GROUP BY bestallningsID, Leverantor"



        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteNonQuery()
        l = 1
        If tabel.HasRows = False Then
            GoTo slut
        Else
            While tabel.Read()
                BestNRTB.Items.Add(nullhantering(tabel("bestallningsID"), "S") + "-" + nullhantering(tabel("Leverantor"), "S"))
            End While

        End If

slut:
        cn.Close()
    End Sub

    Private Sub BestNRTB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BestNRTB.SelectedIndexChanged
        bestnr = Strings.Left(BestNRTB.Text, Strings.InStr(BestNRTB.Text, "-") - 1)
        getbest(bestnr)
        rmaxl.Text = rr
    End Sub
    Function TillLagerLogg(Artiknr As String, TransID As String, Antal As Double)
        TillLagerLogg = "Ja"
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        falt = "" : varden = ""
        mySQL = "INSERT INTO LagerLogg "
        falt = falt + "clientid,"
        varden = varden + "'" + KlientID + "',"
        falt = falt + "MyTimeStamp,"
        varden = varden + "'" + gettimestamp() + "',"
        falt = falt + "Datum,"
        varden = varden + "'" + today + "',"
        falt = falt + "Id,"
        varden = varden + "'" + TransID + "',"
        falt = falt + "Prodnr,"
        varden = varden + "'" + Artiknr + "',"
        falt = falt + "Antal"
        varden = varden + "" + kommatillpunkt(CStr(Antal)) + ""
        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"

        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        'Stop
        cn.Close()
    End Function

    Private Sub UppdatlagretB_Click(sender As Object, e As EventArgs) Handles UppdatlagretB.Click
        Dim artnr As String, levantal As Double, bestantal As Double, inlevID As String
        rmaxl.Text = rr
        inlevID = "Bestnr:" + bestnr
        For i As Integer = 0 To rr

            artnr = nullhantering(DataGridView1.Item(0, i).Value, "S")
            levantal = CDbl(nullhantering(DataGridView1.Item(7, i).Value, "T"))
            bestantal = CDbl(nullhantering(DataGridView1.Item(5, i).Value, "T"))
            If levantal > 0 Then
                TillLagerLogg(artnr, inlevID, levantal)
                DataGridView1.Item(11, i).Value = "Levererade"

            End If

        Next
        sparaBEST()
        nolla()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AltProdB.Click

    End Sub

    Private Sub UtskriftB_Click(sender As Object, e As EventArgs) Handles UtskriftB.Click
        On Error Resume Next
        If FGCB.CheckState = 1 Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.WindowState = FormWindowState.Maximized
            PrintPreviewDialog1.ShowDialog()
        Else
            PrintDocument1.PrinterSettings.Copies = 1
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        On Error Resume Next
        Static startAt As Integer = 0, pagenr As Integer
        Dim PrintFont As New Font("Arial", 12, FontStyle.Regular)
        Dim StringForPage As String, x As Integer, y As Integer
        Dim point1 As Point, point2 As Point
        Dim PrinterY As Integer = e.MarginBounds.Top
        Dim StrFormat As New StringFormat
        Dim varde As Double


        'huvud
        x = 40 : y = 8
        e.Graphics.DrawString(Firmanamn, LargeFontB, BlackFont, x, y)

        e.Graphics.DrawString("Beställning", LargeFontB, BlackFont, 580, y) : y = y + 22
        e.Graphics.DrawString("Datum: " + today, SmallFontR, BlackFont, 580, y) : y = y + 22
        e.Graphics.DrawString("BestNr: " + bestnr, SmallFontR, BlackFont, 580, y) : y = y + 40
        e.Graphics.DrawString(LLevnamnTB.Text, SmallFontB, BlackFont, 42, y) : y = y + 22
        e.Graphics.DrawString(LAdress1TB.Text, SmallFontB, BlackFont, 42, y) : y = y + 22
        e.Graphics.DrawString(LAdress2TB.Text, SmallFontB, BlackFont, 42, y) : y = y + 22
        e.Graphics.DrawString(LPostnummerTB.Text, SmallFontB, BlackFont, 42, y)
        e.Graphics.DrawString(LOrtTB.Text, SmallFontB, BlackFont, 42, y) : y = y + 22
        'radrubriker
        y = y + 40



        y = y + 40
        e.Graphics.DrawString("Produktnr:", SmallFontB, BlackFont, 42, y)
        e.Graphics.DrawString("Produktnamn", SmallFontB, BlackFont, 156, y)
        e.Graphics.DrawString("PF", SmallFontB, BlackFont, 440, y)
        e.Graphics.DrawString("Enhet", SmallFontB, BlackFont, 500, y)
        e.Graphics.DrawString("Antal", SmallFontB, BlackFont, 575, y)
        e.Graphics.DrawString("Inpris", SmallFontB, BlackFont, 640, y)
        e.Graphics.DrawString("Värde", SmallFontB, BlackFont, 740, y)

        y = y + 20
        point1 = New Point(40, y) : point2 = New Point(780, y)
        e.Graphics.DrawLine(blackPen, point1, point2) : PrinterY = PrinterY + 4
        y = y + 12



        PrinterY = y

        For i As Integer = startAt To DataGridView1.RowCount - 2
            pprodnr = DataGridView1.Rows(i).Cells(0).Value
            pprodnamn = DataGridView1.Rows(i).Cells(2).Value
            If Len(pprodnamn) > 30 Then pprodnamn = Strings.Left(pprodnamn, 30)
            pprisfaktor = DataGridView1.Rows(i).Cells(4).Value
            pEnhet = DataGridView1.Rows(i).Cells(6).Value
            pantal = DataGridView1.Rows(i).Cells(5).Value
            pinpris = DataGridView1.Rows(i).Cells(9).Value

            If Len(pprodnr) < 1 Then GoTo slut
            y = y + 20

            PrinterY = y
            StringForPage = i.ToString
            'e.Graphics.DrawString(StringForPage, PrintFont, Brushes.Black, e.MarginBounds.Left, PrinterY, StrFormat)

            e.Graphics.DrawString(pprodnr, SmallFontR, BlackFont, 42, PrinterY)
            e.Graphics.DrawString(pprodnamn, SmallFontR, BlackFont, 156, PrinterY)

            e.Graphics.DrawString(pprisfaktor, SmallFontR, BlackFont, 440, PrinterY)
            e.Graphics.DrawString(pEnhet, SmallFontR, BlackFont, 520, PrinterY)
            e.Graphics.DrawString(rightpad(Format$(pantal, "###,##0.00")), SmallFontR, BlackFont, 555, y)
            e.Graphics.DrawString(rightpad(Format$(pinpris * pprisfaktor, "###,##0.00")), SmallFontR, BlackFont, 620, y)
            ' e.Graphics.DrawString(Rightpad(Format$(pinpris * pantal * pprisfaktor, "###,##0.00")), SmallFontR, BlackFont, 720, y)


            ' point1 = New Point(40, PrinterY) : point2 = New Point(780, PrinterY)
            'e.Graphics.DrawLine(blackPen, point1, point2) : PrinterY = PrinterY + 4
            PrinterY = PrinterY + 16



            'PrinterY = PrinterY + e.Graphics.MeasureString(StringForPage, PrintFont).Height
            If PrinterY >= 1050 Then
                e.HasMorePages = True
                pagenr = pagenr + 1
                PrinterY = 100
                startAt = i + 1
                Return
            End If

slut:

        Next i
        y = y + 20

        'e.Graphics.DrawString("Totalt värde", SmallFontB, BlackFont, 620, y)
        ' e.Graphics.DrawString(Rightpad(Format$(CDbl(VardeL.Text), "###,##0.00")), SmallFontB, BlackFont, 720, y)
        e.HasMorePages = False
        startAt = 0

        PrinterY = 0

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub ProduktVsLeverantörerInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktVsLeverantörerInfoToolStripMenuItem.Click
        ProduktKomponenterF.Show()
    End Sub

    Private Sub LeverantörRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeverantörRegisterToolStripMenuItem.Click
        Levregf.Show()
    End Sub

    Private Sub LLevnrTB_TextChanged(sender As Object, e As EventArgs) Handles LLevnrTB.TextChanged
        llevnr = LLevnrTB.Text
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        rmaxl.Text = rr
    End Sub

    Private Sub odbcsource_Click(sender As Object, e As EventArgs) Handles odbcsourcel.Click

    End Sub

    Private Sub LLevnrTB_KeyUp(sender As Object, e As KeyEventArgs) Handles LLevnrTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim dummy As String
            ' If Status <> "Ny" Then
            dummy = getleverantor("LikaNummer")
            skrivatillform()
            ' End If
            LAdress1TB.Focus()
        End If
    End Sub
End Class