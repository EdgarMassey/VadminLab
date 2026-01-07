Imports System.Data.Odbc
Public Class LagerRegF
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim builder As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter)
    Private Sub LagerRegF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Lagerregister"
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsourcel.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + databasnamn
        Gnamn.Text = Firmanamn
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.Columns(0).Width = 0
        DataGridView1.Columns(1).Width = 70
        DataGridView1.Columns(2).Width = 140
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(4).Width = 120
        summering()

        Sokbegrepp.Select()
    End Sub
    Function CreateDataSet() As DataSet
        Dim strConnString, strSQL As String, DELSTRING As Integer = 0
        strConnString = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen

        strSQL = "SELECT * FROM LagerPlatsReg "



        If Len(Sokbegrepp.Text) > 0 Then
            If LagerPlatsRB.Checked = True Then

                'strSQL = strSQL + "Where lagerplats = '" + Sokbegrepp.Text + "'"
                DELSTRING = Len(Sokbegrepp.Text)
                strSQL = strSQL + "Where left(lagerplats," + CStr(DELSTRING) + ") = '" + Sokbegrepp.Text + "'"
                strSQL = strSQL + " order by lagerplats,produktnummer"
            Else
                'strSQL = strSQL + "Where produktnummer = '" + Sokbegrepp.Text + "'"
                DELSTRING = Len(Sokbegrepp.Text)
                strSQL = strSQL + "Where left(produktnummer," + CStr(DELSTRING) + ") = '" + Sokbegrepp.Text + "'"
                strSQL = strSQL + " order by produktnummer,lagerplats"
            End If
        Else
            strSQL = strSQL + " order by lagerplats"
        End If



        objConn.ConnectionString = strConnString
        With objCmd
            .Connection = objConn
            .CommandText = strSQL
            .CommandType = CommandType.Text
        End With
        dtAdapter.SelectCommand = objCmd
        dtAdapter.Fill(ds)
        Return ds '*** Return DataSet ***'  
        dtAdapter = Nothing
    End Function

    Private Sub Sokbegrepp_TextChanged(sender As Object, e As EventArgs) Handles Sokbegrepp.TextChanged

    End Sub

    Private Sub Sokbegrepp_KeyUp(sender As Object, e As KeyEventArgs) Handles Sokbegrepp.KeyUp
        If e.KeyCode = Keys.Enter Then



            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
            summering()


        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Sub summering()
        Dim tot As Double
        tot = 0
        For i As Integer = 0 To DataGridView1.RowCount - 2
            tot = tot + nullhantering(DataGridView1.Rows(i).Cells("antal").Value, "T")
        Next
        SummaL.Text = tot
        SummaL.Refresh()


    End Sub

    Private Sub Spara_Click(sender As Object, e As EventArgs) Handles Spara.Click
        Dim changes As DataSet
        changes = ds.GetChanges()
        If changes IsNot Nothing Then
            dtAdapter.Update(ds.Tables(0))
        End If
        ds.AcceptChanges()
    End Sub

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Foretag.Close()
        System.Diagnostics.Process.Start(sokvag + "UpdateLager.exe")
        Me.Close()
    End Sub

    Private Sub Gnamn_Click(sender As Object, e As EventArgs) Handles Gnamn.Click
        LokalInstF.Show()
    End Sub

    Private Sub Huvud_Click(sender As Object, e As EventArgs) Handles Huvud.Click
        'Dim cn As OdbcConnection, mysql As String, test As String, mysql2 As String, cn2 As OdbcConnection
        'Dim connStr As String, prnr As String, lagplats As String, tantal As Integer, falt As String, varden As String
        'Dim nr As Integer


        'Dim myCmd2 As New OdbcCommand
        'connStr = "DSN=" + odbcsourcer + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        'cn = New OdbcConnection(connStr)
        'cn2 = New OdbcConnection(connStr)
        'cn.Open()
        'cn2.Open()
        'mysql = "select * FROM LagerB  "
        '' mysql = mysql + " WHERE ClientID = '" + KlientID + "' "
        'mysql = mysql + " order by LagerPlats "
        'Dim myCmd As New OdbcCommand(mysql, cn)
        'Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        ''myCmd.ExecuteReader()
        'nr = 0
        'While tabel.Read()
        '    nr = nr + 1
        '    Label2.Text = nr
        '    Label2.Refresh()
        '    prnr = nullhantering(tabel("Produktnummer"), "S")
        '    lagplats = nullhantering(tabel("Lagerplats"), "S")
        '    tantal = nullhantering(tabel("Antal"), "T")


        '    falt = "" : varden = ""
        '    mysql = "INSERT INTO  LagerPlatsReg "
        '    falt = falt + "MytimeStamp,"
        '    varden = varden + "'" + gettimestamp() + "',"
        '    falt = falt + "Produktnummer,"
        '    varden = varden + "'" + prnr + "',"
        '    falt = falt + "Lagerplats,"
        '    varden = varden + "'" + lagplats + "',"

        '    falt = falt + "Antal"
        '    varden = varden + " " + kommatillpunkt(nullhantering(tantal, "T")) + " "




        '    mysql2 = mysql & "(" & falt & ") VALUES (" & varden & ");"
        '    myCmd2 = New OdbcCommand(mysql2, cn2)


        '    myCmd2.ExecuteNonQuery()

        '    Label2.Text = nr
        '    Label2.Refresh()
        '    nr = nr + 1
        'End While
        'cn.Close()
        'On Error Resume Next
    End Sub

    Private Sub InUtregistreringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InUtregistreringToolStripMenuItem.Click
        InUtRegGB.Visible = True
        ProdnrRB.Visible = False
        LagerPlatsRB.Visible = False
        Label1.Visible = False
        Sokbegrepp.Visible = False
        Spara.Enabled = False
    End Sub

    Private Sub InUtAvslutaB_Click(sender As Object, e As EventArgs) Handles InUtAvslutaB.Click
        InUtRegGB.Visible = False
        ProdnrRB.Visible = True
        LagerPlatsRB.Visible = True
        Label1.Visible = True
        Sokbegrepp.Visible = True
        Spara.Enabled = True
    End Sub

    Private Sub InUtSparB_Click(sender As Object, e As EventArgs) Handles InUtSparB.Click
        'kolla om det finns
        Dim pantal2 As Double = 0
        If Len(LagerplatsTB.Text) = 0 Then GoTo slut1
        If Len(ProdnrTB.Text) = 0 Then GoTo slut1

        If GetlagerplatsOchProdnr(LagerplatsTB.Text, ProdnrTB.Text) = "No" Then
            If TilllagerRB.Checked = True Then
                pantal = AntalTB.Text
            Else
                pantal = nullhantering(AntalTB.Text, "T") * -1
            End If
            skrivatilllager(LagerplatsTB.Text, ProdnrTB.Text, pantal)
        Else
            If TilllagerRB.Checked = True Then
                pantal2 = AntalTB.Text
            Else
                pantal2 = nullhantering(AntalTB.Text, "T") * -1
            End If
            skrivatilllager(LagerplatsTB.Text, ProdnrTB.Text, pantal + pantal2)


        End If
