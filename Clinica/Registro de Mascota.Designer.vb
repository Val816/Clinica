<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_de_Mascota
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtNomMasc = New System.Windows.Forms.TextBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtPeso = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtEdad = New System.Windows.Forms.TextBox()
		Me.txtCaracteristicas = New System.Windows.Forms.TextBox()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.ComboBoxGenero = New System.Windows.Forms.ComboBox()
		Me.ComboBoxRaza = New System.Windows.Forms.ComboBox()
		Me.ComboBoxEspecie = New System.Windows.Forms.ComboBox()
		Me.DataGridMascota = New System.Windows.Forms.DataGridView()
		Me.ComboBoxTalla = New System.Windows.Forms.ComboBox()
		Me.txtCelular = New System.Windows.Forms.TextBox()
		Me.txtNomCliente = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.ComboBoxEstadoReproductivo = New System.Windows.Forms.ComboBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		CType(Me.DataGridMascota, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, -5)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(845, 74)
		Me.Panel1.TabIndex = 3
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(705, 29)
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
		Me.Label1.Location = New System.Drawing.Point(327, 15)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(337, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Mascotas"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(1, 469)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(839, 62)
		Me.Panel2.TabIndex = 4
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Location = New System.Drawing.Point(731, 14)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(2, 4)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(106, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Nombre de Mascota:"
		'
		'txtNomMasc
		'
		Me.txtNomMasc.BackColor = System.Drawing.Color.Silver
		Me.txtNomMasc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNomMasc.Location = New System.Drawing.Point(114, 5)
		Me.txtNomMasc.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNomMasc.Name = "txtNomMasc"
		Me.txtNomMasc.Size = New System.Drawing.Size(228, 13)
		Me.txtNomMasc.TabIndex = 6
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.Silver
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel3.Controls.Add(Me.txtNomMasc)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(27, 135)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(214, 25)
		Me.Panel3.TabIndex = 7
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Silver
		Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel4.Controls.Add(Me.ComboBox2)
		Me.Panel4.Controls.Add(Me.Label3)
		Me.Panel4.Location = New System.Drawing.Point(27, 167)
		Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(73, 25)
		Me.Panel4.TabIndex = 8
		'
		'ComboBox2
		'
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(200, 13)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox2.TabIndex = 6
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(11, 5)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(48, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Especie:"
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Silver
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label4.Location = New System.Drawing.Point(27, 201)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(67, 24)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Raza:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Silver
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label5.Location = New System.Drawing.Point(27, 239)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(67, 24)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Peso:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Silver
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.Location = New System.Drawing.Point(27, 277)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(67, 24)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Talla:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtPeso
		'
		Me.txtPeso.BackColor = System.Drawing.Color.Silver
		Me.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtPeso.Location = New System.Drawing.Point(118, 239)
		Me.txtPeso.Margin = New System.Windows.Forms.Padding(2)
		Me.txtPeso.Multiline = True
		Me.txtPeso.Name = "txtPeso"
		Me.txtPeso.Size = New System.Drawing.Size(121, 24)
		Me.txtPeso.TabIndex = 13
		Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Silver
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label7.Location = New System.Drawing.Point(28, 314)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(67, 24)
		Me.Label7.TabIndex = 15
		Me.Label7.Text = "Género:"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Silver
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label8.Location = New System.Drawing.Point(27, 350)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(67, 24)
		Me.Label8.TabIndex = 16
		Me.Label8.Text = "Edad:"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label9
		'
		Me.Label9.BackColor = System.Drawing.Color.Silver
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label9.Location = New System.Drawing.Point(27, 422)
		Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(83, 24)
		Me.Label9.TabIndex = 17
		Me.Label9.Text = "Características:"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtEdad
		'
		Me.txtEdad.BackColor = System.Drawing.Color.Silver
		Me.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtEdad.Location = New System.Drawing.Point(120, 350)
		Me.txtEdad.Margin = New System.Windows.Forms.Padding(2)
		Me.txtEdad.Multiline = True
		Me.txtEdad.Name = "txtEdad"
		Me.txtEdad.Size = New System.Drawing.Size(121, 24)
		Me.txtEdad.TabIndex = 19
		Me.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtCaracteristicas
		'
		Me.txtCaracteristicas.BackColor = System.Drawing.Color.Silver
		Me.txtCaracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtCaracteristicas.Location = New System.Drawing.Point(120, 422)
		Me.txtCaracteristicas.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCaracteristicas.Multiline = True
		Me.txtCaracteristicas.Name = "txtCaracteristicas"
		Me.txtCaracteristicas.Size = New System.Drawing.Size(209, 41)
		Me.txtCaracteristicas.TabIndex = 20
		Me.txtCaracteristicas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.White
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Cirugía", "Grooming", "Pensión", "Eutanasia"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(713, 425)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(113, 21)
		Me.ComboBoxServicios.TabIndex = 21
		Me.ComboBoxServicios.Text = "Servicio"
		'
		'ComboBoxGenero
		'
		Me.ComboBoxGenero.FormattingEnabled = True
		Me.ComboBoxGenero.Location = New System.Drawing.Point(118, 317)
		Me.ComboBoxGenero.Name = "ComboBoxGenero"
		Me.ComboBoxGenero.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxGenero.TabIndex = 22
		'
		'ComboBoxRaza
		'
		Me.ComboBoxRaza.FormattingEnabled = True
		Me.ComboBoxRaza.Location = New System.Drawing.Point(118, 204)
		Me.ComboBoxRaza.Name = "ComboBoxRaza"
		Me.ComboBoxRaza.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxRaza.TabIndex = 23
		'
		'ComboBoxEspecie
		'
		Me.ComboBoxEspecie.FormattingEnabled = True
		Me.ComboBoxEspecie.Location = New System.Drawing.Point(118, 171)
		Me.ComboBoxEspecie.Name = "ComboBoxEspecie"
		Me.ComboBoxEspecie.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxEspecie.TabIndex = 24
		'
		'DataGridMascota
		'
		Me.DataGridMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridMascota.Location = New System.Drawing.Point(320, 74)
		Me.DataGridMascota.Name = "DataGridMascota"
		Me.DataGridMascota.Size = New System.Drawing.Size(505, 337)
		Me.DataGridMascota.TabIndex = 25
		'
		'ComboBoxTalla
		'
		Me.ComboBoxTalla.FormattingEnabled = True
		Me.ComboBoxTalla.Location = New System.Drawing.Point(118, 280)
		Me.ComboBoxTalla.Name = "ComboBoxTalla"
		Me.ComboBoxTalla.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxTalla.TabIndex = 26
		'
		'txtCelular
		'
		Me.txtCelular.BackColor = System.Drawing.Color.Silver
		Me.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCelular.Location = New System.Drawing.Point(140, 104)
		Me.txtCelular.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCelular.Multiline = True
		Me.txtCelular.Name = "txtCelular"
		Me.txtCelular.Size = New System.Drawing.Size(132, 27)
		Me.txtCelular.TabIndex = 30
		'
		'txtNomCliente
		'
		Me.txtNomCliente.BackColor = System.Drawing.Color.Silver
		Me.txtNomCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNomCliente.Location = New System.Drawing.Point(140, 73)
		Me.txtNomCliente.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNomCliente.Multiline = True
		Me.txtNomCliente.Name = "txtNomCliente"
		Me.txtNomCliente.Size = New System.Drawing.Size(132, 27)
		Me.txtNomCliente.TabIndex = 29
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Silver
		Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label10.Location = New System.Drawing.Point(25, 103)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(97, 27)
		Me.Label10.TabIndex = 28
		Me.Label10.Text = "Teléfono:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label11
		'
		Me.Label11.BackColor = System.Drawing.Color.Gray
		Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label11.Location = New System.Drawing.Point(25, 71)
		Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(97, 27)
		Me.Label11.TabIndex = 27
		Me.Label11.Text = "Nombre de tutor:"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Silver
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Location = New System.Drawing.Point(27, 387)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(126, 24)
		Me.Label12.TabIndex = 31
		Me.Label12.Text = "Estado Reproductivo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ComboBoxEstadoReproductivo
		'
		Me.ComboBoxEstadoReproductivo.FormattingEnabled = True
		Me.ComboBoxEstadoReproductivo.Location = New System.Drawing.Point(168, 390)
		Me.ComboBoxEstadoReproductivo.Name = "ComboBoxEstadoReproductivo"
		Me.ComboBoxEstadoReproductivo.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxEstadoReproductivo.TabIndex = 32
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(610, 428)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(98, 13)
		Me.Label13.TabIndex = 33
		Me.Label13.Text = "Agrega un servicio:"
		'
		'Registro_de_Mascota
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(837, 519)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.ComboBoxEstadoReproductivo)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.txtCelular)
		Me.Controls.Add(Me.ComboBoxTalla)
		Me.Controls.Add(Me.DataGridMascota)
		Me.Controls.Add(Me.txtNomCliente)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.ComboBoxEspecie)
		Me.Controls.Add(Me.ComboBoxRaza)
		Me.Controls.Add(Me.ComboBoxGenero)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.txtCaracteristicas)
		Me.Controls.Add(Me.txtEdad)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtPeso)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Registro_de_Mascota"
		Me.Text = "Registro_de_Mascota"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		CType(Me.DataGridMascota, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents txtNomMasc As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtPeso As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents txtEdad As TextBox
	Friend WithEvents txtCaracteristicas As TextBox
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents ComboBoxGenero As ComboBox
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents ComboBoxRaza As ComboBox
	Friend WithEvents ComboBoxEspecie As ComboBox
	Friend WithEvents DataGridMascota As DataGridView
	Friend WithEvents ComboBoxTalla As ComboBox
	Friend WithEvents txtCelular As TextBox
	Friend WithEvents txtNomCliente As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents ComboBoxEstadoReproductivo As ComboBox
	Friend WithEvents Label13 As Label
End Class
