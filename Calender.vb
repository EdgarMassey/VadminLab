Imports System.Globalization
Imports System
Imports System.Data.Common
Imports System.Data.Odbc





Public Class CalenderF
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet, r As Integer, c As Integer, utskrifttyp As String
    Dim ds2 As New DataSet
    Dim builder As OdbcCommandBuilder = New OdbcCommandBuilder(dtAdapter)
    Dim cdatum As String
    Dim Owner0 As String = "", Owner1 As String = "", Owner2 As String = "", Owner3 As String = "", Owner4 As String = ""
    Dim Caltyp0 As String = "", Caltyp1 As String = "", Caltyp2 As String = "", Caltyp3 As String = "", Caltyp4 As String = ""
    Private Sub CalenderF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)
        HamtaTyp()
        HamtaOwners()
        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Calender "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsourcel.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + databasnamn
        Gnamn.Text = Firmanamn
        Dim datu As String
        datu = today
        cdatum = today
        ''''Calender grid
        makegrid()
        Getmonth(datu)
        SpecDatum.Text = today


        HamtaOwners()

        'Owner0 = "Alla"
        'Owner1 = "Gunnar"
        'Owner2 = "Lars"
        'Owner3 = "Jonny"
        'Owner4 = "Edgar"
        If Len(Owner0) < 2 Then Owner0 = "Alla"
        If Len(Owner1) < 2 Then Owner1 = "Ingen"
        If Len(Owner2) < 2 Then Owner2 = "Ingen"
        If Len(Owner3) < 2 Then Owner3 = "Ingen"
        If Len(Owner4) < 2 Then Owner4 = "Ingen"
        CheckedListBox2.Items.Insert(0, Owner0) : CheckedListBox2.SetItemChecked(0, True)
        CheckedListBox2.Items.Insert(1, Owner1) : CheckedListBox2.SetItemChecked(1, False)
        CheckedListBox2.Items.Insert(2, Owner2) : CheckedListBox2.SetItemChecked(2, False)
        CheckedListBox2.Items.Insert(3, Owner3) : CheckedListBox2.SetItemChecked(3, False)
        CheckedListBox2.Items.Insert(4, Owner4) : CheckedListBox2.SetItemChecked(4, False)
        '  setting checkedlistbox values
        ' HamtaTyp()

        'Caltyp0 = "Alla"
        'Caltyp1 = "Underhåll"
        'Caltyp2 = " "
        'Caltyp3 = "BESÖKANDE"
        'Caltyp4 = "Födelsedagar"
        If Len(Caltyp0) < 2 Then Caltyp0 = "Alla"
        If Len(Caltyp1) < 2 Then Caltyp1 = "Ingen"
        If Len(Caltyp2) < 2 Then Caltyp2 = "Ingen"
        If Len(Caltyp3) < 2 Then Caltyp3 = "Ingen"
        If Len(Caltyp4) < 2 Then Caltyp4 = "Födelsedagar"

        CheckedListBox1.Items.Insert(0, Caltyp0) : CheckedListBox1.SetItemChecked(0, True)
        CheckedListBox1.Items.Insert(1, Caltyp1) : CheckedListBox1.SetItemChecked(1, False)
        CheckedListBox1.Items.Insert(2, Caltyp2) : CheckedListBox1.SetItemChecked(2, False)
        CheckedListBox1.Items.Insert(3, Caltyp3) : CheckedListBox1.SetItemChecked(3, False)
        CheckedListBox1.Items.Insert(4, Caltyp4) : CheckedListBox1.SetItemChecked(4, False)
        ''''''''''''''''''''''''''Fixar att en klick räcker istället för 2 i komboboxes
        DataGridView2.EditMode = DataGridViewEditMode.EditOnEnter
        '''''''''''''''''Dag view grid
        DataGridView2.DataSource = CreateDataSet.Tables(0).DefaultView
        SetupDataGridView()
        With DataGridView2.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView2.Font, FontStyle.Bold)
        End With
        DataGridView2.RowHeadersWidth = 12
        DataGridView2.Columns(0).Width = 0
        DataGridView2.Columns(1).HeaderText = "Datum"
        DataGridView2.Columns(1).Width = 80
        DataGridView2.Columns(2).HeaderText = "Tid"
        DataGridView2.Columns(2).Width = 80
        DataGridView2.Columns(3).Width = 300
        DataGridView2.Columns(3).HeaderText = "Text"
        DataGridView2.Columns(4).Width = 80
        DataGridView2.Columns(5).Width = 80
        datumpicker(today)

        '''''''''Nästkommande events
        DataGridView3.DataSource = CreateDataSet2.Tables(0).DefaultView
        With DataGridView3.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView3.Font, FontStyle.Bold)
        End With
        DataGridView3.RowHeadersWidth = 12
        DataGridView3.Columns(0).Width = 0
        DataGridView3.Columns(1).HeaderText = "Datum"
        DataGridView3.Columns(1).Width = 80
        DataGridView3.Columns(2).HeaderText = "Tid"
        DataGridView3.Columns(2).Width = 80
        DataGridView3.Columns(3).Width = 300
        DataGridView3.Columns(3).HeaderText = "Text"
        DataGridView3.Columns(4).Width = 80
        DataGridView3.Columns(5).Width = 80

        AddHandler DataGridView3.RowPrePaint, AddressOf DataGridView3_RowPrePaint

    End Sub
    Private Sub DataGridView3_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs)
        ' Change row color based on the value in the first column
        If (DataGridView3.Rows(e.RowIndex).Cells(1).Value) = today Then
            DataGridView3.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
        End If
    End Sub

    Function CreateDataSet() As DataSet
        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "Select * FROM Calender "
        strSQL = strSQL + " Where datum ='" + cdatum + "' "
        strSQL = strSQL + "  order by MyTimeStamp"

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
    ''' '''''''''Setup för datagridview2
    Private Sub SetupDataGridView()
        DataGridView2.DataSource = CreateDataSet.Tables(0).DefaultView
        Dim comboBoxColumn As New DataGridViewComboBoxColumn()
        comboBoxColumn.DataPropertyName = "Owner"
        comboBoxColumn.HeaderText = "Owner"
        comboBoxColumn.Name = "Owner"
        DataGridView2.Columns.Remove("Owner")
        comboBoxColumn.Items.AddRange(Owner0, Owner1, Owner2, Owner3, Owner4)
        DataGridView2.Columns.Insert(5, comboBoxColumn)
        Dim comboBoxColumn2 As New DataGridViewComboBoxColumn()
        comboBoxColumn2.DataPropertyName = "KalenderTyp"
        comboBoxColumn2.HeaderText = "KalenderTyp"
        comboBoxColumn2.Name = "KalenderTyp"
        DataGridView2.Columns.Remove("KalenderTyp")
        comboBoxColumn2.Items.AddRange(Caltyp0, Caltyp1, Caltyp2, Caltyp3, Caltyp4)
        DataGridView2.Columns.Insert(4, comboBoxColumn2)
    End Sub
    Function CreateDataSet2() As DataSet
        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "Select * FROM Calender "
        strSQL = strSQL + " Where datum  >= '" + today + "' "
        strSQL = strSQL + "  order by datum,mytimestamp "

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
    Sub DataGridView2_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        If TypeOf e.Control Is ComboBox Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            combo.DropDownStyle = ComboBoxStyle.Simple
        End If
    End Sub
    Sub makegrid()
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()
        DataGridView1.Height = 280
        DataGridView1.Width = 660
        DataGridView1.RowTemplate.Height = 40
        With (Me.DataGridView1.Columns)
            .Add("", "Veckan")
            .Add("", "Måndag")
            .Add("", "Tisdag")
            .Add("", "Onsdag")
            .Add("", "Torsdag")
            .Add("", "Fredag")
            .Add("", "Lördag")
            .Add("", "Söndag")
            DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.DataGridView1.DefaultCellStyle.Font = New Font("Tahoma", 15)
        End With
        With Me.DataGridView1.Rows
            For r = 0 To 5
                .Add("")
            Next r
        End With
        DataGridView1.CurrentCell = DataGridView1.Item(0, 0)
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.RowHeadersWidth = 22
        DataGridView1.Columns(0).Width = 40 'Veckan
        DataGridView1.Columns(1).Width = 84 'Måndag
        DataGridView1.Columns(2).Width = 84 'Tisdag
        DataGridView1.Columns(3).Width = 84 'Onsdag
        DataGridView1.Columns(4).Width = 84 'Torsdag
        DataGridView1.Columns(5).Width = 84 'Fredag
        DataGridView1.Columns(6).Width = 84 'Lördag
        DataGridView1.Columns(7).Width = 84 'Söndag
    End Sub
    Sub datefunctions()
        ' Gets the Calendar instance associated with a CultureInfo.
        Dim myCI As New CultureInfo("sv-SE")
        Dim myCal As Calendar = myCI.Calendar
        Dim calenderweekrule As String, Firstweekday As String, currentweek As String
        ' Gets the DTFI properties required by GetWeekOfYear.
        Dim myCWR As CalendarWeekRule = myCI.DateTimeFormat.CalendarWeekRule
        Dim myFirstDOW As DayOfWeek = myCI.DateTimeFormat.FirstDayOfWeek
        ' Displays the number of the current week relative to the beginning of the year.
        calenderweekrule = myCWR
        Firstweekday = myFirstDOW
        currentweek = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW)
        ' Displays the total number of weeks in the current year.
        Dim LastDay = New System.DateTime(DateTime.Now.Year, 12, 31)
    End Sub
    Function getdayofweek(datum As String)
        Dim ar As Integer, m As Integer, d As Integer
        ar = CInt(Strings.Left(datum, 4)) : m = CInt(Strings.Mid(datum, 6, 2)) : d = CInt(Strings.Right(datum, 2))
        Dim specificDate As New DateTime(ar, m, d) ' Example date: July 1, 2023
        'Dim specificDate As New DateTime(2023, 7, 1) ' Example date: July 1, 2023
        Dim specificDayOfWeek As DayOfWeek = specificDate.DayOfWeek
        Console.WriteLine("July 1, 2023 was a: " & specificDayOfWeek.ToString())
        getdayofweek = specificDayOfWeek.ToString()
    End Function
    Function getweeknr(datum As String)
        Dim ar As Integer, m As Integer, d As Integer
        ar = CInt(Strings.Left(datum, 4)) : m = CInt(Strings.Mid(datum, 6, 2)) : d = CInt(Strings.Right(datum, 2))

        Dim specificDate As New DateTime(ar, m, d) ' Example date: July 1, 2023
        Dim specificWeekNumber As Integer = GetWeekNumber(specificDate)
        getweeknr = specificWeekNumber
    End Function
    Function GetWeekNumber(dateValue As DateTime) As Integer
        Dim culture As CultureInfo = CultureInfo.CurrentCulture
        Dim calendar As Calendar = culture.Calendar
        Dim dateTimeFormat As DateTimeFormatInfo = culture.DateTimeFormat
        Dim weekNumber As Integer = calendar.GetWeekOfYear(dateValue, dateTimeFormat.CalendarWeekRule, dateTimeFormat.FirstDayOfWeek)
        Return weekNumber
    End Function
    Function daysinmonth(datum As String)
        Dim ar As Integer, m As Integer, d As Integer
        ar = CInt(Strings.Left(datum, 4)) : m = CInt(Strings.Mid(datum, 6, 2)) : d = CInt(Strings.Right(datum, 2))
        Dim year As Integer = ar
        Dim month As Integer = m
        daysinmonth = DateTime.DaysInMonth(year, month)
    End Function

    Private Sub Huvud_Click(sender As Object, e As EventArgs) Handles Huvud.Click
        HamtaOwners()
    End Sub

    Private Sub RaderaradB_Click(sender As Object, e As EventArgs) Handles RaderaradB.Click

        ' Check if there is a selected row
        If DataGridView2.SelectedRows.Count > 0 Then
            ' Remove the selected row
            DataGridView2.Rows.RemoveAt(DataGridView2.SelectedRows(0).Index)
        Else
            MessageBox.Show("Markera eventraden att radera")
        End If
        Dim changes As DataSet
        changes = ds.GetChanges()
        If changes IsNot Nothing Then
            dtAdapter.Update(ds.Tables(0))
        End If
        ds.AcceptChanges()

        DataGridView3.DataSource.Table.Rows.Clear()
        DataGridView3.DataSource = CreateDataSet2.Tables(0).DefaultView
    End Sub

    Private Sub CalendertypB_Click(sender As Object, e As EventArgs) Handles CalendertypB.Click
        CalenderTypF.Show()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub CalenderOwnerB_Click(sender As Object, e As EventArgs) Handles CalenderOwnerB.Click
        CalenderOwnerF.Show()
    End Sub

    Function Getmonth(Month) As String
        Dim dag As String, monthlength As Integer = 0
        Dim posit As Integer, weeknr As Integer, datu As Integer
        Dim MonthFirstday As String, datum As String
        MonthFirstday = Strings.Left(Month, 8) + "01"
        dag = getdayofweek(MonthFirstday)
        ' SpecDatum.Text = Strings.Left(Month, 8) + "01"
        monthlength = daysinmonth(Month)
        For x = 0 To 6
            DataGridView1.Item(1, x).Value = ""
            DataGridView1.Item(2, x).Value = ""
            DataGridView1.Item(3, x).Value = ""
            DataGridView1.Item(4, x).Value = ""
            DataGridView1.Item(5, x).Value = ""
            DataGridView1.Item(6, x).Value = ""
            DataGridView1.Item(7, x).Value = ""
        Next

        If dag = "Monday" Then
            posit = 1
        ElseIf dag = "Tuesday" Then
            posit = 2
        ElseIf dag = "Wednesday" Then
            posit = 3
        ElseIf dag = "Thursday" Then
            posit = 4
        ElseIf dag = "Friday" Then
            posit = 5
        ElseIf dag = "Saturday" Then
            posit = 6
        ElseIf dag = "Sunday" Then
            posit = 7
        End If

        datu = 1
        datum = Strings.Left(Month, 8) + "01"
        DatumTB.Text = Strings.Left(Month, 7)
        weeknr = GetWeekNumber(datum)
        For m = 0 To 5
            DataGridView1.Item(0, m).Value = weeknr
            If posit = 1 And m = 0 Then GoTo Monday
            If posit = 2 And m = 0 Then GoTo Tuesday
            If posit = 3 And m = 0 Then GoTo Wednesday
            If posit = 4 And m = 0 Then GoTo Thursday
            If posit = 5 And m = 0 Then GoTo Friday
            If posit = 6 And m = 0 Then GoTo Saturday
            If posit = 7 And m = 0 Then GoTo Sunday

Monday:
            DataGridView1.Item(1, m).Value = CStr(datu)
            posit = posit + 1 : datu = datu + 1 : If monthlength < datu Then GoTo endloop
Tuesday:
            DataGridView1.Item(2, m).Value = CStr(datu)
            posit = posit + 1 : datu = datu + 1 : If monthlength < datu Then GoTo endloop
Wednesday:
            DataGridView1.Item(3, m).Value = CStr(datu)
            posit = posit + 1 : datu = datu + 1 : If monthlength < datu Then GoTo endloop
Thursday:
            DataGridView1.Item(4, m).Value = CStr(datu)
            posit = posit + 1 : datu = datu + 1 : If monthlength < datu Then GoTo endloop
Friday:
            DataGridView1.Item(5, m).Value = CStr(datu)
            posit = posit + 1 : datu = datu + 1 : If monthlength < datu Then GoTo endloop
Saturday:
            DataGridView1.Item(6, m).Value = CStr(datu)
            posit = posit + 1 : datu = datu + 1 : If monthlength < datu Then GoTo endloop
Sunday:
            DataGridView1.Item(7, m).Value = CStr(datu)
            posit = posit + 1 : datu = datu + 1 : If monthlength < datu Then GoTo endloop

            If posit > 7 Then posit = 1 : weeknr = weeknr + 1
        Next
endloop:
        Getmonth = "OK"
    End Function

    Function datumpicker(datum As String)
        'Dim datum As String
        'datum = CStr(DateTimePicker1.Value)
        'datum = "2024-07-01"
        'datum = Strings.Left(datum, 10)
        SpecDatum.Text = datum
        cdatum = SpecDatum.Text
        Getmonth(datum)
        cdatum = datum
        DataGridView2.DataSource.Table.Rows.Clear()
        CreateDataSet()
    End Function

    Private Sub AvslutaB_Click(sender As Object, e As EventArgs) Handles AvslutaB.Click
        Me.Close()

    End Sub

    Private Sub NastaB_Click(sender As Object, e As EventArgs) Handles NastaB.Click
        Dim Nastamonth As String, mont As Integer, year As Integer
        Dim month As String
        Nastamonth = DatumTB.Text
        'Nastamonth = "2024-12"
        mont = Val(Strings.Right(Nastamonth, 2))
        year = Val(Strings.Left(Nastamonth, 4))



        If mont < 13 Then mont = mont + 1
        If mont > 12 Then year = year + 1 : mont = 1 : 

        If mont < 10 Then month = "0" + CStr(mont) Else month = CStr(mont)
        Nastamonth = CStr(year) + "-" + month + "-01"

        Getmonth(Nastamonth)
        SpecDatum.Text = Nastamonth
        datumpicker(Nastamonth)
    End Sub

    Private Sub TidigareB_Click(sender As Object, e As EventArgs) Handles TidigareB.Click
        Dim Tidigaremonth As String, mont As Integer, year As Integer
        Dim month As String
        Tidigaremonth = DatumTB.Text

        mont = Val(Strings.Right(Tidigaremonth, 2))
        year = Val(Strings.Left(Tidigaremonth, 4))



        If mont < 13 Then mont = mont - 1
        If mont < 1 Then year = year - 1 : mont = 12 : 

        If mont < 10 Then month = "0" + CStr(mont) Else month = CStr(mont)
        Tidigaremonth = CStr(year) + "-" + month + "-01"



        Getmonth(Tidigaremonth)
        SpecDatum.Text = Tidigaremonth
        datumpicker(Tidigaremonth)
    End Sub



    Private Sub SparaB_Click(sender As Object, e As EventArgs) Handles SparaB.Click
        Dim changes As DataSet
        changes = ds.GetChanges()
        If changes IsNot Nothing Then
            dtAdapter.Update(ds.Tables(0))
        End If
        ds.AcceptChanges()

        DataGridView3.DataSource.Table.Rows.Clear()
        DataGridView3.DataSource = CreateDataSet2.Tables(0).DefaultView
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView3.DataSource.Table.Rows.Clear()
        DataGridView3.DataSource = CreateDataSet2.Tables(0).DefaultView

    End Sub

    Private Sub DatumTB_TextChanged(sender As Object, e As EventArgs) Handles DatumTB.TextChanged
        If Val(Strings.Right(DatumTB.Text, 2)) = 1 Then
            MonthnameTB.Text = "januari"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 2 Then
            MonthnameTB.Text = "februari"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 3 Then
            MonthnameTB.Text = "mars"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 4 Then
            MonthnameTB.Text = "april"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 5 Then
            MonthnameTB.Text = "maj"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 6 Then
            MonthnameTB.Text = "juni"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 7 Then
            MonthnameTB.Text = "juli"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 8 Then
            MonthnameTB.Text = "augusti"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 9 Then
            MonthnameTB.Text = "september"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 10 Then
            MonthnameTB.Text = "october"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 11 Then
            MonthnameTB.Text = "novenber"
        ElseIf Val(Strings.Right(DatumTB.Text, 2)) = 12 Then
            MonthnameTB.Text = "december"
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim cday As String
        r = Me.DataGridView1.CurrentRow.Index
        c = DataGridView1.CurrentCell.ColumnIndex
        cday = DataGridView1.Item(c, r).Value
        If Len(cday) = 1 Then cday = "0" + cday
        cday = DatumTB.Text + "-" + cday

        datumpicker(cday)
    End Sub


    Private Sub DataGridView2_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView2.UserAddedRow
        DataGridView2.Item(0, Me.DataGridView2.CurrentRow.Index).Value = gettimestamp()
        DataGridView2.Item(1, Me.DataGridView2.CurrentRow.Index).Value = SpecDatum.Text
        DataGridView2.Item(2, Me.DataGridView2.CurrentRow.Index).Value = "08:00"
        DataGridView2.Item(4, Me.DataGridView2.CurrentRow.Index).Value = "Alla"
        DataGridView2.Item(5, Me.DataGridView2.CurrentRow.Index).Value = "Alla"

    End Sub


    Sub HamtaOwners()
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        Dim order As String, typnamn As String
        Owner0 = "" : Owner1 = "" : Owner2 = "" : Owner3 = "" : Owner4 = ""
        connStr = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM Calenderowners"
        mySQL = mySQL + " Order by typorder  "

        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteNonQuery()

        If tabel.HasRows = False Then
            GoTo slut
        Else
            While tabel.Read()
                order = nullhantering(tabel("typorder"), "S")
                typnamn = nullhantering(tabel("typnamn"), "S")

                If order = "1" Then Owner0 = typnamn
                If order = "2" Then Owner1 = typnamn
                If order = "3" Then Owner2 = typnamn
                If order = "4" Then Owner3 = typnamn
                If order = "5" Then Owner4 = typnamn
            End While
        End If
        cn.Close()
slut:

    End Sub
    Sub HamtaTyp()
        '        Dim cn As OdbcConnection, mySQL As String
        '        Dim connStr As String
        '        Dim order As String, typnamn As String
        '        Owner0 = "" : Owner1 = "" : Owner2 = "" : Owner3 = "" : Owner4 = ""
        '        connStr = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        '        cn = New OdbcConnection(connStr)
        '        cn.Open()
        '        mySQL = "SELECT * FROM CalenderTyp"
        '        mySQL = mySQL + " Order by typorder  "

        '        Dim myCmd As New OdbcCommand(mySQL, cn)
        '        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        '        'myCmd.ExecuteNonQuery()

        '        If tabel.HasRows = False Then
        '            GoTo slut
        '        Else
        '            While tabel.Read()
        '                order = nullhantering(tabel("typorder"), "S")
        '                typnamn = nullhantering(tabel("typnamn"), "S")

        '                If order = "1" Then Caltyp0 = typnamn
        '                If order = "2" Then Caltyp1 = typnamn
        '                If order = "3" Then Caltyp2 = typnamn
        '                If order = "4" Then Caltyp3 = typnamn
        '                If order = "5" Then Caltyp4 = typnamn
        '            End While
        '        End If
        '        cn.Close()
        'slut:

    End Sub
End Class

