Imports MySql.Data.MySqlClient

Public Class Inicio_de_sesion

	Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"


	Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

		Dim correo As String = txtCorreo.Text
		Dim contraseña As String = txtContraseña.Text


		If VerificarCredenciales(correo, contraseña) Then
			Dim menuForm As New Menu_Principal()
			Me.Hide()
			menuForm.Show()
		Else
			MessageBox.Show("Usuario o contraseña incorrectos.")
		End If
	End Sub


	Private Function VerificarCredenciales(correo As String, contraseña As String) As Boolean
		Dim resultado As Boolean = False


		Using connection As New MySqlConnection(connectionString)
			Try
				connection.Open()

				Dim query As String = "SELECT COUNT(*) FROM Usuario WHERE Correo = @correo AND Contraseña = @contraseña"
				Using command As New MySqlCommand(query, connection)
					command.Parameters.AddWithValue("@correo", correo)
					command.Parameters.AddWithValue("@contraseña", contraseña)

					Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

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
		Dim crearCuentaForm As New Crear_Cuenta
		crearCuentaForm.Show()
		Me.Hide()
	End Sub

	Private Sub linkRecuperarCuenta_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRecuperarCuenta.LinkClicked
		Dim RecuperarContraseñaForm As New Recuperar_Contraseña
		RecuperarContraseñaForm.Show()
		Me.Hide()
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Application.Exit()
	End Sub

End Class