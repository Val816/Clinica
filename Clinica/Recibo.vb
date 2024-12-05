Imports MySql.Data.MySqlClient

Public Class Recibo
    Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub FormServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosUltimaMascota()
    End Sub

    Private Sub CargarDatosUltimaMascota()
        Dim queryUltimaMascota As String = "SELECT m.nomCliente, m.apCliente, m.celular, m.nomMasc, m.idMascota " &
                                           "FROM mascota m WHERE DATE(m.fecha) = CURDATE() " &
                                           "ORDER BY m.fecha DESC LIMIT 1"
        Dim command As New MySqlCommand(queryUltimaMascota, connection)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                txtNombreCliente.Text = reader("nomCliente").ToString()
                txtApellidoCliente.Text = reader("apCliente").ToString()
                txtTelefono.Text = reader("celular").ToString()
                txtNombreMascota.Text = reader("nomMasc").ToString()

                ' Cargar servicios realizados
                Dim idMascota As Integer = Convert.ToInt32(reader("idMascota"))
                reader.Close()
                CargarServiciosRealizados(idMascota)
            Else
                MessageBox.Show("No se encontró ninguna mascota registrada el día de hoy.", "Información")
                reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos de la última mascota registrada: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub CargarServiciosRealizados(idMascota As Integer)
        Dim queryServicios As String = "
        SELECT 'Consulta' AS Servicio, c.costoCons AS Costo, c.observaciones AS Descripción 
        FROM consulta c 
        WHERE c.idMascota = @idMascota AND DATE(c.fechaConsulta) = CURDATE()

        UNION ALL 

        SELECT 'Cirugía' AS Servicio, ci.costo AS Costo, tc.nombre AS Descripción 
        FROM cirugia ci 
        JOIN tipocirugia tc ON ci.idTipoCirugia = tc.idTipoCirugia 
        WHERE ci.idMascota = @idMascota AND ci.fecha = CURDATE()

        UNION ALL 

        SELECT 'Servicio Estético' AS Servicio, e.precio AS Costo, e.nombreServicio AS Descripción 
        FROM serviciosestetica se 
        JOIN estetica e ON se.idEstetica = e.idEstetica 
        WHERE se.idMascota = @idMascota AND DATE(se.horaEntrada) = CURDATE()

        UNION ALL 

        SELECT 'Desparasitación' AS Servicio, d.costo AS Costo, d.nombre AS Descripción 
        FROM registrodesparacitacion rd 
        JOIN desparacitacion d ON rd.idDesparacitacion = d.idDesparacitacion 
        WHERE rd.idMascota = @idMascota AND DATE(rd.fecha) = CURDATE()

        UNION ALL 

        SELECT 'Vacunación' AS Servicio, v.precio AS Costo, v.nombreVac AS Descripción 
        FROM registrovacunacion rv 
        JOIN vacuna v ON rv.idVacuna = v.idVacuna 
        WHERE rv.idMascota = @idMascota AND rv.fecha = CURDATE()

        UNION ALL 

        SELECT 'Hospitalización' AS Servicio, h.costo AS Costo, h.tipoHospitalizacion AS Descripción 
        FROM hospitalizacion h 
        WHERE h.idMascota = @idMascota AND DATE(h.fechaEntrada) = CURDATE()

        UNION ALL 

        SELECT 'Pensión' AS Servicio, p.costoTotal AS Costo, 'Pensión' AS Descripción 
        FROM pension p 
        WHERE p.idMascota = @idMascota AND DATE(p.fechaEntrada) = CURDATE()

        UNION ALL 

        SELECT 'Profilaxis Dental' AS Servicio, pp.precio AS Costo, 'Profilaxis Dental' AS Descripción 
        FROM profilaxisdental pd 
        JOIN precioprofilaxis pp ON pd.idPrecioProfilaxis = pp.idPrecioProfilaxis 
        WHERE pd.idMascota = @idMascota AND DATE(pd.fecha) = CURDATE()

        UNION ALL 

        SELECT 'Eutanasia' AS Servicio, e.costoFinal AS Costo, 'Eutanasia' AS Descripción 
        FROM eutanasia e 
        WHERE e.idMascota = @idMascota AND DATE(e.fecha) = CURDATE()

        UNION ALL 

        SELECT 'Esterilización' AS Servicio, rp.costo AS Costo, rp.tipoProcedimiento AS Descripción 
FROM registroprocedimiento rp 
WHERE rp.idMascota = @idMascota AND rp.tipoProcedimiento = 'Esterilizacion' AND DATE(rp.fecha) = CURDATE()

    "

        Dim command As New MySqlCommand(queryServicios, connection)
        command.Parameters.AddWithValue("@idMascota", idMascota)

        Dim totalCosto As Decimal = 0

        Try
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Mostrar datos en el DataGridView
            dgvServicios.DataSource = table

            ' Calcular el total
            For Each row As DataRow In table.Rows
                totalCosto += Convert.ToDecimal(row("Costo"))
            Next

            ' Mostrar el total a pagar
            txtTotalPagar.Text = totalCosto.ToString("C")
        Catch ex As Exception
            MessageBox.Show("Error al cargar los servicios realizados: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()
        Me.Close()
    End Sub
End Class
