<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desparacitación
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desparacitación))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.cmbDesparacitacion = New System.Windows.Forms.ComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtObservaciones = New System.Windows.Forms.TextBox()
		Me.cmbServicios = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblNombreMascota = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(842, 116)
		Me.Panel1.TabIndex = 5
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(630, 29)
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
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(268, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(337, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Desparacitación"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Controls.Add(Me.Button2)
		Me.Panel2.Location = New System.Drawing.Point(-36, 407)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(839, 130)
		Me.Panel2.TabIndex = 6
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Location = New System.Drawing.Point(474, 18)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(614, 18)
		Me.Button2.Margin = New System.Windows.Forms.Padding(2)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(115, 25)
		Me.Button2.TabIndex = 6
		Me.Button2.Text = "Continuar a recibo"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'cmbDesparacitacion
		'
		Me.cmbDesparacitacion.BackColor = System.Drawing.SystemColors.InfoText
		Me.cmbDesparacitacion.ForeColor = System.Drawing.Color.White
		Me.cmbDesparacitacion.FormattingEnabled = True
		Me.cmbDesparacitacion.Items.AddRange(New Object() {"Chico", "Mediano", "Grande"})
		Me.cmbDesparacitacion.Location = New System.Drawing.Point(249, 153)
		Me.cmbDesparacitacion.Margin = New System.Windows.Forms.Padding(2)
		Me.cmbDesparacitacion.Name = "cmbDesparacitacion"
		Me.cmbDesparacitacion.Size = New System.Drawing.Size(147, 21)
		Me.cmbDesparacitacion.TabIndex = 26
		Me.cmbDesparacitacion.Text = "Desparacitación"
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Silver
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label10.Location = New System.Drawing.Point(437, 161)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(101, 39)
		Me.Label10.TabIndex = 27
		Me.Label10.Text = "Observaciones:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtObservaciones
		'
		Me.txtObservaciones.BackColor = System.Drawing.Color.Silver
		Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtObservaciones.Location = New System.Drawing.Point(542, 155)
		Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.txtObservaciones.Multiline = True
		Me.txtObservaciones.Name = "txtObservaciones"
		Me.txtObservaciones.Size = New System.Drawing.Size(182, 60)
		Me.txtObservaciones.TabIndex = 28
		Me.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'cmbServicios
		'
		Me.cmbServicios.BackColor = System.Drawing.SystemColors.InfoText
		Me.cmbServicios.ForeColor = System.Drawing.Color.White
		Me.cmbServicios.FormattingEnabled = True
		Me.cmbServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Cirugía", "Grooming", "Pensión", "Eutanasia"})
		Me.cmbServicios.Location = New System.Drawing.Point(577, 261)
		Me.cmbServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.cmbServicios.Name = "cmbServicios"
		Me.cmbServicios.Size = New System.Drawing.Size(147, 21)
		Me.cmbServicios.TabIndex = 32
		Me.cmbServicios.Text = "Agregar Servicio"
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Silver
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Location = New System.Drawing.Point(553, 357)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(62, 24)
		Me.Label12.TabIndex = 33
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(35, 209)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(361, 168)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 35
		Me.PictureBox1.TabStop = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(62, 161)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(51, 13)
		Me.Label2.TabIndex = 36
		Me.Label2.Text = "Mascota:"
		'
		'lblNombreMascota
		'
		Me.lblNombreMascota.AutoSize = True
		Me.lblNombreMascota.Location = New System.Drawing.Point(119, 161)
		Me.lblNombreMascota.Name = "lblNombreMascota"
		Me.lblNombreMascota.Size = New System.Drawing.Size(39, 13)
		Me.lblNombreMascota.TabIndex = 37
		Me.lblNombreMascota.Text = "Label3"
		'
		'Desparacitación
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(757, 474)
		Me.Controls.Add(Me.lblNombreMascota)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.cmbServicios)
		Me.Controls.Add(Me.txtObservaciones)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.cmbDesparacitacion)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Desparacitación"
		Me.Text = "Desparacitación"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnMenuPrincipal As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents btnGuardar As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents cmbDesparacitacion As ComboBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtObservaciones As TextBox
	Friend WithEvents cmbServicios As ComboBox
	Friend WithEvents Label12 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents lblNombreMascota As Label
End Class
