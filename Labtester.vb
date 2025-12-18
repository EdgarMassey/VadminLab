Imports System.Data.Odbc
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LabHanteringF
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet, Timestamp As String
    Dim ds2 As New DataSet
    Dim builder As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter)
    Dim Test1 As String, Test2 As String, Test3 As String, Test4 As String
    Dim Test5 As String, Test6 As String, Test7 As String, Test8 As String, Tolerans As String, Info As String
    Dim maxmin1 As String, maxmin2 As String, maxmin3 As String, maxmin4 As String
    Dim maxmin5 As String, maxmin6 As String, maxmin7 As String, maxmin8 As String
    Dim r As Integer, StatusSecondsPassed As Integer = 60
    Dim StatTimestamp As String, StDatum As String
    Dim komments As String, maxmin As String



    Private Sub LabtesterF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)
        Huvud.Text = Prognamn + " - Provhantering "
        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.White
            .ForeColor = Color.Black
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        'inneliggandeprov 
        DataGridView1.RowHeadersWidth = 5
        DataGridView1.Columns(0).Width = 0 ' Timestamp
        DataGridView1.Columns(1).Width = 80 'Datum
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 0
        DataGridView1.Columns(4).Width = 80
        DataGridView1.Columns(2).HeaderText = "Produkt"
        DataGridView1.Columns(4).DisplayIndex = 2
        DataGridView1.Columns(2).DisplayIndex = 4


        DataGridView1.Columns(5).Width = 80
        DataGridView1.Columns(37).DisplayIndex = 5
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        'provsammanställning'
        If Len(DatumTB.Text) < 5 Then
            ProduktIDCB.Enabled = False
        End If
        Label11.Visible = False
        TestTB.Visible = False
        Makegrid(1)
        nolla()
        HamptaProvNamn()
        HamptaproduktID()
        TestnamnTB.Text = "Kulörbestämning"
        StatusTB.Items.Add("Jonny") : StatusTB.Items.Add("Anna") : StatusTB.Items.Add("Lars") : StatusTB.Items.Add("Gunnar") : StatusTB.Items.Add(" ")


        FromDatumTB.Text = CDate(today).AddDays(-90)
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Timer1.Start()
        Timer_Tick()
        AvslutaK.Select()
    End Sub
    Function CreateDataSet() As DataSet

        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "SELECT * FROM Provarkiv "
        strSQL = strSQL + "Where Datum >= '" + FromDatumTB.Text + "' "
        If BatchnrRB.Checked = True Then
            If Len(Sokbegrepp.Text) > 0 Then
                strSQL = strSQL + "And Batchnr = '" + Sokbegrepp.Text + "' "
            End If
        End If
        If ProduktKodRB.Checked = True Then
            If Len(Sokbegrepp.Text) > 0 Then
                strSQL = strSQL + "And ProduktKod = '" + Sokbegrepp.Text + "' "
            End If
        End If
        'If StatusRB.Checked = True Then
        '    If Len(Sokbegrepp.Text) > 0 Then
        '        strSQL = strSQL + "And Status = '" + Sokbegrepp.Text + "' "
        '    End If
        'End If
        If PagoendeCB.Checked = True Then
            strSQL = strSQL + "And ProvStatus = 'Pågående' "
        End If

        strSQL = strSQL + "  order by datum,Mytimestamp"

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

    Private Sub LabprodukterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabprodukterToolStripMenuItem.Click
        ProdregF.Show()
    End Sub

    Private Sub TestRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestRegisterToolStripMenuItem.Click
        TestregF.Show()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim r2 As Integer, c2 As Integer, prov1 As String = "", prov2 As String = ""
        Dim prov3 As String = "", prov4 As String = "", prov5 As String = "", prov6 As String = ""
        Dim prov7 As String = "", prov8 As String = "", varde1 As String = "", varde2 As String = ""
        Dim varde3 As String = "", varde4 As String = "", varde5 As String = "", varde6 As String = ""
        Dim varde7 As String = "", varde8 As String = "", dummy As String
        r2 = Me.DataGridView1.CurrentRow.Index
        c2 = DataGridView1.CurrentCell.ColumnIndex
        nolla()
        Timestamp = nullhantering(DataGridView1.Item(0, r2).Value, "S")
        DatumTB.Text = nullhantering(DataGridView1.Item(1, r2).Value, "S")

        ProduktIDCB.Text = nullhantering(DataGridView1.Item(2, r2).Value, "S")

        Getproduktnamn(ProduktIDCB.Text)

        ProduktnamnTB.Text = nullhantering(DataGridView1.Item(3, r2).Value, "S")
        BatchnrTB.Text = nullhantering(DataGridView1.Item(4, r2).Value, "S")
        StatusTB.Text = nullhantering(DataGridView1.Item(37, r2).Value, "S")
        ProvstatusCB.Text = nullhantering(DataGridView1.Item(39, r2).Value, "S")
        ProvSenasteTB.Text = nullhantering(DataGridView1.Item(40, r2).Value, "S")
        KommentsTB.Text = nullhantering(DataGridView1.Item(38, r2).Value, "S")
        prov1 = nullhantering(DataGridView1.Item(5, r2).Value, "S")
        dummy = Getprovtext(prov1)
        If Len(prov1) > 1 Then
            Prov1L.Visible = True
            Prov1L.Text = prov1
            'Prov1L.Refresh()

            ' dummy = Getprovtext(prov1)

            If Len(Tolerans) > 1 Then

                Prov1L.ForeColor = Color.Red
            End If
            If Len(Info) > 1 Then
                Info1L.Visible = True
                Info1L.Text = Info
            Else
                Info1L.Visible = False
            End If
            Provtext1L.Visible = True
            Provtext1L.Text = dummy
            varde1 = nullhantering(DataGridView1.Item(13, r2).Value, "S")
            Varde1TB.Visible = True
            Varde1TB.Text = varde1
            Varde1TB.Refresh()
            MaxMin1L.Visible = True
            MaxMin1L.Text = maxmin1
            If prov1 = "Kulörbestämning" Then
                FKod1CB.Visible = True
                FKod1CB.Text = nullhantering(DataGridView1.Item(29, r2).Value, "S")
                Autojamforelse1()
            End If

            'StatusTB.Text = nullhantering(DataGridView1.Item(21, r2).Value, "S")
        End If
        prov2 = nullhantering(DataGridView1.Item(6, r2).Value, "S")
        If Len(prov2) > 1 Then
            Prov2L.Visible = True
            Prov2L.Text = prov2
            Prov2L.Refresh()
            dummy = Getprovtext(prov2)
            If Len(Tolerans) > 1 Then

                Prov2L.ForeColor = Color.Red
            End If
            If Len(Info) > 1 Then
                Info2l.Visible = True
                Info2l.Text = Info
            Else
                Info2l.Visible = False
            End If
            Provtext2L.Visible = True
            Provtext2L.Text = dummy
            varde2 = nullhantering(DataGridView1.Item(14, r2).Value, "S")
            Varde2TB.Visible = True
            Varde2TB.Text = varde2
            Varde2TB.Refresh()
            Maxmin2l.Visible = True
            Maxmin2l.Text = maxmin2
            If prov2 = "Kulörbestämning" Then
                FKod2CB.Visible = True
                FKod2CB.Text = nullhantering(DataGridView1.Item(30, r2).Value, "S")
                Autojamforelse2()
            End If



            prov3 = nullhantering(DataGridView1.Item(7, r2).Value, "S")
            If Len(prov3) > 1 Then
                Prov3L.Visible = True
                Prov3L.Text = prov3
                Prov3L.Refresh()
                dummy = Getprovtext(Prov3L.Text)
                If Len(Tolerans) > 1 Then
                    Prov3L.ForeColor = Color.Red


                End If
                If Len(Info) > 1 Then
                    Info3L.Visible = True
                    Info3L.Text = Info
                Else
                    Info3L.Visible = False
                End If
                Provtext3L.Visible = True
                Provtext3L.Text = dummy
                varde3 = nullhantering(DataGridView1.Item(15, r2).Value, "S")
                Varde3TB.Visible = True
                Varde3TB.Text = varde3
                Varde3TB.Refresh()
                Maxmin3l.Visible = True
                Maxmin3l.Text = maxmin3
                If prov3 = "Kulörbestämning" Then
                    FKod3CB.Visible = True
                    FKod3CB.Text = nullhantering(DataGridView1.Item(31, r2).Value, "S")
                    Autojamforelse3()
                End If

            End If
        End If

        prov4 = nullhantering(DataGridView1.Item(8, r2).Value, "S")
        If Len(prov4) > 1 Then
            Prov4L.Visible = True
            Prov4L.Text = prov4
            Prov4L.Refresh()
            dummy = Getprovtext(Prov4L.Text)
            If Len(Tolerans) > 1 Then
                Prov4L.ForeColor = Color.Red

            End If
            If Len(Info) > 1 Then
                Info4L.Visible = True
                Info4L.Text = Info
            Else
                Info4L.Visible = False
            End If

            Provtext4L.Visible = True
            Provtext4L.Text = dummy
            varde4 = nullhantering(DataGridView1.Item(16, r2).Value, "S")
            Varde4TB.Visible = True
            Varde4TB.Text = varde4
            Varde4TB.Refresh()
            Maxmin4l.Visible = True
            Maxmin4l.Text = maxmin4
            If prov4 = "Kulörbestämning" Then
                FKod4CB.Visible = True
                FKod4CB.Text = nullhantering(DataGridView1.Item(32, r2).Value, "S")
            End If

        End If

        prov5 = nullhantering(DataGridView1.Item(9, r2).Value, "S")
        If Len(prov5) > 1 Then
            Prov5L.Visible = True
            Prov5L.Text = prov5
            Prov5L.Refresh()
            dummy = Getprovtext(Prov5L.Text)
            If Len(Tolerans) > 1 Then
                Prov5L.ForeColor = Color.Red

            End If
            If Len(Info) > 1 Then
                Info5L.Visible = True
                Info5L.Text = Info
            Else
                Info5L.Visible = False
            End If

            Provtext5L.Visible = True
            Provtext5L.Text = dummy
            varde5 = nullhantering(DataGridView1.Item(17, r2).Value, "S")
            Varde5TB.Visible = True
            Varde5TB.Text = varde5
            Varde5TB.Refresh()
            Maxmin5l.Visible = True
            Maxmin5l.Text = maxmin5
            If prov5 = "Kulörbestämning" Then
                FKod5CB.Visible = True
                FKod5CB.Text = nullhantering(DataGridView1.Item(33, r2).Value, "S")
            End If

        End If
        prov6 = nullhantering(DataGridView1.Item(10, r2).Value, "S")
        If Len(prov6) > 1 Then
            Prov6L.Visible = True
            Prov6L.Text = prov6
            Prov6L.Refresh()
            dummy = Getprovtext(Prov6L.Text)

            If Len(Tolerans) > 1 Then
                Prov6L.ForeColor = Color.Red

            End If
            If Len(Info) > 1 Then
                Info6L.Visible = True
                Info6L.Text = Info
            Else
                Info6L.Visible = False
            End If
            Provtext6L.Visible = True
            Provtext6L.Text = dummy
            varde6 = nullhantering(DataGridView1.Item(18, r2).Value, "S")
            Maxmin6l.Visible = True
            Maxmin6l.Text = maxmin6
            Varde6TB.Visible = True
            Varde6TB.Text = varde6
            Varde6TB.Refresh()
            If prov6 = "Kulörbestämning" Then
                FKod6CB.Visible = True
                FKod6CB.Text = nullhantering(DataGridView1.Item(34, r2).Value, "S")
            End If


        End If

        prov7 = nullhantering(DataGridView1.Item(11, r2).Value, "S")
        If Len(prov7) > 1 Then
            Prov7L.Visible = True
            Prov7L.Text = prov7
            Prov7L.Refresh()
            dummy = Getprovtext(Prov7L.Text)
            If Len(Tolerans) > 1 Then
                Prov7L.ForeColor = Color.Red

            End If
            If Len(Info) > 1 Then
                Info7L.Visible = True
                Info7L.Text = Info
            Else
                Info7L.Visible = False
            End If
            Provtext7L.Visible = True
            Provtext7L.Text = dummy
            varde7 = nullhantering(DataGridView1.Item(19, r2).Value, "S")
            Varde7TB.Visible = True
            Varde7TB.Text = varde7
            Varde7TB.Refresh()
            MaxMin7L.Visible = True
            MaxMin7L.Text = maxmin7
            If prov7 = "Kulörbestämning" Then
                FKod7CB.Visible = True
                FKod7CB.Text = nullhantering(DataGridView1.Item(35, r2).Value, "S")
            End If



        End If
        prov8 = nullhantering(DataGridView1.Item(12, r2).Value, "S")

        If Len(prov8) > 1 Then
            Prov8L.Visible = True
            Prov8L.Text = prov8
            Prov8L.Refresh()
            dummy = Getprovtext(Prov8L.Text)
            If Len(Tolerans) > 1 Then
                Prov8L.ForeColor = Color.Red

            End If
            If Len(Info) > 1 Then
                Info8L.Visible = True
                Info8L.Text = Info
            Else
                Info8L.Visible = False
            End If

            Provtext8L.Visible = True
            Provtext8L.Text = dummy
            varde8 = nullhantering(DataGridView1.Item(20, r2).Value, "S")

            Varde8TB.Visible = True
            Varde8TB.Text = varde8
            Varde8TB.Refresh()
            Maxmin8l.Visible = True
            Maxmin8l.Text = maxmin8
            If prov8 = "Kulörbestämning" Then
                FKod8CB.Visible = True
                FKod8CB.Text = nullhantering(DataGridView1.Item(36, r2).Value, "S")
            End If


        End If



        ErsattaB.Visible = True
        'DataGridView1.Focus()
    End Sub
    Sub nolla()
        maxmin = ""
        nollaenhethojd()
        Prov1L.ForeColor = Color.Maroon
        Prov2L.ForeColor = Color.Maroon
        Prov3L.ForeColor = Color.Maroon
        Prov4L.ForeColor = Color.Maroon
        Prov5L.ForeColor = Color.Maroon
        Prov6L.ForeColor = Color.Maroon
        Prov7L.ForeColor = Color.Maroon
        Prov8L.ForeColor = Color.Maroon
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)

        Timestamp = ""
        DatumTB.Text = ""
        ProduktIDCB.Text = ""
        ProduktnamnTB.Text = ""
        BatchnrTB.Text = ""
        ProvstatusCB.Text = ""
        ProvSenasteTB.Text = ""
        StatusTB.Text = ""
        komments = ""
        KommentsTB.Text = ""

        MaxMin1L.Visible = False : MaxMin1L.Text = "" : maxmin1 = ""
        Maxmin2l.Visible = False : Maxmin2l.Text = "" : maxmin2 = ""
        Maxmin3l.Visible = False : Maxmin3l.Text = "" : maxmin3 = ""
        Maxmin4l.Visible = False : Maxmin4l.Text = "" : maxmin4 = ""
        Maxmin5l.Visible = False : Maxmin5l.Text = "" : maxmin5 = ""
        Maxmin6l.Visible = False : Maxmin6l.Text = "" : maxmin6 = ""
        MaxMin7L.Visible = False : MaxMin7L.Text = "" : maxmin7 = ""
        Maxmin8l.Visible = False : Maxmin8l.Text = "" : maxmin8 = ""

        Prov1L.Visible = False : Prov1L.Text = ""
        Prov2L.Visible = False : Prov2L.Text = ""
        Prov3L.Visible = False : Prov3L.Text = ""
        Prov4L.Visible = False : Prov4L.Text = ""
        Prov5L.Visible = False : Prov5L.Text = ""
        Prov6L.Visible = False : Prov6L.Text = ""
        Prov7L.Visible = False : Prov7L.Text = ""
        Prov8L.Visible = False : Prov8L.Text = ""
        Varde1TB.Visible = False : Varde1TB.Text = ""
        Varde2TB.Visible = False : Varde2TB.Text = ""
        Varde3TB.Visible = False : Varde3TB.Text = ""
        Varde4TB.Visible = False : Varde4TB.Text = ""
        Varde5TB.Visible = False : Varde5TB.Text = ""
        Varde6TB.Visible = False : Varde6TB.Text = ""
        Varde7TB.Visible = False : Varde7TB.Text = ""
        Varde8TB.Visible = False : Varde8TB.Text = ""
        Provtext1L.Visible = False : Provtext1L.Text = ""
        Provtext2L.Visible = False : Provtext2L.Text = ""
        Provtext3L.Visible = False : Provtext3L.Text = ""
        Provtext4L.Visible = False : Provtext4L.Text = ""
        Provtext5L.Visible = False : Provtext5L.Text = ""
        Provtext6L.Visible = False : Provtext6L.Text = ""
        Provtext7L.Visible = False : Provtext7L.Text = ""
        Provtext8L.Visible = False : Provtext8L.Text = ""
        FKod1CB.Visible = False : FKod1CB.Text = ""
        FKod2CB.Visible = False : FKod2CB.Text = ""
        FKod3CB.Visible = False : FKod3CB.Text = ""
        FKod4CB.Visible = False : FKod4CB.Text = ""
        FKod5CB.Visible = False : FKod5CB.Text = ""
        FKod6CB.Visible = False : FKod6CB.Text = ""
        FKod7CB.Visible = False : FKod7CB.Text = ""
        FKod8CB.Visible = False : FKod8CB.Text = ""


        Info1L.Visible = False : Info1L.Text = ""
        Info2l.Visible = False : Info2l.Text = ""
        Info3L.Visible = False : Info3L.Text = ""
        Info4L.Visible = False : Info4L.Text = ""
        Info5L.Visible = False : Info5L.Text = ""
        Info6L.Visible = False : Info6L.Text = ""
        Info7L.Visible = False : Info7L.Text = ""
        Info8L.Visible = False : Info8L.Text = ""

        Prov1L.DropDownStyle = ComboBoxStyle.Simple
        Prov2L.DropDownStyle = ComboBoxStyle.Simple
        Prov3L.DropDownStyle = ComboBoxStyle.Simple
        Prov4L.DropDownStyle = ComboBoxStyle.Simple
        Prov5L.DropDownStyle = ComboBoxStyle.Simple
        Prov6L.DropDownStyle = ComboBoxStyle.Simple
        Prov7L.DropDownStyle = ComboBoxStyle.Simple
        Prov8L.DropDownStyle = ComboBoxStyle.Simple
        Jam1B.Visible = False
        Jam2B.Visible = False
        Jam3B.Visible = False
        Jam4B.Visible = False
        Jam5B.Visible = False
        Jam6B.Visible = False
        Jam7B.Visible = False
        Jam8B.Visible = False
        KommentsTB.Text = ""
        Timestamp = ""
        ErsattaB.Visible = False
        SparaB.Visible = False
    End Sub

    Private Sub NollaB_Click(sender As Object, e As EventArgs) Handles NollaB.Click

        nolla()
        ProduktIDCB.Enabled = False
    End Sub

    Private Sub SparaB_Click(sender As Object, e As EventArgs) Handles SparaB.Click

        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        'mySQL = "DELETE FROM ProvArkiv "
        'mySQL = mySQL + " Where Testnamn = '" + TestNamnTB.Text + "' "

        Dim myCmd As New OdbcCommand(mySQL, cn)
        'myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  Provarkiv "
        falt = falt + "MyTimeStamp,"
        Timestamp = gettimestamp()
        varden = varden + "'" + Timestamp + "',"
        falt = falt + "Datum,"
        varden = varden + "'" + kommatillpunkt(DatumTB.Text) + "',"
        falt = falt + "ProduktKod,"
        varden = varden + "'" + kommatillpunkt(ProduktIDCB.Text) + "',"
        falt = falt + "Produktnamn,"
        varden = varden + "'" + kommatillpunkt(ProduktnamnTB.Text) + "',"
        falt = falt + "BatchNr,"
        varden = varden + "'" + kommatillpunkt(BatchnrTB.Text) + "',"
        falt = falt + "Prov1,"
        varden = varden + "'" + kommatillpunkt(Prov1L.Text) + "',"
        falt = falt + "Prov2,"
        varden = varden + "'" + kommatillpunkt(Prov2L.Text) + "',"
        falt = falt + "Prov3,"
        varden = varden + "'" + kommatillpunkt(Prov3L.Text) + "',"
        falt = falt + "Prov4,"
        varden = varden + "'" + kommatillpunkt(Prov4L.Text) + "',"
        falt = falt + "Prov5,"
        varden = varden + "'" + kommatillpunkt(Prov5L.Text) + "',"
        falt = falt + "Prov6,"
        varden = varden + "'" + kommatillpunkt(Prov6L.Text) + "',"
        falt = falt + "Prov7,"
        varden = varden + "'" + kommatillpunkt(Prov7L.Text) + "',"
        falt = falt + "Prov8,"
        varden = varden + "'" + kommatillpunkt(Prov8L.Text) + "',"
        falt = falt + "Resultat1,"
        varden = varden + "'" + kommatillpunkt(Varde1TB.Text) + "',"
        falt = falt + "Resultat2,"
        varden = varden + "'" + kommatillpunkt(Varde2TB.Text) + "',"
        falt = falt + "Resultat3,"
        varden = varden + "'" + kommatillpunkt(Varde3TB.Text) + "',"
        falt = falt + "Resultat4,"
        varden = varden + "'" + kommatillpunkt(Varde4TB.Text) + "',"
        falt = falt + "Resultat5,"
        varden = varden + "'" + kommatillpunkt(Varde5TB.Text) + "',"
        falt = falt + "Resultat6,"
        varden = varden + "'" + kommatillpunkt(Varde6TB.Text) + "',"
        falt = falt + "Resultat7,"
        varden = varden + "'" + kommatillpunkt(Varde7TB.Text) + "',"
        falt = falt + "Resultat8,"
        varden = varden + "'" + kommatillpunkt(Varde8TB.Text) + "',"
        falt = falt + "Fkod1,"
        varden = varden + "'" + kommatillpunkt(FKod1CB.Text) + "',"
        falt = falt + "Fkod2,"
        varden = varden + "'" + kommatillpunkt(FKod2CB.Text) + "',"
        falt = falt + "Fkod3,"
        varden = varden + "'" + kommatillpunkt(FKod3CB.Text) + "',"
        falt = falt + "Fkod4,"
        varden = varden + "'" + kommatillpunkt(FKod4CB.Text) + "',"
        falt = falt + "Fkod5,"
        varden = varden + "'" + kommatillpunkt(FKod5CB.Text) + "',"
        falt = falt + "Fkod6,"
        varden = varden + "'" + kommatillpunkt(FKod6CB.Text) + "',"
        falt = falt + "Fkod7,"
        varden = varden + "'" + kommatillpunkt(FKod7CB.Text) + "',"
        falt = falt + "Fkod8,"
        varden = varden + "'" + kommatillpunkt(FKod8CB.Text) + "',"


        falt = falt + "Status,"
        varden = varden + "'" + kommatillpunkt(StatusTB.Text) + "',"
        falt = falt + "ProvStatus,"
        varden = varden + "'" + kommatillpunkt(ProvstatusCB.Text) + "',"
        falt = falt + "ProvSenaste,"
        varden = varden + "'" + kommatillpunkt(today) + "',"

        falt = falt + "Komment"
        varden = varden + "'" + kommatillpunkt(KommentsTB.Text) + "' "
        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()

        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        SparaB.Visible = False
        'DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        SparaB.Visible = False
        ErsattaB.Visible = True
        'nolla()

    End Sub
    Function Getprovtext(provnamn)
        Dim cn2 As OdbcConnection, mySQL2 As String
        Dim connStr2 As String, utpris(10) As Double
        Dim myCmd2 As OdbcCommand
        Dim tabel2 As OdbcDataReader
        Tolerans = "" : Info = ""

        connStr2 = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn2 = New OdbcConnection(connStr2)
        cn2.Open()
        mySQL2 = "SELECT Text,Tolerans,Info,stdvarde2,TestBildID FROM LabTester"
        mySQL2 = mySQL2 + " WHERE ProvNamn = '" + provnamn + "' "

        myCmd2 = New OdbcCommand(mySQL2, cn2)
        tabel2 = myCmd2.ExecuteReader(CommandBehavior.CloseConnection)

        tabel2.Read()

        If tabel2.HasRows = False Then
            Getprovtext = ""
        Else
            Getprovtext = nullhantering(tabel2("Text"), "S")
            Tolerans = nullhantering(tabel2("Tolerans"), "S")
            Info = nullhantering(tabel2("Info"), "S")
            maxmin = nullhantering(tabel2("stdvarde2"), "S")
            colorprov = nullhantering(tabel2("TestBildID"), "S")

        End If
        cn2.Close()
    End Function

    Function HamptaProvNamn()
        Dim cn As OdbcConnection, mySQL As String, dummy As String, dummy2 As String = ""
        Dim connStr As String, l As Integer
        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
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
            Prov1L.Items.Add(dummy2)
            Prov2L.Items.Add(dummy2)
            Prov3L.Items.Add(dummy2)
            Prov4L.Items.Add(dummy2)
            Prov5L.Items.Add(dummy2)
            Prov6L.Items.Add(dummy2)
            Prov7L.Items.Add(dummy2)
            Prov8L.Items.Add(dummy2)
            While tabel.Read()
                dummy = nullhantering(tabel("Provnamn"), "S")
                TestnamnTB.Items.Add(dummy)
                Prov1L.Items.Add(dummy)
                Prov2L.Items.Add(dummy)
                Prov3L.Items.Add(dummy)
                Prov4L.Items.Add(dummy)
                Prov5L.Items.Add(dummy)
                Prov6L.Items.Add(dummy)
                Prov7L.Items.Add(dummy)
                Prov8L.Items.Add(dummy)
                l = l + 1
            End While
        End If
