Imports MySql.Data.MySqlClient
Public Class Crear_Cuenta
    ' Cadena de conexión, ajústala según tu configuración
    Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"

    ' Evento del botón "Continuar"
    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        ' Obtener los valores ingresados en los TextBox
        Dim nombre As String = txtNombre.Text
        Dim apellidoP As String = txtApellidoP.Text
        Dim apellidoM As String = txtApellidoM.Text
        Dim correo As String = txtCorreo.Text
        Dim contraseña As String = txtContraseña.Text
        Dim confirmarContraseña As String = txtConfirmarContraseña.Text

        ' Validar que las contraseñas coincidan
        If contraseña <> confirmarContraseña Then
            MessageBox.Show("Las contraseñas no coinciden. Por favor, vuelve a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validar que los campos no estén vacíos
        If String.IsNullOrEmpty(nombre) Or String.IsNullOrEmpty(apellidoP) Or String.IsNullOrEmpty(apellidoM) Or String.IsNullOrEmpty(correo) Or String.IsNullOrEmpty(contraseña) Then
            MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Llamar a la función para guardar el usuario
        If CrearCuenta(nombre, apellidoP, apellidoM, correo, contraseña) Then
            MessageBox.Show("Cuenta creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Aquí puedes agregar el código para redirigir a la pantalla de inicio de sesión
            Me.Close() ' Cierra el formulario actual
        Else
            MessageBox.Show("Hubo un error al crear la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Función para crear una cuenta en la base de datos
    Private Function CrearCuenta(nombre As String, apellidoP As String, apellidoM As String, correo As String, contraseña As String) As Boolean
        Dim resultado As Boolean = False

        ' Crear una conexión con la base de datos
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Verificar si el correo ya existe en la base de datos
                Dim checkQuery As String = "SELECT COUNT(*) FROM Usuario WHERE Correo = @correo"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@correo", correo)
                    Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    ' Si el correo ya existe, mostramos un mensaje de error
                    If count > 0 Then
                        MessageBox.Show("El correo electrónico ya está registrado. Por favor, usa otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                End Using

                ' Crear el comando SQL para insertar el nuevo usuario, incluyendo nombre y apellidos
                Dim query As String = "INSERT INTO Usuario (nombreU, ApellidoP, ApellidoM, Correo, Contraseña) VALUES (@nombre, @apellidoP, @apellidoM, @correo, @contraseña)"
                Using command As New MySqlCommand(query, connection)
                    ' Agregar los parámetros
                    command.Parameters.AddWithValue("@nombre", nombre)
                    command.Parameters.AddWithValue("@apellidoP", apellidoP)
                    command.Parameters.AddWithValue("@apellidoM", apellidoM)
                    command.Parameters.AddWithValue("@correo", correo)
                    command.Parameters.AddWithValue("@contraseña", contraseña)

                    ' Ejecutar el comando de inserción
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Si al menos una fila fue afectada, consideramos la operación como exitosa
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

    ' Evento del botón "Atrás" para regresar al formulario de inicio de sesión
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        ' Mostrar el formulario de inicio de sesión
        Dim inicioSesionForm As New Inicio_de_sesion
        inicioSesionForm.Show()

        ' Cerrar el formulario actual
        Me.Close()
    End Sub
End Class
