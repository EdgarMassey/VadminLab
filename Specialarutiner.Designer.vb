<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecrutinerF
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
        Me.HämtaNotesB = New System.Windows.Forms.Button()
        Me.TomProvRegB = New System.Windows.Forms.Button()
        Me.TomLabProdukterB = New System.Windows.Forms.Button()
        Me.AvslutaK = New System.Windows.Forms.Button()
        Me.Huvud = New System.Windows.Forms.Button()
        Me.Ver = New System.Windows.Forms.GroupBox()
        Me.Gnamn = New System.Windows.Forms.Label()
        Me.KlientIdl = New System.Windows.Forms.Label()
        Me.odbcsource = New System.Windows.Forms.Label()
        Me.databas = New System.Windows.Forms.Label()
        Me.datum = New System.Windows.Forms.Label()
        Me.Versionl = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Ver.SuspendLayout()
        Me.SuspendLayout()
        '
        'HämtaNotesB
        '
        Me.HämtaNotesB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HämtaNotesB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HämtaNotesB.ForeColor = System.Drawing.Color.Maroon
        Me.HämtaNotesB.Location = New System.Drawing.Point(148, 171)
        Me.HämtaNotesB.Name = "HämtaNotesB"
        Me.HämtaNotesB.Size = New System.Drawing.Size(303, 25)
        Me.HämtaNotesB.TabIndex = 372
        Me.HämtaNotesB.Text = "Hämta anteckningar från Vadmin"
        Me.HämtaNotesB.UseVisualStyleBackColor = True
        '
        'TomProvRegB
        '
        Me.TomProvRegB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TomProvRegB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TomProvRegB.ForeColor = System.Drawing.Color.Maroon
        Me.TomProvRegB.Location = New System.Drawing.Point(148, 75)
        Me.TomProvRegB.Name = "TomProvRegB"
        Me.TomProvRegB.Size = New System.Drawing.Size(303, 25)
        Me.TomProvRegB.TabIndex = 373
        Me.TomProvRegB.Text = "Töm Provregistret"
        Me.TomProvRegB.UseVisualStyleBackColor = True
        '
        'TomLabProdukterB
        '
        Me.TomLabProdukterB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TomLabProdukterB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TomLabProdukterB.ForeColor = System.Drawing.Color.Maroon
        Me.TomLabProdukterB.Location = New System.Drawing.Point(148, 123)
        Me.TomLabProdukterB.Name = "TomLabProdukterB"
        Me.TomLabProdukterB.Size = New System.Drawing.Size(303, 25)
        Me.TomLabProdukterB.TabIndex = 374
        Me.TomLabProdukterB.Text = "Töm Labprodukt registret"
        Me.TomLabProdukterB.UseVisualStyleBackColor = True
        '
        'AvslutaK
        '
        Me.AvslutaK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaK.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaK.Location = New System.Drawing.Point(474, 321)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(98, 25)
        Me.AvslutaK.TabIndex = 375
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(92, 2)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(421, 36)
        Me.Huvud.TabIndex = 376
        Me.Huvud.Text = "Speciala rutiner"
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
        Me.Ver.Location = New System.Drawing.Point(10, 282)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(197, 73)
        Me.Ver.TabIndex = 377
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
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(64, 228)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(523, 20)
        Me.Label22.TabIndex = 546
        Me.Label22.Text = "OBS. Använda dessa rutiner med ytterst försiktighet och ansvar!"
        '
        'SpecrutinerF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Huvud)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.TomLabProdukterB)
        Me.Controls.Add(Me.TomProvRegB)
        Me.Controls.Add(Me.HämtaNotesB)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SpecrutinerF"
        Me.Text = "Speciala rutiner"
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HämtaNotesB As Button
    Friend WithEvents TomProvRegB As Button
    Friend WithEvents TomLabProdukterB As Button
    Friend WithEvents AvslutaK As Button
    Friend WithEvents Huvud As Button
    Friend WithEvents Ver As GroupBox
    Friend WithEvents Gnamn As Label
    Friend WithEvents KlientIdl As Label
    Friend WithEvents odbcsource As Label
    Friend WithEvents databas As Label
    Friend WithEvents datum As Label
    Friend WithEvents Versionl As Label
    Friend WithEvents Label22 As Label
End Class
