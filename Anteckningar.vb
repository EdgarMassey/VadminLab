Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Runtime.ConstrainedExecution
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AnteckningarF
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet, r As Integer, c As Integer, utskrifttyp As String
    Dim Mytimestamp As String



    Dim builder As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter)

    Private Sub SparaB_Click(sender As Object, e As EventArgs) Handles SparaB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM Notes "
        mySQL = mySQL + " Where TimeStamp = '" + Mytimestamp + "' "

        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  Notes "
        falt = falt + "Timestamp,"
        varden = varden + "'" + kommatillpunkt(Mytimestamp) + "',"
        falt = falt + "Datum,"
        varden = varden + "'" + kommatillpunkt(DatumTB.Text) + "',"
        falt = falt + "Text "

        varden = varden + "'" + kommatillpunkt(AnteckningarTB.Text) + "'  "

        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()

        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        Labdatabasnamn = "NMLab"
    End Sub

    Private Sub NyB_Click(sender As Object, e As EventArgs) Handles NyB.Click
        Mytimestamp = gettimestamp()
        DatumTB.Text = today '
        AnteckningarTB.Text = ""
    End Sub

    Private Sub RaderaB_Click(sender As Object, e As EventArgs) Handles RaderaB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim response
        response = MsgBox("Vill du verkligen radera Anteckningen", 1, "OBS")
        If response = 1 Then    ' User chose Yes.
            connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM Notes "
            mySQL = mySQL + " Where Timestamp = '" + Mytimestamp + "' "

            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()
            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
            nolla()
        Else
        End If

    End Sub
    Sub nolla()
        Mytimestamp = ""
        DatumTB.Text = ""
        AnteckningarTB.Text = ""
    End Sub

    Private Sub SoktextTB_TextChanged(sender As Object, e As EventArgs) Handles SoktextTB.TextChanged

    End Sub

    Private Sub AnteckningarF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Anteckningar "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID

        odbcsourcel.Text = "ODBCsource:" + odbcsource
        databas.Text = "Databasnamn:" + Labdatabasnamn
        Gnamn.Text = Firmanamn
        DatTomTB.Text = today
        DatFromTB.Text = Date.ParseExact(today, "yyyy-MM-dd", Nothing).AddYears(-1).ToString("yyyy-MM-dd")
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.Columns(0).Width = 0
        DataGridView1.Columns(1).Width = 80
        DataGridView1.Columns(2).Width = 900

    End Sub
    Function CreateDataSet() As DataSet

        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "SELECT * FROM Notes "
        strSQL = strSQL + " Where datum >= '" + DatFromTB.Text + "' and datum <= '" + DatTomTB.Text + "' "

        If SoktextTB.Text <> "" Then
            strSQL = strSQL + "And CHARINDEX('" + SoktextTB.Text + "', Text) > 0 "
            ' WHERE CHARINDEX('shortstring', LongTextColumn) > 0
        End If

        strSQL = strSQL + "  order by Datum desc"

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

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub

    Private Sub DatFromTB_TextChanged(sender As Object, e As EventArgs) Handles DatFromTB.TextChanged

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim r2 As Integer, c2 As Integer, dummy As String
        r2 = Me.DataGridView1.CurrentRow.Index
        c2 = DataGridView1.CurrentCell.ColumnIndex
        Mytimestamp = nullhantering(DataGridView1.Item(0, r2).Value, "S")
        DatumTB.Text = nullhantering(DataGridView1.Item(1, r2).Value, "S")

        dummy = nullhantering(DataGridView1.Item(2, r2).Value, "S")
        dummy = dummy.Replace(Chr(10), vbCrLf)
        AnteckningarTB.Text = dummy
    End Sub

    Private Sub DatTomTB_TextChanged(sender As Object, e As EventArgs) Handles DatTomTB.TextChanged

    End Sub

    Private Sub SoktextTB_KeyUp(sender As Object, e As KeyEventArgs) Handles SoktextTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            CreateDataSet()
            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        End If
    End Sub

    Private Sub SoktextTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SoktextTB.KeyPress

    End Sub

    Private Sub DatFromTB_KeyUp(sender As Object, e As KeyEventArgs) Handles DatFromTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            CreateDataSet()
            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        End If
    End Sub

    Private Sub DatTomTB_KeyUp(sender As Object, e As KeyEventArgs) Handles DatTomTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            CreateDataSet()
            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        End If
    End Sub
End Class