<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesCita
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
		Me.lblNombreTutor = New System.Windows.Forms.Label()
		Me.lblApellidoTutor = New System.Windows.Forms.Label()
		Me.lblTelefono = New System.Windows.Forms.Label()
		Me.lblNombreMascota = New System.Windows.Forms.Label()
		Me.lblEspecie = New System.Windows.Forms.Label()
		Me.lblFecha = New System.Windows.Forms.Label()
		Me.lblHora = New System.Windows.Forms.Label()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblNombreTutor
		'
		Me.lblNombreTutor.AutoSize = True
		Me.lblNombreTutor.Location = New System.Drawing.Point(160, 53)
		Me.lblNombreTutor.Name = "lblNombreTutor"
		Me.lblNombreTutor.Size = New System.Drawing.Size(88, 13)
		Me.lblNombreTutor.TabIndex = 0
		Me.lblNombreTutor.Text = """Nombre Tutor: """
		'
		'lblApellidoTutor
		'
		Me.lblApellidoTutor.AutoSize = True
		Me.lblApellidoTutor.Location = New System.Drawing.Point(158, 78)
		Me.lblApellidoTutor.Name = "lblApellidoTutor"
		Me.lblApellidoTutor.Size = New System.Drawing.Size(83, 13)
		Me.lblApellidoTutor.TabIndex = 1
		Me.lblApellidoTutor.Text = """Apellido Tutor: "
		'
		'lblTelefono
		'
		Me.lblTelefono.AutoSize = True
		Me.lblTelefono.Location = New System.Drawing.Point(158, 106)
		Me.lblTelefono.Name = "lblTelefono"
		Me.lblTelefono.Size = New System.Drawing.Size(39, 13)
		Me.lblTelefono.TabIndex = 2
		Me.lblTelefono.Text = "Label3"
		'
		'lblNombreMascota
		'
		Me.lblNombreMascota.AutoSize = True
		Me.lblNombreMascota.Location = New System.Drawing.Point(158, 136)
		Me.lblNombreMascota.Name = "lblNombreMascota"
		Me.lblNombreMascota.Size = New System.Drawing.Size(39, 13)
		Me.lblNombreMascota.TabIndex = 3
		Me.lblNombreMascota.Text = "Label4"
		'
		'lblEspecie
		'
		Me.lblEspecie.AutoSize = True
		Me.lblEspecie.Location = New System.Drawing.Point(158, 161)
		Me.lblEspecie.Name = "lblEspecie"
		Me.lblEspecie.Size = New System.Drawing.Size(39, 13)
		Me.lblEspecie.TabIndex = 4
		Me.lblEspecie.Text = "Label5"
		'
		'lblFecha
		'
		Me.lblFecha.AutoSize = True
		Me.lblFecha.Location = New System.Drawing.Point(158, 185)
		Me.lblFecha.Name = "lblFecha"
		Me.lblFecha.Size = New System.Drawing.Size(39, 13)
		Me.lblFecha.TabIndex = 5
		Me.lblFecha.Text = "Label6"
		'
		'lblHora
		'
		Me.lblHora.AutoSize = True
		Me.lblHora.Location = New System.Drawing.Point(158, 212)
		Me.lblHora.Name = "lblHora"
		Me.lblHora.Size = New System.Drawing.Size(39, 13)
		Me.lblHora.TabIndex = 6
		Me.lblHora.Text = "Label7"
		'
		'btnCerrar
		'
		Me.btnCerrar.Location = New System.Drawing.Point(109, 296)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
		Me.btnCerrar.TabIndex = 7
		Me.btnCerrar.Text = "Button1"
		Me.btnCerrar.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(229, 301)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 8
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'DetallesCita
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.lblHora)
		Me.Controls.Add(Me.lblFecha)
		Me.Controls.Add(Me.lblEspecie)
		Me.Controls.Add(Me.lblNombreMascota)
		Me.Controls.Add(Me.lblTelefono)
		Me.Controls.Add(Me.lblApellidoTutor)
		Me.Controls.Add(Me.lblNombreTutor)
		Me.Name = "DetallesCita"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblNombreTutor As Label
	Friend WithEvents lblApellidoTutor As Label
	Friend WithEvents lblTelefono As Label
	Friend WithEvents lblNombreMascota As Label
	Friend WithEvents lblEspecie As Label
	Friend WithEvents lblFecha As Label
	Friend WithEvents lblHora As Label
	Friend WithEvents btnCerrar As Button
	Friend WithEvents Button2 As Button
End Class
