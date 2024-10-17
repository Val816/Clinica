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
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.DataGridViewMascotas = New System.Windows.Forms.DataGridView()
		Me.txtCelular = New System.Windows.Forms.TextBox()
		Me.txtNomCliente = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.txtApCliente = New System.Windows.Forms.TextBox()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.ComboBoxEdadUnidad = New System.Windows.Forms.ComboBox()
		Me.txtNomMasc = New System.Windows.Forms.TextBox()
		Me.ComboBoxEstadoReproductivo = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.ComboBoxTalla = New System.Windows.Forms.ComboBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ComboBoxEspecie = New System.Windows.Forms.ComboBox()
		Me.ComboBoxRaza = New System.Windows.Forms.ComboBox()
		Me.ComboBoxGenero = New System.Windows.Forms.ComboBox()
		Me.txtCaracteristicas = New System.Windows.Forms.TextBox()
		Me.txtEdad = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtPeso = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		CType(Me.DataGridViewMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel5.SuspendLayout()
		Me.Panel6.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, -5)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(964, 74)
		Me.Panel1.TabIndex = 3
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(856, 29)
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
		Me.Label1.Location = New System.Drawing.Point(262, 15)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(382, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Registro de Mascotas"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel2.Location = New System.Drawing.Point(1, 575)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(964, 55)
		Me.Panel2.TabIndex = 4
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.LightSlateGray
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.ForeColor = System.Drawing.SystemColors.Control
		Me.btnGuardar.Location = New System.Drawing.Point(857, 513)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Cirugía", "Grooming", "Pensión", "Eutanasia"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(838, 549)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(113, 21)
		Me.ComboBoxServicios.TabIndex = 21
		'
		'DataGridViewMascotas
		'
		Me.DataGridViewMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridViewMascotas.Location = New System.Drawing.Point(375, 85)
		Me.DataGridViewMascotas.Name = "DataGridViewMascotas"
		Me.DataGridViewMascotas.Size = New System.Drawing.Size(575, 413)
		Me.DataGridViewMascotas.TabIndex = 25
		'
		'txtCelular
		'
		Me.txtCelular.BackColor = System.Drawing.Color.Silver
		Me.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCelular.Location = New System.Drawing.Point(140, 91)
		Me.txtCelular.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCelular.Multiline = True
		Me.txtCelular.Name = "txtCelular"
		Me.txtCelular.Size = New System.Drawing.Size(173, 27)
		Me.txtCelular.TabIndex = 30
		'
		'txtNomCliente
		'
		Me.txtNomCliente.BackColor = System.Drawing.Color.Silver
		Me.txtNomCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNomCliente.Location = New System.Drawing.Point(140, 11)
		Me.txtNomCliente.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNomCliente.Multiline = True
		Me.txtNomCliente.Name = "txtNomCliente"
		Me.txtNomCliente.Size = New System.Drawing.Size(173, 27)
		Me.txtNomCliente.TabIndex = 29
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Silver
		Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label10.Location = New System.Drawing.Point(28, 91)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(97, 27)
		Me.Label10.TabIndex = 28
		Me.Label10.Text = "Teléfono:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label11
		'
		Me.Label11.BackColor = System.Drawing.Color.Silver
		Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label11.Location = New System.Drawing.Point(28, 11)
		Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(97, 27)
		Me.Label11.TabIndex = 27
		Me.Label11.Text = "Nombre de tutor:"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.ForeColor = System.Drawing.Color.Black
		Me.Label13.Location = New System.Drawing.Point(735, 552)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(98, 13)
		Me.Label13.TabIndex = 33
		Me.Label13.Text = "Agrega un servicio:"
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.LightSlateGray
		Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btnEliminar.Location = New System.Drawing.Point(696, 513)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 25)
		Me.btnEliminar.TabIndex = 34
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = False
		'
		'btnBuscar
		'
		Me.btnBuscar.AutoSize = True
		Me.btnBuscar.BackColor = System.Drawing.Color.LightSlateGray
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btnBuscar.Location = New System.Drawing.Point(777, 513)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(75, 25)
		Me.btnBuscar.TabIndex = 35
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Panel5.Controls.Add(Me.Label14)
		Me.Panel5.Controls.Add(Me.txtApCliente)
		Me.Panel5.Controls.Add(Me.txtNomCliente)
		Me.Panel5.Controls.Add(Me.txtCelular)
		Me.Panel5.Controls.Add(Me.Label11)
		Me.Panel5.Controls.Add(Me.Label10)
		Me.Panel5.Location = New System.Drawing.Point(28, 74)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(329, 130)
		Me.Panel5.TabIndex = 36
		'
		'Label14
		'
		Me.Label14.BackColor = System.Drawing.Color.Silver
		Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label14.Location = New System.Drawing.Point(32, 56)
		Me.Label14.Name = "Label14"
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.Size = New System.Drawing.Size(93, 22)
		Me.Label14.TabIndex = 32
		Me.Label14.Text = "Apellido del tutor:"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtApCliente
		'
		Me.txtApCliente.BackColor = System.Drawing.Color.Silver
		Me.txtApCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtApCliente.Location = New System.Drawing.Point(140, 56)
		Me.txtApCliente.Multiline = True
		Me.txtApCliente.Name = "txtApCliente"
		Me.txtApCliente.Size = New System.Drawing.Size(173, 20)
		Me.txtApCliente.TabIndex = 31
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Panel6.Controls.Add(Me.ComboBoxEdadUnidad)
		Me.Panel6.Controls.Add(Me.txtNomMasc)
		Me.Panel6.Controls.Add(Me.ComboBoxEstadoReproductivo)
		Me.Panel6.Controls.Add(Me.Label12)
		Me.Panel6.Controls.Add(Me.ComboBoxTalla)
		Me.Panel6.Controls.Add(Me.Panel3)
		Me.Panel6.Controls.Add(Me.ComboBoxEspecie)
		Me.Panel6.Controls.Add(Me.ComboBoxRaza)
		Me.Panel6.Controls.Add(Me.ComboBoxGenero)
		Me.Panel6.Controls.Add(Me.txtCaracteristicas)
		Me.Panel6.Controls.Add(Me.txtEdad)
		Me.Panel6.Controls.Add(Me.Label9)
		Me.Panel6.Controls.Add(Me.Label8)
		Me.Panel6.Controls.Add(Me.Label7)
		Me.Panel6.Controls.Add(Me.txtPeso)
		Me.Panel6.Controls.Add(Me.Label6)
		Me.Panel6.Controls.Add(Me.Label5)
		Me.Panel6.Controls.Add(Me.Label4)
		Me.Panel6.Controls.Add(Me.Panel4)
		Me.Panel6.Location = New System.Drawing.Point(28, 210)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(329, 360)
		Me.Panel6.TabIndex = 37
		'
		'ComboBoxEdadUnidad
		'
		Me.ComboBoxEdadUnidad.FormattingEnabled = True
		Me.ComboBoxEdadUnidad.Location = New System.Drawing.Point(192, 227)
		Me.ComboBoxEdadUnidad.Name = "ComboBoxEdadUnidad"
		Me.ComboBoxEdadUnidad.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxEdadUnidad.TabIndex = 50
		'
		'txtNomMasc
		'
		Me.txtNomMasc.BackColor = System.Drawing.Color.LightGray
		Me.txtNomMasc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtNomMasc.Location = New System.Drawing.Point(140, 17)
		Me.txtNomMasc.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNomMasc.Name = "txtNomMasc"
		Me.txtNomMasc.Size = New System.Drawing.Size(133, 20)
		Me.txtNomMasc.TabIndex = 6
		'
		'ComboBoxEstadoReproductivo
		'
		Me.ComboBoxEstadoReproductivo.FormattingEnabled = True
		Me.ComboBoxEstadoReproductivo.Location = New System.Drawing.Point(152, 267)
		Me.ComboBoxEstadoReproductivo.Name = "ComboBoxEstadoReproductivo"
		Me.ComboBoxEstadoReproductivo.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxEstadoReproductivo.TabIndex = 49
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Silver
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Location = New System.Drawing.Point(11, 264)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(126, 24)
		Me.Label12.TabIndex = 48
		Me.Label12.Text = "Estado Reproductivo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ComboBoxTalla
		'
		Me.ComboBoxTalla.FormattingEnabled = True
		Me.ComboBoxTalla.Location = New System.Drawing.Point(102, 157)
		Me.ComboBoxTalla.Name = "ComboBoxTalla"
		Me.ComboBoxTalla.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxTalla.TabIndex = 47
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.Silver
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(11, 12)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(114, 25)
		Me.Panel3.TabIndex = 33
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
		'ComboBoxEspecie
		'
		Me.ComboBoxEspecie.FormattingEnabled = True
		Me.ComboBoxEspecie.Location = New System.Drawing.Point(102, 48)
		Me.ComboBoxEspecie.Name = "ComboBoxEspecie"
		Me.ComboBoxEspecie.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxEspecie.TabIndex = 46
		'
		'ComboBoxRaza
		'
		Me.ComboBoxRaza.FormattingEnabled = True
		Me.ComboBoxRaza.Location = New System.Drawing.Point(102, 81)
		Me.ComboBoxRaza.Name = "ComboBoxRaza"
		Me.ComboBoxRaza.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxRaza.TabIndex = 45
		'
		'ComboBoxGenero
		'
		Me.ComboBoxGenero.FormattingEnabled = True
		Me.ComboBoxGenero.Location = New System.Drawing.Point(102, 194)
		Me.ComboBoxGenero.Name = "ComboBoxGenero"
		Me.ComboBoxGenero.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxGenero.TabIndex = 44
		'
		'txtCaracteristicas
		'
		Me.txtCaracteristicas.BackColor = System.Drawing.Color.Silver
		Me.txtCaracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtCaracteristicas.Location = New System.Drawing.Point(104, 299)
		Me.txtCaracteristicas.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCaracteristicas.Multiline = True
		Me.txtCaracteristicas.Name = "txtCaracteristicas"
		Me.txtCaracteristicas.Size = New System.Drawing.Size(209, 48)
		Me.txtCaracteristicas.TabIndex = 43
		Me.txtCaracteristicas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtEdad
		'
		Me.txtEdad.BackColor = System.Drawing.Color.Silver
		Me.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtEdad.Location = New System.Drawing.Point(104, 227)
		Me.txtEdad.Margin = New System.Windows.Forms.Padding(2)
		Me.txtEdad.Multiline = True
		Me.txtEdad.Name = "txtEdad"
		Me.txtEdad.Size = New System.Drawing.Size(69, 24)
		Me.txtEdad.TabIndex = 42
		Me.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label9
		'
		Me.Label9.BackColor = System.Drawing.Color.Silver
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label9.Location = New System.Drawing.Point(11, 299)
		Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(83, 24)
		Me.Label9.TabIndex = 41
		Me.Label9.Text = "Características:"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Silver
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label8.Location = New System.Drawing.Point(11, 227)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(67, 24)
		Me.Label8.TabIndex = 40
		Me.Label8.Text = "Edad:"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Silver
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label7.Location = New System.Drawing.Point(12, 191)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(67, 24)
		Me.Label7.TabIndex = 39
		Me.Label7.Text = "Género:"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtPeso
		'
		Me.txtPeso.BackColor = System.Drawing.Color.Silver
		Me.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtPeso.Location = New System.Drawing.Point(102, 116)
		Me.txtPeso.Margin = New System.Windows.Forms.Padding(2)
		Me.txtPeso.Multiline = True
		Me.txtPeso.Name = "txtPeso"
		Me.txtPeso.Size = New System.Drawing.Size(121, 24)
		Me.txtPeso.TabIndex = 38
		Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Silver
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.Location = New System.Drawing.Point(11, 154)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(67, 24)
		Me.Label6.TabIndex = 37
		Me.Label6.Text = "Talla:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Silver
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label5.Location = New System.Drawing.Point(11, 116)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(67, 24)
		Me.Label5.TabIndex = 36
		Me.Label5.Text = "Peso:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Silver
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label4.Location = New System.Drawing.Point(11, 78)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(67, 24)
		Me.Label4.TabIndex = 35
		Me.Label4.Text = "Raza:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Silver
		Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel4.Controls.Add(Me.ComboBox2)
		Me.Panel4.Controls.Add(Me.Label3)
		Me.Panel4.Location = New System.Drawing.Point(11, 44)
		Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(73, 25)
		Me.Panel4.TabIndex = 34
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
		'Registro_de_Mascota
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(962, 624)
		Me.Controls.Add(Me.Panel6)
		Me.Controls.Add(Me.Panel5)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.DataGridViewMascotas)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Registro_de_Mascota"
		Me.Text = "Registro"
		Me.Panel1.ResumeLayout(False)
		CType(Me.DataGridViewMascotas, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel5.ResumeLayout(False)
		Me.Panel5.PerformLayout()
		Me.Panel6.ResumeLayout(False)
		Me.Panel6.PerformLayout()
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
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents DataGridViewMascotas As DataGridView
	Friend WithEvents txtCelular As TextBox
	Friend WithEvents txtNomCliente As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents btnEliminar As Button
	Friend WithEvents btnBuscar As Button
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Label14 As Label
	Friend WithEvents txtApCliente As TextBox
	Friend WithEvents Panel6 As Panel
	Friend WithEvents ComboBoxEstadoReproductivo As ComboBox
	Friend WithEvents Label12 As Label
	Friend WithEvents ComboBoxTalla As ComboBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents txtNomMasc As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents ComboBoxEspecie As ComboBox
	Friend WithEvents ComboBoxRaza As ComboBox
	Friend WithEvents ComboBoxGenero As ComboBox
	Friend WithEvents txtCaracteristicas As TextBox
	Friend WithEvents txtEdad As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents txtPeso As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Panel4 As Panel
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents ComboBoxEdadUnidad As ComboBox
End Class
