Imports MySql.Data.MySqlClient

Public Class Recuperar_Contraseña
    Private connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"


    Private Sub btnCambiarContraseña_Click(sender As Object, e As EventArgs) Handles btnCambiarContraseña.Click

        If String.IsNullOrEmpty(txtCorreo.Text) Or String.IsNullOrEmpty(txtNuevaContraseña.Text) Or String.IsNullOrEmpty(txtConfirmaContraseña.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If txtNuevaContraseña.Text <> txtConfirmaContraseña.Text Then
            MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique.", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim queryVerificarCorreo As String = "SELECT COUNT(*) FROM Usuario WHERE Correo = @Correo"
        Dim queryActualizarContraseña As String = "UPDATE Usuario SET Contraseña = @NuevaContraseña WHERE Correo = @Correo"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using verificarCmd As New MySqlCommand(queryVerificarCorreo, connection)
                verificarCmd.Parameters.AddWithValue("@Correo", txtCorreo.Text)

                Dim count As Integer = Convert.ToInt32(verificarCmd.ExecuteScalar())

                If count = 0 Then
                    MessageBox.Show("El correo no existe. Por favor, verifique.", "Correo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using actualizarCmd As New MySqlCommand(queryActualizarContraseña, connection)
                        actualizarCmd.Parameters.AddWithValue("@NuevaContraseña", txtNuevaContraseña.Text)
                        actualizarCmd.Parameters.AddWithValue("@Correo", txtCorreo.Text)

                        actualizarCmd.ExecuteNonQuery()
                        MessageBox.Show("La contraseña ha sido cambiada correctamente.", "Cambio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim formLogin As New Inicio_de_sesion()
                        formLogin.Show()
                        Me.Close()
                    End Using
                End If
            End Using
        End Using
    End Sub


    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim formLogin As New Inicio_de_sesion()
        formLogin.Show()
        Me.Close()
    End Sub
End Class
