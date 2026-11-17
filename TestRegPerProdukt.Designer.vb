<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestregPerProduktF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Huvud = New System.Windows.Forms.Button()
        Me.Ver = New System.Windows.Forms.GroupBox()
        Me.Gnamn = New System.Windows.Forms.Label()
        Me.KlientIdl = New System.Windows.Forms.Label()
        Me.odbcsource = New System.Windows.Forms.Label()
        Me.databas = New System.Windows.Forms.Label()
        Me.datum = New System.Windows.Forms.Label()
        Me.Versionl = New System.Windows.Forms.Label()
        Me.AvslutaK = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.AddProduktB = New System.Windows.Forms.Button()
        Me.TestnamnCB = New System.Windows.Forms.ComboBox()
        Me.InfogaB = New System.Windows.Forms.Button()
        Me.ProduktIDL = New System.Windows.Forms.Label()
        Me.SparaB = New System.Windows.Forms.Button()
        Me.MetodTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EnhetTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MinvärdeTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaxvärdeTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AnnanInfoTB = New System.Windows.Forms.TextBox()
        Me.SparaSTDTestB = New System.Windows.Forms.Button()
        Me.ProduktIDTB = New System.Windows.Forms.TextBox()
        Me.RaderaProduktB = New System.Windows.Forms.Button()
        Me.RaderafranSTDtestB = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabortB = New System.Windows.Forms.Button()
        Me.ProvkroppL = New System.Windows.Forms.Label()
        Me.ProvkroppTB = New System.Windows.Forms.TextBox()
        Me.MoveUPBtn = New System.Windows.Forms.Button()
        Me.MoveDownBtn = New System.Windows.Forms.Button()
        Me.HanteraB = New System.Windows.Forms.Button()
        Me.Ver.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(60, 11)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(782, 36)
        Me.Huvud.TabIndex = 277
        Me.Huvud.Text = "Provregister"
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
        Me.Ver.Location = New System.Drawing.Point(22, 723)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(197, 73)
        Me.Ver.TabIndex = 322
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
        Me.databas.Location = New System.Drawing.Point(12, 26)
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
        'AvslutaK
        '
        Me.AvslutaK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaK.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaK.Location = New System.Drawing.Point(870, 780)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(98, 25)
        Me.AvslutaK.TabIndex = 321
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 374)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(965, 343)
        Me.DataGridView1.TabIndex = 324
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(57, 61)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(73, 17)
        Me.Label26.TabIndex = 360
        Me.Label26.Text = "TestNamn"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(787, 739)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 17)
        Me.Label10.TabIndex = 382
        Me.Label10.Text = "  "
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(572, 53)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(183, 128)
        Me.DataGridView2.TabIndex = 473
        '
        'AddProduktB
        '
        Me.AddProduktB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProduktB.ForeColor = System.Drawing.Color.Maroon
        Me.AddProduktB.Location = New System.Drawing.Point(771, 53)
        Me.AddProduktB.Name = "AddProduktB"
        Me.AddProduktB.Size = New System.Drawing.Size(98, 25)
        Me.AddProduktB.TabIndex = 472
        Me.AddProduktB.Text = "Add Produkt"
        Me.AddProduktB.UseVisualStyleBackColor = True
        '
        'TestnamnCB
        '
        Me.TestnamnCB.FormattingEnabled = True
        Me.TestnamnCB.Location = New System.Drawing.Point(127, 61)
        Me.TestnamnCB.Name = "TestnamnCB"
        Me.TestnamnCB.Size = New System.Drawing.Size(176, 21)
        Me.TestnamnCB.TabIndex = 474
        '
        'InfogaB
        '
        Me.InfogaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfogaB.ForeColor = System.Drawing.Color.Maroon
        Me.InfogaB.Location = New System.Drawing.Point(60, 331)
        Me.InfogaB.Name = "InfogaB"
        Me.InfogaB.Size = New System.Drawing.Size(98, 25)
        Me.InfogaB.TabIndex = 475
        Me.InfogaB.Text = "Infoga"
        Me.InfogaB.UseVisualStyleBackColor = True
        '
        'ProduktIDL
        '
        Me.ProduktIDL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProduktIDL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProduktIDL.Location = New System.Drawing.Point(572, 202)
        Me.ProduktIDL.Name = "ProduktIDL"
        Me.ProduktIDL.Size = New System.Drawing.Size(172, 25)
        Me.ProduktIDL.TabIndex = 476
        Me.ProduktIDL.Text = "Välj produkt"
        Me.ProduktIDL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SparaB
        '
        Me.SparaB.Enabled = False
        Me.SparaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaB.Location = New System.Drawing.Point(870, 723)
        Me.SparaB.Name = "SparaB"
        Me.SparaB.Size = New System.Drawing.Size(98, 25)
        Me.SparaB.TabIndex = 477
        Me.SparaB.Text = "Spara"
        Me.SparaB.UseVisualStyleBackColor = True
        '
        'MetodTB
        '
        Me.MetodTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetodTB.Location = New System.Drawing.Point(127, 88)
        Me.MetodTB.Name = "MetodTB"
        Me.MetodTB.Size = New System.Drawing.Size(155, 22)
        Me.MetodTB.TabIndex = 478
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 479
        Me.Label1.Text = "Metod"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 481
        Me.Label2.Text = "Enhet"
        '
        'EnhetTB
        '
        Me.EnhetTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnhetTB.Location = New System.Drawing.Point(127, 119)
        Me.EnhetTB.Name = "EnhetTB"
        Me.EnhetTB.Size = New System.Drawing.Size(92, 22)
        Me.EnhetTB.TabIndex = 480
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 485
        Me.Label3.Text = "Minvärde"
        '
        'MinvärdeTB
        '
        Me.MinvärdeTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinvärdeTB.Location = New System.Drawing.Point(127, 178)
        Me.MinvärdeTB.Name = "MinvärdeTB"
        Me.MinvärdeTB.Size = New System.Drawing.Size(92, 22)
        Me.MinvärdeTB.TabIndex = 484
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 483
        Me.Label4.Text = "Maxvärde"
        '
        'MaxvärdeTB
        '
        Me.MaxvärdeTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxvärdeTB.Location = New System.Drawing.Point(127, 147)
        Me.MaxvärdeTB.Name = "MaxvärdeTB"
        Me.MaxvärdeTB.Size = New System.Drawing.Size(92, 22)
        Me.MaxvärdeTB.TabIndex = 482
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 486
        Me.Label5.Text = "Annan info"
        '
        'AnnanInfoTB
        '
        Me.AnnanInfoTB.Location = New System.Drawing.Point(127, 251)
        Me.AnnanInfoTB.Multiline = True
        Me.AnnanInfoTB.Name = "AnnanInfoTB"
        Me.AnnanInfoTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AnnanInfoTB.Size = New System.Drawing.Size(263, 74)
        Me.AnnanInfoTB.TabIndex = 487
        '
        'SparaSTDTestB
        '
        Me.SparaSTDTestB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaSTDTestB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaSTDTestB.Location = New System.Drawing.Point(350, 80)
        Me.SparaSTDTestB.Name = "SparaSTDTestB"
        Me.SparaSTDTestB.Size = New System.Drawing.Size(161, 25)
        Me.SparaSTDTestB.TabIndex = 488
        Me.SparaSTDTestB.Text = "Spara som STD test"
        Me.SparaSTDTestB.UseVisualStyleBackColor = True
        '
        'ProduktIDTB
        '
        Me.ProduktIDTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProduktIDTB.Location = New System.Drawing.Point(817, 80)
        Me.ProduktIDTB.Name = "ProduktIDTB"
        Me.ProduktIDTB.Size = New System.Drawing.Size(128, 22)
        Me.ProduktIDTB.TabIndex = 489
        '
        'RaderaProduktB
        '
        Me.RaderaProduktB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaderaProduktB.ForeColor = System.Drawing.Color.Maroon
        Me.RaderaProduktB.Location = New System.Drawing.Point(875, 53)
        Me.RaderaProduktB.Name = "RaderaProduktB"
        Me.RaderaProduktB.Size = New System.Drawing.Size(104, 25)
        Me.RaderaProduktB.TabIndex = 490
        Me.RaderaProduktB.Text = " Radera Produkt"
        Me.RaderaProduktB.UseVisualStyleBackColor = True
        '
        'RaderafranSTDtestB
        '
        Me.RaderafranSTDtestB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaderafranSTDtestB.ForeColor = System.Drawing.Color.Maroon
        Me.RaderafranSTDtestB.Location = New System.Drawing.Point(350, 106)
        Me.RaderafranSTDtestB.Name = "RaderafranSTDtestB"
        Me.RaderafranSTDtestB.Size = New System.Drawing.Size(161, 25)
        Me.RaderafranSTDtestB.TabIndex = 491
        Me.RaderafranSTDtestB.Text = "Radera från STD test"
        Me.RaderafranSTDtestB.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(600, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 492
        Me.Label6.Text = "Aktuell produkt"
        '
        'TabortB
        '
        Me.TabortB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabortB.ForeColor = System.Drawing.Color.Maroon
        Me.TabortB.Location = New System.Drawing.Point(389, 331)
        Me.TabortB.Name = "TabortB"
        Me.TabortB.Size = New System.Drawing.Size(98, 25)
        Me.TabortB.TabIndex = 493
        Me.TabortB.Text = "Ta bort"
        Me.TabortB.UseVisualStyleBackColor = True
        '
        'ProvkroppL
        '
        Me.ProvkroppL.AutoSize = True
        Me.ProvkroppL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvkroppL.Location = New System.Drawing.Point(52, 216)
        Me.ProvkroppL.Name = "ProvkroppL"
        Me.ProvkroppL.Size = New System.Drawing.Size(73, 17)
        Me.ProvkroppL.TabIndex = 495
        Me.ProvkroppL.Text = "Provkropp"
        '
        'ProvkroppTB
        '
        Me.ProvkroppTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvkroppTB.Location = New System.Drawing.Point(127, 213)
        Me.ProvkroppTB.Name = "ProvkroppTB"
        Me.ProvkroppTB.Size = New System.Drawing.Size(92, 22)
        Me.ProvkroppTB.TabIndex = 494
        '
        'MoveUPBtn
        '
        Me.MoveUPBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoveUPBtn.ForeColor = System.Drawing.Color.Maroon
        Me.MoveUPBtn.Location = New System.Drawing.Point(389, 176)
        Me.MoveUPBtn.Name = "MoveUPBtn"
        Me.MoveUPBtn.Size = New System.Drawing.Size(98, 25)
        Me.MoveUPBtn.TabIndex = 496
        Me.MoveUPBtn.Text = "Flytta upp"
        Me.MoveUPBtn.UseVisualStyleBackColor = True
        '
        'MoveDownBtn
        '
        Me.MoveDownBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoveDownBtn.ForeColor = System.Drawing.Color.Maroon
        Me.MoveDownBtn.Location = New System.Drawing.Point(389, 207)
        Me.MoveDownBtn.Name = "MoveDownBtn"
        Me.MoveDownBtn.Size = New System.Drawing.Size(98, 25)
        Me.MoveDownBtn.TabIndex = 497
        Me.MoveDownBtn.Text = "Flytta ned"
        Me.MoveDownBtn.UseVisualStyleBackColor = True
        '
        'HanteraB
        '
        Me.HanteraB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HanteraB.ForeColor = System.Drawing.Color.Maroon
        Me.HanteraB.Location = New System.Drawing.Point(326, 53)
        Me.HanteraB.Name = "HanteraB"
        Me.HanteraB.Size = New System.Drawing.Size(212, 25)
        Me.HanteraB.TabIndex = 498
        Me.HanteraB.Text = "Till STD testregistret"
        Me.HanteraB.UseVisualStyleBackColor = True
        '
        'TestregPerProduktF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1027, 816)
        Me.Controls.Add(Me.HanteraB)
        Me.Controls.Add(Me.MoveDownBtn)
        Me.Controls.Add(Me.MoveUPBtn)
        Me.Controls.Add(Me.ProvkroppL)
        Me.Controls.Add(Me.ProvkroppTB)
        Me.Controls.Add(Me.TabortB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RaderafranSTDtestB)
        Me.Controls.Add(Me.RaderaProduktB)
        Me.Controls.Add(Me.ProduktIDTB)
        Me.Controls.Add(Me.SparaSTDTestB)
        Me.Controls.Add(Me.AnnanInfoTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MinvärdeTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MaxvärdeTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EnhetTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetodTB)
        Me.Controls.Add(Me.SparaB)
        Me.Controls.Add(Me.ProduktIDL)
        Me.Controls.Add(Me.InfogaB)
        Me.Controls.Add(Me.TestnamnCB)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.AddProduktB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.Huvud)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TestregPerProduktF"
        Me.Text = "Test register per produkt"
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Huvud As Button
    Friend WithEvents Ver As GroupBox
    Friend WithEvents Gnamn As Label
    Friend WithEvents KlientIdl As Label
    Friend WithEvents odbcsource As Label
    Friend WithEvents databas As Label
    Friend WithEvents datum As Label
    Friend WithEvents Versionl As Label
    Friend WithEvents AvslutaK As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label26 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents AddProduktB As Button
    Friend WithEvents TestnamnCB As ComboBox
    Friend WithEvents InfogaB As Button
    Friend WithEvents ProduktIDL As Label
    Friend WithEvents SparaB As Button
    Friend WithEvents MetodTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EnhetTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MinvärdeTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MaxvärdeTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AnnanInfoTB As TextBox
    Friend WithEvents SparaSTDTestB As Button
    Friend WithEvents ProduktIDTB As TextBox
    Friend WithEvents RaderaProduktB As Button
    Friend WithEvents RaderafranSTDtestB As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TabortB As Button
    Friend WithEvents ProvkroppL As Label
    Friend WithEvents ProvkroppTB As TextBox
    Friend WithEvents MoveUPBtn As Button
    Friend WithEvents MoveDownBtn As Button
    Friend WithEvents HanteraB As Button
End Class
