<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consulta_Médica
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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TextBoxTemperatura = New System.Windows.Forms.TextBox()
		Me.TextBoxTLLC = New System.Windows.Forms.TextBox()
		Me.TextBoxPulso = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.TextBoxEnfermedad = New System.Windows.Forms.TextBox()
		Me.TextBoxFrecRespiratoria = New System.Windows.Forms.TextBox()
		Me.TextBoxFrecCardiaca = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.ComboBoxDesparacitacion = New System.Windows.Forms.ComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.TextBoxObservaciones = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.TextBoxReceta = New System.Windows.Forms.TextBox()
		Me.ComboBoxVacunas = New System.Windows.Forms.ComboBox()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.ComboBoxEstadoReprod = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, -1)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(842, 115)
		Me.Panel1.TabIndex = 4
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(444, 44)
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
		Me.Label1.Location = New System.Drawing.Point(119, 44)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(337, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Consulta Médica"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(1, 403)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(839, 87)
		Me.Panel2.TabIndex = 5
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Location = New System.Drawing.Point(444, 26)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Silver
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label4.Location = New System.Drawing.Point(30, 250)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(76, 34)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Estado Reproductivo:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Silver
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.Location = New System.Drawing.Point(30, 210)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(76, 24)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "TLLC:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Silver
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.Location = New System.Drawing.Point(30, 175)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(76, 24)
		Me.Label3.TabIndex = 12
		Me.Label3.Text = "Pulso:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Silver
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label5.Location = New System.Drawing.Point(30, 134)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(76, 24)
		Me.Label5.TabIndex = 13
		Me.Label5.Text = "Temperatura:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxTemperatura
		'
		Me.TextBoxTemperatura.BackColor = System.Drawing.Color.Silver
		Me.TextBoxTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxTemperatura.Location = New System.Drawing.Point(127, 134)
		Me.TextBoxTemperatura.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxTemperatura.Multiline = True
		Me.TextBoxTemperatura.Name = "TextBoxTemperatura"
		Me.TextBoxTemperatura.Size = New System.Drawing.Size(130, 24)
		Me.TextBoxTemperatura.TabIndex = 14
		Me.TextBoxTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBoxTLLC
		'
		Me.TextBoxTLLC.BackColor = System.Drawing.Color.Silver
		Me.TextBoxTLLC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxTLLC.Location = New System.Drawing.Point(127, 210)
		Me.TextBoxTLLC.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxTLLC.Multiline = True
		Me.TextBoxTLLC.Name = "TextBoxTLLC"
		Me.TextBoxTLLC.Size = New System.Drawing.Size(130, 24)
		Me.TextBoxTLLC.TabIndex = 16
		Me.TextBoxTLLC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBoxPulso
		'
		Me.TextBoxPulso.BackColor = System.Drawing.Color.Silver
		Me.TextBoxPulso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxPulso.Location = New System.Drawing.Point(127, 175)
		Me.TextBoxPulso.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxPulso.Multiline = True
		Me.TextBoxPulso.Name = "TextBoxPulso"
		Me.TextBoxPulso.Size = New System.Drawing.Size(130, 24)
		Me.TextBoxPulso.TabIndex = 17
		Me.TextBoxPulso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Silver
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.Location = New System.Drawing.Point(286, 134)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(83, 24)
		Me.Label6.TabIndex = 18
		Me.Label6.Text = "Enfermedad:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Silver
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label7.Location = New System.Drawing.Point(30, 348)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(76, 32)
		Me.Label7.TabIndex = 19
		Me.Label7.Text = "Frecuencia Respiratoria:"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Silver
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label8.Location = New System.Drawing.Point(30, 300)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(76, 36)
		Me.Label8.TabIndex = 20
		Me.Label8.Text = "Frecuencia Cardiaca:"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxEnfermedad
		'
		Me.TextBoxEnfermedad.BackColor = System.Drawing.Color.Silver
		Me.TextBoxEnfermedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxEnfermedad.Location = New System.Drawing.Point(376, 134)
		Me.TextBoxEnfermedad.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxEnfermedad.Multiline = True
		Me.TextBoxEnfermedad.Name = "TextBoxEnfermedad"
		Me.TextBoxEnfermedad.Size = New System.Drawing.Size(130, 24)
		Me.TextBoxEnfermedad.TabIndex = 21
		Me.TextBoxEnfermedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBoxFrecRespiratoria
		'
		Me.TextBoxFrecRespiratoria.BackColor = System.Drawing.Color.Silver
		Me.TextBoxFrecRespiratoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxFrecRespiratoria.Location = New System.Drawing.Point(127, 348)
		Me.TextBoxFrecRespiratoria.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxFrecRespiratoria.Multiline = True
		Me.TextBoxFrecRespiratoria.Name = "TextBoxFrecRespiratoria"
		Me.TextBoxFrecRespiratoria.Size = New System.Drawing.Size(130, 32)
		Me.TextBoxFrecRespiratoria.TabIndex = 22
		Me.TextBoxFrecRespiratoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBoxFrecCardiaca
		'
		Me.TextBoxFrecCardiaca.BackColor = System.Drawing.Color.Silver
		Me.TextBoxFrecCardiaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxFrecCardiaca.Location = New System.Drawing.Point(127, 300)
		Me.TextBoxFrecCardiaca.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxFrecCardiaca.Multiline = True
		Me.TextBoxFrecCardiaca.Name = "TextBoxFrecCardiaca"
		Me.TextBoxFrecCardiaca.Size = New System.Drawing.Size(130, 36)
		Me.TextBoxFrecCardiaca.TabIndex = 23
		Me.TextBoxFrecCardiaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(354, 300)
		Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(152, 13)
		Me.Label9.TabIndex = 24
		Me.Label9.Text = "¿Cuenta con desparacitación?"
		'
		'ComboBoxDesparacitacion
		'
		Me.ComboBoxDesparacitacion.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ComboBoxDesparacitacion.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxDesparacitacion.FormattingEnabled = True
		Me.ComboBoxDesparacitacion.Items.AddRange(New Object() {"Si", "No"})
		Me.ComboBoxDesparacitacion.Location = New System.Drawing.Point(359, 320)
		Me.ComboBoxDesparacitacion.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxDesparacitacion.Name = "ComboBoxDesparacitacion"
		Me.ComboBoxDesparacitacion.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxDesparacitacion.TabIndex = 25
		Me.ComboBoxDesparacitacion.Text = "Desparacitación"
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Silver
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label10.Location = New System.Drawing.Point(286, 175)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(83, 24)
		Me.Label10.TabIndex = 26
		Me.Label10.Text = "Observaciones:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxObservaciones
		'
		Me.TextBoxObservaciones.BackColor = System.Drawing.Color.Silver
		Me.TextBoxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxObservaciones.Location = New System.Drawing.Point(376, 175)
		Me.TextBoxObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxObservaciones.Multiline = True
		Me.TextBoxObservaciones.Name = "TextBoxObservaciones"
		Me.TextBoxObservaciones.Size = New System.Drawing.Size(130, 24)
		Me.TextBoxObservaciones.TabIndex = 27
		Me.TextBoxObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label11
		'
		Me.Label11.BackColor = System.Drawing.Color.Silver
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label11.Location = New System.Drawing.Point(286, 214)
		Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(83, 24)
		Me.Label11.TabIndex = 28
		Me.Label11.Text = "Receta:"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxReceta
		'
		Me.TextBoxReceta.BackColor = System.Drawing.Color.Silver
		Me.TextBoxReceta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxReceta.Location = New System.Drawing.Point(376, 214)
		Me.TextBoxReceta.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxReceta.Multiline = True
		Me.TextBoxReceta.Name = "TextBoxReceta"
		Me.TextBoxReceta.Size = New System.Drawing.Size(130, 24)
		Me.TextBoxReceta.TabIndex = 29
		Me.TextBoxReceta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ComboBoxVacunas
		'
		Me.ComboBoxVacunas.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ComboBoxVacunas.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxVacunas.FormattingEnabled = True
		Me.ComboBoxVacunas.Items.AddRange(New Object() {"Puppy", "Quintuple", "Sextuple", "Rabia", "Triple felina", "Bordetella", "Giarda", "Ninguna"})
		Me.ComboBoxVacunas.Location = New System.Drawing.Point(359, 269)
		Me.ComboBoxVacunas.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxVacunas.Name = "ComboBoxVacunas"
		Me.ComboBoxVacunas.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxVacunas.TabIndex = 30
		Me.ComboBoxVacunas.Text = "Esquema de Vacunación"
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(357, 366)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxServicios.TabIndex = 31
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'ComboBoxEstadoReprod
		'
		Me.ComboBoxEstadoReprod.FormattingEnabled = True
		Me.ComboBoxEstadoReprod.Location = New System.Drawing.Point(127, 263)
		Me.ComboBoxEstadoReprod.Name = "ComboBoxEstadoReprod"
		Me.ComboBoxEstadoReprod.Size = New System.Drawing.Size(130, 21)
		Me.ComboBoxEstadoReprod.TabIndex = 34
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(388, 249)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(118, 13)
		Me.Label12.TabIndex = 35
		Me.Label12.Text = "¿Cuenta con vacunas?"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(411, 351)
		Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(95, 13)
		Me.Label13.TabIndex = 36
		Me.Label13.Text = "Agrega un servicio"
		'
		'Consulta_Médica
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(549, 477)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.ComboBoxEstadoReprod)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.ComboBoxVacunas)
		Me.Controls.Add(Me.TextBoxReceta)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.TextBoxObservaciones)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.ComboBoxDesparacitacion)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.TextBoxFrecCardiaca)
		Me.Controls.Add(Me.TextBoxFrecRespiratoria)
		Me.Controls.Add(Me.TextBoxEnfermedad)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.TextBoxPulso)
		Me.Controls.Add(Me.TextBoxTLLC)
		Me.Controls.Add(Me.TextBoxTemperatura)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Consulta_Médica"
		Me.Text = "Consulta_Médica"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnMenuPrincipal As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents btnGuardar As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents TextBoxTemperatura As TextBox
	Friend WithEvents TextBoxTLLC As TextBox
	Friend WithEvents TextBoxPulso As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents TextBoxEnfermedad As TextBox
	Friend WithEvents TextBoxFrecRespiratoria As TextBox
	Friend WithEvents TextBoxFrecCardiaca As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents ComboBoxDesparacitacion As ComboBox
	Friend WithEvents Label10 As Label
	Friend WithEvents TextBoxObservaciones As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents TextBoxReceta As TextBox
	Friend WithEvents ComboBoxVacunas As ComboBox
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents ComboBoxEstadoReprod As ComboBox
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
End Class
