Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Net.Mime.MediaTypeNames
Imports System.Net.Security
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TestregPerProduktF
    Dim dbkontonr As String = ""
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet, r As Integer, c As Integer, utskrifttyp As String
    Dim ds2 As New DataSet
    Dim builder As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter)
    Dim pagenr As Integer, engang As Integer
    Dim dummy As Integer

    Private Sub TestregPerProduktF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Testregister per produkt"
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsource.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + databasnamn
        Gnamn.Text = Firmanamn
        HamptaStdTester()
        nolla()


        DataGridView2.DataSource = CreateDataSet2.Tables(0).DefaultView

        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.RowHeadersWidth = 15
        DataGridView1.Columns(0).Width = 0
        DataGridView1.Columns(1).Width = 110
        DataGridView1.Columns("Enhet").Width = 50
        DataGridView1.Columns(2).Width = 0
        'DataGridView1.Columns(3).Width = 80
        'DataGridView1.Columns(3).HeaderText = "Metod"
        DataGridView1.Columns(4).Width = 120
        DataGridView1.Columns(6).HeaderText = "Maxvärde"
        DataGridView1.Columns(7).HeaderText = "Minvärde"
        DataGridView1.Columns("Annaninfo").Width = 280
        AvslutaK.Select()
    End Sub

    Function CreateDataSet2() As DataSet

        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "Select ProduktID  FROM LabprodukterNya "

        strSQL = strSQL + " ORDER BY ProduktId"

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


    Private Function GetLabtesterByProvnamn(provnamn As String) As DataTable
        Dim connectionString As String =
        "DSN=" & odbcsourcer &
        ";Database=" & Labdatabasnamn &
        ";Uid=v2000;Pwd=" & odbclosen

        Dim results As New DataTable()

        Using conn As New OdbcConnection(connectionString)
            Using cmd As New OdbcCommand(
            "Select * FROM Labtester WHERE Provnamn = ?", conn)

                cmd.Parameters.Add("Provnamn", OdbcType.NVarChar).Value = provnamn

                Using adapter As New OdbcDataAdapter(cmd)
                    adapter.Fill(results)
                End Using
            End Using
        End Using

        Return results
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub RaderaB_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Huvud_Click(sender As Object, e As EventArgs) Handles Huvud.Click

    End Sub
    Sub gettester()
        Dim results As DataTable = GetLabtesterByProvnamn(TestnamnCB.Text)
        Dim tolerans As String, Stdvarde2 As String, text As String, info As String

        If results.Rows.Count > 0 Then
            Stdvarde2 = results.Rows(0)("Stdvarde2").ToString()
            tolerans = results.Rows(0)("Tolerans").ToString()
            text = results.Rows(0)("text").ToString()
            info = results.Rows(0)("info").ToString()

        Else
            text = ""
            info = ""
            tolerans = ""
            Stdvarde2 = ""
        End If
    End Sub
    Private Sub KundDokB_Click(sender As Object, e As EventArgs)
        'Dim fd As OpenFileDialog = New OpenFileDialog()
        'Dim strFileName As String = ""
        'fd.Title = "Open File Dialog"
        'fd.InitialDirectory = labmap

        ''checkfor files
        'fd.Filter = "All files (*.pdf)|*.pdf|All files (*.pdf)|*.pdf"
        'fd.FilterIndex = 2
        'fd.RestoreDirectory = True

        'If fd.ShowDialog() = DialogResult.OK Then
        '    strFileName = fd.FileName
        '    strFileName = Strings.Right(strFileName, Len(strFileName) - 15)
        '    strFileName = Strings.Left(strFileName, Len(strFileName) - 4)
        '    InfoTB.Text = strFileName
        '    ' System.Diagnostics.Process.Start(strFileName)
        'End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextTB_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HanteraViscCB_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Function CreateDataSet() As DataSet

        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "Select * FROM LabtesterPerProdukt "
        strSQL = strSQL + "Where ProduktID = '" + ProduktIDL.Text + "' "
        strSQL = strSQL + "  order by ProduktID,Provnamn"

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
    Sub HamptaStdTester()
        TestnamnCB.Items.Clear()
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, l As Integer
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM LabtestRegNy"

        mySQL = mySQL + " order by Provnamn"

        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteNonQuery()
        l = 1
        If tabel.HasRows = False Then
            GoTo slut
        Else
            While tabel.Read()


                TestnamnCB.Items.Add(nullhantering(tabel("Provnamn"), "S"))
                l = l + 1
            End While

        End If
