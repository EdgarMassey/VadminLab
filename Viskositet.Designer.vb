<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViskositetF
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProdIDCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LAdress1TB = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.NYBT = New System.Windows.Forms.Button()
        Me.SparaB = New System.Windows.Forms.Button()
        Me.AvslutaK = New System.Windows.Forms.Button()
        Me.Ver.SuspendLayout()
        Me.SuspendLayout()
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(70, 12)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(668, 36)
        Me.Huvud.TabIndex = 396
        Me.Huvud.Text = "Viskositetsreg"
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
        Me.Ver.Location = New System.Drawing.Point(12, 484)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(197, 73)
        Me.Ver.TabIndex = 397
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 404
        Me.Label3.Text = "Provkopp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(211, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 445
        Me.Label4.Text = "Produkt ID"
        '
        'ProdIDCB
        '
        Me.ProdIDCB.BackColor = System.Drawing.Color.Gainsboro
        Me.ProdIDCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdIDCB.ForeColor = System.Drawing.Color.Maroon
        Me.ProdIDCB.FormattingEnabled = True
        Me.ProdIDCB.Location = New System.Drawing.Point(299, 64)
        Me.ProdIDCB.Margin = New System.Windows.Forms.Padding(2)
        Me.ProdIDCB.Name = "ProdIDCB"
        Me.ProdIDCB.Size = New System.Drawing.Size(274, 25)
        Me.ProdIDCB.TabIndex = 444
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 446
        Me.Label1.Text = "Program"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 448
        Me.Label2.Text = "Mäthastighet"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 447
        Me.Label5.Text = "Provmetod"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 450
        Me.Label6.Text = "Max och min"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 17)
        Me.Label7.TabIndex = 449
        Me.Label7.Text = "Flytgränshastighet"
        '
        'LAdress1TB
        '
        Me.LAdress1TB.Location = New System.Drawing.Point(159, 153)
        Me.LAdress1TB.Name = "LAdress1TB"
        Me.LAdress1TB.Size = New System.Drawing.Size(199, 20)
        Me.LAdress1TB.TabIndex = 451
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(159, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 20)
        Me.TextBox1.TabIndex = 452
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(159, 247)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(199, 20)
        Me.TextBox2.TabIndex = 453
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(159, 293)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(199, 20)
        Me.TextBox3.TabIndex = 454
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(159, 333)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(199, 20)
        Me.TextBox4.TabIndex = 455
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(159, 379)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(199, 20)
        Me.TextBox5.TabIndex = 456
        '
        'NYBT
        '
        Me.NYBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NYBT.ForeColor = System.Drawing.Color.Maroon
        Me.NYBT.Location = New System.Drawing.Point(285, 447)
        Me.NYBT.Name = "NYBT"
        Me.NYBT.Size = New System.Drawing.Size(62, 25)
        Me.NYBT.TabIndex = 459
        Me.NYBT.Text = "Ny"
        Me.NYBT.UseVisualStyleBackColor = True
        '
        'SparaB
        '
        Me.SparaB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaB.Location = New System.Drawing.Point(601, 447)
        Me.SparaB.Name = "SparaB"
        Me.SparaB.Size = New System.Drawing.Size(98, 25)
        Me.SparaB.TabIndex = 458
        Me.SparaB.Text = "Spara"
        Me.SparaB.UseVisualStyleBackColor = True
        '
        'AvslutaK
        '
        Me.AvslutaK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaK.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaK.Location = New System.Drawing.Point(605, 478)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(95, 25)
        Me.AvslutaK.TabIndex = 457
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'ViskositetF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 569)
        Me.Controls.Add(Me.NYBT)
        Me.Controls.Add(Me.SparaB)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LAdress1TB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProdIDCB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Huvud)
        Me.Name = "ViskositetF"
        Me.Text = "Viskositet"
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProdIDCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LAdress1TB As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents NYBT As Button
    Friend WithEvents SparaB As Button
    Friend WithEvents AvslutaK As Button
End Class
