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
        Dim query As String = "SELECT idServicio, nombreServicio FROM Servicio"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxServicios.Items.Add(New With {.Value = reader("idServicio"), .Text = reader("nombreServicio")})
                End While
            End Using
        End Using
        ComboBoxServicios.DisplayMember = "Text"
        ComboBoxServicios.ValueMember = "Value"
    End Sub

    ' Guardar datos de la mascota
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim query As String = "INSERT INTO Mascota (nomMasc, idEspecie, idRaza, peso, idTalla, edad, caracteristicas, idGenero) " &
                              "VALUES (@nomMasc, @idEspecie, @idRaza, @peso, @idTalla, @edad, @caracteristicas, @idGenero)"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@nomMasc", txtNomMasc.Text)
                cmd.Parameters.AddWithValue("@idEspecie", ComboBoxEspecie.SelectedItem.Value)
                cmd.Parameters.AddWithValue("@idRaza", ComboBoxRaza.SelectedItem.Value)
                cmd.Parameters.AddWithValue("@peso", Convert.ToDouble(txtPeso.Text))
                cmd.Parameters.AddWithValue("@idTalla", ComboBoxTalla.SelectedItem.Value)
                cmd.Parameters.AddWithValue("@edad", Convert.ToInt32(txtEdad.Text))
                cmd.Parameters.AddWithValue("@caracteristicas", txtCaracteristicas.Text)
                cmd.Parameters.AddWithValue("@idGenero", ComboBoxGenero.SelectedItem.Value)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("Datos de la mascota guardados exitosamente.")
        MostrarDatosMascota() ' Actualizar el DataGrid
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
        Dim query As String = "SELECT nomMasc, especie, raza, peso, talla, edad, caracteristicas FROM Mascota"
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