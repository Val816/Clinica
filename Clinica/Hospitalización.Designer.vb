<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hospitalización
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hospitalización))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtCosto = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.cmbTipo = New System.Windows.Forms.ComboBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
		Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
		Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
		Me.dtpFechaEntrada = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.txtMedicina = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TxtObservaciones = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.PictureBox2)
		Me.Panel1.Controls.Add(Me.Label9)
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-5, -5)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(855, 78)
		Me.Panel1.TabIndex = 9
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(16, 2)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(60, 52)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 86
		Me.PictureBox2.TabStop = False
		'
		'Label9
		'
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.Black
		Me.Label9.Location = New System.Drawing.Point(7, 56)
		Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(83, 18)
		Me.Label9.TabIndex = 85
		Me.Label9.Text = "VETCARE"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.SkyBlue
		Me.btnMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(422, 16)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(108, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(174, 25)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(231, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Hospitalización"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Location = New System.Drawing.Point(-5, 485)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(858, 37)
		Me.Panel2.TabIndex = 10
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.SkyBlue
		Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Location = New System.Drawing.Point(199, 437)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(108, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.Color.White
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(58, 441)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(123, 21)
		Me.ComboBoxServicios.TabIndex = 54
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.White
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(17, 352)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(36, 25)
		Me.Label6.TabIndex = 55
		Me.Label6.Text = "Tipo:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.White
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(5, 397)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(48, 24)
		Me.Label12.TabIndex = 70
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtCosto
		'
		Me.txtCosto.BackColor = System.Drawing.Color.White
		Me.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtCosto.Location = New System.Drawing.Point(58, 397)
		Me.txtCosto.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCosto.Multiline = True
		Me.txtCosto.Name = "txtCosto"
		Me.txtCosto.Size = New System.Drawing.Size(73, 24)
		Me.txtCosto.TabIndex = 71
		Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(321, 355)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(204, 114)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 72
		Me.PictureBox1.TabStop = False
		'
		'cmbTipo
		'
		Me.cmbTipo.FormattingEnabled = True
		Me.cmbTipo.Location = New System.Drawing.Point(58, 355)
		Me.cmbTipo.Name = "cmbTipo"
		Me.cmbTipo.Size = New System.Drawing.Size(164, 21)
		Me.cmbTipo.TabIndex = 75
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.dtpHoraEntrada)
		Me.Panel3.Controls.Add(Me.dtpHoraSalida)
		Me.Panel3.Controls.Add(Me.dtpFechaSalida)
		Me.Panel3.Controls.Add(Me.dtpFechaEntrada)
		Me.Panel3.Controls.Add(Me.Label5)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(12, 89)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(508, 109)
		Me.Panel3.TabIndex = 76
		'
		'dtpHoraEntrada
		'
		Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtpHoraEntrada.Location = New System.Drawing.Point(383, 23)
		Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
		Me.dtpHoraEntrada.Size = New System.Drawing.Size(84, 20)
		Me.dtpHoraEntrada.TabIndex = 84
		'
		'dtpHoraSalida
		'
		Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtpHoraSalida.Location = New System.Drawing.Point(383, 65)
		Me.dtpHoraSalida.Name = "dtpHoraSalida"
		Me.dtpHoraSalida.Size = New System.Drawing.Size(84, 20)
		Me.dtpHoraSalida.TabIndex = 83
		'
		'dtpFechaSalida
		'
		Me.dtpFechaSalida.Location = New System.Drawing.Point(115, 65)
		Me.dtpFechaSalida.Name = "dtpFechaSalida"
		Me.dtpFechaSalida.Size = New System.Drawing.Size(144, 20)
		Me.dtpFechaSalida.TabIndex = 82
		'
		'dtpFechaEntrada
		'
		Me.dtpFechaEntrada.Location = New System.Drawing.Point(115, 20)
		Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
		Me.dtpFechaEntrada.Size = New System.Drawing.Size(144, 20)
		Me.dtpFechaEntrada.TabIndex = 81
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(286, 64)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(101, 25)
		Me.Label5.TabIndex = 79
		Me.Label5.Text = "Hora de salida:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(275, 17)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(112, 26)
		Me.Label4.TabIndex = 78
		Me.Label4.Text = "Hora de entrada:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(2, 64)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(116, 27)
		Me.Label3.TabIndex = 76
		Me.Label3.Text = "Fecha de salida:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(2, 17)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(116, 26)
		Me.Label2.TabIndex = 75
		Me.Label2.Text = "Fecha de entrada:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel4.Controls.Add(Me.txtMedicina)
		Me.Panel4.Controls.Add(Me.Label8)
		Me.Panel4.Controls.Add(Me.Label7)
		Me.Panel4.Controls.Add(Me.TxtObservaciones)
		Me.Panel4.Location = New System.Drawing.Point(23, 222)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(487, 118)
		Me.Panel4.TabIndex = 77
		'
		'txtMedicina
		'
		Me.txtMedicina.BackColor = System.Drawing.Color.White
		Me.txtMedicina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtMedicina.Location = New System.Drawing.Point(251, 29)
		Me.txtMedicina.Margin = New System.Windows.Forms.Padding(2)
		Me.txtMedicina.Multiline = True
		Me.txtMedicina.Name = "txtMedicina"
		Me.txtMedicina.Size = New System.Drawing.Size(220, 77)
		Me.txtMedicina.TabIndex = 73
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(5, 7)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(107, 19)
		Me.Label8.TabIndex = 72
		Me.Label8.Text = "Observaciones:"
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(251, 3)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(78, 23)
		Me.Label7.TabIndex = 70
		Me.Label7.Text = "Medicina:"
		'
		'TxtObservaciones
		'
		Me.TxtObservaciones.BackColor = System.Drawing.Color.White
		Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtObservaciones.Location = New System.Drawing.Point(8, 29)
		Me.TxtObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.TxtObservaciones.Multiline = True
		Me.TxtObservaciones.Name = "TxtObservaciones"
		Me.TxtObservaciones.Size = New System.Drawing.Size(218, 77)
		Me.TxtObservaciones.TabIndex = 71
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.White
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(135, 397)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(48, 24)
		Me.Label10.TabIndex = 78
		Me.Label10.Text = "pesos."
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Hospitalización
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(536, 519)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.cmbTipo)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.txtCosto)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Hospitalización"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Hospitalización"
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnMenuPrincipal As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents btnGuardar As Button
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents txtCosto As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents cmbTipo As ComboBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents dtpFechaSalida As DateTimePicker
	Friend WithEvents dtpFechaEntrada As DateTimePicker
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Panel4 As Panel
	Friend WithEvents txtMedicina As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents TxtObservaciones As TextBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Label9 As Label

	Private Sub Hospitalización_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Friend WithEvents dtpHoraEntrada As DateTimePicker
	Friend WithEvents dtpHoraSalida As DateTimePicker
	Friend WithEvents Label10 As Label
End Class
