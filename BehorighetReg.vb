Imports System.Data.Odbc

Public Class BehorighetF
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim builder As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter)
    Private Sub BehorighetF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - BehörighetsRegister"
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
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 80

        AvslutaK.Select()
    End Sub
    Function CreateDataSet() As DataSet
        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = ""

        strSQL = "SELECT * FROM Behorighetsreg "


        strSQL = strSQL + " order by klartextnamn"

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

    Private Sub Spara_Click(sender As Object, e As EventArgs) Handles Spara.Click
        Dim changes As DataSet
        changes = ds.GetChanges()
        If changes IsNot Nothing Then
            dtAdapter.Update(ds.Tables(0))
        End If
        ds.AcceptChanges()
    End Sub

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub

    Private Sub Label2TB_Click(sender As Object, e As EventArgs) Handles Label2TB.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class