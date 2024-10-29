<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eutanasia
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
		Me.BtnGenerarPDF = New System.Windows.Forms.Button()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(-4, -3)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(604, 91)
		Me.Panel1.TabIndex = 5
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(406, 36)
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
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(187, 23)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(145, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Eutanasia"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.BtnGenerarPDF)
		Me.Panel2.Controls.Add(Me.btnGuardar)
		Me.Panel2.Location = New System.Drawing.Point(-4, 381)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(854, 152)
		Me.Panel2.TabIndex = 6
		'
		'BtnGenerarPDF
		'
		Me.BtnGenerarPDF.BackColor = System.Drawing.Color.LightBlue
		Me.BtnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.BtnGenerarPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnGenerarPDF.Location = New System.Drawing.Point(309, 18)
		Me.BtnGenerarPDF.Name = "BtnGenerarPDF"
		Me.BtnGenerarPDF.Size = New System.Drawing.Size(83, 25)
		Me.BtnGenerarPDF.TabIndex = 6
		Me.BtnGenerarPDF.Text = "Generar pdf"
		Me.BtnGenerarPDF.UseVisualStyleBackColor = False
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.Color.LightBlue
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Location = New System.Drawing.Point(406, 18)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(93, 25)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.DateTimePicker1)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Controls.Add(Me.ComboBox1)
		Me.Panel3.Controls.Add(Me.TextBox1)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.TextBox2)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.ComboBox2)
		Me.Panel3.Location = New System.Drawing.Point(84, 118)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(358, 241)
		Me.Panel3.TabIndex = 40
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(130, 9)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePicker1.TabIndex = 46
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(67, 9)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(67, 20)
		Me.Label2.TabIndex = 45
		Me.Label2.Text = "Fecha:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ComboBox1
		'
		Me.ComboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ComboBox1.ForeColor = System.Drawing.Color.Black
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
		Me.ComboBox1.Location = New System.Drawing.Point(19, 209)
		Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox1.TabIndex = 44
		Me.ComboBox1.Text = "Agregar Servicio"
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.White
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox1.Location = New System.Drawing.Point(257, 189)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(73, 24)
		Me.TextBox1.TabIndex = 43
		Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(203, 189)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(62, 24)
		Me.Label3.TabIndex = 42
		Me.Label3.Text = "Costo:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.Silver
		Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox2.Location = New System.Drawing.Point(130, 49)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(210, 96)
		Me.TextBox2.TabIndex = 41
		Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(19, 44)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(106, 24)
		Me.Label4.TabIndex = 40
		Me.Label4.Text = "Observaciones:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ComboBox2
		'
		Me.ComboBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ComboBox2.DropDownHeight = 150
		Me.ComboBox2.ForeColor = System.Drawing.Color.Black
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.IntegralHeight = False
		Me.ComboBox2.Items.AddRange(New Object() {"Edad Avanzada", "Enfermedad crónica"})
		Me.ComboBox2.Location = New System.Drawing.Point(19, 166)
		Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox2.TabIndex = 39
		Me.ComboBox2.Text = "Motivo"
		'
		'Eutanasia
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(512, 458)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Eutanasia"
		Me.Text = "Eutanasia"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
	Friend WithEvents BtnGenerarPDF As Button
	Friend WithEvents Panel3 As Panel
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label2 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents ComboBox2 As ComboBox
End Class
