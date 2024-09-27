Imports System.Data.SqlClient

Public Class Recuperar_Contraseña
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ' Verificar que los campos no estén vacíos
        If txtCorreo.Text = "" Or txtNuevaContrasena.Text = "" Or txtConfirmarContrasena.Text = "" Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return
        End If

        ' Verificar que las contraseñas coincidan
        If txtNuevaContrasena.Text <> txtConfirmarContrasena.Text Then
            MessageBox.Show("Las contraseñas no coinciden.")
            Return
        End If

        ' Conexión a la base de datos (ajusta la cadena de conexión según corresponda)
        Using conn As New SqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            ' Verificar si el correo electrónico existe en la base de datos
            Dim query As String = "SELECT idUsuario FROM Usuario WHERE Correo = @Correo"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text)

                conn.Open()
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    ' Si el correo existe, actualizar la contraseña
                    Dim updateQuery As String = "UPDATE Usuario SET Contraseña = @NuevaContrasena WHERE Correo = @Correo"
                    Using updateCmd As New SqlCommand(updateQuery, conn)
                        updateCmd.Parameters.AddWithValue("@NuevaContrasena", txtNuevaContrasena.Text)
                        updateCmd.Parameters.AddWithValue("@Correo", txtCorreo.Text)

                        updateCmd.ExecuteNonQuery()
                        MessageBox.Show("Contraseña actualizada exitosamente.")

                        ' Redirigir al formulario de inicio de sesión
                        Dim inicioSesionForm As New Inicio_de_sesion()
                        inicioSesionForm.Show()
                        Me.Close() ' Cierra el formulario de recuperación de cuenta
                    End Using
                Else
                    ' Si el correo no existe, mostrar un mensaje
                    MessageBox.Show("El correo electrónico no está registrado.")
                End If
            End Using
        End Using
    End Sub

    Private Sub LimpiarCampos()
            txtCorreo.Text = ""
            txtNuevaContrasena.Text = ""
            txtConfirmarContrasena.Text = ""
        End Sub
    End Class

