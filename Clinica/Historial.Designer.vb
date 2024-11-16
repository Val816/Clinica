<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.cmbMascotas = New System.Windows.Forms.ComboBox()
		Me.tx = New System.Windows.Forms.TextBox()
		Me.txtCelularCliente = New System.Windows.Forms.TextBox()
		Me.txtNombreCliente = New System.Windows.Forms.TextBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.dgvHistorial = New System.Windows.Forms.DataGridView()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-3, -1)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(841, 85)
		Me.Panel1.TabIndex = 14
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(566, 29)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(106, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(274, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(141, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Historial"
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(13, 6)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(111, 33)
		Me.Label3.TabIndex = 76
		Me.Label3.Text = "Nombre de tutor:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(13, 46)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(111, 33)
		Me.Label4.TabIndex = 78
		Me.Label4.Text = "Apellido del tutor:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(48, 84)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(76, 33)
		Me.Label5.TabIndex = 80
		Me.Label5.Text = "Teléfono:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(277, 25)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(77, 33)
		Me.Label6.TabIndex = 82
		Me.Label6.Text = "Mascota:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.Label2)
		Me.Panel2.Location = New System.Drawing.Point(-3, 400)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(841, 138)
		Me.Panel2.TabIndex = 83
		'
		'Label2
		'
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(328, 29)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(419, 39)
		Me.Label2.TabIndex = 0
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.btnBuscar)
		Me.Panel3.Controls.Add(Me.cmbMascotas)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.tx)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.txtCelularCliente)
		Me.Panel3.Controls.Add(Me.Label5)
		Me.Panel3.Controls.Add(Me.txtNombreCliente)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Location = New System.Drawing.Point(79, 97)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(514, 122)
		Me.Panel3.TabIndex = 85
		'
		'cmbMascotas
		'
		Me.cmbMascotas.FormattingEnabled = True
		Me.cmbMascotas.Location = New System.Drawing.Point(354, 37)
		Me.cmbMascotas.Name = "cmbMascotas"
		Me.cmbMascotas.Size = New System.Drawing.Size(121, 21)
		Me.cmbMascotas.TabIndex = 91
		'
		'tx
		'
		Me.tx.BackColor = System.Drawing.Color.White
		Me.tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tx.Location = New System.Drawing.Point(125, 54)
		Me.tx.Margin = New System.Windows.Forms.Padding(2)
		Me.tx.Multiline = True
		Me.tx.Name = "tx"
		Me.tx.Size = New System.Drawing.Size(129, 23)
		Me.tx.TabIndex = 87
		'
		'txtCelularCliente
		'
		Me.txtCelularCliente.BackColor = System.Drawing.Color.White
		Me.txtCelularCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtCelularCliente.Location = New System.Drawing.Point(125, 92)
		Me.txtCelularCliente.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCelularCliente.Multiline = True
		Me.txtCelularCliente.Name = "txtCelularCliente"
		Me.txtCelularCliente.Size = New System.Drawing.Size(129, 23)
		Me.txtCelularCliente.TabIndex = 89
		'
		'txtNombreCliente
		'
		Me.txtNombreCliente.BackColor = System.Drawing.Color.White
		Me.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtNombreCliente.Location = New System.Drawing.Point(125, 14)
		Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNombreCliente.Multiline = True
		Me.txtNombreCliente.Name = "txtNombreCliente"
		Me.txtNombreCliente.Size = New System.Drawing.Size(129, 23)
		Me.txtNombreCliente.TabIndex = 88
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Location = New System.Drawing.Point(368, 84)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(93, 25)
		Me.btnBuscar.TabIndex = 86
		Me.btnBuscar.Text = "Aceptar"
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'dgvHistorial
		'
		Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvHistorial.Location = New System.Drawing.Point(24, 235)
		Me.dgvHistorial.Name = "dgvHistorial"
		Me.dgvHistorial.Size = New System.Drawing.Size(621, 143)
		Me.dgvHistorial.TabIndex = 87
		'
		'Historial
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(680, 452)
		Me.Controls.Add(Me.dgvHistorial)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Historial"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Historial"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
	Friend WithEvents Panel3 As Panel
	Friend WithEvents btnBuscar As Button
	Friend WithEvents tx As TextBox
	Friend WithEvents txtNombreCliente As TextBox
	Friend WithEvents txtCelularCliente As TextBox
	Friend WithEvents dgvHistorial As DataGridView
	Friend WithEvents cmbMascotas As ComboBox
End Class
