<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estética
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estética))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtObservaciones = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtTotalEstetica = New System.Windows.Forms.TextBox()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
		Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.CheckListEsteticas = New System.Windows.Forms.CheckedListBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.PictureBox2)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, -2)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(838, 89)
		Me.Panel1.TabIndex = 8
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(10, 2)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(60, 52)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 86
		Me.PictureBox2.TabStop = False
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Black
		Me.Label5.Location = New System.Drawing.Point(1, 56)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(83, 18)
		Me.Label5.TabIndex = 85
		Me.Label5.Text = "VETCARE"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(390, 29)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(120, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(199, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(137, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Estética"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(1, 447)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(841, 99)
		Me.Panel2.TabIndex = 9
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Location = New System.Drawing.Point(398, 10)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(3, 8)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(113, 28)
		Me.Label6.TabIndex = 41
		Me.Label6.Text = "Hora de entrada:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(11, 47)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(100, 26)
		Me.Label2.TabIndex = 43
		Me.Label2.Text = "Hora de salida:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtObservaciones
		'
		Me.txtObservaciones.BackColor = System.Drawing.Color.White
		Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtObservaciones.Location = New System.Drawing.Point(63, 362)
		Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.txtObservaciones.Multiline = True
		Me.txtObservaciones.Name = "txtObservaciones"
		Me.txtObservaciones.Size = New System.Drawing.Size(184, 66)
		Me.txtObservaciones.TabIndex = 46
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.ForeColor = System.Drawing.Color.Black
		Me.Label12.Location = New System.Drawing.Point(320, 318)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(62, 24)
		Me.Label12.TabIndex = 51
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtTotalEstetica
		'
		Me.txtTotalEstetica.BackColor = System.Drawing.Color.White
		Me.txtTotalEstetica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtTotalEstetica.Location = New System.Drawing.Point(372, 318)
		Me.txtTotalEstetica.Margin = New System.Windows.Forms.Padding(2)
		Me.txtTotalEstetica.Multiline = True
		Me.txtTotalEstetica.Name = "txtTotalEstetica"
		Me.txtTotalEstetica.Size = New System.Drawing.Size(73, 24)
		Me.txtTotalEstetica.TabIndex = 52
		Me.txtTotalEstetica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.Color.White
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(345, 376)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxServicios.TabIndex = 53
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(296, 109)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(207, 162)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 54
		Me.PictureBox1.TabStop = False
		'
		'dtpHoraEntrada
		'
		Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtpHoraEntrada.Location = New System.Drawing.Point(115, 13)
		Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
		Me.dtpHoraEntrada.Size = New System.Drawing.Size(112, 20)
		Me.dtpHoraEntrada.TabIndex = 55
		'
		'dtpHoraSalida
		'
		Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtpHoraSalida.Location = New System.Drawing.Point(115, 51)
		Me.dtpHoraSalida.Name = "dtpHoraSalida"
		Me.dtpHoraSalida.Size = New System.Drawing.Size(112, 20)
		Me.dtpHoraSalida.TabIndex = 56
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(64, 347)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(81, 13)
		Me.Label3.TabIndex = 57
		Me.Label3.Text = "Observaciones:"
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.dtpHoraSalida)
		Me.Panel3.Controls.Add(Me.dtpHoraEntrada)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Location = New System.Drawing.Point(24, 99)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(240, 84)
		Me.Panel3.TabIndex = 60
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel4.Controls.Add(Me.CheckListEsteticas)
		Me.Panel4.Controls.Add(Me.Label4)
		Me.Panel4.Location = New System.Drawing.Point(51, 199)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(200, 136)
		Me.Panel4.TabIndex = 61
		'
		'CheckListEsteticas
		'
		Me.CheckListEsteticas.FormattingEnabled = True
		Me.CheckListEsteticas.Location = New System.Drawing.Point(12, 27)
		Me.CheckListEsteticas.Name = "CheckListEsteticas"
		Me.CheckListEsteticas.Size = New System.Drawing.Size(172, 94)
		Me.CheckListEsteticas.TabIndex = 66
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(13, 11)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(85, 13)
		Me.Label4.TabIndex = 64
		Me.Label4.Text = "Servicios de :"
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.Black
		Me.Label7.Location = New System.Drawing.Point(449, 318)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(54, 24)
		Me.Label7.TabIndex = 62
		Me.Label7.Text = "pesos."
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Estética
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(528, 493)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.txtTotalEstetica)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.txtObservaciones)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Estética"
		Me.Text = "Estética"
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
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
	Friend WithEvents Label6 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtObservaciones As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents txtTotalEstetica As TextBox
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents dtpHoraEntrada As DateTimePicker
	Friend WithEvents dtpHoraSalida As DateTimePicker
	Friend WithEvents Label3 As Label
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label7 As Label

	Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

	End Sub

	Friend WithEvents CheckListEsteticas As CheckedListBox
End Class
