Imports MySql.Data.MySqlClient

Public Class Historial
    ' Cadena de conexión
    Private connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"

    Private Sub cmbMascotas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMascotas.SelectedIndexChanged
        If cmbMascotas.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona una mascota.")
            Return
        End If
        MostrarHistorialProcedimientos()
    End Sub

    Private Sub MostrarHistorialProcedimientos()
        ' Validar que haya una mascota seleccionada en el ComboBox
        If cmbMascotas.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona una mascota.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Consulta SQL para obtener los procedimientos
        Dim query As String = "SELECT " &
                      "  c.fechaConsulta AS 'Fecha de Consulta', " &
                      "  'Consulta Médica' AS 'Tipo de Procedimiento', " &
                      "  c.costoCons AS 'Costo del Procedimiento', " &
                      "  c.receta AS 'Detalles/Observaciones' " &
                      "FROM consulta c " &
                      "INNER JOIN mascota m ON c.idMascota = m.idMascota " &
                      "WHERE m.nomMasc = @nombreMascota " &
                      "UNION ALL " &
                      "SELECT " &
                      "  ci.fecha AS 'Fecha de Cirugía', " &
                      "  'Cirugía' AS 'Tipo de Procedimiento', " &
                      "  ci.costo AS 'Costo del Procedimiento', " &
                      "  ci.observaciones AS 'Detalles/Observaciones' " &
                      "FROM cirugia ci " &
                      "INNER JOIN mascota m ON ci.idMascota = m.idMascota " &
                      "WHERE m.nomMasc = @nombreMascota " &
                      "UNION ALL " &
                      "SELECT " &
                      "  r.fecha AS 'Fecha de Desparacitación', " &
                      "  'Desparacitación' AS 'Tipo de Procedimiento', " &
                      "  d.costo AS 'Costo del Procedimiento', " &
                      "  r.observaciones AS 'Detalles/Observaciones' " &
                      "FROM registrodesparacitacion r " &
                      "INNER JOIN desparacitacion d ON r.idDesparacitacion = d.idDesparacitacion " &
                      "INNER JOIN mascota m ON r.idMascota = m.idMascota " &
                      "WHERE m.nomMasc = @nombreMascota " &
                      "UNION ALL " &
                      "SELECT " &
                      "  rv.fecha AS 'Fecha de Vacunación', " &
                      "  CONCAT('Vacunación: ', v.nombreVac) AS 'Tipo de Procedimiento', " &
                      "  v.precio AS 'Costo del Procedimiento', " &
                      "  rv.observaciones AS 'Detalles/Observaciones' " &
                      "FROM registrovacunacion rv " &
                      "INNER JOIN vacuna v ON rv.idVacuna = v.idVacuna " &
                      "INNER JOIN mascota m ON rv.idMascota = m.idMascota " &
                      "WHERE m.nomMasc = @nombreMascota " &
                      "UNION ALL " &
                      "SELECT " &
                      "  p.fechaEntrada AS 'Fecha de Entrada a Pensión', " &
                      "  'Pensión' AS 'Tipo de Procedimiento', " &
                      "  p.costoTotal AS 'Costo del Procedimiento', " &
                      "  CONCAT('Desde: ', p.fechaEntrada, ' hasta: ', p.fechaSalida, '. ', p.observaciones) AS 'Detalles/Observaciones' " &
                      "FROM pension p " &
                      "INNER JOIN mascota m ON p.idMascota = m.idMascota " &
                      "WHERE m.nomMasc = @nombreMascota " &
                      "UNION ALL " &
                      "SELECT " &
                      "  e.fecha AS 'Fecha de Eutanasia', " &
                      "  'Eutanasia' AS 'Tipo de Procedimiento', " &
                      "  e.costoFinal AS 'Costo del Procedimiento', " &
                      "  e.observaciones AS 'Detalles/Observaciones' " &
                      "FROM eutanasia e " &
                      "INNER JOIN mascota m ON e.idMascota = m.idMascota " &
                      "WHERE m.nomMasc = @nombreMascota " &
                      "UNION ALL " &
                      "SELECT " &
                      "  h.fechaEntrada AS 'Fecha de Hospitalización', " &
                      "  'Hospitalización' AS 'Tipo de Procedimiento', " &
                      "  h.costo AS 'Costo del Procedimiento', " &
                      "  h.observaciones AS 'Detalles/Observaciones' " &
                      "FROM hospitalizacion h " &
                      "INNER JOIN mascota m ON h.idMascota = m.idMascota " &
                      "WHERE m.nomMasc = @nombreMascota " &
                      "UNION ALL " &
                      "SELECT " &
                      "  p.fecha AS 'Fecha de Profilaxis Dental', " &
                      "  'Profilaxis Dental' AS 'Tipo de Procedimiento', " &
                      "  pr.precio AS 'Costo del Procedimiento', " &
                      "  p.observaciones AS 'Detalles/Observaciones' " &
                      "FROM profilaxisdental p " &
                      "INNER JOIN precioprofilaxis pr ON p.idPrecioProfilaxis = pr.idPrecioProfilaxis " &
                      "INNER JOIN mascota m ON p.idMascota = m.idMascota " &
                      "WHERE m.nomMasc = @nombreMascota " &
                      "UNION ALL " &
                      "SELECT " &
                      "  s.horaEntrada AS 'Fecha de Servicio Estético', " &
                      "  'Servicio Estético' AS 'Tipo de Procedimiento', " &
                      "  s.costo AS 'Costo del Procedimiento', " &
                      "  s.observaciones AS 'Detalles/Observaciones' " &
                      "FROM serviciosestetica s " &
                      "INNER JOIN mascota m ON s.idMascota = m.idMascota " &
                      "WHERE m.nomMasc = @nombreMascota"


        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@nombreMascota", cmbMascotas.SelectedItem.ToString())

                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No se encontraron procedimientos para la mascota seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    dgvHistorial.DataSource = dt
                End Using
            End Using
        End Using
    End Sub


    Private Sub MostrarMascotasDelTutor()
        Dim query As String = "SELECT m.nomMasc AS nombre_mascota " &
                              "FROM Mascota m " &
                              "WHERE m.nomCliente = @nombreCliente AND m.celular = @celularCliente"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nombreCliente", txtNombreCliente.Text)
                cmd.Parameters.AddWithValue("@celularCliente", txtCelularCliente.Text)

                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    cmbMascotas.Items.Clear()
                    For Each row As DataRow In dt.Rows
                        cmbMascotas.Items.Add(row("nombre_mascota"))
                    Next
                End Using
            End Using
        End Using
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MostrarMascotasDelTutor()
        MostrarHistorialProcedimientos()
    End Sub
    Private Sub BtnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()
        Me.Close()
    End Sub
End Class
