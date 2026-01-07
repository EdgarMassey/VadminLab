Imports System.IO
Imports System.Net
Imports System.Net.WebRequestMethods
Public Class LokalInstF

    Private Sub LokalInstF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea

        readdll()
        ReadClientfil(sokvag + KlientID + ".cfg")
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)
        Ver.Text = "Version: " + vernr
        Huvud.Text = Prognamn + " - Lokala inställningar"
        datum.Text = today
        KlientIdl.Text = "KlientID:" + KlientID
        odbcsource.Text = "ODBCsource:" + odbcsourcer
        databas.Text = "Databasnamn:" + databasnamn
        Gnamn.Text = Firmanamn
        kordning = "Nummer"

        getprinters()
        skrivatillform()
        ReadClientfil(sokvag + KlientID + ".cfg")
        AvslutaK.Select()
    End Sub
    Private Sub skrivatillform()
        ODBCsourceTB.Text = odbcsourcer
        DatabasnamnTB.Text = databasnamn
        KlientIDLabel.Text = KlientID
        SokvL.Text = sokvag
        StandardmomsTB.Text = stdmoms
        STDVarRefTB.Text = defaultref
        StationsIDTB.Text = stationsid
        STDPrLB.Text = standardpr
        InvPrLb.Text = invoicepr
        DelPrLB.Text = deliverypr
        OffertPrLB.Text = offertpr
        StartUtskriftCB.Text = startutsk
        LonbesPRLB.Text = lonbeskpr
        KvittoPrLB.Text = billpr
        PDFPRLB.Text = pdfpr
        If stationtype = "Butik" Then
            KassaTermCB.Checked = True
        Else
            KassaTermCB.Checked = False
        End If
        If kvittorems = "1" Then
            RemPrCB.Checked = True
        Else
            RemPrCB.Checked = False
        End If
    End Sub


    Private Sub AvslutaK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvslutaK.Click
        Me.Close()
    End Sub

    Private Sub ODBCsourceTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ODBCsourceTB.TextChanged
        odbcsourcer = ODBCsourceTB.Text
    End Sub

    Private Sub DatabasnamnTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabasnamnTB.TextChanged
        databasnamn = DatabasnamnTB.Text
    End Sub

    Private Sub STDVarRefTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STDVarRefTB.TextChanged
        defaultref = STDVarRefTB.Text
    End Sub

    Private Sub StationsIDTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StationsIDTB.TextChanged
        stationsid = StationsIDTB.Text
    End Sub

    Private Sub StandardmomsTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardmomsTB.TextChanged
        stdmoms = StandardmomsTB.Text
    End Sub

    Private Sub SparaB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SparaB.Click
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "Databasename=" + databasnamn + Space(20) + vbCrLf, False)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "StationsID=" + stationsid + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "ODBCSource=" + odbcsourcer + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "Stdmoms=" + stdmoms + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "DefaultRef=" + defaultref + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "Invoice=" + invoicepr + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "Standard=" + standardpr + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "Wagespec=" + lonbeskpr + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "Delivery=" + deliverypr + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "Offert=" + offertpr + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "Bill=" + billpr + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "PDF=" + pdfpr + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "StationType=" + stationtype + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "Kvittorems=" + kvittorems + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "Startutsk=" + startutsk + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "KundDokMapp=" + KunddokumentmappTB.Text + Space(20) + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(sokvag + KlientID + ".cfg", "LevDokMapp=" + LevdokumentmappTB.Text + Space(20) + vbCrLf, True)
    End Sub


    Private Sub STDPrTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        standardpr = STDPrLB.Text
    End Sub

    Private Sub InvPrTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        invoicepr = InvPrLb.Text
    End Sub



    Private Sub DelPrTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        deliverypr = DelPrLB.Text
    End Sub


    Private Sub OffertPrTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        offertpr = OffertPrLB.Text
    End Sub


    Private Sub KvittoPRTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        billpr = KvittoPrLB.Text
    End Sub

    Private Sub PDFPrTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pdfpr = PDFPRLB.Text
    End Sub

    Private Sub KassaTermCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KassaTermCB.CheckedChanged
        If KassaTermCB.Checked = True Then
            stationtype = "Butik"
        Else
            stationtype = "Terminal"
        End If
    End Sub

    Private Sub RemPrCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemPrCB.CheckedChanged
        If RemPrCB.Checked = True Then
            kvittorems = "1"
        Else
            kvittorems = "0"
        End If
    End Sub
    Private Sub getprinters()
        Dim P As Integer
        Dim AvailablePrinters As String
        For P = 0 To System.Drawing.Printing.PrinterSettings.
          InstalledPrinters.Count - 1
            AvailablePrinters = System.Drawing.Printing.PrinterSettings.
              InstalledPrinters.Item(P)
            LonbesPRLB.Items.Add(AvailablePrinters)
            OffertPrLB.Items.Add(AvailablePrinters)
            PDFPRLB.Items.Add(AvailablePrinters)
            DelPrLB.Items.Add(AvailablePrinters)
            InvPrLb.Items.Add(AvailablePrinters)
            STDPrLB.Items.Add(AvailablePrinters)
            KvittoPrLB.Items.Add(AvailablePrinters)
        Next
    End Sub

    Private Sub KlientIDLabel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KlientIDLabel.TextChanged
        KlientID = KlientIDLabel.Text
    End Sub

    Private Sub KvittoPrLB_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles KvittoPrLB.SelectedIndexChanged
        billpr = KvittoPrLB.Text
    End Sub

    Private Sub STDPrLB_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles STDPrLB.SelectedIndexChanged
        standardpr = STDPrLB.Text
    End Sub

    Private Sub InvPrLb_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles InvPrLb.SelectedIndexChanged
        invoicepr = InvPrLb.Text
    End Sub

    Private Sub DelPrLB_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles DelPrLB.SelectedIndexChanged
        deliverypr = DelPrLB.Text
    End Sub

    Private Sub PDFPRLB_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles PDFPRLB.SelectedIndexChanged
        pdfpr = PDFPRLB.Text
    End Sub

    Private Sub OffertPrLB_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles OffertPrLB.SelectedIndexChanged
        offertpr = OffertPrLB.Text
    End Sub

    Private Sub LonbesPRLB_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles LonbesPRLB.SelectedIndexChanged
        lonbeskpr = LonbesPRLB.Text
    End Sub

    Private Sub StartUtskriftCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StartUtskriftCB.SelectedIndexChanged
        startutsk = StartUtskriftCB.Text
    End Sub

    Sub uppdateramenyprogram()
        Dim rfn As String, lfn As String
        Dim Message As String = "Vill du verkligen uppdatera VadminMeny programet ?"
        Dim Caption As String = "OBS:Se till att inte programet körs!!"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.OKCancel
        Dim Result As DialogResult

        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = 1 Then

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
            MessageBox.Show("Uppdateringen utfört!")
        End If
    End Sub

    Private Sub Uppdatmeny_Click(sender As Object, e As EventArgs) Handles Uppdatmeny.Click
        uppdateramenyprogram()
    End Sub

    Private Sub Alla_Click(sender As Object, e As EventArgs) Handles Alla.Click
        KvittoPrLB.Text = STDPrLB.Text
        InvPrLb.Text = STDPrLB.Text
        DelPrLB.Text = STDPrLB.Text
        InvPrLb.Text = STDPrLB.Text
        PDFPRLB.Text = STDPrLB.Text
        OffertPrLB.Text = STDPrLB.Text
        LonbesPRLB.Text = STDPrLB.Text

    End Sub
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

    Private Sub UpdaterB_Click(sender As Object, e As EventArgs) Handles UpdaterB.Click
        On Error GoTo errorhant
        Dim rfn As String, lfn As String
        Dim Message As String = "Vill du verkligen uppdatera VadminMeny programet ?"
        Dim Caption As String = "OBS:Se till att inte programet körs!!"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.OKCancel
        Dim Result As DialogResult
        rfn = "ftp://ftp.vadmin.net/vadmin.net/downloads/VadminUpdater.exe"
        lfn = sokvag + "\VadminUpdater.exe"
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
        MessageBox.Show("VadminUpdater nedladdad!")
        Exit Sub
errorhant:

        Me.Close()
    End Sub
End Class