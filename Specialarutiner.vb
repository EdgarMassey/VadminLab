Imports System.Data.Odbc

Public Class SpecrutinerF



    Private Sub TomLabProdukterB_Click(sender As Object, e As EventArgs) Handles TomLabProdukterB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim response
        response = MsgBox("Vill du verkligen radera  hela Labprodukt registret", 1, "OBS")
        If response = 1 Then    ' User chose Yes.
            connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM Labprodukter "
            ' mySQL = mySQL + " Where ProduktKod = '" + ProduktIDTB.Text + "' "

            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()

        Else
        End If
    End Sub

    Private Sub TomProvRegB_Click(sender As Object, e As EventArgs) Handles TomProvRegB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim response
        response = MsgBox("Vill du verkligen radera Provregistret", 1, "OBS")
        If response = 1 Then    ' User chose Yes.
            connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM Labtester "
            ' mySQL = mySQL + " Where Provnamn = '" + TestNamnTB.Text + "' "

            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()

        Else
        End If
    End Sub

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub

    Private Sub SpecrutinerF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Speciala rutiner "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsource.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + databasnamn
        Gnamn.Text = Firmanamn
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub HämtaNotesB_Click(sender As Object, e As EventArgs) Handles HämtaNotesB.Click
        Me.Cursor = Cursors.WaitCursor
        Dim mysql As String, sConnectionString As String
        Dim mytimestamp As String, datum As String, text As String

        'On Error GoTo sluthampt
        mysql = "Select * FROM Notes"


        sConnectionString = "Provider=SQLOLEDB;Data Source=" + "sql.vadmin.net" + ",1433;Network Library=DBMSSOCN;Initial Catalog=" + "NMLab" + ";User ID=v2000;Password=" + odbclosen + ";"

        Dim conn As New System.Data.OleDb.OleDbConnection(sConnectionString)
        Dim cmd As New System.Data.OleDb.OleDbCommand(mysql, conn)
        Dim dr As System.Data.OleDb.OleDbDataReader
        conn.Open()
        dr = cmd.ExecuteReader()


        Do While dr.Read()
            mytimestamp = (dr.Item("Timestamp"))
            datum = (dr.Item("Datum"))
            text = (dr.Item("Text"))
            savepost(mytimestamp, datum, text)

        Loop
        dr.Close()
        conn.Close()
sluthampt:

        Me.Cursor = Cursors.Default
    End Sub
    Function savepost(ts As String, dat As String, tx As String)



        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM Notes "
        mySQL = mySQL + " Where TimeStamp = '" + ts + "' "

        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  Notes "
        falt = falt + "Timestamp,"
        varden = varden + "'" + kommatillpunkt(ts) + "',"
        falt = falt + "Datum,"
        varden = varden + "'" + kommatillpunkt(dat) + "',"
        falt = falt + "Text "

        varden = varden + "'" + kommatillpunkt(tx) + "'  "

        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()

        savepost = ""



    End Function
End Class