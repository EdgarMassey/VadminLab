Imports System.Data.Common
Imports System.Data.Odbc

Public Class BatchreporterF
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objConn2 As New System.Data.Odbc.OdbcConnection '
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim objCmd2 As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim dtAdapter2 As New System.Data.Odbc.OdbcDataAdapter
    Dim ds1 As New DataSet
    Dim ds2 As New DataSet
    Dim builder As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter)
    Dim builder2 As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter2)
    Dim satsnr As String
    Private Sub BatchreporterF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        ' odbcsourcer = "VadminODBC"
        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Sats reporter "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsourcel.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + Labdatabasnamn
        Gnamn.Text = Firmanamn
        FromDatumTB.Text = CDate(today).AddDays(-600)
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.RowHeadersWidth = 5
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 80
        DataGridView1.Columns(3).Width = 80

    End Sub

    Function CreateDataSet() As DataSet

        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsource + "; Database=" + "Recept1" + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "SELECT DISTINCT Satsnr,Receptnamn,Receptnr, Datum FROM Satsark WHERE datum >= '" + FromDatumTB.Text + "' "
        strSQL = strSQL + " ORDER BY satsnr "

        objConn.ConnectionString = strConnString
        With objCmd
            .Connection = objConn
            .CommandText = strSQL
            .CommandType = CommandType.Text
        End With
        dtAdapter.SelectCommand = objCmd
        dtAdapter.Fill(ds1)
        Return ds1 '*** Return DataSet ***'  
        dtAdapter = Nothing
    End Function
    Function CreateDataSet2() As DataSet

        Dim strConnString2, strSQl2 As String
        strConnString2 = "DSN=" + odbcsource + "; Database=" + "Recept1" + ";Uid=v2000;Pwd=" + odbclosen
        strSQl2 = "SELECT  Prodnr,Prodnamn,Vikt  FROM Satsark WHERE Satsnr  = '" + satsnr + "' "
        strSQl2 = strSQl2 + " ORDER BY satsnr "

        objConn2.ConnectionString = strConnString2
        With objCmd
            .Connection = objConn2
            .CommandText = strSQl2
            .CommandType = CommandType.Text
        End With
        dtAdapter.SelectCommand = objCmd
        dtAdapter.Fill(ds2)
        Return ds2 '*** Return DataSet ***'  
        dtAdapter = Nothing
    End Function

    Private Sub Huvud_Click(sender As Object, e As EventArgs) Handles Huvud.Click

    End Sub

    Private Sub FromDatumTB_TextChanged(sender As Object, e As EventArgs) Handles FromDatumTB.TextChanged

    End Sub

    Private Sub FromDatumTB_KeyUp(sender As Object, e As KeyEventArgs) Handles FromDatumTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim r2 As Integer, c2 As Integer
        On Error Resume Next
        r2 = Me.DataGridView1.CurrentRow.Index
        c2 = DataGridView1.CurrentCell.ColumnIndex
        satsnr = nullhantering(DataGridView1.Item(0, r2).Value, "S")

        DataGridView2.DataSource.Table.Rows.Clear()
        DataGridView2.DataSource = CreateDataSet2.Tables(0).DefaultView
        With DataGridView2.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView2.RowHeadersWidth = 5
        DataGridView2.Columns(0).Width = 60
        DataGridView2.Columns(1).Width = 100
        DataGridView2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView2.Columns.Item(2).DefaultCellStyle.Format = "n2"
        DataGridView2.Columns(2).Width = 80
        DataGridView2.Columns(3).Width = 80
    End Sub
End Class