<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalenderOwnerF
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
        Me.SparaB = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RaderaB = New System.Windows.Forms.Button()
        Me.OwnerTB = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.OrderTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AvslutaB = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SparaB
        '
        Me.SparaB.BackColor = System.Drawing.Color.Cornsilk
        Me.SparaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SparaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparaB.ForeColor = System.Drawing.Color.Maroon
        Me.SparaB.Location = New System.Drawing.Point(58, 200)
        Me.SparaB.Margin = New System.Windows.Forms.Padding(4)
        Me.SparaB.Name = "SparaB"
        Me.SparaB.Size = New System.Drawing.Size(221, 31)
        Me.SparaB.TabIndex = 406
        Me.SparaB.Text = "Spara "
        Me.SparaB.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(359, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(250, 216)
        Me.DataGridView1.TabIndex = 405
        '
        'RaderaB
        '
        Me.RaderaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaderaB.ForeColor = System.Drawing.Color.Maroon
        Me.RaderaB.Location = New System.Drawing.Point(58, 254)
        Me.RaderaB.Margin = New System.Windows.Forms.Padding(4)
        Me.RaderaB.Name = "RaderaB"
        Me.RaderaB.Size = New System.Drawing.Size(219, 31)
        Me.RaderaB.TabIndex = 409
        Me.RaderaB.Text = "Radera"
        Me.RaderaB.UseVisualStyleBackColor = True
        '
        'OwnerTB
        '
        Me.OwnerTB.Location = New System.Drawing.Point(164, 69)
        Me.OwnerTB.Margin = New System.Windows.Forms.Padding(4)
        Me.OwnerTB.Name = "OwnerTB"
        Me.OwnerTB.Size = New System.Drawing.Size(135, 22)
        Me.OwnerTB.TabIndex = 408
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(86, 45)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 20)
        Me.Label26.TabIndex = 407
        Me.Label26.Text = "Order"
        '
        'OrderTB
        '
        Me.OrderTB.Location = New System.Drawing.Point(68, 69)
        Me.OrderTB.Margin = New System.Windows.Forms.Padding(4)
        Me.OrderTB.Name = "OrderTB"
        Me.OrderTB.Size = New System.Drawing.Size(88, 22)
        Me.OrderTB.TabIndex = 410
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 411
        Me.Label1.Text = "Owner"
        '
        'AvslutaB
        '
        Me.AvslutaB.BackColor = System.Drawing.Color.Cornsilk
        Me.AvslutaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AvslutaB.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvslutaB.ForeColor = System.Drawing.Color.Maroon
        Me.AvslutaB.Location = New System.Drawing.Point(501, 390)
        Me.AvslutaB.Margin = New System.Windows.Forms.Padding(4)
        Me.AvslutaB.Name = "AvslutaB"
        Me.AvslutaB.Size = New System.Drawing.Size(122, 31)
        Me.AvslutaB.TabIndex = 412
        Me.AvslutaB.Text = "Avsluta"
        Me.AvslutaB.UseVisualStyleBackColor = False
        '
        'CalenderOwnerF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 434)
        Me.Controls.Add(Me.AvslutaB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OrderTB)
        Me.Controls.Add(Me.RaderaB)
        Me.Controls.Add(Me.OwnerTB)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.SparaB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CalenderOwnerF"
        Me.Text = "CalenderOwner"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SparaB As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RaderaB As Button
    Friend WithEvents OwnerTB As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents OrderTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AvslutaB As Button
End Class
