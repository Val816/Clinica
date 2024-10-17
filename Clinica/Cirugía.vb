Imports MySql.Data.MySqlClient

Public Class Cirugía

    ' Definir la conexión a la base de datos
    Dim conexion As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")

    ' Clases para representar mascotas y tipos de cirugías
    Public Class MascotaItem
        Public Property idMascota As Integer
        Public Property nomMasc As String

        ' Sobrecarga del método ToString para mostrar el nombre de la mascota en el ComboBox
        Public Overrides Function ToString() As String
            Return nomMasc
        End Function
    End Class

    Public Class TipoCirugiaItem
        Public Property idTipoCirugia As Integer
        Public Property tipoCirugia As String
        Public Property costo As Decimal

        ' Sobrecarga del método ToString para mostrar el tipo de cirugía en el ComboBox
        Public Overrides Function ToString() As String
            Return tipoCirugia
        End Function
    End Class

    ' Evento que carga los datos cuando se abre el formulario
    Private Sub FormCirugia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMascotas()
        CargarMascotasDelDia()
        CargarCirugias()
        AddHandler ComboBoxCirugia.SelectedIndexChanged, AddressOf ComboBoxCirugia_SelectedIndexChanged

    End Sub

    ' Método para cargar las mascotas registradas hoy
    Private Sub CargarMascotas()
        Try
            Dim queryMascota As String = "SELECT idMascota, nomMasc FROM Mascota"
            Dim cmdMascota As New MySqlCommand(queryMascota, conexion)
            conexion.Open()
            Dim readerMascota As MySqlDataReader = cmdMascota.ExecuteReader()

            ComboBoxMascota.Items.Clear()

            While readerMascota.Read()
                Dim mascota As New MascotaItem() With {
                    .idMascota = readerMascota("idMascota"),
                    .nomMasc = readerMascota("nomMasc")
                }
                ComboBoxMascota.Items.Add(mascota)
            End While

            readerMascota.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar mascotas: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub CargarMascotasDelDia()
        Dim query As String = "SELECT nomMasc FROM Mascota WHERE DATE(fecha) = CURDATE()"
        Dim cmd As New MySqlCommand(query, conexion)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            ComboBoxMascota.Items.Clear()

            While reader.Read()
                ComboBoxMascota.Items.Add(reader("nomMasc").ToString())
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar las mascotas: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarCirugias()
        Try
            Dim queryCirugia As String = "SELECT idTipoCirugia, nombre, costo FROM TipoCirugia"
            Dim cmdCirugia As New MySqlCommand(queryCirugia, conexion)
            conexion.Open()
            Dim readerCirugia As MySqlDataReader = cmdCirugia.ExecuteReader()

            ComboBoxCirugia.Items.Clear()

            While readerCirugia.Read()
                Dim cirugia As New TipoCirugiaItem() With {
                    .idTipoCirugia = readerCirugia("idTipoCirugia"),
                    .tipoCirugia = readerCirugia("nombre"),
                    .costo = readerCirugia("costo")
                }
                ComboBoxCirugia.Items.Add(cirugia)
            End While

            readerCirugia.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar cirugías: " & ex.Message)
        Finally
            conexion.Close()
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


    Private Sub ComboBoxCirugia_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBoxCirugia.SelectedItem IsNot Nothing Then
            Dim selectedCirugia As TipoCirugiaItem = CType(ComboBoxCirugia.SelectedItem, TipoCirugiaItem)

            TextBoxCosto.Text = selectedCirugia.costo.ToString("F2")
        End If
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Try

            If ComboBoxMascota.SelectedItem Is Nothing OrElse ComboBoxCirugia.SelectedItem Is Nothing Then
                MessageBox.Show("Por favor, selecciona una mascota y una cirugía.")
                Return
            End If


            Dim selectedMascota As MascotaItem = CType(ComboBoxMascota.SelectedItem, MascotaItem)
            Dim selectedCirugia As TipoCirugiaItem = CType(ComboBoxCirugia.SelectedItem, TipoCirugiaItem)

            Dim idMascota As Integer = selectedMascota.idMascota
            Dim idTipoCirugia As Integer = selectedCirugia.idTipoCirugia
            Dim fechaCirugia As String = DateTimePickerFecha.Value.ToString("yyyy-MM-dd")
            Dim observaciones As String = TextBoxObservaciones.Text
            Dim costoCirugia As Decimal = selectedCirugia.costo

            ' Insertar la cirugía en la base de datos
            Dim query As String = "INSERT INTO Cirugia (idMascota, idTipoCirugia, fecha, observaciones, costo) " &
                                  "VALUES (@idMascota, @idTipoCirugia, @fecha, @observaciones, @costo)"
            Dim cmd As New MySqlCommand(query, conexion)

            cmd.Parameters.AddWithValue("@idMascota", idMascota)
            cmd.Parameters.AddWithValue("@idTipoCirugia", idTipoCirugia)
            cmd.Parameters.AddWithValue("@fecha", fechaCirugia)
            cmd.Parameters.AddWithValue("@observaciones", observaciones)
            cmd.Parameters.AddWithValue("@costo", costoCirugia)

            conexion.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("Cirugía registrada exitosamente.")
            ' Limpiar campos después de guardar
            LimpiarCampos()
            ' Recargar datos en el DataGridView
            CargarDatosCirugia()

        Catch ex As Exception
            MessageBox.Show("Error al registrar la cirugía: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Obtener el servicio seleccionado
        Dim servicioSeleccionado As Object = ComboBoxServicios.SelectedItem
        If servicioSeleccionado Is Nothing Then
            MessageBox.Show("Por favor, selecciona un servicio.")
            Return
        End If

        Dim idServicio As Integer = servicioSeleccionado.Value

        ' Redirigir según el servicio seleccionado
        Select Case idServicio
            Case 1 ' 
                Dim formCirugia As New Cirugía()
                formCirugia.Show()
                Me.Hide()

            Case 2 ' 
                Dim consultamedica As New Consulta_Médica()
                consultamedica.Show()
                Me.Hide()

            'Case 4
            '    Dim formDesparacitacion As New Desparacitación()
            '    formDesparacitacion.Show()
            '    Me.Hide()

            'Case 5
            '    Dim formEsterilizacion As New Esterilización()
            '    formEsterilizacion.Show()
            '    Me.Hide()

            'Case 6
            '    Dim formPension As New Pensión()
            '    formPension.Show()
            '    Me.Hide()

            Case 7
                Dim formGrooming As New Estética()
                formGrooming.Show()
                Me.Hide()
            Case 8
                Dim formEutanasia As New Eutanasia()
                formEutanasia.Show()
                Me.Hide()

            Case 9
                Dim formGrooming As New Vacunacion()
                formGrooming.Show()
                Me.Hide()

                'Case 10
                '    Dim formHospitalizacion As New Hospitalización()
                '    formHospitalizacion.Show()
                '    Me.Hide()
                'Case 11
                '    Dim formProfilaxis As New Profilaxis_Dental()
                '    formProfilaxis.Show()
                '    Me.Hide()
                'Case 12
                '    Dim formRecibo As New Recibo()
                '    form formRecibo.Show()
                '    Me.Hide()
            Case Else
                MessageBox.Show("Servicio no reconocido. Por favor, selecciona un servicio válido.")

        End Select
    End Sub
    ' Método para limpiar los campos después de registrar la cirugía
    Private Sub LimpiarCampos()
        ComboBoxMascota.SelectedIndex = -1
        ComboBoxCirugia.SelectedIndex = -1
        TextBoxObservaciones.Clear()
        TextBoxCosto.Clear()
    End Sub
    Private Sub CargarDatosCirugia()
        Try
            Dim query As String = "SELECT Cirugia.idCirugia, Mascota.nomMasc, TipoCirugia.nombre, Cirugia.fecha, Cirugia.observaciones, Cirugia.costo " &
                                  "FROM Cirugia " &
                                  "JOIN Mascota ON Cirugia.idMascota = Mascota.idMascota " &
                                  "JOIN TipoCirugia ON Cirugia.idTipoCirugia = TipoCirugia.idTipoCirugia"

            Dim cmd As New MySqlCommand(query, conexion)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            conexion.Open()
            adapter.Fill(table)

            ' Asignar los datos al DataGridView
            DataGridViewCirugias.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos de las cirugías: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click

        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()


        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim query As String = "SELECT Cirugia.idCirugia, Mascota.nomMasc, TipoCirugia.nombre, Cirugia.fecha, Cirugia.observaciones, Cirugia.costo " &
                                  "FROM Cirugia " &
                                  "JOIN Mascota ON Cirugia.idMascota = Mascota.idMascota " &
                                  "JOIN TipoCirugia ON Cirugia.idTipoCirugia = TipoCirugia.idTipoCirugia WHERE 1=1"

            ' Agregar las condiciones según lo seleccionado en los ComboBox
            If ComboBoxMascota.SelectedItem IsNot Nothing Then
                Dim selectedMascota As MascotaItem = CType(ComboBoxMascota.SelectedItem, MascotaItem)
                query &= " AND Mascota.idMascota = @idMascota"
            End If

            If ComboBoxCirugia.SelectedItem IsNot Nothing Then
                Dim selectedCirugia As TipoCirugiaItem = CType(ComboBoxCirugia.SelectedItem, TipoCirugiaItem)
                query &= " AND Cirugia.idTipoCirugia = @idTipoCirugia"
            End If

            If DateTimePickerFecha.Checked Then
                query &= " AND Cirugia.fecha = @fecha"
            End If

            Dim cmd As New MySqlCommand(query, conexion)

            ' Añadir parámetros si existen
            If ComboBoxMascota.SelectedItem IsNot Nothing Then
                Dim selectedMascota As MascotaItem = CType(ComboBoxMascota.SelectedItem, MascotaItem)
                cmd.Parameters.AddWithValue("@idMascota", selectedMascota.idMascota)
            End If

            If ComboBoxCirugia.SelectedItem IsNot Nothing Then
                Dim selectedCirugia As TipoCirugiaItem = CType(ComboBoxCirugia.SelectedItem, TipoCirugiaItem)
                cmd.Parameters.AddWithValue("@idTipoCirugia", selectedCirugia.idTipoCirugia)
            End If

            If DateTimePickerFecha.Checked Then
                cmd.Parameters.AddWithValue("@fecha", DateTimePickerFecha.Value.ToString("yyyy-MM-dd"))
            End If

            ' Asegurarse de que la conexión esté abierta
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            ' Ejecutar la consulta y llenar el DataGridView
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)

            ' Mostrar los datos en el DataGridView
            DataGridViewCirugias.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error al buscar las cirugías: " & ex.Message)
        Finally
            ' Cerrar la conexión
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

End Class

