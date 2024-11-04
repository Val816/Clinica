Imports MySql.Data.MySqlClient

Public Class Hospitalización
    Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)
    Dim idTallaUltimaMascota As Integer
    Dim costoDiario As Decimal

    Private Sub FormHospitalizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipo.Items.Add("General")
        cmbTipo.Items.Add("Infecciosa")
        Dim idUltimaMascota As Integer = ObtenerUltimoIdMascota(connection)
        idTallaUltimaMascota = ObtenerTallaUltimaMascota(connection, idUltimaMascota)
        LlenarComboBoxServicios()
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        Dim tipo As String = cmbTipo.SelectedItem.ToString()
        costoDiario = CalcularCostoDiario(tipo, idTallaUltimaMascota)
        CalcularCostoTotal()
    End Sub

    Private Sub dtpFechaEntrada_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEntrada.ValueChanged
        CalcularCostoTotal()
    End Sub

    Private Sub dtpFechaSalida_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaSalida.ValueChanged
        CalcularCostoTotal()
    End Sub

    Private Sub CalcularCostoTotal()
        Dim fechaEntrada As Date = dtpFechaEntrada.Value.Date
        Dim fechaSalida As Date = dtpFechaSalida.Value.Date
        Dim diasHospitalizacion As Integer = (fechaSalida - fechaEntrada).Days

        If diasHospitalizacion < 0 Then
            MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de entrada.")
            txtCosto.Text = "0.00"
            Return
        End If

        Dim costoTotal As Decimal = diasHospitalizacion * costoDiario
        txtCosto.Text = costoTotal.ToString("F2")
    End Sub

    Private Function ObtenerUltimoIdMascota(connection As MySqlConnection) As Integer
        Dim idMascota As Integer = 0
        Try
            connection.Open()
            Dim query As String = "SELECT MAX(idMascota) FROM Mascota"
            Dim cmd As New MySqlCommand(query, connection)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                idMascota = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID de la mascota: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return idMascota
    End Function

    Private Function ObtenerTallaUltimaMascota(connection As MySqlConnection, idMascota As Integer) As Integer
        Dim idTalla As Integer = 0
        Try
            connection.Open()
            Dim query As String = "SELECT idTalla FROM Mascota WHERE idMascota = @idMascota"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@idMascota", idMascota)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                idTalla = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener la Talla de la última mascota: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return idTalla
    End Function

    Private Function CalcularCostoDiario(tipo As String, idTalla As Integer) As Decimal
        Dim costo As Decimal = 0
        Try
            connection.Open()
            Dim query As String = "SELECT costo FROM CostoHospitalizacion WHERE tipoHospitalizacion = @tipo AND idTalla = @idTalla"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@tipo", tipo)
            cmd.Parameters.AddWithValue("@idTalla", idTalla)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                costo = reader.GetDecimal("costo")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al calcular el costo diario: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return costo
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fechaEntrada As Date = dtpFechaEntrada.Value.Date
        Dim horaEntrada As TimeSpan = dtpHoraEntrada.Value.TimeOfDay
        Dim fechaSalida As Date = dtpFechaSalida.Value.Date
        Dim horaSalida As TimeSpan = dtpHoraSalida.Value.TimeOfDay
        Dim observaciones As String = TxtObservaciones.Text
        Dim medicina As String = txtMedicina.Text
        Dim tipo As String = cmbTipo.SelectedItem.ToString()
        Dim idMascota As Integer = ObtenerUltimoIdMascota(connection)
        Dim costo As Decimal = Decimal.Parse(txtCosto.Text)

        Try
            connection.Open()
            Dim query As String = "INSERT INTO Hospitalizacion (idMascota, tipoHospitalizacion, idTalla, fechaEntrada, horaEntrada, fechaSalida, horaSalida, observaciones, medicamentos, costo) " &
                                  "VALUES (@idMascota, @tipoHospitalizacion, @idTalla, @fechaEntrada, @horaEntrada, @fechaSalida, @horaSalida, @observaciones, @medicamentos, @costo)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@idMascota", idMascota)
            cmd.Parameters.AddWithValue("@tipoHospitalizacion", tipo)
            cmd.Parameters.AddWithValue("@idTalla", idTallaUltimaMascota)
            cmd.Parameters.AddWithValue("@fechaEntrada", fechaEntrada)
            cmd.Parameters.AddWithValue("@horaEntrada", horaEntrada)
            cmd.Parameters.AddWithValue("@fechaSalida", fechaSalida)
            cmd.Parameters.AddWithValue("@horaSalida", horaSalida)
            cmd.Parameters.AddWithValue("@observaciones", observaciones)
            cmd.Parameters.AddWithValue("@medicamentos", medicina)
            cmd.Parameters.AddWithValue("@costo", costo)

            cmd.ExecuteNonQuery()
            MessageBox.Show("¡Hospitalización guardada exitosamente!")
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        Finally
            connection.Close()
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
