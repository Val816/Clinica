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
		Me.btnCargarInforme = New System.Windows.Forms.Button()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePickerFin = New System.Windows.Forms.DateTimePicker()
		Me.ComboBoxMulti = New System.Windows.Forms.ComboBox()
		Me.btnGenerarPDF = New System.Windows.Forms.Button()
		Me.DataGridViewResultados = New System.Windows.Forms.DataGridView()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.TextBoxTotalVisitas = New System.Windows.Forms.TextBox()
		Me.Panel1.SuspendLayout()
		CType(Me.DataGridViewResultados, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(0, -3)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(841, 89)
		Me.Panel1.TabIndex = 15
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(299, 36)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
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
		Me.Label1.Location = New System.Drawing.Point(149, 22)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(137, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Informes"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Location = New System.Drawing.Point(0, 449)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(841, 82)
		Me.Panel2.TabIndex = 84
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(35, 8)
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
		Me.Label4.Location = New System.Drawing.Point(35, 43)
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
		Me.Label6.Location = New System.Drawing.Point(35, 81)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(92, 22)
		Me.Label6.TabIndex = 98
		Me.Label6.Text = "Filtrar por:"
		'
		'btnCargarInforme
		'
		Me.btnCargarInforme.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.btnCargarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCargarInforme.Location = New System.Drawing.Point(248, 78)
		Me.btnCargarInforme.Margin = New System.Windows.Forms.Padding(2)
		Me.btnCargarInforme.Name = "btnCargarInforme"
		Me.btnCargarInforme.Size = New System.Drawing.Size(93, 25)
		Me.btnCargarInforme.TabIndex = 101
		Me.btnCargarInforme.Text = "Aceptar"
		Me.btnCargarInforme.UseVisualStyleBackColor = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(285, 384)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(44, 17)
		Me.Label7.TabIndex = 102
		Me.Label7.Text = "Total:"
		'
		'DateTimePickerInicio
		'
		Me.DateTimePickerInicio.Location = New System.Drawing.Point(112, 10)
		Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
		Me.DateTimePickerInicio.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerInicio.TabIndex = 114
		'
		'DateTimePickerFin
		'
		Me.DateTimePickerFin.Location = New System.Drawing.Point(112, 45)
		Me.DateTimePickerFin.Name = "DateTimePickerFin"
		Me.DateTimePickerFin.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerFin.TabIndex = 115
		'
		'ComboBoxMulti
		'
		Me.ComboBoxMulti.FormattingEnabled = True
		Me.ComboBoxMulti.Items.AddRange(New Object() {"Mascotas", "Clientes", "Servicios", "Fondos"})
		Me.ComboBoxMulti.Location = New System.Drawing.Point(132, 83)
		Me.ComboBoxMulti.Name = "ComboBoxMulti"
		Me.ComboBoxMulti.Size = New System.Drawing.Size(101, 21)
		Me.ComboBoxMulti.TabIndex = 116
		Me.ComboBoxMulti.Text = "Mascota"
		'
		'btnGenerarPDF
		'
		Me.btnGenerarPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btnGenerarPDF.BackColor = System.Drawing.Color.LightBlue
		Me.btnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGenerarPDF.Location = New System.Drawing.Point(248, 108)
		Me.btnGenerarPDF.Name = "btnGenerarPDF"
		Me.btnGenerarPDF.Size = New System.Drawing.Size(93, 23)
		Me.btnGenerarPDF.TabIndex = 118
		Me.btnGenerarPDF.Text = "PDF"
		Me.btnGenerarPDF.UseVisualStyleBackColor = False
		'
		'DataGridViewResultados
		'
		Me.DataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridViewResultados.Location = New System.Drawing.Point(29, 240)
		Me.DataGridViewResultados.Name = "DataGridViewResultados"
		Me.DataGridViewResultados.Size = New System.Drawing.Size(251, 204)
		Me.DataGridViewResultados.TabIndex = 119
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel4.Controls.Add(Me.btnGenerarPDF)
		Me.Panel4.Controls.Add(Me.ComboBoxMulti)
		Me.Panel4.Controls.Add(Me.btnCargarInforme)
		Me.Panel4.Controls.Add(Me.DateTimePickerFin)
		Me.Panel4.Controls.Add(Me.DateTimePickerInicio)
		Me.Panel4.Controls.Add(Me.Label4)
		Me.Panel4.Controls.Add(Me.Label6)
		Me.Panel4.Controls.Add(Me.Label3)
		Me.Panel4.Location = New System.Drawing.Point(29, 91)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(366, 143)
		Me.Panel4.TabIndex = 120
		'
		'TextBoxTotalVisitas
		'
		Me.TextBoxTotalVisitas.Location = New System.Drawing.Point(334, 383)
		Me.TextBoxTotalVisitas.Name = "TextBoxTotalVisitas"
		Me.TextBoxTotalVisitas.Size = New System.Drawing.Size(51, 20)
		Me.TextBoxTotalVisitas.TabIndex = 121
		'
		'Informes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(419, 487)
		Me.Controls.Add(Me.TextBoxTotalVisitas)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.DataGridViewResultados)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Informes"
		Me.Text = "Informes"
		Me.Panel1.ResumeLayout(False)
		CType(Me.DataGridViewResultados, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents btnCargarInforme As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents DateTimePickerInicio As DateTimePicker
	Friend WithEvents DateTimePickerFin As DateTimePicker
	Friend WithEvents ComboBoxMulti As ComboBox
	Friend WithEvents btnGenerarPDF As Button
	Friend WithEvents DataGridViewResultados As DataGridView
	Friend WithEvents Panel4 As Panel
	Friend WithEvents TextBoxTotalVisitas As TextBox
End Class
