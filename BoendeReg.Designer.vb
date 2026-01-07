<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabStartF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabStartF))
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
        Me.SummaL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InUtregistreringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtskrifterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InUtRegGB = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatumTB = New System.Windows.Forms.TextBox()
        Me.HandlTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PersonnrTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NamnTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InUtSparB = New System.Windows.Forms.Button()
        Me.InUtAvslutaB = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.FGCB = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DatFROMTb = New System.Windows.Forms.TextBox()
        Me.DatTOMTb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TillEpostTB = New System.Windows.Forms.TextBox()
        Me.EpostCB = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ver.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.InUtRegGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(396, 148)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(681, 443)
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
        Me.Ver.Location = New System.Drawing.Point(16, 607)
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
        Me.AvslutaK.Location = New System.Drawing.Point(771, 644)
        Me.AvslutaK.Margin = New System.Windows.Forms.Padding(4)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(131, 31)
        Me.AvslutaK.TabIndex = 277
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(16, 30)
        Me.Huvud.Margin = New System.Windows.Forms.Padding(4)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(1043, 44)
        Me.Huvud.TabIndex = 276
        Me.Huvud.Text = "Bokning"
        Me.Huvud.UseVisualStyleBackColor = True
        '
        'SummaL
        '
        Me.SummaL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SummaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaL.Location = New System.Drawing.Point(771, 607)
        Me.SummaL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SummaL.Name = "SummaL"
        Me.SummaL.Size = New System.Drawing.Size(120, 25)
        Me.SummaL.TabIndex = 320
        Me.SummaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(832, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 321
        Me.Label2.Text = " "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InUtregistreringToolStripMenuItem, Me.UtskrifterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1090, 28)
        Me.MenuStrip1.TabIndex = 322
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InUtregistreringToolStripMenuItem
        '
        Me.InUtregistreringToolStripMenuItem.Name = "InUtregistreringToolStripMenuItem"
        Me.InUtregistreringToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.InUtregistreringToolStripMenuItem.Text = "In/Utregistrering"
        '
        'UtskrifterToolStripMenuItem
        '
        Me.UtskrifterToolStripMenuItem.Name = "UtskrifterToolStripMenuItem"
        Me.UtskrifterToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.UtskrifterToolStripMenuItem.Text = "Utskrift"
        '
        'InUtRegGB
        '
        Me.InUtRegGB.Controls.Add(Me.Label1)
        Me.InUtRegGB.Controls.Add(Me.DatumTB)
        Me.InUtRegGB.Controls.Add(Me.HandlTB)
        Me.InUtRegGB.Controls.Add(Me.Label5)
        Me.InUtRegGB.Controls.Add(Me.PersonnrTB)
        Me.InUtRegGB.Controls.Add(Me.Label4)
        Me.InUtRegGB.Controls.Add(Me.NamnTB)
        Me.InUtRegGB.Controls.Add(Me.Label3)
        Me.InUtRegGB.Controls.Add(Me.InUtSparB)
        Me.InUtRegGB.Controls.Add(Me.InUtAvslutaB)
        Me.InUtRegGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InUtRegGB.Location = New System.Drawing.Point(17, 330)
        Me.InUtRegGB.Margin = New System.Windows.Forms.Padding(4)
        Me.InUtRegGB.Name = "InUtRegGB"
        Me.InUtRegGB.Padding = New System.Windows.Forms.Padding(4)
        Me.InUtRegGB.Size = New System.Drawing.Size(351, 273)
        Me.InUtRegGB.TabIndex = 323
        Me.InUtRegGB.TabStop = False
        Me.InUtRegGB.Text = "Registrering"
        Me.InUtRegGB.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 333
        Me.Label1.Text = "Datum"
        '
        'DatumTB
        '
        Me.DatumTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatumTB.Location = New System.Drawing.Point(108, 33)
        Me.DatumTB.Margin = New System.Windows.Forms.Padding(4)
        Me.DatumTB.Name = "DatumTB"
        Me.DatumTB.Size = New System.Drawing.Size(83, 23)
        Me.DatumTB.TabIndex = 332
        '
        'HandlTB
        '
        Me.HandlTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HandlTB.Location = New System.Drawing.Point(108, 145)
        Me.HandlTB.Margin = New System.Windows.Forms.Padding(4)
        Me.HandlTB.Name = "HandlTB"
        Me.HandlTB.Size = New System.Drawing.Size(121, 23)
        Me.HandlTB.TabIndex = 290
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-3, 154)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 289
        Me.Label5.Text = "Handläggare"
        '
        'PersonnrTB
        '
        Me.PersonnrTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonnrTB.Location = New System.Drawing.Point(108, 109)
        Me.PersonnrTB.Margin = New System.Windows.Forms.Padding(4)
        Me.PersonnrTB.Name = "PersonnrTB"
        Me.PersonnrTB.Size = New System.Drawing.Size(121, 23)
        Me.PersonnrTB.TabIndex = 288
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 287
        Me.Label4.Text = "Personnr"
        '
        'NamnTB
        '
        Me.NamnTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamnTB.Location = New System.Drawing.Point(108, 71)
        Me.NamnTB.Margin = New System.Windows.Forms.Padding(4)
        Me.NamnTB.Name = "NamnTB"
        Me.NamnTB.Size = New System.Drawing.Size(217, 23)
        Me.NamnTB.TabIndex = 286
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 285
        Me.Label3.Text = "Namn"
        '
        'InUtSparB
        '
        Me.InUtSparB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InUtSparB.ForeColor = System.Drawing.Color.Maroon
        Me.InUtSparB.Location = New System.Drawing.Point(228, 192)
        Me.InUtSparB.Margin = New System.Windows.Forms.Padding(4)
        Me.InUtSparB.Name = "InUtSparB"
        Me.InUtSparB.Size = New System.Drawing.Size(97, 31)
        Me.InUtSparB.TabIndex = 282
        Me.InUtSparB.Text = "Spara"
        Me.InUtSparB.UseVisualStyleBackColor = True
        '
        'InUtAvslutaB
        '
        Me.InUtAvslutaB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InUtAvslutaB.ForeColor = System.Drawing.Color.Maroon
        Me.InUtAvslutaB.Location = New System.Drawing.Point(228, 230)
        Me.InUtAvslutaB.Margin = New System.Windows.Forms.Padding(4)
        Me.InUtAvslutaB.Name = "InUtAvslutaB"
        Me.InUtAvslutaB.Size = New System.Drawing.Size(97, 31)
        Me.InUtAvslutaB.TabIndex = 281
        Me.InUtAvslutaB.Text = "Avsluta"
        Me.InUtAvslutaB.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FGCB
        '
        Me.FGCB.AutoSize = True
        Me.FGCB.Checked = True
        Me.FGCB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FGCB.Location = New System.Drawing.Point(144, 77)
        Me.FGCB.Margin = New System.Windows.Forms.Padding(4)
        Me.FGCB.Name = "FGCB"
        Me.FGCB.Size = New System.Drawing.Size(152, 20)
        Me.FGCB.TabIndex = 324
        Me.FGCB.Text = "Förhandsgranskning"
        Me.FGCB.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(326, 124)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 329
        Me.Label7.Text = "[Enter]"
        '
        'DatFROMTb
        '
        Me.DatFROMTb.Location = New System.Drawing.Point(125, 124)
        Me.DatFROMTb.Margin = New System.Windows.Forms.Padding(4)
        Me.DatFROMTb.Name = "DatFROMTb"
        Me.DatFROMTb.Size = New System.Drawing.Size(83, 22)
        Me.DatFROMTb.TabIndex = 328
        '
        'DatTOMTb
        '
        Me.DatTOMTb.Location = New System.Drawing.Point(235, 124)
        Me.DatTOMTb.Margin = New System.Windows.Forms.Padding(4)
        Me.DatTOMTb.Name = "DatTOMTb"
        Me.DatTOMTb.Size = New System.Drawing.Size(83, 22)
        Me.DatTOMTb.TabIndex = 330
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 128)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 331
        Me.Label8.Text = "Datum"
        '
        'TillEpostTB
        '
        Me.TillEpostTB.Location = New System.Drawing.Point(493, 77)
        Me.TillEpostTB.Margin = New System.Windows.Forms.Padding(4)
        Me.TillEpostTB.Name = "TillEpostTB"
        Me.TillEpostTB.Size = New System.Drawing.Size(378, 22)
        Me.TillEpostTB.TabIndex = 332
        Me.TillEpostTB.Text = "edgar.massey@gmail.com"
        '
        'EpostCB
        '
        Me.EpostCB.AutoSize = True
        Me.EpostCB.Checked = True
        Me.EpostCB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EpostCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EpostCB.Location = New System.Drawing.Point(333, 78)
        Me.EpostCB.Margin = New System.Windows.Forms.Padding(4)
        Me.EpostCB.Name = "EpostCB"
        Me.EpostCB.Size = New System.Drawing.Size(147, 20)
        Me.EpostCB.TabIndex = 334
        Me.EpostCB.Text = "Skickas till epost"
        Me.EpostCB.UseVisualStyleBackColor = True
        '
        'LabStartF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 692)
        Me.Controls.Add(Me.EpostCB)
        Me.Controls.Add(Me.TillEpostTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DatTOMTb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DatFROMTb)
        Me.Controls.Add(Me.FGCB)
        Me.Controls.Add(Me.InUtRegGB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SummaL)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.Huvud)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LabStartF"
        Me.Text = "Labstart"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.InUtRegGB.ResumeLayout(False)
        Me.InUtRegGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Ver As GroupBox
    Friend WithEvents Gnamn As Label
    Friend WithEvents KlientIdl As Label
    Friend WithEvents odbcsource As Label
    Friend WithEvents databas As Label
    Friend WithEvents datum As Label
    Friend WithEvents Versionl As Label
    Friend WithEvents AvslutaK As Button
    Friend WithEvents Huvud As Button
    Friend WithEvents SummaL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InUtregistreringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtskrifterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InUtRegGB As GroupBox
    Friend WithEvents HandlTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PersonnrTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NamnTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents InUtSparB As Button
    Friend WithEvents InUtAvslutaB As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents FGCB As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DatFROMTb As TextBox
    Friend WithEvents DatTOMTb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatumTB As TextBox
    Friend WithEvents TillEpostTB As TextBox
    Friend WithEvents EpostCB As CheckBox
End Class
