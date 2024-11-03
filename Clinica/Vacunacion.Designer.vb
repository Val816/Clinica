<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacunacion
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vacunacion))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtObservaciones = New System.Windows.Forms.TextBox()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtTotalPrice = New System.Windows.Forms.TextBox()
		Me.CheckListVaccines = New System.Windows.Forms.CheckedListBox()
		Me.dgvRegistroVacunacion = New System.Windows.Forms.DataGridView()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		CType(Me.dgvRegistroVacunacion, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.PictureBox2)
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, -1)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(838, 93)
		Me.Panel1.TabIndex = 6
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(10, 0)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(60, 52)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 86
		Me.PictureBox2.TabStop = False
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.Black
		Me.Label6.Location = New System.Drawing.Point(1, 54)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(83, 18)
		Me.Label6.TabIndex = 85
		Me.Label6.Text = "VETCARE"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(439, 38)
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
		Me.Label1.Location = New System.Drawing.Point(201, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(201, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Vacunación"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(1, 435)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(854, 87)
		Me.Panel2.TabIndex = 7
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.LightBlue
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Location = New System.Drawing.Point(451, 25)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(172, 14)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(102, 13)
		Me.Label3.TabIndex = 31
		Me.Label3.Text = "Vacuna aplicada"
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(357, 2)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(99, 40)
		Me.Label10.TabIndex = 32
		Me.Label10.Text = "Observaciones:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtObservaciones
		'
		Me.txtObservaciones.BackColor = System.Drawing.Color.White
		Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtObservaciones.Location = New System.Drawing.Point(360, 44)
		Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.txtObservaciones.Multiline = True
		Me.txtObservaciones.Name = "txtObservaciones"
		Me.txtObservaciones.Size = New System.Drawing.Size(161, 78)
		Me.txtObservaciones.TabIndex = 33
		Me.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.Color.White
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(8, 138)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxServicios.TabIndex = 36
		Me.ComboBoxServicios.Text = "Agregar Servicio"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(153, 129)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 39
		Me.PictureBox1.TabStop = False
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.ComboBoxServicios)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Controls.Add(Me.txtTotalPrice)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.PictureBox1)
		Me.Panel3.Controls.Add(Me.Label10)
		Me.Panel3.Controls.Add(Me.txtObservaciones)
		Me.Panel3.Controls.Add(Me.CheckListVaccines)
		Me.Panel3.Location = New System.Drawing.Point(11, 97)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(534, 176)
		Me.Panel3.TabIndex = 40
		'
		'Label4
		'
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(471, 138)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(50, 20)
		Me.Label4.TabIndex = 42
		Me.Label4.Text = "pesos."
		'
		'Label2
		'
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(360, 135)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(49, 20)
		Me.Label2.TabIndex = 41
		Me.Label2.Text = "Costo:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtTotalPrice
		'
		Me.txtTotalPrice.Location = New System.Drawing.Point(414, 136)
		Me.txtTotalPrice.Name = "txtTotalPrice"
		Me.txtTotalPrice.Size = New System.Drawing.Size(55, 20)
		Me.txtTotalPrice.TabIndex = 40
		'
		'CheckListVaccines
		'
		Me.CheckListVaccines.FormattingEnabled = True
		Me.CheckListVaccines.Items.AddRange(New Object() {"Vacuna Puppy", "Vacuna Quintuple", "Vacuna Sextuple", "Vacuna de rabia", "Vacuna triple felina", "Vacuna bordetella", "Vacuna giarda", "Otra"})
		Me.CheckListVaccines.Location = New System.Drawing.Point(172, 34)
		Me.CheckListVaccines.Margin = New System.Windows.Forms.Padding(2)
		Me.CheckListVaccines.Name = "CheckListVaccines"
		Me.CheckListVaccines.Size = New System.Drawing.Size(153, 124)
		Me.CheckListVaccines.TabIndex = 29
		'
		'dgvRegistroVacunacion
		'
		Me.dgvRegistroVacunacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvRegistroVacunacion.Location = New System.Drawing.Point(44, 280)
		Me.dgvRegistroVacunacion.Name = "dgvRegistroVacunacion"
		Me.dgvRegistroVacunacion.Size = New System.Drawing.Size(470, 150)
		Me.dgvRegistroVacunacion.TabIndex = 41
		'
		'Vacunacion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(556, 503)
		Me.Controls.Add(Me.dgvRegistroVacunacion)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Vacunacion"
		Me.Text = "Vacunacion"
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.dgvRegistroVacunacion, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents txtObservaciones As TextBox
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Label6 As Label
	Friend WithEvents CheckListVaccines As CheckedListBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtTotalPrice As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents dgvRegistroVacunacion As DataGridView
End Class
