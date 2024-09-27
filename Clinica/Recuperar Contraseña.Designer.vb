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
		Me.txtNuevaContrasena = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtConfirmarContrasena = New System.Windows.Forms.TextBox()
		Me.btnIngresar = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Lime
		Me.Label1.Location = New System.Drawing.Point(337, 18)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(143, 31)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "VETCARE"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(371, 59)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
		Me.Label3.Location = New System.Drawing.Point(260, 226)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(124, 17)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "Correo electrónico"
		'
		'txtCorreo
		'
		Me.txtCorreo.Location = New System.Drawing.Point(263, 255)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(274, 20)
		Me.txtCorreo.TabIndex = 12
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(260, 297)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(128, 17)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "Nueva contraseña:"
		'
		'txtNuevaContrasena
		'
		Me.txtNuevaContrasena.Location = New System.Drawing.Point(263, 325)
		Me.txtNuevaContrasena.Name = "txtNuevaContrasena"
		Me.txtNuevaContrasena.Size = New System.Drawing.Size(274, 20)
		Me.txtNuevaContrasena.TabIndex = 14
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(260, 367)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(143, 17)
		Me.Label4.TabIndex = 15
		Me.Label4.Text = "Confirma contraseña:"
		'
		'txtConfirmarContrasena
		'
		Me.txtConfirmarContrasena.Location = New System.Drawing.Point(263, 392)
		Me.txtConfirmarContrasena.Name = "txtConfirmarContrasena"
		Me.txtConfirmarContrasena.Size = New System.Drawing.Size(274, 20)
		Me.txtConfirmarContrasena.TabIndex = 16
		'
		'btnIngresar
		'
		Me.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btnIngresar.Location = New System.Drawing.Point(367, 432)
		Me.btnIngresar.Name = "btnIngresar"
		Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
		Me.btnIngresar.TabIndex = 17
		Me.btnIngresar.Text = "Ingresar"
		Me.btnIngresar.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(315, 188)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(187, 25)
		Me.Label5.TabIndex = 18
		Me.Label5.Text = "Recuperar Cuenta"
		'
		'Recuperar_Contraseña
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(849, 487)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.btnIngresar)
		Me.Controls.Add(Me.txtConfirmarContrasena)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtNuevaContrasena)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtCorreo)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents txtNuevaContrasena As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfirmarContrasena As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label5 As Label
End Class
