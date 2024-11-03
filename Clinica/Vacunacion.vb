Imports MySql.Data.MySqlClient

Public Class Vacunacion
    Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
    Dim vacunas As New Dictionary(Of Integer, Tuple(Of String, Decimal))

        Private Sub VacunacionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVacunas()
        LlenarComboBoxServicios()
    End Sub

    Private Sub LoadVacunas()
        CheckListVaccines.Items.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("SELECT idVacuna, nombreVac, precio FROM Vacuna", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim idVacuna As Integer = reader.GetInt32(0)
                Dim nombreVac As String = reader.GetString(1)
                Dim precio As Decimal = reader.GetDecimal(2)
                vacunas.Add(idVacuna, New Tuple(Of String, Decimal)(nombreVac, precio))

                CheckListVaccines.Items.Add(nombreVac)
            End While
        End Using
    End Sub


    Private Sub CheckListVaccines_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckListVaccines.ItemCheck

        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To CheckListVaccines.Items.Count - 1
                If i <> e.Index Then
                    CheckListVaccines.SetItemChecked(i, False)
                End If
            Next
        End If

        Dim precio As Decimal = 0

        If e.NewValue = CheckState.Checked Then
            Dim idVacuna As Integer = vacunas.Keys.ElementAt(e.Index)
            precio = vacunas(idVacuna).Item2
        End If

        txtTotalPrice.Text = precio.ToString("C")
    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim observaciones As String = txtObservaciones.Text.Trim()

        If String.IsNullOrEmpty(observaciones) Then
            MessageBox.Show("Las observaciones no pueden estar vacías.")
            Return
        End If

        Dim idMascota As Integer
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            idMascota = ObtenerUltimoIdMascota(connection)

            If idMascota = 0 Then
                MessageBox.Show("No se encontraron mascotas registradas.")
                Return
            End If

            Dim fecha As DateTime = DateTime.Now

            Try
                Dim command As New MySqlCommand("INSERT INTO RegistroVacunacion (idMascota, idVacuna, fecha, observaciones) VALUES (@idMascota, @idVacuna, @fecha, @observaciones)", connection)
                Dim vacunasSeleccionadas As Boolean = False

                For i As Integer = 0 To CheckListVaccines.Items.Count - 1
                    If CheckListVaccines.GetItemChecked(i) Then
                        Dim idVacuna As Integer = vacunas.Keys.ElementAt(i)
                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("@idMascota", idMascota)
                        command.Parameters.AddWithValue("@idVacuna", idVacuna)
                        command.Parameters.AddWithValue("@fecha", fecha)
                        command.Parameters.AddWithValue("@observaciones", observaciones)

                        command.ExecuteNonQuery()
                        vacunasSeleccionadas = True
                    End If
                Next

                If vacunasSeleccionadas Then
                    MessageBox.Show("Registro de vacunación guardado exitosamente.")
                Else
                    MessageBox.Show("No se seleccionó ninguna vacuna.")
                End If
            Catch ex As MySqlException
                MessageBox.Show("Error al guardar el registro: " & ex.Message)
            End Try
        End Using

        LoadRegistroVacunacion()
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

    Private Sub LoadRegistroVacunacion()
        ' Cargar y mostrar el registro de vacunación en un DataGridView
        Dim dt As New DataTable()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("SELECT m.nomMasc, v.nombreVac, r.fecha, v.precio, r.observaciones FROM RegistroVacunacion r JOIN Vacuna v ON r.idVacuna = v.idVacuna JOIN Mascota m ON r.idMascota = m.idMascota", connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dt)
            dgvRegistroVacunacion.DataSource = dt
        End Using

        ' Cambiar los títulos de las columnas
        dgvRegistroVacunacion.Columns(0).HeaderText = "Nombre de Mascota"
        dgvRegistroVacunacion.Columns(1).HeaderText = "Nombre de Vacuna"
        dgvRegistroVacunacion.Columns(2).HeaderText = "Fecha"
        dgvRegistroVacunacion.Columns(3).HeaderText = "Costo"
        dgvRegistroVacunacion.Columns(4).HeaderText = "Observaciones"
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
