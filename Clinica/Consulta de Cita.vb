Imports MySql.Data.MySqlClient

Public Class Consulta_de_Cita
    Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim celular As String = txtCelular.Text
        Dim nombre As String = txtNombre.Text
        Dim mascota As String = txtNombreMascota.Text
        Dim fecha As Date = dtpFecha.Value
        Dim hora As String = txtHora.Text

        If String.IsNullOrEmpty(celular) AndAlso String.IsNullOrEmpty(nombre) AndAlso fecha = DateTimePicker.MinimumDateTime Then
            MessageBox.Show("Por favor, ingresa un número de celular, nombre o selecciona una fecha para buscar la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        BuscarCita(celular, nombre, mascota, fecha, hora)
    End Sub

    Private Sub BuscarCita(celular As String, nombre As String, mascota As String, fecha As Date, hora As String)
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim celularNumerico As Long
                Dim query As String = "SELECT * FROM Cita WHERE (celular = @celular OR nomCliente LIKE @nombre OR nomMasc LIKE @mascota) AND (fecha = @fecha OR @fecha IS NULL)"

                Using command As New MySqlCommand(query, connection)
                    If Not String.IsNullOrEmpty(celular) AndAlso Long.TryParse(celular, celularNumerico) Then
                        command.Parameters.AddWithValue("@celular", celularNumerico)
                    Else
                        command.Parameters.AddWithValue("@celular", DBNull.Value)
                    End If

                    command.Parameters.AddWithValue("@nombre", "%" & nombre & "%")
                    command.Parameters.AddWithValue("@mascota", "%" & mascota & "%")
                    command.Parameters.AddWithValue("@fecha", If(fecha = DateTimePicker.MinimumDateTime, DBNull.Value, fecha.Date))

                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    If table.Rows.Count > 0 Then
                        dgvCitaProgramada.DataSource = table
                    Else
                        MessageBox.Show("No se encontró ninguna cita con esos datos.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCitaProgramada.SelectedRows.Count > 0 Then
            Dim idCita As Integer = Convert.ToInt32(dgvCitaProgramada.SelectedRows(0).Cells("idCita").Value)
            Dim confirmacion As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta cita?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.Yes Then
                EliminarCita(idCita)
            End If
        Else
            MessageBox.Show("Por favor, selecciona una cita para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub EliminarCita(idCita As Integer)
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "DELETE FROM Cita WHERE idCita = @idCita"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@idCita", idCita)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Cita eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        btnBuscar.PerformClick()
                    Else
                        MessageBox.Show("Error al eliminar la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub btnAgregarCita_Click(sender As Object, e As EventArgs) Handles btnAgregarCita.Click
        Dim registroCitaForm As New Registro_de_Cita
        registroCitaForm.Show()
        Me.Close()
    End Sub

    Private Sub btnContinuarRegistroMascota_Click(sender As Object, e As EventArgs) Handles btnContinuarRegistroMascota.Click
        Dim registroMascotaForm As New Registro_de_Mascota
        registroMascotaForm.Show()
        Me.Close()
    End Sub

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim menuPrincipalForm As New Menu_Principal
        menuPrincipalForm.Show()
        Me.Close()
    End Sub

End Class