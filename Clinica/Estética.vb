Imports MySql.Data.MySqlClient

Public Class Estética
    Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
    Dim esteticas As New Dictionary(Of Integer, Tuple(Of String, Decimal))

    Private costosEstetica As New Dictionary(Of String, Dictionary(Of String, Decimal)) From {
        {"Baño", New Dictionary(Of String, Decimal) From {
            {"pequeña", 400},
            {"mediana", 650},
            {"grande", 900}
        }},
        {"Corte de Pelo", New Dictionary(Of String, Decimal) From {
            {"pequeña", 200},
            {"mediana", 350},
            {"grande", 700}
        }},
        {"Corte de Uñas", New Dictionary(Of String, Decimal) From {
            {"pequeña", 100},
            {"mediana", 150},
            {"grande", 200}
            }},
        {"Cepillado", New Dictionary(Of String, Decimal) From {
            {"pequeña", 150},
            {"mediana", 250},
            {"grande", 350}
        }},
        {"Perfumado", New Dictionary(Of String, Decimal) From {
            {"pequeña", 50},
            {"mediana", 75},
            {"grande", 100}
        }},
        {"Spa", New Dictionary(Of String, Decimal) From {
            {"pequeña", 350},
            {"mediana", 425},
            {"grande", 570}
        }}
    }

    Private Sub EsteticaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEsteticas()
        LlenarComboBoxServicios()
    End Sub

    Private Sub LoadEsteticas()
        CheckListEsteticas.Items.Clear()
        txtTotalEstetica.Text = "0.00"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("SELECT idEstetica, nombreServicio, precio FROM Estetica", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim idEstetica As Integer = reader.GetInt32(0)
                Dim nombreEstetica As String = reader.GetString(1)
                Dim precio As Decimal = reader.GetDecimal(2)
                esteticas.Add(idEstetica, New Tuple(Of String, Decimal)(nombreEstetica, precio))
                CheckListEsteticas.Items.Add(nombreEstetica)
            End While
        End Using
    End Sub


    Private Sub CheckListEsteticas_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckListEsteticas.ItemCheck

        Me.BeginInvoke(Sub()
                           Dim totalPrecio As Decimal = 0
                           For i As Integer = 0 To CheckListEsteticas.Items.Count - 1
                               If CheckListEsteticas.GetItemChecked(i) Then
                                   Dim idEstetica As Integer = esteticas.Keys.ElementAt(i)
                                   totalPrecio += esteticas(idEstetica).Item2
                               End If
                           Next
                           txtTotalEstetica.Text = totalPrecio.ToString("C")

                       End Sub)
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim observaciones As String = txtObservaciones.Text.Trim()

        If String.IsNullOrEmpty(observaciones) Then
            MessageBox.Show("Las observaciones no pueden estar vacías.")
            Return
        End If

        Dim idMascota As Integer
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
            Catch ex As Exception
                MessageBox.Show("Error al abrir la conexión: " & ex.Message)
                Return
            End Try

            idMascota = ObtenerUltimoIdMascota(connection)

            If idMascota = 0 Then
                MessageBox.Show("No se encontraron mascotas registradas.")
                Return
            End If

            Dim fechaEntrada As DateTime = DateTime.Now
            Dim horaSalida As DateTime = fechaEntrada.AddHours(1)
            Dim tallaMascota As String = ObtenerTallaMascota(idMascota)
            Dim costoTotal As Decimal = 0
            Dim esteticasSeleccionadas As Boolean = False
            Dim serviciosNoRegistrados As New List(Of String)()

            ' Recorre los servicios seleccionados
            For i As Integer = 0 To CheckListEsteticas.Items.Count - 1
                If CheckListEsteticas.GetItemChecked(i) Then
                    Dim servicio As String = CheckListEsteticas.Items(i).ToString()
                    Dim idEstetica As Integer = esteticas.Keys.ElementAt(i)

                    If costosEstetica.ContainsKey(servicio) AndAlso costosEstetica(servicio).ContainsKey(tallaMascota) Then
                        Dim costoServicio As Decimal = costosEstetica(servicio)(tallaMascota)
                        costoTotal += costoServicio
                        esteticasSeleccionadas = True

                        ' Guardar cada servicio seleccionado en la base de datos
                        Using command As New MySqlCommand("INSERT INTO serviciosestetica (idMascota, idEstetica, horaEntrada, horaSalida, observaciones,costo) VALUES (@idMascota, @idEstetica, @horaEntrada, @horaSalida, @observaciones,@costo)", connection)
                            command.Parameters.AddWithValue("@idMascota", idMascota)
                            command.Parameters.AddWithValue("@idEstetica", idEstetica)
                            command.Parameters.AddWithValue("@horaEntrada", fechaEntrada)
                            command.Parameters.AddWithValue("@horaSalida", horaSalida)
                            command.Parameters.AddWithValue("@observaciones", observaciones)
                            command.Parameters.AddWithValue("@costo", costoServicio)

                            Try
                                command.ExecuteNonQuery()
                            Catch ex As MySqlException
                                serviciosNoRegistrados.Add(servicio)
                            End Try
                        End Using
                    Else
                        serviciosNoRegistrados.Add(servicio)
                    End If
                End If
            Next

            ' Mostrar el total y los mensajes correspondientes
            If esteticasSeleccionadas Then
                txtTotalEstetica.Text = costoTotal.ToString("C")
                MessageBox.Show("El costo total de los servicios estéticos es: " & costoTotal.ToString("C2"))
                If serviciosNoRegistrados.Count > 0 Then
                    MessageBox.Show("Los siguientes servicios no se pudieron registrar: " & String.Join(", ", serviciosNoRegistrados))
                Else
                    MessageBox.Show("Todos los servicios estéticos se han registrado exitosamente.")
                End If
            Else
                MessageBox.Show("No se seleccionó ningún servicio estético.")
            End If
        End Using
    End Sub


    Private Function ObtenerUltimoIdMascota(connection As MySqlConnection) As Integer
        Dim idMascota As Integer = 0

        Dim command As New MySqlCommand("SELECT MAX(idMascota) FROM Mascota", connection)
        Dim result = command.ExecuteScalar()
        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
            idMascota = Convert.ToInt32(result)
        End If

        Return idMascota
    End Function

    Private Function ObtenerTallaMascota(idMascota As Integer) As String
        Dim talla As String = String.Empty

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT idTalla FROM Mascota WHERE idMascota = @idMascota"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Dim idTalla As Integer = Convert.ToInt32(result)
                    talla = ObtenerNombreTalla(idTalla)
                End If
            End Using
        End Using

        Return talla
    End Function

    Private Function ObtenerNombreTalla(idTalla As Integer) As String
        Select Case idTalla
            Case 1
                Return "pequeña"
            Case 2
                Return "mediana"
            Case 3
                Return "grande"
            Case Else
                Return String.Empty
        End Select
    End Function

    Private Sub LlenarComboBoxServicios()
        ComboBoxServicios.Items.Clear()
        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using conn As New MySqlConnection(connectionString)
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
                Dim formVacunacion As New Vacunacion()
                formVacunacion.Show()
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
