Imports MySql.Data.MySqlClient

Public Class Inicio_de_sesion

	' Cadena de conexión, ajusta esto de acuerdo a tu configuración de base de datos
	Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"

	' Evento de clic en el botón "Ingresar"
	Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
		' Obtener los valores ingresados
		Dim correo As String = txtCorreo.Text
		Dim contraseña As String = txtContraseña.Text

		' Llamar a la función para verificar el inicio de sesión
		If VerificarCredenciales(correo, contraseña) Then
			MessageBox.Show("Inicio de sesión exitoso.")
			' Aquí puedes agregar el código para abrir la siguiente ventana o formulario
		Else
			MessageBox.Show("Correo o contraseña incorrectos.")
		End If
	End Sub

	' Función para verificar credenciales en la base de datos
	Private Function VerificarCredenciales(correo As String, contraseña As String) As Boolean
		Dim resultado As Boolean = False

		' Crear una conexión con la base de datos
		Using connection As New MySqlConnection(connectionString)
			Try
				connection.Open()

				' Crear el comando SQL para buscar el usuario
				Dim query As String = "SELECT COUNT(*) FROM Usuario WHERE Correo = @correo AND Contraseña = @contraseña"
				Using command As New MySqlCommand(query, connection)
					' Agregar los parámetros
					command.Parameters.AddWithValue("@correo", correo)
					command.Parameters.AddWithValue("@contraseña", contraseña)

					' Ejecutar el comando y obtener el resultado
					Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

					' Si el conteo es mayor a 0, el usuario existe
					If count > 0 Then
						resultado = True
					End If
				End Using
			Catch ex As Exception
				MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
			End Try
		End Using

		Return resultado
	End Function
	Private Sub linkCrearCuenta_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCrearCuenta.LinkClicked
		' Crear una nueva instancia del formulario Crear Cuenta
		Dim crearCuentaForm As New Crear_Cuenta

		' Mostrar el formulario de Crear Cuenta
		crearCuentaForm.Show()

		' Ocultar el formulario actual (Inicio de Sesión)
		Me.Hide()
	End Sub
End Class