﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recibo
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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnMenuPrincipal = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.txtTotalPagar = New System.Windows.Forms.TextBox()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.txtNombreCliente = New System.Windows.Forms.TextBox()
		Me.txtNombreMascota = New System.Windows.Forms.TextBox()
		Me.txtTelefono = New System.Windows.Forms.TextBox()
		Me.txtApellidoCliente = New System.Windows.Forms.TextBox()
		Me.dgvServicios = New System.Windows.Forms.DataGridView()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.Controls.Add(Me.btnMenuPrincipal)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(2, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(831, 112)
		Me.Panel1.TabIndex = 13
		'
		'btnMenuPrincipal
		'
		Me.btnMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
		Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMenuPrincipal.Location = New System.Drawing.Point(592, 61)
		Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(2)
		Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
		Me.btnMenuPrincipal.Size = New System.Drawing.Size(107, 25)
		Me.btnMenuPrincipal.TabIndex = 1
		Me.btnMenuPrincipal.Text = "Menú Principal"
		Me.btnMenuPrincipal.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(299, 46)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(156, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Recibo"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel2.Controls.Add(Me.Button1)
		Me.Panel2.Location = New System.Drawing.Point(-3, 419)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(836, 112)
		Me.Panel2.TabIndex = 14
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.LightBlue
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(597, 14)
		Me.Button1.Margin = New System.Windows.Forms.Padding(2)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(107, 25)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Menú Principal"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(8, 4)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(61, 26)
		Me.Label2.TabIndex = 59
		Me.Label2.Text = "Fecha:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(5, 48)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(105, 33)
		Me.Label3.TabIndex = 75
		Me.Label3.Text = "Nombre de tutor:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(5, 91)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(105, 33)
		Me.Label4.TabIndex = 77
		Me.Label4.Text = "Apellido el Tutor:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(42, 134)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(74, 33)
		Me.Label5.TabIndex = 79
		Me.Label5.Text = "Teléfono:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(45, 180)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(68, 33)
		Me.Label6.TabIndex = 81
		Me.Label6.Text = "Mascota:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label17
		'
		Me.Label17.BackColor = System.Drawing.Color.White
		Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(547, 374)
		Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(77, 24)
		Me.Label17.TabIndex = 94
		Me.Label17.Text = "Costo Total:"
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtTotalPagar
		'
		Me.txtTotalPagar.BackColor = System.Drawing.Color.White
		Me.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotalPagar.Location = New System.Drawing.Point(628, 379)
		Me.txtTotalPagar.Margin = New System.Windows.Forms.Padding(2)
		Me.txtTotalPagar.Multiline = True
		Me.txtTotalPagar.Name = "txtTotalPagar"
		Me.txtTotalPagar.Size = New System.Drawing.Size(73, 19)
		Me.txtTotalPagar.TabIndex = 103
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(63, 10)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePicker1.TabIndex = 106
		'
		'txtNombreCliente
		'
		Me.txtNombreCliente.Location = New System.Drawing.Point(106, 57)
		Me.txtNombreCliente.Name = "txtNombreCliente"
		Me.txtNombreCliente.Size = New System.Drawing.Size(128, 20)
		Me.txtNombreCliente.TabIndex = 107
		'
		'txtNombreMascota
		'
		Me.txtNombreMascota.Location = New System.Drawing.Point(106, 189)
		Me.txtNombreMascota.Name = "txtNombreMascota"
		Me.txtNombreMascota.Size = New System.Drawing.Size(100, 20)
		Me.txtNombreMascota.TabIndex = 111
		'
		'txtTelefono
		'
		Me.txtTelefono.Location = New System.Drawing.Point(106, 141)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
		Me.txtTelefono.TabIndex = 112
		'
		'txtApellidoCliente
		'
		Me.txtApellidoCliente.Location = New System.Drawing.Point(106, 101)
		Me.txtApellidoCliente.Name = "txtApellidoCliente"
		Me.txtApellidoCliente.Size = New System.Drawing.Size(128, 20)
		Me.txtApellidoCliente.TabIndex = 113
		'
		'dgvServicios
		'
		Me.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvServicios.Location = New System.Drawing.Point(308, 124)
		Me.dgvServicios.Name = "dgvServicios"
		Me.dgvServicios.Size = New System.Drawing.Size(393, 235)
		Me.dgvServicios.TabIndex = 115
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Panel3.Controls.Add(Me.txtApellidoCliente)
		Me.Panel3.Controls.Add(Me.txtTelefono)
		Me.Panel3.Controls.Add(Me.txtNombreMascota)
		Me.Panel3.Controls.Add(Me.txtNombreCliente)
		Me.Panel3.Controls.Add(Me.DateTimePicker1)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Controls.Add(Me.Label5)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(16, 120)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(272, 239)
		Me.Panel3.TabIndex = 116
		'
		'Recibo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(729, 487)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.dgvServicios)
		Me.Controls.Add(Me.txtTotalPagar)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Recibo"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Recibo"
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents txtTotalPagar As TextBox
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents txtNombreCliente As TextBox
	Friend WithEvents txtNombreMascota As TextBox
	Friend WithEvents txtTelefono As TextBox
	Friend WithEvents txtApellidoCliente As TextBox
	Friend WithEvents dgvServicios As DataGridView
	Friend WithEvents Panel3 As Panel
	Friend WithEvents btnMenuPrincipal As Button
	Friend WithEvents Button1 As Button
End Class
