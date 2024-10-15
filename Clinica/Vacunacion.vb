Imports MySql.Data.MySqlClient

Public Class Vacunacion

        ' Cadena de conexión (ajusta con los datos de tu servidor)
        Dim connectionString As String = "server=localhost;user id=root;password=tu_contraseña;database=tu_base_de_datos"

        ' Función para insertar un registro de vacunación en la base de datos
        Private Sub GuardarVacunacion()

            ' Abrir la conexión
            Dim conexion As New MySqlConnection(connectionString)
            conexion.Open()

            Try
                ' 1. Insertar el registro en la tabla RegistroVacunacion, utilizando NOW() para la fecha
                Dim comandoRegistro As New MySqlCommand("INSERT INTO RegistroVacunacion (idMascota, fecha, observaciones) VALUES (@idMascota, NOW(), @observaciones)", conexion)
                comandoRegistro.Parameters.AddWithValue("@idMascota", idMascota)  ' Asume que idMascota está definido
                comandoRegistro.Parameters.AddWithValue("@observaciones", txtObservaciones.Text)
                comandoRegistro.ExecuteNonQuery()

                ' Obtener el ID del registro de vacunación recién insertado
                Dim idRegistroVacunacion As Integer = comandoRegistro.LastInsertedId

                ' 2. Insertar las vacunas seleccionadas en DetalleVacunacion
                For Each chk As CheckBox In groupBoxVacunasAplicar.Controls
                    If chk.Checked Then
                        ' Obtener el id de la vacuna en función del nombre del checkbox (debe coincidir con los nombres de las vacunas en la tabla)
                        Dim comandoVacuna As New MySqlCommand("SELECT idVacuna FROM Vacuna WHERE nombreVac = @nombreVac", conexion)
                        comandoVacuna.Parameters.AddWithValue("@nombreVac", chk.Text)
                        Dim idVacuna As Integer = comandoVacuna.ExecuteScalar()

                        ' Insertar en DetalleVacunacion
                        Dim comandoDetalle As New MySqlCommand("INSERT INTO DetalleVacunacion (idRegistroVacunacion, idVacuna) VALUES (@idRegistroVacunacion, @idVacuna)", conexion)
                        comandoDetalle.Parameters.AddWithValue("@idRegistroVacunacion", idRegistroVacunacion)
                        comandoDetalle.Parameters.AddWithValue("@idVacuna", idVacuna)
                        comandoDetalle.ExecuteNonQuery()
                    End If
                Next

                ' Cerrar la conexión
                conexion.Close()

                ' Mensaje de confirmación
                MessageBox.Show("Vacunación registrada exitosamente.", "Registro Completado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ' Manejo de errores
                MessageBox.Show("Error al registrar la vacunación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Asegurarse de cerrar la conexión aunque haya un error
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
            End Try
        End Sub

        ' Evento del botón Guardar
        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            ' Llamar a la función GuardarVacunacion cuando el botón se presione
            GuardarVacunacion()
        End Sub

        ' Asume que hay un botón para regresar al menú principal
        Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
            ' Regresar al menú principal (o cerrar este formulario)
            Me.Close()
        End Sub

    End Class
