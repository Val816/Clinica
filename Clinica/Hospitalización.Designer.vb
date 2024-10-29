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
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.ComboBoxServicio = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.cmbTalla = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.TextBox10 = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.cmbTipoHospitalizacion = New System.Windows.Forms.ComboBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
		Me.dtpFechaEntrada = New System.Windows.Forms.DateTimePicker()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.TxtMedicinas = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TxtObservaciones = New System.Windows.Forms.TextBox()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-5, -5)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(855, 78)
		Me.Panel1.TabIndex = 9
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(411, 16)
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
		Me.Label1.Location = New System.Drawing.Point(154, 32)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(337, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Hospitalización"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel2.Location = New System.Drawing.Point(-5, 485)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(858, 37)
		Me.Panel2.TabIndex = 10
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Location = New System.Drawing.Point(206, 441)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'ComboBoxServicio
		'
		Me.ComboBoxServicio.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBoxServicio.ForeColor = System.Drawing.Color.White
		Me.ComboBoxServicio.FormattingEnabled = True
		Me.ComboBoxServicio.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicio.Location = New System.Drawing.Point(176, 398)
		Me.ComboBoxServicio.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicio.Name = "ComboBoxServicio"
		Me.ComboBoxServicio.Size = New System.Drawing.Size(123, 21)
		Me.ComboBoxServicio.TabIndex = 54
		Me.ComboBoxServicio.Text = "Agregar Servicio"
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Silver
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Location = New System.Drawing.Point(20, 352)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(33, 25)
		Me.Label6.TabIndex = 55
		Me.Label6.Text = "Tipo:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'cmbTalla
		'
		Me.cmbTalla.BackColor = System.Drawing.SystemColors.InfoText
		Me.cmbTalla.ForeColor = System.Drawing.Color.White
		Me.cmbTalla.FormattingEnabled = True
		Me.cmbTalla.Items.AddRange(New Object() {"Pequeña", "Mediana", "Grande"})
		Me.cmbTalla.Location = New System.Drawing.Point(20, 398)
		Me.cmbTalla.Margin = New System.Windows.Forms.Padding(2)
		Me.cmbTalla.Name = "cmbTalla"
		Me.cmbTalla.Size = New System.Drawing.Size(118, 21)
		Me.cmbTalla.TabIndex = 61
		Me.cmbTalla.Text = "Talla"
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Silver
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Location = New System.Drawing.Point(20, 438)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(62, 24)
		Me.Label12.TabIndex = 70
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBox10
		'
		Me.TextBox10.BackColor = System.Drawing.Color.Silver
		Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox10.Location = New System.Drawing.Point(86, 438)
		Me.TextBox10.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox10.Multiline = True
		Me.TextBox10.Name = "TextBox10"
		Me.TextBox10.Size = New System.Drawing.Size(73, 24)
		Me.TextBox10.TabIndex = 71
		Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
		'cmbTipoHospitalizacion
		'
		Me.cmbTipoHospitalizacion.FormattingEnabled = True
		Me.cmbTipoHospitalizacion.Location = New System.Drawing.Point(58, 356)
		Me.cmbTipoHospitalizacion.Name = "cmbTipoHospitalizacion"
		Me.cmbTipoHospitalizacion.Size = New System.Drawing.Size(131, 21)
		Me.cmbTipoHospitalizacion.TabIndex = 75
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.dtpFechaSalida)
		Me.Panel3.Controls.Add(Me.dtpFechaEntrada)
		Me.Panel3.Controls.Add(Me.TextBox4)
		Me.Panel3.Controls.Add(Me.Label5)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.TextBox2)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(12, 89)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(508, 109)
		Me.Panel3.TabIndex = 76
		'
		'dtpFechaSalida
		'
		Me.dtpFechaSalida.Location = New System.Drawing.Point(115, 71)
		Me.dtpFechaSalida.Name = "dtpFechaSalida"
		Me.dtpFechaSalida.Size = New System.Drawing.Size(144, 20)
		Me.dtpFechaSalida.TabIndex = 82
		'
		'dtpFechaEntrada
		'
		Me.dtpFechaEntrada.Location = New System.Drawing.Point(115, 23)
		Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
		Me.dtpFechaEntrada.Size = New System.Drawing.Size(144, 20)
		Me.dtpFechaEntrada.TabIndex = 81
		'
		'TextBox4
		'
		Me.TextBox4.BackColor = System.Drawing.Color.Silver
		Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox4.Location = New System.Drawing.Point(392, 68)
		Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox4.Multiline = True
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(106, 23)
		Me.TextBox4.TabIndex = 80
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Silver
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label5.Location = New System.Drawing.Point(294, 64)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(85, 25)
		Me.Label5.TabIndex = 79
		Me.Label5.Text = "Hora de salida:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Silver
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Location = New System.Drawing.Point(283, 17)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(96, 26)
		Me.Label4.TabIndex = 78
		Me.Label4.Text = "Hora de entrada:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.Silver
		Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox2.Location = New System.Drawing.Point(392, 20)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(106, 23)
		Me.TextBox2.TabIndex = 77
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Silver
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Location = New System.Drawing.Point(10, 64)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(100, 27)
		Me.Label3.TabIndex = 76
		Me.Label3.Text = "Fecha de salida:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Silver
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Location = New System.Drawing.Point(10, 17)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(100, 26)
		Me.Label2.TabIndex = 75
		Me.Label2.Text = "Fecha de entrada:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Panel4
		'
		Me.Panel4.Controls.Add(Me.TxtMedicinas)
		Me.Panel4.Controls.Add(Me.Label8)
		Me.Panel4.Controls.Add(Me.Label7)
		Me.Panel4.Controls.Add(Me.TxtObservaciones)
		Me.Panel4.Location = New System.Drawing.Point(23, 222)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(487, 118)
		Me.Panel4.TabIndex = 77
		'
		'TxtMedicinas
		'
		Me.TxtMedicinas.BackColor = System.Drawing.Color.Silver
		Me.TxtMedicinas.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtMedicinas.Location = New System.Drawing.Point(251, 29)
		Me.TxtMedicinas.Margin = New System.Windows.Forms.Padding(2)
		Me.TxtMedicinas.Multiline = True
		Me.TxtMedicinas.Name = "TxtMedicinas"
		Me.TxtMedicinas.Size = New System.Drawing.Size(220, 77)
		Me.TxtMedicinas.TabIndex = 73
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Silver
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label8.Location = New System.Drawing.Point(5, 7)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(91, 19)
		Me.Label8.TabIndex = 72
		Me.Label8.Text = "Observaciones:"
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Silver
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label7.Location = New System.Drawing.Point(251, 3)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(62, 23)
		Me.Label7.TabIndex = 70
		Me.Label7.Text = "Medicina:"
		'
		'TxtObservaciones
		'
		Me.TxtObservaciones.BackColor = System.Drawing.Color.Silver
		Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtObservaciones.Location = New System.Drawing.Point(5, 29)
		Me.TxtObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.TxtObservaciones.Multiline = True
		Me.TxtObservaciones.Name = "TxtObservaciones"
		Me.TxtObservaciones.Size = New System.Drawing.Size(218, 77)
		Me.TxtObservaciones.TabIndex = 71
		'
		'Hospitalización
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(536, 519)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.cmbTipoHospitalizacion)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.TextBox10)
		Me.Controls.Add(Me.cmbTalla)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.ComboBoxServicio)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Hospitalización"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Hospitalización"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
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
	Friend WithEvents ComboBoxServicio As ComboBox
	Friend WithEvents Label6 As Label
	Friend WithEvents cmbTalla As ComboBox
	Friend WithEvents Label12 As Label
	Friend WithEvents TextBox10 As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents cmbTipoHospitalizacion As ComboBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents dtpFechaSalida As DateTimePicker
	Friend WithEvents dtpFechaEntrada As DateTimePicker
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Panel4 As Panel
	Friend WithEvents TxtMedicinas As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents TxtObservaciones As TextBox
End Class
