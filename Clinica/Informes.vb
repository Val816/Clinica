Imports MySql.Data.MySqlClient
Public Class Informes
    Dim connection As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")

    ' Evento al hacer click en el botón de Generar Informe
    Private Sub ButtonGenerarInforme_Click(sender As Object, e As EventArgs) Handles ButtonGenerarInforme.Click
            Try
                ' Abrir la conexión
                connection.Open()

                ' Filtrar por mascota seleccionada
                Dim queryMascota As String = "SELECT m.nomMascota, m.nomCliente, s.nombreServicio, hs.fechaServicio, hs.costo " &
                                         "FROM HistorialServicio hs " &
                                         "INNER JOIN Mascota m ON hs.idMascota = m.idMascota " &
                                         "INNER JOIN Servicio s ON hs.idServicio = s.idServicio " &
                                         "WHERE hs.fechaServicio BETWEEN @fechaInicio AND @fechaFin"

                ' Aplicar filtros de ComboBox
                If ComboBoxMascota.SelectedIndex <> -1 Then
                    queryMascota &= " AND m.nomMascota = @mascota"
                End If

                If ComboBoxEspecie.SelectedIndex <> -1 Then
                    queryMascota &= " AND m.idEspecie = @especie"
                End If

                If ComboBoxServicio.SelectedIndex <> -1 Then
                    queryMascota &= " AND s.nombreServicio = @servicio"
                End If

                ' Preparar la consulta
                Dim commandMascota As New MySqlCommand(queryMascota, connection)
                commandMascota.Parameters.AddWithValue("@fechaInicio", DateTimePickerInicio.Value.ToString("yyyy-MM-dd"))
                commandMascota.Parameters.AddWithValue("@fechaFin", DateTimePickerFin.Value.ToString("yyyy-MM-dd"))

                If ComboBoxMascota.SelectedIndex <> -1 Then
                    commandMascota.Parameters.AddWithValue("@mascota", ComboBoxMascota.SelectedItem.ToString())
                End If

                If ComboBoxEspecie.SelectedIndex <> -1 Then
                    commandMascota.Parameters.AddWithValue("@especie", ComboBoxEspecie.SelectedValue)
                End If

                If ComboBoxServicio.SelectedIndex <> -1 Then
                    commandMascota.Parameters.AddWithValue("@servicio", ComboBoxServicio.SelectedItem.ToString())
                End If

                ' Cargar los datos en el DataGridView
                Dim adapter As New MySqlDataAdapter(commandMascota)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DataGridViewResultados.DataSource = dt

                ' Mostrar totales
                TextBoxTotalMascotas.Text = dt.Rows.Count.ToString()

                ' Filtrar por especie
                Dim especieQuery As String = "SELECT m.idEspecie, e.nombreEspecie, COUNT(m.idMascota) AS TotalEspecie " &
                                         "FROM Mascota m " &
                                         "INNER JOIN Especie e ON m.idEspecie = e.idEspecie " &
                                         "WHERE m.fechaRegistro BETWEEN @fechaInicio AND @fechaFin"
                Dim commandEspecie As New MySqlCommand(especieQuery, connection)
                commandEspecie.Parameters.AddWithValue("@fechaInicio", DateTimePickerInicio.Value.ToString("yyyy-MM-dd"))
                commandEspecie.Parameters.AddWithValue("@fechaFin", DateTimePickerFin.Value.ToString("yyyy-MM-dd"))
                Dim adapterEspecie As New MySqlDataAdapter(commandEspecie)
                Dim dtEspecie As New DataTable()
                adapterEspecie.Fill(dtEspecie)
                TextBoxTotalEspecie.Text = dtEspecie.Rows.Count.ToString()

                ' Filtrar por servicio más realizado
                Dim servicioQuery As String = "SELECT s.nombreServicio, COUNT(hs.idServicio) AS TotalServicio, SUM(hs.costo) AS DineroRecaudado " &
                                         "FROM HistorialServicio hs " &
                                         "INNER JOIN Servicio s ON hs.idServicio = s.idServicio " &
                                         "WHERE hs.fechaServicio BETWEEN @fechaInicio AND @fechaFin " &
                                         "GROUP BY s.nombreServicio"
                Dim commandServicio As New MySqlCommand(servicioQuery, connection)
                commandServicio.Parameters.AddWithValue("@fechaInicio", DateTimePickerInicio.Value.ToString("yyyy-MM-dd"))
                commandServicio.Parameters.AddWithValue("@fechaFin", DateTimePickerFin.Value.ToString("yyyy-MM-dd"))
                Dim adapterServicio As New MySqlDataAdapter(commandServicio)
                Dim dtServicio As New DataTable()
                adapterServicio.Fill(dtServicio)

                ' Mostrar el servicio más realizado y dinero recaudado
                If dtServicio.Rows.Count > 0 Then
                    Dim servicioMasDado As DataRow = dtServicio.Rows(0)
                    TextBoxServicioMasDado.Text = servicioMasDado("nombreServicio").ToString()
                    TextBoxDineroRecaudado.Text = servicioMasDado("DineroRecaudado").ToString()
                End If

            Catch ex As Exception
                MessageBox.Show("Error al generar el informe: " & ex.Message)
            Finally
                ' Cerrar la conexión
                connection.Close()
            End Try
        End Sub

        ' Evento para imprimir el informe
        Private Sub ButtonImprimir_Click(sender As Object, e As EventArgs) Handles ButtonImprimir.Click
            ' Aquí iría la lógica para generar el informe (puede ser un archivo PDF o impresión directa)
            ' Como ejemplo, se mostrará un mensaje.
            MessageBox.Show("Informe listo para imprimir")
        End Sub
    End Class
