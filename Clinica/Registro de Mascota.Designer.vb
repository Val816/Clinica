<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_de_Mascota
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
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnGuardarContinuar = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtNomMasc = New System.Windows.Forms.TextBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtEspecie = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtRaza = New System.Windows.Forms.TextBox()
		Me.txtPeso = New System.Windows.Forms.TextBox()
		Me.txtTalla = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtEdad = New System.Windows.Forms.TextBox()
		Me.txtCaracteristicas = New System.Windows.Forms.TextBox()
		Me.ComboBoxServicios = New System.Windows.Forms.ComboBox()
		Me.ComboBoxGenero = New System.Windows.Forms.ComboBox()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel1.Controls.Add(Me.btnCerrar)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, -5)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(845, 105)
		Me.Panel1.TabIndex = 3
		'
		'btnCerrar
		'
		Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCerrar.Location = New System.Drawing.Point(736, 29)
		Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(93, 25)
		Me.btnCerrar.TabIndex = 1
		Me.btnCerrar.Text = "Menú Principal"
		Me.btnCerrar.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(268, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(337, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Registro de Mascota"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel2.Controls.Add(Me.Button1)
		Me.Panel2.Controls.Add(Me.btnGuardarContinuar)
		Me.Panel2.Location = New System.Drawing.Point(1, 437)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(839, 94)
		Me.Panel2.TabIndex = 4
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(561, 37)
		Me.Button1.Margin = New System.Windows.Forms.Padding(2)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(93, 25)
		Me.Button1.TabIndex = 5
		Me.Button1.Text = "Guardar"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'btnGuardarContinuar
		'
		Me.btnGuardarContinuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.btnGuardarContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardarContinuar.Location = New System.Drawing.Point(705, 37)
		Me.btnGuardarContinuar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardarContinuar.Name = "btnGuardarContinuar"
		Me.btnGuardarContinuar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardarContinuar.TabIndex = 6
		Me.btnGuardarContinuar.Text = "Continuar"
		Me.btnGuardarContinuar.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(2, 6)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(106, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Nombre de Mascota:"
		'
		'txtNomMasc
		'
		Me.txtNomMasc.BackColor = System.Drawing.Color.Silver
		Me.txtNomMasc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNomMasc.Location = New System.Drawing.Point(115, 6)
		Me.txtNomMasc.Margin = New System.Windows.Forms.Padding(2)
		Me.txtNomMasc.Name = "txtNomMasc"
		Me.txtNomMasc.Size = New System.Drawing.Size(228, 13)
		Me.txtNomMasc.TabIndex = 6
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.Silver
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Controls.Add(Me.txtNomMasc)
		Me.Panel3.Location = New System.Drawing.Point(30, 129)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(347, 25)
		Me.Panel3.TabIndex = 7
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Silver
		Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel4.Controls.Add(Me.Label3)
		Me.Panel4.Controls.Add(Me.txtEspecie)
		Me.Panel4.Location = New System.Drawing.Point(27, 179)
		Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(347, 25)
		Me.Panel4.TabIndex = 8
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(13, 5)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(48, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Especie:"
		'
		'txtEspecie
		'
		Me.txtEspecie.BackColor = System.Drawing.Color.Silver
		Me.txtEspecie.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtEspecie.Location = New System.Drawing.Point(78, 6)
		Me.txtEspecie.Margin = New System.Windows.Forms.Padding(2)
		Me.txtEspecie.Name = "txtEspecie"
		Me.txtEspecie.Size = New System.Drawing.Size(228, 13)
		Me.txtEspecie.TabIndex = 6
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Silver
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label4.Location = New System.Drawing.Point(33, 240)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(67, 24)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Raza:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Silver
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label5.Location = New System.Drawing.Point(33, 291)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(67, 24)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Peso:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Silver
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.Location = New System.Drawing.Point(33, 336)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(67, 24)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Talla:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtRaza
		'
		Me.txtRaza.BackColor = System.Drawing.Color.Silver
		Me.txtRaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtRaza.Location = New System.Drawing.Point(136, 240)
		Me.txtRaza.Margin = New System.Windows.Forms.Padding(2)
		Me.txtRaza.Multiline = True
		Me.txtRaza.Name = "txtRaza"
		Me.txtRaza.Size = New System.Drawing.Size(229, 24)
		Me.txtRaza.TabIndex = 12
		Me.txtRaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtPeso
		'
		Me.txtPeso.BackColor = System.Drawing.Color.Silver
		Me.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtPeso.Location = New System.Drawing.Point(136, 291)
		Me.txtPeso.Margin = New System.Windows.Forms.Padding(2)
		Me.txtPeso.Multiline = True
		Me.txtPeso.Name = "txtPeso"
		Me.txtPeso.Size = New System.Drawing.Size(229, 24)
		Me.txtPeso.TabIndex = 13
		Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtTalla
		'
		Me.txtTalla.BackColor = System.Drawing.Color.Silver
		Me.txtTalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtTalla.Location = New System.Drawing.Point(136, 340)
		Me.txtTalla.Margin = New System.Windows.Forms.Padding(2)
		Me.txtTalla.Multiline = True
		Me.txtTalla.Name = "txtTalla"
		Me.txtTalla.Size = New System.Drawing.Size(229, 24)
		Me.txtTalla.TabIndex = 14
		Me.txtTalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.Silver
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label7.Location = New System.Drawing.Point(463, 129)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(67, 24)
		Me.Label7.TabIndex = 15
		Me.Label7.Text = "Género:"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Silver
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label8.Location = New System.Drawing.Point(463, 179)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(67, 24)
		Me.Label8.TabIndex = 16
		Me.Label8.Text = "Edad:"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label9
		'
		Me.Label9.BackColor = System.Drawing.Color.Silver
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label9.Location = New System.Drawing.Point(447, 240)
		Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(83, 24)
		Me.Label9.TabIndex = 17
		Me.Label9.Text = "Características:"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtEdad
		'
		Me.txtEdad.BackColor = System.Drawing.Color.Silver
		Me.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtEdad.Location = New System.Drawing.Point(571, 179)
		Me.txtEdad.Margin = New System.Windows.Forms.Padding(2)
		Me.txtEdad.Multiline = True
		Me.txtEdad.Name = "txtEdad"
		Me.txtEdad.Size = New System.Drawing.Size(229, 24)
		Me.txtEdad.TabIndex = 19
		Me.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtCaracteristicas
		'
		Me.txtCaracteristicas.BackColor = System.Drawing.Color.Silver
		Me.txtCaracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtCaracteristicas.Location = New System.Drawing.Point(571, 230)
		Me.txtCaracteristicas.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCaracteristicas.Multiline = True
		Me.txtCaracteristicas.Name = "txtCaracteristicas"
		Me.txtCaracteristicas.Size = New System.Drawing.Size(229, 54)
		Me.txtCaracteristicas.TabIndex = 20
		Me.txtCaracteristicas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ComboBoxServicios
		'
		Me.ComboBoxServicios.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBoxServicios.ForeColor = System.Drawing.Color.White
		Me.ComboBoxServicios.FormattingEnabled = True
		Me.ComboBoxServicios.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Cirugía", "Grooming", "Pensión", "Eutanasia"})
		Me.ComboBoxServicios.Location = New System.Drawing.Point(562, 308)
		Me.ComboBoxServicios.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicios.Name = "ComboBoxServicios"
		Me.ComboBoxServicios.Size = New System.Drawing.Size(113, 21)
		Me.ComboBoxServicios.TabIndex = 21
		Me.ComboBoxServicios.Text = "Servicio"
		'
		'ComboBoxGenero
		'
		Me.ComboBoxGenero.FormattingEnabled = True
		Me.ComboBoxGenero.Location = New System.Drawing.Point(571, 129)
		Me.ComboBoxGenero.Name = "ComboBoxGenero"
		Me.ComboBoxGenero.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxGenero.TabIndex = 22
		'
		'Registro_de_Mascota
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(839, 508)
		Me.Controls.Add(Me.ComboBoxGenero)
		Me.Controls.Add(Me.ComboBoxServicios)
		Me.Controls.Add(Me.txtCaracteristicas)
		Me.Controls.Add(Me.txtEdad)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtTalla)
		Me.Controls.Add(Me.txtPeso)
		Me.Controls.Add(Me.txtRaza)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Registro_de_Mascota"
		Me.Text = "Registro_de_Mascota"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGuardarContinuar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomMasc As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEspecie As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRaza As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtTalla As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
	Friend WithEvents txtEdad As TextBox
	Friend WithEvents txtCaracteristicas As TextBox
	Friend WithEvents ComboBoxServicios As ComboBox
	Friend WithEvents ComboBoxGenero As ComboBox
End Class
