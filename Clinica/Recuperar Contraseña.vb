Imports MySql.Data.MySqlClient

Public Class Recuperar_Contraseña
    ' Conexión a la base de datos
    Private connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"

    ' Evento al presionar el botón "Cambiar Contraseña"
    Private Sub btnCambiarContraseña_Click(sender As Object, e As EventArgs) Handles btnCambiarContraseña.Click
        ' Verificar que los campos no estén vacíos
        If String.IsNullOrEmpty(txtCorreo.Text) Or String.IsNullOrEmpty(txtNuevaContraseña.Text) Or String.IsNullOrEmpty(txtConfirmaContraseña.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar que la nueva contraseña y la confirmación coincidan
        If txtNuevaContraseña.Text <> txtConfirmaContraseña.Text Then
            MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique.", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Actualizar la contraseña si el correo existe en la base de datos
        Dim queryVerificarCorreo As String = "SELECT COUNT(*) FROM Usuario WHERE Correo = @Correo"
        Dim queryActualizarContraseña As String = "UPDATE Usuario SET Contraseña = @NuevaContraseña WHERE Correo = @Correo"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Verificar si el correo existe
            Using verificarCmd As New MySqlCommand(queryVerificarCorreo, connection)
                verificarCmd.Parameters.AddWithValue("@Correo", txtCorreo.Text)

                Dim count As Integer = Convert.ToInt32(verificarCmd.ExecuteScalar())

                If count = 0 Then
                    MessageBox.Show("El correo no existe. Por favor, verifique.", "Correo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Actualizar la contraseña
                    Using actualizarCmd As New MySqlCommand(queryActualizarContraseña, connection)
                        actualizarCmd.Parameters.AddWithValue("@NuevaContraseña", txtNuevaContraseña.Text)
                        actualizarCmd.Parameters.AddWithValue("@Correo", txtCorreo.Text)

                        actualizarCmd.ExecuteNonQuery()
                        MessageBox.Show("La contraseña ha sido cambiada correctamente.", "Cambio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Redirigir al formulario de inicio de sesión
                        Dim formLogin As New Inicio_de_sesion()
                        formLogin.Show()
                        Me.Close()
                    End Using
                End If
            End Using
        End Using
    End Sub

    ' Botón para regresar a la ventana de inicio de sesión
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        ' Abrir el formulario de inicio de sesión y cerrar el actual
        Dim formLogin As New Inicio_de_sesion()
        formLogin.Show()
        Me.Close()
    End Sub
End Class
