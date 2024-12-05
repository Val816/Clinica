Imports MySql.Data.MySqlClient

Public Class Hospitalización
    Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)
    Dim idTallaUltimaMascota As Integer
    Dim idUltimaMascota As Integer
    Dim costoDiario As Decimal

    Private Sub FormHospitalizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipo.Items.Add("General")
        cmbTipo.Items.Add("Infecciosa")
        idUltimaMascota = ObtenerUltimoIdMascota()
        idTallaUltimaMascota = ObtenerTallaUltimaMascota(idUltimaMascota)

        ' Llenar combo de servicios
        LlenarComboBoxServicios()
    End Sub

    Private Function ObtenerUltimoIdMascota() As Integer
        Dim idMascota As Integer = 0
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT MAX(idMascota) FROM Mascota"
                Using cmd As New MySqlCommand(query, connection)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        idMascota = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID de la mascota: " & ex.Message)
        End Try
        Return idMascota
    End Function

    Private Function ObtenerTallaUltimaMascota(idMascota As Integer) As Integer
        Dim idTalla As Integer = 0
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT idTalla FROM Mascota WHERE idMascota = @idMascota"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@idMascota", idMascota)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        idTalla = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener la Talla de la última mascota: " & ex.Message)
        End Try
        Return idTalla
    End Function


    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        Dim tipo As String = cmbTipo.SelectedItem.ToString()
        costoDiario = CalcularCostoDiario(tipo, idTallaUltimaMascota)
        CalcularCostoTotal()
    End Sub

    Private Sub CalcularCostoTotal()
        Dim fechaEntrada As Date = dtpFechaEntrada.Value.Date
        Dim fechaSalida As Date = dtpFechaSalida.Value.Date
        Dim diasHospitalizacion As Integer = Math.Max(0, (fechaSalida - fechaEntrada).Days)

        If diasHospitalizacion = 0 Then
            MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de entrada.")
            txtCostoConvertido.Text = "0.00"
            Return
        End If

        Dim costoTotal As Decimal = diasHospitalizacion * costoDiario
        txtCostoConvertido.Text = costoTotal.ToString("F2")
    End Sub


    Private Function CalcularCostoDiario(tipo As String, idTalla As Integer) As Decimal
        ' Define los costos
        Dim costos As New Dictionary(Of String, Dictionary(Of Integer, Decimal)) From {
        {"General", New Dictionary(Of Integer, Decimal) From {{1, 400}, {2, 500}, {3, 550}}},
        {"Infecciosa", New Dictionary(Of Integer, Decimal) From {{1, 550}, {2, 600}, {3, 650}}}
    }

        ' Verifica si existen los costos para el tipo y talla
        If costos.ContainsKey(tipo) AndAlso costos(tipo).ContainsKey(idTalla) Then
            Return costos(tipo)(idTalla)
        Else
            MessageBox.Show("No se encontraron costos para el tipo de hospitalización y talla seleccionados.")
            Return 0
        End If
    End Function


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cmbTipo.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor selecciona un tipo de hospitalización.")
            Return
        End If

        Dim fechaEntrada As Date = dtpFechaEntrada.Value.Date
        Dim fechaSalida As Date = dtpFechaSalida.Value.Date
        Dim diasHospitalizacion As Integer = Math.Max(1, (fechaSalida - fechaEntrada).Days + 1)
        Dim costo As Decimal

        If Not Decimal.TryParse(txtCostoConvertido.Text, costo) Then
            MessageBox.Show("El costo total no es válido.")
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Hospitalizacion (idMascota, tipoHospitalizacion, idTalla, fechaEntrada, horaEntrada, fechaSalida, horaSalida, observaciones, medicamentos, costo) " &
                                  "VALUES (@idMascota, @tipoHospitalizacion, @idTalla, @fechaEntrada, @horaEntrada, @fechaSalida, @horaSalida, @observaciones, @medicamentos, @costo)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@idMascota", idUltimaMascota)
                    cmd.Parameters.AddWithValue("@tipoHospitalizacion", cmbTipo.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@idTalla", idTallaUltimaMascota)
                    cmd.Parameters.AddWithValue("@fechaEntrada", fechaEntrada)
                    cmd.Parameters.AddWithValue("@horaEntrada", dtpHoraEntrada.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@fechaSalida", fechaSalida)
                    cmd.Parameters.AddWithValue("@horaSalida", dtpHoraSalida.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@observaciones", TxtObservaciones.Text)
                    cmd.Parameters.AddWithValue("@medicamentos", txtMedicina.Text)
                    cmd.Parameters.AddWithValue("@costo", costo)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("¡Hospitalización guardada exitosamente!")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar la hospitalización: " & ex.Message)
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
