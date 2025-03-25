Imports System.Data.Common
Imports System.Data.Odbc

Public Class ProdregF
    Dim dbkontonr As String = ""
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet, r As Integer, c As Integer, utskrifttyp As String
    Dim builder As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter)

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Dim pagenr As Integer, engang As Integer

    Private Sub RaderaB_Click(sender As Object, e As EventArgs) Handles RaderaB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim response
        response = MsgBox("Vill du verkligen radera produkten", 1, "OBS")
        If response = 1 Then    ' User chose Yes.
            connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM Labprodukter "
            mySQL = mySQL + " Where ProduktKod = '" + ProduktIDTB.Text + "' "

            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()
            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
            nolla()
        Else
        End If

    End Sub

    Private Sub SparaB_Click(sender As Object, e As EventArgs) Handles SparaB.Click

        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM Labprodukter "
        mySQL = mySQL + " Where ProduktKod= '" + ProduktIDTB.Text + "' "

        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  LabProdukter "
        falt = falt + "ProduktKod,"
        varden = varden + "'" + kommatillpunkt(ProduktIDTB.Text) + "',"
        falt = falt + "ProduktNamn,"
        varden = varden + "'" + kommatillpunkt(ProduktnamnTB.Text) + "',"
        falt = falt + "Komments,"
        varden = varden + "'" + kommatillpunkt(KommentsTB.Text) + "',"

        falt = falt + "ProduktStatus, "
        varden = varden + "'" + kommatillpunkt(StatusTB.Text) + "', "

        falt = falt + "Test1, "
        varden = varden + "'" + kommatillpunkt(Test1CB.Text) + "', "
        falt = falt + "Test2, "
        varden = varden + "'" + kommatillpunkt(Test2CB.Text) + "', "
        falt = falt + "Test3, "
        varden = varden + "'" + kommatillpunkt(Test3CB.Text) + "', "
        falt = falt + "Test4, "
        varden = varden + "'" + kommatillpunkt(Test4CB.Text) + "', "
        falt = falt + "Test5, "
        varden = varden + "'" + kommatillpunkt(Test5CB.Text) + "', "
        falt = falt + "Test6, "
        varden = varden + "'" + kommatillpunkt(Test6CB.Text) + "', "
        falt = falt + "Test7, "
        varden = varden + "'" + kommatillpunkt(Test7CB.Text) + "', "
        falt = falt + "Test8,"
        varden = varden + "'" + kommatillpunkt(Test8CB.Text) + "', "

        falt = falt + "Test1MaxMin,"
        varden = varden + "'" + kommatillpunkt(Test1MinMaxTB.Text) + "', "
        falt = falt + "Test2MaxMin,"
        varden = varden + "'" + kommatillpunkt(Test2MinMaxTB.Text) + "', "
        falt = falt + "Test3MaxMin,"
        varden = varden + "'" + kommatillpunkt(Test3MinMaxTB.Text) + "', "
        falt = falt + "Test4MaxMin,"
        varden = varden + "'" + kommatillpunkt(Test4MinMaxTB.Text) + "', "
        falt = falt + "Test5MaxMin,"
        varden = varden + "'" + kommatillpunkt(Test5MinMaxTB.Text) + "', "
        falt = falt + "Test6MaxMin,"
        varden = varden + "'" + kommatillpunkt(Test6MinMaxTB.Text) + "', "
        falt = falt + "Test7MaxMin,"
        varden = varden + "'" + kommatillpunkt(Test7MinMaxTB.Text) + "', "
        falt = falt + "Test8MaxMin "
        varden = varden + "'" + kommatillpunkt(Test8MinMaxTB.Text) + "'  "

        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()

        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        LabHanteringF.Close()
        LabHanteringF.Show()
    End Sub

    Private Sub ProduktIDTB_TextChanged(sender As Object, e As EventArgs) Handles ProduktIDTB.TextChanged

    End Sub

    Private Sub ProdregF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - NM Produkter "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsource.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + Labdatabasnamn
        Gnamn.Text = Firmanamn

        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 0
        DataGridView1.Columns(2).Width = 0


        HamptaProvNamn()

        AvslutaK.Select()
    End Sub

    Private Sub Test1CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Test1CB.SelectedIndexChanged
        If Len(Test1CB.Text) > 1 Then
            Test1MinMaxTB.Visible = True
        Else
            Test1MinMaxTB.Visible = False
        End If
    End Sub

    Private Sub Test2CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Test2CB.SelectedIndexChanged
        If Len(Test2CB.Text) > 1 Then
            Test2MinMaxTB.Visible = True
        Else
            Test2MinMaxTB.Visible = False
        End If
    End Sub

    Private Sub Test3CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Test3CB.SelectedIndexChanged
        If Len(Test3CB.Text) > 1 Then
            Test3MinMaxTB.Visible = True
        Else
            Test3MinMaxTB.Visible = False
        End If
    End Sub

    Private Sub Test4CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Test4CB.SelectedIndexChanged
        If Len(Test4CB.Text) > 1 Then
            Test4MinMaxTB.Visible = True
        Else
            Test4MinMaxTB.Visible = False
        End If
    End Sub

    Private Sub Test5CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Test5CB.SelectedIndexChanged
        If Len(Test5CB.Text) > 1 Then
            Test5MinMaxTB.Visible = True
        Else
            Test5MinMaxTB.Visible = False
        End If
    End Sub

    Private Sub Test6CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Test6CB.SelectedIndexChanged
        If Len(Test6CB.Text) > 1 Then
            Test6MinMaxTB.Visible = True
        Else
            Test6MinMaxTB.Visible = False
        End If
    End Sub

    Private Sub Test7CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Test7CB.SelectedIndexChanged
        If Len(Test7CB.Text) > 1 Then
            Test7MinMaxTB.Visible = True
        Else
            Test7MinMaxTB.Visible = False
        End If
    End Sub

    Private Sub Test8CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Test8CB.SelectedIndexChanged
        If Len(Test8CB.Text) > 1 Then
            Test8MinMaxTB.Visible = True
        Else
            Test8MinMaxTB.Visible = False
        End If
    End Sub

    Function CreateDataSet() As DataSet

        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "SELECT * FROM Labprodukter "
        strSQL = strSQL + "  order by Produktnamn"

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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim r2 As Integer, c2 As Integer
        r2 = Me.DataGridView1.CurrentRow.Index
        c2 = DataGridView1.CurrentCell.ColumnIndex
        ProduktIDTB.Text = nullhantering(DataGridView1.Item(0, r2).Value, "S")
        ProduktnamnTB.Text = nullhantering(DataGridView1.Item(1, r2).Value, "S")
        StatusTB.Text = nullhantering(DataGridView1.Item(2, r2).Value, "S")
        KommentsTB.Text = nullhantering(DataGridView1.Item(3, r2).Value, "S")
        Test1CB.Text = nullhantering(DataGridView1.Item(4, r2).Value, "S")
        Test2CB.Text = nullhantering(DataGridView1.Item(5, r2).Value, "S")
        Test3CB.Text = nullhantering(DataGridView1.Item(6, r2).Value, "S")
        Test4CB.Text = nullhantering(DataGridView1.Item(7, r2).Value, "S")
        Test5CB.Text = nullhantering(DataGridView1.Item(8, r2).Value, "S")
        Test6CB.Text = nullhantering(DataGridView1.Item(9, r2).Value, "S")
        Test7CB.Text = nullhantering(DataGridView1.Item(10, r2).Value, "S")
        Test8CB.Text = nullhantering(DataGridView1.Item(11, r2).Value, "S")
        If Len(Test1CB.Text) > 1 Then
            Test1MinMaxTB.Visible = True
            Test1MinMaxTB.Text = nullhantering(DataGridView1.Item(12, r2).Value, "S")
        Else
            Test1MinMaxTB.Visible = False
        End If
        If Len(Test2CB.Text) > 1 Then
            Test2MinMaxTB.Visible = True
            Test2MinMaxTB.Text = nullhantering(DataGridView1.Item(13, r2).Value, "S")
        Else
            Test2MinMaxTB.Visible = False
        End If
        If Len(Test3CB.Text) > 1 Then
            Test3MinMaxTB.Visible = True
            Test3MinMaxTB.Text = nullhantering(DataGridView1.Item(14, r2).Value, "S")
        Else
            Test3MinMaxTB.Visible = False
        End If
        If Len(Test4CB.Text) > 1 Then
            Test4MinMaxTB.Visible = True
            Test4MinMaxTB.Text = nullhantering(DataGridView1.Item(15, r2).Value, "S")
        Else
            Test4MinMaxTB.Visible = False
        End If
        If Len(Test5CB.Text) > 1 Then
            Test5MinMaxTB.Visible = True
            Test5MinMaxTB.Text = nullhantering(DataGridView1.Item(16, r2).Value, "S")
        Else
            Test5MinMaxTB.Visible = False
        End If
        If Len(Test6CB.Text) > 1 Then
            Test6MinMaxTB.Visible = True
            Test6MinMaxTB.Text = nullhantering(DataGridView1.Item(17, r2).Value, "S")
        Else
            Test6MinMaxTB.Visible = False
        End If
        If Len(Test7CB.Text) > 1 Then
            Test7MinMaxTB.Visible = True
            Test7MinMaxTB.Text = nullhantering(DataGridView1.Item(18, r2).Value, "S")
        Else
            Test7MinMaxTB.Visible = False
        End If
        If Len(Test8CB.Text) > 1 Then
            Test8MinMaxTB.Visible = True
            Test8MinMaxTB.Text = nullhantering(DataGridView1.Item(19, r2).Value, "S")
        Else
            Test8MinMaxTB.Visible = False
        End If





        'DataGridView1.Focus()
    End Sub
    Sub nolla()
        ProduktIDTB.Text = ""
        ProduktnamnTB.Text = ""
        StatusTB.Text = ""

    End Sub
    Function HamptaProvNamn()
        Dim cn As OdbcConnection, mySQL As String, dummy As String, dummy2 As String = ""
        Dim connStr As String, l As Integer
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM Labtester"
        mySQL = mySQL + " order by Provnamn"

        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteNonQuery()
        l = 1
        If tabel.HasRows = False Then
            GoTo slut
        Else
            Test1CB.Items.Add(dummy2)
            Test2CB.Items.Add(dummy2)
            Test3CB.Items.Add(dummy2)
            Test4CB.Items.Add(dummy2)
            Test5CB.Items.Add(dummy2)
            Test6CB.Items.Add(dummy2)
            Test7CB.Items.Add(dummy2)
            Test8CB.Items.Add(dummy2)
            While tabel.Read()
                dummy = nullhantering(tabel("Provnamn"), "S")

                Test1CB.Items.Add(dummy)
                Test2CB.Items.Add(dummy)
                Test3CB.Items.Add(dummy)
                Test4CB.Items.Add(dummy)
                Test5CB.Items.Add(dummy)
                Test6CB.Items.Add(dummy)
                Test7CB.Items.Add(dummy)
                Test8CB.Items.Add(dummy)
                l = l + 1
            End While
        End If
slut:
        cn.Close()
    End Function
End Class