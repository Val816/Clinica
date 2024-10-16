<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cirugía
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cirugía))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.ButtonGuardar = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.TextBoxObservaciones = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.ComboBoxServicio = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.TextBoxCostoTotal = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
		Me.ComboBoxCirugia = New System.Windows.Forms.ComboBox()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(1, -1)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(838, 108)
		Me.Panel1.TabIndex = 7
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(540, 29)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(93, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(263, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(337, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Cirugía"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel2.Controls.Add(Me.ButtonGuardar)
		Me.Panel2.Location = New System.Drawing.Point(-2, 423)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(841, 115)
		Me.Panel2.TabIndex = 8
		'
		'ButtonGuardar
		'
		Me.ButtonGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonGuardar.Location = New System.Drawing.Point(543, 18)
		Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.ButtonGuardar.Name = "ButtonGuardar"
		Me.ButtonGuardar.Size = New System.Drawing.Size(93, 25)
		Me.ButtonGuardar.TabIndex = 5
		Me.ButtonGuardar.Text = "Guardar"
		Me.ButtonGuardar.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Silver
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.Location = New System.Drawing.Point(31, 150)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(104, 24)
		Me.Label2.TabIndex = 12
		Me.Label2.Text = "Tipo de cirugía:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Silver
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label10.Location = New System.Drawing.Point(20, 252)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(115, 40)
		Me.Label10.TabIndex = 38
		Me.Label10.Text = "Observaciones:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxObservaciones
		'
		Me.TextBoxObservaciones.BackColor = System.Drawing.Color.Silver
		Me.TextBoxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxObservaciones.Location = New System.Drawing.Point(157, 252)
		Me.TextBoxObservaciones.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxObservaciones.Multiline = True
		Me.TextBoxObservaciones.Name = "TextBoxObservaciones"
		Me.TextBoxObservaciones.Size = New System.Drawing.Size(210, 82)
		Me.TextBoxObservaciones.TabIndex = 39
		Me.TextBoxObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Silver
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Location = New System.Drawing.Point(40, 195)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(95, 28)
		Me.Label6.TabIndex = 40
		Me.Label6.Text = "Fecha:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ComboBoxServicio
		'
		Me.ComboBoxServicio.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBoxServicio.ForeColor = System.Drawing.Color.White
		Me.ComboBoxServicio.FormattingEnabled = True
		Me.ComboBoxServicio.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBoxServicio.Location = New System.Drawing.Point(220, 111)
		Me.ComboBoxServicio.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBoxServicio.Name = "ComboBoxServicio"
		Me.ComboBoxServicio.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxServicio.TabIndex = 42
		Me.ComboBoxServicio.Text = "Agregar Servicio"
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Silver
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Location = New System.Drawing.Point(73, 363)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(62, 24)
		Me.Label12.TabIndex = 43
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxCostoTotal
		'
		Me.TextBoxCostoTotal.BackColor = System.Drawing.Color.Silver
		Me.TextBoxCostoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxCostoTotal.Location = New System.Drawing.Point(157, 363)
		Me.TextBoxCostoTotal.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBoxCostoTotal.Multiline = True
		Me.TextBoxCostoTotal.Name = "TextBoxCostoTotal"
		Me.TextBoxCostoTotal.Size = New System.Drawing.Size(73, 24)
		Me.TextBoxCostoTotal.TabIndex = 44
		Me.TextBoxCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(389, 111)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(245, 287)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 45
		Me.PictureBox1.TabStop = False
		'
		'DateTimePickerFecha
		'
		Me.DateTimePickerFecha.Location = New System.Drawing.Point(157, 203)
		Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
		Me.DateTimePickerFecha.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerFecha.TabIndex = 46
		'
		'ComboBoxCirugia
		'
		Me.ComboBoxCirugia.FormattingEnabled = True
		Me.ComboBoxCirugia.Location = New System.Drawing.Point(157, 150)
		Me.ComboBoxCirugia.Name = "ComboBoxCirugia"
		Me.ComboBoxCirugia.Size = New System.Drawing.Size(200, 21)
		Me.ComboBoxCirugia.TabIndex = 47
		'
		'Cirugía
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(648, 477)
		Me.Controls.Add(Me.ComboBoxCirugia)
		Me.Controls.Add(Me.DateTimePickerFecha)
		Me.Controls.Add(Me.ComboBoxServicio)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.TextBoxCostoTotal)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.TextBoxObservaciones)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Cirugía"
		Me.Text = "Cirugía"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents btnMenuPrincipal As System.Windows.Forms.Button
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents TextBoxObservaciones As System.Windows.Forms.TextBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents ComboBoxServicio As System.Windows.Forms.ComboBox
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents TextBoxCostoTotal As System.Windows.Forms.TextBox
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents DateTimePickerFecha As System.Windows.Forms.DateTimePicker
	Friend WithEvents ComboBoxCirugia As System.Windows.Forms.ComboBox


End Class
