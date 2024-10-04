<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desparacitación
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desparacitación))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.TextBox7 = New System.Windows.Forms.TextBox()
		Me.ComboBox3 = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.TextBox10 = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
		Me.Panel1.Location = New System.Drawing.Point(1, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(842, 116)
		Me.Panel1.TabIndex = 5
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(725, 29)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
		Me.Label1.Location = New System.Drawing.Point(268, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(337, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Desparacitación"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.Panel2.Controls.Add(Me.Button1)
		Me.Panel2.Controls.Add(Me.Button2)
		Me.Panel2.Location = New System.Drawing.Point(1, 443)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(839, 94)
		Me.Panel2.TabIndex = 6
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(543, 37)
		Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(93, 25)
		Me.Button1.TabIndex = 5
		Me.Button1.Text = "Guardar"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(683, 37)
		Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(115, 25)
		Me.Button2.TabIndex = 6
		Me.Button2.Text = "Continuar a recibo"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'ComboBox1
		'
		Me.ComboBox1.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBox1.ForeColor = System.Drawing.Color.White
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"Chico", "Mediano", "Grande"})
		Me.ComboBox1.Location = New System.Drawing.Point(93, 179)
		Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(147, 21)
		Me.ComboBox1.TabIndex = 26
		Me.ComboBox1.Text = "Desparacitación"
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.Silver
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label10.Location = New System.Drawing.Point(418, 168)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(101, 39)
		Me.Label10.TabIndex = 27
		Me.Label10.Text = "Observaciones:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBox7
		'
		Me.TextBox7.BackColor = System.Drawing.Color.Silver
		Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox7.Location = New System.Drawing.Point(579, 155)
		Me.TextBox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.TextBox7.Multiline = True
		Me.TextBox7.Name = "TextBox7"
		Me.TextBox7.Size = New System.Drawing.Size(182, 60)
		Me.TextBox7.TabIndex = 28
		Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ComboBox3
		'
		Me.ComboBox3.BackColor = System.Drawing.SystemColors.InfoText
		Me.ComboBox3.ForeColor = System.Drawing.Color.White
		Me.ComboBox3.FormattingEnabled = True
		Me.ComboBox3.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Cirugía", "Grooming", "Pensión", "Eutanasia"})
		Me.ComboBox3.Location = New System.Drawing.Point(501, 254)
		Me.ComboBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.ComboBox3.Name = "ComboBox3"
		Me.ComboBox3.Size = New System.Drawing.Size(147, 21)
		Me.ComboBox3.TabIndex = 32
		Me.ComboBox3.Text = "Agregar Servicio"
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Silver
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Location = New System.Drawing.Point(568, 385)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(62, 24)
		Me.Label12.TabIndex = 33
		Me.Label12.Text = "Costo:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBox10
		'
		Me.TextBox10.BackColor = System.Drawing.Color.Silver
		Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox10.Location = New System.Drawing.Point(662, 385)
		Me.TextBox10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.TextBox10.Multiline = True
		Me.TextBox10.Name = "TextBox10"
		Me.TextBox10.Size = New System.Drawing.Size(73, 24)
		Me.TextBox10.TabIndex = 34
		Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(35, 209)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(417, 210)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 35
		Me.PictureBox1.TabStop = False
		'
		'Desparacitación
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(840, 487)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.TextBox10)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.ComboBox3)
		Me.Controls.Add(Me.TextBox7)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "Desparacitación"
		Me.Text = "Desparacitación"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
