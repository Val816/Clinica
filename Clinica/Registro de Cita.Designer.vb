﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro_de_Cita
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
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

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_de_Cita))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.btnRegistrarCita = New System.Windows.Forms.Button()
		Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
		Me.txtHora = New System.Windows.Forms.TextBox()
		Me.txtEspecie = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtNomMascota = New System.Windows.Forms.TextBox()
		Me.txtTelefono = New System.Windows.Forms.TextBox()
		Me.txtApellido = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtNomCliente = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.DataGridViewCitas = New System.Windows.Forms.DataGridView()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		CType(Me.DataGridViewCitas, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-1, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(855, 98)
		Me.Panel1.TabIndex = 1
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(526, 43)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(93, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("MV Boli", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(177, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(287, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Registro de Cita"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel2.ForeColor = System.Drawing.Color.LightSlateGray
		Me.Panel2.Location = New System.Drawing.Point(-1, 443)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(855, 77)
		Me.Panel2.TabIndex = 2
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Panel3.Controls.Add(Me.btnRegistrarCita)
		Me.Panel3.Controls.Add(Me.DateTimePickerFecha)
		Me.Panel3.Controls.Add(Me.txtHora)
		Me.Panel3.Controls.Add(Me.txtEspecie)
		Me.Panel3.Controls.Add(Me.Label8)
		Me.Panel3.Controls.Add(Me.txtNomMascota)
		Me.Panel3.Controls.Add(Me.txtTelefono)
		Me.Panel3.Controls.Add(Me.txtApellido)
		Me.Panel3.Controls.Add(Me.Label7)
		Me.Panel3.Controls.Add(Me.txtNomCliente)
		Me.Panel3.Controls.Add(Me.TextBox1)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Controls.Add(Me.Label5)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(11, 120)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(319, 281)
		Me.Panel3.TabIndex = 3
		'
		'btnRegistrarCita
		'
		Me.btnRegistrarCita.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnRegistrarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnRegistrarCita.Location = New System.Drawing.Point(120, 254)
		Me.btnRegistrarCita.Margin = New System.Windows.Forms.Padding(2)
		Me.btnRegistrarCita.Name = "btnRegistrarCita"
		Me.btnRegistrarCita.Size = New System.Drawing.Size(93, 25)
		Me.btnRegistrarCita.TabIndex = 7
		Me.btnRegistrarCita.Text = "Registrar cita"
		Me.btnRegistrarCita.UseVisualStyleBackColor = False
		'
		'DateTimePickerFecha
		'
		Me.DateTimePickerFecha.Location = New System.Drawing.Point(141, 183)
		Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
		Me.DateTimePickerFecha.Size = New System.Drawing.Size(149, 20)
		Me.DateTimePickerFecha.TabIndex = 8
		'
		'txtHora
		'
		Me.txtHora.BackColor = System.Drawing.Color.Silver
		Me.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtHora.Location = New System.Drawing.Point(141, 208)
		Me.txtHora.Margin = New System.Windows.Forms.Padding(2)
		Me.txtHora.Multiline = True
		Me.txtHora.Name = "txtHora"
		Me.txtHora.Size = New System.Drawing.Size(149, 27)
		Me.txtHora.TabIndex = 6
		'
		'txtEspecie
		'
		Me.txtEspecie.BackColor = System.Drawing.Color.Silver
		Me.txtEspecie.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtEspecie.Location = New System.Drawing.Point(141, 143)
		Me.txtEspecie.Margin = New System.Windows.Forms.Padding(2)
		Me.txtEspecie.Multiline = True
		Me.txtEspecie.Name = "txtEspecie"
		Me.txtEspecie.Size = New System.Drawing.Size(149, 27)
		Me.txtEspecie.TabIndex = 8
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Silver
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label8.Location = New System.Drawing.Point(26, 208)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(97, 27)
		Me.Label8.TabIndex = 5
		Me.Label8.Text = "Hora:"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtNomMascota
		'
		Me.txtNomMascota.BackColor = System.Drawing.Color.Silver
		Me.txtNomMascota.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNomMascota.Location = New System.Drawing.Point(141, 111)
		Me.txtNomMascota.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNomMascota.Multiline = True
		Me.txtNomMascota.Name = "txtNomMascota"
		Me.txtNomMascota.Size = New System.Drawing.Size(149, 27)
		Me.txtNomMascota.TabIndex = 8
		'
		'txtTelefono
		'
		Me.txtTelefono.BackColor = System.Drawing.Color.Silver
		Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtTelefono.Location = New System.Drawing.Point(141, 80)
		Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2)
		Me.txtTelefono.Multiline = True
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(149, 27)
		Me.txtTelefono.TabIndex = 7
		'
		'txtApellido
		'
		Me.txtApellido.BackColor = System.Drawing.Color.Silver
		Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtApellido.Location = New System.Drawing.Point(141, 49)
		Me.txtApellido.Margin = New System.Windows.Forms.Padding(2)
		Me.txtApellido.Multiline = True
		Me.txtApellido.Name = "txtApellido"
		Me.txtApellido.Size = New System.Drawing.Size(149, 27)
		Me.txtApellido.TabIndex = 6
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Silver
		Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label7.Location = New System.Drawing.Point(26, 176)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(97, 27)
		Me.Label7.TabIndex = 1
		Me.Label7.Text = "Fecha:"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtNomCliente
		'
		Me.txtNomCliente.BackColor = System.Drawing.Color.Silver
		Me.txtNomCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNomCliente.Location = New System.Drawing.Point(141, 19)
		Me.txtNomCliente.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNomCliente.Multiline = True
		Me.txtNomCliente.Name = "txtNomCliente"
		Me.txtNomCliente.Size = New System.Drawing.Size(149, 27)
		Me.txtNomCliente.TabIndex = 5
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(150, 33)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(1, 20)
		Me.TextBox1.TabIndex = 5
		Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Silver
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Location = New System.Drawing.Point(26, 143)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(97, 27)
		Me.Label6.TabIndex = 4
		Me.Label6.Text = "Especie:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Silver
		Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label5.Location = New System.Drawing.Point(26, 111)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(97, 27)
		Me.Label5.TabIndex = 3
		Me.Label5.Text = "Nombre de mascota:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Silver
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Location = New System.Drawing.Point(26, 80)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(97, 27)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "Teléfono:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Silver
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Location = New System.Drawing.Point(26, 49)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(97, 27)
		Me.Label3.TabIndex = 1
		Me.Label3.Text = "Apellido:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Silver
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Location = New System.Drawing.Point(26, 19)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(97, 27)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Nombre de tutor:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DataGridViewCitas
		'
		Me.DataGridViewCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridViewCitas.Location = New System.Drawing.Point(335, 120)
		Me.DataGridViewCitas.Name = "DataGridViewCitas"
		Me.DataGridViewCitas.Size = New System.Drawing.Size(283, 215)
		Me.DataGridViewCitas.TabIndex = 0
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(374, 340)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(203, 99)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 5
		Me.PictureBox1.TabStop = False
		'
		'Registro_de_Cita
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(636, 487)
		Me.Controls.Add(Me.DataGridViewCitas)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Registro_de_Cita"
		Me.Text = "Registro de Cita"
		Me.Panel1.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.DataGridViewCitas, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnMenuPrincipal As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents txtNomCliente As TextBox
	Friend WithEvents txtEspecie As TextBox
	Friend WithEvents txtNomMascota As TextBox
	Friend WithEvents txtTelefono As TextBox
	Friend WithEvents txtApellido As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents btnRegistrarCita As Button
	Friend WithEvents txtHora As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents DateTimePickerFecha As DateTimePicker
	Friend WithEvents DataGridViewCitas As DataGridView
End Class
