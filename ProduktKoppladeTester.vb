Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ProduktkoppladeTesterF
    Dim objConn As New System.Data.Odbc.OdbcConnection
    Dim objCmd As New System.Data.Odbc.OdbcCommand
    Dim dtAdapter As New System.Data.Odbc.OdbcDataAdapter
    Dim ds As New DataSet, r As Integer, c As Integer, utskrifttyp As String
    Dim Mytimestamp As String
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

        LoadProvmetodTree()
        ProvmetodTreeView.LabelEdit = True

        ProvmetodTreeView.CollapseAll()

    End Sub

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub

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

        ProvmetodTreeView.Nodes.Clear()
        AddProvmetodNodes(Nothing, Nothing, items)
        ProvmetodTreeView.ExpandAll()

    End Sub

    Private Sub AddProvmetodNodes(
        parentNode As TreeNode,
        parentId As Integer?,
        items As DataTable)

        For Each row As DataRow In items.Rows

            Dim isChild As Boolean

            If parentId.HasValue Then
                isChild = Not IsDBNull(row("ParentID")) AndAlso
                          CInt(row("ParentID")) = parentId.Value
            Else
                isChild = IsDBNull(row("ParentID"))
            End If

            If isChild Then
                Dim itemId As Integer = CInt(row("ItemID"))
                Dim node As New TreeNode(row("ItemName").ToString())

                node.Tag = itemId

                If parentNode Is Nothing Then
                    ProvmetodTreeView.Nodes.Add(node)
                Else
                    parentNode.Nodes.Add(node)
                End If

                AddProvmetodNodes(node, itemId, items)
            End If

        Next

    End Sub
    Private Sub ProvmetodTreeView_KeyDown(
    sender As Object,
    e As KeyEventArgs
) Handles ProvmetodTreeView.KeyDown

        If e.KeyCode = Keys.F2 AndAlso ProvmetodTreeView.SelectedNode IsNot Nothing Then
            ProvmetodTreeView.SelectedNode.BeginEdit()
        End If

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


    Private Sub ProvmetodTreeView_AfterLabelEdit(
    sender As Object,
    e As NodeLabelEditEventArgs
) Handles ProvmetodTreeView.AfterLabelEdit

        If e.Label Is Nothing Then Return

        Dim newName As String = e.Label.Trim()

        If newName = "" Then
            e.CancelEdit = True
            Return
        End If

        Try
            Dim connStr As String =
                "DSN=" & odbcsourcer &
                "; Database=" & Labdatabasnamn &
                ";Uid=v2000;Pwd=" & odbclosen

            Using cn As New OdbcConnection(connStr)
                cn.Open()

                Dim sql As String =
                    "UPDATE dbo.ProvmetodTree SET ItemName = ? WHERE ItemID = ?"

                Using cmd As New OdbcCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@p1", newName)
                    cmd.Parameters.AddWithValue("@p2", CInt(e.Node.Tag))

                    If cmd.ExecuteNonQuery() = 0 Then
                        Throw New Exception("No matching row was found in the table.")
                    End If
                End Using
            End Using

        Catch ex As Exception
            e.CancelEdit = True
            MessageBox.Show("Could not save the new name: " & ex.Message)
        End Try

    End Sub
    Private Sub AddSubItemBT_Click(sender As Object, e As EventArgs) Handles AddSubItemBT.Click

        If ProvmetodTreeView.SelectedNode Is Nothing Then
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

        Using cn As New OdbcConnection(connStr)
            cn.Open()

            Dim sql As String =
                "INSERT INTO dbo.ProvmetodTree (ParentID, ItemName, SortOrder) " &
                "VALUES (?, ?, 0)"

            Using cmd As New OdbcCommand(sql, cn)
                cmd.Parameters.AddWithValue("@p1", CInt(ProvmetodTreeView.SelectedNode.Tag))
                cmd.Parameters.AddWithValue("@p2", newName)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadProvmetodTree()

    End Sub

    Private Sub DeleteProvmetodBT_Click(
    sender As Object,
    e As EventArgs
) Handles DeleteProvmetodBT.Click

        Dim selectedNode As TreeNode = ProvmetodTreeView.SelectedNode

        If selectedNode Is Nothing Then
            MessageBox.Show("Select an item to delete.")
            Return
        End If

        Dim answer = MessageBox.Show(
            "Delete '" & selectedNode.Text & "' and all its subitems?",
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
                    cmd.Parameters.AddWithValue("@p1", CInt(selectedNode.Tag))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadProvmetodTree()

        Catch ex As Exception
            MessageBox.Show("Could not delete the item: " & ex.Message)
        End Try

    End Sub
End Class