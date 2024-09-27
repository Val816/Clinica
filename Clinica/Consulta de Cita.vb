Imports System.Data.SqlClient
Public Class Consulta_de_Cita

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
            ' Consulta SQL para buscar la cita según el nombre del cliente y la mascota
            Dim query As String = "SELECT fecha, hora FROM Cita WHERE nomCliente = @nomCliente AND nomMasc = @nomMasc"

        ' Conexión a la base de datos
        Using conn As New SqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New SqlCommand(query, conn)
                ' Asignar parámetros a la consulta
                cmd.Parameters.AddWithValue("@nomCliente", txtNombreTutor.Text)
                cmd.Parameters.AddWithValue("@nomMasc", txtNombreMascota.Text)

                ' Abrir la conexión
                conn.Open()

                ' Ejecutar la consulta y leer los resultados
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Si se encuentra la cita, asignar la fecha al DateTimePicker
                        dateFecha.Value = DateTime.Parse(reader("fecha").ToString())

                        ' Asignar la hora al TextBox
                        txtHora.Text = reader("hora").ToString()

                        ' Habilitar el botón de continuar
                        btnContinuar.Enabled = True
                    Else
                        ' Si no se encuentra cita, mostrar mensaje y limpiar los campos
                        MessageBox.Show("No se encontró ninguna cita.")
                        btnContinuar.Enabled = False
                        LimpiarCampos()
                    End If
                End Using
            End Using
        End Using
    End Sub

        ' Botón para limpiar todos los campos del formulario
        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            LimpiarCampos()
        End Sub

        ' Función para limpiar los campos del formulario
        Private Sub LimpiarCampos()
            txtNombreTutor.Text = ""
            txtTelefono.Text = ""
            txtNombreMascota.Text = ""
            txtHora.Text = ""
            dateFecha.Value = DateTime.Now
        End Sub

        ' Botón para eliminar la cita
        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            ' Verificar si hay cita seleccionada
            If txtNombreTutor.Text = "" Or txtNombreMascota.Text = "" Then
                MessageBox.Show("Por favor, busque una cita antes de eliminar.")
                Return
            End If

            ' Confirmar eliminación
            If MessageBox.Show("¿Está seguro de que desea eliminar esta cita?", "Confirmar eliminación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ' Consulta SQL para eliminar la cita
                Dim query As String = "DELETE FROM Cita WHERE nomCliente = @nomCliente AND nomMasc = @nomMasc"

                ' Conexión a la base de datos
                Using conn As New SqlConnection("your_connection_string_here")
                    Using cmd As New SqlCommand(query, conn)
                        ' Asignar parámetros
                        cmd.Parameters.AddWithValue("@nomCliente", txtNombreTutor.Text)
                        cmd.Parameters.AddWithValue("@nomMasc", txtNombreMascota.Text)

                        ' Abrir la conexión y ejecutar la eliminación
                        conn.Open()
                        cmd.ExecuteNonQuery()

                        ' Limpiar los campos después de eliminar la cita
                        LimpiarCampos()
                        MessageBox.Show("Cita eliminada exitosamente.")
                    End Using
                End Using
            End If
        End Sub

        ' Botón para continuar con el registro de la mascota
        Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
            ' Aquí redireccionarías al formulario de registro de la mascota
            MessageBox.Show("Redirigiendo al registro de la mascota...")
            ' Ejemplo: abrir otro formulario
            ' Dim frmRegistroMascota As New FormRegistroMascota()
            ' frmRegistroMascota.Show()
            ' Me.Close() ' Cerrar el formulario actual si es necesario
        End Sub

        ' Botón para ir al registro de citas si no se encuentra ninguna
        Private Sub btnIrRegistroCita_Click(sender As Object, e As EventArgs) Handles btnIrRegistroCita.Click
            ' Aquí redireccionarías al formulario de registro de citas
            MessageBox.Show("Redirigiendo al registro de citas...")
        ' Ejemplo: abrir otro formulario
        ' Dim frmRegistroCita As New FormRegistroCita()
        ' frmRegistroCita.Show()
        ' Me.Close()
    End Sub

        ' Botón para regresar al menú principal
        Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
            ' Aquí redireccionarías al menú principal
            MessageBox.Show("Redirigiendo al menú principal...")
            ' Ejemplo: abrir otro formulario
            ' Dim frmMenuPrincipal As New FormMenuPrincipal()
            ' frmMenuPrincipal.Show()
            ' Me.Close() ' Cerrar el formulario actual si es necesario
        End Sub

End Class