Imports System.Globalization
Imports System
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Runtime.ConstrainedExecution

Public Class CalenderOwnerF
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Private Sub CalenderOwnerF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''''''''Nästkommande events
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.RowHeadersWidth = 20
        DataGridView1.Columns(0).Width = 0
        DataGridView1.Columns(1).Width = 40
        DataGridView1.Columns(1).HeaderText = "Order"
        DataGridView1.Columns(2).HeaderText = "Namn"

    End Sub
    Function CreateDataSet() As DataSet
        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "Select * FROM CalenderOwners "

        strSQL = strSQL + "  order by typorder"

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value = gettimestamp()
    End Sub

    Private Sub SparaB_Click(sender As Object, e As EventArgs) Handles SparaB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM CalenderOwners "
        mySQL = mySQL + " Where TypOrder= '" + OrderTB.Text + "' "

        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  CalenderOwners"
        falt = falt + "MyTimeStamp,"
        varden = varden + "'" + gettimestamp() + "',"
        falt = falt + "TypOrder,"
        varden = varden + "'" + OrderTB.Text + "',"
        falt = falt + "TypNamn "
        varden = varden + "'" + OwnerTB.Text + "' "



        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()

        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim r2 As Integer, c2 As Integer
        r2 = Me.DataGridView1.CurrentRow.Index
        c2 = DataGridView1.CurrentCell.ColumnIndex
        OrderTB.Text = nullhantering(DataGridView1.Item(1, r2).Value, "S")
        OwnerTB.Text = nullhantering(DataGridView1.Item(2, r2).Value, "S")


    End Sub

    Private Sub RaderaB_Click(sender As Object, e As EventArgs) Handles RaderaB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim response
        response = MsgBox("Vill du verkligen radera denna post", 1, "OBS")
        If response = 1 Then    ' User chose Yes.
            connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM CalenderOwners "
            mySQL = mySQL + " Where TypOrder= '" + OrderTB.Text + "' "

            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()
            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView

        Else
        End If
    End Sub

    Private Sub AvslutaB_Click(sender As Object, e As EventArgs) Handles AvslutaB.Click
        Me.Close()
    End Sub
End Class