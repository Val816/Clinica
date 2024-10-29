Imports MySql.Data.MySqlClient

Public Class Registro_de_Cita
    Private connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"


    Private Sub btnRegistrarCita_Click(sender As Object, e As EventArgs) Handles btnRegistrarCita.Click
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
                    RegistrarCita()
                End If
            End Using
        End Using
    End Sub

    Private Sub RegistrarCita()
        Dim queryInsertar As String = "INSERT INTO Cita (nomCliente, apellidoPC, celular, nomMasc, especie, fecha, hora) " &
                                      "VALUES (@nomCliente, @apellidoPC, @celular, @nomMasc, @especie, @fecha, @hora)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryInsertar, connection)
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

                CargarCitas()
            End Using
        End Using
    End Sub

    Private Sub CargarCitas()
        Dim queryCargar As String = "SELECT idCita, nomCliente, apellidoPC, celular, nomMasc, especie, fecha, hora FROM Cita WHERE fecha = @fecha"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryCargar, connection)
                command.Parameters.AddWithValue("@fecha", DateTimePickerFecha.Value.Date)

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                DataGridViewCitas.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub DateTimePickerFecha_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFecha.ValueChanged
        CargarCitas()
    End Sub

    Private Sub FormRegistroCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCitas()
    End Sub

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click

        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
