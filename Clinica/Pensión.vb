Imports MySql.Data.MySqlClient
Public Class Pensión
    Private connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
    Private costoDiario As Decimal = 250D
    Private Function CalcularCostoTotal() As Decimal
        Dim diasEstancia As Integer = (dtpFechaSalida.Value.Date - dtpFechaEntrada.Value.Date).Days
        Return diasEstancia * costoDiario
    End Function

    Private Sub RegistrarPension()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Pension (idMascota, fechaEntrada, fechaSalida, horaEntrada, horaSalida, observaciones, costoDiario, costoTotal) " &
                                      "VALUES (@idMascota, @fechaEntrada, @fechaSalida, @horaEntrada, @horaSalida, @observaciones, @costoDiario, @costoTotal)"

                Using cmd As New MySqlCommand(query, connection)
                    Dim idMascota As Integer = ObtenerUltimoIdMascota(connection)

                    cmd.Parameters.AddWithValue("@idMascota", idMascota)
                    cmd.Parameters.AddWithValue("@fechaEntrada", dtpFechaEntrada.Value.Date)
                    cmd.Parameters.AddWithValue("@fechaSalida", dtpFechaSalida.Value.Date)
                    cmd.Parameters.AddWithValue("@horaEntrada", dtpHoraEntrada.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@horaSalida", dtpHoraSalida.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@observaciones", txtObservaciones.Text)
                    cmd.Parameters.AddWithValue("@costoDiario", costoDiario)
                    cmd.Parameters.AddWithValue("@costoTotal", CalcularCostoTotal())

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Registro de pensión exitoso.")
            CargarDatosPension()
        Catch ex As Exception
            MessageBox.Show("Error al registrar la pensión: " & ex.Message)
        End Try
    End Sub


    Private Function ObtenerUltimoIdMascota(connection As MySqlConnection) As Integer
        Dim idMascota As Integer = 0
        Try
            Dim query As String = "SELECT MAX(idMascota) FROM Mascota"
            Using cmd As New MySqlCommand(query, connection)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    idMascota = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID de la mascota: " & ex.Message)
        End Try
        Return idMascota
    End Function


    Private Sub CargarDatosPension()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT M.nomMasc AS 'Nombre de la Mascota', P.fechaEntrada AS 'Fecha de Entrada', " &
                                      "P.fechaSalida AS 'Fecha de Salida', P.horaEntrada AS 'Hora de Entrada', P.horaSalida AS 'Hora de Salida', " &
                                      "P.observaciones AS 'Observaciones', P.costoDiario AS 'Costo Diario', P.costoTotal AS 'Costo Total' " &
                                      "FROM Pension P JOIN Mascota M ON P.idMascota = M.idMascota"

                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                dgvPension.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos de la pensión: " & ex.Message)
        End Try
    End Sub

    Private Sub dtpFechaEntrada_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEntrada.ValueChanged, dtpFechaSalida.ValueChanged
        txtCostoDiario.Text = costoDiario.ToString("C")
        txtCostoTotal.Text = CalcularCostoTotal().ToString("C")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        RegistrarPension()
    End Sub

    Private Sub Pensión_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosPension()
        txtCostoDiario.Text = costoDiario.ToString("C")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BuscarPension()
    End Sub

    Private Sub BuscarPension()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT M.nomMasc AS 'Nombre de la Mascota', P.fechaEntrada AS 'Fecha de Entrada', " &
                                      "P.fechaSalida AS 'Fecha de Salida', P.horaEntrada AS 'Hora de Entrada', P.horaSalida AS 'Hora de Salida', " &
                                      "P.observaciones AS 'Observaciones', P.costoDiario AS 'Costo Diario', P.costoTotal AS 'Costo Total' " &
                                      "FROM Pension P JOIN Mascota M ON P.idMascota = M.idMascota " &
                                      "WHERE P.fechaEntrada >= @fechaEntrada AND P.fechaSalida <= @fechaSalida"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@fechaEntrada", dtpFechaEntrada.Value.Date)
                    cmd.Parameters.AddWithValue("@fechaSalida", dtpFechaSalida.Value.Date)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    dgvPension.DataSource = dataTable

                    If dataTable.Rows.Count = 0 Then
                        MessageBox.Show("No se encontraron registros para el rango de fechas especificado.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar registros: " & ex.Message)
        End Try
    End Sub
    Private Sub LlenarComboBoxServicios()
        ComboBoxServicios.Items.Clear()
        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxServicios.Items.Add(New With {.Value = reader("idServicio"), .Text = reader("nombre")})
                End While
            End Using
        End Using
        ComboBoxServicios.DisplayMember = "Text"
        ComboBoxServicios.ValueMember = "Value"
    End Sub
    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxServicios.SelectedIndexChanged

        Dim servicioSeleccionado As Object = ComboBoxServicios.SelectedItem
        If servicioSeleccionado Is Nothing Then
            MessageBox.Show("Por favor, selecciona un servicio.")
            Return
        End If

        Dim idServicio As Integer = servicioSeleccionado.Value

        Select Case idServicio
            Case 1 ' 
                Dim formCirugia As New Cirugía()
                formCirugia.Show()
                Me.Hide()

            Case 2 ' 
                Dim consultamedica As New Consulta_Médica()
                consultamedica.Show()
                Me.Hide()

            Case 3
                Dim formDesparacitacion As New DesparacitacionForm()
                formDesparacitacion.Show()
                Me.Hide()

            Case 4
                Dim formEsterilizacion As New Castración_y_Esterilización()
                formEsterilizacion.Show()
                Me.Hide()

            Case 5
                Dim formPension As New Pensión()
                formPension.Show()
                Me.Hide()

            Case 6
                Dim formGrooming As New Estética()
                formGrooming.Show()
                Me.Hide()
            Case 7
                Dim formEutanasia As New Eutanasia()
                formEutanasia.Show()
                Me.Hide()

            Case 8
                Dim formGrooming As New Vacunacion()
                formGrooming.Show()
                Me.Hide()

            Case 9
                Dim formHospitalizacion As New Hospitalización()
                formHospitalizacion.Show()
                Me.Hide()
            Case 10
                Dim formProfilaxis As New Proaxis_Dental()
                formProfilaxis.Show()
                Me.Hide()
            Case 11
                Dim formmRecibo As New Recibo()
                formmRecibo.Show()
                Me.Hide()
            Case Else
                MessageBox.Show("Servicio no reconocido. Por favor, selecciona un servicio válido.")

        End Select
    End Sub
    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()

        Me.Close()
    End Sub

End Class