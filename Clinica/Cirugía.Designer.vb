<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cirugía
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
		Me.ButtonGuardar = New System.Windows.Forms.Button()
		Me.DataGridViewCirugias = New System.Windows.Forms.DataGridView()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.BtnBuscar = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.ComboBoxMascota = New System.Windows.Forms.ComboBox()
		Me.ComboBoxCirugia = New System.Windows.Forms.ComboBox()
		Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.TextBoxCosto = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TextBoxObservaciones = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		CType(Me.DataGridViewCirugias, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
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
		Me.Panel1.Size = New System.Drawing.Size(838, 84)
		Me.Panel1.TabIndex = 7
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(604, 29)
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
		Me.Label1.Location = New System.Drawing.Point(294, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(271, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Cirugía"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel2.Location = New System.Drawing.Point(-2, 423)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(841, 115)
		Me.Panel2.TabIndex = 8
		'
		'ButtonGuardar
		'
		Me.ButtonGuardar.BackColor = System.Drawing.Color.LightSteelBlue
		Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonGuardar.Location = New System.Drawing.Point(23, 283)
		Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.ButtonGuardar.Name = "ButtonGuardar"
		Me.ButtonGuardar.Size = New System.Drawing.Size(76, 23)
		Me.ButtonGuardar.TabIndex = 5
		Me.ButtonGuardar.Text = "Guardar"
		Me.ButtonGuardar.UseVisualStyleBackColor = False
		'
		'DataGridViewCirugias
		'
		Me.DataGridViewCirugias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridViewCirugias.Location = New System.Drawing.Point(371, 100)
		Me.DataGridViewCirugias.Name = "DataGridViewCirugias"
		Me.DataGridViewCirugias.Size = New System.Drawing.Size(328, 306)
		Me.DataGridViewCirugias.TabIndex = 49
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
		Me.Panel3.Controls.Add(Me.ButtonGuardar)
		Me.Panel3.Controls.Add(Me.BtnBuscar)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.ComboBoxMascota)
		Me.Panel3.Controls.Add(Me.ComboBoxCirugia)
		Me.Panel3.Controls.Add(Me.DateTimePickerFecha)
		Me.Panel3.Controls.Add(Me.ComboBoxServicios)
		Me.Panel3.Controls.Add(Me.TextBoxCosto)
		Me.Panel3.Controls.Add(Me.Label12)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Controls.Add(Me.TextBoxObservaciones)
		Me.Panel3.Controls.Add(Me.Label10)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(12, 100)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(353, 318)
		Me.Panel3.TabIndex = 50
		'
		'BtnBuscar
		'
		Me.BtnBuscar.BackColor = System.Drawing.Color.LightSteelBlue
		Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtnBuscar.Location = New System.Drawing.Point(104, 283)
		Me.BtnBuscar.Name = "BtnBuscar"
		Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
		Me.BtnBuscar.TabIndex = 61
		Me.BtnBuscar.Text = "Buscar"
		Me.BtnBuscar.UseVisualStyleBackColor = False
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Silver
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Location = New System.Drawing.Point(23, 13)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(104, 36)
		Me.Label3.TabIndex = 60
		Me.Label3.Text = "Nombre de la mascota:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ComboBoxMascota
		'
		Me.ComboBoxMascota.FormattingEnabled = True
		Me.ComboBoxMascota.Location = New System.Drawing.Point(140, 19)
		Me.ComboBoxMascota.Name = "ComboBoxMascota"
		Me.ComboBoxMascota.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxMascota.TabIndex = 58
		'
		'ComboBoxCirugia
		'
		Me.ComboBoxCirugia.FormattingEnabled = True
		Me.ComboBoxCirugia.Location = New System.Drawing.Point(140, 60)
		Me.ComboBoxCirugia.Name = "ComboBoxCirugia"
		Me.ComboBoxCirugia.Size = New System.Drawing.Size(200, 21)
		Me.ComboBoxCirugia.TabIndex = 57
		'
		'DateTimePickerFecha
		'
		Me.DateTimePickerFecha.Location = New System.Drawing.Point(140, 102)
		Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
		Me.DateTimePickerFecha.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerFecha.TabIndex = 56
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(193, 285)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxServicios.TabIndex = 53
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'TextBoxCosto
		'
		Me.TextBoxCosto.BackColor = System.Drawing.Color.Silver
		Me.TextBoxCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxCosto.Location = New System.Drawing.Point(140, 236)
		Me.TextBoxCosto.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxCosto.Multiline = True
		Me.TextBoxCosto.Name = "TextBoxCosto"
		Me.TextBoxCosto.Size = New System.Drawing.Size(73, 24)
		Me.TextBoxCosto.TabIndex = 55
		Me.TextBoxCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Silver
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Location = New System.Drawing.Point(65, 236)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(62, 24)
		Me.Label12.TabIndex = 54
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Silver
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Location = New System.Drawing.Point(23, 100)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(95, 28)
		Me.Label6.TabIndex = 52
		Me.Label6.Text = "Fecha:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxObservaciones
		'
		Me.TextBoxObservaciones.BackColor = System.Drawing.Color.Silver
		Me.TextBoxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxObservaciones.Location = New System.Drawing.Point(140, 147)
		Me.TextBoxObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxObservaciones.Multiline = True
		Me.TextBoxObservaciones.Name = "TextBoxObservaciones"
		Me.TextBoxObservaciones.Size = New System.Drawing.Size(200, 82)
		Me.TextBoxObservaciones.TabIndex = 51
		Me.TextBoxObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Silver
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label10.Location = New System.Drawing.Point(12, 147)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(115, 40)
		Me.Label10.TabIndex = 50
		Me.Label10.Text = "Observaciones:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Silver
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.Location = New System.Drawing.Point(23, 57)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(104, 24)
		Me.Label2.TabIndex = 49
		Me.Label2.Text = "Tipo de cirugía:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Cirugía
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(711, 477)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.DataGridViewCirugias)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Cirugía"
		Me.Text = "Cirugía"
		Me.Panel1.ResumeLayout(False)
		CType(Me.DataGridViewCirugias, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents btnMenuPrincipal As System.Windows.Forms.Button
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
	Friend WithEvents DataGridViewCirugias As DataGridView
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Label3 As Label
	Friend WithEvents ComboBoxMascota As ComboBox
	Friend WithEvents ComboBoxCirugia As ComboBox
	Friend WithEvents DateTimePickerFecha As DateTimePicker
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents TextBoxCosto As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents TextBoxObservaciones As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents BtnBuscar As Button
End Class
