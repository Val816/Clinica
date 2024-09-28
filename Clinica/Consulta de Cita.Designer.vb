<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_de_Cita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_de_Cita))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNombreMascota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreTutor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnIrRegistroCita = New System.Windows.Forms.Button()
        Me.dateFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1282, 163)
        Me.Panel1.TabIndex = 2
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(1104, 45)
        Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
        Me.btnMenuPrincipal.Size = New System.Drawing.Size(140, 38)
        Me.btnMenuPrincipal.TabIndex = 1
        Me.btnMenuPrincipal.Text = "Menú Principal"
        Me.btnMenuPrincipal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consulta de Cita"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnContinuar)
        Me.Panel2.Location = New System.Drawing.Point(0, 649)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1282, 156)
        Me.Panel2.TabIndex = 3
        '
        'btnContinuar
        '
        Me.btnContinuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar.Location = New System.Drawing.Point(960, 66)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(261, 38)
        Me.btnContinuar.TabIndex = 9
        Me.btnContinuar.Text = "Continuar a Registro de Mascota"
        Me.btnContinuar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnBuscar)
        Me.Panel3.Controls.Add(Me.txtNombreMascota)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtTelefono)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtNombreTutor)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(38, 222)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(538, 278)
        Me.Panel3.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(183, 218)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(140, 38)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtNombreMascota
        '
        Me.txtNombreMascota.BackColor = System.Drawing.Color.Silver
        Me.txtNombreMascota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreMascota.Location = New System.Drawing.Point(196, 151)
        Me.txtNombreMascota.Multiline = True
        Me.txtNombreMascota.Name = "txtNombreMascota"
        Me.txtNombreMascota.Size = New System.Drawing.Size(314, 42)
        Me.txtNombreMascota.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(21, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 42)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nombre de mascota:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.Silver
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Location = New System.Drawing.Point(196, 95)
        Me.txtTelefono.Multiline = True
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(314, 42)
        Me.txtTelefono.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(21, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 42)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Teléfono:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreTutor
        '
        Me.txtNombreTutor.BackColor = System.Drawing.Color.Silver
        Me.txtNombreTutor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreTutor.Location = New System.Drawing.Point(196, 31)
        Me.txtNombreTutor.Multiline = True
        Me.txtNombreTutor.Name = "txtNombreTutor"
        Me.txtNombreTutor.Size = New System.Drawing.Size(314, 42)
        Me.txtNombreTutor.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(21, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 42)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre de tutor:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnIrRegistroCita)
        Me.Panel4.Controls.Add(Me.dateFecha)
        Me.Panel4.Controls.Add(Me.btnLimpiar)
        Me.Panel4.Controls.Add(Me.btnEliminar)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txtHora)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(682, 222)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(538, 295)
        Me.Panel4.TabIndex = 5
        '
        'btnIrRegistroCita
        '
        Me.btnIrRegistroCita.Location = New System.Drawing.Point(375, 234)
        Me.btnIrRegistroCita.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnIrRegistroCita.Name = "btnIrRegistroCita"
        Me.btnIrRegistroCita.Size = New System.Drawing.Size(112, 35)
        Me.btnIrRegistroCita.TabIndex = 16
        Me.btnIrRegistroCita.Text = "Ir a registro de cita"
        Me.btnIrRegistroCita.UseVisualStyleBackColor = True
        '
        'dateFecha
        '
        Me.dateFecha.Location = New System.Drawing.Point(168, 97)
        Me.dateFecha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dateFecha.Name = "dateFecha"
        Me.dateFecha.Size = New System.Drawing.Size(298, 26)
        Me.dateFecha.TabIndex = 15
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(190, 231)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(177, 38)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limipar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(45, 231)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 38)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar cita"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(40, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 42)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Hora:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.Silver
        Me.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHora.Location = New System.Drawing.Point(33, 162)
        Me.txtHora.Multiline = True
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(477, 42)
        Me.txtHora.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(40, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 42)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fecha:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Silver
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(33, 95)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(477, 42)
        Me.TextBox4.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(122, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(289, 40)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cita Programada"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(106, 515)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(387, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Consulta_de_Cita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 771)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Consulta_de_Cita"
        Me.Text = "Consulta_de_Cita"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnContinuar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreTutor As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreMascota As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents txtHora As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents dateFecha As DateTimePicker
	Friend WithEvents btnIrRegistroCita As Button
End Class
