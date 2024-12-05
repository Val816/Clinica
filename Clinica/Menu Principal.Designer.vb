<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Principal))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnCerrarSistema = New System.Windows.Forms.Button()
		Me.btnInformes = New System.Windows.Forms.Button()
		Me.btnConsulta = New System.Windows.Forms.Button()
		Me.btnHistorial = New System.Windows.Forms.Button()
		Me.btnRegistroCita = New System.Windows.Forms.Button()
		Me.cmbServicios = New System.Windows.Forms.ComboBox()
		Me.btnMascota = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnCirugia = New System.Windows.Forms.Button()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.btnPension = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.Panel5.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-1, -11)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(847, 83)
		Me.Panel1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(257, 31)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(238, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Menú Principal"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.btnCerrarSistema)
		Me.Panel2.Location = New System.Drawing.Point(-1, 454)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(847, 81)
		Me.Panel2.TabIndex = 1
		'
		'btnCerrarSistema
		'
		Me.btnCerrarSistema.BackColor = System.Drawing.Color.LightBlue
		Me.btnCerrarSistema.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnCerrarSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCerrarSistema.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCerrarSistema.Location = New System.Drawing.Point(468, 17)
		Me.btnCerrarSistema.Margin = New System.Windows.Forms.Padding(2)
		Me.btnCerrarSistema.Name = "btnCerrarSistema"
		Me.btnCerrarSistema.Size = New System.Drawing.Size(110, 30)
		Me.btnCerrarSistema.TabIndex = 0
		Me.btnCerrarSistema.Text = "Cerrar Sesión"
		Me.btnCerrarSistema.UseVisualStyleBackColor = False
		'
		'btnInformes
		'
		Me.btnInformes.BackColor = System.Drawing.Color.LightBlue
		Me.btnInformes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInformes.Location = New System.Drawing.Point(8, 49)
		Me.btnInformes.Name = "btnInformes"
		Me.btnInformes.Size = New System.Drawing.Size(228, 31)
		Me.btnInformes.TabIndex = 9
		Me.btnInformes.Text = "Informes"
		Me.btnInformes.UseVisualStyleBackColor = False
		'
		'btnConsulta
		'
		Me.btnConsulta.BackColor = System.Drawing.Color.LightBlue
		Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnConsulta.Location = New System.Drawing.Point(9, 12)
		Me.btnConsulta.Name = "btnConsulta"
		Me.btnConsulta.Size = New System.Drawing.Size(228, 31)
		Me.btnConsulta.TabIndex = 9
		Me.btnConsulta.Text = "Consulta de Cita"
		Me.btnConsulta.UseVisualStyleBackColor = False
		'
		'btnHistorial
		'
		Me.btnHistorial.BackColor = System.Drawing.Color.LightBlue
		Me.btnHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnHistorial.Location = New System.Drawing.Point(9, 86)
		Me.btnHistorial.Name = "btnHistorial"
		Me.btnHistorial.Size = New System.Drawing.Size(228, 31)
		Me.btnHistorial.TabIndex = 9
		Me.btnHistorial.Text = "Historial"
		Me.btnHistorial.UseVisualStyleBackColor = False
		'
		'btnRegistroCita
		'
		Me.btnRegistroCita.BackColor = System.Drawing.Color.LightBlue
		Me.btnRegistroCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRegistroCita.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnRegistroCita.Location = New System.Drawing.Point(9, 56)
		Me.btnRegistroCita.Name = "btnRegistroCita"
		Me.btnRegistroCita.Size = New System.Drawing.Size(228, 34)
		Me.btnRegistroCita.TabIndex = 7
		Me.btnRegistroCita.Text = "Registro de cita"
		Me.btnRegistroCita.UseVisualStyleBackColor = False
		'
		'cmbServicios
		'
		Me.cmbServicios.FormattingEnabled = True
		Me.cmbServicios.Location = New System.Drawing.Point(427, 393)
		Me.cmbServicios.Name = "cmbServicios"
		Me.cmbServicios.Size = New System.Drawing.Size(121, 21)
		Me.cmbServicios.TabIndex = 7
		'
		'btnMascota
		'
		Me.btnMascota.BackColor = System.Drawing.Color.LightBlue
		Me.btnMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMascota.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnMascota.Location = New System.Drawing.Point(9, 16)
		Me.btnMascota.Name = "btnMascota"
		Me.btnMascota.Size = New System.Drawing.Size(228, 34)
		Me.btnMascota.TabIndex = 6
		Me.btnMascota.Text = "Registro de Mascota"
		Me.btnMascota.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(359, 110)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(176, 31)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "¡Bienvenido!"
		'
		'btnCirugia
		'
		Me.btnCirugia.BackColor = System.Drawing.Color.LightBlue
		Me.btnCirugia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCirugia.Location = New System.Drawing.Point(9, 51)
		Me.btnCirugia.Name = "btnCirugia"
		Me.btnCirugia.Size = New System.Drawing.Size(228, 34)
		Me.btnCirugia.TabIndex = 10
		Me.btnCirugia.Text = "Cirugía"
		Me.btnCirugia.UseVisualStyleBackColor = False
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.btnMascota)
		Me.Panel3.Controls.Add(Me.btnRegistroCita)
		Me.Panel3.Location = New System.Drawing.Point(11, 77)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(251, 103)
		Me.Panel3.TabIndex = 11
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel4.Controls.Add(Me.btnConsulta)
		Me.Panel4.Controls.Add(Me.btnHistorial)
		Me.Panel4.Controls.Add(Me.btnInformes)
		Me.Panel4.Location = New System.Drawing.Point(12, 199)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(251, 131)
		Me.Panel4.TabIndex = 12
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel5.Controls.Add(Me.btnPension)
		Me.Panel5.Controls.Add(Me.btnCirugia)
		Me.Panel5.Location = New System.Drawing.Point(12, 348)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(250, 93)
		Me.Panel5.TabIndex = 13
		'
		'btnPension
		'
		Me.btnPension.BackColor = System.Drawing.Color.LightBlue
		Me.btnPension.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPension.Location = New System.Drawing.Point(9, 11)
		Me.btnPension.Name = "btnPension"
		Me.btnPension.Size = New System.Drawing.Size(228, 34)
		Me.btnPension.TabIndex = 11
		Me.btnPension.Text = "Pensión"
		Me.btnPension.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(413, 208)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(71, 117)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 15
		Me.PictureBox1.TabStop = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
		Me.Label3.Location = New System.Drawing.Point(375, 165)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(150, 31)
		Me.Label3.TabIndex = 14
		Me.Label3.Text = "VETCARE"
		'
		'Menu_Principal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(597, 522)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Panel5)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.cmbServicios)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Menu_Principal"
		Me.Text = "Menú"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel5.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCerrarSistema As Button
	Friend WithEvents btnRegistroCita As Button
	Friend WithEvents btnConsulta As Button
	Friend WithEvents btnMascota As Button
	Friend WithEvents btnHistorial As Button
	Friend WithEvents cmbServicios As ComboBox
	Friend WithEvents btnInformes As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents btnCirugia As Button
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Panel5 As Panel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents btnPension As Button
End Class
