<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LabstartF
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
        Me.components = New System.ComponentModel.Container()
        Me.Ver = New System.Windows.Forms.GroupBox()
        Me.Gnamn = New System.Windows.Forms.Label()
        Me.KlientIdl = New System.Windows.Forms.Label()
        Me.odbcsource = New System.Windows.Forms.Label()
        Me.databas = New System.Windows.Forms.Label()
        Me.datum = New System.Windows.Forms.Label()
        Me.Versionl = New System.Windows.Forms.Label()
        Me.Huvud = New System.Windows.Forms.Button()
        Me.ProvHanteringB = New System.Windows.Forms.Button()
        Me.AvslutaB = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.POLbestB = New System.Windows.Forms.Button()
        Me.BatchreporterB = New System.Windows.Forms.Button()
        Me.SpecialrutinerB = New System.Windows.Forms.Button()
        Me.Ver.SuspendLayout()
        Me.SuspendLayout()
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
        'Huvud
        '
        Me.Huvud.BackColor = System.Drawing.Color.Cornsilk
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(56, 24)
        Me.Huvud.Margin = New System.Windows.Forms.Padding(4)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(664, 44)
        Me.Huvud.TabIndex = 324
        Me.Huvud.Text = "Labstartmeny"
        Me.Huvud.UseVisualStyleBackColor = False
        '
        'ProvHanteringB
        '
        Me.ProvHanteringB.BackColor = System.Drawing.Color.Cornsilk
        Me.ProvHanteringB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProvHanteringB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvHanteringB.ForeColor = System.Drawing.Color.Maroon
        Me.ProvHanteringB.Location = New System.Drawing.Point(177, 87)
        Me.ProvHanteringB.Margin = New System.Windows.Forms.Padding(4)
        Me.ProvHanteringB.Name = "ProvHanteringB"
        Me.ProvHanteringB.Size = New System.Drawing.Size(404, 31)
        Me.ProvHanteringB.TabIndex = 371
        Me.ProvHanteringB.Text = "Provhantering"
        Me.ProvHanteringB.UseMnemonic = False
        Me.ProvHanteringB.UseVisualStyleBackColor = False
        '
        'AvslutaB
        '
        Me.AvslutaB.BackColor = System.Drawing.Color.Cornsilk
        Me.AvslutaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AvslutaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaB.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaB.Location = New System.Drawing.Point(637, 399)
        Me.AvslutaB.Margin = New System.Windows.Forms.Padding(4)
        Me.AvslutaB.Name = "AvslutaB"
        Me.AvslutaB.Size = New System.Drawing.Size(122, 31)
        Me.AvslutaB.TabIndex = 372
        Me.AvslutaB.Text = "Avsluta"
        Me.AvslutaB.UseVisualStyleBackColor = False
        '
        'POLbestB
        '
        Me.POLbestB.BackColor = System.Drawing.Color.Cornsilk
        Me.POLbestB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.POLbestB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POLbestB.ForeColor = System.Drawing.Color.Maroon
        Me.POLbestB.Location = New System.Drawing.Point(177, 143)
        Me.POLbestB.Margin = New System.Windows.Forms.Padding(4)
        Me.POLbestB.Name = "POLbestB"
        Me.POLbestB.Size = New System.Drawing.Size(404, 31)
        Me.POLbestB.TabIndex = 374
        Me.POLbestB.Text = "POL beställningar"
        Me.POLbestB.UseVisualStyleBackColor = False
        '
        'BatchreporterB
        '
        Me.BatchreporterB.BackColor = System.Drawing.Color.Cornsilk
        Me.BatchreporterB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BatchreporterB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchreporterB.ForeColor = System.Drawing.Color.Maroon
        Me.BatchreporterB.Location = New System.Drawing.Point(177, 202)
        Me.BatchreporterB.Margin = New System.Windows.Forms.Padding(4)
        Me.BatchreporterB.Name = "BatchreporterB"
        Me.BatchreporterB.Size = New System.Drawing.Size(404, 31)
        Me.BatchreporterB.TabIndex = 375
        Me.BatchreporterB.Text = "Batch reporter"
        Me.BatchreporterB.UseVisualStyleBackColor = False
        '
        'SpecialrutinerB
        '
        Me.SpecialrutinerB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SpecialrutinerB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialrutinerB.ForeColor = System.Drawing.Color.Maroon
        Me.SpecialrutinerB.Location = New System.Drawing.Point(177, 308)
        Me.SpecialrutinerB.Margin = New System.Windows.Forms.Padding(4)
        Me.SpecialrutinerB.Name = "SpecialrutinerB"
        Me.SpecialrutinerB.Size = New System.Drawing.Size(404, 31)
        Me.SpecialrutinerB.TabIndex = 376
        Me.SpecialrutinerB.Text = "Speciela rutiner"
        Me.SpecialrutinerB.UseVisualStyleBackColor = True
        Me.SpecialrutinerB.Visible = False
        '
        'LabstartF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SpecialrutinerB)
        Me.Controls.Add(Me.BatchreporterB)
        Me.Controls.Add(Me.POLbestB)
        Me.Controls.Add(Me.AvslutaB)
        Me.Controls.Add(Me.ProvHanteringB)
        Me.Controls.Add(Me.Huvud)
        Me.Controls.Add(Me.Ver)
        Me.Name = "LabstartF"
        Me.Text = "NM Lab start"
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ver As GroupBox
    Friend WithEvents Gnamn As Label
    Friend WithEvents KlientIdl As Label
    Friend WithEvents odbcsource As Label
    Friend WithEvents databas As Label
    Friend WithEvents datum As Label
    Friend WithEvents Versionl As Label
    Friend WithEvents Huvud As Button
    Friend WithEvents ProvHanteringB As Button
    Friend WithEvents AvslutaB As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents POLbestB As Button
    Friend WithEvents BatchreporterB As Button
    Friend WithEvents SpecialrutinerB As Button
End Class
