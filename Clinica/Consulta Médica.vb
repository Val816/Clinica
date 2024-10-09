Imports MySql.Data.MySqlClient

Public Class Consulta_Médica
    Private conexionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"

    ' Cargar el formulario y llenar los ComboBox al cargar el formulario
    Private Sub ConsultaMedicaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LlenarComboBoxDesparacitacion()
            LlenarComboBoxVacunas()
            LlenarComboBoxServicios()
        LlenarComboBoxEstadoReprod()
    End Sub

    ' Llenar ComboBox de Desparacitaciones
    Private Sub LlenarComboBoxDesparacitacion()
            ComboBoxDesparacitacion.Items.Clear()

            Dim query As String = "SELECT idDesparacitacion, nombre FROM Desparacitacion"
            Using conn As New MySqlConnection(conexionString)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ComboBoxDesparacitacion.Items.Add(New With {
                        .Value = reader("idDesparacitacion"),
                        .Text = reader("nombre")
                    })
                    End While
                End Using
            End Using

            ComboBoxDesparacitacion.DisplayMember = "Text"
            ComboBoxDesparacitacion.ValueMember = "Value"
        End Sub

        ' Llenar ComboBox de Vacunas
        Private Sub LlenarComboBoxVacunas()
            ComboBoxVacunas.Items.Clear()

            Dim query As String = "SELECT idVacuna, nombreVac FROM Vacuna"
            Using conn As New MySqlConnection(conexionString)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ComboBoxVacunas.Items.Add(New With {
                        .Value = reader("idVacuna"),
                        .Text = reader("nombreVac")
                    })
                    End While
                End Using
            End Using

            ComboBoxVacunas.DisplayMember = "Text"
            ComboBoxVacunas.ValueMember = "Value"
        End Sub
    ' Llenar ComboBox de Estado Reproductivo
    Private Sub LlenarComboBoxEstadoReprod()
        ComboBoxEstadoReprod.Items.Clear()

        Dim query As String = "SELECT idEstadoReproductivo, nombre FROM EstadoReproductivo"
        Using conn As New MySqlConnection(conexionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxEstadoReprod.Items.Add(New With {
                    .Value = reader("idEstadoReproductivo"),
                    .Text = reader("nombre")
                })
                End While
            End Using
        End Using

        ComboBoxEstadoReprod.DisplayMember = "Text"
        ComboBoxEstadoReprod.ValueMember = "Value"
    End Sub

    ' Llenar ComboBox de Servicios
    Private Sub LlenarComboBoxServicios()
            ComboBoxServicios.Items.Clear()

            Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
            Using conn As New MySqlConnection(conexionString)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ComboBoxServicios.Items.Add(New With {
                        .Value = reader("idServicio"),
                        .Text = reader("nombre")
                    })
                    End While
                End Using
            End Using

            ComboBoxServicios.DisplayMember = "Text"
            ComboBoxServicios.ValueMember = "Value"
        End Sub

    ' Guardar los datos de la consulta médica junto con la fecha y hora actual
    Private Sub GuardarConsulta()
        Dim query As String = "INSERT INTO Consulta (idDesparacitacion, idVacuna, idServicio, temperatura, pulso, TLLC, estadoRep, frecCardi, frecResp, enfermedad, receta, desparacitacion, costoCons, observaciones, fechaConsulta) " &
                          "VALUES (@idDesparacitacion, @idVacuna, @idServicio, @temperatura, @pulso, @TLLC, @estadoRep, @frecCardi, @frecResp, @enfermedad, @receta, @desparacitacion, @costoCons, @observaciones, @fechaConsulta)"

        Using conn As New MySqlConnection(conexionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idDesparacitacion", ComboBoxDesparacitacion.SelectedValue)
                cmd.Parameters.AddWithValue("@idVacuna", ComboBoxVacunas.SelectedValue)
                cmd.Parameters.AddWithValue("@idServicio", ComboBoxServicios.SelectedValue)
                cmd.Parameters.AddWithValue("@temperatura", Convert.ToDouble(TextBoxTemperatura.Text))
                cmd.Parameters.AddWithValue("@pulso", TextBoxPulso.Text)
                cmd.Parameters.AddWithValue("@TLLC", TextBoxTLLC.Text)
                cmd.Parameters.AddWithValue("@estadoRep", ComboBoxEstadoReprod.SelectedValue) ' Nuevo ComboBox para estado reproductivo
                cmd.Parameters.AddWithValue("@frecCardi", TextBoxFrecCardiaca.Text)
                cmd.Parameters.AddWithValue("@frecResp", Convert.ToDouble(TextBoxFrecRespiratoria.Text))
                cmd.Parameters.AddWithValue("@enfermedad", TextBoxEnfermedad.Text)
                cmd.Parameters.AddWithValue("@receta", TextBoxReceta.Text)
                cmd.Parameters.AddWithValue("@desparacitacion", If(ComboBoxDesparacitacion.SelectedItem IsNot Nothing, "S", "N"))
                cmd.Parameters.AddWithValue("@costoCons", 300)
                cmd.Parameters.AddWithValue("@observaciones", TextBoxObservaciones.Text)
                cmd.Parameters.AddWithValue("@fechaConsulta", DateTime.Now)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Consulta guardada exitosamente")
            End Using
        End Using
    End Sub




    Private Sub BtnnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            GuardarConsulta()
        Catch ex As Exception
            MessageBox.Show("Error al guardar la consulta: " & ex.Message)
        End Try
    End Sub

    ' Redirigir al formulario adecuado cuando selecciona un servicio
    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxServicios.SelectedIndexChanged
        ' Obtener el servicio seleccionado
        Dim servicioSeleccionado As Object = ComboBoxServicios.SelectedItem
        If servicioSeleccionado Is Nothing Then
            MessageBox.Show("Por favor, selecciona un servicio.")
            Return
        End If

        Dim idServicio As Integer = servicioSeleccionado.Value

        ' Redirigir según el servicio seleccionado
        Select Case idServicio
            Case 1 ' Ejemplo: Servicio de Vacunación
                Dim formVacunacion As New Vacunacion()
                formVacunacion.Show()
                Me.Hide()

            Case 2 ' Ejemplo: Servicio de Desparacitación
                Dim formDesparacitacion As New Desparacitación()
                formDesparacitacion.Show()
                Me.Hide()

            Case 3 ' Otro servicio
                Dim formOtroServicio As New Estética()
                formOtroServicio.Show()
                Me.Hide()

            Case Else
                MessageBox.Show("Servicio no reconocido. Por favor, selecciona un servicio válido.")
        End Select
    End Sub
    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        ' Abrir el formulario del Menú Principal
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()

        ' Cerrar el formulario actual
        Me.Close()
    End Sub
End Class
