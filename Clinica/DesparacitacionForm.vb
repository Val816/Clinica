Imports MySql.Data.MySqlClient

Public Class DesparacitacionForm
    Private connectionString As String = "server=localhost;user=root;password=root;database=veterinaria;"
    Private idMascota As Integer

    Public Sub New(Optional idMascota As Integer = 0)
        InitializeComponent()
        Me.idMascota = idMascota
    End Sub

    Private Sub RegistroDesparacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idMascota <= 0 Then
            MessageBox.Show("ID de mascota no válido.")
            Me.Close()
            Return
        End If
        CargarComboBoxDesparacitacion()
        LlenarComboBoxServicios()
        txtCosto.ReadOnly = True ' Hacer el TextBox de costo de solo lectura
    End Sub

    Private Sub CargarComboBoxDesparacitacion()
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim query As String = "SELECT idDesparacitacion, nombre, costo FROM Desparacitacion"
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()

                conn.Open()
                adapter.Fill(dt)

                cbDesparacitacion.DataSource = dt
                cbDesparacitacion.DisplayMember = "nombre"
                cbDesparacitacion.ValueMember = "idDesparacitacion"
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al cargar el ComboBox de desparacitaciones: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim idDesparacitacion As Integer = Convert.ToInt32(cbDesparacitacion.SelectedValue)
            Dim fecha As Date = Date.Now
            Dim observaciones As String = txtObservaciones.Text

            ' Obtener el costo de la desparacitación
            Dim costo As Decimal = ObtenerCosto(idDesparacitacion)

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Insertar en RegistroDesparacitacion
                Dim query As String = "INSERT INTO RegistroDesparacitacion (idMascota, idDesparacitacion, fecha, observaciones, costo) VALUES (@idMascota, @idDesparacitacion, @fecha, @observaciones, @costo)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idMascota", idMascota)
                    cmd.Parameters.AddWithValue("@idDesparacitacion", idDesparacitacion)
                    cmd.Parameters.AddWithValue("@fecha", fecha)
                    cmd.Parameters.AddWithValue("@observaciones", observaciones)
                    cmd.Parameters.AddWithValue("@costo", costo)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Desparacitación registrada exitosamente.")
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al registrar la desparacitación: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Function ObtenerCosto(idDesparacitacion As Integer) As Decimal
        Dim costo As Decimal = 0
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim query As String = "SELECT costo FROM Desparacitacion WHERE idDesparacitacion = @idDesparacitacion"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idDesparacitacion", idDesparacitacion)
                    conn.Open()
                    costo = Convert.ToDecimal(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al obtener el costo de la desparacitación: " & ex.Message)
        End Try
        Return costo
    End Function

    Private Sub cbDesparacitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDesparacitacion.SelectedIndexChanged
        Try
            If cbDesparacitacion.SelectedItem IsNot Nothing Then
                Dim selectedRow As DataRowView = CType(cbDesparacitacion.SelectedItem, DataRowView)
                Dim costo As Decimal = Convert.ToDecimal(selectedRow("costo"))
                txtCosto.Text = costo.ToString("C") ' Formatear como moneda
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al seleccionar la desparacitación: " & ex.Message)
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

        Dim servicioSeleccionado As Object = ComboBoxServicios.SelectedItem
        If servicioSeleccionado Is Nothing Then
            MessageBox.Show("Por favor, selecciona un servicio.")
            Return
        End If

        Dim idServicio As Integer = servicioSeleccionado.Value

        Select Case idServicio
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
                MessageBox.Show("Servicio no reconocido. Por favor, selecciona un servicio válido.")
        End Select
    End Sub

    ' Botón para regresar al Menú Principal
    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim menu As New Menu_Principal()
        menu.Show()
        Me.Close()
    End Sub


End Class