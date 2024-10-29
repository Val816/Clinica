<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_de_Cita
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_de_Cita))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnContinuarRegistroMascota = New System.Windows.Forms.Button()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.btnAgregarCita = New System.Windows.Forms.Button()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.txtNombreMascota = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtHora = New System.Windows.Forms.TextBox()
		Me.txtCelular = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.dgvCitaProgramada = New System.Windows.Forms.DataGridView()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		CType(Me.dgvCitaProgramada, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(855, 94)
		Me.Panel1.TabIndex = 2
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(617, 43)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(127, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(263, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(243, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Consulta de Cita"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.btnContinuarRegistroMascota)
		Me.Panel2.Location = New System.Drawing.Point(0, 422)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(855, 101)
		Me.Panel2.TabIndex = 3
		'
		'btnContinuarRegistroMascota
		'
		Me.btnContinuarRegistroMascota.BackColor = System.Drawing.Color.LightBlue
		Me.btnContinuarRegistroMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnContinuarRegistroMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnContinuarRegistroMascota.Location = New System.Drawing.Point(595, 10)
		Me.btnContinuarRegistroMascota.Margin = New System.Windows.Forms.Padding(2)
		Me.btnContinuarRegistroMascota.Name = "btnContinuarRegistroMascota"
		Me.btnContinuarRegistroMascota.Size = New System.Drawing.Size(159, 44)
		Me.btnContinuarRegistroMascota.TabIndex = 9
		Me.btnContinuarRegistroMascota.Text = "Continuar a Registro de Mascota"
		Me.btnContinuarRegistroMascota.UseVisualStyleBackColor = False
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.btnAgregarCita)
		Me.Panel3.Controls.Add(Me.btnBuscar)
		Me.Panel3.Controls.Add(Me.dtpFecha)
		Me.Panel3.Controls.Add(Me.btnEliminar)
		Me.Panel3.Controls.Add(Me.txtNombreMascota)
		Me.Panel3.Controls.Add(Me.Label7)
		Me.Panel3.Controls.Add(Me.Label5)
		Me.Panel3.Controls.Add(Me.txtHora)
		Me.Panel3.Controls.Add(Me.txtCelular)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.txtNombre)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(25, 110)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(355, 226)
		Me.Panel3.TabIndex = 4
		'
		'btnAgregarCita
		'
		Me.btnAgregarCita.BackColor = System.Drawing.Color.LightBlue
		Me.btnAgregarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAgregarCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAgregarCita.Location = New System.Drawing.Point(236, 187)
		Me.btnAgregarCita.Name = "btnAgregarCita"
		Me.btnAgregarCita.Size = New System.Drawing.Size(98, 25)
		Me.btnAgregarCita.TabIndex = 17
		Me.btnAgregarCita.Text = "Agregar Cita"
		Me.btnAgregarCita.UseVisualStyleBackColor = False
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.LightBlue
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBuscar.Location = New System.Drawing.Point(17, 187)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(93, 25)
		Me.btnBuscar.TabIndex = 12
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'dtpFecha
		'
		Me.dtpFecha.Location = New System.Drawing.Point(148, 121)
		Me.dtpFecha.Name = "dtpFecha"
		Me.dtpFecha.Size = New System.Drawing.Size(168, 20)
		Me.dtpFecha.TabIndex = 15
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.LightBlue
		Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEliminar.Location = New System.Drawing.Point(128, 187)
		Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(93, 25)
		Me.btnEliminar.TabIndex = 14
		Me.btnEliminar.Text = "Eliminar cita"
		Me.btnEliminar.UseVisualStyleBackColor = False
		'
		'txtNombreMascota
		'
		Me.txtNombreMascota.BackColor = System.Drawing.Color.White
		Me.txtNombreMascota.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNombreMascota.Location = New System.Drawing.Point(148, 79)
		Me.txtNombreMascota.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNombreMascota.Multiline = True
		Me.txtNombreMascota.Name = "txtNombreMascota"
		Me.txtNombreMascota.Size = New System.Drawing.Size(168, 27)
		Me.txtNombreMascota.TabIndex = 11
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(97, 146)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(47, 27)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Hora:"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(14, 79)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(125, 27)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Nombre de mascota:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtHora
		'
		Me.txtHora.BackColor = System.Drawing.Color.White
		Me.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtHora.Location = New System.Drawing.Point(148, 146)
		Me.txtHora.Margin = New System.Windows.Forms.Padding(2)
		Me.txtHora.Multiline = True
		Me.txtHora.Name = "txtHora"
		Me.txtHora.Size = New System.Drawing.Size(93, 27)
		Me.txtHora.TabIndex = 10
		'
		'txtCelular
		'
		Me.txtCelular.BackColor = System.Drawing.Color.White
		Me.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCelular.Location = New System.Drawing.Point(148, 48)
		Me.txtCelular.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCelular.Multiline = True
		Me.txtCelular.Name = "txtCelular"
		Me.txtCelular.Size = New System.Drawing.Size(168, 27)
		Me.txtCelular.TabIndex = 9
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(89, 114)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(55, 27)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Fecha:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(72, 48)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(72, 27)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Teléfono:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtNombre
		'
		Me.txtNombre.BackColor = System.Drawing.Color.White
		Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNombre.Location = New System.Drawing.Point(148, 17)
		Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNombre.Multiline = True
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(168, 27)
		Me.txtNombre.TabIndex = 7
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(32, 17)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(112, 27)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Nombre de tutor:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dgvCitaProgramada
		'
		Me.dgvCitaProgramada.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
		Me.dgvCitaProgramada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvCitaProgramada.Location = New System.Drawing.Point(402, 110)
		Me.dgvCitaProgramada.Name = "dgvCitaProgramada"
		Me.dgvCitaProgramada.Size = New System.Drawing.Size(342, 262)
		Me.dgvCitaProgramada.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(486, 375)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(194, 29)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Cita Programada"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(83, 340)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(258, 83)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 6
		Me.PictureBox1.TabStop = False
		'
		'Consulta_de_Cita
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(765, 487)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.dgvCitaProgramada)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Consulta_de_Cita"
		Me.Text = "Consulta de Cita"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.dgvCitaProgramada, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnContinuarRegistroMascota As Button
    Friend WithEvents Panel3 As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreMascota As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label3 As Label
	Friend WithEvents btnEliminar As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents txtHora As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents dtpFecha As DateTimePicker
	Friend WithEvents btnAgregarCita As Button
	Friend WithEvents dgvCitaProgramada As DataGridView
End Class
