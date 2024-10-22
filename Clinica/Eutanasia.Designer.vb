<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eutanasia
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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.ComboBoxMotivos = New System.Windows.Forms.ComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.TextBoxObservaciones = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.TextBoxCostoFinal = New System.Windows.Forms.TextBox()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.txtHora = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
		Me.BtnGenerarPDF = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-4, -3)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(854, 106)
		Me.Panel1.TabIndex = 5
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(368, 29)
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
		Me.Label1.Location = New System.Drawing.Point(142, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(196, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Eutanasia"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel2.Controls.Add(Me.BtnGenerarPDF)
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(-4, 381)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(854, 152)
		Me.Panel2.TabIndex = 6
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Location = New System.Drawing.Point(357, 19)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'ComboBoxMotivos
		'
		Me.ComboBoxMotivos.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBoxMotivos.DropDownHeight = 150
		Me.ComboBoxMotivos.ForeColor = System.Drawing.Color.White
		Me.ComboBoxMotivos.FormattingEnabled = True
		Me.ComboBoxMotivos.IntegralHeight = False
		Me.ComboBoxMotivos.Items.AddRange(New Object() {"Edad Avanzada", "Enfermedad crónica"})
		Me.ComboBoxMotivos.Location = New System.Drawing.Point(78, 290)
		Me.ComboBoxMotivos.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxMotivos.Name = "ComboBoxMotivos"
		Me.ComboBoxMotivos.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxMotivos.TabIndex = 26
		Me.ComboBoxMotivos.Text = "Motivo"
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Silver
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label10.Location = New System.Drawing.Point(63, 168)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(95, 24)
		Me.Label10.TabIndex = 27
		Me.Label10.Text = "Observaciones:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxObservaciones
		'
		Me.TextBoxObservaciones.BackColor = System.Drawing.Color.Silver
		Me.TextBoxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxObservaciones.Location = New System.Drawing.Point(182, 172)
		Me.TextBoxObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxObservaciones.Multiline = True
		Me.TextBoxObservaciones.Name = "TextBoxObservaciones"
		Me.TextBoxObservaciones.Size = New System.Drawing.Size(210, 96)
		Me.TextBoxObservaciones.TabIndex = 28
		Me.TextBoxObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Silver
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Location = New System.Drawing.Point(253, 308)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(62, 24)
		Me.Label12.TabIndex = 33
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxCostoFinal
		'
		Me.TextBoxCostoFinal.BackColor = System.Drawing.Color.Silver
		Me.TextBoxCostoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxCostoFinal.Location = New System.Drawing.Point(319, 308)
		Me.TextBoxCostoFinal.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxCostoFinal.Multiline = True
		Me.TextBoxCostoFinal.Name = "TextBoxCostoFinal"
		Me.TextBoxCostoFinal.Size = New System.Drawing.Size(73, 24)
		Me.TextBoxCostoFinal.TabIndex = 34
		Me.TextBoxCostoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.White
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(78, 334)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxServicios.TabIndex = 35
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'txtHora
		'
		Me.txtHora.BackColor = System.Drawing.Color.Silver
		Me.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtHora.Location = New System.Drawing.Point(182, 124)
		Me.txtHora.Margin = New System.Windows.Forms.Padding(2)
		Me.txtHora.Multiline = True
		Me.txtHora.Name = "txtHora"
		Me.txtHora.Size = New System.Drawing.Size(210, 28)
		Me.txtHora.TabIndex = 36
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Silver
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Location = New System.Drawing.Point(63, 124)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(95, 28)
		Me.Label6.TabIndex = 37
		Me.Label6.Text = "Fecha:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DateTimePickerFecha
		'
		Me.DateTimePickerFecha.Location = New System.Drawing.Point(186, 126)
		Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
		Me.DateTimePickerFecha.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerFecha.TabIndex = 38
		'
		'BtnGenerarPDF
		'
		Me.BtnGenerarPDF.Location = New System.Drawing.Point(257, 20)
		Me.BtnGenerarPDF.Name = "BtnGenerarPDF"
		Me.BtnGenerarPDF.Size = New System.Drawing.Size(75, 23)
		Me.BtnGenerarPDF.TabIndex = 6
		Me.BtnGenerarPDF.Text = "Generar pdf"
		Me.BtnGenerarPDF.UseVisualStyleBackColor = True
		'
		'Eutanasia
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(468, 450)
		Me.Controls.Add(Me.DateTimePickerFecha)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtHora)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.TextBoxCostoFinal)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.TextBoxObservaciones)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.ComboBoxMotivos)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Eutanasia"
		Me.Text = "Eutanasia"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
	Friend WithEvents ComboBoxMotivos As ComboBox
	Friend WithEvents Label10 As Label
	Friend WithEvents TextBoxObservaciones As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents TextBoxCostoFinal As TextBox
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents txtHora As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents DateTimePickerFecha As DateTimePicker
	Friend WithEvents BtnGenerarPDF As Button
End Class