slut:
        cn.Close()
    End Sub
    Function GetStdTester(testnamn As String)
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, l As Integer
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM LabtestRegNy"
        mySQL = mySQL + " where provnamn = '" + testnamn + "' "
        mySQL = mySQL + " order by Provnamn"

        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteNonQuery()
        l = 1
        If tabel.HasRows = False Then
            GoTo slut
        Else
            While tabel.Read()
                MetodTB.Text = (nullhantering(tabel("Metod"), "S"))
                MaxvärdeTB.Text = (nullhantering(tabel("Maxvarde"), "S"))
                MinvärdeTB.Text = (nullhantering(tabel("Minvarde"), "S"))
                EnhetTB.Text = (nullhantering(tabel("Enhet"), "S"))
                AnnanInfoTB.Text = (nullhantering(tabel("AnnanInfo"), "S"))
                l = l + 1
            End While

        End If
slut:
        cn.Close()
    End Function

    Private Sub InfogaB_Click(sender As Object, e As EventArgs) Handles InfogaB.Click
        If ProduktIDL.Text = "Välj produkt" Then
            MessageBox.Show("Välj produkt!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim results As DataTable = GetLabtesterByProvnamn(TestnamnCB.Text)
        Dim tolerans As String, Stdvarde2 As String, text As String, info As String

        If results.Rows.Count > 0 Then
            Stdvarde2 = results.Rows(0)("Stdvarde2").ToString()
            tolerans = results.Rows(0)("Tolerans").ToString()
            text = results.Rows(0)("text").ToString()
            info = results.Rows(0)("info").ToString()

        Else
            text = ""
            info = ""
            tolerans = ""
            Stdvarde2 = ""
        End If

        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM LabTesterPerProdukt "
        mySQL = mySQL + " Where ProvNamn= '" + TestnamnCB.Text + "' "
        mySQL = mySQL + "And ProduktID= '" + ProduktIDL.Text + "' "


        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  LabTesterPerProdukt "
        falt = falt + "Timestamp,"
        varden = varden + "'" + gettimestamp() + "',"
        falt = falt + "ProduktID,"
        varden = varden + "'" + kommatillpunkt(ProduktIDL.Text) + "',"
        falt = falt + "ProvNamn, "
        varden = varden + "'" + kommatillpunkt(TestnamnCB.Text) + "', "
        falt = falt + "Metod, "
        varden = varden + "'" + kommatillpunkt(MetodTB.Text) + "', "
        falt = falt + "Maxvärde,"
        varden = varden + "'" + kommatillpunkt(MaxvärdeTB.Text) + "', "
        falt = falt + "Enhet,"
        varden = varden + "'" + kommatillpunkt(EnhetTB.Text) + "', "
        falt = falt + "Minvärde, "
        varden = varden + "'" + kommatillpunkt(MinvärdeTB.Text) + "', "
        falt = falt + "Annaninfo "
        varden = varden + "'" + kommatillpunkt(AnnanInfoTB.Text) + "' "

        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()

        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
    End Sub

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub

    Private Sub ProduktIDL_Click(sender As Object, e As EventArgs) Handles ProduktIDL.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub SparaB_Click(sender As Object, e As EventArgs) Handles SparaB.Click
        Dim changes As DataSet
        changes = ds.GetChanges()
        If changes IsNot Nothing Then
            dtAdapter.Update(ds.Tables(0))
        End If
        ds.AcceptChanges()
    End Sub

    Private Sub KlientIdl_Click(sender As Object, e As EventArgs) Handles KlientIdl.Click
        MessageBox.Show("TestRegPerProdukt.vb")

    End Sub

    Private Sub KlientIdTB_TextChanged(sender As Object, e As EventArgs) Handles MetodTB.TextChanged

    End Sub

    Private Sub TestnamnCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TestnamnCB.SelectedIndexChanged
        GetStdTester(TestnamnCB.Text)
    End Sub



    Private Sub SparaSTDTestB_Click(sender As Object, e As EventArgs) Handles SparaSTDTestB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM LabTestRegNy "
        mySQL = mySQL + " Where ProvNamn= '" + TestnamnCB.Text + "' "



        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  LabTestRegNy "

        falt = falt + "ProvNamn, "
        varden = varden + "'" + kommatillpunkt(TestnamnCB.Text) + "', "
        falt = falt + "Metod, "
        varden = varden + "'" + kommatillpunkt(MetodTB.Text) + "', "
        falt = falt + "Maxvarde,"
        varden = varden + "'" + kommatillpunkt(MaxvärdeTB.Text) + "', "
        falt = falt + "Enhet,"
        varden = varden + "'" + kommatillpunkt(EnhetTB.Text) + "', "
        falt = falt + "Minvarde
, "
        varden = varden + "'" + kommatillpunkt(MinvärdeTB.Text) + "', "
        falt = falt + "Annaninfo "
        varden = varden + "'" + kommatillpunkt(AnnanInfoTB.Text) + "' "

        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()
        HamptaStdTester()
    End Sub

    Private Sub AddProduktB_Click(sender As Object, e As EventArgs) Handles AddProduktB.Click
        If Len(ProduktIDTB.Text) < 2 Then
            MessageBox.Show("Skriv ProduktID i rutan under knappen", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If



        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM LabprodukterNya "
        mySQL = mySQL + " Where ProduktID = '" + TestnamnCB.Text + "' "



        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  LabprodukterNya  "

        falt = falt + "ProduktID  "
        varden = varden + "'" + kommatillpunkt(ProduktIDTB.Text) + "'  "
        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()

        DataGridView2.DataSource.Table.Rows.Clear()
        DataGridView2.DataSource = CreateDataSet2.Tables(0).DefaultView
    End Sub

    Private Sub RaderafranSTDtestB_Click(sender As Object, e As EventArgs) Handles RaderafranSTDtestB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM LabTestRegNy "
        mySQL = mySQL + " Where ProvNamn= '" + TestnamnCB.Text + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()
        nolla()
        HamptaStdTester()
    End Sub

    Private Sub RaderaProduktB_Click(sender As Object, e As EventArgs) Handles RaderaProduktB.Click
        If Len(ProduktIDTB.Text) < 2 Then
            MessageBox.Show("Skriv ProduktID i rutan under knappen", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If



        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM LabprodukterNya "
        mySQL = mySQL + " Where ProduktID = '" + ProduktIDTB.Text + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()
        DataGridView2.DataSource.Table.Rows.Clear()
        DataGridView2.DataSource = CreateDataSet2.Tables(0).DefaultView
        'CreateDataSet()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim r2 As Integer, c2 As Integer
        r2 = Me.DataGridView1.CurrentRow.Index
        c2 = DataGridView1.CurrentCell.ColumnIndex
        TestnamnCB.Text = nullhantering(DataGridView1.Item(1, r2).Value, "S")
        MetodTB.Text = nullhantering(DataGridView1.Item(4, r2).Value, "S")
        EnhetTB.Text = nullhantering(DataGridView1.Item(5, r2).Value, "S")
        MaxvärdeTB.Text = nullhantering(DataGridView1.Item(7, r2).Value, "S")
        MinvärdeTB.Text = nullhantering(DataGridView1.Item(6, r2).Value, "S")

        AnnanInfoTB.Text = nullhantering(DataGridView1.Item(8, r2).Value, "S")
    End Sub

    Private Sub TabortB_Click(sender As Object, e As EventArgs) Handles TabortB.Click
        If MessageBox.Show("Bekräfta en bort tagning?", "Bekräfta",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) = DialogResult.Yes Then


            Dim cn As OdbcConnection, mySQL As String
            Dim connStr As String 
            connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM LabTesterPerProdukt "
            mySQL = mySQL + " Where ProvNamn= '" + TestnamnCB.Text + "' "
            mySQL = mySQL + "And ProduktID= '" + ProduktIDL.Text + "' "


            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()
            cn.Close()

            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        Else
            Exit Sub
        End If
    End Sub

    Function CountCharacter(value As String, ch As String) As Integer

        CountCharacter = 0

        While InStr(value, ch) > 0
            value = Strings.Right(value, (Len(value) - InStr(value, ch)))
            CountCharacter = CountCharacter + 1

        End While

    End Function







    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim r2 As Integer, c2 As Integer
        ' nolla()
        r2 = Me.DataGridView2.CurrentRow.Index
        c2 = DataGridView2.CurrentCell.ColumnIndex
        ProduktIDL.Text = nullhantering(DataGridView2.Item(0, r2).Value, "S")
        'DataGridView1.DataSource.Table.Rows.Clear()

        nolla()
        'DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
    End Sub
    Sub nolla()
        TestnamnCB.Text = "Välj test"
        EnhetTB.Text = ""
        MetodTB.Text = ""
        MaxvärdeTB.Text = ""
        MinvärdeTB.Text = ""
        AnnanInfoTB.Text = ""


        If DataGridView1.DataSource IsNot Nothing Then
            DataGridView1.DataSource.Table.Rows.Clear()
        End If


        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
    End Sub

    Private Sub DataGridView2_CellBorderStyleChanged(sender As Object, e As EventArgs) Handles DataGridView2.CellBorderStyleChanged

    End Sub
End Class