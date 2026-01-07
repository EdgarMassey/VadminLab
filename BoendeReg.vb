Imports System.Data.Odbc
Public Class LabStartF
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
        Huvud.Text = Prognamn + " - Boenderegister"
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsource.Text = "ODBCsource:" + odbcsourcer
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
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(4).Width = 120
        DatFROMTb.Text = today
        DatTOMTb.Text = today
        CreateDataSet()
    End Sub
    Function CreateDataSet() As DataSet
        Dim strConnString, strSQL As String, DELSTRING As Integer = 0
        strConnString = "DSN=" + odbcsourcer + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen

        strSQL = "SELECT * FROM BoendeReg "





        strSQL = strSQL + "Where Datum >= '" + DatFROMTb.Text + "' "
        strSQL = strSQL + "And Datum <= '" + DatTOMTb.Text + "'"

        strSQL = strSQL + " order by Namn"




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

    Private Sub Sokbegrepp_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Sokbegrepp_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then



            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView



        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub Spara_Click(sender As Object, e As EventArgs)
        Dim changes As DataSet
        changes = ds.GetChanges()
        If changes IsNot Nothing Then
            dtAdapter.Update(ds.Tables(0))
        End If
        ds.AcceptChanges()
    End Sub

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        System.Diagnostics.Process.Start(sokvag + "VadminMeny.exe")
        Foretag.Close()
        Me.Close()
    End Sub

    Private Sub Gnamn_Click(sender As Object, e As EventArgs) Handles Gnamn.Click

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

        DatumTB.Text = today


    End Sub

    Private Sub InUtAvslutaB_Click(sender As Object, e As EventArgs) Handles InUtAvslutaB.Click
        InUtRegGB.Visible = False

        Label1.Visible = True


    End Sub

    Private Sub InUtSparB_Click(sender As Object, e As EventArgs) Handles InUtSparB.Click
        'kolla om det finns
        Dim pantal2 As Double = 0
        If Len(NamnTB.Text) = 0 Then GoTo slut1
        If Len(PersonnrTB.Text) = 0 Then GoTo slut1




        skrivatilllager(DatumTB.Text, NamnTB.Text, PersonnrTB.Text, HandlTB.Text)



slut1:

        InUtRegGB.Visible = False

        Label1.Visible = True



        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView

    End Sub

    Function skrivatilllager(datum As String, namn As String, Personnr As String, handlagare As String)
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsourcer + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM BoendeReg "
        mySQL = mySQL + " Where Personnr =  '" + PersonnrTB.Text + "' "
        mySQL = mySQL + " And Datum = '" + DatumTB.Text + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO BoendeReg "
        falt = falt + "TimeStamp,"
        varden = varden + "'" + gettimestamp() + "',"
        falt = falt + "Datum,"
        varden = varden + "'" + datum + "',"
        falt = falt + "Namn,"
        varden = varden + "'" + namn + "',"
        falt = falt + "Personnr,"
        varden = varden + "'" + Personnr + "',"
        falt = falt + "Handlaggare"
        varden = varden + "'" + handlagare + "' "
        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)

        myCmd.ExecuteNonQuery()


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
        Static startAt As Integer = 0, lplats As String = "", ldatum As String, lnamn As String, lpersonnr As String, lhandlaggare As String
        Dim PrintFont As New Font("Arial", 12, FontStyle.Regular)
        Dim x As Integer, y As Integer
        '  Dim StringForPage As String, x As Integer, y As Integer
        Dim point1 As Point, point2 As Point, pagenr As Integer
        Dim PrinterY As Integer = e.MarginBounds.Top
        Dim StrFormat As New StringFormat

        'huvud
        x = 40 : y = 8
        e.Graphics.DrawString(Firmanamn, LargeFontB, BlackFont, x, y)
        e.Graphics.DrawString("Bokningutskrift", LargeFontB, BlackFont, 580, y) : y = y + 22
        e.Graphics.DrawString("Datum: " + today, SmallFontR, BlackFont, 580, y)
        'radrubriker

        y = y + 40
        e.Graphics.DrawString("Period ", SmallFontB, BlackFont, x, y) : y = y + 20
        e.Graphics.DrawString(DatFROMTb.Text + " - " + DatTOMTb.Text, SmallFontR, BlackFont, x, y) : y = y + 20
        y = y + 40
        e.Graphics.DrawString("Datum:", SmallFontB, BlackFont, 42, y)
        e.Graphics.DrawString("Namn", SmallFontB, BlackFont, 150, y)
        e.Graphics.DrawString("Personnr", SmallFontB, BlackFont, 400, y)
        e.Graphics.DrawString("Handläggare", SmallFontB, BlackFont, 520, y)

        y = y + 20
        point1 = New Point(40, y) : point2 = New Point(780, y)
        e.Graphics.DrawLine(blackPen, point1, point2) : PrinterY = PrinterY + 4
        y = y + 12
        PrinterY = y
        For i As Integer = startAt To DataGridView1.RowCount - 2





            ldatum = nullhantering(DataGridView1.Rows(i).Cells("Datum").Value, "S")
            lnamn = nullhantering(DataGridView1.Rows(i).Cells("Namn").Value, "S")
            lpersonnr = nullhantering(DataGridView1.Rows(i).Cells("Personnr").Value, "S")
            lhandlaggare = nullhantering(DataGridView1.Rows(i).Cells("Handlaggare").Value, "S")
            ' StringForPage = i.ToString
            e.Graphics.DrawString(ldatum, SmallFontR, BlackFont, 42, PrinterY)
            e.Graphics.DrawString(lnamn, SmallFontR, BlackFont, 150, PrinterY)
            e.Graphics.DrawString(lpersonnr, SmallFontR, BlackFont, 400, PrinterY)
            e.Graphics.DrawString(lhandlaggare, SmallFontR, BlackFont, 520, PrinterY)


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

        e.HasMorePages = False
        startAt = 0

        PrinterY = 0
    End Sub



    Private Sub FranLagB_Click(sender As Object, e As EventArgs)
        InUtRegGB.Visible = True

        Label1.Visible = False

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LagerPlatsRB_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProdnrRB_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DatFROMTb_TextChanged(sender As Object, e As EventArgs) Handles DatFROMTb.TextChanged

    End Sub

    Private Sub DatFROMTb_KeyUp(sender As Object, e As KeyEventArgs) Handles DatFROMTb.KeyUp
        If e.KeyCode = Keys.Enter Then



            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView



        End If
    End Sub

    Private Sub DatTOMTb_TextChanged(sender As Object, e As EventArgs) Handles DatTOMTb.TextChanged

    End Sub

    Private Sub DatTOMTb_KeyUp(sender As Object, e As KeyEventArgs) Handles DatTOMTb.KeyUp
        If e.KeyCode = Keys.Enter Then



            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView



        End If
    End Sub

    Private Sub ProdnrTB_TextChanged(sender As Object, e As EventArgs) Handles PersonnrTB.TextChanged

    End Sub
End Class