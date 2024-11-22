Imports MySql.Data.MySqlClient

Public Class Informes
    Private Sub btnCargarInforme_Click(sender As Object, e As EventArgs) Handles btnCargarInforme.Click
        Dim fechaInicio As String = DateTimePickerInicio.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = DateTimePickerFin.Value.ToString("yyyy-MM-dd")
        Dim tipoInforme As String = ComboBoxMulti.SelectedItem?.ToString()

        If String.IsNullOrEmpty(tipoInforme) Then
            MessageBox.Show("Por favor, selecciona un tipo de informe válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Variables para consultas
        Dim query As String = ""
        Dim columnHeader As String = ""
        Dim totalQuery As String = ""

        ' Configurar consulta según el tipo seleccionado
        If tipoInforme = "Servicios" Then
            query = "
            SELECT 
                Servicio, 
                COUNT(*) AS TotalSolicitudes
            FROM (
                SELECT 'Cirugía' AS Servicio, c.fecha AS Fecha, c.idMascota AS Mascota
                FROM cirugia c

                UNION ALL

                SELECT 'Consulta' AS Servicio, con.fechaConsulta AS Fecha, con.idMascota AS Mascota
                FROM consulta con

                UNION ALL

                SELECT 'Eutanasia' AS Servicio, e.fecha AS Fecha, e.idMascota AS Mascota
                FROM eutanasia e

                UNION ALL

                SELECT 'Hospitalización' AS Servicio, h.fechaEntrada AS Fecha, h.idMascota AS Mascota
                FROM hospitalizacion h

                UNION ALL

                SELECT 'Pensión' AS Servicio, p.fechaEntrada AS Fecha, p.idMascota AS Mascota
                FROM pension p

                UNION ALL

                SELECT 'Profilaxis Dental' AS Servicio, pd.fecha AS Fecha, pd.idMascota AS Mascota
                FROM profilaxisdental pd

                UNION ALL

                SELECT 'Desparacitación' AS Servicio, rd.fecha AS Fecha, rd.idMascota AS Mascota
                FROM registrodesparacitacion rd

                UNION ALL

                SELECT 'Vacunación' AS Servicio, rv.fecha AS Fecha, rv.idMascota AS Mascota
                FROM registrovacunacion rv

                UNION ALL

                SELECT 'Esterilización' AS Servicio, rp.fecha AS Fecha, rp.idMascota AS Mascota
                FROM registroprocedimiento rp

                UNION ALL

                SELECT 'Estética' AS Servicio, se.horaEntrada AS Fecha, se.idMascota AS Mascota
                FROM serviciosestetica se
            ) AS Servicios
            WHERE Fecha BETWEEN @FechaInicio AND @FechaFin
            GROUP BY Servicio;"

            columnHeader = "Servicios más solicitados"
            totalQuery = "
            SELECT COUNT(*) AS TotalSolicitudes
            FROM (
                SELECT 'Cirugía' AS Servicio, c.fecha AS Fecha, c.idMascota AS Mascota
                FROM cirugia c

                UNION ALL

                SELECT 'Consulta' AS Servicio, con.fechaConsulta AS Fecha, con.idMascota AS Mascota
                FROM consulta con

                UNION ALL

                SELECT 'Eutanasia' AS Servicio, e.fecha AS Fecha, e.idMascota AS Mascota
                FROM eutanasia e

                UNION ALL

                SELECT 'Hospitalización' AS Servicio, h.fechaEntrada AS Fecha, h.idMascota AS Mascota
                FROM hospitalizacion h

                UNION ALL

                SELECT 'Pensión' AS Servicio, p.fechaEntrada AS Fecha, p.idMascota AS Mascota
                FROM pension p

                UNION ALL

                SELECT 'Profilaxis Dental' AS Servicio, pd.fecha AS Fecha, pd.idMascota AS Mascota
                FROM profilaxisdental pd

                UNION ALL

                SELECT 'Desparacitación' AS Servicio, rd.fecha AS Fecha, rd.idMascota AS Mascota
                FROM registrodesparacitacion rd

                UNION ALL

                SELECT 'Vacunación' AS Servicio, rv.fecha AS Fecha, rv.idMascota AS Mascota
                FROM registrovacunacion rv

                UNION ALL

                SELECT 'Esterilización' AS Servicio, rp.fecha AS Fecha, rp.idMascota AS Mascota
                FROM registroprocedimiento rp

                UNION ALL

                SELECT 'Estética' AS Servicio, se.horaEntrada AS Fecha, se.idMascota AS Mascota
                FROM serviciosestetica se
            ) AS Servicios
            WHERE Fecha BETWEEN @FechaInicio AND @FechaFin;"
        ElseIf tipoInforme = "Clientes" Then
            query = "
                SELECT CONCAT(m.nomCliente, ' ', m.apCliente) AS Cliente, COUNT(*) AS TotalVisitas
                FROM mascota m
                WHERE m.fecha BETWEEN @FechaInicio AND @FechaFin
                GROUP BY m.nomCliente, m.apCliente
                ORDER BY TotalVisitas DESC;"
            columnHeader = "Clientes más frecuentes"
            totalQuery = "
                SELECT COUNT(*) AS TotalVisitas
                FROM mascota
                WHERE fecha BETWEEN @FechaInicio AND @FechaFin;"
        ElseIf tipoInforme = "Mascotas" Then
            query = "
                SELECT m.nomMasc AS Mascota, COUNT(*) AS TotalVisitas
                FROM mascota m
                WHERE m.fecha BETWEEN @FechaInicio AND @FechaFin
                GROUP BY m.idMascota, m.nomMasc
                ORDER BY TotalVisitas DESC;"
            columnHeader = "Mascotas más atendidas"
            totalQuery = "
                SELECT COUNT(*) AS TotalVisitas
                FROM mascota
                WHERE fecha BETWEEN @FechaInicio AND @FechaFin;"
        ElseIf tipoInforme = "Fondos" Then
            query = "
        SELECT Servicio, SUM(Costo) AS TotalRecaudado
        FROM (
            SELECT 'Cirugía' AS Servicio, c.costo AS Costo
            FROM cirugia c
            WHERE c.fecha BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT 'Consulta' AS Servicio, con.costoCons AS Costo
            FROM consulta con
            WHERE con.fechaConsulta BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT 'Eutanasia' AS Servicio, e.costoFinal AS Costo
            FROM eutanasia e
            WHERE e.fecha BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT 'Hospitalización' AS Servicio, h.costo AS Costo
            FROM hospitalizacion h
            WHERE h.fechaEntrada BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT 'Pensión' AS Servicio, p.costoTotal AS Costo
            FROM pension p
            WHERE p.fechaEntrada BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT 'Profilaxis Dental' AS Servicio, pp.precio AS Costo
            FROM profilaxisdental pd
            INNER JOIN precioprofilaxis pp ON pd.idPrecioProfilaxis = pp.idPrecioProfilaxis
            WHERE pd.fecha BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT 'Desparacitación' AS Servicio, d.costo AS Costo
            FROM registrodesparacitacion rd
            INNER JOIN desparacitacion d ON rd.idDesparacitacion = d.idDesparacitacion
            WHERE rd.fecha BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT 'Vacunación' AS Servicio, v.precio AS Costo
            FROM registrovacunacion rv
            INNER JOIN vacuna v ON rv.idVacuna = v.idVacuna
            WHERE rv.fecha BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT 'Esterilización' AS Servicio, rp.costo AS Costo
            FROM registroprocedimiento rp
            WHERE rp.fecha BETWEEN @FechaInicio AND @FechaFin
        ) AS Servicios
        GROUP BY Servicio
        ORDER BY Servicio;"

            totalQuery = "
        SELECT SUM(Costo) AS TotalRecaudado
        FROM (
            SELECT c.costo AS Costo
            FROM cirugia c
            WHERE c.fecha BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT con.costoCons AS Costo
            FROM consulta con
            WHERE con.fechaConsulta BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT e.costoFinal AS Costo
            FROM eutanasia e
            WHERE e.fecha BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT h.costo AS Costo
            FROM hospitalizacion h
            WHERE h.fechaEntrada BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT p.costoTotal AS Costo
            FROM pension p
            WHERE p.fechaEntrada BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT pp.precio AS Costo
            FROM profilaxisdental pd
            INNER JOIN precioprofilaxis pp ON pd.idPrecioProfilaxis = pp.idPrecioProfilaxis
            WHERE pd.fecha BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT d.costo AS Costo
            FROM registrodesparacitacion rd
            INNER JOIN desparacitacion d ON rd.idDesparacitacion = d.idDesparacitacion
            WHERE rd.fecha BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT v.precio AS Costo
            FROM registrovacunacion rv
            INNER JOIN vacuna v ON rv.idVacuna = v.idVacuna
            WHERE rv.fecha BETWEEN @FechaInicio AND @FechaFin

            UNION ALL

            SELECT rp.costo AS Costo
            FROM registroprocedimiento rp
            WHERE rp.fecha BETWEEN @FechaInicio AND @FechaFin
        ) AS TotalRecaudado;"
        Else

            MessageBox.Show("Por favor, selecciona un tipo de informe válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ejecutar consulta principal y mostrar en el DataGridView
        Try
            Dim conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            cmd.Parameters.AddWithValue("@FechaFin", fechaFin)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            conn.Open()
            adapter.Fill(table)
            conn.Close()

            If table.Rows.Count > 0 Then
                DataGridViewResultados.DataSource = table
                DataGridViewResultados.Columns(0).HeaderText = "Servicio"
                DataGridViewResultados.Columns(1).HeaderText = "Total Solicitudes"
            Else
                MessageBox.Show("No se encontraron datos para el rango de fechas seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al ejecutar la consulta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        ' Ejecutar consulta de total y mostrar en el TextBox
        Try
            Dim conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Dim cmdTotal As New MySqlCommand(totalQuery, conn)
            cmdTotal.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            cmdTotal.Parameters.AddWithValue("@FechaFin", fechaFin)

            conn.Open()
            Dim total As Integer = Convert.ToInt32(cmdTotal.ExecuteScalar())
            conn.Close()

            TextBoxTotalVisitas.Text = total.ToString()
        Catch ex As Exception
            MessageBox.Show("Error al calcular el total: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class