Imports MySql.Data.MySqlClient
Public Class Consulta_Médica

    ' Variables para la conexión 
    Dim connectionString As String = "server=localhost;user id=root;password=tu_password;database=tu_base_datos"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        Private Sub FormConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Cargar datos en los ComboBox al cargar el formulario
            CargarDesparacitaciones()
            CargarVacunaciones()
            CargarServicios()
        End Sub

        Private Sub CargarDesparacitaciones()
            Dim query As String = "SELECT idDesparacitacion, descripcion FROM Desparacitacion"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            ComboBoxDesparacitacion.DataSource = table
            ComboBoxDesparacitacion.DisplayMember = "descripcion"
            ComboBoxDesparacitacion.ValueMember = "idDesparacitacion"
        End Sub

        Private Sub CargarVacunaciones()
            Dim query As String = "SELECT idVacunacion FROM Vacunacion"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

        ComboBoxVacuna.DataSource = table
        ComboBoxVacuna.DisplayMember = "idVacunacion"
        ComboBoxVacuna.ValueMember = "idVacunacion"
    End Sub

    Private Sub CargarServicios()
        Dim query As String = "SELECT idServicio, nombreServ FROM Servicio"
        Dim command As New MySqlCommand(query, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        ComboBoxServicio.DataSource = table
        ComboBoxServicio.DisplayMember = "nombreServ"
        ComboBoxServicio.ValueMember = "idServicio"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            connection.Open()

            ' Query para insertar los datos de la consulta
            Dim query As String = "INSERT INTO Consulta (idDesparacitacion, idVacunacion, idServicio, temperatura, pulso, TLLC, estadoRep, frecCardi, frecResp, observaciones, receta, costoCons, condicionCorp) " &
                                  "VALUES (@idDesparacitacion, @idVacunacion, @idServicio, @temperatura, @pulso, @TLLC, @estadoRep, @frecCardi, @frecResp, @observaciones, @receta, @costoCons, @condicionCorp)"

            Dim command As New MySqlCommand(query, connection)

            '' Asignar valores de los ComboBox y TextBox a los parámetros de la consulta
            'command.Parameters.AddWithValue("@idDesparacitacion", ComboBoxDesparacitacion.SelectedValue)
            'command.Parameters.AddWithValue("@idVacunacion", ComboBoxVacuna.SelectedValue)
            'command.Parameters.AddWithValue("@idServicio", ComboBoxServicio.SelectedValue)
            '    command.Parameters.AddWithValue("@temperatura", Convert.ToDouble(txtTemperatura.Text))
            '    command.Parameters.AddWithValue("@pulso", txtPulso.Text)
            '    command.Parameters.AddWithValue("@TLLC", txtTLLC.Text)
            '    command.Parameters.AddWithValue("@estadoRep", txtEstadoRep.Text)
            '    command.Parameters.AddWithValue("@frecCardi", txtFrecCardi.Text)
            '    command.Parameters.AddWithValue("@frecResp", Convert.ToDouble(txtFrecResp.Text))
            '    command.Parameters.AddWithValue("@observaciones", txtObservaciones.Text)
            '    command.Parameters.AddWithValue("@receta", txtReceta.Text)
            '    command.Parameters.AddWithValue("@costoCons", Convert.ToDouble(txtCosto.Text))
            '    command.Parameters.AddWithValue("@condicionCorp", txtCondicionCorp.Text)

            ' Ejecutar la consulta
            command.ExecuteNonQuery()

                MessageBox.Show("Consulta registrada con éxito")

            Catch ex As Exception
                MessageBox.Show("Error al registrar la consulta: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Sub


End Class
