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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.ComboBoxEdadUnidad = New System.Windows.Forms.ComboBox()
		Me.txtNomMasc = New System.Windows.Forms.TextBox()
		Me.ComboBoxEstadoReproductivo = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.ComboBoxTalla = New System.Windows.Forms.ComboBox()
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
		Me.Panel1.SuspendLayout()
		CType(Me.DataGridViewMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel5.SuspendLayout()
		Me.Panel6.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, -5)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(964, 74)
		Me.Panel1.TabIndex = 3
		Me.Panel1.UseWaitCursor = True
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.AutoSize = True
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(737, 33)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(103, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		Me.btnMenuPrincipal.UseWaitCursor = True
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(295, 14)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(321, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Registro de Mascotas"
		Me.Label1.UseWaitCursor = True
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Location = New System.Drawing.Point(1, 575)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(964, 55)
		Me.Panel2.TabIndex = 4
		Me.Panel2.UseWaitCursor = True
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.LightBlue
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnGuardar.Location = New System.Drawing.Point(740, 513)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		Me.btnGuardar.UseWaitCursor = True
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Cirugía", "Grooming", "Pensión", "Eutanasia"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(721, 549)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(113, 21)
		Me.ComboBoxServicios.TabIndex = 21
		Me.ComboBoxServicios.UseWaitCursor = True
		'
		'DataGridViewMascotas
		'
		Me.DataGridViewMascotas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.DataGridViewMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridViewMascotas.GridColor = System.Drawing.Color.AliceBlue
		Me.DataGridViewMascotas.Location = New System.Drawing.Point(375, 85)
		Me.DataGridViewMascotas.Name = "DataGridViewMascotas"
		Me.DataGridViewMascotas.Size = New System.Drawing.Size(458, 422)
		Me.DataGridViewMascotas.TabIndex = 25
		Me.DataGridViewMascotas.UseWaitCursor = True
		'
		'txtCelular
		'
		Me.txtCelular.BackColor = System.Drawing.Color.White
		Me.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCelular.Location = New System.Drawing.Point(140, 91)
		Me.txtCelular.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCelular.Multiline = True
		Me.txtCelular.Name = "txtCelular"
		Me.txtCelular.Size = New System.Drawing.Size(173, 27)
		Me.txtCelular.TabIndex = 30
		Me.txtCelular.UseWaitCursor = True
		'
		'txtNomCliente
		'
		Me.txtNomCliente.BackColor = System.Drawing.Color.White
		Me.txtNomCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNomCliente.Location = New System.Drawing.Point(140, 11)
		Me.txtNomCliente.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNomCliente.Multiline = True
		Me.txtNomCliente.Name = "txtNomCliente"
		Me.txtNomCliente.Size = New System.Drawing.Size(173, 27)
		Me.txtNomCliente.TabIndex = 29
		Me.txtNomCliente.UseWaitCursor = True
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(67, 91)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(70, 27)
		Me.Label10.TabIndex = 28
		Me.Label10.Text = "Teléfono:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label10.UseWaitCursor = True
		'
		'Label11
		'
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(14, 11)
		Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(123, 27)
		Me.Label11.TabIndex = 27
		Me.Label11.Text = "Nombre de tutor:"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label11.UseWaitCursor = True
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.ForeColor = System.Drawing.Color.Black
		Me.Label13.Location = New System.Drawing.Point(587, 552)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(129, 15)
		Me.Label13.TabIndex = 33
		Me.Label13.Text = "Agrega un servicio:"
		Me.Label13.UseWaitCursor = True
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.LightBlue
		Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnEliminar.Location = New System.Drawing.Point(579, 513)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 25)
		Me.btnEliminar.TabIndex = 34
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = False
		Me.btnEliminar.UseWaitCursor = True
		'
		'btnBuscar
		'
		Me.btnBuscar.AutoSize = True
		Me.btnBuscar.BackColor = System.Drawing.Color.LightBlue
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBuscar.Location = New System.Drawing.Point(660, 513)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(75, 25)
		Me.btnBuscar.TabIndex = 35
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = False
		Me.btnBuscar.UseWaitCursor = True
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.LightSteelBlue
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
		Me.Panel5.UseWaitCursor = True
		'
		'Label14
		'
		Me.Label14.BackColor = System.Drawing.Color.Transparent
		Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(15, 56)
		Me.Label14.Name = "Label14"
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.Size = New System.Drawing.Size(122, 22)
		Me.Label14.TabIndex = 32
		Me.Label14.Text = "Apellido del tutor:"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label14.UseWaitCursor = True
		'
		'txtApCliente
		'
		Me.txtApCliente.BackColor = System.Drawing.Color.White
		Me.txtApCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtApCliente.Location = New System.Drawing.Point(140, 56)
		Me.txtApCliente.Multiline = True
		Me.txtApCliente.Name = "txtApCliente"
		Me.txtApCliente.Size = New System.Drawing.Size(173, 20)
		Me.txtApCliente.TabIndex = 31
		Me.txtApCliente.UseWaitCursor = True
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel6.Controls.Add(Me.Label2)
		Me.Panel6.Controls.Add(Me.Label3)
		Me.Panel6.Controls.Add(Me.ComboBoxEdadUnidad)
		Me.Panel6.Controls.Add(Me.txtNomMasc)
		Me.Panel6.Controls.Add(Me.ComboBoxEstadoReproductivo)
		Me.Panel6.Controls.Add(Me.Label12)
		Me.Panel6.Controls.Add(Me.ComboBoxTalla)
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
		Me.Panel6.Location = New System.Drawing.Point(28, 213)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(329, 352)
		Me.Panel6.TabIndex = 37
		Me.Panel6.UseWaitCursor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(14, 10)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(140, 15)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Nombre de Mascota:"
		Me.Label2.UseWaitCursor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(35, 37)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(62, 15)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Especie:"
		Me.Label3.UseWaitCursor = True
		'
		'ComboBoxEdadUnidad
		'
		Me.ComboBoxEdadUnidad.FormattingEnabled = True
		Me.ComboBoxEdadUnidad.Location = New System.Drawing.Point(178, 199)
		Me.ComboBoxEdadUnidad.Name = "ComboBoxEdadUnidad"
		Me.ComboBoxEdadUnidad.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxEdadUnidad.TabIndex = 50
		Me.ComboBoxEdadUnidad.UseWaitCursor = True
		'
		'txtNomMasc
		'
		Me.txtNomMasc.BackColor = System.Drawing.Color.White
		Me.txtNomMasc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtNomMasc.Location = New System.Drawing.Point(158, 10)
		Me.txtNomMasc.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNomMasc.Name = "txtNomMasc"
		Me.txtNomMasc.Size = New System.Drawing.Size(133, 20)
		Me.txtNomMasc.TabIndex = 6
		Me.txtNomMasc.UseWaitCursor = True
		'
		'ComboBoxEstadoReproductivo
		'
		Me.ComboBoxEstadoReproductivo.FormattingEnabled = True
		Me.ComboBoxEstadoReproductivo.Location = New System.Drawing.Point(158, 230)
		Me.ComboBoxEstadoReproductivo.Name = "ComboBoxEstadoReproductivo"
		Me.ComboBoxEstadoReproductivo.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxEstadoReproductivo.TabIndex = 49
		Me.ComboBoxEstadoReproductivo.UseWaitCursor = True
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(11, 221)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(143, 34)
		Me.Label12.TabIndex = 48
		Me.Label12.Text = "Estado Reproductivo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label12.UseWaitCursor = True
		'
		'ComboBoxTalla
		'
		Me.ComboBoxTalla.FormattingEnabled = True
		Me.ComboBoxTalla.Location = New System.Drawing.Point(102, 133)
		Me.ComboBoxTalla.Name = "ComboBoxTalla"
		Me.ComboBoxTalla.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxTalla.TabIndex = 47
		Me.ComboBoxTalla.UseWaitCursor = True
		'
		'ComboBoxEspecie
		'
		Me.ComboBoxEspecie.FormattingEnabled = True
		Me.ComboBoxEspecie.Location = New System.Drawing.Point(102, 36)
		Me.ComboBoxEspecie.Name = "ComboBoxEspecie"
		Me.ComboBoxEspecie.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxEspecie.TabIndex = 46
		Me.ComboBoxEspecie.UseWaitCursor = True
		'
		'ComboBoxRaza
		'
		Me.ComboBoxRaza.FormattingEnabled = True
		Me.ComboBoxRaza.Location = New System.Drawing.Point(102, 67)
		Me.ComboBoxRaza.Name = "ComboBoxRaza"
		Me.ComboBoxRaza.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxRaza.TabIndex = 45
		Me.ComboBoxRaza.UseWaitCursor = True
		'
		'ComboBoxGenero
		'
		Me.ComboBoxGenero.FormattingEnabled = True
		Me.ComboBoxGenero.Location = New System.Drawing.Point(102, 167)
		Me.ComboBoxGenero.Name = "ComboBoxGenero"
		Me.ComboBoxGenero.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxGenero.TabIndex = 44
		Me.ComboBoxGenero.UseWaitCursor = True
		'
		'txtCaracteristicas
		'
		Me.txtCaracteristicas.BackColor = System.Drawing.Color.White
		Me.txtCaracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtCaracteristicas.Location = New System.Drawing.Point(110, 266)
		Me.txtCaracteristicas.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCaracteristicas.Multiline = True
		Me.txtCaracteristicas.Name = "txtCaracteristicas"
		Me.txtCaracteristicas.Size = New System.Drawing.Size(209, 80)
		Me.txtCaracteristicas.TabIndex = 43
		Me.txtCaracteristicas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtCaracteristicas.UseWaitCursor = True
		'
		'txtEdad
		'
		Me.txtEdad.BackColor = System.Drawing.Color.White
		Me.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtEdad.Location = New System.Drawing.Point(102, 196)
		Me.txtEdad.Margin = New System.Windows.Forms.Padding(2)
		Me.txtEdad.Multiline = True
		Me.txtEdad.Name = "txtEdad"
		Me.txtEdad.Size = New System.Drawing.Size(69, 24)
		Me.txtEdad.TabIndex = 42
		Me.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtEdad.UseWaitCursor = True
		'
		'Label9
		'
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(2, 266)
		Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(111, 24)
		Me.Label9.TabIndex = 41
		Me.Label9.Text = "Características:"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label9.UseWaitCursor = True
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(44, 195)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(67, 24)
		Me.Label8.TabIndex = 40
		Me.Label8.Text = "Edad:"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label8.UseWaitCursor = True
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(36, 163)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(67, 24)
		Me.Label7.TabIndex = 39
		Me.Label7.Text = "Género:"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label7.UseWaitCursor = True
		'
		'txtPeso
		'
		Me.txtPeso.BackColor = System.Drawing.Color.White
		Me.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtPeso.Location = New System.Drawing.Point(102, 98)
		Me.txtPeso.Margin = New System.Windows.Forms.Padding(2)
		Me.txtPeso.Multiline = True
		Me.txtPeso.Name = "txtPeso"
		Me.txtPeso.Size = New System.Drawing.Size(121, 24)
		Me.txtPeso.TabIndex = 38
		Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtPeso.UseWaitCursor = True
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(49, 133)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(54, 24)
		Me.Label6.TabIndex = 37
		Me.Label6.Text = "Talla:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label6.UseWaitCursor = True
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(41, 98)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(67, 24)
		Me.Label5.TabIndex = 36
		Me.Label5.Text = "Peso:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label5.UseWaitCursor = True
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(42, 64)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 24)
		Me.Label4.TabIndex = 35
		Me.Label4.Text = "Raza:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label4.UseWaitCursor = True
		'
		'Registro_de_Mascota
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(853, 624)
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
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Registro_de_Mascota"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Registro"
		Me.UseWaitCursor = True
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.DataGridViewMascotas, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel5.ResumeLayout(False)
		Me.Panel5.PerformLayout()
		Me.Panel6.ResumeLayout(False)
		Me.Panel6.PerformLayout()
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
	Friend WithEvents Label3 As Label
	Friend WithEvents ComboBoxEdadUnidad As ComboBox
End Class
