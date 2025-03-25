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
        Me.TomTestArkivB = New System.Windows.Forms.Button()
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
        'TomTestArkivB
        '
        Me.TomTestArkivB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TomTestArkivB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TomTestArkivB.ForeColor = System.Drawing.Color.Maroon
        Me.TomTestArkivB.Location = New System.Drawing.Point(198, 210)
        Me.TomTestArkivB.Margin = New System.Windows.Forms.Padding(4)
        Me.TomTestArkivB.Name = "TomTestArkivB"
        Me.TomTestArkivB.Size = New System.Drawing.Size(404, 31)
        Me.TomTestArkivB.TabIndex = 372
        Me.TomTestArkivB.Text = "Töm Testarkivet"
        Me.TomTestArkivB.UseVisualStyleBackColor = True
        '
        'TomProvRegB
        '
        Me.TomProvRegB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TomProvRegB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TomProvRegB.ForeColor = System.Drawing.Color.Maroon
        Me.TomProvRegB.Location = New System.Drawing.Point(198, 92)
        Me.TomProvRegB.Margin = New System.Windows.Forms.Padding(4)
        Me.TomProvRegB.Name = "TomProvRegB"
        Me.TomProvRegB.Size = New System.Drawing.Size(404, 31)
        Me.TomProvRegB.TabIndex = 373
        Me.TomProvRegB.Text = "Töm Provregistret"
        Me.TomProvRegB.UseVisualStyleBackColor = True
        '
        'TomLabProdukterB
        '
        Me.TomLabProdukterB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TomLabProdukterB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TomLabProdukterB.ForeColor = System.Drawing.Color.Maroon
        Me.TomLabProdukterB.Location = New System.Drawing.Point(198, 151)
        Me.TomLabProdukterB.Margin = New System.Windows.Forms.Padding(4)
        Me.TomLabProdukterB.Name = "TomLabProdukterB"
        Me.TomLabProdukterB.Size = New System.Drawing.Size(404, 31)
        Me.TomLabProdukterB.TabIndex = 374
        Me.TomLabProdukterB.Text = "Töm Labprodukt registret"
        Me.TomLabProdukterB.UseVisualStyleBackColor = True
        '
        'AvslutaK
        '
        Me.AvslutaK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaK.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaK.Location = New System.Drawing.Point(632, 395)
        Me.AvslutaK.Margin = New System.Windows.Forms.Padding(4)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(131, 31)
        Me.AvslutaK.TabIndex = 375
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(122, 2)
        Me.Huvud.Margin = New System.Windows.Forms.Padding(4)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(561, 44)
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
        Me.Ver.Location = New System.Drawing.Point(13, 347)
        Me.Ver.Margin = New System.Windows.Forms.Padding(4)
        Me.Ver.Name = "Ver"
        Me.Ver.Padding = New System.Windows.Forms.Padding(4)
        Me.Ver.Size = New System.Drawing.Size(263, 90)
        Me.Ver.TabIndex = 377
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
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(86, 281)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(629, 25)
        Me.Label22.TabIndex = 546
        Me.Label22.Text = "OBS. Använda dessa rutiner med ytterst försiktighet och ansvar!"
        '
        'SpecrutinerF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Huvud)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.TomLabProdukterB)
        Me.Controls.Add(Me.TomProvRegB)
        Me.Controls.Add(Me.TomTestArkivB)
        Me.Name = "SpecrutinerF"
        Me.Text = "Speciala rutiner"
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TomTestArkivB As Button
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
