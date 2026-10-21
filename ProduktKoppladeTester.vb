Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ProduktkoppladeTesterF
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet, r As Integer, c As Integer, utskrifttyp As String
    Dim Mytimestamp As String
    Private ReadOnly ProvmetodExpanded As New Dictionary(Of Integer, Boolean)

    Private Class ProvmetodRowInfo
        Public Property ItemId As Integer
        Public Property Level As Integer
        Public Property HasChildren As Boolean
    End Class

    Private Sub ProduktkoppladeTesterF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Produktkopplade tester "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsourcel.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + Labdatabasnamn
        Gnamn.Text = Firmanamn
        DataGridView1.DataSource = CreateDataSet.Tables(0).DefaultView
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Gray
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Bold)
        End With
        DataGridView1.Columns(0).Width = 100
        ConfigureProvmetodGrid()
        LoadProvmetodTree()

    End Sub

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub
    Function CreateDataSet() As DataSet

        Dim strConnString, strSQL As String
        strConnString = "DSN=" + odbcsource + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        strSQL = "SELECT Produktkod  FROM Labprodukter "
        strSQL = strSQL + " ORDER BY Produktkod "

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
    Private Sub LoadProvmetodTree()

        Dim items As New DataTable()
        Dim connStr As String =
            "DSN=" & odbcsourcer &
            "; Database=" & Labdatabasnamn &
            ";Uid=v2000;Pwd=" & odbclosen

        Using cn As New OdbcConnection(connStr)
            Dim sql As String =
                "SELECT ItemID, ParentID, ItemName, SortOrder " &
                "FROM dbo.ProvmetodTree " &
                "ORDER BY SortOrder, ItemName"

            Using da As New OdbcDataAdapter(sql, cn)
                da.Fill(items)
            End Using
        End Using

        ProvmetodGrid.Rows.Clear()
        AddProvmetodRows(Nothing, 0, items)
    End Sub

    Private Sub ConfigureProvmetodGrid()
        With ProvmetodGrid
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False
            .RowHeadersVisible = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
            .BackgroundColor = Color.White
            .ColumnHeadersHeight = 30
            .RowTemplate.Height = 26
            .Columns.Clear()
        End With

        Dim expandColumn As New DataGridViewButtonColumn With {
            .Name = "Expand",
            .HeaderText = "",
            .Width = 34,
            .MinimumWidth = 34,
            .Resizable = DataGridViewTriState.False,
            .FlatStyle = FlatStyle.Flat,
            .UseColumnTextForButtonValue = False
        }
        Dim nameColumn As New DataGridViewTextBoxColumn With {
            .Name = "ItemName",
            .HeaderText = "Produkt / del",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            .MinimumWidth = 180,
            .SortMode = DataGridViewColumnSortMode.NotSortable
        }
        ProvmetodGrid.Columns.Add(expandColumn)
        ProvmetodGrid.Columns.Add(nameColumn)

        AddHandler ProvmetodGrid.CellContentClick, AddressOf ProvmetodGrid_CellContentClick
        AddHandler ProvmetodGrid.CellValidating, AddressOf ProvmetodGrid_CellValidating
        AddHandler ProvmetodGrid.CellEndEdit, AddressOf ProvmetodGrid_CellEndEdit
        AddHandler ProvmetodGrid.KeyDown, AddressOf ProvmetodGrid_KeyDown
        AddHandler ProvmetodGrid.DataError, AddressOf ProvmetodGrid_DataError
    End Sub

    Private Sub AddProvmetodRows(parentId As Integer?, level As Integer, items As DataTable)
        For Each row As DataRow In items.Rows
            Dim isChild As Boolean
            If parentId.HasValue Then
                isChild = Not IsDBNull(row("ParentID")) AndAlso CInt(row("ParentID")) = parentId.Value
            Else
                isChild = IsDBNull(row("ParentID"))
            End If

            If Not isChild Then Continue For

            Dim itemId As Integer = CInt(row("ItemID"))
            Dim hasChildren As Boolean = False
            For Each possibleChild As DataRow In items.Rows
                If Not IsDBNull(possibleChild("ParentID")) AndAlso CInt(possibleChild("ParentID")) = itemId Then
                    hasChildren = True
                    Exit For
                End If
            Next

            Dim rowIndex As Integer = ProvmetodGrid.Rows.Add()
            Dim gridRow As DataGridViewRow = ProvmetodGrid.Rows(rowIndex)
            Dim isExpanded As Boolean = ProvmetodExpanded.ContainsKey(itemId) AndAlso ProvmetodExpanded(itemId)
            gridRow.Tag = New ProvmetodRowInfo With {.ItemId = itemId, .Level = level, .HasChildren = hasChildren}
            gridRow.Cells("Expand").Value = If(hasChildren, If(isExpanded, "−", "+"), "")
            gridRow.Cells("ItemName").Value = row("ItemName").ToString()
            gridRow.Cells("ItemName").Style.Padding = New Padding(8 + (level * 20), 0, 0, 0)

            If hasChildren AndAlso isExpanded Then
                AddProvmetodRows(itemId, level + 1, items)
            End If
        Next
    End Sub

    Private Sub ProvmetodGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 OrElse ProvmetodGrid.Columns(e.ColumnIndex).Name <> "Expand" Then Return

        Dim info As ProvmetodRowInfo = TryCast(ProvmetodGrid.Rows(e.RowIndex).Tag, ProvmetodRowInfo)
        If info Is Nothing OrElse Not info.HasChildren Then Return

        Dim currentlyExpanded As Boolean = ProvmetodExpanded.ContainsKey(info.ItemId) AndAlso ProvmetodExpanded(info.ItemId)
        ProvmetodExpanded(info.ItemId) = Not currentlyExpanded
        LoadProvmetodTree()
        SelectProvmetodRow(info.ItemId)
    End Sub

    Private Sub ProvmetodGrid_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs)
        If e.RowIndex < 0 OrElse ProvmetodGrid.Columns(e.ColumnIndex).Name <> "ItemName" Then Return

        If String.IsNullOrWhiteSpace(Convert.ToString(e.FormattedValue)) Then
            ProvmetodGrid.Rows(e.RowIndex).ErrorText = "Produktnamnet får inte vara tomt."
            e.Cancel = True
        Else
            ProvmetodGrid.Rows(e.RowIndex).ErrorText = ""
        End If
    End Sub

    Private Sub ProvmetodGrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 OrElse ProvmetodGrid.Columns(e.ColumnIndex).Name <> "ItemName" Then Return

        Dim gridRow As DataGridViewRow = ProvmetodGrid.Rows(e.RowIndex)
        Dim info As ProvmetodRowInfo = TryCast(gridRow.Tag, ProvmetodRowInfo)
        If info Is Nothing Then Return

        Dim newName As String = Convert.ToString(gridRow.Cells("ItemName").Value).Trim()
        If newName = "" Then Return

        Try
            Dim connStr As String =
                "DSN=" & odbcsourcer &
                "; Database=" & Labdatabasnamn &
                ";Uid=v2000;Pwd=" & odbclosen

            Using cn As New OdbcConnection(connStr)
                cn.Open()
                Dim sql As String = "UPDATE dbo.ProvmetodTree SET ItemName = ? WHERE ItemID = ?"
                Using cmd As New OdbcCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@p1", newName)
                    cmd.Parameters.AddWithValue("@p2", info.ItemId)
                    If cmd.ExecuteNonQuery() = 0 Then Throw New Exception("No matching row was found in the table.")
                End Using
            End Using

            gridRow.Cells("ItemName").Value = newName
        Catch ex As Exception
            MessageBox.Show("Could not save the new name: " & ex.Message)
            LoadProvmetodTree()
            SelectProvmetodRow(info.ItemId)
        End Try
    End Sub

    Private Sub ProvmetodGrid_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.F2 AndAlso ProvmetodGrid.CurrentCell IsNot Nothing AndAlso
           ProvmetodGrid.Columns(ProvmetodGrid.CurrentCell.ColumnIndex).Name = "ItemName" Then
            ProvmetodGrid.BeginEdit(True)
        End If
    End Sub

    Private Sub ProvmetodGrid_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        e.ThrowException = False
    End Sub

    Private Function SelectedProvmetodItem() As ProvmetodRowInfo
        If ProvmetodGrid.CurrentRow Is Nothing Then Return Nothing
        Return TryCast(ProvmetodGrid.CurrentRow.Tag, ProvmetodRowInfo)
    End Function

    Private Sub SelectProvmetodRow(itemId As Integer)
        For Each gridRow As DataGridViewRow In ProvmetodGrid.Rows
            Dim info As ProvmetodRowInfo = TryCast(gridRow.Tag, ProvmetodRowInfo)
            If info IsNot Nothing AndAlso info.ItemId = itemId Then
                ProvmetodGrid.CurrentCell = gridRow.Cells("ItemName")
                gridRow.Selected = True
                Return
            End If
        Next
    End Sub
    Private Sub AddMainItemBT_Click(
    sender As Object,
    e As EventArgs
) Handles AddMainItemBT.Click

        Dim newName As String =
        Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the main item name:",
            "Add main item"
        ).Trim()

        If newName = "" Then Return

        Dim connStr As String =
        "DSN=" & odbcsourcer &
        "; Database=" & Labdatabasnamn &
        ";Uid=v2000;Pwd=" & odbclosen

        Try
            Using cn As New OdbcConnection(connStr)
                cn.Open()

                Dim sql As String =
                "INSERT INTO dbo.ProvmetodTree (ParentID, ItemName, SortOrder) " &
                "VALUES (NULL, ?, 0)"

                Using cmd As New OdbcCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@p1", newName)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadProvmetodTree()

        Catch ex As Exception
            MessageBox.Show("Could not add the main item: " & ex.Message)
        End Try

    End Sub

    Private Sub AddSubItemBT_Click(sender As Object, e As EventArgs) Handles AddSubItemBT.Click

        Dim selectedItem As ProvmetodRowInfo = SelectedProvmetodItem()
        If selectedItem Is Nothing Then
            MessageBox.Show("Select the parent item first.")
            Return
        End If

        Dim newName As String =
            Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the subitem name:",
                "Add subitem"
            ).Trim()

        If newName = "" Then Return

        Dim connStr As String =
            "DSN=" & odbcsourcer &
            "; Database=" & Labdatabasnamn &
            ";Uid=v2000;Pwd=" & odbclosen

        Try
            Using cn As New OdbcConnection(connStr)
                cn.Open()

                Dim sql As String =
                    "INSERT INTO dbo.ProvmetodTree (ParentID, ItemName, SortOrder) " &
                    "VALUES (?, ?, 0)"

                Using cmd As New OdbcCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@p1", selectedItem.ItemId)
                    cmd.Parameters.AddWithValue("@p2", newName)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ProvmetodExpanded(selectedItem.ItemId) = True
            LoadProvmetodTree()
        Catch ex As Exception
            MessageBox.Show("Could not add the subitem: " & ex.Message)
        End Try

    End Sub

    Private Sub DeleteProvmetodBT_Click(
    sender As Object,
    e As EventArgs
) Handles DeleteProvmetodBT.Click

        Dim selectedItem As ProvmetodRowInfo = SelectedProvmetodItem()

        If selectedItem Is Nothing Then
            MessageBox.Show("Select an item to delete.")
            Return
        End If

        Dim selectedName As String = Convert.ToString(ProvmetodGrid.CurrentRow.Cells("ItemName").Value)

        Dim answer = MessageBox.Show(
            "Delete '" & selectedName & "' and all its subitems?",
            "Confirm delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If answer <> DialogResult.Yes Then Return

        Dim connStr As String =
            "DSN=" & odbcsourcer &
            "; Database=" & Labdatabasnamn &
            ";Uid=v2000;Pwd=" & odbclosen

        Try
            Using cn As New OdbcConnection(connStr)
                cn.Open()

                Dim sql As String =
                    ";WITH ItemsToDelete AS (" &
                    " SELECT ItemID FROM dbo.ProvmetodTree WHERE ItemID = ? " &
                    " UNION ALL " &
                    " SELECT child.ItemID " &
                    " FROM dbo.ProvmetodTree AS child " &
                    " INNER JOIN ItemsToDelete AS parent " &
                    " ON child.ParentID = parent.ItemID" &
                    ") " &
                    "DELETE FROM dbo.ProvmetodTree " &
                    "WHERE ItemID IN (SELECT ItemID FROM ItemsToDelete) " &
                    "OPTION (MAXRECURSION 100)"

                Using cmd As New OdbcCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@p1", selectedItem.ItemId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadProvmetodTree()

        Catch ex As Exception
            MessageBox.Show("Could not delete the item: " & ex.Message)
        End Try

    End Sub
End Class
