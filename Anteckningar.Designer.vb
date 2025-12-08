<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnteckningarF
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AnteckningarTB = New System.Windows.Forms.TextBox()
        Me.DatumTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NyB = New System.Windows.Forms.Button()
        Me.RaderaB = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SoktextTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Ver.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(190, 12)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(668, 36)
        Me.Huvud.TabIndex = 279
        Me.Huvud.Text = "Anteckningar"
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
        Me.Ver.Location = New System.Drawing.Point(15, 620)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(197, 73)
        Me.Ver.TabIndex = 324
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
        'SparaB
        '
        Me.SparaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaB.Location = New System.Drawing.Point(954, 580)
        Me.SparaB.Name = "SparaB"
        Me.SparaB.Size = New System.Drawing.Size(98, 25)
        Me.SparaB.TabIndex = 377
        Me.SparaB.Text = "Spara"
        Me.SparaB.UseVisualStyleBackColor = True
        '
        'AvslutaK
        '
        Me.AvslutaK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaK.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaK.Location = New System.Drawing.Point(954, 649)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(98, 25)
        Me.AvslutaK.TabIndex = 376
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(89, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(978, 151)
        Me.DataGridView1.TabIndex = 378
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(338, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 382
        Me.Label3.Text = "Anteckningar"
        '
        'AnteckningarTB
        '
        Me.AnteckningarTB.Location = New System.Drawing.Point(331, 261)
        Me.AnteckningarTB.Multiline = True
        Me.AnteckningarTB.Name = "AnteckningarTB"
        Me.AnteckningarTB.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AnteckningarTB.Size = New System.Drawing.Size(736, 296)
        Me.AnteckningarTB.TabIndex = 381
        '
        'DatumTB
        '
        Me.DatumTB.Location = New System.Drawing.Point(89, 267)
        Me.DatumTB.Name = "DatumTB"
        Me.DatumTB.Size = New System.Drawing.Size(142, 20)
        Me.DatumTB.TabIndex = 380
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 379
        Me.Label2.Text = "Reg Datum"
        '
        'NyB
        '
        Me.NyB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NyB.ForeColor = System.Drawing.Color.Maroon
        Me.NyB.Location = New System.Drawing.Point(735, 649)
        Me.NyB.Name = "NyB"
        Me.NyB.Size = New System.Drawing.Size(98, 25)
        Me.NyB.TabIndex = 383
        Me.NyB.Text = "Ny"
        Me.NyB.UseVisualStyleBackColor = True
        '
        'RaderaB
        '
        Me.RaderaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaderaB.ForeColor = System.Drawing.Color.Maroon
        Me.RaderaB.Location = New System.Drawing.Point(812, 580)
        Me.RaderaB.Name = "RaderaB"
        Me.RaderaB.Size = New System.Drawing.Size(98, 25)
        Me.RaderaB.TabIndex = 384
        Me.RaderaB.Text = "Radera"
        Me.RaderaB.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(13, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 25)
        Me.Button1.TabIndex = 385
        Me.Button1.Text = "Välj"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SoktextTB
        '
        Me.SoktextTB.Location = New System.Drawing.Point(15, 61)
        Me.SoktextTB.Name = "SoktextTB"
        Me.SoktextTB.Size = New System.Drawing.Size(196, 20)
        Me.SoktextTB.TabIndex = 387
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 386
        Me.Label1.Text = "Sök text"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Wingdings 3", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label35.Location = New System.Drawing.Point(217, 66)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(20, 15)
        Me.Label35.TabIndex = 388
        Me.Label35.Text = "8"
        '
        'AnteckningarF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 696)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.SoktextTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RaderaB)
        Me.Controls.Add(Me.NyB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AnteckningarTB)
        Me.Controls.Add(Me.DatumTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SparaB)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Huvud)
        Me.Name = "AnteckningarF"
        Me.Text = "Anteckningar"
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
    Friend WithEvents SparaB As Button
    Friend WithEvents AvslutaK As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents AnteckningarTB As TextBox
    Friend WithEvents DatumTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NyB As Button
    Friend WithEvents RaderaB As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SoktextTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label35 As Label
End Class
