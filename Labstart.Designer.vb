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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabstartF))
        Me.Ver = New System.Windows.Forms.GroupBox()
        Me.Gnamn = New System.Windows.Forms.Label()
        Me.KlientIdl = New System.Windows.Forms.Label()
        Me.odbcsourcel = New System.Windows.Forms.Label()
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
        Me.AnteckB = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LocalaInställningarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BesokB = New System.Windows.Forms.Button()
        Me.Ver.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Ver.Location = New System.Drawing.Point(10, 327)
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
        'Huvud
        '
        Me.Huvud.BackColor = System.Drawing.Color.Cornsilk
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(42, 20)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(498, 36)
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
        Me.ProvHanteringB.Location = New System.Drawing.Point(133, 71)
        Me.ProvHanteringB.Name = "ProvHanteringB"
        Me.ProvHanteringB.Size = New System.Drawing.Size(303, 25)
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
        Me.AvslutaB.Location = New System.Drawing.Point(478, 369)
        Me.AvslutaB.Name = "AvslutaB"
        Me.AvslutaB.Size = New System.Drawing.Size(92, 25)
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
        Me.POLbestB.Location = New System.Drawing.Point(133, 116)
        Me.POLbestB.Name = "POLbestB"
        Me.POLbestB.Size = New System.Drawing.Size(303, 25)
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
        Me.BatchreporterB.Location = New System.Drawing.Point(133, 164)
        Me.BatchreporterB.Name = "BatchreporterB"
        Me.BatchreporterB.Size = New System.Drawing.Size(303, 25)
        Me.BatchreporterB.TabIndex = 375
        Me.BatchreporterB.Text = "Batch reporter"
        Me.BatchreporterB.UseVisualStyleBackColor = False
        '
        'SpecialrutinerB
        '
        Me.SpecialrutinerB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SpecialrutinerB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialrutinerB.ForeColor = System.Drawing.Color.Maroon
        Me.SpecialrutinerB.Location = New System.Drawing.Point(133, 295)
        Me.SpecialrutinerB.Name = "SpecialrutinerB"
        Me.SpecialrutinerB.Size = New System.Drawing.Size(303, 25)
        Me.SpecialrutinerB.TabIndex = 376
        Me.SpecialrutinerB.Text = "Speciela rutiner"
        Me.SpecialrutinerB.UseVisualStyleBackColor = True
        Me.SpecialrutinerB.Visible = False
        '
        'AnteckB
        '
        Me.AnteckB.BackColor = System.Drawing.Color.Cornsilk
        Me.AnteckB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AnteckB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnteckB.ForeColor = System.Drawing.Color.Maroon
        Me.AnteckB.Location = New System.Drawing.Point(133, 206)
        Me.AnteckB.Name = "AnteckB"
        Me.AnteckB.Size = New System.Drawing.Size(303, 25)
        Me.AnteckB.TabIndex = 377
        Me.AnteckB.Text = "Anteckningar"
        Me.AnteckB.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalaInställningarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 24)
        Me.MenuStrip1.TabIndex = 378
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LocalaInställningarToolStripMenuItem
        '
        Me.LocalaInställningarToolStripMenuItem.Name = "LocalaInställningarToolStripMenuItem"
        Me.LocalaInställningarToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.LocalaInställningarToolStripMenuItem.Text = "Locala inställningar"
        '
        'BesokB
        '
        Me.BesokB.BackColor = System.Drawing.Color.Cornsilk
        Me.BesokB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BesokB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BesokB.ForeColor = System.Drawing.Color.Maroon
        Me.BesokB.Location = New System.Drawing.Point(133, 247)
        Me.BesokB.Name = "BesokB"
        Me.BesokB.Size = New System.Drawing.Size(303, 25)
        Me.BesokB.TabIndex = 379
        Me.BesokB.Text = "Besökregister"
        Me.BesokB.UseVisualStyleBackColor = False
        '
        'LabstartF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(610, 423)
        Me.Controls.Add(Me.BesokB)
        Me.Controls.Add(Me.AnteckB)
        Me.Controls.Add(Me.SpecialrutinerB)
        Me.Controls.Add(Me.BatchreporterB)
        Me.Controls.Add(Me.POLbestB)
        Me.Controls.Add(Me.AvslutaB)
        Me.Controls.Add(Me.ProvHanteringB)
        Me.Controls.Add(Me.Huvud)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LabstartF"
        Me.Text = "NM Lab start"
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ver As GroupBox
    Friend WithEvents Gnamn As Label
    Friend WithEvents KlientIdl As Label
    Friend WithEvents odbcsourcel As Label
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
    Friend WithEvents AnteckB As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LocalaInställningarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BesokB As Button
End Class
