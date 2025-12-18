<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProduktKomponenterF
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
        Me.odbcsourcel = New System.Windows.Forms.Label()
        Me.databas = New System.Windows.Forms.Label()
        Me.datum = New System.Windows.Forms.Label()
        Me.Versionl = New System.Windows.Forms.Label()
        Me.AvslutaB = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NewLabKomponentB = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KommentsTB = New System.Windows.Forms.TextBox()
        Me.RaderaB = New System.Windows.Forms.Button()
        Me.KomponentNamnTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KomponentIDTB = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.SparaB = New System.Windows.Forms.Button()
        Me.SokTB = New System.Windows.Forms.TextBox()
        Me.NewLabLeverantorB = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Sok3TB = New System.Windows.Forms.TextBox()
        Me.LevIDTB = New System.Windows.Forms.TextBox()
        Me.LeverantorID = New System.Windows.Forms.Label()
        Me.LevNamnTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LevKommentsTB = New System.Windows.Forms.TextBox()
        Me.SparaLevB = New System.Windows.Forms.Button()
        Me.RaderaLevB = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LevlankTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SparaLankadeInfoB = New System.Windows.Forms.Button()
        Me.RaderaLankadeInfoB = New System.Windows.Forms.Button()
        Me.Ver.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(447, 10)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(429, 30)
        Me.Huvud.TabIndex = 326
        Me.Huvud.Text = "ProduktKomponenter"
        Me.Huvud.UseVisualStyleBackColor = True
        '
        'Ver
        '
        Me.Ver.Controls.Add(Me.Gnamn)
        Me.Ver.Controls.Add(Me.KlientIdl)
        Me.Ver.Controls.Add(Me.odbcsourcel)
        Me.Ver.Controls.Add(Me.databas)
        Me.Ver.Controls.Add(Me.datum)
        Me.Ver.Controls.Add(Me.Versionl)
        Me.Ver.ForeColor = System.Drawing.Color.Gray
        Me.Ver.Location = New System.Drawing.Point(10, 572)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(197, 73)
        Me.Ver.TabIndex = 327
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
        'odbcsourcel
        '
        Me.odbcsourcel.Location = New System.Drawing.Point(6, 42)
        Me.odbcsourcel.Name = "odbcsourcel"
        Me.odbcsourcel.Size = New System.Drawing.Size(185, 13)
        Me.odbcsourcel.TabIndex = 3
        Me.odbcsourcel.Text = "Odbcsource"
        Me.odbcsourcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'AvslutaB
        '
        Me.AvslutaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AvslutaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaB.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaB.Location = New System.Drawing.Point(1337, 608)
        Me.AvslutaB.Name = "AvslutaB"
        Me.AvslutaB.Size = New System.Drawing.Size(91, 25)
        Me.AvslutaB.TabIndex = 374
        Me.AvslutaB.Text = "Avsluta"
        Me.AvslutaB.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(268, 415)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(404, 134)
        Me.DataGridView1.TabIndex = 375
        Me.DataGridView1.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(16, 263)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(404, 133)
        Me.DataGridView2.TabIndex = 376
        '
        'NewLabKomponentB
        '
        Me.NewLabKomponentB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewLabKomponentB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabKomponentB.ForeColor = System.Drawing.Color.Maroon
        Me.NewLabKomponentB.Location = New System.Drawing.Point(307, 617)
        Me.NewLabKomponentB.Name = "NewLabKomponentB"
        Me.NewLabKomponentB.Size = New System.Drawing.Size(181, 25)
        Me.NewLabKomponentB.TabIndex = 377
        Me.NewLabKomponentB.Text = "Ny LabKomponent"
        Me.NewLabKomponentB.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 386
        Me.Label3.Text = "Kommentarer/Krav"
        '
        'KommentsTB
        '
        Me.KommentsTB.Location = New System.Drawing.Point(21, 92)
        Me.KommentsTB.Multiline = True
        Me.KommentsTB.Name = "KommentsTB"
        Me.KommentsTB.Size = New System.Drawing.Size(400, 107)
        Me.KommentsTB.TabIndex = 385
        '
        'RaderaB
        '
        Me.RaderaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaderaB.ForeColor = System.Drawing.Color.Maroon
        Me.RaderaB.Location = New System.Drawing.Point(68, 205)
        Me.RaderaB.Name = "RaderaB"
        Me.RaderaB.Size = New System.Drawing.Size(159, 25)
        Me.RaderaB.TabIndex = 384
        Me.RaderaB.Text = "Radera Labkomponent"
        Me.RaderaB.UseVisualStyleBackColor = True
        '
        'KomponentNamnTB
        '
        Me.KomponentNamnTB.Location = New System.Drawing.Point(135, 33)
        Me.KomponentNamnTB.Name = "KomponentNamnTB"
        Me.KomponentNamnTB.Size = New System.Drawing.Size(249, 20)
        Me.KomponentNamnTB.TabIndex = 381
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 380
        Me.Label1.Text = "Komponent Namn"
        '
        'KomponentIDTB
        '
        Me.KomponentIDTB.Location = New System.Drawing.Point(135, 9)
        Me.KomponentIDTB.Name = "KomponentIDTB"
        Me.KomponentIDTB.Size = New System.Drawing.Size(110, 20)
        Me.KomponentIDTB.TabIndex = 379
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(30, 9)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 17)
        Me.Label26.TabIndex = 378
        Me.Label26.Text = "Komponent ID"
        '
        'SparaB
        '
        Me.SparaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaB.Location = New System.Drawing.Point(268, 205)
        Me.SparaB.Name = "SparaB"
        Me.SparaB.Size = New System.Drawing.Size(151, 25)
        Me.SparaB.TabIndex = 387
        Me.SparaB.Text = "Spara LabKomponent"
        Me.SparaB.UseVisualStyleBackColor = True
        '
        'SokTB
        '
        Me.SokTB.Location = New System.Drawing.Point(398, 555)
        Me.SokTB.Name = "SokTB"
        Me.SokTB.Size = New System.Drawing.Size(176, 20)
        Me.SokTB.TabIndex = 389
        Me.SokTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SokTB.Visible = False
        '
        'NewLabLeverantorB
        '
        Me.NewLabLeverantorB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewLabLeverantorB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLabLeverantorB.ForeColor = System.Drawing.Color.Maroon
        Me.NewLabLeverantorB.Location = New System.Drawing.Point(827, 617)
        Me.NewLabLeverantorB.Name = "NewLabLeverantorB"
        Me.NewLabLeverantorB.Size = New System.Drawing.Size(181, 25)
        Me.NewLabLeverantorB.TabIndex = 390
        Me.NewLabLeverantorB.Text = "Ny LabLeverantör"
        Me.NewLabLeverantorB.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(703, 415)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(404, 134)
        Me.DataGridView3.TabIndex = 391
        Me.DataGridView3.Visible = False
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(949, 263)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.Size = New System.Drawing.Size(404, 133)
        Me.DataGridView4.TabIndex = 393
        '
        'Sok3TB
        '
        Me.Sok3TB.Location = New System.Drawing.Point(827, 555)
        Me.Sok3TB.Name = "Sok3TB"
        Me.Sok3TB.Size = New System.Drawing.Size(176, 20)
        Me.Sok3TB.TabIndex = 394
        Me.Sok3TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sok3TB.Visible = False
        '
        'LevIDTB
        '
        Me.LevIDTB.Location = New System.Drawing.Point(1054, 6)
        Me.LevIDTB.Name = "LevIDTB"
        Me.LevIDTB.Size = New System.Drawing.Size(110, 20)
        Me.LevIDTB.TabIndex = 396
        '
        'LeverantorID
        '
        Me.LeverantorID.AutoSize = True
        Me.LeverantorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeverantorID.Location = New System.Drawing.Point(949, 6)
        Me.LeverantorID.Name = "LeverantorID"
        Me.LeverantorID.Size = New System.Drawing.Size(94, 17)
        Me.LeverantorID.TabIndex = 395
        Me.LeverantorID.Text = "Leverantör ID"
        '
        'LevNamnTB
        '
        Me.LevNamnTB.Location = New System.Drawing.Point(1054, 33)
        Me.LevNamnTB.Name = "LevNamnTB"
        Me.LevNamnTB.Size = New System.Drawing.Size(280, 20)
        Me.LevNamnTB.TabIndex = 398
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(949, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 397
        Me.Label2.Text = "Leverantör Namn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(949, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 400
        Me.Label4.Text = "Anteckningar"
        '
        'LevKommentsTB
        '
        Me.LevKommentsTB.Location = New System.Drawing.Point(949, 92)
        Me.LevKommentsTB.Multiline = True
        Me.LevKommentsTB.Name = "LevKommentsTB"
        Me.LevKommentsTB.Size = New System.Drawing.Size(443, 107)
        Me.LevKommentsTB.TabIndex = 399
        '
        'SparaLevB
        '
        Me.SparaLevB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaLevB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaLevB.Location = New System.Drawing.Point(1192, 205)
        Me.SparaLevB.Name = "SparaLevB"
        Me.SparaLevB.Size = New System.Drawing.Size(141, 25)
        Me.SparaLevB.TabIndex = 402
        Me.SparaLevB.Text = "Spara Leverantör"
        Me.SparaLevB.UseVisualStyleBackColor = True
        '
        'RaderaLevB
        '
        Me.RaderaLevB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaderaLevB.ForeColor = System.Drawing.Color.Maroon
        Me.RaderaLevB.Location = New System.Drawing.Point(984, 205)
        Me.RaderaLevB.Name = "RaderaLevB"
        Me.RaderaLevB.Size = New System.Drawing.Size(145, 25)
        Me.RaderaLevB.TabIndex = 401
        Me.RaderaLevB.Text = "Radera Leverantör"
        Me.RaderaLevB.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(95, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 22)
        Me.Label5.TabIndex = 403
        Me.Label5.Text = "Registrerade LabKomponenter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(1037, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 22)
        Me.Label6.TabIndex = 404
        Me.Label6.Text = "Registrerade LabLeverantörer"
        '
        'LevlankTB
        '
        Me.LevlankTB.Location = New System.Drawing.Point(477, 153)
        Me.LevlankTB.Multiline = True
        Me.LevlankTB.Name = "LevlankTB"
        Me.LevlankTB.Size = New System.Drawing.Size(400, 153)
        Me.LevlankTB.TabIndex = 405
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(477, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(411, 19)
        Me.Label7.TabIndex = 406
        Me.Label7.Text = "Anteckningar om den leverantör med denna komponent"
        '
        'SparaLankadeInfoB
        '
        Me.SparaLankadeInfoB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaLankadeInfoB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaLankadeInfoB.Location = New System.Drawing.Point(735, 311)
        Me.SparaLankadeInfoB.Name = "SparaLankadeInfoB"
        Me.SparaLankadeInfoB.Size = New System.Drawing.Size(141, 25)
        Me.SparaLankadeInfoB.TabIndex = 408
        Me.SparaLankadeInfoB.Text = "Spara Länkade Info"
        Me.SparaLankadeInfoB.UseVisualStyleBackColor = True
        '
        'RaderaLankadeInfoB
        '
        Me.RaderaLankadeInfoB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaderaLankadeInfoB.ForeColor = System.Drawing.Color.Maroon
        Me.RaderaLankadeInfoB.Location = New System.Drawing.Point(477, 311)
        Me.RaderaLankadeInfoB.Name = "RaderaLankadeInfoB"
        Me.RaderaLankadeInfoB.Size = New System.Drawing.Size(145, 25)
        Me.RaderaLankadeInfoB.TabIndex = 407
        Me.RaderaLankadeInfoB.Text = "Radera Länkade info"
        Me.RaderaLankadeInfoB.UseVisualStyleBackColor = True
        '
        'ProduktKomponenterF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1283, 663)
        Me.Controls.Add(Me.SparaLankadeInfoB)
        Me.Controls.Add(Me.RaderaLankadeInfoB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LevlankTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SparaLevB)
        Me.Controls.Add(Me.RaderaLevB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LevKommentsTB)
        Me.Controls.Add(Me.LevNamnTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LevIDTB)
        Me.Controls.Add(Me.LeverantorID)
        Me.Controls.Add(Me.Sok3TB)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.NewLabLeverantorB)
        Me.Controls.Add(Me.SokTB)
        Me.Controls.Add(Me.SparaB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.KommentsTB)
        Me.Controls.Add(Me.RaderaB)
        Me.Controls.Add(Me.KomponentNamnTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KomponentIDTB)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.NewLabKomponentB)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AvslutaB)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Huvud)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "ProduktKomponenterF"
        Me.Text = "Produkt Komponenter"
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Huvud As Button
    Friend WithEvents Ver As GroupBox
    Friend WithEvents Gnamn As Label
    Friend WithEvents KlientIdl As Label
    Friend WithEvents odbcsourcel As Label
    Friend WithEvents databas As Label
    Friend WithEvents datum As Label
    Friend WithEvents Versionl As Label
    Friend WithEvents AvslutaB As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents NewLabKomponentB As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents KommentsTB As TextBox
    Friend WithEvents RaderaB As Button
    Friend WithEvents KomponentNamnTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents KomponentIDTB As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents SparaB As Button
    Friend WithEvents SokTB As TextBox
    Friend WithEvents NewLabLeverantorB As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Sok3TB As TextBox
    Friend WithEvents LevIDTB As TextBox
    Friend WithEvents LeverantorID As Label
    Friend WithEvents LevNamnTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LevKommentsTB As TextBox
    Friend WithEvents SparaLevB As Button
    Friend WithEvents RaderaLevB As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LevlankTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SparaLankadeInfoB As Button
    Friend WithEvents RaderaLankadeInfoB As Button
End Class
