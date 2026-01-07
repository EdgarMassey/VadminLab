<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdregF
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
        Me.AvslutaK = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProduktIDTB = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ProduktnamnTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RaderaB = New System.Windows.Forms.Button()
        Me.SparaB = New System.Windows.Forms.Button()
        Me.KommentsTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Test1CB = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Test2CB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Test3CB = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Test4CB = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Test5CB = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Test6CB = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Test7CB = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Test8CB = New System.Windows.Forms.ComboBox()
        Me.Test1MinMaxTB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Test2MinMaxTB = New System.Windows.Forms.TextBox()
        Me.Test3MinMaxTB = New System.Windows.Forms.TextBox()
        Me.Test4MinMaxTB = New System.Windows.Forms.TextBox()
        Me.Test5MinMaxTB = New System.Windows.Forms.TextBox()
        Me.Test6MinMaxTB = New System.Windows.Forms.TextBox()
        Me.Test7MinMaxTB = New System.Windows.Forms.TextBox()
        Me.Test8MinMaxTB = New System.Windows.Forms.TextBox()
        Me.Ver.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(45, 13)
        Me.Huvud.Margin = New System.Windows.Forms.Padding(4)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(890, 44)
        Me.Huvud.TabIndex = 278
        Me.Huvud.Text = "Lab Produktregister"
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
        Me.Ver.Location = New System.Drawing.Point(13, 563)
        Me.Ver.Margin = New System.Windows.Forms.Padding(4)
        Me.Ver.Name = "Ver"
        Me.Ver.Padding = New System.Windows.Forms.Padding(4)
        Me.Ver.Size = New System.Drawing.Size(263, 90)
        Me.Ver.TabIndex = 323
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
        Me.databas.Location = New System.Drawing.Point(16, 32)
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
        Me.AvslutaK.Location = New System.Drawing.Point(1211, 618)
        Me.AvslutaK.Margin = New System.Windows.Forms.Padding(4)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(131, 31)
        Me.AvslutaK.TabIndex = 324
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1103, 97)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(262, 408)
        Me.DataGridView1.TabIndex = 325
        '
        'ProduktIDTB
        '
        Me.ProduktIDTB.Location = New System.Drawing.Point(132, 102)
        Me.ProduktIDTB.Margin = New System.Windows.Forms.Padding(4)
        Me.ProduktIDTB.Name = "ProduktIDTB"
        Me.ProduktIDTB.Size = New System.Drawing.Size(188, 22)
        Me.ProduktIDTB.TabIndex = 363
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(41, 102)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(83, 20)
        Me.Label26.TabIndex = 362
        Me.Label26.Text = "ProduktID"
        '
        'ProduktnamnTB
        '
        Me.ProduktnamnTB.Location = New System.Drawing.Point(132, 156)
        Me.ProduktnamnTB.Margin = New System.Windows.Forms.Padding(4)
        Me.ProduktnamnTB.Name = "ProduktnamnTB"
        Me.ProduktnamnTB.Size = New System.Drawing.Size(331, 22)
        Me.ProduktnamnTB.TabIndex = 365
        Me.ProduktnamnTB.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 156)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 364
        Me.Label1.Text = "Produkt Namn"
        Me.Label1.Visible = False
        '
        'StatusTB
        '
        Me.StatusTB.Location = New System.Drawing.Point(132, 220)
        Me.StatusTB.Margin = New System.Windows.Forms.Padding(4)
        Me.StatusTB.Name = "StatusTB"
        Me.StatusTB.Size = New System.Drawing.Size(188, 22)
        Me.StatusTB.TabIndex = 367
        Me.StatusTB.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 220)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 366
        Me.Label2.Text = "Status"
        Me.Label2.Visible = False
        '
        'RaderaB
        '
        Me.RaderaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaderaB.ForeColor = System.Drawing.Color.Maroon
        Me.RaderaB.Location = New System.Drawing.Point(332, 97)
        Me.RaderaB.Margin = New System.Windows.Forms.Padding(4)
        Me.RaderaB.Name = "RaderaB"
        Me.RaderaB.Size = New System.Drawing.Size(131, 31)
        Me.RaderaB.TabIndex = 374
        Me.RaderaB.Text = "Radera"
        Me.RaderaB.UseVisualStyleBackColor = True
        '
        'SparaB
        '
        Me.SparaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaB.Location = New System.Drawing.Point(657, 563)
        Me.SparaB.Margin = New System.Windows.Forms.Padding(4)
        Me.SparaB.Name = "SparaB"
        Me.SparaB.Size = New System.Drawing.Size(131, 31)
        Me.SparaB.TabIndex = 375
        Me.SparaB.Text = "Spara"
        Me.SparaB.UseVisualStyleBackColor = True
        '
        'KommentsTB
        '
        Me.KommentsTB.Location = New System.Drawing.Point(28, 283)
        Me.KommentsTB.Margin = New System.Windows.Forms.Padding(4)
        Me.KommentsTB.Multiline = True
        Me.KommentsTB.Name = "KommentsTB"
        Me.KommentsTB.Size = New System.Drawing.Size(435, 75)
        Me.KommentsTB.TabIndex = 376
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 259)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 377
        Me.Label3.Text = "Komments"
        '
        'Test1CB
        '
        Me.Test1CB.BackColor = System.Drawing.Color.Gainsboro
        Me.Test1CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test1CB.ForeColor = System.Drawing.Color.Maroon
        Me.Test1CB.FormattingEnabled = True
        Me.Test1CB.Location = New System.Drawing.Point(598, 102)
        Me.Test1CB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Test1CB.Name = "Test1CB"
        Me.Test1CB.Size = New System.Drawing.Size(208, 28)
        Me.Test1CB.TabIndex = 442
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(534, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 443
        Me.Label4.Text = "Test 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(534, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 445
        Me.Label5.Text = "Test 2"
        '
        'Test2CB
        '
        Me.Test2CB.BackColor = System.Drawing.Color.Gainsboro
        Me.Test2CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test2CB.ForeColor = System.Drawing.Color.Maroon
        Me.Test2CB.FormattingEnabled = True
        Me.Test2CB.Location = New System.Drawing.Point(598, 153)
        Me.Test2CB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Test2CB.Name = "Test2CB"
        Me.Test2CB.Size = New System.Drawing.Size(208, 28)
        Me.Test2CB.TabIndex = 444
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(534, 205)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 447
        Me.Label6.Text = "Test 3"
        '
        'Test3CB
        '
        Me.Test3CB.BackColor = System.Drawing.Color.Gainsboro
        Me.Test3CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test3CB.ForeColor = System.Drawing.Color.Maroon
        Me.Test3CB.FormattingEnabled = True
        Me.Test3CB.Location = New System.Drawing.Point(598, 202)
        Me.Test3CB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Test3CB.Name = "Test3CB"
        Me.Test3CB.Size = New System.Drawing.Size(208, 28)
        Me.Test3CB.TabIndex = 446
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(534, 254)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 449
        Me.Label7.Text = "Test 4"
        '
        'Test4CB
        '
        Me.Test4CB.BackColor = System.Drawing.Color.Gainsboro
        Me.Test4CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test4CB.ForeColor = System.Drawing.Color.Maroon
        Me.Test4CB.FormattingEnabled = True
        Me.Test4CB.Location = New System.Drawing.Point(598, 251)
        Me.Test4CB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Test4CB.Name = "Test4CB"
        Me.Test4CB.Size = New System.Drawing.Size(208, 28)
        Me.Test4CB.TabIndex = 448
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(534, 304)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 451
        Me.Label8.Text = "Test 5"
        '
        'Test5CB
        '
        Me.Test5CB.BackColor = System.Drawing.Color.Gainsboro
        Me.Test5CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test5CB.ForeColor = System.Drawing.Color.Maroon
        Me.Test5CB.FormattingEnabled = True
        Me.Test5CB.Location = New System.Drawing.Point(598, 301)
        Me.Test5CB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Test5CB.Name = "Test5CB"
        Me.Test5CB.Size = New System.Drawing.Size(208, 28)
        Me.Test5CB.TabIndex = 450
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(534, 354)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 453
        Me.Label9.Text = "Test 6"
        '
        'Test6CB
        '
        Me.Test6CB.BackColor = System.Drawing.Color.Gainsboro
        Me.Test6CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test6CB.ForeColor = System.Drawing.Color.Maroon
        Me.Test6CB.FormattingEnabled = True
        Me.Test6CB.Location = New System.Drawing.Point(598, 351)
        Me.Test6CB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Test6CB.Name = "Test6CB"
        Me.Test6CB.Size = New System.Drawing.Size(208, 28)
        Me.Test6CB.TabIndex = 452
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(534, 399)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 455
        Me.Label10.Text = "Test 7"
        '
        'Test7CB
        '
        Me.Test7CB.BackColor = System.Drawing.Color.Gainsboro
        Me.Test7CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test7CB.ForeColor = System.Drawing.Color.Maroon
        Me.Test7CB.FormattingEnabled = True
        Me.Test7CB.Location = New System.Drawing.Point(598, 396)
        Me.Test7CB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Test7CB.Name = "Test7CB"
        Me.Test7CB.Size = New System.Drawing.Size(208, 28)
        Me.Test7CB.TabIndex = 454
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(534, 445)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 457
        Me.Label11.Text = "Test 8"
        '
        'Test8CB
        '
        Me.Test8CB.BackColor = System.Drawing.Color.Gainsboro
        Me.Test8CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test8CB.ForeColor = System.Drawing.Color.Maroon
        Me.Test8CB.FormattingEnabled = True
        Me.Test8CB.Location = New System.Drawing.Point(598, 442)
        Me.Test8CB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Test8CB.Name = "Test8CB"
        Me.Test8CB.Size = New System.Drawing.Size(208, 28)
        Me.Test8CB.TabIndex = 456
        '
        'Test1MinMaxTB
        '
        Me.Test1MinMaxTB.Location = New System.Drawing.Point(836, 108)
        Me.Test1MinMaxTB.Margin = New System.Windows.Forms.Padding(4)
        Me.Test1MinMaxTB.Name = "Test1MinMaxTB"
        Me.Test1MinMaxTB.Size = New System.Drawing.Size(188, 22)
        Me.Test1MinMaxTB.TabIndex = 458
        Me.Test1MinMaxTB.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(856, 82)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 20)
        Me.Label12.TabIndex = 459
        Me.Label12.Text = "Max/min värde"
        '
        'Test2MinMaxTB
        '
        Me.Test2MinMaxTB.Location = New System.Drawing.Point(836, 153)
        Me.Test2MinMaxTB.Margin = New System.Windows.Forms.Padding(4)
        Me.Test2MinMaxTB.Name = "Test2MinMaxTB"
        Me.Test2MinMaxTB.Size = New System.Drawing.Size(188, 22)
        Me.Test2MinMaxTB.TabIndex = 460
        Me.Test2MinMaxTB.Visible = False
        '
        'Test3MinMaxTB
        '
        Me.Test3MinMaxTB.Location = New System.Drawing.Point(836, 205)
        Me.Test3MinMaxTB.Margin = New System.Windows.Forms.Padding(4)
        Me.Test3MinMaxTB.Name = "Test3MinMaxTB"
        Me.Test3MinMaxTB.Size = New System.Drawing.Size(188, 22)
        Me.Test3MinMaxTB.TabIndex = 461
        Me.Test3MinMaxTB.Visible = False
        '
        'Test4MinMaxTB
        '
        Me.Test4MinMaxTB.Location = New System.Drawing.Point(836, 251)
        Me.Test4MinMaxTB.Margin = New System.Windows.Forms.Padding(4)
        Me.Test4MinMaxTB.Name = "Test4MinMaxTB"
        Me.Test4MinMaxTB.Size = New System.Drawing.Size(188, 22)
        Me.Test4MinMaxTB.TabIndex = 462
        Me.Test4MinMaxTB.Visible = False
        '
        'Test5MinMaxTB
        '
        Me.Test5MinMaxTB.Location = New System.Drawing.Point(836, 301)
        Me.Test5MinMaxTB.Margin = New System.Windows.Forms.Padding(4)
        Me.Test5MinMaxTB.Name = "Test5MinMaxTB"
        Me.Test5MinMaxTB.Size = New System.Drawing.Size(188, 22)
        Me.Test5MinMaxTB.TabIndex = 463
        Me.Test5MinMaxTB.Visible = False
        '
        'Test6MinMaxTB
        '
        Me.Test6MinMaxTB.Location = New System.Drawing.Point(836, 351)
        Me.Test6MinMaxTB.Margin = New System.Windows.Forms.Padding(4)
        Me.Test6MinMaxTB.Name = "Test6MinMaxTB"
        Me.Test6MinMaxTB.Size = New System.Drawing.Size(188, 22)
        Me.Test6MinMaxTB.TabIndex = 464
        Me.Test6MinMaxTB.Visible = False
        '
        'Test7MinMaxTB
        '
        Me.Test7MinMaxTB.Location = New System.Drawing.Point(836, 397)
        Me.Test7MinMaxTB.Margin = New System.Windows.Forms.Padding(4)
        Me.Test7MinMaxTB.Name = "Test7MinMaxTB"
        Me.Test7MinMaxTB.Size = New System.Drawing.Size(188, 22)
        Me.Test7MinMaxTB.TabIndex = 465
        Me.Test7MinMaxTB.Visible = False
        '
        'Test8MinMaxTB
        '
        Me.Test8MinMaxTB.Location = New System.Drawing.Point(836, 442)
        Me.Test8MinMaxTB.Margin = New System.Windows.Forms.Padding(4)
        Me.Test8MinMaxTB.Name = "Test8MinMaxTB"
        Me.Test8MinMaxTB.Size = New System.Drawing.Size(188, 22)
        Me.Test8MinMaxTB.TabIndex = 466
        Me.Test8MinMaxTB.Visible = False
        '
        'ProdregF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1398, 666)
        Me.Controls.Add(Me.Test8MinMaxTB)
        Me.Controls.Add(Me.Test7MinMaxTB)
        Me.Controls.Add(Me.Test6MinMaxTB)
        Me.Controls.Add(Me.Test5MinMaxTB)
        Me.Controls.Add(Me.Test4MinMaxTB)
        Me.Controls.Add(Me.Test3MinMaxTB)
        Me.Controls.Add(Me.Test2MinMaxTB)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Test1MinMaxTB)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Test8CB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Test7CB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Test6CB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Test5CB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Test4CB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Test3CB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Test2CB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Test1CB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.KommentsTB)
        Me.Controls.Add(Me.SparaB)
        Me.Controls.Add(Me.RaderaB)
        Me.Controls.Add(Me.StatusTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProduktnamnTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProduktIDTB)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Huvud)
        Me.Name = "ProdregF"
        Me.Text = "Produkt register"
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ProduktIDTB As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents ProduktnamnTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RaderaB As Button
    Friend WithEvents SparaB As Button
    Friend WithEvents KommentsTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Test1CB As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Test2CB As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Test3CB As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Test4CB As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Test5CB As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Test6CB As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Test7CB As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Test8CB As ComboBox
    Friend WithEvents Test1MinMaxTB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Test2MinMaxTB As TextBox
    Friend WithEvents Test3MinMaxTB As TextBox
    Friend WithEvents Test4MinMaxTB As TextBox
    Friend WithEvents Test5MinMaxTB As TextBox
    Friend WithEvents Test6MinMaxTB As TextBox
    Friend WithEvents Test7MinMaxTB As TextBox
    Friend WithEvents Test8MinMaxTB As TextBox
End Class
