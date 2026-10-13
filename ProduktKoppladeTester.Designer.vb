<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProduktkoppladeTesterF
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
        Me.DeleteProvmetodBT = New System.Windows.Forms.Button()
        Me.AddMainItemBT = New System.Windows.Forms.Button()
        Me.AvslutaK = New System.Windows.Forms.Button()
        Me.AddSubItemBT = New System.Windows.Forms.Button()
        Me.ProvmetodTreeView = New System.Windows.Forms.TreeView()
        Me.Ver.SuspendLayout()
        Me.SuspendLayout()
        '
        'Huvud
        '
        Me.Huvud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Huvud.ForeColor = System.Drawing.Color.Maroon
        Me.Huvud.Location = New System.Drawing.Point(70, 12)
        Me.Huvud.Name = "Huvud"
        Me.Huvud.Size = New System.Drawing.Size(574, 36)
        Me.Huvud.TabIndex = 396
        Me.Huvud.Text = "Produktkopplade tester"
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
        'DeleteProvmetodBT
        '
        Me.DeleteProvmetodBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteProvmetodBT.ForeColor = System.Drawing.Color.Maroon
        Me.DeleteProvmetodBT.Location = New System.Drawing.Point(470, 514)
        Me.DeleteProvmetodBT.Name = "DeleteProvmetodBT"
        Me.DeleteProvmetodBT.Size = New System.Drawing.Size(62, 25)
        Me.DeleteProvmetodBT.TabIndex = 459
        Me.DeleteProvmetodBT.Text = "Radera"
        Me.DeleteProvmetodBT.UseVisualStyleBackColor = True
        '
        'AddMainItemBT
        '
        Me.AddMainItemBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMainItemBT.ForeColor = System.Drawing.Color.Maroon
        Me.AddMainItemBT.Location = New System.Drawing.Point(27, 72)
        Me.AddMainItemBT.Name = "AddMainItemBT"
        Me.AddMainItemBT.Size = New System.Drawing.Size(98, 25)
        Me.AddMainItemBT.TabIndex = 458
        Me.AddMainItemBT.Text = "Add Produkt"
        Me.AddMainItemBT.UseVisualStyleBackColor = True
        '
        'AvslutaK
        '
        Me.AvslutaK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaK.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaK.Location = New System.Drawing.Point(559, 526)
        Me.AvslutaK.Name = "AvslutaK"
        Me.AvslutaK.Size = New System.Drawing.Size(95, 25)
        Me.AvslutaK.TabIndex = 457
        Me.AvslutaK.Text = "Avsluta"
        Me.AvslutaK.UseVisualStyleBackColor = True
        '
        'AddSubItemBT
        '
        Me.AddSubItemBT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSubItemBT.ForeColor = System.Drawing.Color.Maroon
        Me.AddSubItemBT.Location = New System.Drawing.Point(556, 446)
        Me.AddSubItemBT.Name = "AddSubItemBT"
        Me.AddSubItemBT.Size = New System.Drawing.Size(98, 25)
        Me.AddSubItemBT.TabIndex = 469
        Me.AddSubItemBT.Text = "Add subitem"
        Me.AddSubItemBT.UseVisualStyleBackColor = True
        '
        'ProvmetodTreeView
        '
        Me.ProvmetodTreeView.AccessibleDescription = "Provmetoder"
        Me.ProvmetodTreeView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvmetodTreeView.Location = New System.Drawing.Point(153, 54)
        Me.ProvmetodTreeView.Name = "ProvmetodTreeView"
        Me.ProvmetodTreeView.Size = New System.Drawing.Size(351, 417)
        Me.ProvmetodTreeView.TabIndex = 470
        '
        'ProduktkoppladeTesterF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 569)
        Me.Controls.Add(Me.ProvmetodTreeView)
        Me.Controls.Add(Me.AddSubItemBT)
        Me.Controls.Add(Me.DeleteProvmetodBT)
        Me.Controls.Add(Me.AddMainItemBT)
        Me.Controls.Add(Me.AvslutaK)
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Huvud)
        Me.Name = "ProduktkoppladeTesterF"
        Me.Text = "ProduktkoppladeTester"
        Me.Ver.ResumeLayout(False)
        Me.Ver.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Huvud As Button
    Friend WithEvents Ver As GroupBox
    Friend WithEvents Gnamn As Label
    Friend WithEvents KlientIdl As Label
    Friend WithEvents odbcsourcel As Label
    Friend WithEvents databas As Label
    Friend WithEvents datum As Label
    Friend WithEvents Versionl As Label
    Friend WithEvents DeleteProvmetodBT As Button
    Friend WithEvents AddMainItemBT As Button
    Friend WithEvents AvslutaK As Button
    Friend WithEvents AddSubItemBT As Button
    Friend WithEvents ProvmetodTreeView As TreeView
End Class
