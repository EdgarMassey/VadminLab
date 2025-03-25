<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalenderTypAndOwnersF
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SparaB = New System.Windows.Forms.Button()
        Me.OwnerTB = New System.Windows.Forms.TextBox()
        Me.Huvud = New System.Windows.Forms.Button()
        Me.Ver = New System.Windows.Forms.GroupBox()
        Me.Gnamn = New System.Windows.Forms.Label()
        Me.KlientIdl = New System.Windows.Forms.Label()
        Me.odbcsource = New System.Windows.Forms.Label()
        Me.databas = New System.Windows.Forms.Label()
        Me.datum = New System.Windows.Forms.Label()
        Me.Versionl = New System.Windows.Forms.Label()
        Me.AvslutaB = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ver.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(249, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(250, 216)
        Me.DataGridView1.TabIndex = 0
        '
        'SparaB
        '
        Me.SparaB.BackColor = System.Drawing.Color.Cornsilk
        Me.SparaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SparaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaB.Location = New System.Drawing.Point(266, 350)
        Me.SparaB.Margin = New System.Windows.Forms.Padding(4)
        Me.SparaB.Name = "SparaB"
        Me.SparaB.Size = New System.Drawing.Size(221, 31)
        Me.SparaB.TabIndex = 404
        Me.SparaB.Text = "Spara "
        Me.SparaB.UseVisualStyleBackColor = False
        '
        'OwnerTB
        '
        Me.OwnerTB.Location = New System.Drawing.Point(284, 97)
        Me.OwnerTB.Name = "OwnerTB"
        Me.OwnerTB.Size = New System.Drawing.Size(166, 22)
        Me.OwnerTB.TabIndex = 405
        Me.OwnerTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Huvud
        '
        Me.Huvud.BackColor = System.Drawing.Color.Cornsilk
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(91, 13)
        Me.Huvud.Margin = New System.Windows.Forms.Padding(4)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(592, 44)
        Me.Huvud.TabIndex = 406
        Me.Huvud.Text = "Calender"
        Me.Huvud.UseVisualStyleBackColor = False
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
        Me.Ver.Location = New System.Drawing.Point(13, 439)
        Me.Ver.Margin = New System.Windows.Forms.Padding(4)
        Me.Ver.Name = "Ver"
        Me.Ver.Padding = New System.Windows.Forms.Padding(4)
        Me.Ver.Size = New System.Drawing.Size(263, 90)
        Me.Ver.TabIndex = 407
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
        Me.KlientIdl.Location = New System.Drawing.Point(8, 19)
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
        Me.databas.Location = New System.Drawing.Point(8, 36)
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
        'AvslutaB
        '
        Me.AvslutaB.BackColor = System.Drawing.Color.Cornsilk
        Me.AvslutaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AvslutaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaB.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaB.Location = New System.Drawing.Point(665, 491)
        Me.AvslutaB.Margin = New System.Windows.Forms.Padding(4)
        Me.AvslutaB.Name = "AvslutaB"
        Me.AvslutaB.Size = New System.Drawing.Size(122, 31)
        Me.AvslutaB.TabIndex = 408
        Me.AvslutaB.Text = "Avsluta"
        Me.AvslutaB.UseVisualStyleBackColor = False
        '
        'CalenderTypAndOwnersF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 542)
        Me.Controls.Add(Me.AvslutaB)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Huvud)
        Me.Controls.Add(Me.OwnerTB)
        Me.Controls.Add(Me.SparaB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CalenderTypAndOwnersF"
        Me.Text = "CalenderTypAndOwners"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SparaB As Button
    Friend WithEvents OwnerTB As TextBox
    Friend WithEvents Huvud As Button
    Friend WithEvents Ver As GroupBox
    Friend WithEvents Gnamn As Label
    Friend WithEvents KlientIdl As Label
    Friend WithEvents odbcsource As Label
    Friend WithEvents databas As Label
    Friend WithEvents datum As Label
    Friend WithEvents Versionl As Label
    Friend WithEvents AvslutaB As Button
End Class
