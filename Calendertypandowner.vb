Imports System.Data.Common

Public Class CalenderTypOwnerF
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Private Sub CalenderTypOwnerF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Calendertyp and owner "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsource.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + databasnamn
        Gnamn.Text = Firmanamn


        ''''''''''Nästkommande events
        DataGridView1.DataSource = CreateDataSet1.Tables(0).DefaultView
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.RowHeadersWidth = 12
        DataGridView1.Columns(0).Width = 0
        DataGridView1.Columns(1).Width = 0
        DataGridView1.Columns(2).HeaderText = "Order"
        DataGridView1.Columns(2).Width = 40
        DataGridView1.Columns(3).Width = 90


    End Sub

    Function CreateDataSet1() As DataSet
        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "Select Mytimestamp,Tabeltyp, Typorder,Typnamn FROM CalenderTypAndOwner "
        strSQL = strSQL + " Where tabeltyp ='CalenderTyp' "
        strSQL = strSQL + "  order by Typorder "

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



    Private Sub AvslutaB_Click(sender As Object, e As EventArgs) Handles AvslutaB.Click
        Me.Close()
    End Sub

    Private Sub SparaTypB_Click(sender As Object, e As EventArgs) Handles SparaTypB.Click
        Dim changes As DataSet
        changes = ds.GetChanges()
        If changes IsNot Nothing Then
            dtAdapter.Update(ds.Tables(0))
        End If
        ds.AcceptChanges()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value = gettimestamp()
        DataGridView1.Item(1, Me.DataGridView1.CurrentRow.Index).Value = "CalenderTyp"
    End Sub
End Class