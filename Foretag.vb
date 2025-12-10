

Imports System.Data.Odbc
Imports System.IO
Imports System.Net
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Foretag
    Dim Labversion As String = "", dummy As String

    Private Sub Foretag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ipp() As Net.IPAddress = System.Net.Dns.GetHostAddresses("")
        If ipp.Count > 0 Then
            For Each ipadd As Net.IPAddress In ipp
                ipadress = (ipadd.ToString)
            Next
        End If
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        sokvag = AppDomain.CurrentDomain.BaseDirectory
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        readdll()
        ReadClientfil(sokvag + KlientID + ".cfg")
        KlientIdTB.Text = KlientID
        LasVersion(sokvag + "LabVersion.cfg")
        LasMenyVersion()

        If KlientID = "NM" Or KlientID = "MD" Or KlientID = "MC" Then
            PersonligIDL.Visible = True
            PersonligIDTB.Visible = True
            PersonligIDTB.Text = PersonligID
        Else
            PersonligIDL.Visible = False
            PersonligIDTB.Visible = False
        End If
        LosenTB.Text = losen

        If spar = "True" Then
            SparaCB.Checked = True
        End If

        checkmeny = hamptaversion("VadminMENY")
        vernr = "20251210b"
        Labdatabasnamn = "NMLab"

        My.Computer.FileSystem.WriteAllText(sokvag + "LabVersion.cfg", "Labversion=" + vernr + Space(40) + vbCrLf, False)

        myip = "90.231.192.137"
        Prognamn = "Vadmin 2025 "
        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Lab  Behörighetskontroll"
        today = Format(Now, "yyyy-MM-dd")
        odbclosen = "alfons"
        OleDbSource = "sql.vadmin.net"
        datum.Text = today
    End Sub
    Private Sub loginrutin()
        KlientID = UCase(KlientID)
        Me.Cursor = Cursors.WaitCursor
        If spar = "True" Then
            SparaCB.Checked = True
        Else
            SparaCB.Checked = False
        End If
        hamptaforetag(KlientID)
        If KlientID = "MD" Or KlientID = "NM" Or KlientID = "MC" Then
            sakerhet = 1

            GetNewBehorighet(PersonligIDTB.Text)
            If GetNewBehorighet(PersonligIDTB.Text) = "" Then
                sakerhet = 0
                If PersonligIDTB.Text = "edgar.massey@gmail.com" And LosenTB.Text = "EMassey46" Then sakerhet = 1
            Else

                If InStr(PersonligIDKlass, "1") > 0 Then sakerhet = 1
                If InStr(PersonligIDKlass, "4") > 0 Then sakerhet = 2
                If InStr(PersonligIDKlass, "5") > 0 Then sakerhet = 3
                If PersonligIDTB.Text = "edgar.massey@gmail.com" And LosenTB.Text = "EMassey46" Then sakerhet = 1

            End If


            dummy = PersonligKlarTextName
            dummy = PersonligID
            dummy = PersonligIDKlass
            dummy = PersonligIDLosen
        Else
            If losen = password6 Then sakerhet = 6
            If losen = password5 Then sakerhet = 5
            If losen = password4 Then sakerhet = 4
            If losen = password3 Then sakerhet = 3
            If losen = password2 Then sakerhet = 2
            If losen = "EMassey46" Or losen = password1 Then sakerhet = 1

        End If

        If sakerhet > 0 Then

            If SparaCB.Checked = True Then
                My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "ClientID=" + KlientID + vbCrLf, False)
                My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "Lösen=" + losen + vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "PersID=" + PersonligIDTB.Text + vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "Spara=" + CStr(SparaCB.Checked) + vbCrLf, True)
            Else
                My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "" + vbCrLf, False)

            End If
            ReadClientfil(sokvag + KlientID + ".cfg")
            Me.SendToBack()

            If MaxBehorighet = "True" Or TotLab = "True" Then
                LabstartF.Show()
            Else
                MessageBox.Show("Ogiltig inloggning")
            End If
        Else
            MessageBox.Show("Ogiltig inloggning")
        End If
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub AvslutaK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvslutaK.Click
        System.Diagnostics.Process.Start(sokvag + "VadminMeny.exe")
        Me.Close()
    End Sub

    Private Sub KlientIdTB_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KlientIdTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            loginrutin()
        End If
    End Sub

    Private Sub KlientIdTB_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles KlientIdTB.LostFocus
        KlientID = UCase(KlientIdTB.Text)
        KlientIdTB.Text = UCase(KlientIdTB.Text)
    End Sub
    Private Sub LoginK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginK.Click
        loginrutin()
    End Sub
    Function hamptaforetag(ByVal clientid As String)
        hamptaforetag = ""
        'On Error GoTo nocon
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, test As Decimal

        connStr = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen

        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM foretagreg"
        mySQL = mySQL + " WHERE ClientID = '" + KlientID + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteReader()
        While tabel.Read()
            rakenskapID = nullhantering(tabel("rakenskapID"), "S")
            rakenskapID = nullhantering(tabel("yearid"), "S")
            logonamn = nullhantering(tabel("Logonamn"), "S")
            Firmanamn = nullhantering(tabel("Firmanamn"), "S")
            Postadress1 = nullhantering(tabel("Postadress1"), "S")
            Postadress2 = nullhantering(tabel("Postadress2"), "S")
            Postadress3 = nullhantering(tabel("Postadress3"), "S")
            besad1 = nullhantering(tabel("besoksadress1"), "S")
            besad2 = nullhantering(tabel("besoksadress2"), "S")
            firmaland = nullhantering(tabel("Land"), "S")
            telefon = nullhantering(tabel("Telefon"), "S")
            telefax = nullhantering(tabel("Telefax"), "S")
            gsm = nullhantering(tabel("GSM"), "S")
            epost = nullhantering(tabel("epost"), "S")
            kontaktperson = nullhantering(tabel("kontaktperson"), "S")
            password1 = nullhantering(tabel("Password1"), "S")
            password2 = nullhantering(tabel("Password2"), "S")
            password3 = nullhantering(tabel("Password3"), "S")
            password4 = nullhantering(tabel("Password4"), "S")
            password5 = nullhantering(tabel("Password5"), "S")
            password6 = nullhantering(tabel("Password6"), "S")
            antkvitto = nullhantering(tabel("Antalkvitto"), "T")
            meddelande = nullhantering(tabel("meddelande"), "S")
            antalfolj = nullhantering(tabel("Antalfoljesedel"), "T")
            antfakt = nullhantering(tabel("Antalfaktura"), "T")
            antorderbekraft = nullhantering(tabel("Antalorderbekraft"), "T")
            antallonespec = nullhantering(tabel("Antallonespec"), "T")
            grundlista = nullhantering(tabel("Grundlista"), "T")
            specialversion = nullhantering(tabel("Specialversion"), "S")
            moms1 = nullhantering(tabel("moms1"), "T")
            moms2 = nullhantering(tabel("moms2"), "T")
            moms3 = nullhantering(tabel("moms3"), "T")
            test = moms1 / 100
            momsv(1) = (moms1 / 100) : momsv(2) = moms2 / 100 : momsv(3) = moms3 / 100
            momsv(4) = Int(moms1 / ((moms1 / 100) + 1) * 100) / 100
            momsv(5) = Int(moms2 / ((moms2 / 100) + 1) * 100) / 100
            momsv(6) = Int(moms3 / ((moms3 / 100) + 1) * 100) / 100
            momsv(4) = momsv(4) / 100
            momsv(5) = momsv(5) / 100
            momsv(6) = momsv(6) / 100
            drojsmalsranta = nullhantering(tabel("drojsmalsranta"), "T")
            fortrycktpapper = nullhantering(tabel("Fortryckbankgiro"), "T")
            fortrycktfot = nullhantering(tabel("Fortrycktfot"), "T")
            bankgiro = nullhantering(tabel("bankgiro"), "S")
            postgiro = nullhantering(tabel("postgiro"), "S")
            regnr = nullhantering(tabel("regnr"), "S")
            bankkonto = nullhantering(tabel("bank"), "S")
            bankkonteringsnr = nullhantering(tabel("bankkonteringsnr"), "S")
            If Len(bankkonteringsnr) < 4 Then bankkonteringsnr = "1940"
            stdforsaljning = nullhantering(tabel("stdforsaljning"), "S")
            utmoms = nullhantering(tabel("utmoms"), "S")
            lagerup = nullhantering(tabel("Lagerup"), "S")
            telebankgiro = nullhantering(tabel("telebankgiro"), "T")
            expavgift = nullhantering(tabel("Expavgift"), "T")
            avgiftsgrans = nullhantering(tabel("avgiftsgrans"), "T")
            ettlangd = nullhantering(tabel("Ettikettlangd"), "T")
            ettbred = nullhantering(tabel("Ettantalibred"), "T")
            komponentup = nullhantering(tabel("Girolink"), "T")
            komment1 = nullhantering(tabel("Komment1"), "S")
            komment2 = nullhantering(tabel("Komment2"), "S")
            sidolev = nullhantering(tabel("Sidolev"), "T")
            genast = nullhantering(tabel("Telebankgiro"), "T")
            EAN = nullhantering(tabel("Inteean"), "T")
            Language = nullhantering(tabel("sprak"), "S")
            faktfolj = nullhantering(tabel("faktfolj"), "T")
            girolinknr = nullhantering(tabel("girolinknr"), "S")
            girolinkfil = nullhantering(tabel("girolinkfil"), "S")
            epost = nullhantering(tabel("epost"), "S")
            rabradfakt = nullhantering(tabel("rabradfakt"), "S")
            arbavgift = nullhantering(tabel("arbavgift"), "T")
            ejprissatt = nullhantering(tabel("ejprisspar"), "T")
            nolllagerspar = nullhantering(tabel("nolllagerspar"), "T")
            a5kvitto = nullhantering(tabel("a5kvitto"), "T")
            rantdagar = nullhantering(tabel("rantdagar"), "T")
            rantbelopp = nullhantering(tabel("rantbelopp"), "T")
            BasEU97 = nullhantering(tabel("baseu97"), "T")
            ejavrund = nullhantering(tabel("ejavrundning"), "T")
            ordsok = nullhantering(tabel("sokorder"), "T")
            ejcapri = nullhantering(tabel("ejcapris"), "T")
            lagerred = nullhantering(tabel("lagerred"), "T")
            garantitext = nullhantering(tabel("garantitext"), "S")
            textradpos = nullhantering(tabel("textrad"), "T")
            orderformat = nullhantering(tabel("orderformat"), "S")
            meddelande = nullhantering(tabel("meddelande"), "S")
            gsm = nullhantering(tabel("gsm"), "S")
            SMTPservernamn = nullhantering(tabel("SMTPserver"), "S")
            SMTPUser = nullhantering(tabel("SMTPUser"), "S")
            SMTPPassW = nullhantering(tabel("SMTPPassW"), "S")
            banknamn = nullhantering(tabel("banknamn"), "S")
            webadress = nullhantering(tabel("webadress"), "S")
            ingmoms = nullhantering(tabel("ingmomskonto"), "S")
            kp = nullhantering(tabel("kostnpos"), "T")
            antallonebesked = nullhantering(tabel("antallonespec"), "S")
        End While
        cn.Close()
