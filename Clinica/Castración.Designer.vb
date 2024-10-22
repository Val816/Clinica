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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.TextBoxCosto = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
		Me.TextBoxObservaciones = New System.Windows.Forms.TextBox()
		Me.ComboBoxEspecie = New System.Windows.Forms.ComboBox()
		Me.ComboBoxTipoProcedimiento = New System.Windows.Forms.ComboBox()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-2, -2)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(858, 120)
		Me.Panel1.TabIndex = 10
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(373, 21)
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
		Me.Label1.Font = New System.Drawing.Font("MV Boli", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(119, 11)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(237, 85)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Castración y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Esterilización"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(-2, 419)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(858, 105)
		Me.Panel2.TabIndex = 11
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Location = New System.Drawing.Point(360, 32)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'ComboBoxTalla
		'
		Me.ComboBoxTalla.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBoxTalla.ForeColor = System.Drawing.Color.White
		Me.ComboBoxTalla.FormattingEnabled = True
		Me.ComboBoxTalla.Items.AddRange(New Object() {"Pequeña", "Mediana", "Grande"})
		Me.ComboBoxTalla.Location = New System.Drawing.Point(31, 204)
		Me.ComboBoxTalla.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxTalla.Name = "ComboBoxTalla"
		Me.ComboBoxTalla.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxTalla.TabIndex = 62
		Me.ComboBoxTalla.Text = "Talla"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.LightGray
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Location = New System.Drawing.Point(207, 140)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(45, 20)
		Me.Label2.TabIndex = 63
		Me.Label2.Text = "Fecha:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.LightGray
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label8.Location = New System.Drawing.Point(233, 190)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(88, 20)
		Me.Label8.TabIndex = 69
		Me.Label8.Text = "Observaciones:"
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.White
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(304, 358)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxServicios.TabIndex = 71
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.LightGray
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Location = New System.Drawing.Point(259, 301)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(62, 24)
		Me.Label12.TabIndex = 72
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxCosto
		'
		Me.TextBoxCosto.BackColor = System.Drawing.Color.LightGray
		Me.TextBoxCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxCosto.Location = New System.Drawing.Point(337, 301)
		Me.TextBoxCosto.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxCosto.Multiline = True
		Me.TextBoxCosto.Name = "TextBoxCosto"
		Me.TextBoxCosto.Size = New System.Drawing.Size(86, 24)
		Me.TextBoxCosto.TabIndex = 73
		Me.TextBoxCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(21, 236)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(189, 179)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 74
		Me.PictureBox1.TabStop = False
		'
		'DateTimePickerFecha
		'
		Me.DateTimePickerFecha.Location = New System.Drawing.Point(259, 140)
		Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
		Me.DateTimePickerFecha.Size = New System.Drawing.Size(164, 20)
		Me.DateTimePickerFecha.TabIndex = 75
		'
		'TextBoxObservaciones
		'
		Me.TextBoxObservaciones.BackColor = System.Drawing.Color.LightGray
		Me.TextBoxObservaciones.Location = New System.Drawing.Point(233, 213)
		Me.TextBoxObservaciones.Multiline = True
		Me.TextBoxObservaciones.Name = "TextBoxObservaciones"
		Me.TextBoxObservaciones.Size = New System.Drawing.Size(192, 66)
		Me.TextBoxObservaciones.TabIndex = 76
		'
		'ComboBoxEspecie
		'
		Me.ComboBoxEspecie.FormattingEnabled = True
		Me.ComboBoxEspecie.Location = New System.Drawing.Point(31, 168)
		Me.ComboBoxEspecie.Name = "ComboBoxEspecie"
		Me.ComboBoxEspecie.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxEspecie.TabIndex = 77
		'
		'ComboBoxTipoProcedimiento
		'
		Me.ComboBoxTipoProcedimiento.FormattingEnabled = True
		Me.ComboBoxTipoProcedimiento.Location = New System.Drawing.Point(31, 128)
		Me.ComboBoxTipoProcedimiento.Name = "ComboBoxTipoProcedimiento"
		Me.ComboBoxTipoProcedimiento.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxTipoProcedimiento.TabIndex = 78
		'
		'Castración_y_Esterilización
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(475, 487)
		Me.Controls.Add(Me.ComboBoxTipoProcedimiento)
		Me.Controls.Add(Me.ComboBoxEspecie)
		Me.Controls.Add(Me.TextBoxObservaciones)
		Me.Controls.Add(Me.DateTimePickerFecha)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.TextBoxCosto)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.ComboBoxTalla)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Castración_y_Esterilización"
		Me.Text = "Castración y Esterilización"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
	Friend WithEvents ComboBoxTalla As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents Label12 As Label
	Friend WithEvents TextBoxCosto As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents DateTimePickerFecha As DateTimePicker
	Friend WithEvents TextBoxObservaciones As TextBox
	Friend WithEvents ComboBoxEspecie As ComboBox
	Friend WithEvents ComboBoxTipoProcedimiento As ComboBox
End Class
