Imports System.Data.Common
Imports System.Data.Odbc

Public Class ProduktKomponenterF
    Dim dbkontonr As String = ""
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objConn2 As New System.Data.Odbc.OdbcConnection '
    Dim objConn3 As New System.Data.Odbc.OdbcConnection
    Dim objConn4 As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim objCmd2 As New System.Data.Odbc.OdbcCommand
    Dim objCmd3 As New System.Data.Odbc.OdbcCommand
    Dim objCmd4 As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim dtAdapter2 As New System.Data.Odbc.OdbcDataAdapter
    Dim dtAdapter3 As New System.Data.Odbc.OdbcDataAdapter
    Dim dtAdapter4 As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet, r As Integer, c As Integer, utskrifttyp As String
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim ds4 As New DataSet
    Dim builder As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter)
    Dim builder2 As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter2)
    Dim builder3 As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter3)
    Dim builder4 As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter4)

    Private Sub AvslutaB_Click(sender As Object, e As EventArgs) Handles AvslutaB.Click
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Huvud_Click(sender As Object, e As EventArgs) Handles Huvud.Click

        komponentLeverantor()
    End Sub

    Private Sub NewLabKomponentB_Click(sender As Object, e As EventArgs) Handles NewLabKomponentB.Click
        DataGridView3.Visible = False

        'Me.DataGridView1.Location = New Point(10, 10)
        'Me.DataGridView1.Size = New Point(300, 130)
        DataGridView1.Visible = True

        SokTB.Visible = True
        SokTB.Text = "Möjliga komponenter"
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView

        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.RowHeadersWidth = 5
        DataGridView1.Columns(0).Width = 0
        DataGridView1.Columns(1).Width = 80
        DataGridView1.Columns(2).Width = 200
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ProduktKomponenterF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)
        ' odbcsourcer = "VadminODBC"
        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + "LabKomponenter / Lableverantörer   "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsourcel.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + Labdatabasnamn
        Gnamn.Text = Firmanamn

        DataGridView2.DataSource = CreateDataSet2.Tables(0).DefaultView
        With DataGridView2.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView2.Font, FontStyle.Bold)
        End With
        DataGridView2.Columns(0).Width = 80
        DataGridView2.Columns(1).Width = 100
        DataGridView2.Columns(2).Width = 200
    End Sub

    Private Sub SparaB_Click(sender As Object, e As EventArgs) Handles SparaB.Click

        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM LabKomponenter"
        mySQL = mySQL + " Where KomponentNR= '" + KomponentIDTB.Text + "' "

        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  LabKomponenter "
        falt = falt + "KomponentNR,"
        varden = varden + "'" + kommatillpunkt(KomponentIDTB.Text) + "',"
        falt = falt + "KomponentNamn,"
        varden = varden + "'" + kommatillpunkt(KomponentNamnTB.Text) + "',"
        falt = falt + "Komponentspec "
        varden = varden + "'" + kommatillpunkt(KommentsTB.Text) + "' "

        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()
        DataGridView2.DataSource.Table.Rows.Clear()
        DataGridView2.DataSource = CreateDataSet2.Tables(0).DefaultView
        DataGridView1.Visible = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim r2 As Integer, c2 As Integer
        nolla()
        r2 = Me.DataGridView1.CurrentRow.Index
        c2 = DataGridView1.CurrentCell.ColumnIndex
        KomponentIDTB.Text = nullhantering(DataGridView1.Item(1, r2).Value, "S")
        KomponentNamnTB.Text = nullhantering(DataGridView1.Item(2, r2).Value, "S")
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim r2 As Integer, c2 As Integer
        nolla()
        r2 = Me.DataGridView2.CurrentRow.Index
        c2 = DataGridView2.CurrentCell.ColumnIndex
        KomponentIDTB.Text = nullhantering(DataGridView2.Item(0, r2).Value, "S")
        KomponentNamnTB.Text = nullhantering(DataGridView2.Item(1, r2).Value, "S")
        KommentsTB.Text = nullhantering(DataGridView2.Item(2, r2).Value, "S")

        komponentLeverantor()
    End Sub

    Private Sub RaderaB_Click(sender As Object, e As EventArgs) Handles RaderaB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim response
        response = MsgBox("Vill du verkligen radera produkten", 1, "OBS")
        If response = 1 Then    ' User chose Yes.
            connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM LabKomponenter"
            mySQL = mySQL + " Where KomponentNR= '" + KomponentIDTB.Text + "' "

            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()
            cn.Close()
            DataGridView2.DataSource.Table.Rows.Clear()
            DataGridView2.DataSource = CreateDataSet2.Tables(0).DefaultView
        Else
        End If
        DataGridView1.Visible = False
    End Sub

    Private Sub NewLabLeverantorB_Click(sender As Object, e As EventArgs) Handles NewLabLeverantorB.Click
        DataGridView1.Visible = False
        SokTB.Visible = False
        'Me.DataGridView3.Location = New Point(1160, 10)
        'Me.DataGridView3.Size = New Point(300, 150)
        DataGridView3.Visible = True
        Sok3TB.Visible = True
        If DataGridView3.RowCount = 0 Then
        Else
            DataGridView3.DataSource.Table.Rows.Clear()
        End If

        DataGridView3.Visible = True


        DataGridView3.DataSource = CreateDataSet3.Tables(0).DefaultView

        With DataGridView3.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView3.Font, FontStyle.Bold)
        End With
        DataGridView3.RowHeadersWidth = 5
        DataGridView3.Columns(0).Width = 0
        DataGridView3.Columns(1).Width = 80
        DataGridView3.Columns(2).Width = 200
    End Sub
    Sub komponentLeverantor()
        ' DataGridView1.Visible = False
        ' SokTB.Visible = False
        ' Me.DataGridView3.Location = New Point(1160, 10)
        ' Me.DataGridView3.Size = New Point(300, 150)
        DataGridView4.Visible = True

        If DataGridView4.RowCount = 0 Then
        Else
            DataGridView4.DataSource.Table.Rows.Clear()
        End If

        DataGridView4.Visible = True

        Sok3TB.Visible = True
        Sok3TB.Text = "Möjliga leverantörer till komponenten"
        DataGridView4.DataSource = CreateDataSet4.Tables(0).DefaultView

        With DataGridView4.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView4.Font, FontStyle.Bold)
        End With
        DataGridView4.RowHeadersWidth = 5
        DataGridView4.Columns(0).Width = 0
        DataGridView4.Columns(1).Width = 80
        DataGridView4.Columns(2).Width = 200
    End Sub
    Function CreateDataSet() As DataSet

        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen

        strSQL = "SELECT * FROM produktreg "
            strSQL = strSQL + " where produktgrupp   = 'ZRV' "
            strSQL = strSQL + "  order by prodnamn"

        objConn.ConnectionString = strConnString
        With objCmd
            .Connection = objConn
            .CommandText = strSQL
            .CommandType = CommandType.Text
        End With
        dtAdapter.SelectCommand = objCmd
        dtAdapter.Fill(ds2)
        Return ds2 '*** Return DataSet ***'  
        dtAdapter = Nothing
    End Function

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Function CreateDataSet2() As DataSet

        Dim strConnString2, strSQL2 As String
        strConnString2 = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL2 = "SELECT * FROM Labkomponenter"
        strSQL2 = strSQL2 + "  order by komponentnamn"

        objConn2.ConnectionString = strConnString2
        With objCmd2
            .Connection = objConn2
            .CommandText = strSQL2
            .CommandType = CommandType.Text
        End With
        dtAdapter2.SelectCommand = objCmd2
        dtAdapter2.Fill(ds)
        Return ds  '*** Return DataSet ***'  
        dtAdapter2 = Nothing
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles LevIDTB.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LeverantorID.Click

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Function CreateDataSet3() As DataSet

        Dim strConnString3, strSQL3 As String
        strConnString3 = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen

        strSQL3 = "SELECT * FROM Levreg "
        strSQL3 = strSQL3 + "  order by Levnamn"

        objConn3.ConnectionString = strConnString3
        With objCmd3
            .Connection = objConn3
            .CommandText = strSQL3
            .CommandType = CommandType.Text
        End With
        dtAdapter3.SelectCommand = objCmd3
        dtAdapter3.Fill(ds3)
        Return ds3  '*** Return DataSet ***'  
        dtAdapter3 = Nothing
    End Function
    Function CreateDataSet4() As DataSet

        Dim strConnString4, strSQL4 As String
        strConnString4 = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen

        strSQL4 = "SELECT * FROM ProdLevLink "
        strSQL4 = strSQL4 + "  where kompnr = '" + KomponentIDTB.Text + "' "
        strSQL4 = strSQL4 + "  order by Levnamn"

        objConn4.ConnectionString = strConnString4
        With objCmd4
            .Connection = objConn4
            .CommandText = strSQL4
            .CommandType = CommandType.Text
        End With
        dtAdapter4.SelectCommand = objCmd4
        dtAdapter4.Fill(ds4)
        Return ds4  '*** Return DataSet ***'  
        dtAdapter4 = Nothing
    End Function

    Private Sub SparaLevB_Click(sender As Object, e As EventArgs) Handles SparaLevB.Click
        On Error Resume Next
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM Prodlevlink"
        mySQL = mySQL + " Where KompNR= '" + KomponentIDTB.Text + "' "
        mySQL = mySQL + " And Levnr= '" + LevIDTB.Text + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  ProdLevLink "

        falt = falt + "MytimeStamp,"
        varden = varden + "'" + gettimestamp() + "',"
        falt = falt + "LevNR,"
        varden = varden + "'" + kommatillpunkt(LevIDTB.Text) + "',"
        falt = falt + "Komment1,"
        varden = varden + "'" + kommatillpunkt(LevlankTB.Text) + "',"
        falt = falt + "LevNamn,"
        varden = varden + "'" + kommatillpunkt(LevNamnTB.Text) + "',"
        falt = falt + "Kompnr,"
        If Len(KomponentIDTB.Text) = 0 Then
            varden = varden + "'" + "Alla" + "', "
        Else
            varden = varden + "'" + kommatillpunkt(KomponentIDTB.Text) + "',"
        End If
        falt = falt + "KommentLev "
            varden = varden + "'" + kommatillpunkt(LevKommentsTB.Text) + "' "

        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()
        ' DataGridView4.DataSource.Table.Rows.Clear()
        DataGridView4.DataSource = CreateDataSet4.Tables(0).DefaultView
        DataGridView3.Visible = False
        nolla2()
    End Sub

    Private Sub KomponentIDTB_TextChanged(sender As Object, e As EventArgs) Handles KomponentIDTB.TextChanged

    End Sub

    Private Sub RaderaLevB_Click(sender As Object, e As EventArgs) Handles RaderaLevB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim response
        response = MsgBox("Vill du verkligen radera leverantören", 1, "OBS")
        If response = 1 Then    ' User chose Yes.
            connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM Prodlevlink"
            mySQL = mySQL + " Where KompNR= '" + KomponentIDTB.Text + "' "
            mySQL = mySQL + " And Levnr= '" + LevIDTB.Text + "' "

            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()
            cn.Close()
            DataGridView4.DataSource.Table.Rows.Clear()
            DataGridView4.DataSource = CreateDataSet4.Tables(0).DefaultView
        Else
        End If
        DataGridView1.Visible = False
        nolla2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SparaLankadeInfoB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM Prodlevlink"
        mySQL = mySQL + " Where KompNR= '" + KomponentIDTB.Text + "' "
        mySQL = mySQL + " And Levnr= '" + LevIDTB.Text + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  ProdLevLink "

        falt = falt + "MytimeStamp,"
        varden = varden + "'" + gettimestamp() + "',"
        falt = falt + "LevNR,"
        varden = varden + "'" + kommatillpunkt(LevIDTB.Text) + "',"
        falt = falt + "Komment1,"
        varden = varden + "'" + kommatillpunkt(LevlankTB.Text) + "',"
        falt = falt + "LevNamn,"
        varden = varden + "'" + kommatillpunkt(LevNamnTB.Text) + "',"
        falt = falt + "Kompnr,"
        If Len(KomponentIDTB.Text) = 0 Then
            varden = varden + "'" + "Alla" + "', "
        Else
            varden = varden + "'" + kommatillpunkt(KomponentIDTB.Text) + "',"
        End If
        falt = falt + "KommentLev "
        varden = varden + "'" + kommatillpunkt(LevKommentsTB.Text) + "' "

        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()
        DataGridView4.DataSource.Table.Rows.Clear()
        DataGridView4.DataSource = CreateDataSet4.Tables(0).DefaultView
        DataGridView3.Visible = False
        nolla2()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RaderaLankadeInfoB.Click

    End Sub

    Sub nolla()
        KomponentIDTB.Text = ""
        KomponentNamnTB.Text = ""
        KommentsTB.Text = ""
    End Sub

    Private Sub SokTB_TextChanged(sender As Object, e As EventArgs) Handles SokTB.TextChanged

    End Sub

    Sub nolla2()
        KomponentIDTB.Text = ""
        KomponentNamnTB.Text = ""
        KommentsTB.Text = ""
        LevlankTB.Text = ""
        LevIDTB.Text = ""
        LevNamnTB.Text = ""
        LevKommentsTB.Text = ""
    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        Dim r4 As Integer, c4 As Integer
        'nolla()
        r4 = Me.DataGridView4.CurrentRow.Index
        c4 = DataGridView4.CurrentCell.ColumnIndex
        LevIDTB.Text = nullhantering(DataGridView4.Item(1, r4).Value, "S")
        LevNamnTB.Text = nullhantering(DataGridView4.Item(2, r4).Value, "S")
        LevKommentsTB.Text = nullhantering(DataGridView4.Item(5, r4).Value, "S")
        LevlankTB.Text = nullhantering(DataGridView4.Item(4, r4).Value, "S")

    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Dim r4 As Integer, c4 As Integer
        'nolla()
        r4 = Me.DataGridView3.CurrentRow.Index
        c4 = DataGridView3.CurrentCell.ColumnIndex
        LevIDTB.Text = nullhantering(DataGridView3.Item(1, r4).Value, "S")
        LevNamnTB.Text = nullhantering(DataGridView3.Item(2, r4).Value, "S")
        'LevKommentsTB.Text = nullhantering(DataGridView3.Item(4, r4).Value, "S")
        Sok3TB.Visible = False
    End Sub
End Class