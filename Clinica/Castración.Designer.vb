<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Castración_y_Esterilización
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Castración_y_Esterilización))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.ComboBoxTalla = New System.Windows.Forms.ComboBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.ComboBoxEspecie = New System.Windows.Forms.ComboBox()
		Me.ComboBoxTipoProcedimiento = New System.Windows.Forms.ComboBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.TextBoxObservaciones = New System.Windows.Forms.TextBox()
		Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
		Me.TextBoxCosto = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.PictureBox2)
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-2, -2)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(858, 95)
		Me.Panel1.TabIndex = 10
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(604, 29)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(125, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(166, 2)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(434, 85)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Castración y Esterilización"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(-2, 412)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(858, 112)
		Me.Panel2.TabIndex = 11
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.LightBlue
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Location = New System.Drawing.Point(623, 21)
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
		Me.ComboBoxTalla.Location = New System.Drawing.Point(113, 72)
		Me.ComboBoxTalla.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxTalla.Name = "ComboBoxTalla"
		Me.ComboBoxTalla.Size = New System.Drawing.Size(83, 21)
		Me.ComboBoxTalla.TabIndex = 62
		Me.ComboBoxTalla.Text = "Talla"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(256, 4)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(149, 83)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 74
		Me.PictureBox1.TabStop = False
		'
		'ComboBoxEspecie
		'
		Me.ComboBoxEspecie.FormattingEnabled = True
		Me.ComboBoxEspecie.Location = New System.Drawing.Point(113, 40)
		Me.ComboBoxEspecie.Name = "ComboBoxEspecie"
		Me.ComboBoxEspecie.Size = New System.Drawing.Size(83, 21)
		Me.ComboBoxEspecie.TabIndex = 77
		'
		'ComboBoxTipoProcedimiento
		'
		Me.ComboBoxTipoProcedimiento.FormattingEnabled = True
		Me.ComboBoxTipoProcedimiento.Location = New System.Drawing.Point(113, 13)
		Me.ComboBoxTipoProcedimiento.Name = "ComboBoxTipoProcedimiento"
		Me.ComboBoxTipoProcedimiento.Size = New System.Drawing.Size(175, 21)
		Me.ComboBoxTipoProcedimiento.TabIndex = 78
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.TextBoxObservaciones)
		Me.Panel3.Controls.Add(Me.DateTimePickerFecha)
		Me.Panel3.Controls.Add(Me.PictureBox1)
		Me.Panel3.Controls.Add(Me.ComboBoxServicios)
		Me.Panel3.Controls.Add(Me.Label8)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(309, 109)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(417, 126)
		Me.Panel3.TabIndex = 2
		'
		'TextBoxObservaciones
		'
		Me.TextBoxObservaciones.BackColor = System.Drawing.Color.White
		Me.TextBoxObservaciones.Location = New System.Drawing.Point(18, 56)
		Me.TextBoxObservaciones.Multiline = True
		Me.TextBoxObservaciones.Name = "TextBoxObservaciones"
		Me.TextBoxObservaciones.Size = New System.Drawing.Size(191, 60)
		Me.TextBoxObservaciones.TabIndex = 83
		'
		'DateTimePickerFecha
		'
		Me.DateTimePickerFecha.Location = New System.Drawing.Point(59, 10)
		Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
		Me.DateTimePickerFecha.Size = New System.Drawing.Size(192, 20)
		Me.DateTimePickerFecha.TabIndex = 82
		'
		'TextBoxCosto
		'
		Me.TextBoxCosto.BackColor = System.Drawing.Color.White
		Me.TextBoxCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxCosto.Location = New System.Drawing.Point(113, 98)
		Me.TextBoxCosto.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxCosto.Multiline = True
		Me.TextBoxCosto.Name = "TextBoxCosto"
		Me.TextBoxCosto.Size = New System.Drawing.Size(53, 24)
		Me.TextBoxCosto.TabIndex = 81
		Me.TextBoxCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(52, 98)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(57, 24)
		Me.Label12.TabIndex = 80
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.Color.White
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(286, 95)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(119, 21)
		Me.ComboBoxServicios.TabIndex = 79
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(15, 33)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(109, 20)
		Me.Label8.TabIndex = 78
		Me.Label8.Text = "Observaciones:"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(15, 8)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 20)
		Me.Label2.TabIndex = 77
		Me.Label2.Text = "Fecha:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(-1, 14)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(108, 15)
		Me.Label3.TabIndex = 79
		Me.Label3.Text = "Procedimiento: "
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(41, 43)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(62, 15)
		Me.Label4.TabIndex = 80
		Me.Label4.Text = "Especie:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(59, 72)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(43, 15)
		Me.Label5.TabIndex = 81
		Me.Label5.Text = "Talla:"
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel4.Controls.Add(Me.Label7)
		Me.Panel4.Controls.Add(Me.Label5)
		Me.Panel4.Controls.Add(Me.Label4)
		Me.Panel4.Controls.Add(Me.TextBoxCosto)
		Me.Panel4.Controls.Add(Me.Label3)
		Me.Panel4.Controls.Add(Me.Label12)
		Me.Panel4.Controls.Add(Me.ComboBoxTipoProcedimiento)
		Me.Panel4.Controls.Add(Me.ComboBoxEspecie)
		Me.Panel4.Controls.Add(Me.ComboBoxTalla)
		Me.Panel4.Location = New System.Drawing.Point(12, 109)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(291, 126)
		Me.Panel4.TabIndex = 82
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(6, 2)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(60, 52)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 84
		Me.PictureBox2.TabStop = False
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.Black
		Me.Label6.Location = New System.Drawing.Point(-3, 56)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(83, 18)
		Me.Label6.TabIndex = 83
		Me.Label6.Text = "VETCARE"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(170, 98)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(50, 24)
		Me.Label7.TabIndex = 82
		Me.Label7.Text = "pesos."
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(15, 262)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(712, 127)
		Me.DataGridView1.TabIndex = 83
		'
		'Castración_y_Esterilización
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(738, 488)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Castración_y_Esterilización"
		Me.Text = "Castración y Esterilización"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
	Friend WithEvents ComboBoxTalla As ComboBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents ComboBoxEspecie As ComboBox
	Friend WithEvents ComboBoxTipoProcedimiento As ComboBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents TextBoxObservaciones As TextBox
	Friend WithEvents DateTimePickerFecha As DateTimePicker
	Friend WithEvents TextBoxCosto As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Panel4 As Panel
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents DataGridView1 As DataGridView
End Class
