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
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.btnConsulta = New System.Windows.Forms.Button()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.btnMascota = New System.Windows.Forms.Button()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.btnRegistro.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.Panel5.SuspendLayout()
		Me.Panel6.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
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
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(359, 31)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(238, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Menú Principal"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel2.Controls.Add(Me.btnCerrarSistema)
		Me.Panel2.Location = New System.Drawing.Point(-1, 437)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(847, 98)
		Me.Panel2.TabIndex = 1
		'
		'btnCerrarSistema
		'
		Me.btnCerrarSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnCerrarSistema.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnCerrarSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCerrarSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCerrarSistema.Location = New System.Drawing.Point(657, 45)
		Me.btnCerrarSistema.Margin = New System.Windows.Forms.Padding(2)
		Me.btnCerrarSistema.Name = "btnCerrarSistema"
		Me.btnCerrarSistema.Size = New System.Drawing.Size(110, 24)
		Me.btnCerrarSistema.TabIndex = 0
		Me.btnCerrarSistema.Text = "Cerrar Sesión"
		Me.btnCerrarSistema.UseVisualStyleBackColor = False
		'
		'btnRegistro
		'
		Me.btnRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.btnRegistro.Controls.Add(Me.btnRegistroCita)
		Me.btnRegistro.Location = New System.Drawing.Point(179, 112)
		Me.btnRegistro.Margin = New System.Windows.Forms.Padding(2)
		Me.btnRegistro.Name = "btnRegistro"
		Me.btnRegistro.Size = New System.Drawing.Size(133, 294)
		Me.btnRegistro.TabIndex = 2
		'
		'btnRegistroCita
		'
		Me.btnRegistroCita.Location = New System.Drawing.Point(3, 239)
		Me.btnRegistroCita.Name = "btnRegistroCita"
		Me.btnRegistroCita.Size = New System.Drawing.Size(129, 23)
		Me.btnRegistroCita.TabIndex = 7
		Me.btnRegistroCita.Text = "Registro de cita"
		Me.btnRegistroCita.UseVisualStyleBackColor = True
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.Panel4.Controls.Add(Me.btnConsulta)
		Me.Panel4.Location = New System.Drawing.Point(352, 112)
		Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(133, 294)
		Me.Panel4.TabIndex = 3
		'
		'btnConsulta
		'
		Me.btnConsulta.Location = New System.Drawing.Point(28, 239)
		Me.btnConsulta.Name = "btnConsulta"
		Me.btnConsulta.Size = New System.Drawing.Size(75, 23)
		Me.btnConsulta.TabIndex = 9
		Me.btnConsulta.Text = "Consulta"
		Me.btnConsulta.UseVisualStyleBackColor = True
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.Panel5.Controls.Add(Me.btnMascota)
		Me.Panel5.Location = New System.Drawing.Point(11, 111)
		Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(129, 295)
		Me.Panel5.TabIndex = 4
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.Panel6.Controls.Add(Me.Button2)
		Me.Panel6.Location = New System.Drawing.Point(529, 112)
		Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(133, 294)
		Me.Panel6.TabIndex = 5
		'
		'btnMascota
		'
		Me.btnMascota.Location = New System.Drawing.Point(8, 240)
		Me.btnMascota.Name = "btnMascota"
		Me.btnMascota.Size = New System.Drawing.Size(115, 23)
		Me.btnMascota.TabIndex = 6
		Me.btnMascota.Text = "Registro de Mascota"
		Me.btnMascota.UseVisualStyleBackColor = True
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.Panel3.Controls.Add(Me.Button3)
		Me.Panel3.Location = New System.Drawing.Point(699, 112)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(133, 294)
		Me.Panel3.TabIndex = 10
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(36, 239)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 9
		Me.Button2.Text = "Informes"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(36, 239)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 9
		Me.Button3.Text = "Historial"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Menu_Principal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(843, 522)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel6)
		Me.Controls.Add(Me.Panel5)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.btnRegistro)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Menu_Principal"
		Me.Text = "Menu_Principal"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.btnRegistro.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel5.ResumeLayout(False)
		Me.Panel6.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCerrarSistema As Button
    Friend WithEvents btnRegistro As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Panel6 As Panel
	Friend WithEvents btnRegistroCita As Button
	Friend WithEvents btnConsulta As Button
	Friend WithEvents btnMascota As Button
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
End Class