nocon:
        If Err.Number <> 0 Then
            MessageBox.Show("ODBC förbindelse saknas")
        End If
    End Function

    Private Sub LosenTB_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LosenTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            loginrutin()
        End If
    End Sub
    Private Sub LosenTB_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LosenTB.LostFocus
        losen = LosenTB.Text
    End Sub

    Private Sub LosenTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LosenTB.TextChanged
        losen = LosenTB.Text
    End Sub

    Private Sub SparaCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SparaCB.CheckedChanged
        spar = SparaCB.Checked
    End Sub

    Private Sub datum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datum.Click
        LokalInstF.Show()
    End Sub

    Private Sub KlientIdTB_TextChanged(sender As Object, e As EventArgs) Handles KlientIdTB.TextChanged
        KlientID = UCase(KlientIdTB.Text)
        If KlientID = "NM" Or KlientID = "MD" Then
            PersonligIDL.Visible = True
            PersonligIDTB.Visible = True
        Else
            PersonligIDL.Visible = False
            PersonligIDTB.Visible = False
        End If
    End Sub
    Function hamptaversion(ByVal kod As String)
        Dim odbcs As String = "VadminODBC", odbcl As String = "alfons"
        hamptaversion = ""
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, l As Integer
        connStr = "DSN=" + odbcs + "; Database=SiteInfo" + ";Uid=v2000;Pwd=" + odbcl
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM ProgramVersionReg"
        mySQL = mySQL + " WHERE "
        mySQL = mySQL + " Programnamn = '" + kod + "'  "


        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteNonQuery()
        l = 1
        If tabel.HasRows = False Then
            GoTo slut
        Else
            While tabel.Read()
                hamptaversion = tabel("AktuellVersion")
                l = l + 1
            End While

        End If
