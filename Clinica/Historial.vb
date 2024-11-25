Imports MySql.Data.MySqlClient

Public Class Historial
    ' Cadena de conexión
    Private connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"

    Private Sub cmbMascotas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMascotas.SelectedIndexChanged
        If cmbMascotas.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona una mascota.")
            Return
        End If
        MostrarHistorialCompleto()
    End Sub

    Private Sub MostrarHistorialCompleto()
        ' Validar que haya una mascota seleccionada
        If cmbMascotas.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona una mascota.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim queryHistorial As String = "SELECT 'Consulta' AS TipoServicio, c.fechaConsulta AS Fecha, c.costoCons AS Costo, c.receta AS Descripción " &
                                       "FROM consulta c WHERE c.idMascota = @idMascota " &
                                       "UNION ALL " &
                                       "SELECT 'Cirugía' AS TipoServicio, ci.fecha AS Fecha, ci.costo AS Costo, tc.nombre AS Descripción " &
                                       "FROM cirugia ci JOIN tipocirugia tc ON ci.idTipoCirugia = tc.idTipoCirugia WHERE ci.idMascota = @idMascota " &
                                       "UNION ALL " &
                                       "SELECT 'Servicio Estético' AS TipoServicio, se.horaEntrada AS Fecha, se.costo AS Costo, e.nombreServicio AS Descripción " &
                                       "FROM serviciosestetica se JOIN estetica e ON se.idEstetica = e.idEstetica WHERE se.idMascota = @idMascota " &
                                       "UNION ALL " &
                                       "SELECT 'Desparasitación' AS TipoServicio, rd.fecha AS Fecha, d.costo AS Costo, d.nombre AS Descripción " &
                                       "FROM registrodesparacitacion rd JOIN desparacitacion d ON rd.idDesparacitacion = d.idDesparacitacion WHERE rd.idMascota = @idMascota " &
                                       "UNION ALL " &
                                       "SELECT 'Vacunación' AS TipoServicio, rv.fecha AS Fecha, v.precio AS Costo, v.nombreVac AS Descripción " &
                                       "FROM registrovacunacion rv JOIN vacuna v ON rv.idVacuna = v.idVacuna WHERE rv.idMascota = @idMascota " &
                                       "UNION ALL " &
                                       "SELECT 'Hospitalización' AS TipoServicio, h.fechaEntrada AS Fecha, h.costo AS Costo, h.tipoHospitalizacion AS Descripción " &
                                       "FROM hospitalizacion h WHERE h.idMascota = @idMascota " &
                                       "UNION ALL " &
                                       "SELECT 'Pensión' AS TipoServicio, p.fechaEntrada AS Fecha, p.costoTotal AS Costo, CONCAT('Desde: ', p.fechaEntrada, ' hasta: ', p.fechaSalida) AS Descripción " &
                                       "FROM pension p WHERE p.idMascota = @idMascota " &
                                       "UNION ALL " &
                                       "SELECT 'Profilaxis Dental' AS TipoServicio, pd.fecha AS Fecha, pp.precio AS Costo, 'Profilaxis Dental' AS Descripción " &
                                       "FROM profilaxisdental pd JOIN precioprofilaxis pp ON pd.idPrecioProfilaxis = pp.idPrecioProfilaxis WHERE pd.idMascota = @idMascota " &
                                       "UNION ALL " &
                                       "SELECT 'Eutanasia' AS TipoServicio, e.fecha AS Fecha, e.costoFinal AS Costo, 'Eutanasia' AS Descripción " &
                                       "FROM eutanasia e WHERE e.idMascota = @idMascota " &
                                       "UNION ALL " &
                                       "SELECT 'Esterilización' AS TipoServicio, est.fecha AS Fecha, est.costo AS Costo, te.nombreEsterilizacion AS Descripción " &
                                       "FROM esterilizacion est JOIN tipoesterilizacion te ON est.idTipoEsterilizacion = te.idTipoEsterilizacion WHERE est.idMascota = @idMascota"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(queryHistorial, conn)
                    ' Asigna el valor del parámetro
                    cmd.Parameters.AddWithValue("@idMascota", cmbMascotas.SelectedValue)

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
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarMascotasDelTutor()
        Dim query As String = "SELECT m.idMascota, m.nomMasc AS nombre_mascota " &
                              "FROM Mascota m " &
                              "WHERE m.nomCliente = @nombreCliente AND m.celular = @celularCliente"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombreCliente", txtNombreCliente.Text)
                    cmd.Parameters.AddWithValue("@celularCliente", txtCelularCliente.Text)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)

                        cmbMascotas.DataSource = dt
                        cmbMascotas.DisplayMember = "nombre_mascota"
                        cmbMascotas.ValueMember = "idMascota"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MostrarMascotasDelTutor()
    End Sub

    Private Sub BtnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()
        Me.Close()
    End Sub
End Class
