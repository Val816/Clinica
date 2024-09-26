Imports System.Data.SqlClient
Public Class Registro_de_Cita
    ' Conexión a la base de datos
    Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"

    Private Sub btnRegistrarCita_Click(sender As Object, e As EventArgs) Handles btnRegistrarCita.Click
        ' Validar los datos del formulario
        If Not ValidarDatos() Then
            MessageBox.Show("Por favor, complete todos los campos correctamente.")
            Return
        End If

        ' Registrar la cita en la base de datos
        If RegistrarCita() Then
            MessageBox.Show("Cita registrada con éxito.")
        Else
            MessageBox.Show("Error al registrar la cita. Por favor, inténtelo de nuevo.")
        End If
    End Sub

    Private Function ValidarDatos() As Boolean
        ' Validar campos obligatorios (ejemplo de validación simple)
        Return Not String.IsNullOrWhiteSpace(txtNombreTutor.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtApellidoTutor.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtTelefono.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtNombreMascota.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtEspecie.Text) AndAlso
               dtpFecha.Value <= DateTime.Now ' Validar fecha 
    End Function

    Private Function RegistrarCita() As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Cita (nomCliente, apellidoPC, celular, nomMasc, especie, fecha, hora) VALUES (@nomCliente, @apellidoPC, @celular, @nomMasc, @especie, @fecha, @hora)"
                Using command As New SqlCommand(query, connection)
                    ' Asignación de valores
                    command.Parameters.AddWithValue("@nomCliente", txtNombreTutor.Text)
                    command.Parameters.AddWithValue("@apellidoPC", txtApellidoTutor.Text)
                    command.Parameters.AddWithValue("@celular", Convert.ToDecimal(txtTelefono.Text))
                    command.Parameters.AddWithValue("@nomMasc", txtNombreMascota.Text)
                    command.Parameters.AddWithValue("@especie", txtEspecie.Text)
                    command.Parameters.AddWithValue("@fecha", dtpFecha.Value) ' Asumiendo que tienes un DateTimePicker
                    command.Parameters.AddWithValue("@hora", txtHora.Text)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            ' Manejo de errores
            Console.WriteLine("Error al registrar la cita: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnContinuarRegistroMascota_Click(sender As Object, e As EventArgs) Handles btnContinuarRegistroMascota.Click
        ' Redirigir al formulario de registro de mascota
        Dim registroMascotaForm As New RegistroMascota()
        registroMascotaForm.Show()
        Me.Hide() ' Opcional: oculta el formulario actual
    End Sub

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()
    End Sub
End Class
