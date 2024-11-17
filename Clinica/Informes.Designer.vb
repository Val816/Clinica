<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.ComboBoxServicio = New System.Windows.Forms.ComboBox()
		Me.ComboBoxEspecie = New System.Windows.Forms.ComboBox()
		Me.ButtonGenerarInforme = New System.Windows.Forms.Button()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePickerFin = New System.Windows.Forms.DateTimePicker()
		Me.ComboBoxMascota = New System.Windows.Forms.ComboBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.ButtonImprimir = New System.Windows.Forms.Button()
		Me.DataGridViewResultados = New System.Windows.Forms.DataGridView()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.TextBoxTotalMascotas = New System.Windows.Forms.TextBox()
		Me.TextBoxTotalEspecie = New System.Windows.Forms.TextBox()
		Me.TextBoxServicioMasDado = New System.Windows.Forms.TextBox()
		Me.TextBoxDineroRecaudado = New System.Windows.Forms.TextBox()
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		CType(Me.DataGridViewResultados, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(0, -3)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(841, 89)
		Me.Panel1.TabIndex = 15
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(628, 43)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(105, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(311, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(137, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Informes"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Location = New System.Drawing.Point(0, 436)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(841, 95)
		Me.Panel2.TabIndex = 84
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(14, 8)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(67, 22)
		Me.Label3.TabIndex = 85
		Me.Label3.Text = "Desde:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(14, 43)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(62, 22)
		Me.Label4.TabIndex = 95
		Me.Label4.Text = "Hasta:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(15, 3)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(92, 22)
		Me.Label6.TabIndex = 98
		Me.Label6.Text = "Filtrar por:"
		'
		'ComboBoxServicio
		'
		Me.ComboBoxServicio.BackColor = System.Drawing.Color.White
		Me.ComboBoxServicio.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicio.FormattingEnabled = True
		Me.ComboBoxServicio.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicio.Location = New System.Drawing.Point(11, 50)
		Me.ComboBoxServicio.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicio.Name = "ComboBoxServicio"
		Me.ComboBoxServicio.Size = New System.Drawing.Size(101, 21)
		Me.ComboBoxServicio.TabIndex = 99
		Me.ComboBoxServicio.Text = "Servicio"
		'
		'ComboBoxEspecie
		'
		Me.ComboBoxEspecie.BackColor = System.Drawing.Color.White
		Me.ComboBoxEspecie.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxEspecie.FormattingEnabled = True
		Me.ComboBoxEspecie.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxEspecie.Location = New System.Drawing.Point(11, 75)
		Me.ComboBoxEspecie.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxEspecie.Name = "ComboBoxEspecie"
		Me.ComboBoxEspecie.Size = New System.Drawing.Size(101, 21)
		Me.ComboBoxEspecie.TabIndex = 100
		Me.ComboBoxEspecie.Text = "Especie"
		'
		'ButtonGenerarInforme
		'
		Me.ButtonGenerarInforme.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.ButtonGenerarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonGenerarInforme.Location = New System.Drawing.Point(129, 24)
		Me.ButtonGenerarInforme.Margin = New System.Windows.Forms.Padding(2)
		Me.ButtonGenerarInforme.Name = "ButtonGenerarInforme"
		Me.ButtonGenerarInforme.Size = New System.Drawing.Size(93, 25)
		Me.ButtonGenerarInforme.TabIndex = 101
		Me.ButtonGenerarInforme.Text = "Aceptar"
		Me.ButtonGenerarInforme.UseVisualStyleBackColor = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(696, 267)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(61, 17)
		Me.Label7.TabIndex = 102
		Me.Label7.Text = "Mascota"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(696, 373)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(58, 17)
		Me.Label8.TabIndex = 103
		Me.Label8.Text = "Especie"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(696, 316)
		Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(65, 17)
		Me.Label11.TabIndex = 106
		Me.Label11.Text = "Servicios"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(712, 417)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(44, 17)
		Me.Label12.TabIndex = 107
		Me.Label12.Text = "Costo"
		'
		'DateTimePickerInicio
		'
		Me.DateTimePickerInicio.Location = New System.Drawing.Point(86, 10)
		Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
		Me.DateTimePickerInicio.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerInicio.TabIndex = 114
		'
		'DateTimePickerFin
		'
		Me.DateTimePickerFin.Location = New System.Drawing.Point(86, 45)
		Me.DateTimePickerFin.Name = "DateTimePickerFin"
		Me.DateTimePickerFin.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerFin.TabIndex = 115
		'
		'ComboBoxMascota
		'
		Me.ComboBoxMascota.FormattingEnabled = True
		Me.ComboBoxMascota.Location = New System.Drawing.Point(11, 24)
		Me.ComboBoxMascota.Name = "ComboBoxMascota"
		Me.ComboBoxMascota.Size = New System.Drawing.Size(101, 21)
		Me.ComboBoxMascota.TabIndex = 116
		Me.ComboBoxMascota.Text = "Mascota"
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.ComboBoxMascota)
		Me.Panel3.Controls.Add(Me.ButtonImprimir)
		Me.Panel3.Controls.Add(Me.ButtonGenerarInforme)
		Me.Panel3.Controls.Add(Me.ComboBoxEspecie)
		Me.Panel3.Controls.Add(Me.ComboBoxServicio)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Location = New System.Drawing.Point(443, 109)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(239, 105)
		Me.Panel3.TabIndex = 117
		'
		'ButtonImprimir
		'
		Me.ButtonImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ButtonImprimir.BackColor = System.Drawing.Color.LightBlue
		Me.ButtonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonImprimir.Location = New System.Drawing.Point(129, 73)
		Me.ButtonImprimir.Name = "ButtonImprimir"
		Me.ButtonImprimir.Size = New System.Drawing.Size(93, 23)
		Me.ButtonImprimir.TabIndex = 118
		Me.ButtonImprimir.Text = "PDF"
		Me.ButtonImprimir.UseVisualStyleBackColor = False
		'
		'DataGridViewResultados
		'
		Me.DataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridViewResultados.Location = New System.Drawing.Point(32, 244)
		Me.DataGridViewResultados.Name = "DataGridViewResultados"
		Me.DataGridViewResultados.Size = New System.Drawing.Size(518, 182)
		Me.DataGridViewResultados.TabIndex = 119
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel4.Controls.Add(Me.DateTimePickerFin)
		Me.Panel4.Controls.Add(Me.DateTimePickerInicio)
		Me.Panel4.Controls.Add(Me.Label4)
		Me.Panel4.Controls.Add(Me.Label3)
		Me.Panel4.Location = New System.Drawing.Point(51, 123)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(310, 73)
		Me.Panel4.TabIndex = 120
		'
		'TextBoxTotalMascotas
		'
		Me.TextBoxTotalMascotas.Location = New System.Drawing.Point(591, 267)
		Me.TextBoxTotalMascotas.Name = "TextBoxTotalMascotas"
		Me.TextBoxTotalMascotas.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxTotalMascotas.TabIndex = 121
		'
		'TextBoxTotalEspecie
		'
		Me.TextBoxTotalEspecie.Location = New System.Drawing.Point(591, 316)
		Me.TextBoxTotalEspecie.Name = "TextBoxTotalEspecie"
		Me.TextBoxTotalEspecie.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxTotalEspecie.TabIndex = 122
		'
		'TextBoxServicioMasDado
		'
		Me.TextBoxServicioMasDado.Location = New System.Drawing.Point(591, 373)
		Me.TextBoxServicioMasDado.Name = "TextBoxServicioMasDado"
		Me.TextBoxServicioMasDado.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxServicioMasDado.TabIndex = 123
		'
		'TextBoxDineroRecaudado
		'
		Me.TextBoxDineroRecaudado.Location = New System.Drawing.Point(591, 411)
		Me.TextBoxDineroRecaudado.Name = "TextBoxDineroRecaudado"
		Me.TextBoxDineroRecaudado.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxDineroRecaudado.TabIndex = 124
		'
		'Informes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(767, 487)
		Me.Controls.Add(Me.TextBoxDineroRecaudado)
		Me.Controls.Add(Me.TextBoxServicioMasDado)
		Me.Controls.Add(Me.TextBoxTotalEspecie)
		Me.Controls.Add(Me.TextBoxTotalMascotas)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.DataGridViewResultados)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Informes"
		Me.Text = "Informes"
		Me.Panel1.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.DataGridViewResultados, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents ComboBoxServicio As ComboBox
	Friend WithEvents ComboBoxEspecie As ComboBox
	Friend WithEvents ButtonGenerarInforme As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents DateTimePickerInicio As DateTimePicker
	Friend WithEvents DateTimePickerFin As DateTimePicker
	Friend WithEvents ComboBoxMascota As ComboBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents ButtonImprimir As Button
	Friend WithEvents DataGridViewResultados As DataGridView
	Friend WithEvents Panel4 As Panel
	Friend WithEvents TextBoxTotalMascotas As TextBox
	Friend WithEvents TextBoxTotalEspecie As TextBox
	Friend WithEvents TextBoxServicioMasDado As TextBox
	Friend WithEvents TextBoxDineroRecaudado As TextBox
End Class