slut1:

        InUtRegGB.Visible = False
        ProdnrRB.Visible = True
        LagerPlatsRB.Visible = True
        Label1.Visible = True
        Sokbegrepp.Visible = True
        Spara.Enabled = True

        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        summering()
    End Sub
    Function GetlagerplatsOchProdnr(lp As String, pnr As String)
        GetlagerplatsOchProdnr = "No"

        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim myCmd As OdbcCommand
        Dim tabel As OdbcDataReader


        connStr = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM LagerPlatsReg "
        mySQL = mySQL + "Where lagerplats = " & "'" + lp + "'"
        mySQL = mySQL + " And produktnummer = '" + pnr + "' "

        myCmd = New OdbcCommand(mySQL, cn)
        tabel = myCmd.ExecuteReader(CommandBehavior.CloseConnection)

        tabel.Read()

        If tabel.HasRows = False Then
            GetlagerplatsOchProdnr = "No"
            'MessageBox.Show("Kontot " + nr + " saknas")

        Else
            pantal = nullhantering(tabel("antal"), "S")
            GetlagerplatsOchProdnr = "Yes"
        End If
        cn.Close()

    End Function
    Function skrivatilllager(lp As String, pnr As String, ant As Double)
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM LagerPlatsReg "
        mySQL = mySQL + " Where Lagerplats = '" + lp + "' "
        mySQL = mySQL + " And Produktnummer = '" + pnr + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO LagerPlatsReg "
        falt = falt + "MyTimeStamp,"
        varden = varden + "'" + gettimestamp() + "',"
        falt = falt + "Lagerplats,"
        varden = varden + "'" + lp + "',"
        falt = falt + "produktnummer,"
        varden = varden + "'" + kommatillpunkt(pnr) + "',"
        falt = falt + "Forandring,"
        varden = varden + "'" + Strings.Left(Now, 16) + "',"
        falt = falt + "Antal"
        varden = varden + "" + CStr(ant) + ""
        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        If ant <> 0 Then
            myCmd.ExecuteNonQuery()
        End If

        'Stop
        cn.Close()
        skrivatilllager = "Bra"
    End Function

    Private Sub UtskrifterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtskrifterToolStripMenuItem.Click
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
        Static startAt As Integer = 0, lplats As String = ""
        Dim PrintFont As New Font("Arial", 12, FontStyle.Regular)
        Dim x As Integer, y As Integer
        '  Dim StringForPage As String, x As Integer, y As Integer
        Dim point1 As Point, point2 As Point, pagenr As Integer
        Dim PrinterY As Integer = e.MarginBounds.Top
        Dim StrFormat As New StringFormat
        'huvud
        x = 40 : y = 8
        e.Graphics.DrawString(Firmanamn, LargeFontB, BlackFont, x, y)
        e.Graphics.DrawString("Lagerutskrift", LargeFontB, BlackFont, 580, y) : y = y + 22
        e.Graphics.DrawString("Datum: " + today, SmallFontR, BlackFont, 580, y)
        'radrubriker

        y = y + 40
        e.Graphics.DrawString("Period ", SmallFontB, BlackFont, x, y) : y = y + 20
        ' e.Graphics.DrawString(FromTB.Text + " - " + TOMTB.Text, SmallFontR, BlackFont, x, y) : y = y + 20
        y = y + 40
        e.Graphics.DrawString("Lagerplats:", SmallFontB, BlackFont, 42, y)
        e.Graphics.DrawString("Produktnummer", SmallFontB, BlackFont, 156, y)
        e.Graphics.DrawString("Antal", SmallFontB, BlackFont, 414, y)
        e.Graphics.DrawString("Förändrad", SmallFontB, BlackFont, 550, y)

        y = y + 20
        point1 = New Point(40, y) : point2 = New Point(780, y)
        e.Graphics.DrawLine(blackPen, point1, point2) : PrinterY = PrinterY + 4
        y = y + 12
        PrinterY = y
        For i As Integer = startAt To DataGridView1.RowCount - 2



            pprodnr = nullhantering(DataGridView1.Rows(i).Cells("Produktnummer").Value, "S")

            ldatum = nullhantering(DataGridView1.Rows(i).Cells("forandring").Value, "S")
            pantal = nullhantering(DataGridView1.Rows(i).Cells("antal").Value, "T")
            lplats = nullhantering(DataGridView1.Rows(i).Cells("lagerplats").Value, "S")

            ' StringForPage = i.ToString
            e.Graphics.DrawString(lplats, SmallFontR, BlackFont, 42, PrinterY)
            e.Graphics.DrawString(pprodnr, SmallFontR, BlackFont, 156, PrinterY)
            e.Graphics.DrawString(ldatum, SmallFontR, BlackFont, 520, PrinterY)

            e.Graphics.DrawString(rightpad(Format$(pantal, "#####0")), SmallFontR, BlackFont, 360, PrinterY)


            PrinterY = PrinterY + 16
            If PrinterY >= 1050 Then

                e.HasMorePages = True
                pagenr = pagenr + 1
                PrinterY = 100
                startAt = i + 1
                Return
            End If
        Next i
        PrinterY = PrinterY + 25
        e.Graphics.DrawString("Summa", SmallFontB, BlackFont, 280, PrinterY)
        e.Graphics.DrawString(rightpad(Format$((CDbl(SummaL.Text)), "###,##0")), SmallFontB, BlackFont, 360, PrinterY)
        e.HasMorePages = False
        startAt = 0

        PrinterY = 0
    End Sub

    Private Sub TillLagB_Click(sender As Object, e As EventArgs) Handles TillLagB.Click
        InUtRegGB.Visible = True
        ProdnrRB.Visible = False
        LagerPlatsRB.Visible = False
        Label1.Visible = False
        Sokbegrepp.Visible = False
        Spara.Enabled = False
        TilllagerRB.Checked = True
    End Sub

    Private Sub FranLagB_Click(sender As Object, e As EventArgs) Handles FranLagB.Click
        InUtRegGB.Visible = True
        ProdnrRB.Visible = False
        LagerPlatsRB.Visible = False
        Label1.Visible = False
        Sokbegrepp.Visible = False
        Spara.Enabled = False
        FranlagerRB.Checked = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LagerPlatsRB_CheckedChanged(sender As Object, e As EventArgs) Handles LagerPlatsRB.CheckedChanged
        Sokbegrepp.Select()
    End Sub

    Private Sub ProdnrRB_CheckedChanged(sender As Object, e As EventArgs) Handles ProdnrRB.CheckedChanged
        Sokbegrepp.Select()
    End Sub
End Class