slut:
        cn.Close()
    End Function

    Private Sub ProvListaCB_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Function HamptaproduktID()
        Dim cn As OdbcConnection, mySQL As String, dummy As String
        Dim connStr As String, l As Integer
        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM LabProdukter"
        mySQL = mySQL + " order by ProduktKod"

        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteNonQuery()
        l = 1
        If tabel.HasRows = False Then
            GoTo slut
        Else
            While tabel.Read()

                dummy = nullhantering(tabel("Produktkod"), "S")
                ProduktIDCB.Items.Add(dummy)
                l = l + 1
            End While

        End If
slut:
        cn.Close()
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub



    Private Sub ErsattaB_Click(sender As Object, e As EventArgs) Handles ErsattaB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        Dim response
        'response = MsgBox("Vill du verkligen ersätta provet", 1, "OBS")
        'If response = 1 Then    ' User chose Yes.

        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM ProvArkiv "
        mySQL = mySQL + " Where MyTimeStamp = '" + Timestamp + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        falt = "" : varden = ""
        mySQL = "INSERT INTO  Provarkiv "
        falt = falt + "MyTimeStamp,"
        varden = varden + "'" + Timestamp + "',"

        falt = falt + "Datum,"
        varden = varden + "'" + kommatillpunkt(DatumTB.Text) + "',"
        falt = falt + "ProduktKod,"
        varden = varden + "'" + kommatillpunkt(ProduktIDCB.Text) + "',"
        falt = falt + "Produktnamn,"
        varden = varden + "'" + kommatillpunkt(ProduktnamnTB.Text) + "',"
        falt = falt + "BatchNr,"
        varden = varden + "'" + kommatillpunkt(BatchnrTB.Text) + "',"
        falt = falt + "Prov1,"
        varden = varden + "'" + kommatillpunkt(Prov1L.Text) + "',"
        falt = falt + "Prov2,"
        varden = varden + "'" + kommatillpunkt(Prov2L.Text) + "',"
        falt = falt + "Prov3,"
        varden = varden + "'" + kommatillpunkt(Prov3L.Text) + "',"
        falt = falt + "Prov4,"
        varden = varden + "'" + kommatillpunkt(Prov4L.Text) + "',"
        falt = falt + "Prov5,"
        varden = varden + "'" + kommatillpunkt(Prov5L.Text) + "',"
        falt = falt + "Prov6,"
        varden = varden + "'" + kommatillpunkt(Prov6L.Text) + "',"
        falt = falt + "Prov7,"
        varden = varden + "'" + kommatillpunkt(Prov7L.Text) + "',"
        falt = falt + "Prov8,"
        varden = varden + "'" + kommatillpunkt(Prov8L.Text) + "',"
        falt = falt + "Resultat1,"
        varden = varden + "'" + kommatillpunkt(Varde1TB.Text) + "',"
        falt = falt + "Resultat2,"
        varden = varden + "'" + kommatillpunkt(Varde2TB.Text) + "',"
        falt = falt + "Resultat3,"
        varden = varden + "'" + kommatillpunkt(Varde3TB.Text) + "',"
        falt = falt + "Resultat4,"
        varden = varden + "'" + kommatillpunkt(Varde4TB.Text) + "',"
        falt = falt + "Resultat5,"
        varden = varden + "'" + kommatillpunkt(Varde5TB.Text) + "',"
        falt = falt + "Resultat6,"
        varden = varden + "'" + kommatillpunkt(Varde6TB.Text) + "',"
        falt = falt + "Resultat7,"
        varden = varden + "'" + kommatillpunkt(Varde7TB.Text) + "',"
        falt = falt + "Resultat8,"
        varden = varden + "'" + kommatillpunkt(Varde8TB.Text) + "',"
        falt = falt + "Fkod1,"
        varden = varden + "'" + kommatillpunkt(FKod1CB.Text) + "',"
        falt = falt + "Fkod2,"
        varden = varden + "'" + kommatillpunkt(FKod2CB.Text) + "',"
        falt = falt + "Fkod3,"
        varden = varden + "'" + kommatillpunkt(FKod3CB.Text) + "',"
        falt = falt + "Fkod4,"
        varden = varden + "'" + kommatillpunkt(FKod4CB.Text) + "',"
        falt = falt + "Fkod5,"
        varden = varden + "'" + kommatillpunkt(FKod5CB.Text) + "',"
        falt = falt + "Fkod6,"
        varden = varden + "'" + kommatillpunkt(FKod6CB.Text) + "',"
        falt = falt + "Fkod7,"
        varden = varden + "'" + kommatillpunkt(FKod7CB.Text) + "',"
        falt = falt + "Fkod8,"
        varden = varden + "'" + kommatillpunkt(FKod8CB.Text) + "',"



        falt = falt + "Status,"
        varden = varden + "'" + kommatillpunkt(StatusTB.Text) + "',"
        falt = falt + "ProvStatus,"
        varden = varden + "'" + kommatillpunkt(ProvstatusCB.Text) + "',"
        falt = falt + "ProvSenaste,"
        varden = varden + "'" + kommatillpunkt(today) + "',"
        falt = falt + "Komment"
        varden = varden + "'" + kommatillpunkt(KommentsTB.Text) + "' "
        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()


        'Else
        'End If
        'nolla()
        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
    End Sub

    Private Sub Prov1L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Prov1L.SelectedIndexChanged
        Provtext1L.Visible = True
        ' TestKomment1B.Visible = True
        Provtext1L.Text = Getprovtext(Prov1L.Text)
        Provtext1L.Refresh()
        Varde1TB.Visible = True
        Jam1B.Visible = True
        Varde1TB.Text = ""
        Varde1TB.Refresh()
        If Prov1L.Text = "Kulörbestämning" Then
            FKod1CB.Visible = True
        End If
    End Sub
    Private Sub Prov2L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Prov2L.SelectedIndexChanged
        Provtext2L.Visible = True
        ' TestKomment2B.Visible = True
        Provtext2L.Text = Getprovtext(Prov2L.Text)
        Provtext2L.Refresh()
        Varde2TB.Visible = True
        Jam2B.Visible = True
        Varde2TB.Text = ""
        Varde2TB.Refresh()
        If colorprov = "Färg" Then
            FKod2CB.Visible = True
        Else
            FKod2CB.Visible = False
        End If

        If Prov2L.Text = "Kulörbestämning" Then
            FKod2CB.Visible = True

        End If

    End Sub



    Private Sub NP1_Click_1(sender As Object, e As EventArgs) Handles NP1.Click
        Prov1L.Visible = True

    End Sub

    Private Sub RaderaB_Click(sender As Object, e As EventArgs) Handles RaderaB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim response
        response = MsgBox("Vill du verkligen radera", 1, "OBS")
        If response = 1 Then    ' User chose Yes.
            connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM Provarkiv "
            mySQL = mySQL + " Where MyTimeStamp = '" + Timestamp + "' "

            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()
            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
            nolla()
        Else

        End If



    End Sub

    Private Sub ProduktIDCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProduktIDCB.SelectedIndexChanged

        Getproduktnamn(ProduktIDCB.Text)
        ProduktnamnTB.Text = Getproduktnamn(ProduktIDCB.Text)
        If Len(Test1) > 0 Then
            Prov1L.Visible = True
            Prov1L.Text = Test1

            Getprovtext(Test1)
            MaxMin1L.Visible = True
            MaxMin1L.Text = maxmin1
            Info1L.Visible = True
            Info1L.Text = Info

        Else
            Prov1L.Visible = False
            MaxMin1L.Visible = False
            Info1L.Visible = False
        End If
        If Len(Test2) > 0 Then
            Prov2L.Visible = True
            Prov2L.Text = Test2
            Getprovtext(Test2)
            Maxmin2l.Visible = True
            Maxmin2l.Text = maxmin2
            Info2l.Visible = True
            Info2l.Text = Info
        Else
            Prov2L.Visible = False
            Maxmin2l.Visible = False
            Info2l.Visible = False
        End If
        If Len(Test3) > 0 Then
            Prov3L.Visible = True
            Prov3L.Text = Test3
            Getprovtext(Test3)
            Maxmin3l.Visible = True
            Maxmin3l.Text = maxmin3
            Info3L.Visible = True
            Info3L.Text = Info
        Else
            Prov3L.Visible = False
            Maxmin3l.Visible = False
            Info3L.Visible = False
        End If
        If Len(Test4) > 0 Then
            Prov4L.Visible = True
            Prov4L.Text = Test4
            Getprovtext(Test4)
            Maxmin4l.Visible = True
            Maxmin4l.Text = maxmin4
            Info4L.Visible = True
            Info4L.Text = Info
        Else
            Prov4L.Visible = False
            Maxmin4l.Visible = False
            Info4L.Visible = False
        End If
        If Len(Test5) > 0 Then
            Prov5L.Visible = True
            Prov5L.Text = Test5
            Getprovtext(Test5)
            Maxmin5l.Visible = True
            Maxmin5l.Text = maxmin5
            Info5L.Visible = True
            Info5L.Text = Info
        Else
            Prov5L.Visible = False
            Maxmin5l.Visible = False
            Info5L.Visible = False
        End If
        If Len(Test6) > 0 Then
            Prov6L.Visible = True
            Prov6L.Text = Test6
            Getprovtext(Test6)
            Maxmin6l.Visible = True
            Maxmin6l.Text = maxmin6
            Info6L.Visible = True
            Info6L.Text = Info
        Else
            Prov6L.Visible = False
            Maxmin6l.Visible = False
            Info6L.Visible = False
        End If
        If Len(Test7) > 0 Then
            Prov7L.Visible = True
            Prov7L.Text = Test7
            Getprovtext(Test7)
            MaxMin7L.Visible = True
            MaxMin7L.Text = maxmin7
            Info7L.Visible = True
            Info7L.Text = Info
        Else
            Prov7L.Visible = False
            MaxMin7L.Visible = False
            Info7L.Visible = False
        End If
        If Len(Test8) > 0 Then
            Prov8L.Visible = True
            Prov8L.Text = Test8
            Getprovtext(Test8)
            Maxmin8l.Visible = True
            Maxmin8l.Text = maxmin8
            Info8L.Visible = True
            Info8L.Text = Info
        Else
            Prov8L.Visible = False
            Maxmin8l.Visible = False
            Info8L.Visible = False
        End If

        KommentsTB.Text = komments





    End Sub

    Private Sub NP2_Click(sender As Object, e As EventArgs) Handles NP2.Click
        Prov2L.Visible = True
    End Sub

    Private Sub NP3_Click(sender As Object, e As EventArgs) Handles NP3.Click
        Prov3L.Visible = True
    End Sub

    Private Sub NP4_Click(sender As Object, e As EventArgs) Handles NP4.Click
        Prov4L.Visible = True
    End Sub

    Private Sub NP5_Click(sender As Object, e As EventArgs) Handles NP5.Click
        Prov5L.Visible = True
    End Sub

    Private Sub NP6_Click(sender As Object, e As EventArgs) Handles NP6.Click
        Prov6L.Visible = True
    End Sub

    Private Sub NP7_Click(sender As Object, e As EventArgs) Handles NP7.Click
        Prov7L.Visible = True
    End Sub

    Private Sub NP8_Click(sender As Object, e As EventArgs) Handles NP8.Click
        Prov8L.Visible = True
    End Sub

    Private Sub Huvud_Click(sender As Object, e As EventArgs) Handles Huvud.Click
        Info1L.Height = 60

    End Sub

    Private Sub SokB_Click(sender As Object, e As EventArgs) Handles SokB.Click
        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
    End Sub

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub

    Private Sub NyB_Click(sender As Object, e As EventArgs) Handles NyB.Click
        nolla()
        DatumTB.Text = today
        BatchnrTB.Text = "???"
        ProvstatusCB.Text = "Pågående"
        ProvSenasteTB.Text = today
        SparaB.Visible = True
        ErsattaB.Visible = False
        ProduktIDCB.Enabled = True
    End Sub

    Private Sub Sokbegrepp_TextChanged(sender As Object, e As EventArgs) Handles Sokbegrepp.TextChanged

    End Sub

    Function Getproduktnamn(Prodnamn)
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, utpris(10) As Double
        Dim myCmd As OdbcCommand
        Dim tabel As OdbcDataReader


        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT top 10 * FROM LabProdukter"
        mySQL = mySQL + " WHERE ProduktKod = '" + Prodnamn + "' "

        myCmd = New OdbcCommand(mySQL, cn)
        tabel = myCmd.ExecuteReader(CommandBehavior.CloseConnection)

        tabel.Read()

        If tabel.HasRows = False Then
            MessageBox.Show("Provet saknas")
        Else
            Getproduktnamn = nullhantering(tabel("ProduktNamn"), "S")
            komments = nullhantering(tabel("Komments"), "S")
            KommentsTB.Text = nullhantering(tabel("Komments"), "S")

            Test1 = nullhantering(tabel("Test1"), "S")
            Test2 = nullhantering(tabel("Test2"), "S")
            Test3 = nullhantering(tabel("Test3"), "S")
            Test4 = nullhantering(tabel("Test4"), "S")
            Test5 = nullhantering(tabel("Test5"), "S")
            Test6 = nullhantering(tabel("Test6"), "S")
            Test7 = nullhantering(tabel("Test7"), "S")
            Test8 = nullhantering(tabel("Test8"), "S")
            maxmin1 = nullhantering(tabel("Test1MaxMin"), "S")
            maxmin2 = nullhantering(tabel("Test2MaxMin"), "S")
            maxmin3 = nullhantering(tabel("Test3MaxMin"), "S")
            maxmin4 = nullhantering(tabel("Test4MaxMin"), "S")
            maxmin5 = nullhantering(tabel("Test5MaxMin"), "S")
            maxmin6 = nullhantering(tabel("Test6MaxMin"), "S")
            maxmin7 = nullhantering(tabel("Test7MaxMin"), "S")
            maxmin8 = nullhantering(tabel("Test8MaxMin"), "S")

        End If

        cn.Close()
    End Function

    Private Sub Prov8L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Prov8L.SelectedIndexChanged
        Provtext8L.Visible = True
        ' TestKomment8B.Visible = True
        Provtext8L.Text = Getprovtext(Prov8L.Text)
        Provtext8L.Refresh()
        Varde8TB.Visible = True
        Jam8B.Visible = True
        Varde8TB.Text = ""
        Varde8TB.Refresh()
        If colorprov = "Färg" Then
            FKod8CB.Visible = True
        Else
            FKod8CB.Visible = False
        End If
        If Prov8L.Text = "Kulörbestämning" Then
            FKod8CB.Visible = True

        End If

    End Sub

    Private Sub Prov3L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Prov3L.SelectedIndexChanged
        Provtext3L.Visible = True
        'TestKomment3B.Visible = True
        Provtext3L.Text = Getprovtext(Prov3L.Text)
        Provtext3L.Refresh()
        Varde3TB.Visible = True
        Jam3B.Visible = True
        Varde3TB.Text = ""
        Varde3TB.Refresh()
        If colorprov = "Färg" Then
            FKod3CB.Visible = True
        Else
            FKod3CB.Visible = False
        End If
        If Prov3L.Text = "Kulörbestämning" Then
            FKod3CB.Visible = True

        End If

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Prov4L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Prov4L.SelectedIndexChanged
        Provtext4L.Visible = True
        ' TestKomment4B.Visible = True
        Provtext4L.Text = Getprovtext(Prov4L.Text)
        Provtext4L.Refresh()
        Varde4TB.Visible = True
        Jam4B.Visible = True
        Varde4TB.Text = ""
        Varde4TB.Refresh()
        If colorprov = "Färg" Then
            FKod4CB.Visible = True
        Else
            FKod4CB.Visible = False
        End If

        If Prov4L.Text = "Kulörbestämning" Then
            FKod4CB.Visible = True

        End If

    End Sub

    Private Sub SokSammanB_Click(sender As Object, e As EventArgs) Handles SokSammanB.Click
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Prov5L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Prov5L.SelectedIndexChanged
        Provtext5L.Visible = True
        'TestKomment5B.Visible = True
        Provtext5L.Text = Getprovtext(Prov5L.Text)
        Provtext5L.Refresh()
        Varde5TB.Visible = True
        Jam5B.Visible = True
        Varde5TB.Text = ""
        Varde5TB.Refresh()
        If colorprov = "Färg" Then
            FKod5CB.Visible = True
        Else
            FKod5CB.Visible = False
        End If

        If Prov5L.Text = "Kulörbestämning" Then
            FKod5CB.Visible = True

        End If

    End Sub

    Private Sub ResultatRegTB_TextChanged(sender As Object, e As EventArgs) Handles ResultatRegTB.TextChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Prov6L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Prov6L.SelectedIndexChanged
        Provtext6L.Visible = True
        ' TestKomment6B.Visible = True
        Provtext6L.Text = Getprovtext(Prov6L.Text)
        Provtext6L.Refresh()
        Varde6TB.Visible = True
        Jam6B.Visible = True
        Varde6TB.Text = ""
        Varde6TB.Refresh()
        If colorprov = "Färg" Then
            FKod6CB.Visible = True
        Else
            FKod6CB.Visible = False
        End If
        If Prov6L.Text = "Kulörbestämning" Then
            FKod6CB.Visible = True

        End If


    End Sub

    Private Sub Prov7L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Prov7L.SelectedIndexChanged
        Provtext7L.Visible = True
        ' TestKomment7B.Visible = True
        Provtext7L.Text = Getprovtext(Prov7L.Text)
        Provtext7L.Refresh()
        Varde7TB.Visible = True
        Jam7B.Visible = True
        Varde7TB.Text = ""
        Varde7TB.Refresh()
        If colorprov = "Färg" Then
            FKod7CB.Visible = True
        Else
            FKod7CB.Visible = False
        End If
        If Prov7L.Text = "Kulörbestämning" Then
            FKod7CB.Visible = True

        End If

    End Sub

    Private Sub EditeringsbarCB_CheckedChanged(sender As Object, e As EventArgs) Handles EditeringsbarCB.CheckedChanged
        If EditeringsbarCB.Checked = True Then
            Prov1L.DropDownStyle = ComboBoxStyle.DropDown
            Prov2L.DropDownStyle = ComboBoxStyle.DropDown
            Prov3L.DropDownStyle = ComboBoxStyle.DropDown
            Prov4L.DropDownStyle = ComboBoxStyle.DropDown
            Prov5L.DropDownStyle = ComboBoxStyle.DropDown
            Prov6L.DropDownStyle = ComboBoxStyle.DropDown
            Prov7L.DropDownStyle = ComboBoxStyle.DropDown
            Prov8L.DropDownStyle = ComboBoxStyle.DropDown
        Else
            Prov1L.DropDownStyle = ComboBoxStyle.Simple
            Prov2L.DropDownStyle = ComboBoxStyle.Simple
            Prov3L.DropDownStyle = ComboBoxStyle.Simple
            Prov4L.DropDownStyle = ComboBoxStyle.Simple
            Prov5L.DropDownStyle = ComboBoxStyle.Simple
            Prov6L.DropDownStyle = ComboBoxStyle.Simple
            Prov7L.DropDownStyle = ComboBoxStyle.Simple
            Prov8L.DropDownStyle = ComboBoxStyle.Simple
        End If
    End Sub

    Private Sub Jam1B_Click(sender As Object, e As EventArgs) Handles Jam1B.Click
        TestnamnTB.Text = Prov1L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov1L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod1CB.Text
        If Len(FKod1CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Private Sub Jam2B_Click(sender As Object, e As EventArgs) Handles Jam2B.Click
        TestnamnTB.Text = Prov2L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov2L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod2CB.Text
        If Len(FKod2CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Private Sub Jam3B_Click(sender As Object, e As EventArgs) Handles Jam3B.Click
        TestnamnTB.Text = Prov3L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov3L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod3CB.Text
        If Len(FKod3CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Private Sub Jam4B_Click(sender As Object, e As EventArgs) Handles Jam4B.Click
        TestnamnTB.Text = Prov4L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov4L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod4CB.Text
        If Len(FKod4CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Private Sub Jam5B_Click(sender As Object, e As EventArgs) Handles Jam5B.Click
        TestnamnTB.Text = Prov5L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov5L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod5CB.Text
        If Len(FKod5CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Private Sub Jam6B_Click(sender As Object, e As EventArgs) Handles Jam6B.Click
        TestnamnTB.Text = Prov6L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov6L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod6CB.Text
        If Len(FKod6CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Private Sub Jam7B_Click(sender As Object, e As EventArgs) Handles Jam7B.Click
        TestnamnTB.Text = Prov7L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov7L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod7CB.Text
        If Len(FKod7CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Private Sub Jam8B_Click(sender As Object, e As EventArgs) Handles Jam8B.Click
        TestnamnTB.Text = Prov8L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov8L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod8CB.Text
        If Len(FKod8CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Private Sub BatchSokB_Click(sender As Object, e As EventArgs) Handles BatchSokB.Click
        nolla()
        Getbatch(ResultatRegTB.Text)
        ErsattaB.Visible = True
        SparaB.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
    End Sub

    Private Sub PagoendeCB_CheckedChanged(sender As Object, e As EventArgs) Handles PagoendeCB.CheckedChanged
        On Error Resume Next
        ' DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        If PagoendeCB.Checked = True Then
            Label11.Visible = False
            TestTB.Visible = False

            FromDatumTB.Text = "2020-01-01"
            FromDatumTB.Visible = False
            Label7.Visible = False
            Label6.Visible = False
            Sokbegrepp.Visible = False
            BatchnrRB.Visible = False
            ProduktKodRB.Visible = False
            SokB.Visible = False
            DataGridView1.Columns(2).Width = 200
        Else
            FromDatumTB.Text = CDate(today).AddDays(-90)
            FromDatumTB.Visible = True
            Label7.Visible = True
            Label6.Visible = True
            Sokbegrepp.Visible = True
            BatchnrRB.Visible = True
            ProduktKodRB.Visible = True
            SokB.Visible = True
            DataGridView1.Columns(2).Width = 120
        End If
    End Sub

    Private Sub Sokbegrepp_KeyUp(sender As Object, e As KeyEventArgs) Handles Sokbegrepp.KeyUp
        If e.KeyCode = Keys.Enter Then
            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        End If
    End Sub

    Private Sub Prov1L_TextChanged(sender As Object, e As EventArgs) Handles Prov1L.TextChanged
        Provtext1L.Visible = True
        Provtext1L.Text = Getprovtext(Prov1L.Text)
        Provtext1L.Refresh()
        Varde1TB.Visible = True
        Varde1TB.Text = ""
        Varde1TB.Refresh()

        If colorprov = "Färg" Then
            FKod1CB.Visible = True
        Else
            FKod1CB.Visible = False
        End If
        If Prov1L.Text = "Kulörbestämning" Then
            FKod1CB.Visible = True

        End If

    End Sub

    Private Sub FromDatumTB_TextChanged(sender As Object, e As EventArgs) Handles FromDatumTB.TextChanged

    End Sub

    Private Sub ProdKodTB_TextChanged(sender As Object, e As EventArgs) Handles ProdKodTB.TextChanged

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Function Makegrid(ByVal typ As String)

        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()

        DataGridView2.Left = 805
        DataGridView2.Top = 550
        DataGridView2.Height = 200
        DataGridView2.DefaultCellStyle.ForeColor = Color.Black
        DataGridView2.DefaultCellStyle.BackColor = Color.White
        With (Me.DataGridView2.Columns)
            .Add("", "Datum")
            .Add("", "Produkt")
            .Add("", "Batch")
            .Add("", "Test")
            .Add("", "Värde")
            .Add("", "FärgKod")
            .Add("", "Status")
            .Add("", "TimeStamp")
        End With
        'DataGridView2.Columns(1).DisplayIndex = 3 'Datum
        With Me.DataGridView2.Rows
            For Me.r = 1 To 50
                .Add("")
            Next r
        End With
        DataGridView2.CurrentCell = DataGridView2.Item(0, 0)
        'DataGridView1.CurrentCell.Style.SelectionBackColor = Color.White
        r = 0
        With DataGridView2.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView2.Font, FontStyle.Bold)
        End With
        DataGridView2.RowHeadersWidth = 10
        DataGridView2.Columns(0).Width = 70 'Datum
        DataGridView2.Columns(1).Width = 100 'ProduktKod
        DataGridView2.Columns(2).Width = 80 'Batch
        DataGridView2.Columns(3).Width = 0 'TestID
        DataGridView2.Columns(4).Width = 80 'Varde
        DataGridView2.Columns(5).Width = 80 'Färgkod
        DataGridView2.Columns(6).Width = 120 'Status
        DataGridView2.Columns(7).Width = 0 'Status
        ''prisfaktor
        'DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        'DataGridView1.Columns(3).Width = 0


        ''antal
        'DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridView1.Columns(4).Width = 40
        ''apris
        'DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView1.Columns(5).Width = 60
        'Me.DataGridView1.Columns.Item(5).DefaultCellStyle.Format = "n2"
        ''summa
        'DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView1.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView1.Columns(6).Width = 60
        'Me.DataGridView1.Columns.Item(6).DefaultCellStyle.Format = "n2"
        'DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView1.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView1.Columns(7).Width = 70
        'Me.DataGridView1.Columns.Item(7).DefaultCellStyle.Format = "n2"
        'DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridView1.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridView1.Columns(8).Width = 53
        'Me.DataGridView1.Columns.Item(8).DefaultCellStyle.Format = "n1"
        'DataGridView1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView1.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView1.Columns(9).Width = 70
        'Me.DataGridView2.Columns.Item(9).DefaultCellStyle.Format = "n2"

        DataGridView2.Visible = True
        Makegrid = ""
    End Function

    Function getsammanstallning(ByVal nr As String)
        'On Error Resume Next

        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, prov1 As String, prov2 As String, prov3 As String, prov4 As String, prov5 As String, prov6 As String
        Dim prov7 As String, prov8 As String, Batch As String, l As Integer = 0
        Dim prov As String, varde As String, fkod As String
        Dim varde1 As String, varde2 As String, varde3 As String, varde4 As String
        Dim varde5 As String, varde6 As String, varde7 As String, varde8 As String
        Dim fkod1 As String, fkod2 As String, fkod3 As String, fkod4 As String
        Dim fkod5 As String, fkod6 As String, fkod7 As String, fkod8 As String
        Dim Status As String

        Dim Datum As String, ProduktKod As String, FargKod As String, testkod As String, testvarde As String
        Dim myCmd As OdbcCommand
        Dim tabel As OdbcDataReader
        'DataGridView2.Columns.Clear()
        'DataGridView2.Rows.Clear()

        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM Provarkiv "
        If ProdKodTB.Text <> "Alla" Then
            mySQL = mySQL + "Where ProduktKod = " + "'" + ProdKodTB.Text + "'"
        End If

        mySQL = mySQL + " Order by Datum desc"

        myCmd = New OdbcCommand(mySQL, cn)
        tabel = myCmd.ExecuteReader(CommandBehavior.CloseConnection)


        If tabel.HasRows = False Then
            GoTo slut
        Else
            While tabel.Read()
                prov = "" : varde = "" : fkod = ""
                prov1 = nullhantering(tabel("prov1"), "S")
                If prov1 = nr Then
                    prov = prov1
                    varde = nullhantering(tabel("resultat1"), "S")
                    If prov1 = "Kulörbestämning" Then
                        fkod = nullhantering(tabel("fkod1"), "S")
                    End If
                End If

                prov2 = nullhantering(tabel("prov2"), "S")
                If prov2 = nr Then
                    prov = prov2
                    varde = nullhantering(tabel("resultat2"), "S")
                    If prov2 = "Kulörbestämning" Then
                        fkod = nullhantering(tabel("fkod2"), "S")
                    End If
                End If

                prov3 = nullhantering(tabel("prov3"), "S")
                If prov3 = nr Then
                    prov = prov3
                    varde = nullhantering(tabel("resultat3"), "S")
                    If prov3 = "Kulörbestämning" Then
                        fkod = nullhantering(tabel("fkod3"), "S")
                    End If
                End If
                prov4 = nullhantering(tabel("prov4"), "S")
                If prov4 = nr Then
                    prov = prov4
                    varde = nullhantering(tabel("resultat4"), "S")
                    If prov4 = "Kulörbestämning" Then
                        fkod = nullhantering(tabel("fkod4"), "S")
                    End If
                End If


                Datum = nullhantering(tabel("Datum"), "S")
                ProduktKod = nullhantering(tabel("ProduktKod"), "S")
                Batch = nullhantering(tabel("BatchNr"), "S")
                Status = nullhantering(tabel("ProvStatus"), "S")
                StTimestamp = nullhantering(tabel("MyTimeStamp"), "S")

                If FargkodJamTB.Text <> "Alla" And fkod <> FargkodJamTB.Text Then



                Else
                    DataGridView2.Item(0, l).Value = Datum
                    DataGridView2.Item(1, l).Value = ProduktKod
                    DataGridView2.Item(2, l).Value = Batch
                    DataGridView2.Item(3, l).Value = nr
                    DataGridView2.Item(4, l).Value = varde
                    DataGridView2.Item(5, l).Value = fkod
                    DataGridView2.Item(6, l).Value = Status
                    DataGridView2.Item(7, l).Value = StTimestamp
                    l = l + 1
                End If
            End While

        End If
slut:
        cn.Close()



    End Function
    Function Getbatch(bnr As String)
        Dim strConnString, strSQL As String
        Dim tabel As OdbcDataReader
        Dim cn As OdbcConnection
        Dim myCmd As OdbcCommand, dummy As String
        Dim Prov1 As String, varde1 As String, prov2 As String, varde2 As String
        Dim Prov3 As String, varde3 As String, prov4 As String, varde4 As String
        Dim Prov5 As String, varde5 As String, prov6 As String, varde6 As String
        Dim Prov7 As String, varde7 As String, prov8 As String, varde8 As String

        strConnString = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(strConnString)
        cn.Open()
        strSQL = "SELECT * FROM Provarkiv "
        ' strSQL = strSQL + "Where Datum >= '" + FromDatumTB.Text + "' "
        strSQL = strSQL + "Where Batchnr = '" + bnr + "' "
        strSQL = strSQL + "  order by datum,Mytimestamp"

        myCmd = New OdbcCommand(strSQL, cn)
        tabel = myCmd.ExecuteReader(CommandBehavior.CloseConnection)

        tabel.Read()

        If tabel.HasRows = False Then
            MessageBox.Show("Batch saknas")
        Else

            Timestamp = nullhantering(tabel("Mytimestamp"), "S")

            DatumTB.Text = nullhantering(tabel("Datum"), "S")
            StatusTB.Text = nullhantering(tabel("Status"), "S")
            ProduktIDCB.Text = nullhantering(tabel("ProduktKod"), "S")
            BatchnrTB.Text = nullhantering(tabel("BatchNr"), "S")
            KommentsTB.Text = nullhantering(tabel("Komment"), "S")

            Prov1 = nullhantering(tabel("Prov1"), "S")
            If Len(Prov1) > 2 Then

                Prov1L.Visible = True
                Prov1L.Text = Prov1
                Prov1L.Refresh()
                dummy = Getprovtext(Prov1L.Text)
                Provtext1L.Visible = True
                Provtext1L.Text = dummy
                varde1 = nullhantering(tabel("Resultat1"), "S")
                Varde1TB.Visible = True
                Varde1TB.Text = varde1
                Varde1TB.Refresh()
                If Prov1 = "Kulörbestämning" Then
                    FKod1CB.Visible = True
                    FKod1CB.Text = nullhantering(tabel("Fkod1"), "S")
                End If
            End If

            prov2 = nullhantering(tabel("Prov2"), "S")
            If Len(prov2) > 2 Then
                Prov2L.Visible = True

                Prov2L.Text = prov2
                Prov2L.Refresh()
                dummy = Getprovtext(Prov2L.Text)
                Provtext2L.Visible = True
                Provtext2L.Text = dummy
                varde2 = nullhantering(tabel("Resultat2"), "S")
                Varde2TB.Visible = True
                Varde2TB.Text = varde2
                Varde2TB.Refresh()
                If prov2 = "Kulörbestämning" Then
                    FKod2CB.Visible = True
                    FKod2CB.Text = nullhantering(tabel("Fkod2"), "S")
                End If
            End If

            Prov3 = nullhantering(tabel("Prov3"), "S")
            If Len(Prov3) > 2 Then
                Prov3L.Visible = True
                Prov3L.Text = Prov3
                Prov3L.Refresh()
                dummy = Getprovtext(Prov3L.Text)
                Provtext3L.Visible = True
                Provtext3L.Text = dummy
                varde3 = nullhantering(tabel("Resultat3"), "S")
                Varde3TB.Visible = True
                Varde3TB.Text = varde3
                Varde3TB.Refresh()
                If Prov3 = "Kulörbestämning" Then
                    FKod3CB.Visible = True
                    FKod3CB.Text = nullhantering(tabel("Fkod3"), "S")
                End If
            End If
            prov4 = nullhantering(tabel("Prov4"), "S")
            If Len(prov4) > 2 Then
                Prov4L.Visible = True
                Prov4L.Text = prov4
                Prov4L.Refresh()
                dummy = Getprovtext(Prov4L.Text)
                Provtext4L.Visible = True
                Provtext4L.Text = dummy
                varde4 = nullhantering(tabel("Resultat4"), "S")
                Varde4TB.Visible = True
                Varde4TB.Text = varde4
                Varde4TB.Refresh()
                If prov4 = "Kulörbestämning" Then
                    FKod4CB.Visible = True
                    FKod4CB.Text = nullhantering(tabel("Fkod4"), "S")
                End If
            End If
            Prov5 = nullhantering(tabel("Prov5"), "S")
            If Len(Prov5) > 2 Then
                Prov5L.Visible = True
                Prov5L.Text = Prov5
                Prov5L.Refresh()
                dummy = Getprovtext(Prov5L.Text)
                Provtext5L.Visible = True
                Provtext5L.Text = dummy
                varde5 = nullhantering(tabel("Resultat5"), "S")
                Varde5TB.Visible = True
                Varde5TB.Text = varde5
                Varde5TB.Refresh()
                If Prov5 = "Kulörbestämning" Then
                    FKod5CB.Visible = True
                    FKod5CB.Text = nullhantering(tabel("Fkod5"), "S")
                End If
            End If
            prov6 = nullhantering(tabel("Prov6"), "S")
            If Len(prov6) > 2 Then
                Prov6L.Visible = True
                Prov6L.Text = prov6
                Prov6L.Refresh()
                dummy = Getprovtext(Prov6L.Text)
                Provtext6L.Visible = True
                Provtext6L.Text = dummy
                varde6 = nullhantering(tabel("Resultat6"), "S")
                Varde6TB.Visible = True
                Varde6TB.Text = varde6
                Varde6TB.Refresh()
                If prov6 = "Kulörbestämning" Then
                    FKod6CB.Visible = True
                    FKod6CB.Text = nullhantering(tabel("Fkod6"), "S")
                End If
            End If

            Prov7 = nullhantering(tabel("Prov7"), "S")
            If Len(Prov7) > 2 Then
                Prov7L.Visible = True
                Prov7L.Text = Prov7
                Prov7L.Refresh()
                dummy = Getprovtext(Prov7L.Text)
                Provtext7L.Visible = True
                Provtext6L.Text = dummy
                varde7 = nullhantering(tabel("Resultat7"), "S")
                Varde7TB.Visible = True
                Varde7TB.Text = varde7
                Varde6TB.Refresh()
                If Prov7 = "Kulörbestämning" Then
                    FKod7CB.Visible = True
                    FKod7CB.Text = nullhantering(tabel("Fkod7"), "S")
                End If
            End If

            prov8 = nullhantering(tabel("Prov8"), "S")
            If Len(prov8) > 2 Then
                Prov8L.Visible = True
                Prov8L.Text = prov8
                Prov8L.Refresh()
                dummy = Getprovtext(Prov8L.Text)
                Provtext8L.Visible = True
                Provtext8L.Text = dummy
                varde8 = nullhantering(tabel("Resultat8"), "S")
                Varde8TB.Visible = True
                Varde8TB.Text = varde8
                Varde6TB.Refresh()
                If prov8 = "Kulörbestämning" Then
                    FKod8CB.Visible = True
                    FKod8CB.Text = nullhantering(tabel("Fkod8"), "S")
                End If
            End If
        End If




        'dtAdapter = Nothing
        Getbatch = "Sparad"
    End Function

    Private Sub ResultatRegTB_KeyUp(sender As Object, e As KeyEventArgs) Handles ResultatRegTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            nolla()
            Getbatch(ResultatRegTB.Text)
            ErsattaB.Visible = True
            SparaB.Visible = False
        End If
    End Sub

    Private Sub ResultatRegTB_Paint(sender As Object, e As PaintEventArgs) Handles ResultatRegTB.Paint

    End Sub
    Sub Var5eminute()


        Timer1.Interval = 1000
        Timer1.Enabled = True
        Timer1.Start()





    End Sub





    Sub Timer_Tick() Handles Timer1.Tick

        ' Stop
        StatusSecondsPassed -= 1
        TestTB.Text = StatusSecondsPassed
        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView

        If StatusSecondsPassed = 0 Then
            TestTB.Text = "60"
            StatusSecondsPassed = 60
        End If
    End Sub

    Sub Autojamforelse1()
        TestnamnTB.Text = Prov1L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov1L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod1CB.Text
        If Len(FKod1CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Sub Autojamforelse2()
        TestnamnTB.Text = Prov2L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov2L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod2CB.Text
        If Len(FKod2CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Private Sub TestKomment1_Click(sender As Object, e As EventArgs)
        If Len(Prov1L.Text) > 1 Then

            Getprovtext(Prov1L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov1L.Text + " Kommentar")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub MaxMin1L_Click(sender As Object, e As EventArgs) Handles MaxMin1L.Click

    End Sub

    Private Sub Info2l_Click(sender As Object, e As EventArgs) Handles Info2l.Click
        Dim filnamn As String, response As Integer
        '"F:\V2012LabDok\"
        filnamn = Info2l.Text
        filnamn = labmap + filnamn + ".pdf"
        If System.IO.File.Exists(filnamn) Then
            Process.Start(filnamn)
        Else
            response = MsgBox("Filen finns inte", 0, "OBS")
            If response = 1 Then
            End If
        End If
    End Sub

    Private Sub Info3L_Click(sender As Object, e As EventArgs) Handles Info3L.Click
        Dim filnamn As String, response As Integer
        '"F:\V2012LabDok\"
        filnamn = Info3L.Text
        filnamn = labmap + filnamn + ".pdf"
        If System.IO.File.Exists(filnamn) Then
            Process.Start(filnamn)
        Else
            response = MsgBox("Filen finns inte", 0, "OBS")
            If response = 1 Then
            End If
        End If
    End Sub

    Private Sub Info4L_Click(sender As Object, e As EventArgs) Handles Info4L.Click
        Dim filnamn As String, response As Integer
        '"F:\V2012LabDok\"
        filnamn = Info4L.Text
        filnamn = labmap + filnamn + ".pdf"
        If System.IO.File.Exists(filnamn) Then
            Process.Start(filnamn)
        Else
            response = MsgBox("Filen finns inte", 0, "OBS")
            If response = 1 Then
            End If
        End If
    End Sub

    Private Sub Info5L_Click(sender As Object, e As EventArgs) Handles Info5L.Click
        Dim filnamn As String, response As Integer
        '"F:\V2012LabDok\"
        filnamn = Info5L.Text
        filnamn = labmap + filnamn + ".pdf"
        If System.IO.File.Exists(filnamn) Then
            Process.Start(filnamn)
        Else
            response = MsgBox("Filen finns inte", 0, "OBS")
            If response = 1 Then
            End If
        End If
    End Sub

    Private Sub Info6L_Click(sender As Object, e As EventArgs) Handles Info6L.Click
        Dim filnamn As String, response As Integer
        '"F:\V2012LabDok\"
        filnamn = Info6L.Text
        filnamn = labmap + filnamn + ".pdf"
        If System.IO.File.Exists(filnamn) Then
            Process.Start(filnamn)
        Else
            response = MsgBox("Filen finns inte", 0, "OBS")
            If response = 1 Then
            End If
        End If
    End Sub

    Private Sub Info7L_Click(sender As Object, e As EventArgs) Handles Info7L.Click
        Dim filnamn As String, response As Integer
        '"F:\V2012LabDok\"
        filnamn = Info7L.Text
        filnamn = labmap + filnamn + ".pdf"
        If System.IO.File.Exists(filnamn) Then
            Process.Start(filnamn)
        Else
            response = MsgBox("Filen finns inte", 0, "OBS")
            If response = 1 Then
            End If
        End If
    End Sub

    Private Sub Info8L_Click(sender As Object, e As EventArgs) Handles Info8L.Click
        Dim filnamn As String, response As Integer
        '"F:\V2012LabDok\"
        filnamn = Info8L.Text
        filnamn = labmap + filnamn + ".pdf"
        If System.IO.File.Exists(filnamn) Then
            Process.Start(filnamn)
        Else
            response = MsgBox("Filen finns inte", 0, "OBS")
            If response = 1 Then
            End If
        End If
    End Sub

    Private Sub Provtext1L_Click(sender As Object, e As EventArgs) Handles Provtext1L.Click


        If Provtext1L.Height = 80 Then
            nollaenhethojd()
            Provtext1L.Height = 21
            Provtext1L.BringToFront()
        Else
            Provtext1L.Height = 80
            Provtext1L.BringToFront()
            ' Provtext1L.Height = 21
            Provtext2L.Height = 21
            Provtext3L.Height = 21
            Provtext4L.Height = 21
            Provtext5L.Height = 21
            Provtext6L.Height = 21
            Provtext7L.Height = 21
            Provtext8L.Height = 21
        End If
    End Sub

    Private Sub Provtext2L_Click(sender As Object, e As EventArgs) Handles Provtext2L.Click

        If Provtext2L.Height = 80 Then
            nollaenhethojd()
            Provtext2L.Height = 21
            Provtext2L.BringToFront()
        Else
            Provtext2L.Height = 80
            Provtext2L.BringToFront()
            Provtext1L.Height = 21
            ' Provtext2L.Height = 21
            Provtext3L.Height = 21
            Provtext4L.Height = 21
            Provtext5L.Height = 21
            Provtext6L.Height = 21
            Provtext7L.Height = 21
            Provtext8L.Height = 21
        End If


    End Sub

    Private Sub Provtext3L_Click(sender As Object, e As EventArgs) Handles Provtext3L.Click

        If Provtext3L.Height = 80 Then
            nollaenhethojd()
            Provtext3L.Height = 21
            Provtext3L.BringToFront()
        Else
            Provtext3L.Height = 80
            Provtext3L.BringToFront()
            Provtext1L.Height = 21
            Provtext2L.Height = 21
            ' Provtext3L.Height = 21
            Provtext4L.Height = 21
            Provtext5L.Height = 21
            Provtext6L.Height = 21
            Provtext7L.Height = 21
            Provtext8L.Height = 21
        End If
    End Sub

    Private Sub Provtext4L_Click(sender As Object, e As EventArgs) Handles Provtext4L.Click
        If Provtext4L.Height = 80 Then
            nollaenhethojd()
            Provtext4L.Height = 21
            Provtext4L.BringToFront()
        Else
            Provtext4L.Height = 80

            Provtext4L.BringToFront()
            Provtext1L.Height = 21
            Provtext2L.Height = 21
            Provtext3L.Height = 21
            '' Provtext4L.Height = 21
            Provtext5L.Height = 21
            Provtext6L.Height = 21
            Provtext7L.Height = 21
            Provtext8L.Height = 21
        End If
    End Sub

    Private Sub Provtext5L_Click(sender As Object, e As EventArgs) Handles Provtext5L.Click
        If Provtext5L.Height = 80 Then
            nollaenhethojd()
            Provtext5L.Height = 21
            Provtext5L.BringToFront()
        Else
            Provtext5L.Height = 80
            Provtext5L.BringToFront()
            Provtext1L.Height = 21
            Provtext2L.Height = 21
            Provtext3L.Height = 21
            Provtext4L.Height = 21
            ' Provtext5L.Height = 21
            Provtext6L.Height = 21
            Provtext7L.Height = 21
            Provtext8L.Height = 21
        End If
    End Sub

    Private Sub Provtext6L_Click(sender As Object, e As EventArgs) Handles Provtext6L.Click
        If Provtext6L.Height = 80 Then
            nollaenhethojd()
            Provtext6L.Height = 21
            Provtext6L.BringToFront()
        Else
            Provtext6L.Height = 80
            Provtext6L.BringToFront()
            Provtext1L.Height = 21
            Provtext2L.Height = 21
            Provtext3L.Height = 21
            Provtext4L.Height = 21
            Provtext5L.Height = 21
            ' Provtext6L.Height = 21
            Provtext7L.Height = 21
            Provtext8L.Height = 21
        End If
    End Sub

    Private Sub Provtext7L_Click(sender As Object, e As EventArgs) Handles Provtext7L.Click
        If Provtext7L.Height = 80 Then
            nollaenhethojd()
            Provtext7L.Height = 21
            Provtext7L.BringToFront()
        Else
            Provtext7L.Height = 80
            Provtext7L.BringToFront()
            Provtext1L.Height = 21
            Provtext2L.Height = 21
            Provtext3L.Height = 21
            Provtext4L.Height = 21
            Provtext5L.Height = 21
            Provtext6L.Height = 21
            ' Provtext7L.Height = 21
            Provtext8L.Height = 21
        End If
    End Sub

    Private Sub Provtext8L_Click(sender As Object, e As EventArgs) Handles Provtext8L.Click
        If Provtext8L.Height = 80 Then
            nollaenhethojd()
            Provtext8L.Height = 21
            Provtext8L.BringToFront()
        Else
            Provtext8L.Height = 80
            Provtext8L.BringToFront()
            Provtext1L.Height = 21
            Provtext2L.Height = 21
            Provtext3L.Height = 21
            Provtext4L.Height = 21
            Provtext5L.Height = 21
            Provtext6L.Height = 21
            Provtext7L.Height = 21
            '  Provtext8L.Height = 21
        End If
    End Sub

    Private Sub TestKomment2B_Click(sender As Object, e As EventArgs)
        If Len(Prov2L.Text) > 1 Then

            Getprovtext(Prov2L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov2L.Text + " Kommentar")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub TestKomment3B_Click(sender As Object, e As EventArgs)
        If Len(Prov3L.Text) > 1 Then

            Getprovtext(Prov3L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov3L.Text + " Kommentar")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub TestKomment4B_Click(sender As Object, e As EventArgs)
        If Len(Prov4L.Text) > 1 Then

            Getprovtext(Prov4L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov4L.Text + " Kommentar")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub TestKomment5B_Click(sender As Object, e As EventArgs)
        If Len(Prov5L.Text) > 1 Then

            Getprovtext(Prov5L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov5L.Text + " Kommentar")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub TestKomment6B_Click(sender As Object, e As EventArgs)
        If Len(Prov6L.Text) > 1 Then

            Getprovtext(Prov6L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov6L.Text + " Kommentar")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub Info1L_Click(sender As Object, e As EventArgs) Handles Info1L.Click
        Dim filnamn As String, response As Integer
        '"F:\V2012LabDok\"
        filnamn = Info1L.Text
        filnamn = labmap + filnamn + ".pdf"
        If System.IO.File.Exists(filnamn) Then
            Process.Start(filnamn)
        Else
            response = MsgBox("Filen finns inte", 0, "OBS")
            If response = 1 Then
            End If
        End If

    End Sub

    Private Sub TestKomment7B_Click(sender As Object, e As EventArgs)
        If Len(Prov7L.Text) > 1 Then

            Getprovtext(Prov7L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov7L.Text + " Kommentar")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub TestKomment8B_Click(sender As Object, e As EventArgs)
        If Len(Prov8L.Text) > 1 Then

            Getprovtext(Prov8L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov8L.Text + " Kommentar")
            If response = 0 Then

            End If
        End If
    End Sub

    Sub Autojamforelse3()
        TestnamnTB.Text = Prov3L.Text
        ProdKodTB.Text = ProduktIDCB.Text
        If Prov3L.Text = "Kulörbestämning" Then FargkodJamTB.Text = FKod3CB.Text
        If Len(FKod3CB.Text) < 1 Then FargkodJamTB.Text = "Alla"
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        Makegrid(1)
        getsammanstallning(TestnamnTB.Text)
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim r2 As Integer, c2 As Integer, prov1 As String = "", prov2 As String = ""
        Dim prov3 As String = "", prov4 As String = "", prov5 As String = "", prov6 As String = ""
        Dim prov7 As String = "", prov8 As String = "", varde1 As String = "", varde2 As String = ""
        Dim varde3 As String = "", varde4 As String = "", varde5 As String = "", varde6 As String = ""
        Dim varde7 As String = "", varde8 As String = ""
        r2 = Me.DataGridView2.CurrentRow.Index
        c2 = DataGridView2.CurrentCell.ColumnIndex

        StTimestamp = nullhantering(DataGridView2.Item(7, r2).Value, "S")

        StatistikPopupf.Close()
        StatistikPopupf.Show()


    End Sub

    Private Sub Prov1L_Click(sender As Object, e As EventArgs) Handles Prov1L.Click
        If Len(Prov1L.Text) > 1 Then

            Getprovtext(Prov1L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov1L.Text + " Komment")
            If response = 0 Then

            End If
        End If
    End Sub



    Private Sub Prov2L_Click(sender As Object, e As EventArgs) Handles Prov2L.Click
        If Len(Prov2L.Text) > 1 Then

            Getprovtext(Prov2L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov2L.Text + " Komment")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub Prov3L_Click(sender As Object, e As EventArgs) Handles Prov3L.Click
        If Len(Prov3L.Text) > 1 Then

            Getprovtext(Prov3L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov3L.Text + " Komment")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub Prov4L_Click(sender As Object, e As EventArgs) Handles Prov4L.Click
        If Len(Prov4L.Text) > 1 Then

            Getprovtext(Prov4L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov4L.Text + " Komment")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub Prov5L_Click(sender As Object, e As EventArgs) Handles Prov5L.Click
        If Len(Prov5L.Text) > 1 Then

            Getprovtext(Prov5L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov5L.Text + " Komment")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub Prov6L_Click(sender As Object, e As EventArgs) Handles Prov6L.Click
        If Len(Prov6L.Text) > 1 Then

            Getprovtext(Prov6L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov6L.Text + " Komment")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub Prov7L_Click(sender As Object, e As EventArgs) Handles Prov7L.Click
        If Len(Prov7L.Text) > 1 Then

            Getprovtext(Prov7L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov7L.Text + " Komment")
            If response = 0 Then

            End If
        End If
    End Sub

    Private Sub Prov8L_Click(sender As Object, e As EventArgs) Handles Prov8L.Click
        If Len(Prov8L.Text) > 1 Then

            Getprovtext(Prov8L.Text)
            Dim response
            response = MsgBox(Tolerans, 1, Prov8L.Text + " Komment")
            If response = 0 Then

            End If
        End If
    End Sub
    Sub nollaenhethojd()

        Provtext1L.Height = 21
        Provtext2L.Height = 21
        Provtext3L.Height = 21
        Provtext4L.Height = 21
        Provtext5L.Height = 21
        Provtext6L.Height = 21
        Provtext7L.Height = 21
        Provtext8L.Height = 21

    End Sub

    Private Sub Provtext1L_LostFocus(sender As Object, e As EventArgs) Handles Provtext1L.LostFocus

    End Sub

    Private Sub Provtext1L_Validated(sender As Object, e As EventArgs) Handles Provtext1L.Validated

    End Sub
End Class