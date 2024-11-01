Imports MySql.Data.MySqlClient

Public Class desparacitación
    Private connectionString As String = "server=localhost;user=root;password=root;database=veterinaria;"
    Private idMascota As Integer

    ' Constructor que recibe el idMascota
    Public Sub New(Optional idMascota As Integer = 0)
        InitializeComponent()
        Me.idMascota = idMascota
    End Sub

    Private Sub RegistroDesparacitacionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDesparasitaciones()
        CargarRegistrosDesparacitacion()
        LlenarComboBoxServicios()
    End Sub

    Private Sub CargarDesparasitaciones()
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT idDesparacitacion, nombre FROM Desparacitacion"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            conn.Open()
            adapter.Fill(dt)

            cbDesparacitacion.DataSource = dt
            cbDesparacitacion.DisplayMember = "nombre" ' Mostrar el nombre en el ComboBox
            cbDesparacitacion.ValueMember = "idDesparacitacion" ' Usar el ID como valor
        End Using
    End Sub


    Private Sub CargarRegistrosDesparacitacion()
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT r.idRegistro, m.nomMasc, d.nombre AS Desparacitacion, r.fecha, r.observaciones " &
                                  "FROM RegistroDesparacitacion r " &
                                  "JOIN Mascota m ON r.idMascota = m.idMascota " &
                                  "JOIN Desparacitacion d ON r.idDesparacitacion = d.idDesparacitacion " &
                                  "WHERE r.idMascota = @idMascota"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@idMascota", idMascota)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            conn.Open()
            adapter.Fill(dt)

            dgvDesparacitaciones.DataSource = dt
        End Using
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim idDesparacitacion As Integer = Convert.ToInt32(cbDesparacitacion.SelectedValue)
        Dim fecha As Date = Date.Now
        Dim observaciones As String = txtObservaciones.Text

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO RegistroDesparacitacion (idMascota, idDesparacitacion, fecha, observaciones) VALUES (@idMascota, @idDesparacitacion, @fecha, @observaciones)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@idMascota", idMascota)
            cmd.Parameters.AddWithValue("@idDesparacitacion", idDesparacitacion)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@observaciones", observaciones)

            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Desparacitación registrada exitosamente.")

            ' Recargar registros después de guardar
            CargarRegistrosDesparacitacion()
        End Using
    End Sub

    Private Sub cbDesparacitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDesparacitacion.SelectedIndexChanged
        Try
            If cbDesparacitacion.SelectedItem IsNot Nothing Then
                Dim selectedRow As DataRowView = CType(cbDesparacitacion.SelectedItem, DataRowView)
                Dim idDesparacitacion As Integer = Convert.ToInt32(selectedRow("IdColumna")) ' Reemplaza "IdColumna"
                MessageBox.Show("ID de desparacitación: " & idDesparacitacion.ToString())
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("Error de conversión: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

    Private Sub LlenarComboBoxServicios()
        ComboBoxServicios.Items.Clear()
        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxServicios.Items.Add(New KeyValuePair(Of Integer, String)(reader("idServicio"), reader("nombre")))
                End While
            End Using
        End Using

        ComboBoxServicios.DisplayMember = "Value"
        ComboBoxServicios.ValueMember = "Key"
    End Sub

    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxServicios.SelectedIndexChanged
        If ComboBoxServicios.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona un servicio.")
            Return
        End If

        Dim servicioSeleccionado As KeyValuePair(Of Integer, String) = CType(ComboBoxServicios.SelectedItem, KeyValuePair(Of Integer, String))
        Dim idServicio As Integer = servicioSeleccionado.Key

        Select Case idServicio
            Case 1
                Dim formCirugia As New Cirugía()
                formCirugia.Show()
                Me.Hide()
            Case 2
                Dim consultamedica As New Consulta_Médica()
                consultamedica.Show()
                Me.Hide()
            Case 4
                Dim formDesparacitacion As New Castración_y_Esterilización()
                formDesparacitacion.Show()
                Me.Hide()
            Case 6
                Dim formPension As New Pensión()
                formPension.Show()
                Me.Hide()
            Case 7
                Dim formGrooming As New Estética()
                formGrooming.Show()
                Me.Hide()
            Case 8
                Dim formEutanasia As New Eutanasia()
                formEutanasia.Show()
                Me.Hide()
            Case 9
                Dim formVacunacion As New Vacunacion()
                formVacunacion.Show()
                Me.Hide()
            Case 10
                Dim formHospitalizacion As New Hospitalización()
                formHospitalizacion.Show()
                Me.Hide()
            Case 11
                Dim formProfilaxis As New Proaxis_Dental()
                formProfilaxis.Show()
                Me.Hide()
            Case 12
                Dim formRecibo As New Recibo()
                formRecibo.Show()
                Me.Hide()
            Case Else
                MessageBox.Show("Servicio no reconocido. Por favor, selecciona un servicio válido.")
        End Select
    End Sub

    ' Botón para regresar al Menú Principal
    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()
        Me.Close()
    End Sub
End Class
