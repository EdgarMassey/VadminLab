Imports System.Data.Odbc
Imports System.Runtime.ConstrainedExecution
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class StatistikPopupf
    Dim StDatum As String
    Dim STProv1 As String, STProv2 As String, STProv3 As String, STProv4 As String
    Dim STProv5 As String, STProv6 As String, STProv7 As String, STProv8 As String
    Dim STResultat1 As String, STResultat2 As String, STResultat3 As String, STResultat4 As String
    Dim STResultat5 As String, STResultat6 As String, STResultat7 As String, STResultat8 As String
    Dim STGodk1 As String, STGodk2 As String, STGodk3 As String, STGodk4 As String
    Dim STGodk5 As String, STGodk6 As String, STGodk7 As String, STGodk8 As String
    Dim STFkod1 As String, STFkod2 As String, STFkod3 As String, STFkod4 As String
    Dim STFkod5 As String, STFkod6 As String, STFkod7 As String, STFkod8 As String
    Dim Tolerans As String, Info As String
    Private Sub Huvud_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StatistikPopupf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)


        GetProv(StTimestamp)

    End Sub

    Private Sub AvslutaK_Click(sender As Object, e As EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub
    Function GetProv(tist As String)

        Dim strConnString, strSQL As String
        Dim cn As OdbcConnection
        Dim dummy As String

        strConnString = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(strConnString)
        cn.Open()

        strSQL = "SELECT * FROM Provarkiv "
        strSQL = strSQL + "Where MyTimestamp = '" + tist + "' "


        Dim myCmd As New OdbcCommand(strSQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteNonQuery()

        If tabel.HasRows = False Then
            GoTo slut
        Else

            While tabel.Read()
                StTimestamp = nullhantering(tabel("MyTimeStamp"), "S")
                DatumTB.Text = nullhantering(tabel("Datum"), "S")
                ProduktIDCB.Text = nullhantering(tabel("ProduktKod"), "S")
                BatchnrTB.Text = nullhantering(tabel("Batchnr"), "S")
                StatusTB.Text = nullhantering(tabel("Status"), "S")
                ProvstatusCB.Text = nullhantering(tabel("ProvStatus"), "S")
                ProvSenasteTB.Text = nullhantering(tabel("Provsenaste"), "S")
                KommentsTB.Text = nullhantering(tabel("Komment"), "S")
                STProv1 = nullhantering(tabel("Prov1"), "S")
                STProv2 = nullhantering(tabel("Prov2"), "S")
                STProv3 = nullhantering(tabel("Prov3"), "S")
                STProv4 = nullhantering(tabel("Prov4"), "S")
                STProv5 = nullhantering(tabel("Prov5"), "S")
                STProv6 = nullhantering(tabel("Prov6"), "S")
                STProv7 = nullhantering(tabel("Prov7"), "S")
                STProv8 = nullhantering(tabel("Prov8"), "S")
                STResultat1 = nullhantering(tabel("Resultat1"), "S")
                STResultat2 = nullhantering(tabel("Resultat2"), "S")
                STResultat3 = nullhantering(tabel("Resultat3"), "S")
                STResultat4 = nullhantering(tabel("Resultat4"), "S")
                STResultat5 = nullhantering(tabel("Resultat5"), "S")
                STResultat6 = nullhantering(tabel("Resultat6"), "S")
                STResultat7 = nullhantering(tabel("Resultat7"), "S")
                STResultat8 = nullhantering(tabel("Resultat8"), "S")
                STGodk1 = nullhantering(tabel("Godk1"), "S")
                STGodk2 = nullhantering(tabel("Godk2"), "S")
                STGodk3 = nullhantering(tabel("Godk3"), "S")
                STGodk4 = nullhantering(tabel("Godk4"), "S")
                STGodk5 = nullhantering(tabel("Godk5"), "S")
                STGodk6 = nullhantering(tabel("Godk6"), "S")
                STGodk7 = nullhantering(tabel("Godk7"), "S")
                STGodk8 = nullhantering(tabel("Godk8"), "S")
                STFkod1 = nullhantering(tabel("Fkod1"), "S")
                STFkod2 = nullhantering(tabel("Fkod2"), "S")
                STFkod3 = nullhantering(tabel("Fkod3"), "S")
                STFkod4 = nullhantering(tabel("Fkod4"), "S")
                STFkod5 = nullhantering(tabel("Fkod5"), "S")
                STFkod6 = nullhantering(tabel("Fkod6"), "S")
                STFkod7 = nullhantering(tabel("Fkod7"), "S")
                STFkod8 = nullhantering(tabel("Fkod8"), "S")
            End While

        End If
slut:

        If Len(STProv1) > 2 Then
            Prov1L.Visible = True
            Prov1L.Text = STProv1
            Prov1L.Refresh()
            dummy = Getprovtext(Prov1L.Text)
            If Len(Info) > 1 Then
                Info1L.Visible = True
                Info1L.Text = Info
            Else
                Info1L.Visible = False
            End If
            Provtext1L.Visible = True
            Provtext1L.Text = dummy
            Varde1TB.Visible = True
            Varde1TB.Text = STResultat1
            Varde1TB.Refresh()
            If STProv1 = "Kulörbestämning" Then
                FKod1CB.Visible = True
                FKod1CB.Text = nullhantering(STFkod1, "S")
            End If
        End If

        If Len(STProv2) > 2 Then
            Prov2L.Visible = True
            Prov2L.Text = STProv2
            Prov2L.Refresh()
            dummy = Getprovtext(Prov2L.Text)
            If Len(Info) > 1 Then
                Info2l.Visible = True
                Info2l.Text = Info
            Else
                Info2l.Visible = False
            End If
            Provtext2L.Visible = True
            Provtext2L.Text = dummy
            Varde2TB.Visible = True
            Varde2TB.Text = STResultat2
            Varde2TB.Refresh()
            If STProv2 = "Kulörbestämning" Then
                FKod2CB.Visible = True
                FKod2CB.Text = nullhantering(STFkod2, "S")
            End If
        End If

        If Len(STProv3) > 2 Then
            Prov3L.Visible = True
            Prov3L.Text = STProv3
            Prov3L.Refresh()
            dummy = Getprovtext(Prov3L.Text)
            If Len(Info) > 1 Then
                Info3L.Visible = True
                Info3L.Text = Info
            Else
                Info3L.Visible = False
            End If
            Provtext3L.Visible = True
            Provtext3L.Text = dummy
            Varde3TB.Visible = True
            Varde3TB.Text = STResultat3
            Varde3TB.Refresh()
            If STProv3 = "Kulörbestämning" Then
                FKod3CB.Visible = True
                FKod3CB.Text = nullhantering(STFkod3, "S")
            End If
        End If

        If Len(STProv4) > 2 Then
            Prov4L.Visible = True
            Prov4L.Text = STProv4
            Prov4L.Refresh()
            dummy = Getprovtext(Prov4L.Text)
            If Len(Info) > 1 Then
                Info4L.Visible = True
                Info4L.Text = Info
            Else
                Info4L.Visible = False
            End If
            Provtext4L.Visible = True
            Provtext4L.Text = dummy
            Varde4TB.Visible = True
            Varde4TB.Text = STResultat4
            Varde4TB.Refresh()
            If STProv4 = "Kulörbestämning" Then
                FKod4CB.Visible = True
                FKod4CB.Text = nullhantering(STFkod4, "S")
            End If
        End If

        If Len(STProv5) > 2 Then
            Prov5L.Visible = True
            Prov5L.Text = STProv5
            Prov5L.Refresh()
            dummy = Getprovtext(Prov5L.Text)
            If Len(Info) > 1 Then
                Info5L.Visible = True
                Info5L.Text = Info
            Else
                Info5L.Visible = False
            End If
            Provtext5L.Visible = True
            Provtext5L.Text = dummy
            Varde5TB.Visible = True
            Varde5TB.Text = STResultat5
            Varde5TB.Refresh()
            If STProv5 = "Kulörbestämning" Then
                FKod5CB.Visible = True
                FKod5CB.Text = nullhantering(STFkod5, "S")
            End If
        End If

        If Len(STProv6) > 2 Then
            Prov6L.Visible = True
            Prov6L.Text = STProv6
            Prov6L.Refresh()
            dummy = Getprovtext(Prov6L.Text)
            If Len(Info) > 1 Then
                Info6L.Visible = True
                Info6L.Text = Info
            Else
                Info6L.Visible = False
            End If
            Provtext6L.Visible = True
            Provtext6L.Text = dummy
            Varde6TB.Visible = True
            Varde6TB.Text = STResultat6
            Varde6TB.Refresh()
            If STProv6 = "Kulörbestämning" Then
                FKod6CB.Visible = True
                FKod6CB.Text = nullhantering(STFkod6, "S")
            End If
        End If

        If Len(STProv7) > 2 Then
            Prov7L.Visible = True
            Prov7L.Text = STProv7
            Prov7L.Refresh()
            dummy = Getprovtext(Prov7L.Text)
            If Len(Info) > 1 Then
                Info7L.Visible = True
                Info7L.Text = Info
            Else
                Info7L.Visible = False
            End If
            Provtext7L.Visible = True
            Provtext7L.Text = dummy
            Varde7TB.Visible = True
            Varde7TB.Text = STResultat7
            Varde7TB.Refresh()
            If STProv7 = "Kulörbestämning" Then
                FKod7CB.Visible = True
                FKod7CB.Text = nullhantering(STFkod7, "S")
            End If
        End If

        If Len(STProv8) > 2 Then
            Prov8L.Visible = True
            Prov8L.Text = STProv8
            Prov8L.Refresh()
            dummy = Getprovtext(Prov8L.Text)
            If Len(Info) > 1 Then
                Info8L.Visible = True
                Info8L.Text = Info
            Else
                Info8L.Visible = False
            End If
            Provtext8L.Visible = True
            Provtext8L.Text = dummy
            Varde8TB.Visible = True
            Varde8TB.Text = STResultat8
            Varde8TB.Refresh()
            If STProv8 = "Kulörbestämning" Then
                FKod8CB.Visible = True
                FKod8CB.Text = nullhantering(STFkod8, "S")
            End If
        End If

        cn.Close()
        GetProv = "Ja"

    End Function

    Function Getprovtext(provnamn)
        Dim cn2 As OdbcConnection, mySQL2 As String
        Dim connStr2 As String, utpris(10) As Double
        Dim myCmd2 As OdbcCommand
        Dim tabel2 As OdbcDataReader
        Tolerans = "" : Info = ""

        connStr2 = "DSN=" + odbcsourcer + "; Database=" + Labdatabasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn2 = New OdbcConnection(connStr2)
        cn2.Open()
        mySQL2 = "SELECT Text,Tolerans,Info FROM LabTester"
        mySQL2 = mySQL2 + " WHERE ProvNamn = '" + provnamn + "' "

        myCmd2 = New OdbcCommand(mySQL2, cn2)
        tabel2 = myCmd2.ExecuteReader(CommandBehavior.CloseConnection)

        tabel2.Read()

        If tabel2.HasRows = False Then
            Getprovtext = ""
        Else
            Getprovtext = nullhantering(tabel2("Text"), "S")
            Tolerans = nullhantering(tabel2("Tolerans"), "S")
            Info = nullhantering(tabel2("Info"), "S")
        End If
        cn2.Close()
    End Function
End Class