Imports MySql.Data.MySqlClient

Public Class Crear_Cuenta
    Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click

        Dim nombre As String = txtNombre.Text
        Dim apellidoP As String = txtApellidoP.Text
        Dim apellidoM As String = txtApellidoM.Text
        Dim correo As String = txtCorreo.Text
        Dim contraseña As String = txtContraseña.Text
        Dim confirmarContraseña As String = txtConfirmarContraseña.Text


        If contraseña <> confirmarContraseña Then
            MessageBox.Show("Las contraseñas no coinciden. Por favor, vuelve a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(nombre) Or String.IsNullOrEmpty(apellidoP) Or String.IsNullOrEmpty(apellidoM) Or String.IsNullOrEmpty(correo) Or String.IsNullOrEmpty(contraseña) Then
            MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If CrearCuenta(nombre, apellidoP, apellidoM, correo, contraseña) Then
            MessageBox.Show("Cuenta creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim inicioSesionForm As New Inicio_de_sesion
            inicioSesionForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Hubo un error al crear la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function CrearCuenta(nombre As String, apellidoP As String, apellidoM As String, correo As String, contraseña As String) As Boolean
        Dim resultado As Boolean = False


        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()


                Dim checkQuery As String = "SELECT COUNT(*) FROM Usuario WHERE Correo = @correo"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@correo", correo)
                    Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())


                    If count > 0 Then
                        MessageBox.Show("El correo electrónico ya está registrado. Por favor, usa otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                End Using

                Dim query As String = "INSERT INTO Usuario (nombreU, ApellidoP, ApellidoM, Correo, Contraseña) VALUES (@nombre, @apellidoP, @apellidoM, @correo, @contraseña)"
                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@nombre", nombre)
                    command.Parameters.AddWithValue("@apellidoP", apellidoP)
                    command.Parameters.AddWithValue("@apellidoM", apellidoM)
                    command.Parameters.AddWithValue("@correo", correo)
                    command.Parameters.AddWithValue("@contraseña", contraseña)


                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        resultado = True
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
            End Try
        End Using

        Return resultado
    End Function

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim inicioSesionForm As New Inicio_de_sesion
        inicioSesionForm.Show()
        Me.Close()
    End Sub
End Class
