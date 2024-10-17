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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnCerrarSistema = New System.Windows.Forms.Button()
		Me.btnRegistro = New System.Windows.Forms.Panel()
		Me.btnRegistroCita = New System.Windows.Forms.Button()
		Me.btnConsulta = New System.Windows.Forms.Button()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.cmbServicios = New System.Windows.Forms.ComboBox()
		Me.btnMascota = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.btnRegistro.SuspendLayout()
		Me.Panel5.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-1, 8)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(847, 98)
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
		Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
		Me.Panel2.Controls.Add(Me.btnCerrarSistema)
		Me.Panel2.Location = New System.Drawing.Point(-1, 437)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(847, 98)
		Me.Panel2.TabIndex = 1
		'
		'btnCerrarSistema
		'
		Me.btnCerrarSistema.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnCerrarSistema.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnCerrarSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCerrarSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCerrarSistema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.btnCerrarSistema.Location = New System.Drawing.Point(478, 37)
		Me.btnCerrarSistema.Margin = New System.Windows.Forms.Padding(2)
		Me.btnCerrarSistema.Name = "btnCerrarSistema"
		Me.btnCerrarSistema.Size = New System.Drawing.Size(110, 24)
		Me.btnCerrarSistema.TabIndex = 0
		Me.btnCerrarSistema.Text = "Cerrar Sesión"
		Me.btnCerrarSistema.UseVisualStyleBackColor = False
		'
		'btnRegistro
		'
		Me.btnRegistro.BackColor = System.Drawing.Color.Silver
		Me.btnRegistro.Controls.Add(Me.Button2)
		Me.btnRegistro.Controls.Add(Me.btnConsulta)
		Me.btnRegistro.Controls.Add(Me.Button3)
		Me.btnRegistro.Location = New System.Drawing.Point(454, 124)
		Me.btnRegistro.Margin = New System.Windows.Forms.Padding(2)
		Me.btnRegistro.Name = "btnRegistro"
		Me.btnRegistro.Size = New System.Drawing.Size(133, 295)
		Me.btnRegistro.TabIndex = 2
		'
		'btnRegistroCita
		'
		Me.btnRegistroCita.Location = New System.Drawing.Point(8, 70)
		Me.btnRegistroCita.Name = "btnRegistroCita"
		Me.btnRegistroCita.Size = New System.Drawing.Size(105, 23)
		Me.btnRegistroCita.TabIndex = 7
		Me.btnRegistroCita.Text = "Registro de cita"
		Me.btnRegistroCita.UseVisualStyleBackColor = True
		'
		'btnConsulta
		'
		Me.btnConsulta.Location = New System.Drawing.Point(36, 259)
		Me.btnConsulta.Name = "btnConsulta"
		Me.btnConsulta.Size = New System.Drawing.Size(75, 23)
		Me.btnConsulta.TabIndex = 9
		Me.btnConsulta.Text = "Consulta"
		Me.btnConsulta.UseVisualStyleBackColor = True
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.Silver
		Me.Panel5.Controls.Add(Me.btnRegistroCita)
		Me.Panel5.Controls.Add(Me.cmbServicios)
		Me.Panel5.Controls.Add(Me.btnMascota)
		Me.Panel5.Location = New System.Drawing.Point(51, 124)
		Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(129, 295)
		Me.Panel5.TabIndex = 4
		'
		'cmbServicios
		'
		Me.cmbServicios.FormattingEnabled = True
		Me.cmbServicios.Location = New System.Drawing.Point(3, 166)
		Me.cmbServicios.Name = "cmbServicios"
		Me.cmbServicios.Size = New System.Drawing.Size(121, 21)
		Me.cmbServicios.TabIndex = 7
		'
		'btnMascota
		'
		Me.btnMascota.BackColor = System.Drawing.Color.LightSlateGray
		Me.btnMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMascota.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btnMascota.Location = New System.Drawing.Point(8, 259)
		Me.btnMascota.Name = "btnMascota"
		Me.btnMascota.Size = New System.Drawing.Size(115, 23)
		Me.btnMascota.TabIndex = 6
		Me.btnMascota.Text = "Registro de Mascota"
		Me.btnMascota.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(36, 164)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 9
		Me.Button3.Text = "Historial"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(36, 70)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 9
		Me.Button2.Text = "Informes"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(228, 233)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(176, 31)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "¡Bienvenido!"
		'
		'Menu_Principal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(630, 522)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Panel5)
		Me.Controls.Add(Me.btnRegistro)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Menu_Principal"
		Me.Text = "Menú"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.btnRegistro.ResumeLayout(False)
		Me.Panel5.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCerrarSistema As Button
    Friend WithEvents btnRegistro As Panel
	Friend WithEvents Panel5 As Panel
	Friend WithEvents btnRegistroCita As Button
	Friend WithEvents btnConsulta As Button
	Friend WithEvents btnMascota As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents cmbServicios As ComboBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Label2 As Label
End Class
