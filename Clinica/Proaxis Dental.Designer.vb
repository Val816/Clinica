<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proaxis_Dental
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proaxis_Dental))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.ComboBoxTalla = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.TextBoxCosto = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePickerHoraEntrada = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePickerHoraSalida = New System.Windows.Forms.DateTimePicker()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.TextBoxObservaciones = New System.Windows.Forms.TextBox()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-3, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(862, 90)
		Me.Panel1.TabIndex = 11
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(463, 29)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(104, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(174, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(244, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Profilaxis Dental"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(-3, 413)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(862, 81)
		Me.Panel2.TabIndex = 12
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.LightBlue
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Location = New System.Drawing.Point(474, 22)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'ComboBoxTalla
		'
		Me.ComboBoxTalla.BackColor = System.Drawing.Color.White
		Me.ComboBoxTalla.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxTalla.FormattingEnabled = True
		Me.ComboBoxTalla.Items.AddRange(New Object() {"Pequeña", "Mediana", "Grande"})
		Me.ComboBoxTalla.Location = New System.Drawing.Point(398, 125)
		Me.ComboBoxTalla.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxTalla.Name = "ComboBoxTalla"
		Me.ComboBoxTalla.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxTalla.TabIndex = 63
		Me.ComboBoxTalla.Text = "Talla"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(6, 5)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 25)
		Me.Label2.TabIndex = 64
		Me.Label2.Text = "Fecha:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(3, 50)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(105, 20)
		Me.Label4.TabIndex = 66
		Me.Label4.Text = "Hora de entrada:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(9, 80)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(99, 26)
		Me.Label3.TabIndex = 68
		Me.Label3.Text = "Hora de salida:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(20, 252)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(101, 24)
		Me.Label8.TabIndex = 70
		Me.Label8.Text = "Observaciones:"
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.Color.White
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(398, 173)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxServicios.TabIndex = 72
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(163, 365)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(62, 24)
		Me.Label12.TabIndex = 73
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxCosto
		'
		Me.TextBoxCosto.BackColor = System.Drawing.Color.White
		Me.TextBoxCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxCosto.ForeColor = System.Drawing.Color.Black
		Me.TextBoxCosto.Location = New System.Drawing.Point(215, 365)
		Me.TextBoxCosto.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxCosto.Multiline = True
		Me.TextBoxCosto.Name = "TextBoxCosto"
		Me.TextBoxCosto.Size = New System.Drawing.Size(73, 24)
		Me.TextBoxCosto.TabIndex = 74
		Me.TextBoxCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(318, 242)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(227, 136)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 75
		Me.PictureBox1.TabStop = False
		'
		'DateTimePickerFecha
		'
		Me.DateTimePickerFecha.Location = New System.Drawing.Point(65, 8)
		Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
		Me.DateTimePickerFecha.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerFecha.TabIndex = 76
		'
		'DateTimePickerHoraEntrada
		'
		Me.DateTimePickerHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.DateTimePickerHoraEntrada.Location = New System.Drawing.Point(113, 50)
		Me.DateTimePickerHoraEntrada.Name = "DateTimePickerHoraEntrada"
		Me.DateTimePickerHoraEntrada.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerHoraEntrada.TabIndex = 77
		'
		'DateTimePickerHoraSalida
		'
		Me.DateTimePickerHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.DateTimePickerHoraSalida.Location = New System.Drawing.Point(113, 86)
		Me.DateTimePickerHoraSalida.Name = "DateTimePickerHoraSalida"
		Me.DateTimePickerHoraSalida.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerHoraSalida.TabIndex = 78
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.DateTimePickerHoraSalida)
		Me.Panel3.Controls.Add(Me.DateTimePickerHoraEntrada)
		Me.Panel3.Controls.Add(Me.DateTimePickerFecha)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(23, 104)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(329, 121)
		Me.Panel3.TabIndex = 79
		'
		'TextBoxObservaciones
		'
		Me.TextBoxObservaciones.AcceptsTab = True
		Me.TextBoxObservaciones.AllowDrop = True
		Me.TextBoxObservaciones.BackColor = System.Drawing.Color.Silver
		Me.TextBoxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxObservaciones.Location = New System.Drawing.Point(126, 250)
		Me.TextBoxObservaciones.Multiline = True
		Me.TextBoxObservaciones.Name = "TextBoxObservaciones"
		Me.TextBoxObservaciones.Size = New System.Drawing.Size(176, 90)
		Me.TextBoxObservaciones.TabIndex = 80
		Me.TextBoxObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Proaxis_Dental
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(575, 479)
		Me.Controls.Add(Me.TextBoxObservaciones)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.TextBoxCosto)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.ComboBoxTalla)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Proaxis_Dental"
		Me.Text = "Proaxis Dental"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
	Friend WithEvents ComboBoxTalla As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents Label12 As Label
	Friend WithEvents TextBoxCosto As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents DateTimePickerFecha As DateTimePicker
	Friend WithEvents DateTimePickerHoraEntrada As DateTimePicker
	Friend WithEvents DateTimePickerHoraSalida As DateTimePicker
	Friend WithEvents Panel3 As Panel
	Friend WithEvents TextBoxObservaciones As TextBox
End Class
