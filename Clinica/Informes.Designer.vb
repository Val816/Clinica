<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.ComboBoxServicio = New System.Windows.Forms.ComboBox()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.K = New System.Windows.Forms.ComboBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(0, -3)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(841, 89)
		Me.Panel1.TabIndex = 15
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(628, 43)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(105, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(311, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(137, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Informes"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Location = New System.Drawing.Point(0, 436)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(841, 95)
		Me.Panel2.TabIndex = 84
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(14, 8)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(67, 22)
		Me.Label3.TabIndex = 85
		Me.Label3.Text = "Desde:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(14, 43)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(62, 22)
		Me.Label4.TabIndex = 95
		Me.Label4.Text = "Hasta:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(15, 3)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(92, 22)
		Me.Label6.TabIndex = 98
		Me.Label6.Text = "Filtrar por:"
		'
		'ComboBoxServicio
		'
		Me.ComboBoxServicio.BackColor = System.Drawing.Color.White
		Me.ComboBoxServicio.ForeColor = System.Drawing.Color.Black
		Me.ComboBoxServicio.FormattingEnabled = True
		Me.ComboBoxServicio.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicio.Location = New System.Drawing.Point(11, 50)
		Me.ComboBoxServicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.ComboBoxServicio.Name = "ComboBoxServicio"
		Me.ComboBoxServicio.Size = New System.Drawing.Size(101, 21)
		Me.ComboBoxServicio.TabIndex = 99
		Me.ComboBoxServicio.Text = "Servicio"
		'
		'ComboBox1
		'
		Me.ComboBox1.BackColor = System.Drawing.Color.White
		Me.ComboBox1.ForeColor = System.Drawing.Color.Black
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBox1.Location = New System.Drawing.Point(11, 75)
		Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(101, 21)
		Me.ComboBox1.TabIndex = 100
		Me.ComboBox1.Text = "Especie"
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Location = New System.Drawing.Point(129, 24)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 101
		Me.btnGuardar.Text = "Aceptar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(48, 217)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(61, 17)
		Me.Label7.TabIndex = 102
		Me.Label7.Text = "Mascota"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(189, 217)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(58, 17)
		Me.Label8.TabIndex = 103
		Me.Label8.Text = "Especie"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(331, 217)
		Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(42, 17)
		Me.Label9.TabIndex = 104
		Me.Label9.Text = "Tutor"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(461, 217)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(64, 17)
		Me.Label10.TabIndex = 105
		Me.Label10.Text = "Teléfono"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(588, 217)
		Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(65, 17)
		Me.Label11.TabIndex = 106
		Me.Label11.Text = "Servicios"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(689, 217)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(44, 17)
		Me.Label12.TabIndex = 107
		Me.Label12.Text = "Costo"
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(86, 10)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePicker1.TabIndex = 114
		'
		'DateTimePicker2
		'
		Me.DateTimePicker2.Location = New System.Drawing.Point(86, 45)
		Me.DateTimePicker2.Name = "DateTimePicker2"
		Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePicker2.TabIndex = 115
		'
		'K
		'
		Me.K.FormattingEnabled = True
		Me.K.Location = New System.Drawing.Point(11, 24)
		Me.K.Name = "K"
		Me.K.Size = New System.Drawing.Size(101, 21)
		Me.K.TabIndex = 116
		Me.K.Text = "Mascota"
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.K)
		Me.Panel3.Controls.Add(Me.Button1)
		Me.Panel3.Controls.Add(Me.btnGuardar)
		Me.Panel3.Controls.Add(Me.ComboBox1)
		Me.Panel3.Controls.Add(Me.ComboBoxServicio)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Location = New System.Drawing.Point(443, 109)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(239, 105)
		Me.Panel3.TabIndex = 117
		'
		'Button1
		'
		Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Button1.BackColor = System.Drawing.Color.LightBlue
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(129, 73)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(93, 23)
		Me.Button1.TabIndex = 118
		Me.Button1.Text = "PDF"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(32, 244)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(676, 182)
		Me.DataGridView1.TabIndex = 119
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel4.Controls.Add(Me.DateTimePicker2)
		Me.Panel4.Controls.Add(Me.DateTimePicker1)
		Me.Panel4.Controls.Add(Me.Label4)
		Me.Panel4.Controls.Add(Me.Label3)
		Me.Panel4.Location = New System.Drawing.Point(51, 123)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(310, 73)
		Me.Panel4.TabIndex = 120
		'
		'Informes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(767, 487)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "Informes"
		Me.Text = "Informes"
		Me.Panel1.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents ComboBoxServicio As ComboBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents btnGuardar As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents DateTimePicker2 As DateTimePicker
	Friend WithEvents K As ComboBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Button1 As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Panel4 As Panel
End Class
