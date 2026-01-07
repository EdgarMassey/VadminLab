<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BehorighetF
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3TB = New System.Windows.Forms.Label()
        Me.Label2TB = New System.Windows.Forms.Label()
        Me.Label1TB = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ver.SuspendLayout()
        Me.SuspendLayout()
        '
        'Spara
        '
        Me.Spara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spara.ForeColor = System.Drawing.Color.Maroon
        Me.Spara.Location = New System.Drawing.Point(492, 386)
        Me.Spara.Name = "Spara"
        Me.Spara.Size = New System.Drawing.Size(95, 25)
        Me.Spara.TabIndex = 280
        Me.Spara.Text = "Spara"
        Me.Spara.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(628, 280)
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
        Me.Ver.Location = New System.Drawing.Point(12, 468)
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
        'AvslutaK
        '
        Me.AvslutaK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaK.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaK.Location = New System.Drawing.Point(489, 507)
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
        Me.Huvud.Location = New System.Drawing.Point(227, -70)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(360, 36)
        Me.Huvud.TabIndex = 276
        Me.Huvud.Text = "Leveranssätt"
        Me.Huvud.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(103, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(431, 36)
        Me.Button1.TabIndex = 281
        Me.Button1.Text = "Behörighetsregister"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(199, 349)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 316
        Me.Label18.Text = "Extra rabatt"
        '
        'Label3TB
        '
        Me.Label3TB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3TB.Location = New System.Drawing.Point(214, 423)
        Me.Label3TB.Name = "Label3TB"
        Me.Label3TB.Size = New System.Drawing.Size(251, 20)
        Me.Label3TB.TabIndex = 315
        Me.Label3TB.Text = "3  - Lönesystemet"
        Me.Label3TB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2TB
        '
        Me.Label2TB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2TB.Location = New System.Drawing.Point(214, 404)
        Me.Label2TB.Name = "Label2TB"
        Me.Label2TB.Size = New System.Drawing.Size(251, 20)
        Me.Label2TB.TabIndex = 314
        Me.Label2TB.Text = "2  - RedovisningSystem"
        Me.Label2TB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1TB
        '
        Me.Label1TB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1TB.Location = New System.Drawing.Point(214, 384)
        Me.Label1TB.Name = "Label1TB"
        Me.Label1TB.Size = New System.Drawing.Size(251, 20)
        Me.Label1TB.TabIndex = 313
        Me.Label1TB.Text = "1  - Total behörighet"
        Me.Label1TB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 463)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 20)
        Me.Label2.TabIndex = 318
        Me.Label2.Text = "5  - OLF butik"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(214, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 20)
        Me.Label3.TabIndex = 317
        Me.Label3.Text = "4  - OLF systemet"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 482)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 20)
        Me.Label1.TabIndex = 319
        Me.Label1.Text = "6  - Receptsystemet"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(214, 503)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 20)
        Me.Label4.TabIndex = 320
        Me.Label4.Text = "7  - LabReceptsystemet"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BehorighetF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 553)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label3TB)
        Me.Controls.Add(Me.Label2TB)
        Me.Controls.Add(Me.Label1TB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Spara)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.Huvud)
        Me.Name = "BehorighetF"
        Me.Text = "BehörighetsRegister"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label3TB As Label
    Friend WithEvents Label2TB As Label
    Friend WithEvents Label1TB As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
