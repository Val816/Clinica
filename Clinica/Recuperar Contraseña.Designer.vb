<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recuperar_Contraseña
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recuperar_Contraseña))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtNuevaContraseña = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtConfirmaContraseña = New System.Windows.Forms.TextBox()
		Me.btnCambiarContraseña = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btnRegresar = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Lime
		Me.Label1.Location = New System.Drawing.Point(260, 18)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(143, 31)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "VETCARE"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(294, 59)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(71, 117)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 10
		Me.PictureBox1.TabStop = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(183, 226)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(124, 17)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "Correo electrónico"
		'
		'txtCorreo
		'
		Me.txtCorreo.Location = New System.Drawing.Point(186, 255)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(274, 20)
		Me.txtCorreo.TabIndex = 12
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(183, 297)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(128, 17)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "Nueva contraseña:"
		'
		'txtNuevaContraseña
		'
		Me.txtNuevaContraseña.Location = New System.Drawing.Point(186, 325)
		Me.txtNuevaContraseña.Name = "txtNuevaContraseña"
		Me.txtNuevaContraseña.Size = New System.Drawing.Size(274, 20)
		Me.txtNuevaContraseña.TabIndex = 14
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(183, 367)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(143, 17)
		Me.Label4.TabIndex = 15
		Me.Label4.Text = "Confirma contraseña:"
		'
		'txtConfirmaContraseña
		'
		Me.txtConfirmaContraseña.Location = New System.Drawing.Point(186, 392)
		Me.txtConfirmaContraseña.Name = "txtConfirmaContraseña"
		Me.txtConfirmaContraseña.Size = New System.Drawing.Size(274, 20)
		Me.txtConfirmaContraseña.TabIndex = 16
		'
		'btnCambiarContraseña
		'
		Me.btnCambiarContraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.btnCambiarContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btnCambiarContraseña.Location = New System.Drawing.Point(218, 433)
		Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
		Me.btnCambiarContraseña.Size = New System.Drawing.Size(75, 23)
		Me.btnCambiarContraseña.TabIndex = 17
		Me.btnCambiarContraseña.Text = "Ingresar"
		Me.btnCambiarContraseña.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(238, 188)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(187, 25)
		Me.Label5.TabIndex = 18
		Me.Label5.Text = "Recuperar Cuenta"
		'
		'btnRegresar
		'
		Me.btnRegresar.Location = New System.Drawing.Point(337, 433)
		Me.btnRegresar.Name = "btnRegresar"
		Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
		Me.btnRegresar.TabIndex = 19
		Me.btnRegresar.Text = "Regresar"
		Me.btnRegresar.UseVisualStyleBackColor = True
		'
		'Recuperar_Contraseña
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(647, 489)
		Me.Controls.Add(Me.btnRegresar)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.btnCambiarContraseña)
		Me.Controls.Add(Me.txtConfirmaContraseña)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtNuevaContraseña)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtCorreo)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Recuperar_Contraseña"
		Me.Text = "Recuperar_Contraseña"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNuevaContraseña As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfirmaContraseña As TextBox
    Friend WithEvents btnCambiarContraseña As Button
    Friend WithEvents Label5 As Label
	Friend WithEvents btnRegresar As Button
End Class
