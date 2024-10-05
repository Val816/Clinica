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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBoxDesparacitacion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.ComboBoxServicio = New System.Windows.Forms.ComboBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-6, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1281, 163)
        Me.Panel1.TabIndex = 5
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(1088, 45)
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
        Me.Label1.Location = New System.Drawing.Point(460, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eutanasia"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(-6, 676)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1281, 145)
        Me.Panel2.TabIndex = 6
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(814, 57)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 38)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1024, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 38)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Continuar a recibo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBoxDesparacitacion
        '
        Me.ComboBoxDesparacitacion.BackColor = System.Drawing.SystemColors.InfoText
        Me.ComboBoxDesparacitacion.DropDownHeight = 150
        Me.ComboBoxDesparacitacion.ForeColor = System.Drawing.Color.White
        Me.ComboBoxDesparacitacion.FormattingEnabled = True
        Me.ComboBoxDesparacitacion.IntegralHeight = False
        Me.ComboBoxDesparacitacion.Items.AddRange(New Object() {"Edad Avanzada", "Enfermedad crónica"})
        Me.ComboBoxDesparacitacion.Location = New System.Drawing.Point(247, 412)
        Me.ComboBoxDesparacitacion.Name = "ComboBoxDesparacitacion"
        Me.ComboBoxDesparacitacion.Size = New System.Drawing.Size(218, 28)
        Me.ComboBoxDesparacitacion.TabIndex = 26
        Me.ComboBoxDesparacitacion.Text = "Motivo"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(665, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 60)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Observaciones:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.Silver
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Location = New System.Drawing.Point(950, 270)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(240, 60)
        Me.txtObservaciones.TabIndex = 28
        Me.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(879, 582)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 36)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Costo:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Silver
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Location = New System.Drawing.Point(1037, 582)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(108, 36)
        Me.TextBox10.TabIndex = 34
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBoxServicio
        '
        Me.ComboBoxServicio.BackColor = System.Drawing.SystemColors.InfoText
        Me.ComboBoxServicio.ForeColor = System.Drawing.Color.White
        Me.ComboBoxServicio.FormattingEnabled = True
        Me.ComboBoxServicio.Items.AddRange(New Object() {"Consulta Médica", "Desparacitación", "Vacunación", "Eutanasia", "Cirugía", "Estética", "Pensión", "Castración", "Proaxis Dental"})
        Me.ComboBoxServicio.Location = New System.Drawing.Point(791, 412)
        Me.ComboBoxServicio.Name = "ComboBoxServicio"
        Me.ComboBoxServicio.Size = New System.Drawing.Size(218, 28)
        Me.ComboBoxServicio.TabIndex = 35
        Me.ComboBoxServicio.Text = "Agregar Servicio"
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.Silver
        Me.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHora.Location = New System.Drawing.Point(247, 279)
        Me.txtHora.Multiline = True
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(314, 42)
        Me.txtHora.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(60, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 42)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Fecha:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Eutanasia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1263, 816)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.ComboBoxServicio)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBoxDesparacitacion)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Eutanasia"
        Me.Text = "Eutanasia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBoxDesparacitacion As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents ComboBoxServicio As ComboBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents Label6 As Label
End Class
