<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LagerRegF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LagerRegF))
        Me.Spara = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Ver = New System.Windows.Forms.GroupBox()
        Me.Gnamn = New System.Windows.Forms.Label()
        Me.KlientIdl = New System.Windows.Forms.Label()
        Me.odbcsourcel = New System.Windows.Forms.Label()
        Me.databas = New System.Windows.Forms.Label()
        Me.datum = New System.Windows.Forms.Label()
        Me.Versionl = New System.Windows.Forms.Label()
        Me.AvslutaK = New System.Windows.Forms.Button()
        Me.Huvud = New System.Windows.Forms.Button()
        Me.Sokbegrepp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LagerPlatsRB = New System.Windows.Forms.RadioButton()
        Me.ProdnrRB = New System.Windows.Forms.RadioButton()
        Me.SummaL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InUtregistreringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtskrifterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InUtRegGB = New System.Windows.Forms.GroupBox()
        Me.FranlagerRB = New System.Windows.Forms.RadioButton()
        Me.TilllagerRB = New System.Windows.Forms.RadioButton()
        Me.AntalTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProdnrTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LagerplatsTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InUtSparB = New System.Windows.Forms.Button()
        Me.InUtAvslutaB = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.FGCB = New System.Windows.Forms.CheckBox()
        Me.TillLagB = New System.Windows.Forms.Button()
        Me.FranLagB = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ver.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.InUtRegGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Spara
        '
        Me.Spara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spara.ForeColor = System.Drawing.Color.Maroon
        Me.Spara.Location = New System.Drawing.Point(581, 493)
        Me.Spara.Name = "Spara"
        Me.Spara.Size = New System.Drawing.Size(95, 25)
        Me.Spara.TabIndex = 280
        Me.Spara.Text = "Spara"
        Me.Spara.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(292, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(477, 360)
        Me.DataGridView1.TabIndex = 279
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
        Me.Ver.Location = New System.Drawing.Point(12, 493)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(197, 73)
        Me.Ver.TabIndex = 278
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
        Me.AvslutaK.Location = New System.Drawing.Point(578, 523)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(98, 25)
        Me.AvslutaK.TabIndex = 277
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(12, 24)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(782, 36)
        Me.Huvud.TabIndex = 276
        Me.Huvud.Text = "Lagerregister"
        Me.Huvud.UseVisualStyleBackColor = True
        '
        'Sokbegrepp
        '
        Me.Sokbegrepp.Location = New System.Drawing.Point(47, 134)
        Me.Sokbegrepp.Name = "Sokbegrepp"
        Me.Sokbegrepp.Size = New System.Drawing.Size(138, 20)
        Me.Sokbegrepp.TabIndex = 285
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 284
        Me.Label1.Text = "Sökbegrepp"
        '
        'LagerPlatsRB
        '
        Me.LagerPlatsRB.AutoSize = True
        Me.LagerPlatsRB.Location = New System.Drawing.Point(61, 203)
        Me.LagerPlatsRB.Name = "LagerPlatsRB"
        Me.LagerPlatsRB.Size = New System.Drawing.Size(75, 17)
        Me.LagerPlatsRB.TabIndex = 282
        Me.LagerPlatsRB.Text = "LagerPlats"
        Me.LagerPlatsRB.UseVisualStyleBackColor = True
        '
        'ProdnrRB
        '
        Me.ProdnrRB.AutoSize = True
        Me.ProdnrRB.Checked = True
        Me.ProdnrRB.Location = New System.Drawing.Point(61, 180)
        Me.ProdnrRB.Name = "ProdnrRB"
        Me.ProdnrRB.Size = New System.Drawing.Size(99, 17)
        Me.ProdnrRB.TabIndex = 281
        Me.ProdnrRB.TabStop = True
        Me.ProdnrRB.Text = "Produktnummer"
        Me.ProdnrRB.UseVisualStyleBackColor = True
        '
        'SummaL
        '
        Me.SummaL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SummaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaL.Location = New System.Drawing.Point(567, 452)
        Me.SummaL.Name = "SummaL"
        Me.SummaL.Size = New System.Drawing.Size(90, 20)
        Me.SummaL.TabIndex = 320
        Me.SummaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(624, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 321
        Me.Label2.Text = " "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InUtregistreringToolStripMenuItem, Me.UtskrifterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(806, 24)
        Me.MenuStrip1.TabIndex = 322
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InUtregistreringToolStripMenuItem
        '
        Me.InUtregistreringToolStripMenuItem.Name = "InUtregistreringToolStripMenuItem"
        Me.InUtregistreringToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.InUtregistreringToolStripMenuItem.Text = "In/Utregistrering"
        '
        'UtskrifterToolStripMenuItem
        '
        Me.UtskrifterToolStripMenuItem.Name = "UtskrifterToolStripMenuItem"
        Me.UtskrifterToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UtskrifterToolStripMenuItem.Text = "Utskrift"
        '
        'InUtRegGB
        '
        Me.InUtRegGB.Controls.Add(Me.FranlagerRB)
        Me.InUtRegGB.Controls.Add(Me.TilllagerRB)
        Me.InUtRegGB.Controls.Add(Me.AntalTB)
        Me.InUtRegGB.Controls.Add(Me.Label5)
        Me.InUtRegGB.Controls.Add(Me.ProdnrTB)
        Me.InUtRegGB.Controls.Add(Me.Label4)
        Me.InUtRegGB.Controls.Add(Me.LagerplatsTB)
        Me.InUtRegGB.Controls.Add(Me.Label3)
        Me.InUtRegGB.Controls.Add(Me.InUtSparB)
        Me.InUtRegGB.Controls.Add(Me.InUtAvslutaB)
        Me.InUtRegGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InUtRegGB.Location = New System.Drawing.Point(13, 268)
        Me.InUtRegGB.Name = "InUtRegGB"
        Me.InUtRegGB.Size = New System.Drawing.Size(263, 222)
        Me.InUtRegGB.TabIndex = 323
        Me.InUtRegGB.TabStop = False
        Me.InUtRegGB.Text = "In/Utregistrering"
        Me.InUtRegGB.Visible = False
        '
        'FranlagerRB
        '
        Me.FranlagerRB.AutoSize = True
        Me.FranlagerRB.Checked = True
        Me.FranlagerRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FranlagerRB.Location = New System.Drawing.Point(115, 25)
        Me.FranlagerRB.Name = "FranlagerRB"
        Me.FranlagerRB.Size = New System.Drawing.Size(96, 20)
        Me.FranlagerRB.TabIndex = 292
        Me.FranlagerRB.TabStop = True
        Me.FranlagerRB.Text = "Från lager"
        Me.FranlagerRB.UseVisualStyleBackColor = True
        '
        'TilllagerRB
        '
        Me.TilllagerRB.AutoSize = True
        Me.TilllagerRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TilllagerRB.Location = New System.Drawing.Point(21, 25)
        Me.TilllagerRB.Name = "TilllagerRB"
        Me.TilllagerRB.Size = New System.Drawing.Size(87, 20)
        Me.TilllagerRB.TabIndex = 291
        Me.TilllagerRB.Text = "Till lager"
        Me.TilllagerRB.UseVisualStyleBackColor = True
        '
        'AntalTB
        '
        Me.AntalTB.Location = New System.Drawing.Point(118, 118)
        Me.AntalTB.Name = "AntalTB"
        Me.AntalTB.Size = New System.Drawing.Size(79, 26)
        Me.AntalTB.TabIndex = 290
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 289
        Me.Label5.Text = "Antal"
        '
        'ProdnrTB
        '
        Me.ProdnrTB.Location = New System.Drawing.Point(118, 89)
        Me.ProdnrTB.Name = "ProdnrTB"
        Me.ProdnrTB.Size = New System.Drawing.Size(79, 26)
        Me.ProdnrTB.TabIndex = 288
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 287
        Me.Label4.Text = "Produktnummer"
        '
        'LagerplatsTB
        '
        Me.LagerplatsTB.Location = New System.Drawing.Point(118, 61)
        Me.LagerplatsTB.Name = "LagerplatsTB"
        Me.LagerplatsTB.Size = New System.Drawing.Size(79, 26)
        Me.LagerplatsTB.TabIndex = 286
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 285
        Me.Label3.Text = "Lagerplats"
        '
        'InUtSparB
        '
        Me.InUtSparB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InUtSparB.ForeColor = System.Drawing.Color.Maroon
        Me.InUtSparB.Location = New System.Drawing.Point(171, 156)
        Me.InUtSparB.Name = "InUtSparB"
        Me.InUtSparB.Size = New System.Drawing.Size(73, 25)
        Me.InUtSparB.TabIndex = 282
        Me.InUtSparB.Text = "Spara"
        Me.InUtSparB.UseVisualStyleBackColor = True
        '
        'InUtAvslutaB
        '
        Me.InUtAvslutaB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InUtAvslutaB.ForeColor = System.Drawing.Color.Maroon
        Me.InUtAvslutaB.Location = New System.Drawing.Point(171, 187)
        Me.InUtAvslutaB.Name = "InUtAvslutaB"
        Me.InUtAvslutaB.Size = New System.Drawing.Size(73, 25)
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
        Me.FGCB.Location = New System.Drawing.Point(116, 63)
        Me.FGCB.Name = "FGCB"
        Me.FGCB.Size = New System.Drawing.Size(122, 17)
        Me.FGCB.TabIndex = 324
        Me.FGCB.Text = "Förhandsgranskning"
        Me.FGCB.UseVisualStyleBackColor = True
        '
        'TillLagB
        '
        Me.TillLagB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TillLagB.ForeColor = System.Drawing.Color.Maroon
        Me.TillLagB.Location = New System.Drawing.Point(13, 237)
        Me.TillLagB.Name = "TillLagB"
        Me.TillLagB.Size = New System.Drawing.Size(83, 25)
        Me.TillLagB.TabIndex = 325
        Me.TillLagB.Text = "Till lagret"
        Me.TillLagB.UseVisualStyleBackColor = True
        '
        'FranLagB
        '
        Me.FranLagB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FranLagB.ForeColor = System.Drawing.Color.Maroon
        Me.FranLagB.Location = New System.Drawing.Point(165, 237)
        Me.FranLagB.Name = "FranLagB"
        Me.FranLagB.Size = New System.Drawing.Size(92, 25)
        Me.FranLagB.TabIndex = 326
        Me.FranLagB.Text = "Från lagret"
        Me.FranLagB.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(191, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 12)
        Me.Label6.TabIndex = 327
        Me.Label6.Text = "[Enter]"
        '
        'LagerRegF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 562)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FranLagB)
        Me.Controls.Add(Me.TillLagB)
        Me.Controls.Add(Me.FGCB)
        Me.Controls.Add(Me.InUtRegGB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SummaL)
        Me.Controls.Add(Me.Sokbegrepp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LagerPlatsRB)
        Me.Controls.Add(Me.ProdnrRB)
        Me.Controls.Add(Me.Spara)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.Huvud)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LagerRegF"
        Me.Text = "Lagerregister"
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

    Friend WithEvents Spara As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Ver As GroupBox
    Friend WithEvents Gnamn As Label
    Friend WithEvents KlientIdl As Label
    Friend WithEvents odbcsourcel As Label
    Friend WithEvents databas As Label
    Friend WithEvents datum As Label
    Friend WithEvents Versionl As Label
    Friend WithEvents AvslutaK As Button
    Friend WithEvents Huvud As Button
    Friend WithEvents Sokbegrepp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LagerPlatsRB As RadioButton
    Friend WithEvents ProdnrRB As RadioButton
    Friend WithEvents SummaL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InUtregistreringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtskrifterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InUtRegGB As GroupBox
    Friend WithEvents AntalTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ProdnrTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LagerplatsTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents InUtSparB As Button
    Friend WithEvents InUtAvslutaB As Button
    Friend WithEvents FranlagerRB As RadioButton
    Friend WithEvents TilllagerRB As RadioButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents FGCB As CheckBox
    Friend WithEvents TillLagB As Button
    Friend WithEvents FranLagB As Button
    Friend WithEvents Label6 As Label
End Class
