Imports System.Data.Odbc

Public Class ViskositetF
    Private Sub ViskositetF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - BesökRegister "
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsourcel.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + Labdatabasnamn
        Gnamn.Text = Firmanamn
        Hamptaprodukter()
    End Sub

    Sub Hamptaprodukter()
        Dim dummy As String
        Dim connStr As String = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen


        Dim mySQL As String = "SELECT Produktkod FROM Labprodukter ORDER BY Produktkod"

        ProdIDCB.Items.Clear()
        ProdIDCB.Text = "Välj produktkod"

        Using cn As New OdbcConnection(connStr)
            cn.Open()

            Using myCmd As New OdbcCommand(mySQL, cn)

                Using tabel As OdbcDataReader = myCmd.ExecuteReader()

                    While tabel.Read()

                        dummy = nullhantering(tabel("Produktkod"), "S")

                        ProdIDCB.Items.Add(nullhantering(tabel("Produktkod"), "S"))
                    End While

                End Using
            End Using
        End Using

    End Sub
End Class