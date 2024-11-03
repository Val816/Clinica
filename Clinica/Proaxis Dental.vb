Imports MySql.Data.MySqlClient

Public Class Proaxis_Dental
    Public Class ComboBoxItem
        Public Property Value As Integer
        Public Property Text As String

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub FormProfilaxisDental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar el ComboBox de tallas directamente desde la base de datos
        LlenarComboBoxTallas()
        LlenarComboBoxServicios()

        ' Cargar el registro de la mascota
        CargarDatosMascota()
    End Sub

    Private Sub LlenarComboBoxTallas()
        ComboBoxTalla.Items.Clear()
        Dim query As String = "SELECT idTalla, descripcion FROM Talla"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Dim cmd As New MySqlCommand(query, conn)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim item As New ComboBoxItem With {
                .Value = reader("idTalla"),
                .Text = reader("descripcion").ToString()
            }
                ComboBoxTalla.Items.Add(item)
            End While
        End Using
    End Sub

    Private Sub LlenarComboBoxServicios()
        ComboBoxServicios.Items.Clear()
        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim item As New ComboBoxItem With {
                        .Value = reader("idServicio"),
                        .Text = reader("nombre").ToString()
                    }
                    ComboBoxServicios.Items.Add(item)
                End While
            End Using
        End Using
    End Sub

    Private Sub CargarDatosMascota()
        Dim idMascota As Integer = 1 ' Cambia esto al ID real de la mascota que estás utilizando
        Dim query As String = "SELECT idTalla FROM Mascota WHERE idMascota = @idMascota"

        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@idMascota", idMascota)
            conn.Open()
            Dim idTalla As Object = cmd.ExecuteScalar()
            If idTalla IsNot Nothing Then
                ' Seleccionar el ComboBoxTalla basado en la talla de la mascota
                For Each item As ComboBoxItem In ComboBoxTalla.Items
                    If item.Value = Convert.ToInt32(idTalla) Then
                        ComboBoxTalla.SelectedItem = item
                        Exit For
                    End If
                Next
            End If
        End Using
    End Sub

    Private Sub ComboBoxTalla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTalla.SelectedIndexChanged
        If ComboBoxTalla.SelectedItem IsNot Nothing Then
            Dim idTallaSeleccionada As Integer = CType(ComboBoxTalla.SelectedItem, ComboBoxItem).Value
            Dim query As String = "SELECT precio FROM PrecioProfilaxis WHERE idTalla = @idTalla"

            Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idTalla", idTallaSeleccionada)
                conn.Open()
                Dim costo As Object = cmd.ExecuteScalar()
                If costo IsNot Nothing Then
                    TextBoxCosto.Text = Convert.ToDecimal(costo).ToString("C2") ' Muestra el costo en formato de moneda
                Else
                    TextBoxCosto.Text = "0.00"
                End If
            End Using
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Establecer la conexión
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            conn.Open()

            ' Obtener el ID de la última mascota registrada
            Dim idMascota As Integer = ObtenerUltimoIdMascota(conn)

            ' Asegurarse de que se haya obtenido un ID válido
            If idMascota = 0 Then
                MessageBox.Show("No se encontró ninguna mascota registrada.")
                Return
            End If

            ' Obtener valores del formulario
            Dim fecha As Date = DateTimePickerFecha.Value
            Dim horaEntrada As Date = DateTimePickerHoraEntrada.Value
            Dim horaSalida As Date = DateTimePickerHoraSalida.Value
            Dim idTalla As Integer = CType(ComboBoxTalla.SelectedItem, ComboBoxItem).Value
            Dim observaciones As String = TextBoxObservaciones.Text

            ' Obtener el idPrecioProfilaxis basado en la talla seleccionada
            Dim idPrecioProfilaxis As Integer
            Dim query As String = "SELECT idPrecioProfilaxis FROM PrecioProfilaxis WHERE idTalla = @idTalla"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idTalla", idTalla)
                idPrecioProfilaxis = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' Insertar el registro de profilaxis dental
            Dim insertQuery As String = "INSERT INTO ProfilaxisDental (idMascota, fecha, horaEntrada, horaSalida, observaciones, idPrecioProfilaxis) " &
                                     "VALUES (@idMascota, @fecha, @horaEntrada, @horaSalida, @observaciones, @idPrecioProfilaxis)"

            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                cmd.Parameters.AddWithValue("@fecha", fecha)
                cmd.Parameters.AddWithValue("@horaEntrada", horaEntrada)
                cmd.Parameters.AddWithValue("@horaSalida", horaSalida)
                cmd.Parameters.AddWithValue("@observaciones", observaciones)
                cmd.Parameters.AddWithValue("@idPrecioProfilaxis", idPrecioProfilaxis)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Registro de profilaxis guardado exitosamente.")

        ' Cargar los datos en el DataGrid después de guardar
        CargarDatosEnDataGrid()
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


    Private Sub CargarDatosEnDataGrid()
        Dim query As String = "SELECT m.nomMasc, pd.fecha, pd.horaEntrada, pd.horaSalida, pd.observaciones " &
                          "FROM ProfilaxisDental pd " &
                          "JOIN Mascota m ON pd.idMascota = m.idMascota"

        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable ' Asegúrate de que este sea el nombre de tu DataGridView
            End Using
        End Using
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
        Me.Hide()
    End Sub
End Class
