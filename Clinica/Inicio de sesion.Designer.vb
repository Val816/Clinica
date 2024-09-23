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
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtContraseña = New System.Windows.Forms.TextBox()
		Me.btnIngresar = New System.Windows.Forms.Button()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
		'txtCorreo
		'
		Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCorreo.Location = New System.Drawing.Point(294, 250)
		Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(275, 23)
		Me.txtCorreo.TabIndex = 3
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
		'txtContraseña
		'
		Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtContraseña.Location = New System.Drawing.Point(294, 318)
		Me.txtContraseña.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.txtContraseña.Name = "txtContraseña"
		Me.txtContraseña.Size = New System.Drawing.Size(275, 23)
		Me.txtContraseña.TabIndex = 5
		'
		'btnIngresar
		'
		Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnIngresar.Location = New System.Drawing.Point(294, 369)
		Me.btnIngresar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnIngresar.Name = "btnIngresar"
		Me.btnIngresar.Size = New System.Drawing.Size(274, 28)
		Me.btnIngresar.TabIndex = 6
		Me.btnIngresar.Text = "Ingresar"
		Me.btnIngresar.UseVisualStyleBackColor = False
		'
		'LinkLabel1
		'
		Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.LinkLabel1.Location = New System.Drawing.Point(388, 426)
		Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(94, 13)
		Me.LinkLabel1.TabIndex = 7
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "Recuperar Cuenta"
		'
		'LinkLabel2
		'
		Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.LinkLabel2.AutoSize = True
		Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.LinkLabel2.Location = New System.Drawing.Point(394, 452)
		Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.LinkLabel2.Name = "LinkLabel2"
		Me.LinkLabel2.Size = New System.Drawing.Size(69, 13)
		Me.LinkLabel2.TabIndex = 8
		Me.LinkLabel2.TabStop = True
		Me.LinkLabel2.Text = "Crear Cuenta"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(382, 61)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(71, 117)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 9
		Me.PictureBox1.TabStop = False
		'
		'Inicio_de_sesion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(851, 487)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.LinkLabel2)
		Me.Controls.Add(Me.LinkLabel1)
		Me.Controls.Add(Me.btnIngresar)
		Me.Controls.Add(Me.txtContraseña)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtCorreo)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "Inicio_de_sesion"
		Me.Text = "Inicio_de_sesion"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
