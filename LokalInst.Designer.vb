<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LokalInstF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Huvud = New System.Windows.Forms.Button()
        Me.Ver = New System.Windows.Forms.GroupBox()
        Me.Gnamn = New System.Windows.Forms.Label()
        Me.KlientIdl = New System.Windows.Forms.Label()
        Me.odbcsource = New System.Windows.Forms.Label()
        Me.databas = New System.Windows.Forms.Label()
        Me.datum = New System.Windows.Forms.Label()
        Me.Versionl = New System.Windows.Forms.Label()
        Me.SparaB = New System.Windows.Forms.Button()
        Me.AvslutaK = New System.Windows.Forms.Button()
        Me.ODBCsourceTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatabasnamnTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StandardmomsTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.STDVarRefTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SokvL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StationsIDTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.KassaTermCB = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RemPrCB = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.KlientIDLabel = New System.Windows.Forms.TextBox()
        Me.KvittoPrLB = New System.Windows.Forms.ComboBox()
        Me.STDPrLB = New System.Windows.Forms.ComboBox()
        Me.InvPrLb = New System.Windows.Forms.ComboBox()
        Me.DelPrLB = New System.Windows.Forms.ComboBox()
        Me.PDFPRLB = New System.Windows.Forms.ComboBox()
        Me.OffertPrLB = New System.Windows.Forms.ComboBox()
        Me.LonbesPRLB = New System.Windows.Forms.ComboBox()
        Me.StartUtskriftCB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Uppdatmeny = New System.Windows.Forms.Button()
        Me.Alla = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LevdokumentmappTB = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.KunddokumentmappTB = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UpdaterB = New System.Windows.Forms.Button()
        Me.Ver.SuspendLayout()
        Me.SuspendLayout()
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(61, 12)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(406, 36)
        Me.Huvud.TabIndex = 18
        Me.Huvud.Text = "Lokala inställningar"
        Me.Huvud.UseVisualStyleBackColor = True
        '
        'Ver
        '
        Me.Ver.Controls.Add(Me.Gnamn)
        Me.Ver.Controls.Add(Me.KlientIdl)
        Me.Ver.Controls.Add(Me.odbcsource)
        Me.Ver.Controls.Add(Me.databas)
        Me.Ver.Controls.Add(Me.datum)
        Me.Ver.Controls.Add(Me.Versionl)
        Me.Ver.ForeColor = System.Drawing.Color.Gray
        Me.Ver.Location = New System.Drawing.Point(9, 576)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(197, 73)
        Me.Ver.TabIndex = 22
        Me.Ver.TabStop = False
        Me.Ver.Text = "Version"
        '
        'Gnamn
        '
        Me.Gnamn.Location = New System.Drawing.Point(9, 57)
        Me.Gnamn.Name = "Gnamn"
        Me.Gnamn.Size = New System.Drawing.Size(182, 13)
        Me.Gnamn.TabIndex = 17
        Me.Gnamn.Text = "Företagsnamn"
        Me.Gnamn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KlientIdl
        '
        Me.KlientIdl.Location = New System.Drawing.Point(6, 13)
        Me.KlientIdl.Name = "KlientIdl"
        Me.KlientIdl.Size = New System.Drawing.Size(185, 13)
        Me.KlientIdl.TabIndex = 4
        Me.KlientIdl.Text = "Klientid"
        Me.KlientIdl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'odbcsource
        '
        Me.odbcsource.Location = New System.Drawing.Point(6, 42)
        Me.odbcsource.Name = "odbcsource"
        Me.odbcsource.Size = New System.Drawing.Size(185, 13)
        Me.odbcsource.TabIndex = 3
        Me.odbcsource.Text = "Odbcsource"
        Me.odbcsource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'databas
        '
        Me.databas.Location = New System.Drawing.Point(6, 26)
        Me.databas.Name = "databas"
        Me.databas.Size = New System.Drawing.Size(185, 13)
        Me.databas.TabIndex = 2
        Me.databas.Text = "Databas"
        Me.databas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'datum
        '
        Me.datum.AutoSize = True
        Me.datum.Location = New System.Drawing.Point(120, 0)
        Me.datum.Name = "datum"
        Me.datum.Size = New System.Drawing.Size(38, 13)
        Me.datum.TabIndex = 1
        Me.datum.Text = "Datum"
        '
        'Versionl
        '
        Me.Versionl.AutoSize = True
        Me.Versionl.Location = New System.Drawing.Point(22, 16)
        Me.Versionl.Name = "Versionl"
        Me.Versionl.Size = New System.Drawing.Size(0, 13)
        Me.Versionl.TabIndex = 0
        '
        'SparaB
        '
        Me.SparaB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaB.Location = New System.Drawing.Point(499, 595)
        Me.SparaB.Name = "SparaB"
        Me.SparaB.Size = New System.Drawing.Size(98, 25)
        Me.SparaB.TabIndex = 235
        Me.SparaB.Text = "Spara"
        Me.SparaB.UseVisualStyleBackColor = True
        '
        'AvslutaK
        '
        Me.AvslutaK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaK.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaK.Location = New System.Drawing.Point(502, 626)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(95, 25)
        Me.AvslutaK.TabIndex = 234
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'ODBCsourceTB
        '
        Me.ODBCsourceTB.Location = New System.Drawing.Point(113, 79)
        Me.ODBCsourceTB.Name = "ODBCsourceTB"
        Me.ODBCsourceTB.Size = New System.Drawing.Size(130, 20)
        Me.ODBCsourceTB.TabIndex = 237
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 236
        Me.Label1.Text = "ODBC sourcenamn"
        '
        'DatabasnamnTB
        '
        Me.DatabasnamnTB.Location = New System.Drawing.Point(113, 107)
        Me.DatabasnamnTB.Name = "DatabasnamnTB"
        Me.DatabasnamnTB.Size = New System.Drawing.Size(130, 20)
        Me.DatabasnamnTB.TabIndex = 239
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 238
        Me.Label2.Text = "Databasnamn"
        '
        'StandardmomsTB
        '
        Me.StandardmomsTB.Location = New System.Drawing.Point(113, 188)
        Me.StandardmomsTB.Name = "StandardmomsTB"
        Me.StandardmomsTB.Size = New System.Drawing.Size(34, 20)
        Me.StandardmomsTB.TabIndex = 241
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "Standardmomstyp"
        '
        'STDVarRefTB
        '
        Me.STDVarRefTB.Location = New System.Drawing.Point(113, 133)
        Me.STDVarRefTB.Name = "STDVarRefTB"
        Me.STDVarRefTB.Size = New System.Drawing.Size(130, 20)
        Me.STDVarRefTB.TabIndex = 243
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 242
        Me.Label4.Text = "Standard vårreferens"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 244
        Me.Label5.Text = "Programmapp"
        '
        'SokvL
        '
        Me.SokvL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SokvL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SokvL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SokvL.Location = New System.Drawing.Point(111, 213)
        Me.SokvL.Name = "SokvL"
        Me.SokvL.Size = New System.Drawing.Size(247, 20)
        Me.SokvL.TabIndex = 296
        Me.SokvL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 297
        Me.Label7.Text = "KlientID"
        '
        'StationsIDTB
        '
        Me.StationsIDTB.Location = New System.Drawing.Point(113, 161)
        Me.StationsIDTB.Name = "StationsIDTB"
        Me.StationsIDTB.Size = New System.Drawing.Size(130, 20)
        Me.StationsIDTB.TabIndex = 300
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 299
        Me.Label8.Text = "StationsID"
        '
        'KassaTermCB
        '
        Me.KassaTermCB.AutoSize = True
        Me.KassaTermCB.Location = New System.Drawing.Point(166, 190)
        Me.KassaTermCB.Name = "KassaTermCB"
        Me.KassaTermCB.Size = New System.Drawing.Size(91, 17)
        Me.KassaTermCB.TabIndex = 301
        Me.KassaTermCB.Text = "Kassaterminal"
        Me.KassaTermCB.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(326, 385)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 303
        Me.Label9.Text = "Fakturaskrivare/Offert"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(326, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 305
        Me.Label10.Text = "Kvittoskrivare"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(616, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 307
        Me.Label11.Text = "Standardskrivare"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(326, 411)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 309
        Me.Label12.Text = "Följesedelskrivare"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(326, 464)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 311
        Me.Label13.Text = "Alternativskrivare"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(326, 490)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 13)
        Me.Label14.TabIndex = 313
        Me.Label14.Text = "Lönebeskedsskrivare"
        '
        'RemPrCB
        '
        Me.RemPrCB.AutoSize = True
        Me.RemPrCB.Location = New System.Drawing.Point(403, 355)
        Me.RemPrCB.Name = "RemPrCB"
        Me.RemPrCB.Size = New System.Drawing.Size(85, 17)
        Me.RemPrCB.TabIndex = 314
        Me.RemPrCB.Text = "Remskrivare"
        Me.RemPrCB.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(326, 438)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 316
        Me.Label15.Text = "PDFskrivare"
        '
        'KlientIDLabel
        '
        Me.KlientIDLabel.Location = New System.Drawing.Point(111, 244)
        Me.KlientIDLabel.Name = "KlientIDLabel"
        Me.KlientIDLabel.Size = New System.Drawing.Size(87, 20)
        Me.KlientIDLabel.TabIndex = 324
        '
        'KvittoPrLB
        '
        Me.KvittoPrLB.FormattingEnabled = True
        Me.KvittoPrLB.Location = New System.Drawing.Point(16, 356)
        Me.KvittoPrLB.Name = "KvittoPrLB"
        Me.KvittoPrLB.Size = New System.Drawing.Size(301, 21)
        Me.KvittoPrLB.TabIndex = 325
        '
        'STDPrLB
        '
        Me.STDPrLB.FormattingEnabled = True
        Me.STDPrLB.Location = New System.Drawing.Point(16, 329)
        Me.STDPrLB.Name = "STDPrLB"
        Me.STDPrLB.Size = New System.Drawing.Size(301, 21)
        Me.STDPrLB.TabIndex = 326
        '
        'InvPrLb
        '
        Me.InvPrLb.FormattingEnabled = True
        Me.InvPrLb.Location = New System.Drawing.Point(16, 383)
        Me.InvPrLb.Name = "InvPrLb"
        Me.InvPrLb.Size = New System.Drawing.Size(301, 21)
        Me.InvPrLb.TabIndex = 327
        '
        'DelPrLB
        '
        Me.DelPrLB.FormattingEnabled = True
        Me.DelPrLB.Location = New System.Drawing.Point(16, 411)
        Me.DelPrLB.Name = "DelPrLB"
        Me.DelPrLB.Size = New System.Drawing.Size(301, 21)
        Me.DelPrLB.TabIndex = 328
        '
        'PDFPRLB
        '
        Me.PDFPRLB.FormattingEnabled = True
        Me.PDFPRLB.Location = New System.Drawing.Point(16, 438)
        Me.PDFPRLB.Name = "PDFPRLB"
        Me.PDFPRLB.Size = New System.Drawing.Size(301, 21)
        Me.PDFPRLB.TabIndex = 329
        '
        'OffertPrLB
        '
        Me.OffertPrLB.FormattingEnabled = True
        Me.OffertPrLB.Location = New System.Drawing.Point(16, 465)
        Me.OffertPrLB.Name = "OffertPrLB"
        Me.OffertPrLB.Size = New System.Drawing.Size(301, 21)
        Me.OffertPrLB.TabIndex = 330
        '
        'LonbesPRLB
        '
        Me.LonbesPRLB.FormattingEnabled = True
        Me.LonbesPRLB.Location = New System.Drawing.Point(16, 492)
        Me.LonbesPRLB.Name = "LonbesPRLB"
        Me.LonbesPRLB.Size = New System.Drawing.Size(301, 21)
        Me.LonbesPRLB.TabIndex = 331
        '
        'StartUtskriftCB
        '
        Me.StartUtskriftCB.FormattingEnabled = True
        Me.StartUtskriftCB.Items.AddRange(New Object() {"Faktura", "Kvitto", "Följesedel", "Orderbekräftelse"})
        Me.StartUtskriftCB.Location = New System.Drawing.Point(428, 78)
        Me.StartUtskriftCB.Name = "StartUtskriftCB"
        Me.StartUtskriftCB.Size = New System.Drawing.Size(139, 21)
        Me.StartUtskriftCB.TabIndex = 332
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 333
        Me.Label6.Text = "Standard utskrift"
        '
        'Uppdatmeny
        '
        Me.Uppdatmeny.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uppdatmeny.ForeColor = System.Drawing.Color.Maroon
        Me.Uppdatmeny.Location = New System.Drawing.Point(12, 549)
        Me.Uppdatmeny.Name = "Uppdatmeny"
        Me.Uppdatmeny.Size = New System.Drawing.Size(194, 25)
        Me.Uppdatmeny.TabIndex = 334
        Me.Uppdatmeny.Text = "Uppdatera menyprogramet"
        Me.Uppdatmeny.UseVisualStyleBackColor = True
        '
        'Alla
        '
        Me.Alla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alla.ForeColor = System.Drawing.Color.Maroon
        Me.Alla.Location = New System.Drawing.Point(329, 307)
        Me.Alla.Name = "Alla"
        Me.Alla.Size = New System.Drawing.Size(98, 22)
        Me.Alla.TabIndex = 335
        Me.Alla.Text = "Alla som standard"
        Me.Alla.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(326, 332)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 336
        Me.Label16.Text = "Standard skrivare"
        '
        'LevdokumentmappTB
        '
        Me.LevdokumentmappTB.Location = New System.Drawing.Point(405, 270)
        Me.LevdokumentmappTB.Name = "LevdokumentmappTB"
        Me.LevdokumentmappTB.Size = New System.Drawing.Size(192, 20)
        Me.LevdokumentmappTB.TabIndex = 344
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(291, 272)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 13)
        Me.Label18.TabIndex = 343
        Me.Label18.Text = "Levdokument mapp"
        '
        'KunddokumentmappTB
        '
        Me.KunddokumentmappTB.Location = New System.Drawing.Point(113, 270)
        Me.KunddokumentmappTB.Name = "KunddokumentmappTB"
        Me.KunddokumentmappTB.Size = New System.Drawing.Size(170, 20)
        Me.KunddokumentmappTB.TabIndex = 342
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(0, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 13)
        Me.Label17.TabIndex = 341
        Me.Label17.Text = "Kunddokument mapp"
        '
        'UpdaterB
        '
        Me.UpdaterB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdaterB.ForeColor = System.Drawing.Color.Maroon
        Me.UpdaterB.Location = New System.Drawing.Point(12, 519)
        Me.UpdaterB.Name = "UpdaterB"
        Me.UpdaterB.Size = New System.Drawing.Size(194, 25)
        Me.UpdaterB.TabIndex = 345
        Me.UpdaterB.Text = "Ladda ned VadminUpdater"
        Me.UpdaterB.UseVisualStyleBackColor = True
        '
        'LokalInstF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 662)
        Me.Controls.Add(Me.UpdaterB)
        Me.Controls.Add(Me.LevdokumentmappTB)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.KunddokumentmappTB)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Alla)
        Me.Controls.Add(Me.Uppdatmeny)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StartUtskriftCB)
        Me.Controls.Add(Me.LonbesPRLB)
        Me.Controls.Add(Me.OffertPrLB)
        Me.Controls.Add(Me.PDFPRLB)
        Me.Controls.Add(Me.DelPrLB)
        Me.Controls.Add(Me.InvPrLb)
        Me.Controls.Add(Me.STDPrLB)
        Me.Controls.Add(Me.KvittoPrLB)
        Me.Controls.Add(Me.KlientIDLabel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.RemPrCB)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.KassaTermCB)
        Me.Controls.Add(Me.StationsIDTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SokvL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.STDVarRefTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StandardmomsTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DatabasnamnTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ODBCsourceTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SparaB)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Huvud)
        Me.Name = "LokalInstF"
        Me.Text = "Lokala inställningar"
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Huvud As System.Windows.Forms.Button
    Friend WithEvents Ver As System.Windows.Forms.GroupBox
    Friend WithEvents Gnamn As System.Windows.Forms.Label
    Friend WithEvents KlientIdl As System.Windows.Forms.Label
    Friend WithEvents odbcsource As System.Windows.Forms.Label
    Friend WithEvents databas As System.Windows.Forms.Label
    Friend WithEvents datum As System.Windows.Forms.Label
    Friend WithEvents Versionl As System.Windows.Forms.Label
    Friend WithEvents SparaB As System.Windows.Forms.Button
    Friend WithEvents AvslutaK As System.Windows.Forms.Button
    Friend WithEvents ODBCsourceTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DatabasnamnTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StandardmomsTB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents STDVarRefTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SokvL As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StationsIDTB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents KassaTermCB As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RemPrCB As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents KlientIDLabel As System.Windows.Forms.TextBox
    Friend WithEvents KvittoPrLB As System.Windows.Forms.ComboBox
    Friend WithEvents STDPrLB As System.Windows.Forms.ComboBox
    Friend WithEvents InvPrLb As System.Windows.Forms.ComboBox
    Friend WithEvents DelPrLB As System.Windows.Forms.ComboBox
    Friend WithEvents PDFPRLB As System.Windows.Forms.ComboBox
    Friend WithEvents OffertPrLB As System.Windows.Forms.ComboBox
    Friend WithEvents LonbesPRLB As System.Windows.Forms.ComboBox
    Friend WithEvents StartUtskriftCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Uppdatmeny As System.Windows.Forms.Button
    Friend WithEvents Alla As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LevdokumentmappTB As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents KunddokumentmappTB As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents UpdaterB As Button
End Class
