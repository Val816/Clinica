<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio_de_sesion
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio_de_sesion))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.linkRecuperarCuenta = New System.Windows.Forms.LinkLabel()
		Me.linkCrearCuenta = New System.Windows.Forms.LinkLabel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.txtContraseña = New System.Windows.Forms.TextBox()
		Me.btnIngresar = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Lime
		Me.Label1.Location = New System.Drawing.Point(349, 33)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(143, 31)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "VETCARE"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(339, 180)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(162, 25)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Inicio de sesión"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(291, 226)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(124, 17)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Correo electrónico"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(291, 294)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(81, 17)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "Contraseña"
		'
		'linkRecuperarCuenta
		'
		Me.linkRecuperarCuenta.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.linkRecuperarCuenta.AutoSize = True
		Me.linkRecuperarCuenta.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.linkRecuperarCuenta.Location = New System.Drawing.Point(388, 426)
		Me.linkRecuperarCuenta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.linkRecuperarCuenta.Name = "linkRecuperarCuenta"
		Me.linkRecuperarCuenta.Size = New System.Drawing.Size(94, 13)
		Me.linkRecuperarCuenta.TabIndex = 7
		Me.linkRecuperarCuenta.TabStop = True
		Me.linkRecuperarCuenta.Text = "Recuperar Cuenta"
		'
		'linkCrearCuenta
		'
		Me.linkCrearCuenta.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.linkCrearCuenta.AutoSize = True
		Me.linkCrearCuenta.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.linkCrearCuenta.Location = New System.Drawing.Point(394, 452)
		Me.linkCrearCuenta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.linkCrearCuenta.Name = "linkCrearCuenta"
		Me.linkCrearCuenta.Size = New System.Drawing.Size(69, 13)
		Me.linkCrearCuenta.TabIndex = 8
		Me.linkCrearCuenta.TabStop = True
		Me.linkCrearCuenta.Text = "Crear Cuenta"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(382, 61)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(71, 117)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 9
		Me.PictureBox1.TabStop = False
		'
		'txtCorreo
		'
		Me.txtCorreo.Location = New System.Drawing.Point(294, 258)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(274, 20)
		Me.txtCorreo.TabIndex = 10
		'
		'txtContraseña
		'
		Me.txtContraseña.Location = New System.Drawing.Point(294, 330)
		Me.txtContraseña.Name = "txtContraseña"
		Me.txtContraseña.Size = New System.Drawing.Size(274, 20)
		Me.txtContraseña.TabIndex = 10
		'
		'btnIngresar
		'
		Me.btnIngresar.Location = New System.Drawing.Point(317, 379)
		Me.btnIngresar.Name = "btnIngresar"
		Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
		Me.btnIngresar.TabIndex = 12
		Me.btnIngresar.Text = "Ingresar"
		Me.btnIngresar.UseVisualStyleBackColor = True
		'
		'btnSalir
		'
		Me.btnSalir.Location = New System.Drawing.Point(446, 379)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(75, 23)
		Me.btnSalir.TabIndex = 13
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.UseVisualStyleBackColor = True
		'
		'Inicio_de_sesion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(822, 501)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.btnIngresar)
		Me.Controls.Add(Me.txtContraseña)
		Me.Controls.Add(Me.txtCorreo)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.linkCrearCuenta)
		Me.Controls.Add(Me.linkRecuperarCuenta)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Inicio_de_sesion"
		Me.Text = "Inicio_de_sesion"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents linkRecuperarCuenta As LinkLabel
	Friend WithEvents linkCrearCuenta As LinkLabel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents txtCorreo As TextBox
	Friend WithEvents txtContraseña As TextBox
	Friend WithEvents btnIngresar As Button
	Friend WithEvents btnSalir As Button
End Class
