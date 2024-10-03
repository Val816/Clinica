Imports MySql.Data.MySqlClient

Public Class Registro_de_Mascota

    Private Sub RegistroMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar ComboBox de género, especie, raza, talla, y servicios
        LlenarComboBoxGenero()
        LlenarComboBoxEspecie()
        LlenarComboBoxRaza()
        LlenarComboBoxTalla()
        LlenarComboBoxServicios()
        MostrarDatosMascota() ' Mostrar los datos de la mascota al cargar
    End Sub

    ' Llenar ComboBox de género
    Private Sub LlenarComboBoxGenero()
        Dim query As String = "SELECT idGenero, descripcion FROM Genero"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxGenero.Items.Add(New With {.Value = reader("idGenero"), .Text = reader("descripcion")})
                End While
            End Using
        End Using
        ComboBoxGenero.DisplayMember = "Text"
        ComboBoxGenero.ValueMember = "Value"
    End Sub

    ' Llenar ComboBox de especie
    Private Sub LlenarComboBoxEspecie()
        Dim query As String = "SELECT idEspecie, nombreEspecie FROM Especie"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxEspecie.Items.Add(New With {.Value = reader("idEspecie"), .Text = reader("nombreEspecie")})
                End While
            End Using
        End Using
        ComboBoxEspecie.DisplayMember = "Text"
        ComboBoxEspecie.ValueMember = "Value"
    End Sub

    ' Llenar ComboBox de raza
    Private Sub LlenarComboBoxRaza()
        Dim query As String = "SELECT idRaza, nombreRaza FROM Raza"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxRaza.Items.Add(New With {.Value = reader("idRaza"), .Text = reader("nombreRaza")})
                End While
            End Using
        End Using
        ComboBoxRaza.DisplayMember = "Text"
        ComboBoxRaza.ValueMember = "Value"
    End Sub

    ' Llenar ComboBox de talla
    Private Sub LlenarComboBoxTalla()
        Dim query As String = "SELECT idTalla, descripcion FROM Talla"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxTalla.Items.Add(New With {.Value = reader("idTalla"), .Text = reader("descripcion")})
                End While
            End Using
        End Using
        ComboBoxTalla.DisplayMember = "Text"
        ComboBoxTalla.ValueMember = "Value"
    End Sub

    ' Llenar ComboBox de servicios
    Private Sub LlenarComboBoxServicios()
        ComboBoxServicios.Items.Clear() ' Limpia los ítems previos para evitar duplicados
        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxServicios.Items.Add(New With {.Value = reader("idServicio"), .Text = reader("nombre")})
                End While
            End Using
        End Using
        ComboBoxServicios.DisplayMember = "Text"
        ComboBoxServicios.ValueMember = "Value"
    End Sub


    ' Guardar datos de la mascota
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Comprobar si hay valores seleccionados en los ComboBox antes de continuar
            If ComboBoxEspecie.SelectedItem Is Nothing OrElse ComboBoxRaza.SelectedItem Is Nothing OrElse
           ComboBoxTalla.SelectedItem Is Nothing OrElse ComboBoxGenero.SelectedItem Is Nothing Then
                MessageBox.Show("Debe seleccionar todos los campos.")
                Return
            End If

            Dim query As String = "INSERT INTO Mascota (nomMasc, idEspecie, idRaza, peso, idTalla, edad, caracteristicas, idGenero) " &
                              "VALUES (@nomMasc, @idEspecie, @idRaza, @peso, @idTalla, @edad, @caracteristicas, @idGenero)"
            Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()

                    ' Agregar los parámetros para la consulta
                    cmd.Parameters.AddWithValue("@nomMasc", txtNomMasc.Text)
                    cmd.Parameters.AddWithValue("@idEspecie", ComboBoxEspecie.SelectedItem.Value)
                    cmd.Parameters.AddWithValue("@idRaza", ComboBoxRaza.SelectedItem.Value)
                    cmd.Parameters.AddWithValue("@peso", Convert.ToDouble(txtPeso.Text))
                    cmd.Parameters.AddWithValue("@idTalla", ComboBoxTalla.SelectedItem.Value)
                    cmd.Parameters.AddWithValue("@edad", Convert.ToInt32(txtEdad.Text))
                    cmd.Parameters.AddWithValue("@caracteristicas", txtCaracteristicas.Text)
                    cmd.Parameters.AddWithValue("@idGenero", ComboBoxGenero.SelectedItem.Value)

                    ' Ejecutar la consulta
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Datos de la mascota guardados exitosamente.")
            MostrarDatosMascota() ' Actualizar el DataGrid
        Catch ex As Exception
            ' Mostrar mensaje de error con la descripción detallada del error
            MessageBox.Show("Error al guardar los datos: " & ex.Message)
        End Try
    End Sub


    ' Redirigir a la ventana del servicio seleccionado al presionar "Continuar"
    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        ' Guardar los datos de la mascota
        btnGuardar_Click(sender, e)

        ' Redirigir a la ventana del servicio seleccionado
        Dim idServicioSeleccionado As Integer = ComboBoxServicios.SelectedItem.Value

        Select Case idServicioSeleccionado
            'Case 1 ' Servicio de Vacunación
            '    Dim vacunacionForm As New Vacunacion()
            '    vacunacionForm.Show()
            Case 2 ' Servicio de Desparacitación
                Dim desparacitacionForm As New Desparacitación()
                desparacitacionForm.Show()
                ' Agregar más casos según los servicios disponibles
        End Select

        Me.Close() ' Cerrar el formulario actual
    End Sub

    ' Mostrar datos de la mascota en un DataGrid de manera vertical
    Private Sub MostrarDatosMascota()
        Dim query As String = "SELECT M.nomMasc, E.nombreEspecie, R.nombreRaza, M.peso, T.descripcion AS talla, M.edad, M.caracteristicas, G.descripcion AS genero " &
                          "FROM Mascota M " &
                          "JOIN Especie E ON M.idEspecie = E.idEspecie " &
                          "JOIN Raza R ON M.idRaza = R.idRaza " &
                          "JOIN Talla T ON M.idTalla = T.idTalla " &
                          "JOIN Genero G ON M.idGenero = G.idGenero"
        Dim dt As New DataTable()
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
                DataGridMascotas.DataSource = dt
            End Using
        End Using
    End Sub


    ' Botón para cerrar el formulario y regresar al menú
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()
        Me.Close() ' Cerrar el formulario actual
    End Sub

End Class