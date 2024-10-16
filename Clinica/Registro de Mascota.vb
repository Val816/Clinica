Imports MySql.Data.MySqlClient

Public Class Registro_de_Mascota

    Private Sub RegistroMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBoxGenero()
        LlenarComboBoxEspecie()
        LlenarComboBoxRaza()
        LlenarComboBoxTalla()
        LlenarComboBoxServicios()
        LlenarComboBoxEstadoReproductivo()
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

    ' Llenar ComboBox de estado reproductivo
    Private Sub LlenarComboBoxEstadoReproductivo()
        Dim query As String = "SELECT idEstadoReproductivo, descripcion FROM EstadoReproductivo"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxEstadoReproductivo.Items.Add(New With {.Value = reader("idEstadoReproductivo"), .Text = reader("descripcion")})
                End While
            End Using
        End Using
        ComboBoxEstadoReproductivo.DisplayMember = "Text"
        ComboBoxEstadoReproductivo.ValueMember = "Value"
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
            ' Verificar que se seleccionen todos los campos
            If ComboBoxEspecie.SelectedItem Is Nothing OrElse ComboBoxRaza.SelectedItem Is Nothing OrElse
               ComboBoxTalla.SelectedItem Is Nothing OrElse ComboBoxGenero.SelectedItem Is Nothing OrElse
               ComboBoxEstadoReproductivo.SelectedItem Is Nothing Then
                MessageBox.Show("Debe seleccionar todos los campos.")
                Return
            End If

            If MascotaExiste(txtNomMasc.Text, ComboBoxEspecie.SelectedItem.Value, ComboBoxRaza.SelectedItem.Value, Convert.ToDouble(txtPeso.Text), ComboBoxTalla.SelectedItem.Value, Convert.ToInt32(txtEdad.Text), ComboBoxGenero.SelectedItem.Value) Then
                MessageBox.Show("Esta mascota ya está registrada.")
                Return
            End If

            Dim query As String = "INSERT INTO Mascota (nomCliente, celular, nomMasc, idEspecie, idRaza, peso, idTalla, edad, caracteristicas, idGenero, idEstadoReproductivo) " &
                                  "VALUES (@nomCliente, @celular, @nomMasc, @idEspecie, @idRaza, @peso, @idTalla, @edad, @caracteristicas, @idGenero, @idEstadoReproductivo)"
            Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()

                    cmd.Parameters.AddWithValue("@nomCliente", txtNomCliente.Text)
                    cmd.Parameters.AddWithValue("@celular", Convert.ToDecimal(txtCelular.Text))
                    cmd.Parameters.AddWithValue("@nomMasc", txtNomMasc.Text)
                    cmd.Parameters.AddWithValue("@idEspecie", ComboBoxEspecie.SelectedItem.Value)
                    cmd.Parameters.AddWithValue("@idRaza", ComboBoxRaza.SelectedItem.Value)
                    cmd.Parameters.AddWithValue("@peso", Convert.ToDouble(txtPeso.Text))
                    cmd.Parameters.AddWithValue("@idTalla", ComboBoxTalla.SelectedItem.Value)
                    cmd.Parameters.AddWithValue("@edad", Convert.ToInt32(txtEdad.Text))
                    cmd.Parameters.AddWithValue("@caracteristicas", txtCaracteristicas.Text)
                    cmd.Parameters.AddWithValue("@idGenero", ComboBoxGenero.SelectedItem.Value)
                    cmd.Parameters.AddWithValue("@idEstadoReproductivo", ComboBoxEstadoReproductivo.SelectedItem.Value)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Mascota registrada exitosamente.")
            LimpiarCampos()
            MostrarDatosMascota()
        Catch ex As Exception
            MessageBox.Show("Error al guardar la mascota: " & ex.Message)
        End Try
    End Sub

    ' Limpiar campos
    Private Sub LimpiarCampos()
        txtNomCliente.Clear()
        txtCelular.Clear()
        txtNomMasc.Clear()
        txtPeso.Clear()
        txtEdad.Clear()
        txtCaracteristicas.Clear()
        ComboBoxGenero.SelectedIndex = -1
        ComboBoxEspecie.SelectedIndex = -1
        ComboBoxRaza.SelectedIndex = -1
        ComboBoxTalla.SelectedIndex = -1
        ComboBoxEstadoReproductivo.SelectedIndex = -1
        ComboBoxServicios.SelectedIndex = -1
    End Sub

    ' Redirigir al formulario de vacunación
    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxServicios.SelectedIndexChanged
        ' Obtener el servicio seleccionado
        Dim servicioSeleccionado As Object = ComboBoxServicios.SelectedItem
        If servicioSeleccionado Is Nothing Then
            MessageBox.Show("Por favor, selecciona un servicio.")
            Return
        End If

        Dim idServicio As Integer = servicioSeleccionado.Value

        ' Redirigir según el servicio seleccionado
        Select Case idServicio
            Case 1 ' 
                Dim formCirugia As New Cirugía()
                formCirugia.Show()
                Me.Hide()

            Case 2 ' 
                Dim consultamedica As New Consulta_Médica()
                consultamedica.Show()
                Me.Hide()

            'Case 4
            '    Dim formDesparacitacion As New Desparacitación()
            '    formDesparacitacion.Show()
            '    Me.Hide()

            'Case 5
            '    Dim formEsterilizacion As New Esterilización()
            '    formEsterilizacion.Show()
            '    Me.Hide()

            'Case 6
            '    Dim formPension As New Pensión()
            '    formPension.Show()
            '    Me.Hide()

            Case 7
                Dim formGrooming As New Estética()
                formGrooming.Show()
                Me.Hide()
            Case 8
                Dim formEutanasia As New Eutanasia()
                formEutanasia.Show()
                Me.Hide()

            Case 9
                Dim formGrooming As New Vacunacion()
                formGrooming.Show()
                Me.Hide()

                'Case 10
                '    Dim formHospitalizacion As New Hospitalización()
                '    formHospitalizacion.Show()
                '    Me.Hide()
                'Case 11
                '    Dim formProfilaxis As New Profilaxis_Dental()
                '    formProfilaxis.Show()
                '    Me.Hide()
            Case Else
                MessageBox.Show("Servicio no reconocido. Por favor, selecciona un servicio válido.")

        End Select
    End Sub
    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        ' Abrir el formulario del Menú Principal
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()

        ' Cerrar el formulario actual
        Me.Close()
    End Sub

    ' Mostrar datos de la mascota en el DataGridView
    Private Sub MostrarDatosMascota()
        Dim query As String = "SELECT idMascota, nomCliente, celular, nomMasc, idEspecie, idRaza, peso, idTalla, edad, caracteristicas, idGenero, idEstadoReproductivo FROM Mascota"

        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable() ' Usamos un DataTable para almacenar los datos
                Dim da As New MySqlDataAdapter(cmd)

                Try
                    conn.Open()
                    da.Fill(dt) ' Llenar el DataTable con los resultados de la consulta
                    DataGridMascota.DataSource = dt ' Vincular el DataTable al DataGridView
                Catch ex As Exception
                    MessageBox.Show("Error al mostrar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class
