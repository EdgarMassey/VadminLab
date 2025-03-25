<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InleveransF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InleveransF))
        Me.UppdatlagretB = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Ver = New System.Windows.Forms.GroupBox()
        Me.Gnamn = New System.Windows.Forms.Label()
        Me.KlientIdl = New System.Windows.Forms.Label()
        Me.odbcsource = New System.Windows.Forms.Label()
        Me.databas = New System.Windows.Forms.Label()
        Me.datum = New System.Windows.Forms.Label()
        Me.Versionl = New System.Windows.Forms.Label()
        Me.AvslutaK = New System.Windows.Forms.Button()
        Me.Huvud = New System.Windows.Forms.Button()
        Me.LLandTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LOrtTB = New System.Windows.Forms.TextBox()
        Me.LPostnummerTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LAdress2TB = New System.Windows.Forms.TextBox()
        Me.LAdress1TB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LLevnamnTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LMarkningTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LEpostTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LTelefonTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LKommentTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LvartreferensTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LvartkundnrTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DatumTB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LnormallevtidTB = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LInLevtypTB = New System.Windows.Forms.ComboBox()
        Me.AltProdB = New System.Windows.Forms.Button()
        Me.HamptaBristB = New System.Windows.Forms.Button()
        Me.SkapaXMLB = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NyB = New System.Windows.Forms.Button()
        Me.Bak = New System.Windows.Forms.Button()
        Me.Fram = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SummaL = New System.Windows.Forms.Label()
        Me.BestNRTB = New System.Windows.Forms.ComboBox()
        Me.rrl = New System.Windows.Forms.Label()
        Me.rmaxl = New System.Windows.Forms.Label()
        Me.UtskriftB = New System.Windows.Forms.Button()
        Me.FGCB = New System.Windows.Forms.CheckBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProduktVsLeverantörerInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeverantörRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LLevnrTB = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ver.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UppdatlagretB
        '
        Me.UppdatlagretB.Enabled = False
        Me.UppdatlagretB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UppdatlagretB.ForeColor = System.Drawing.Color.Maroon
        Me.UppdatlagretB.Location = New System.Drawing.Point(925, 642)
        Me.UppdatlagretB.Margin = New System.Windows.Forms.Padding(4)
        Me.UppdatlagretB.Name = "UppdatlagretB"
        Me.UppdatlagretB.Size = New System.Drawing.Size(155, 31)
        Me.UppdatlagretB.TabIndex = 280
        Me.UppdatlagretB.Text = "Uppdatera lagret"
        Me.UppdatlagretB.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 291)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1393, 260)
        Me.DataGridView1.TabIndex = 279
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
        Me.Ver.Location = New System.Drawing.Point(16, 635)
        Me.Ver.Margin = New System.Windows.Forms.Padding(4)
        Me.Ver.Name = "Ver"
        Me.Ver.Padding = New System.Windows.Forms.Padding(4)
        Me.Ver.Size = New System.Drawing.Size(263, 90)
        Me.Ver.TabIndex = 278
        Me.Ver.TabStop = False
        Me.Ver.Text = "Version"
        '
        'Gnamn
        '
        Me.Gnamn.Location = New System.Drawing.Point(12, 70)
        Me.Gnamn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Gnamn.Name = "Gnamn"
        Me.Gnamn.Size = New System.Drawing.Size(243, 16)
        Me.Gnamn.TabIndex = 17
        Me.Gnamn.Text = "Företagsnamn"
        Me.Gnamn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KlientIdl
        '
        Me.KlientIdl.Location = New System.Drawing.Point(8, 16)
        Me.KlientIdl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.KlientIdl.Name = "KlientIdl"
        Me.KlientIdl.Size = New System.Drawing.Size(247, 16)
        Me.KlientIdl.TabIndex = 4
        Me.KlientIdl.Text = "Klientid"
        Me.KlientIdl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'odbcsource
        '
        Me.odbcsource.Location = New System.Drawing.Point(8, 52)
        Me.odbcsource.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.odbcsource.Name = "odbcsource"
        Me.odbcsource.Size = New System.Drawing.Size(247, 16)
        Me.odbcsource.TabIndex = 3
        Me.odbcsource.Text = "Odbcsource"
        Me.odbcsource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'databas
        '
        Me.databas.Location = New System.Drawing.Point(8, 32)
        Me.databas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.databas.Name = "databas"
        Me.databas.Size = New System.Drawing.Size(247, 16)
        Me.databas.TabIndex = 2
        Me.databas.Text = "Databas"
        Me.databas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'datum
        '
        Me.datum.AutoSize = True
        Me.datum.Location = New System.Drawing.Point(160, 0)
        Me.datum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.datum.Name = "datum"
        Me.datum.Size = New System.Drawing.Size(46, 16)
        Me.datum.TabIndex = 1
        Me.datum.Text = "Datum"
        '
        'Versionl
        '
        Me.Versionl.AutoSize = True
        Me.Versionl.Location = New System.Drawing.Point(29, 20)
        Me.Versionl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Versionl.Name = "Versionl"
        Me.Versionl.Size = New System.Drawing.Size(0, 16)
        Me.Versionl.TabIndex = 0
        '
        'AvslutaK
        '
        Me.AvslutaK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaK.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaK.Location = New System.Drawing.Point(1231, 695)
        Me.AvslutaK.Margin = New System.Windows.Forms.Padding(4)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(155, 31)
        Me.AvslutaK.TabIndex = 277
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(541, 15)
        Me.Huvud.Margin = New System.Windows.Forms.Padding(4)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(762, 44)
        Me.Huvud.TabIndex = 276
        Me.Huvud.Text = "Inleveranser"
        Me.Huvud.UseVisualStyleBackColor = True
        '
        'LLandTB
        '
        Me.LLandTB.Location = New System.Drawing.Point(137, 213)
        Me.LLandTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LLandTB.Name = "LLandTB"
        Me.LLandTB.Size = New System.Drawing.Size(295, 22)
        Me.LLandTB.TabIndex = 290
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 289
        Me.Label4.Text = "Land"
        '
        'LOrtTB
        '
        Me.LOrtTB.Location = New System.Drawing.Point(214, 181)
        Me.LOrtTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LOrtTB.Name = "LOrtTB"
        Me.LOrtTB.Size = New System.Drawing.Size(217, 22)
        Me.LOrtTB.TabIndex = 288
        '
        'LPostnummerTB
        '
        Me.LPostnummerTB.Location = New System.Drawing.Point(137, 181)
        Me.LPostnummerTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LPostnummerTB.Name = "LPostnummerTB"
        Me.LPostnummerTB.Size = New System.Drawing.Size(68, 22)
        Me.LPostnummerTB.TabIndex = 287
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 286
        Me.Label3.Text = "Postnr/Ort"
        '
        'LAdress2TB
        '
        Me.LAdress2TB.Location = New System.Drawing.Point(137, 149)
        Me.LAdress2TB.Margin = New System.Windows.Forms.Padding(4)
        Me.LAdress2TB.Name = "LAdress2TB"
        Me.LAdress2TB.Size = New System.Drawing.Size(295, 22)
        Me.LAdress2TB.TabIndex = 285
        '
        'LAdress1TB
        '
        Me.LAdress1TB.Location = New System.Drawing.Point(137, 117)
        Me.LAdress1TB.Margin = New System.Windows.Forms.Padding(4)
        Me.LAdress1TB.Name = "LAdress1TB"
        Me.LAdress1TB.Size = New System.Drawing.Size(295, 22)
        Me.LAdress1TB.TabIndex = 284
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 283
        Me.Label2.Text = "Adress"
        '
        'LLevnamnTB
        '
        Me.LLevnamnTB.Location = New System.Drawing.Point(137, 85)
        Me.LLevnamnTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LLevnamnTB.Name = "LLevnamnTB"
        Me.LLevnamnTB.Size = New System.Drawing.Size(295, 22)
        Me.LLevnamnTB.TabIndex = 282
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 281
        Me.Label1.Text = "LeverantörNamn"
        '
        'LMarkningTB
        '
        Me.LMarkningTB.Location = New System.Drawing.Point(620, 130)
        Me.LMarkningTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LMarkningTB.Name = "LMarkningTB"
        Me.LMarkningTB.Size = New System.Drawing.Size(295, 22)
        Me.LMarkningTB.TabIndex = 296
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(525, 135)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 295
        Me.Label9.Text = "Märkning"
        '
        'LEpostTB
        '
        Me.LEpostTB.Location = New System.Drawing.Point(620, 98)
        Me.LEpostTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LEpostTB.Name = "LEpostTB"
        Me.LEpostTB.Size = New System.Drawing.Size(295, 22)
        Me.LEpostTB.TabIndex = 294
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(525, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 293
        Me.Label6.Text = "Epost"
        '
        'LTelefonTB
        '
        Me.LTelefonTB.Location = New System.Drawing.Point(620, 66)
        Me.LTelefonTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LTelefonTB.Name = "LTelefonTB"
        Me.LTelefonTB.Size = New System.Drawing.Size(295, 22)
        Me.LTelefonTB.TabIndex = 292
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(519, 70)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 291
        Me.Label7.Text = "Telefon"
        '
        'LKommentTB
        '
        Me.LKommentTB.Location = New System.Drawing.Point(620, 165)
        Me.LKommentTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LKommentTB.Multiline = True
        Me.LKommentTB.Name = "LKommentTB"
        Me.LKommentTB.Size = New System.Drawing.Size(295, 86)
        Me.LKommentTB.TabIndex = 298
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(467, 165)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 297
        Me.Label5.Text = "Kontakt uppgifter"
        '
        'LvartreferensTB
        '
        Me.LvartreferensTB.Location = New System.Drawing.Point(1128, 128)
        Me.LvartreferensTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LvartreferensTB.Name = "LvartreferensTB"
        Me.LvartreferensTB.Size = New System.Drawing.Size(241, 22)
        Me.LvartreferensTB.TabIndex = 304
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1056, 133)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 303
        Me.Label8.Text = "Vårref"
        '
        'LvartkundnrTB
        '
        Me.LvartkundnrTB.Location = New System.Drawing.Point(1128, 96)
        Me.LvartkundnrTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LvartkundnrTB.Name = "LvartkundnrTB"
        Me.LvartkundnrTB.Size = New System.Drawing.Size(241, 22)
        Me.LvartkundnrTB.TabIndex = 302
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1021, 98)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 20)
        Me.Label10.TabIndex = 301
        Me.Label10.Text = "Vårtkundnr"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1056, 65)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 20)
        Me.Label11.TabIndex = 299
        Me.Label11.Text = "Bestnr"
        '
        'DatumTB
        '
        Me.DatumTB.Location = New System.Drawing.Point(1128, 161)
        Me.DatumTB.Margin = New System.Windows.Forms.Padding(4)
        Me.DatumTB.Name = "DatumTB"
        Me.DatumTB.Size = New System.Drawing.Size(179, 22)
        Me.DatumTB.TabIndex = 306
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1056, 162)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 20)
        Me.Label12.TabIndex = 305
        Me.Label12.Text = "Datum"
        '
        'LnormallevtidTB
        '
        Me.LnormallevtidTB.Location = New System.Drawing.Point(1128, 193)
        Me.LnormallevtidTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LnormallevtidTB.Name = "LnormallevtidTB"
        Me.LnormallevtidTB.Size = New System.Drawing.Size(89, 22)
        Me.LnormallevtidTB.TabIndex = 308
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1000, 193)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 20)
        Me.Label13.TabIndex = 307
        Me.Label13.Text = "Normal lev tid"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1227, 193)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 20)
        Me.Label14.TabIndex = 309
        Me.Label14.Text = "dagar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1021, 226)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 20)
        Me.Label15.TabIndex = 336
        Me.Label15.Text = "Typ/Status"
        '
        'LInLevtypTB
        '
        Me.LInLevtypTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LInLevtypTB.FormattingEnabled = True
        Me.LInLevtypTB.Items.AddRange(New Object() {"OffertBegäran", "Beställning"})
        Me.LInLevtypTB.Location = New System.Drawing.Point(1128, 225)
        Me.LInLevtypTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LInLevtypTB.Name = "LInLevtypTB"
        Me.LInLevtypTB.Size = New System.Drawing.Size(192, 25)
        Me.LInLevtypTB.TabIndex = 337
        Me.LInLevtypTB.Text = "Inköp"
        '
        'AltProdB
        '
        Me.AltProdB.Enabled = False
        Me.AltProdB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltProdB.ForeColor = System.Drawing.Color.Maroon
        Me.AltProdB.Location = New System.Drawing.Point(493, 588)
        Me.AltProdB.Margin = New System.Windows.Forms.Padding(4)
        Me.AltProdB.Name = "AltProdB"
        Me.AltProdB.Size = New System.Drawing.Size(155, 31)
        Me.AltProdB.TabIndex = 338
        Me.AltProdB.Text = "Alternativprodukter"
        Me.AltProdB.UseVisualStyleBackColor = True
        '
        'HamptaBristB
        '
        Me.HamptaBristB.Enabled = False
        Me.HamptaBristB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HamptaBristB.ForeColor = System.Drawing.Color.Maroon
        Me.HamptaBristB.Location = New System.Drawing.Point(493, 642)
        Me.HamptaBristB.Margin = New System.Windows.Forms.Padding(4)
        Me.HamptaBristB.Name = "HamptaBristB"
        Me.HamptaBristB.Size = New System.Drawing.Size(155, 31)
        Me.HamptaBristB.TabIndex = 339
        Me.HamptaBristB.Text = "Hämtabristlistan"
        Me.HamptaBristB.UseVisualStyleBackColor = True
        '
        'SkapaXMLB
        '
        Me.SkapaXMLB.Enabled = False
        Me.SkapaXMLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkapaXMLB.ForeColor = System.Drawing.Color.Maroon
        Me.SkapaXMLB.Location = New System.Drawing.Point(925, 588)
        Me.SkapaXMLB.Margin = New System.Windows.Forms.Padding(4)
        Me.SkapaXMLB.Name = "SkapaXMLB"
        Me.SkapaXMLB.Size = New System.Drawing.Size(155, 31)
        Me.SkapaXMLB.TabIndex = 340
        Me.SkapaXMLB.Text = "Skapa XML fil"
        Me.SkapaXMLB.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Maroon
        Me.Button4.Location = New System.Drawing.Point(1231, 626)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(155, 31)
        Me.Button4.TabIndex = 341
        Me.Button4.Text = "Spara"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NyB
        '
        Me.NyB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NyB.ForeColor = System.Drawing.Color.Maroon
        Me.NyB.Location = New System.Drawing.Point(493, 694)
        Me.NyB.Margin = New System.Windows.Forms.Padding(4)
        Me.NyB.Name = "NyB"
        Me.NyB.Size = New System.Drawing.Size(155, 31)
        Me.NyB.TabIndex = 342
        Me.NyB.Text = "Ny"
        Me.NyB.UseVisualStyleBackColor = True
        '
        'Bak
        '
        Me.Bak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bak.ForeColor = System.Drawing.Color.Maroon
        Me.Bak.Location = New System.Drawing.Point(298, 251)
        Me.Bak.Margin = New System.Windows.Forms.Padding(4)
        Me.Bak.Name = "Bak"
        Me.Bak.Size = New System.Drawing.Size(61, 31)
        Me.Bak.TabIndex = 344
        Me.Bak.Text = "Bak"
        Me.Bak.UseVisualStyleBackColor = True
        '
        'Fram
        '
        Me.Fram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fram.ForeColor = System.Drawing.Color.Maroon
        Me.Fram.Location = New System.Drawing.Point(366, 251)
        Me.Fram.Margin = New System.Windows.Forms.Padding(4)
        Me.Fram.Name = "Fram"
        Me.Fram.Size = New System.Drawing.Size(63, 31)
        Me.Fram.TabIndex = 343
        Me.Fram.Text = "Fram"
        Me.Fram.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1153, 556)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 346
        Me.Label16.Text = "Summa"
        '
        'SummaL
        '
        Me.SummaL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SummaL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaL.Location = New System.Drawing.Point(1231, 555)
        Me.SummaL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SummaL.Name = "SummaL"
        Me.SummaL.Size = New System.Drawing.Size(149, 28)
        Me.SummaL.TabIndex = 345
        Me.SummaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BestNRTB
        '
        Me.BestNRTB.FormattingEnabled = True
        Me.BestNRTB.Location = New System.Drawing.Point(1128, 68)
        Me.BestNRTB.Margin = New System.Windows.Forms.Padding(4)
        Me.BestNRTB.Name = "BestNRTB"
        Me.BestNRTB.Size = New System.Drawing.Size(241, 24)
        Me.BestNRTB.TabIndex = 348
        '
        'rrl
        '
        Me.rrl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rrl.Location = New System.Drawing.Point(3, 273)
        Me.rrl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.rrl.Name = "rrl"
        Me.rrl.Size = New System.Drawing.Size(25, 25)
        Me.rrl.TabIndex = 350
        Me.rrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rmaxl
        '
        Me.rmaxl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rmaxl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rmaxl.Location = New System.Drawing.Point(3, 305)
        Me.rmaxl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.rmaxl.Name = "rmaxl"
        Me.rmaxl.Size = New System.Drawing.Size(25, 25)
        Me.rmaxl.TabIndex = 349
        Me.rmaxl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UtskriftB
        '
        Me.UtskriftB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UtskriftB.ForeColor = System.Drawing.Color.Maroon
        Me.UtskriftB.Location = New System.Drawing.Point(925, 690)
        Me.UtskriftB.Margin = New System.Windows.Forms.Padding(4)
        Me.UtskriftB.Name = "UtskriftB"
        Me.UtskriftB.Size = New System.Drawing.Size(155, 31)
        Me.UtskriftB.TabIndex = 351
        Me.UtskriftB.Text = "Utskrift"
        Me.UtskriftB.UseVisualStyleBackColor = True
        '
        'FGCB
        '
        Me.FGCB.AutoSize = True
        Me.FGCB.Checked = True
        Me.FGCB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FGCB.Location = New System.Drawing.Point(938, 729)
        Me.FGCB.Margin = New System.Windows.Forms.Padding(4)
        Me.FGCB.Name = "FGCB"
        Me.FGCB.Size = New System.Drawing.Size(152, 20)
        Me.FGCB.TabIndex = 352
        Me.FGCB.Text = "Förhandsgranskning"
        Me.FGCB.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProduktVsLeverantörerInfoToolStripMenuItem, Me.LeverantörRegisterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1464, 33)
        Me.MenuStrip1.TabIndex = 353
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProduktVsLeverantörerInfoToolStripMenuItem
        '
        Me.ProduktVsLeverantörerInfoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProduktVsLeverantörerInfoToolStripMenuItem.Name = "ProduktVsLeverantörerInfoToolStripMenuItem"
        Me.ProduktVsLeverantörerInfoToolStripMenuItem.Size = New System.Drawing.Size(265, 29)
        Me.ProduktVsLeverantörerInfoToolStripMenuItem.Text = "Produkt vs Leverantörer Info"
        '
        'LeverantörRegisterToolStripMenuItem
        '
        Me.LeverantörRegisterToolStripMenuItem.Name = "LeverantörRegisterToolStripMenuItem"
        Me.LeverantörRegisterToolStripMenuItem.Size = New System.Drawing.Size(147, 29)
        Me.LeverantörRegisterToolStripMenuItem.Text = "Leverantör register"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 53)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 20)
        Me.Label17.TabIndex = 354
        Me.Label17.Text = "LeverantörNr"
        '
        'LLevnrTB
        '
        Me.LLevnrTB.Location = New System.Drawing.Point(136, 55)
        Me.LLevnrTB.Margin = New System.Windows.Forms.Padding(4)
        Me.LLevnrTB.Name = "LLevnrTB"
        Me.LLevnrTB.Size = New System.Drawing.Size(133, 22)
        Me.LLevnrTB.TabIndex = 355
        '
        'InleveransF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1464, 759)
        Me.Controls.Add(Me.LLevnrTB)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.FGCB)
        Me.Controls.Add(Me.UtskriftB)
        Me.Controls.Add(Me.rrl)
        Me.Controls.Add(Me.rmaxl)
        Me.Controls.Add(Me.BestNRTB)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.SummaL)
        Me.Controls.Add(Me.Bak)
        Me.Controls.Add(Me.Fram)
        Me.Controls.Add(Me.NyB)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.SkapaXMLB)
        Me.Controls.Add(Me.HamptaBristB)
        Me.Controls.Add(Me.AltProdB)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LInLevtypTB)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LnormallevtidTB)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DatumTB)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LvartreferensTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LvartkundnrTB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LKommentTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LMarkningTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LEpostTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LTelefonTB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LLandTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LOrtTB)
        Me.Controls.Add(Me.LPostnummerTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LAdress2TB)
        Me.Controls.Add(Me.LAdress1TB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LLevnamnTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UppdatlagretB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.Huvud)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InleveransF"
        Me.Text = "Inleveranser"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UppdatlagretB As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Ver As System.Windows.Forms.GroupBox
    Friend WithEvents Gnamn As System.Windows.Forms.Label
    Friend WithEvents KlientIdl As System.Windows.Forms.Label
    Friend WithEvents odbcsource As System.Windows.Forms.Label
    Friend WithEvents databas As System.Windows.Forms.Label
    Friend WithEvents datum As System.Windows.Forms.Label
    Friend WithEvents Versionl As System.Windows.Forms.Label
    Friend WithEvents AvslutaK As System.Windows.Forms.Button
    Friend WithEvents Huvud As System.Windows.Forms.Button
    Friend WithEvents LLandTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LOrtTB As System.Windows.Forms.TextBox
    Friend WithEvents LPostnummerTB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LAdress2TB As System.Windows.Forms.TextBox
    Friend WithEvents LAdress1TB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LLevnamnTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LMarkningTB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LEpostTB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LTelefonTB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LKommentTB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LvartreferensTB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LvartkundnrTB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DatumTB As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LnormallevtidTB As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LInLevtypTB As System.Windows.Forms.ComboBox
    Friend WithEvents AltProdB As System.Windows.Forms.Button
    Friend WithEvents HamptaBristB As System.Windows.Forms.Button
    Friend WithEvents SkapaXMLB As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents NyB As System.Windows.Forms.Button
    Friend WithEvents Bak As System.Windows.Forms.Button
    Friend WithEvents Fram As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SummaL As System.Windows.Forms.Label
    Friend WithEvents BestNRTB As System.Windows.Forms.ComboBox
    Friend WithEvents rrl As System.Windows.Forms.Label
    Friend WithEvents rmaxl As System.Windows.Forms.Label
    Friend WithEvents UtskriftB As Button
    Friend WithEvents FGCB As CheckBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProduktVsLeverantörerInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeverantörRegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label17 As Label
    Friend WithEvents LLevnrTB As TextBox
End Class
