Imports MySql.Data.MySqlClient

Public Class Registro_de_Cita
    ' Conexión a la base de datos
    Private connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"

    ' Evento para el botón "Registrar Cita"
    Private Sub btnRegistrarCita_Click(sender As Object, e As EventArgs) Handles btnRegistrarCita.Click
        ' Verificar si ya existe una cita para la misma fecha y hora
        Dim queryVerificar As String = "SELECT COUNT(*) FROM Cita WHERE fecha = @fecha AND hora = @hora"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryVerificar, connection)
                command.Parameters.AddWithValue("@fecha", DateTimePickerFecha.Value.Date)
                command.Parameters.AddWithValue("@hora", txtHora.Text)

                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Ya existe una cita registrada para esa fecha y hora.", "Error de cita", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' No hay duplicados, registrar la cita
                    RegistrarCita()
                End If
            End Using
        End Using
    End Sub

    ' Función para registrar la cita en la base de datos
    Private Sub RegistrarCita()
        Dim queryInsertar As String = "INSERT INTO Cita (nomCliente, apellidoPC, celular, nomMasc, especie, fecha, hora) " &
                                      "VALUES (@nomCliente, @apellidoPC, @celular, @nomMasc, @especie, @fecha, @hora)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryInsertar, connection)
                ' Agregar los parámetros del formulario
                command.Parameters.AddWithValue("@nomCliente", txtNomCliente.Text)
                command.Parameters.AddWithValue("@apellidoPC", txtApellido.Text)
                command.Parameters.AddWithValue("@celular", txtTelefono.Text)
                command.Parameters.AddWithValue("@nomMasc", txtNomMascota.Text)
                command.Parameters.AddWithValue("@especie", txtEspecie.Text)
                command.Parameters.AddWithValue("@fecha", DateTimePickerFecha.Value.Date)
                command.Parameters.AddWithValue("@hora", txtHora.Text)

                connection.Open()
                command.ExecuteNonQuery()

                MessageBox.Show("Cita registrada correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refrescar el DataGridView con las citas del día
                CargarCitas()
            End Using
        End Using
    End Sub

    ' Función para cargar las citas en el DataGridView para la fecha seleccionada
    Private Sub CargarCitas()
        Dim queryCargar As String = "SELECT idCita, nomCliente, apellidoPC, celular, nomMasc, especie, fecha, hora FROM Cita WHERE fecha = @fecha"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryCargar, connection)
                command.Parameters.AddWithValue("@fecha", DateTimePickerFecha.Value.Date)

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Asignar los datos al DataGridView
                DataGridViewCitas.DataSource = table
            End Using
        End Using
    End Sub

    ' Evento para cargar las citas al seleccionar una nueva fecha
    Private Sub DateTimePickerFecha_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFecha.ValueChanged
        CargarCitas()
    End Sub

    ' Al cargar el formulario, cargar las citas para la fecha actual
    Private Sub FormRegistroCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCitas()
    End Sub

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        ' Abrir el formulario del Menú Principal
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()

        ' Cerrar el formulario actual
        Me.Close()
    End Sub
    Private Sub btnContinuarRegistroMascota_Click(sender As Object, e As EventArgs) Handles btnContinuarRegistroMascota.Click
        Dim registroMascota As New Registro_de_Mascota()
        registroMascota.Show()
        Me.Close()
    End Sub


End Class