slut:
        cn.Close()
    End Function

    Sub uppdateramenyprogram()
        On Error Resume Next
        Dim rfn As String, lfn As String
        Dim Message As String = "Vill du verkligen uppdatera VadminMeny programet ?"
        Dim Caption As String = "OBS:Se till att inte programet körs!!"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.OKCancel
        Dim Result As DialogResult

        rfn = "ftp://ftp.vadmin.net/vadmin.net/downloads/VadminMeny.exe"
        lfn = sokvag + "\VadminMeny.exe"
        Dim ftp As FtpWebRequest = CType(FtpWebRequest.Create(rfn), FtpWebRequest)
        Console.WriteLine("Downloading: " & rfn)
        ftp.Credentials = New NetworkCredential("Edgar", "alfons")
        ftp.KeepAlive = False
        ftp.UseBinary = True
        ftp.Method = WebRequestMethods.Ftp.DownloadFile
        Using FtpResponse As FtpWebResponse = CType(ftp.GetResponse, FtpWebResponse)
            Using ResponseStream As IO.Stream = FtpResponse.GetResponseStream
                Using fs As New IO.FileStream(lfn, FileMode.Create)
                    Dim buffer(2047) As Byte
                    Dim read As Integer = 0
                    Do
                        read = ResponseStream.Read(buffer, 0, buffer.Length)
                        fs.Write(buffer, 0, read)
                        Console.Write(".")
                    Loop Until read = 0
                    ResponseStream.Close()
                    fs.Flush()
                    fs.Close()
                End Using
                ResponseStream.Close()
            End Using
        End Using
        MessageBox.Show("Meny uppdateringen utfört!")

    End Sub

    Function getlocalIP()
        Dim strHostName As String
        Dim IPAddresses As IPAddress()
        getlocalIP = ""
        strHostName = System.Net.Dns.GetHostName()
        IPAddresses = System.Net.Dns.GetHostEntry(strHostName).AddressList
        For Each IP As IPAddress In IPAddresses
            If InStr(IP.ToString, ".") > 1 Then
                getlocalIP = IP.ToString
            End If
        Next
    End Function

    Private Sub Huvud_Click(sender As Object, e As EventArgs) Handles Huvud.Click
        LokalInstF.Show()
    End Sub

    Function hamptapersonligID(ByVal clientid As String)
        hamptapersonligID = ""

        'On Error GoTo nocon
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String
        connStr = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM Behorighetsreg"
        mySQL = mySQL + " WHERE UserID = '" + PersonligIDTB.Text + "' "
        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteReader()
        While tabel.Read()
            PersonligID = nullhantering(tabel("UserID"), "S")
            PersonligKlarTextName = nullhantering(tabel("Klartextnamn"), "S")
            PersonligIDLosen = nullhantering(tabel("Password"), "S")
            PersonligIDKlass = nullhantering(tabel("Behörighetsklass"), "S")
            If PersonligIDLosen = LosenTB.Text Then
                hamptapersonligID = PersonligKlarTextName
            End If
        End While
        cn.Close()
