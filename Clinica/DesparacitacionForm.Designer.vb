<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DesparacitacionForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesparacitacionForm))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtObservaciones = New System.Windows.Forms.TextBox()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtCosto = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cbDesparacitacion = New System.Windows.Forms.ComboBox()
		Me.dataGridDesparacitaciones = New System.Windows.Forms.DataGridView()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		CType(Me.dataGridDesparacitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.PictureBox2)
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(842, 78)
		Me.Panel1.TabIndex = 5
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(11, 2)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(60, 52)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 86
		Me.PictureBox2.TabStop = False
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.Black
		Me.Label6.Location = New System.Drawing.Point(2, 56)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(83, 18)
		Me.Label6.TabIndex = 85
		Me.Label6.Text = "VETCARE"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(464, 11)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(119, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(176, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(231, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Desparacitación"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(-36, 411)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(839, 126)
		Me.Panel2.TabIndex = 6
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.LightBlue
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Location = New System.Drawing.Point(538, 17)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(82, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(8, 68)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(110, 26)
		Me.Label10.TabIndex = 27
		Me.Label10.Text = "Observaciones:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtObservaciones
		'
		Me.txtObservaciones.BackColor = System.Drawing.Color.White
		Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtObservaciones.Location = New System.Drawing.Point(11, 96)
		Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.txtObservaciones.Multiline = True
		Me.txtObservaciones.Name = "txtObservaciones"
		Me.txtObservaciones.Size = New System.Drawing.Size(160, 60)
		Me.txtObservaciones.TabIndex = 28
		Me.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.Color.White
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(406, 264)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxServicios.TabIndex = 32
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(327, 90)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(226, 154)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 35
		Me.PictureBox1.TabStop = False
		'
		'txtCosto
		'
		Me.txtCosto.Location = New System.Drawing.Point(59, 172)
		Me.txtCosto.Name = "txtCosto"
		Me.txtCosto.Size = New System.Drawing.Size(69, 20)
		Me.txtCosto.TabIndex = 36
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(14, 179)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(39, 13)
		Me.Label2.TabIndex = 37
		Me.Label2.Text = "Costo"
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Controls.Add(Me.Label10)
		Me.Panel3.Controls.Add(Me.txtObservaciones)
		Me.Panel3.Controls.Add(Me.txtCosto)
		Me.Panel3.Controls.Add(Me.cbDesparacitacion)
		Me.Panel3.Location = New System.Drawing.Point(55, 88)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(193, 202)
		Me.Panel3.TabIndex = 38
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(134, 179)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(44, 13)
		Me.Label4.TabIndex = 38
		Me.Label4.Text = "pesos."
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(14, 6)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(169, 29)
		Me.Label3.TabIndex = 29
		Me.Label3.Text = "Tipo de Desparacitación:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'cbDesparacitacion
		'
		Me.cbDesparacitacion.BackColor = System.Drawing.Color.White
		Me.cbDesparacitacion.ForeColor = System.Drawing.Color.Black
		Me.cbDesparacitacion.FormattingEnabled = True
		Me.cbDesparacitacion.Items.AddRange(New Object() {"Chico", "Mediano", "Grande"})
		Me.cbDesparacitacion.Location = New System.Drawing.Point(24, 34)
		Me.cbDesparacitacion.Margin = New System.Windows.Forms.Padding(2)
		Me.cbDesparacitacion.Name = "cbDesparacitacion"
		Me.cbDesparacitacion.Size = New System.Drawing.Size(147, 21)
		Me.cbDesparacitacion.TabIndex = 26
		Me.cbDesparacitacion.Text = "Desparacitación"
		'
		'dataGridDesparacitaciones
		'
		Me.dataGridDesparacitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridDesparacitaciones.Location = New System.Drawing.Point(19, 301)
		Me.dataGridDesparacitaciones.Name = "dataGridDesparacitaciones"
		Me.dataGridDesparacitaciones.Size = New System.Drawing.Size(555, 105)
		Me.dataGridDesparacitaciones.TabIndex = 39
		'
		'DesparacitacionForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(595, 464)
		Me.Controls.Add(Me.dataGridDesparacitaciones)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Panel3)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "DesparacitacionForm"
		Me.Text = "Desparacitación"
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.dataGridDesparacitaciones, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnMenuPrincipal As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents btnGuardar As Button
	Friend WithEvents Label10 As Label
	Friend WithEvents txtObservaciones As TextBox
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents txtCosto As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents dataGridDesparacitaciones As DataGridView
	Friend WithEvents cbDesparacitacion As ComboBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Label6 As Label
End Class
