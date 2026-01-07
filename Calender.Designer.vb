<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalenderF
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Huvud = New System.Windows.Forms.Button()
        Me.Ver = New System.Windows.Forms.GroupBox()
        Me.Gnamn = New System.Windows.Forms.Label()
        Me.KlientIdl = New System.Windows.Forms.Label()
        Me.odbcsourcel = New System.Windows.Forms.Label()
        Me.databas = New System.Windows.Forms.Label()
        Me.datum = New System.Windows.Forms.Label()
        Me.Versionl = New System.Windows.Forms.Label()
        Me.AvslutaB = New System.Windows.Forms.Button()
        Me.DatumTB = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SpecDatum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NastaB = New System.Windows.Forms.Button()
        Me.TidigareB = New System.Windows.Forms.Button()
        Me.SparaB = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.MonthnameTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RaderaradB = New System.Windows.Forms.Button()
        Me.CalendertypB = New System.Windows.Forms.Button()
        Me.CalenderOwnerB = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ver.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(9, 92)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(658, 263)
        Me.DataGridView1.TabIndex = 1
        '
        'Huvud
        '
        Me.Huvud.BackColor = System.Drawing.Color.Cornsilk
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(113, 2)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(782, 36)
        Me.Huvud.TabIndex = 278
        Me.Huvud.Text = "Calender"
        Me.Huvud.UseVisualStyleBackColor = False
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
        Me.Ver.Location = New System.Drawing.Point(2, 675)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(197, 73)
        Me.Ver.TabIndex = 323
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
        Me.KlientIdl.Location = New System.Drawing.Point(6, 15)
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
        Me.databas.Location = New System.Drawing.Point(6, 29)
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
        Me.AvslutaB.BackColor = System.Drawing.Color.Cornsilk
        Me.AvslutaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AvslutaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaB.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaB.Location = New System.Drawing.Point(1247, 732)
        Me.AvslutaB.Name = "AvslutaB"
        Me.AvslutaB.Size = New System.Drawing.Size(92, 25)
        Me.AvslutaB.TabIndex = 373
        Me.AvslutaB.Text = "Avsluta"
        Me.AvslutaB.UseVisualStyleBackColor = False
        '
        'DatumTB
        '
        Me.DatumTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatumTB.Location = New System.Drawing.Point(273, 43)
        Me.DatumTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DatumTB.Name = "DatumTB"
        Me.DatumTB.Size = New System.Drawing.Size(117, 21)
        Me.DatumTB.TabIndex = 397
        Me.DatumTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(9, 400)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(658, 273)
        Me.DataGridView2.TabIndex = 398
        '
        'SpecDatum
        '
        Me.SpecDatum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecDatum.Location = New System.Drawing.Point(12, 377)
        Me.SpecDatum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SpecDatum.Name = "SpecDatum"
        Me.SpecDatum.Size = New System.Drawing.Size(117, 21)
        Me.SpecDatum.TabIndex = 400
        Me.SpecDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 358)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "Dagen"
        '
        'NastaB
        '
        Me.NastaB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NastaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NastaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NastaB.ForeColor = System.Drawing.Color.Maroon
        Me.NastaB.Location = New System.Drawing.Point(406, 43)
        Me.NastaB.Name = "NastaB"
        Me.NastaB.Size = New System.Drawing.Size(92, 25)
        Me.NastaB.TabIndex = 401
        Me.NastaB.Text = "Nästa"
        Me.NastaB.UseVisualStyleBackColor = False
        '
        'TidigareB
        '
        Me.TidigareB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TidigareB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TidigareB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TidigareB.ForeColor = System.Drawing.Color.Maroon
        Me.TidigareB.Location = New System.Drawing.Point(161, 43)
        Me.TidigareB.Name = "TidigareB"
        Me.TidigareB.Size = New System.Drawing.Size(92, 25)
        Me.TidigareB.TabIndex = 402
        Me.TidigareB.Text = "Tidigare"
        Me.TidigareB.UseVisualStyleBackColor = False
        '
        'SparaB
        '
        Me.SparaB.BackColor = System.Drawing.Color.Cornsilk
        Me.SparaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SparaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaB.Location = New System.Drawing.Point(512, 717)
        Me.SparaB.Name = "SparaB"
        Me.SparaB.Size = New System.Drawing.Size(166, 25)
        Me.SparaB.TabIndex = 403
        Me.SparaB.Text = "Spara event "
        Me.SparaB.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(705, 85)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(647, 471)
        Me.DataGridView3.TabIndex = 404
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(705, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(634, 25)
        Me.Button1.TabIndex = 405
        Me.Button1.Text = "Nästkommande händelser"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(727, 622)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(170, 124)
        Me.CheckedListBox1.TabIndex = 407
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(727, 591)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 25)
        Me.Button2.TabIndex = 408
        Me.Button2.Text = "Calenders"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Maroon
        Me.Button3.Location = New System.Drawing.Point(943, 591)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 25)
        Me.Button3.TabIndex = 410
        Me.Button3.Text = "Owners"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(943, 622)
        Me.CheckedListBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(170, 124)
        Me.CheckedListBox2.TabIndex = 409
        '
        'MonthnameTB
        '
        Me.MonthnameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthnameTB.Location = New System.Drawing.Point(273, 65)
        Me.MonthnameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MonthnameTB.Name = "MonthnameTB"
        Me.MonthnameTB.Size = New System.Drawing.Size(117, 21)
        Me.MonthnameTB.TabIndex = 411
        Me.MonthnameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(244, 689)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 15)
        Me.Label3.TabIndex = 412
        Me.Label3.Text = "Börja en ny eventrad med text ... avsluta med spara"
        '
        'RaderaradB
        '
        Me.RaderaradB.BackColor = System.Drawing.Color.Cornsilk
        Me.RaderaradB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RaderaradB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaderaradB.ForeColor = System.Drawing.Color.Maroon
        Me.RaderaradB.Location = New System.Drawing.Point(200, 717)
        Me.RaderaradB.Name = "RaderaradB"
        Me.RaderaradB.Size = New System.Drawing.Size(166, 25)
        Me.RaderaradB.TabIndex = 413
        Me.RaderaradB.Text = "Radera eventrad"
        Me.RaderaradB.UseVisualStyleBackColor = False
        '
        'CalendertypB
        '
        Me.CalendertypB.BackColor = System.Drawing.Color.Cornsilk
        Me.CalendertypB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CalendertypB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalendertypB.ForeColor = System.Drawing.Color.Maroon
        Me.CalendertypB.Location = New System.Drawing.Point(943, 2)
        Me.CalendertypB.Name = "CalendertypB"
        Me.CalendertypB.Size = New System.Drawing.Size(151, 25)
        Me.CalendertypB.TabIndex = 414
        Me.CalendertypB.Text = "Till Calenderyp register"
        Me.CalendertypB.UseVisualStyleBackColor = False
        '
        'CalenderOwnerB
        '
        Me.CalenderOwnerB.BackColor = System.Drawing.Color.Cornsilk
        Me.CalenderOwnerB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CalenderOwnerB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalenderOwnerB.ForeColor = System.Drawing.Color.Maroon
        Me.CalenderOwnerB.Location = New System.Drawing.Point(1100, 2)
        Me.CalenderOwnerB.Name = "CalenderOwnerB"
        Me.CalenderOwnerB.Size = New System.Drawing.Size(171, 25)
        Me.CalenderOwnerB.TabIndex = 415
        Me.CalenderOwnerB.Text = "Till CalenderOwner register"
        Me.CalenderOwnerB.UseVisualStyleBackColor = False
        '
        'CalenderF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1361, 759)
        Me.Controls.Add(Me.CalenderOwnerB)
        Me.Controls.Add(Me.CalendertypB)
        Me.Controls.Add(Me.RaderaradB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MonthnameTB)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.SparaB)
        Me.Controls.Add(Me.TidigareB)
        Me.Controls.Add(Me.NastaB)
        Me.Controls.Add(Me.SpecDatum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DatumTB)
        Me.Controls.Add(Me.AvslutaB)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Huvud)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CalenderF"
        Me.Text = "CalenderF"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Huvud As Button
    Friend WithEvents Ver As GroupBox
    Friend WithEvents Gnamn As Label
    Friend WithEvents KlientIdl As Label
    Friend WithEvents odbcsourcel As Label
    Friend WithEvents databas As Label
    Friend WithEvents datum As Label
    Friend WithEvents Versionl As Label
    Friend WithEvents AvslutaB As Button
    Friend WithEvents DatumTB As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents SpecDatum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NastaB As Button
    Friend WithEvents TidigareB As Button
    Friend WithEvents SparaB As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents MonthnameTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RaderaradB As Button
    Friend WithEvents CalendertypB As Button
    Friend WithEvents CalenderOwnerB As Button
End Class
