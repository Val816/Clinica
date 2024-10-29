<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_Cuenta
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnAtras = New System.Windows.Forms.Button()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtApellidoP = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtApellidoM = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btnContinuar = New System.Windows.Forms.Button()
		Me.txtConfirmarContraseña = New System.Windows.Forms.TextBox()
		Me.txtContraseña = New System.Windows.Forms.TextBox()
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.SteelBlue
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(126, 37)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(183, 37)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Crear Cuenta"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(2, -11)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(855, 88)
		Me.Panel1.TabIndex = 1
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.btnAtras)
		Me.Panel2.Location = New System.Drawing.Point(2, 432)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(855, 86)
		Me.Panel2.TabIndex = 2
		'
		'btnAtras
		'
		Me.btnAtras.BackColor = System.Drawing.Color.LightBlue
		Me.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnAtras.FlatAppearance.BorderSize = 0
		Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAtras.Location = New System.Drawing.Point(305, 20)
		Me.btnAtras.Margin = New System.Windows.Forms.Padding(2)
		Me.btnAtras.Name = "btnAtras"
		Me.btnAtras.Size = New System.Drawing.Size(80, 24)
		Me.btnAtras.TabIndex = 7
		Me.btnAtras.Text = "Atrás"
		Me.btnAtras.UseVisualStyleBackColor = False
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.txtNombre)
		Me.Panel3.Controls.Add(Me.Label7)
		Me.Panel3.Controls.Add(Me.txtApellidoP)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Controls.Add(Me.txtApellidoM)
		Me.Panel3.Controls.Add(Me.Label5)
		Me.Panel3.Controls.Add(Me.btnContinuar)
		Me.Panel3.Controls.Add(Me.txtConfirmarContraseña)
		Me.Panel3.Controls.Add(Me.txtContraseña)
		Me.Panel3.Controls.Add(Me.txtCorreo)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(31, 100)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(377, 312)
		Me.Panel3.TabIndex = 3
		'
		'txtNombre
		'
		Me.txtNombre.BackColor = System.Drawing.Color.White
		Me.txtNombre.Location = New System.Drawing.Point(161, 8)
		Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNombre.Multiline = True
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(193, 29)
		Me.txtNombre.TabIndex = 12
		Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(68, 8)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(78, 29)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Nombre:"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtApellidoP
		'
		Me.txtApellidoP.BackColor = System.Drawing.Color.White
		Me.txtApellidoP.Location = New System.Drawing.Point(161, 46)
		Me.txtApellidoP.Margin = New System.Windows.Forms.Padding(2)
		Me.txtApellidoP.Multiline = True
		Me.txtApellidoP.Name = "txtApellidoP"
		Me.txtApellidoP.Size = New System.Drawing.Size(193, 29)
		Me.txtApellidoP.TabIndex = 10
		Me.txtApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(15, 46)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(131, 29)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Apellido Paterno:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtApellidoM
		'
		Me.txtApellidoM.BackColor = System.Drawing.Color.White
		Me.txtApellidoM.Location = New System.Drawing.Point(161, 87)
		Me.txtApellidoM.Margin = New System.Windows.Forms.Padding(2)
		Me.txtApellidoM.Multiline = True
		Me.txtApellidoM.Name = "txtApellidoM"
		Me.txtApellidoM.Size = New System.Drawing.Size(193, 29)
		Me.txtApellidoM.TabIndex = 8
		Me.txtApellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(15, 87)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(131, 29)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "Apellido Materno:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnContinuar
		'
		Me.btnContinuar.BackColor = System.Drawing.Color.SkyBlue
		Me.btnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnContinuar.FlatAppearance.BorderSize = 0
		Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnContinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnContinuar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.btnContinuar.Location = New System.Drawing.Point(253, 271)
		Me.btnContinuar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnContinuar.Name = "btnContinuar"
		Me.btnContinuar.Size = New System.Drawing.Size(101, 24)
		Me.btnContinuar.TabIndex = 6
		Me.btnContinuar.Text = "Continuar"
		Me.btnContinuar.UseVisualStyleBackColor = False
		'
		'txtConfirmarContraseña
		'
		Me.txtConfirmarContraseña.BackColor = System.Drawing.Color.White
		Me.txtConfirmarContraseña.Location = New System.Drawing.Point(161, 224)
		Me.txtConfirmarContraseña.Margin = New System.Windows.Forms.Padding(2)
		Me.txtConfirmarContraseña.Multiline = True
		Me.txtConfirmarContraseña.Name = "txtConfirmarContraseña"
		Me.txtConfirmarContraseña.Size = New System.Drawing.Size(193, 33)
		Me.txtConfirmarContraseña.TabIndex = 5
		Me.txtConfirmarContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtContraseña
		'
		Me.txtContraseña.BackColor = System.Drawing.Color.White
		Me.txtContraseña.Location = New System.Drawing.Point(161, 180)
		Me.txtContraseña.Margin = New System.Windows.Forms.Padding(2)
		Me.txtContraseña.Multiline = True
		Me.txtContraseña.Name = "txtContraseña"
		Me.txtContraseña.Size = New System.Drawing.Size(193, 33)
		Me.txtContraseña.TabIndex = 4
		Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtCorreo
		'
		Me.txtCorreo.BackColor = System.Drawing.Color.White
		Me.txtCorreo.Location = New System.Drawing.Point(161, 135)
		Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCorreo.Multiline = True
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(193, 29)
		Me.txtCorreo.TabIndex = 3
		Me.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(42, 222)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(104, 32)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "Confirma Contraseña:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(45, 181)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(101, 32)
		Me.Label3.TabIndex = 1
		Me.Label3.Text = "Contraseña:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(15, 126)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(131, 42)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Ingresa tu correo electrónico: "
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Crear_Cuenta
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(435, 487)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Crear_Cuenta"
		Me.Text = "Crea tu Cuenta"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtCorreo As TextBox
	Friend WithEvents txtConfirmarContraseña As TextBox
	Friend WithEvents txtContraseña As TextBox
	Friend WithEvents btnContinuar As Button
	Friend WithEvents btnAtras As Button
	Friend WithEvents txtNombre As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtApellidoP As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents txtApellidoM As TextBox
	Friend WithEvents Label5 As Label
End Class
