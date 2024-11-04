Imports MySql.Data.MySqlClient

Public Class DesparacitacionForm
    Dim connection As New MySqlConnection("server=localhost;userid=root;password=root;database=veterinaria")

    Private Sub FormDesparacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBoxDesparacitacion()
        LlenarComboBoxServicios()
        MostrarDatosEnDataGrid()
    End Sub

    Private Sub LlenarComboBoxDesparacitacion()
        Dim query As String = "SELECT idDesparacitacion, nombre FROM desparacitacion"

        Try
            Using connection As New MySqlConnection("server=localhost;userid=root;password=root;database=veterinaria")
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                cbDesparacitacion.Items.Clear()
                While reader.Read()
                    cbDesparacitacion.Items.Add(New DesparacitacionItem(reader("nombre").ToString(), Convert.ToInt32(reader("idDesparacitacion"))))
                End While
            End Using

            Dim idMascota As Integer = ObtenerUltimoIdMascota()
            If idMascota > 0 Then
                Dim idTalla As Integer = ObtenerIdTallaDeMascota(idMascota)
                Dim desparacitacionSeleccionada As Integer = ObtenerDesparacitacionPorTalla(idTalla)

                For Each item As DesparacitacionItem In cbDesparacitacion.Items
                    If item.IdDesparacitacion = desparacitacionSeleccionada Then
                        cbDesparacitacion.SelectedItem = item
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("No se encontró ninguna mascota registrada.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar desparacitaciones: " & ex.Message)
        End Try
    End Sub



    Private Sub cbDesparacitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDesparacitacion.SelectedIndexChanged
        If cbDesparacitacion.SelectedItem IsNot Nothing Then
            Dim selectedDesparacitacion As DesparacitacionItem = DirectCast(cbDesparacitacion.SelectedItem, DesparacitacionItem)

            Dim query As String = "SELECT costo FROM desparacitacion WHERE idDesparacitacion = @id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", selectedDesparacitacion.IdDesparacitacion)

            Try
                connection.Open()
                Dim costo As Object = cmd.ExecuteScalar()
                If costo IsNot Nothing Then
                    txtCosto.Text = costo.ToString()
                Else
                    txtCosto.Clear()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al obtener costo: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim idMascota As Integer = ObtenerUltimoIdMascota()

        If idMascota > 0 Then
            If cbDesparacitacion.SelectedItem IsNot Nothing Then
                Dim selectedDesparacitacion As DesparacitacionItem = DirectCast(cbDesparacitacion.SelectedItem, DesparacitacionItem)
                Dim idDesparacitacion As Integer = selectedDesparacitacion.IdDesparacitacion

                Dim fecha As Date = DateTime.Now
                Dim observaciones As String = txtObservaciones.Text

                Dim query As String = "INSERT INTO registrodesparacitacion (idMascota, idDesparacitacion, fecha, observaciones) " &
                                  "VALUES (@idMascota, @idDesparacitacion, @fecha, @observaciones)"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                cmd.Parameters.AddWithValue("@idDesparacitacion", idDesparacitacion)
                cmd.Parameters.AddWithValue("@fecha", fecha)
                cmd.Parameters.AddWithValue("@observaciones", observaciones)

                Try
                    connection.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro de desparacitación guardado correctamente.")
                    MostrarDatosEnDataGrid()
                Catch ex As MySqlException
                    MessageBox.Show("Error de MySQL al guardar registro: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error al guardar registro: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            Else
                MessageBox.Show("Por favor, selecciona una desparacitación antes de guardar.")
            End If
        Else
            MessageBox.Show("No se encontró ninguna mascota registrada.")
        End If
    End Sub


    Private Sub MostrarDatosEnDataGrid()
        Dim query As String = "SELECT m.nomMasc AS Mascota, d.nombre AS Desparacitacion, r.fecha, r.observaciones " &
                      "FROM registrodesparacitacion r " &
                      "JOIN desparacitacion d ON r.idDesparacitacion = d.idDesparacitacion " &
                      "JOIN mascota m ON r.idMascota = m.idMascota " &
                      "ORDER BY r.fecha ASC"

        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim table As New DataTable()

        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            adapter.Fill(table)
            dataGridDesparacitaciones.DataSource = table
        Catch ex As MySqlException
            MessageBox.Show("Error de MySQL al cargar registros: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error al cargar registros: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    '
    Private Function ObtenerUltimoIdMascota() As Integer
        Dim idMascota As Integer = 0
        Dim query As String = "SELECT MAX(idMascota) FROM Mascota"

        Try
            Using connection As New MySqlConnection("server=localhost;userid=root;password=root;database=veterinaria")
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                idMascota = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar ID de mascota: " & ex.Message)
        End Try

        Return idMascota
    End Function

    Private Function ObtenerDesparacitacionPorTalla(idTalla As Integer) As Integer
        Dim desparacitacionSeleccionada As Integer = 0
        Dim query As String = "SELECT idDesparacitacion FROM desparacitacion WHERE idTalla = @idTalla"

        Try
            Using connection As New MySqlConnection("server=localhost;userid=root;password=root;database=veterinaria")
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@idTalla", idTalla)
                desparacitacionSeleccionada = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener la desparacitación: " & ex.Message)
        End Try

        Return desparacitacionSeleccionada
    End Function

    Private Function ObtenerIdTallaDeMascota(idMascota As Integer) As Integer
        Dim idTalla As Integer = 0
        Dim query As String = "SELECT idTalla FROM Mascota WHERE idMascota = @idMascota"

        Try
            Using connection As New MySqlConnection("server=localhost;userid=root;password=root;database=veterinaria")
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                idTalla = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener la talla de la mascota: " & ex.Message)
        End Try

        Return idTalla
    End Function

    Private Sub LlenarComboBoxServicios()
        ComboBoxServicios.Items.Clear()
        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using cmd As New MySqlCommand(query, connection)
            Try
                connection.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxServicios.Items.Add(New KeyValuePair(Of Integer, String)(Convert.ToInt32(reader("idServicio")), reader("nombre").ToString()))
                End While
            Catch ex As Exception
                MessageBox.Show("Error al cargar servicios: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        ComboBoxServicios.DisplayMember = "Value"
        ComboBoxServicios.ValueMember = "Key"
    End Sub

    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxServicios.SelectedIndexChanged
        Dim servicioSeleccionado As KeyValuePair(Of Integer, String) = DirectCast(ComboBoxServicios.SelectedItem, KeyValuePair(Of Integer, String))
        If servicioSeleccionado.Key = 0 Then Return ' Salir si no hay servicio seleccionado

        Select Case servicioSeleccionado.Key
            Case 1
                Dim formCirugia As New Cirugía()
                formCirugia.Show()
                Me.Hide()

            Case 2
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
                MessageBox.Show("Servicio no disponible.")
        End Select
    End Sub

    Private Class DesparacitacionItem
        Public Property Nombre As String
        Public Property IdDesparacitacion As Integer

        Public Sub New(nombre As String, idDesparacitacion As Integer)
            Me.Nombre = nombre
            Me.IdDesparacitacion = idDesparacitacion
        End Sub

        Public Overrides Function ToString() As String
            Return Nombre
        End Function
    End Class
End Class
