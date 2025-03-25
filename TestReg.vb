Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Net.Security
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TestregF
    Dim dbkontonr As String = ""
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet, r As Integer, c As Integer, utskrifttyp As String
    Dim builder As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter)
    Dim pagenr As Integer, engang As Integer
    Dim dummy As Integer






    Private Sub SparaB_Click(sender As Object, e As EventArgs) Handles SparaB.Click

        Dim cn As OdbcConnection, mySQL As String, visc As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "DELETE FROM Labtester "
        mySQL = mySQL + " Where Provnamn = '" + TestNamnTB.Text + "' "

        Dim myCmd As New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()

        falt = "" : varden = ""
        mySQL = "INSERT INTO  Labtester "
        falt = falt + "Provnamn,"
        varden = varden + "'" + kommatillpunkt(TestNamnTB.Text) + "',"
        falt = falt + "Text,"
        varden = varden + "'" + kommatillpunkt(TextTB.Text) + "',"
        falt = falt + "Tolerans,"
        varden = varden + "'" + kommatillpunkt(ToleransTB.Text) + "',"
        falt = falt + "Info,"
        varden = varden + "'" + kommatillpunkt(InfoTB.Text) + "',"
        falt = falt + "StdVarde2,"
        If HanteraViscCB.Checked = True Then
            visc = "Visc"
        Else
            visc = ""
        End If
        varden = varden + "'" + kommatillpunkt(visc) + "',"
        falt = falt + "TestBildID"
        If ColorCB.Checked = True Then
            colorprov = "Färg"
        Else
            colorprov = ""
        End If
        varden = varden + "'" + kommatillpunkt(colorprov) + "' "
        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        myCmd = New OdbcCommand(mySQL, cn)
        myCmd.ExecuteNonQuery()
        cn.Close()
        DataGridView1.DataSource.Table.Rows.Clear()
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub RaderaB_Click(sender As Object, e As EventArgs) Handles RaderaB.Click
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim response
        response = MsgBox("Vill du verkligen radera testet", 1, "OBS")
        If response = 1 Then    ' User chose Yes.
            connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
            cn = New OdbcConnection(connStr)
            cn.Open()
            mySQL = "DELETE FROM Labtester "
            mySQL = mySQL + " Where Provnamn = '" + TestNamnTB.Text + "' "

            Dim myCmd As New OdbcCommand(mySQL, cn)
            myCmd.ExecuteNonQuery()
            DataGridView1.DataSource.Table.Rows.Clear()
            DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
            nolla()
        Else
        End If

    End Sub

    Private Sub TestregF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Testregister "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsource.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + databasnamn
        Gnamn.Text = Firmanamn

        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.RowHeadersWidth = 5
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).HeaderText = "Produkt"
        DataGridView1.Columns(1).Width = 60
        DataGridView1.Columns(1).HeaderText = "Enhet"

        DataGridView1.Columns(2).HeaderText = "Komment"
        DataGridView1.Columns(2).Width = 80
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(3).HeaderText = "Metod"
        DataGridView1.Columns(4).Width = 0
        DataGridView1.Columns(5).Width = 0
        'Me.DataGridView1.Columns.Item(9).DefaultCellStyle.Format = "n2"

        'DataGridView1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DataGridView1.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Label1.Text = "Enhet"
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        TextTB.Height = 22

        AvslutaK.Select()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Huvud_Click(sender As Object, e As EventArgs) Handles Huvud.Click
        TextTB.SelectionStart = 0
        TextTB.SelectionLength = 0
        TextTB.Focus()


    End Sub

    Private Sub Info1L_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KundDokB_Click(sender As Object, e As EventArgs) Handles KundDokB.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = ""
        fd.Title = "Open File Dialog"
        fd.InitialDirectory = labmap

        'checkfor files
        fd.Filter = "All files (*.pdf)|*.pdf|All files (*.pdf)|*.pdf"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            strFileName = Strings.Right(strFileName, Len(strFileName) - 15)
            strFileName = Strings.Left(strFileName, Len(strFileName) - 4)
            InfoTB.Text = strFileName
            ' System.Diagnostics.Process.Start(strFileName)
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextTB_TextChanged(sender As Object, e As EventArgs) Handles TextTB.TextChanged
        Dim dummy As Integer
        dummy = CountCharacter(TextTB.Text, Chr(10))
        Label10.Text = dummy
        If dummy > 3 Then
            TextTB.SelectionStart = 0
            TextTB.SelectionLength = 0
            TextTB.Focus()
        End If
    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub HanteraViscCB_CheckedChanged(sender As Object, e As EventArgs) Handles HanteraViscCB.CheckedChanged
        If Label1.Text = "Mätkopp" Then
            Label1.Text = "Enhet"
            Label9.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            TextTB.Height = 22
        Else
            Label1.Text = "Mätkopp"
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            TextTB.Height = 80
            Label9.Visible = True
        End If
    End Sub

    Function CreateDataSet() As DataSet

        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "SELECT * FROM Labtester "
        strSQL = strSQL + "  order by Provnamn"

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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim r2 As Integer, c2 As Integer, visc As String
        nolla()
        r2 = Me.DataGridView1.CurrentRow.Index
        c2 = DataGridView1.CurrentCell.ColumnIndex
        TestNamnTB.Text = nullhantering(DataGridView1.Item(0, r2).Value, "S")
        TextTB.Text = nullhantering(DataGridView1.Item(1, r2).Value, "S")
        ToleransTB.Text = nullhantering(DataGridView1.Item(2, r2).Value, "S")
        InfoTB.Text = nullhantering(DataGridView1.Item(3, r2).Value, "S")

        visc = nullhantering(DataGridView1.Item(4, r2).Value, "S")
        If visc = "Visc" Then
            HanteraViscCB.Checked = True
        Else
            HanteraViscCB.Checked = False
        End If
        colorprov = nullhantering(DataGridView1.Item(5, r2).Value, "S")
        If colorprov = "Färg" Then
            ColorCB.Checked = True
        Else
            ColorCB.Checked = False
        End If

        'DataGridView1.Focus()
    End Sub

    Function CountCharacter(value As String, ch As String) As Integer

        CountCharacter = 0

        While InStr(value, ch) > 0
            value = Strings.Right(value, (Len(value) - InStr(value, ch)))
            CountCharacter = CountCharacter + 1

        End While

    End Function




    Sub nolla()
        HanteraViscCB.Checked = False
        Label1.Text = "Enhet"
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        TextTB.Height = 22

        TestNamnTB.Text = ""
        TextTB.Text = ""
        ToleransTB.Text = ""
        InfoTB.Text = ""
        Stdvarde2TB.Text = ""

        colorprov = ""
    End Sub
End Class