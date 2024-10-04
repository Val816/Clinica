Imports MySql.Data.MySqlClient

Public Class Registro_de_Mascota

    Private Sub RegistroMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LlenarComboBoxGenero()
        LlenarComboBoxEspecie()
        LlenarComboBoxRaza()
        LlenarComboBoxTalla()
        LlenarComboBoxServicios()
        MostrarDatosMascota()
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
        ComboBoxServicios.Items.Clear()
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

    ' Función para verificar si la mascota ya existe en la base de datos
    Private Function MascotaExiste(nomMasc As String, idEspecie As Integer, idRaza As Integer, peso As Double, idTalla As Integer, edad As Integer, idGenero As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Mascota WHERE nomMasc = @nomMasc AND idEspecie = @idEspecie AND idRaza = @idRaza AND peso = @peso AND idTalla = @idTalla AND edad = @edad AND idGenero = @idGenero"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nomMasc", nomMasc)
                cmd.Parameters.AddWithValue("@idEspecie", idEspecie)
                cmd.Parameters.AddWithValue("@idRaza", idRaza)
                cmd.Parameters.AddWithValue("@peso", peso)
                cmd.Parameters.AddWithValue("@idTalla", idTalla)
                cmd.Parameters.AddWithValue("@edad", edad)
                cmd.Parameters.AddWithValue("@idGenero", idGenero)
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    ' Guardar datos de la mascota
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If ComboBoxEspecie.SelectedItem Is Nothing OrElse ComboBoxRaza.SelectedItem Is Nothing OrElse
           ComboBoxTalla.SelectedItem Is Nothing OrElse ComboBoxGenero.SelectedItem Is Nothing Then
                MessageBox.Show("Debe seleccionar todos los campos.")
                Return
            End If

            If MascotaExiste(txtNomMasc.Text, ComboBoxEspecie.SelectedItem.Value, ComboBoxRaza.SelectedItem.Value, Convert.ToDouble(txtPeso.Text), ComboBoxTalla.SelectedItem.Value, Convert.ToInt32(txtEdad.Text), ComboBoxGenero.SelectedItem.Value) Then
                MessageBox.Show("Esta mascota ya está registrada.")
                Return
            End If

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
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxServicios.SelectedIndexChanged

        If ComboBoxServicios.SelectedItem IsNot Nothing Then
            Dim idServicio As Integer = ComboBoxServicios.SelectedItem.Value

            Select Case idServicio
                Case 1
                    Dim ventanaDesparacitacion As New Desparacitación()
                    ventanaDesparacitacion.Show()
            'Case 2
            '    Dim ventanaVacunacion As New Vacunación()
            '    ventanaVacunacion.Show()
                Case 3
                    Dim ventanaVacunacion As New Consulta_Médica()
                    ventanaVacunacion.Show()
                Case 4
                    Dim ventanaDesparacitacion As New Desparacitación()
                    ventanaDesparacitacion.Show()
                Case Else
                    MessageBox.Show("Servicio no disponible.")
            End Select


            Me.Hide()
        End If
    End Sub




    Private Sub MostrarDatosMascota()
        Dim query As String = "SELECT nomMasc, (SELECT nombreEspecie FROM Especie WHERE idEspecie = m.idEspecie) AS especie, " &
                          "(SELECT nombreRaza FROM Raza WHERE idRaza = m.idRaza) AS raza, " &
                          "peso, (SELECT descripcion FROM Talla WHERE idTalla = m.idTalla) AS talla, " &
                          "edad, caracteristicas, (SELECT descripcion FROM Genero WHERE idGenero = m.idGenero) AS genero " &
                          "FROM Mascota m"
        Dim dt As New DataTable()
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        DataGridViewMascota.DataSource = dt
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()
    End Sub
End Class
