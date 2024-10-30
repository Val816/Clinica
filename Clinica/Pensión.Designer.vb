<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pensión
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pensión))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TextBox10 = New System.Windows.Forms.TextBox()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		Me.ComboBoxServicio = New System.Windows.Forms.ComboBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, -1)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(862, 90)
		Me.Panel1.TabIndex = 12
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(445, 29)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(112, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(214, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(143, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Pensión"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(-4, 447)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(867, 79)
		Me.Panel2.TabIndex = 13
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.LightBlue
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Location = New System.Drawing.Point(450, 16)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(112, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(2, 8)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(111, 26)
		Me.Label2.TabIndex = 58
		Me.Label2.Text = "Fecha de entrada:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(8, 45)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(105, 26)
		Me.Label3.TabIndex = 59
		Me.Label3.Text = "Fecha de salida:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(334, 192)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(105, 19)
		Me.Label8.TabIndex = 70
		Me.Label8.Text = "Observaciones:"
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(266, 10)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(110, 26)
		Me.Label4.TabIndex = 71
		Me.Label4.Text = "Hora de entrada:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(279, 51)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(93, 26)
		Me.Label5.TabIndex = 72
		Me.Label5.Text = "Hora de salida:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TextBox5
		'
		Me.TextBox5.BackColor = System.Drawing.Color.Silver
		Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox5.Location = New System.Drawing.Point(337, 213)
		Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox5.Multiline = True
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(189, 75)
		Me.TextBox5.TabIndex = 77
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(14, 11)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(85, 24)
		Me.Label12.TabIndex = 78
		Me.Label12.Text = "Costo Diario:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(14, 51)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(85, 24)
		Me.Label6.TabIndex = 79
		Me.Label6.Text = "Costo Total:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBox10
		'
		Me.TextBox10.BackColor = System.Drawing.Color.Silver
		Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox10.Location = New System.Drawing.Point(103, 11)
		Me.TextBox10.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox10.Multiline = True
		Me.TextBox10.Name = "TextBox10"
		Me.TextBox10.Size = New System.Drawing.Size(73, 24)
		Me.TextBox10.TabIndex = 80
		Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBox6
		'
		Me.TextBox6.BackColor = System.Drawing.Color.Silver
		Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox6.Location = New System.Drawing.Point(103, 55)
		Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox6.Multiline = True
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(73, 24)
		Me.TextBox6.TabIndex = 81
		Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ComboBoxServicio
		'
		Me.ComboBoxServicio.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBoxServicio.ForeColor = System.Drawing.Color.White
		Me.ComboBoxServicio.FormattingEnabled = True
		Me.ComboBoxServicio.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicio.Location = New System.Drawing.Point(372, 403)
		Me.ComboBoxServicio.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicio.Name = "ComboBoxServicio"
		Me.ComboBoxServicio.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxServicio.TabIndex = 82
		Me.ComboBoxServicio.Text = "Agregar Servicio"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(56, 212)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(246, 168)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 83
		Me.PictureBox1.TabStop = False
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(115, 14)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(142, 20)
		Me.DateTimePicker1.TabIndex = 84
		'
		'DateTimePicker2
		'
		Me.DateTimePicker2.Location = New System.Drawing.Point(115, 51)
		Me.DateTimePicker2.Name = "DateTimePicker2"
		Me.DateTimePicker2.Size = New System.Drawing.Size(142, 20)
		Me.DateTimePicker2.TabIndex = 85
		'
		'DateTimePicker3
		'
		Me.DateTimePicker3.Location = New System.Drawing.Point(377, 14)
		Me.DateTimePicker3.Name = "DateTimePicker3"
		Me.DateTimePicker3.Size = New System.Drawing.Size(122, 20)
		Me.DateTimePicker3.TabIndex = 86
		'
		'DateTimePicker4
		'
		Me.DateTimePicker4.Location = New System.Drawing.Point(377, 57)
		Me.DateTimePicker4.Name = "DateTimePicker4"
		Me.DateTimePicker4.Size = New System.Drawing.Size(122, 20)
		Me.DateTimePicker4.TabIndex = 87
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.DateTimePicker4)
		Me.Panel3.Controls.Add(Me.DateTimePicker3)
		Me.Panel3.Controls.Add(Me.DateTimePicker2)
		Me.Panel3.Controls.Add(Me.DateTimePicker1)
		Me.Panel3.Controls.Add(Me.Label5)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(27, 94)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(514, 88)
		Me.Panel3.TabIndex = 88
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel4.Controls.Add(Me.TextBox10)
		Me.Panel4.Controls.Add(Me.Label6)
		Me.Panel4.Controls.Add(Me.Label12)
		Me.Panel4.Controls.Add(Me.TextBox6)
		Me.Panel4.Location = New System.Drawing.Point(343, 301)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(183, 88)
		Me.Panel4.TabIndex = 89
		'
		'Pensión
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(569, 504)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.ComboBoxServicio)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Pensión"
		Me.Text = "Pensión"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents TextBox10 As TextBox
	Friend WithEvents TextBox6 As TextBox
	Friend WithEvents ComboBoxServicio As ComboBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents DateTimePicker2 As DateTimePicker
	Friend WithEvents DateTimePicker3 As DateTimePicker
	Friend WithEvents DateTimePicker4 As DateTimePicker
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel4 As Panel
End Class