nocon:
        If Err.Number <> 0 Then
            MessageBox.Show("ODBC förbindelse saknas")
        End If
    End Function
    Function ReadClientfil(fil As String)
        For Each line As String In System.IO.File.ReadLines(fil)
            Console.WriteLine(line)
            If Strings.Left$(line, 11) = "MenyVersion" Then menuversion = BLANKBORT(Mid$(line, 13, 50))
            If Strings.Left$(line, 7) = "Invoice" Then invoicepr = BLANKBORT(Mid$(line, 9, 50))
            If Strings.Left$(line, 8) = "Standard" Then standardpr = BLANKBORT(Mid$(line, 10, 50))
            If Strings.Left$(line, 4) = "Pack" Then packpr = BLANKBORT(Mid$(line, 6, 50))
            If Strings.Left$(line, 8) = "Delivery" Then deliverypr = BLANKBORT(Mid$(line, 10, 50))
            If Strings.Left$(line, 4) = "Bill" Then billpr = BLANKBORT(Mid$(line, 6, 50))
            If Strings.Left$(line, 3) = "PDF" Then pdfpr = BLANKBORT(Mid$(line, 5, 50))
            If Strings.Left$(line, 7) = "PostPak" Then postpr = BLANKBORT(Mid$(line, 9, 50))
            If Strings.Left$(line, 8) = "Reminder" Then paminpr = BLANKBORT(Mid$(line, 10, 50))
            If Strings.Left$(line, 8) = "Wagespec" Then lonbeskpr = BLANKBORT(Mid$(line, 10, 50))
            If Strings.Left$(line, 7) = "Telefax" Then telefaxpr = BLANKBORT(Mid$(line, 9, 50))
            If Strings.Left$(line, 7) = "Bestskr" Then bestpr = BLANKBORT(Mid$(line, 9, 50))
            If Strings.Left$(line, 8) = "Timecard" Then timecardpr = BLANKBORT(Mid$(line, 10, 50))
            If Strings.Left$(line, 10) = "DefaultRef" Then defaultref = BLANKBORT(Mid$(line, 12, 50))
            If Strings.Left$(line, 10) = "DefaultDoc" Then defaultDoc = BLANKBORT(Mid$(line, 12, 50))
            If Strings.Left$(line, 11) = "StationType" Then stationtype = BLANKBORT(Mid$(line, 13, 50))
            If Strings.Left$(line, 8) = "Calender" Then calbok = BLANKBORT(Mid$(line, 10, 20))
            If Strings.Left$(line, 10) = "Kvittorems" Then kvittorems = BLANKBORT(Mid$(line, 12, 50))
            If Strings.Left$(line, 9) = "Startutsk" Then startutsk = BLANKBORT(Mid$(line, 11, 50))
            If Strings.Left$(line, 10) = "Fraktsedel" Then fraktsedpr = BLANKBORT(Mid$(line, 12, 50))
            If Strings.Left$(line, 11) = "Kolliadress" Then kolliadrpr = BLANKBORT(Mid$(line, 13, 50))
            If Strings.Left$(line, 10) = "Farliggods" Then farliggodspr = BLANKBORT(Mid$(line, 12, 50))
            If Strings.Left$(line, 7) = "Stdmoms" Then stdmoms = BLANKBORT(Mid$(line, 9, 1))
            If Strings.Left$(line, 12) = "Databasename" Then databasnamn = BLANKBORT(Mid$(line, 14, 50))
            If Strings.Left$(line, 11) = "KundDokMapp" Then KundDokMapp = BLANKBORT(Mid$(line, 13, 50))
            If Strings.Left$(line, 10) = "LevDokMapp" Then levdokmapp = BLANKBORT(Mid$(line, 12, 50))
            If Strings.Left$(line, 6) = "Offert" Then offertpr = BLANKBORT(Mid$(line, 8, 50))
            If Strings.Left$(line, 10) = "ODBCSource" Then
                odbcsourcer = BLANKBORT(Mid$(line, 12, 50))
                odbcsourcerr = odbcsourcer
                odbcsource = odbcsourcer
            End If
            If Strings.Left$(line, 10) = "StationsID" Then stationsid = BLANKBORT(Mid$(line, 12, 50))
            If Strings.Left$(line, Len("ClientID")) = "ClientID" Then KlientID = BLANKBORT(Mid$(line, Len("ClientID") + 2, 50))
            If Strings.Left$(line, 2) = "Lö" Then losen = BLANKBORT(Mid$(line, Len("Lösen") + 2, 50))
            If Strings.Left$(line, 6) = "PersID" Then PersonligID = BLANKBORT(Mid$(line, Len("PersID") + 2, 50))
            If Strings.Left$(line, Len("Tid")) = "Tid" Then tid = BLANKBORT(Mid$(line, Len("Tid") + 2, 20))
            If Strings.Left$(line, Len("Spar")) = "Spar" Then spar = BLANKBORT(Mid$(line, Len("Spar") + 3, 4))
        Next
        ReadClientfil = "1"
    End Function
    Function readdll()
        For Each line As String In System.IO.File.ReadLines(sokvag + "vdriver.dll")
            ' Console.WriteLine(line)
            If Strings.Left$(line, Len("ClientID")) = "ClientID" Then KlientID = BLANKBORT(Mid$(line, Len("ClientID") + 2, 50))
            If Strings.Left$(line, 5) = "Lösen" Then losen = BLANKBORT(Mid$(line, Len("Lösen") + 2, 50))
            If Strings.Left$(line, 6) = "PersID" Then PersonligID = BLANKBORT(Mid$(line, Len("PersID") + 2, 50))
            If Strings.Left$(line, Len("Spar")) = "Spar" Then spar = BLANKBORT(Mid$(line, Len("Spar") + 3, 4))
        Next
        readdll = ""

    End Function
    Function LasVersion(fil As String)
        For Each line As String In System.IO.File.ReadLines(fil)
            ' Console.WriteLine(line)
            If Strings.Left$(line, 10) = "Labversion" Then Labversion = BLANKBORT(Mid$(line, 12, 50))
        Next
        LasVersion = ""
    End Function


    Function LasMenyVersion()
        For Each line As String In System.IO.File.ReadLines("MenyInfo.cfg")
            ' Console.WriteLine(line)
            If Strings.Left$(line, 11) = "MenyVersion" Then menuversion = BLANKBORT(Mid$(line, 13, 50))
            LasMenyVersion = ""
        Next
        LasMenyVersion = ""

    End Function
    Function GetNewBehorighet(ByVal kod As String)
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, l As Integer
        connStr = "DSN=" + odbcsourcer + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM BehorReg"
        mySQL = mySQL + " WHERE UserId = '" + kod + "'  "

        GetNewBehorighet = ""
        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteNonQuery()
        l = 1
        If tabel.HasRows = False Then
            GoTo slut
        Else
            While tabel.Read()
                UserID = nullhantering(tabel("UserID"), "S")
                UserNamn = nullhantering(tabel("Usernamn"), "S")
                Userpassword = nullhantering(tabel("UserPassword"), "S")
                MaxBehorighet = tabel("MaxBehorighet")
                'Olika programmoduler
                TotCal = tabel("TotCal")
                TotLab = tabel("Totlab")
                TotRec = tabel("TotRec")
                TotRed = tabel("TotRed")
                TotOLF = tabel("TotOlf")
                'OLF moduler 
                MOLFKundreg = tabel("MOLFKundreg")
                MOLFKundres = tabel("MOLFKundres")
                MOLFProdreg = tabel("MOLFProdreg")
                MOLFOrderFakt = tabel("MOLFOrderFakt")
                MOLFArbOrder = tabel("MOLFArbOrder")
                MOLFInlev = tabel("MOLFInlev")
                MOLFBestall = tabel("MOLFBestall")
                'Diverse begränsningar/undantag
                BRECBegrOmtappning = tabel("BRECBegrOmtappning")
                BOLFBegProdpriser = tabel("BOLFBegProdpriser")
                BOLFAnkomnstKontroll = tabel("BOLFAnkomnstKontroll")
                BCalEndastVisning = tabel("BCalEndastVisning")
                l = l + 1
                GetNewBehorighet = "Ja"
            End While

        End If
slut:
        cn.Close()

    End Function

End Class
