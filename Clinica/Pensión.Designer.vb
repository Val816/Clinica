<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pensión
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pensión))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtObservaciones = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtCostoDiario = New System.Windows.Forms.TextBox()
		Me.txtCostoTotal = New System.Windows.Forms.TextBox()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.dtpFechaEntrada = New System.Windows.Forms.DateTimePicker()
		Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
		Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.dgvPension = New System.Windows.Forms.DataGridView()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		CType(Me.dgvPension, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.PictureBox2)
		Me.Panel1.Controls.Add(Me.Label14)
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, -1)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(862, 90)
		Me.Panel1.TabIndex = 12
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(10, 2)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(60, 52)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 92
		Me.PictureBox2.TabStop = False
		'
		'Label14
		'
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.ForeColor = System.Drawing.Color.Black
		Me.Label14.Location = New System.Drawing.Point(5, 54)
		Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(83, 18)
		Me.Label14.TabIndex = 91
		Me.Label14.Text = "VETCARE"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(623, 29)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(112, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(290, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(143, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Pensión"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Location = New System.Drawing.Point(-4, 447)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(867, 79)
		Me.Panel2.TabIndex = 13
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.LightBlue
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Location = New System.Drawing.Point(415, 367)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(112, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(2, 8)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(111, 26)
		Me.Label2.TabIndex = 58
		Me.Label2.Text = "Fecha de entrada:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(8, 45)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(105, 26)
		Me.Label3.TabIndex = 59
		Me.Label3.Text = "Fecha de salida:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(219, 346)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(105, 19)
		Me.Label8.TabIndex = 70
		Me.Label8.Text = "Observaciones:"
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(266, 10)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(110, 26)
		Me.Label4.TabIndex = 71
		Me.Label4.Text = "Hora de entrada:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(279, 51)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(93, 26)
		Me.Label5.TabIndex = 72
		Me.Label5.Text = "Hora de salida:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtObservaciones
		'
		Me.txtObservaciones.BackColor = System.Drawing.Color.White
		Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtObservaciones.Location = New System.Drawing.Point(222, 367)
		Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.txtObservaciones.Multiline = True
		Me.txtObservaciones.Name = "txtObservaciones"
		Me.txtObservaciones.Size = New System.Drawing.Size(189, 62)
		Me.txtObservaciones.TabIndex = 77
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(14, 11)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(85, 24)
		Me.Label12.TabIndex = 78
		Me.Label12.Text = "Costo Diario:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(17, 52)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(79, 24)
		Me.Label6.TabIndex = 79
		Me.Label6.Text = "Costo Total:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtCostoDiario
		'
		Me.txtCostoDiario.BackColor = System.Drawing.Color.White
		Me.txtCostoDiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtCostoDiario.Location = New System.Drawing.Point(95, 13)
		Me.txtCostoDiario.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCostoDiario.Multiline = True
		Me.txtCostoDiario.Name = "txtCostoDiario"
		Me.txtCostoDiario.Size = New System.Drawing.Size(73, 24)
		Me.txtCostoDiario.TabIndex = 80
		Me.txtCostoDiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtCostoTotal
		'
		Me.txtCostoTotal.BackColor = System.Drawing.Color.White
		Me.txtCostoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtCostoTotal.Location = New System.Drawing.Point(96, 52)
		Me.txtCostoTotal.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCostoTotal.Multiline = True
		Me.txtCostoTotal.Name = "txtCostoTotal"
		Me.txtCostoTotal.Size = New System.Drawing.Size(73, 24)
		Me.txtCostoTotal.TabIndex = 81
		Me.txtCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.Color.White
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(593, 413)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxServicios.TabIndex = 82
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(535, 249)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(205, 130)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 83
		Me.PictureBox1.TabStop = False
		'
		'dtpFechaEntrada
		'
		Me.dtpFechaEntrada.Location = New System.Drawing.Point(115, 14)
		Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
		Me.dtpFechaEntrada.Size = New System.Drawing.Size(142, 20)
		Me.dtpFechaEntrada.TabIndex = 84
		'
		'dtpFechaSalida
		'
		Me.dtpFechaSalida.Location = New System.Drawing.Point(115, 51)
		Me.dtpFechaSalida.Name = "dtpFechaSalida"
		Me.dtpFechaSalida.Size = New System.Drawing.Size(142, 20)
		Me.dtpFechaSalida.TabIndex = 85
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.dtpHoraSalida)
		Me.Panel3.Controls.Add(Me.dtpHoraEntrada)
		Me.Panel3.Controls.Add(Me.dtpFechaSalida)
		Me.Panel3.Controls.Add(Me.dtpFechaEntrada)
		Me.Panel3.Controls.Add(Me.Label5)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(16, 250)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(514, 88)
		Me.Panel3.TabIndex = 88
		'
		'dtpHoraSalida
		'
		Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtpHoraSalida.Location = New System.Drawing.Point(381, 52)
		Me.dtpHoraSalida.Name = "dtpHoraSalida"
		Me.dtpHoraSalida.Size = New System.Drawing.Size(103, 20)
		Me.dtpHoraSalida.TabIndex = 93
		'
		'dtpHoraEntrada
		'
		Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtpHoraEntrada.Location = New System.Drawing.Point(381, 16)
		Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
		Me.dtpHoraEntrada.Size = New System.Drawing.Size(104, 20)
		Me.dtpHoraEntrada.TabIndex = 92
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel4.Controls.Add(Me.txtCostoDiario)
		Me.Panel4.Controls.Add(Me.Label6)
		Me.Panel4.Controls.Add(Me.Label12)
		Me.Panel4.Controls.Add(Me.txtCostoTotal)
		Me.Panel4.Location = New System.Drawing.Point(16, 346)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(183, 88)
		Me.Panel4.TabIndex = 89
		'
		'dgvPension
		'
		Me.dgvPension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvPension.Location = New System.Drawing.Point(16, 94)
		Me.dgvPension.Name = "dgvPension"
		Me.dgvPension.Size = New System.Drawing.Size(720, 150)
		Me.dgvPension.TabIndex = 90
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.LightBlue
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBuscar.Location = New System.Drawing.Point(415, 406)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(112, 23)
		Me.btnBuscar.TabIndex = 91
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'Pensión
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(748, 504)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.dgvPension)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.txtObservaciones)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Pensión"
		Me.Text = "Pensión"
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		CType(Me.dgvPension, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents txtObservaciones As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtCostoDiario As TextBox
	Friend WithEvents txtCostoTotal As TextBox
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents dtpFechaEntrada As DateTimePicker
	Friend WithEvents dtpFechaSalida As DateTimePicker
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents dtpHoraEntrada As DateTimePicker
	Friend WithEvents dtpHoraSalida As DateTimePicker
	Friend WithEvents dgvPension As DataGridView
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Label14 As Label
	Friend WithEvents btnBuscar As Button
End Class
