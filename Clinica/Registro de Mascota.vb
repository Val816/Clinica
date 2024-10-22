Imports MySql.Data.MySqlClient

Public Class Registro_de_Mascota
    Private selectedPetId As Integer
    Private Sub RegistroMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBoxGenero()
        LlenarComboBoxEspecie()
        LlenarComboBoxRaza()
        LlenarComboBoxTalla()
        LlenarComboBoxServicios()
        LlenarComboBoxEstadoReproductivo()
        LlenarComboBoxEdadUnidad()
        CargarDatosMascota()
    End Sub

    Private Sub LlenarComboBoxEdadUnidad()
        ComboBoxEdadUnidad.Items.Add("Meses")
        ComboBoxEdadUnidad.Items.Add("Años")
        ComboBoxEdadUnidad.SelectedIndex = 0
    End Sub


    Private Sub LlenarComboBoxGenero()
        Dim query As String = "SELECT idGenero, descripcion FROM Genero"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Dim generos As New List(Of Object)()
                While reader.Read()
                    ComboBoxGenero.Items.Add(New With {.Value = reader("idGenero"), .Text = reader("descripcion")})
                End While
            End Using
        End Using
        ComboBoxGenero.DisplayMember = "Text"
        ComboBoxGenero.ValueMember = "Value"
    End Sub


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

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClients()
    End Sub

    Private Sub LoadClients()
        Dim connString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
        Dim query As String = "SELECT m.idMascota, m.nomCliente, m.apCliente, m.celular, m.nomMasc, m.idEspecie, m.idRaza, m.peso, m.idTalla, m.edad, m.caracteristicas, m.idGenero, m.idEstadoReproductivo, m.fecha FROM Mascota m"

        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand(query, conn)
            conn.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DataGridViewMascotas.DataSource = dt
        End Using
    End Sub


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



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
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
            If String.IsNullOrWhiteSpace(txtEdad.Text) OrElse Not IsNumeric(txtEdad.Text) Then
                MessageBox.Show("Por favor, ingrese una edad válida.")
                Return
            End If

            Dim edad As Integer = Convert.ToInt32(txtEdad.Text)
            Dim unidad As String = ComboBoxEdadUnidad.SelectedItem.ToString()

            If unidad = "Años" Then
                edad *= 12
            End If

            Dim query As String = "INSERT INTO Mascota (nomCliente, apCliente, celular, nomMasc, idEspecie, idRaza, peso, idTalla, edad, caracteristicas, idGenero, idEstadoReproductivo) " &
                                  "VALUES (@nomCliente, @apCliente, @celular, @nomMasc, @idEspecie, @idRaza, @peso, @idTalla, @edad, @caracteristicas, @idGenero, @idEstadoReproductivo)"
            Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()

                    cmd.Parameters.AddWithValue("@nomCliente", txtNomCliente.Text)
                    cmd.Parameters.AddWithValue("@apCliente", txtApCliente.Text)
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
                    MessageBox.Show("Datos de la mascota guardados correctamente.")
                    CargarDatosMascota()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message)
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim nombreCliente As String = txtNomCliente.Text
        Dim apellidoCliente As String = txtApCliente.Text
        Dim telefonoCliente As String = txtCelular.Text

        If nombreCliente = "" Or telefonoCliente = "" Then
            MessageBox.Show("Por favor, ingresa el nombre del cliente y su número de teléfono.")
            Exit Sub
        End If
        Dim query As String = "SELECT * FROM Mascota WHERE nomCliente = @nombreCliente AND celular = @telefonoCliente AND apCliente = @ApellidoCliente"

        Using connection As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombreCliente", nombreCliente)
                command.Parameters.AddWithValue("@apellidoCliente", apellidoCliente)
                command.Parameters.AddWithValue("@telefonoCliente", telefonoCliente)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()
                            txtNomMasc.Text = reader("nomMasc").ToString()
                            ComboBoxEspecie.SelectedValue = reader("idEspecie").ToString()
                            ComboBoxRaza.SelectedValue = reader("idRaza").ToString()
                            ComboBoxEspecie.SelectedValue = reader("idEspecie").ToString()
                            ComboBoxGenero.SelectedValue = reader("idGenero").ToString()
                            ComboBoxTalla.SelectedValue = reader("idTalla").ToString()
                            ComboBoxEstadoReproductivo.SelectedValue = reader("idEstadoReproductivo").ToString()
                            txtPeso.Text = reader("peso").ToString()
                            txtEdad.Text = reader("edad").ToString()
                        End While
                    Else
                        MessageBox.Show("No se encontró ninguna mascota para este cliente.")
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error al buscar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub LimpiarCampos()
        txtNomCliente.Clear()
        txtApCliente.Clear()
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
    End Sub



    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxServicios.SelectedIndexChanged

        Dim servicioSeleccionado As Object = ComboBoxServicios.SelectedItem
        If servicioSeleccionado Is Nothing Then
            MessageBox.Show("Por favor, selecciona un servicio.")
            Return
        End If

        Dim idServicio As Integer = servicioSeleccionado.Value

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

            Case 6
                Dim formPension As New Pensión()
                formPension.Show()
                Me.Hide()

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

            Case 10
                Dim formHospitalizacion As New Hospitalización()
                formHospitalizacion.Show()
                Me.Hide()
            Case 11
                Dim formProfilaxis As New Proaxis_Dental()
                formProfilaxis.Show()
                Me.Hide()
            Case 12
                Dim formmRecibo As New Recibo()
                formmRecibo.Show()
                Me.Hide()
            Case Else
                MessageBox.Show("Servicio no reconocido. Por favor, selecciona un servicio válido.")

        End Select
    End Sub
    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click

        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()

        Me.Close()
    End Sub

    Private Sub CargarDatosMascota()
        ' Declaración correcta de la consulta SQL
        Dim query As String = "SELECT * FROM Mascota WHERE nomCliente = @nombreCliente AND celular = @telefonoCliente AND apCliente = @apellidoCliente"

        ' Establecer conexión
        Using connection As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            ' Crear comando MySQL
            Using command As New MySqlCommand(query, connection)
                ' Aquí debes agregar los valores para los parámetros
                command.Parameters.AddWithValue("@nombreCliente", txtNomCliente.Text.Trim())
                command.Parameters.AddWithValue("@telefonoCliente", txtCelular.Text.Trim())
                command.Parameters.AddWithValue("@apellidoCliente", txtApCliente.Text.Trim())

                Try
                    ' Abrir conexión
                    connection.Open()

                    ' Crear adaptador para cargar los datos en la tabla
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Asignar la tabla al DataGridView
                    DataGridViewMascotas.DataSource = table
                    DataGridViewMascotas.Columns("idMascota").Visible = False
                    DataGridViewMascotas.Columns("nomCliente").HeaderText = "Nombre"
                    DataGridViewMascotas.Columns("apCliente").HeaderText = "Apellido"
                    DataGridViewMascotas.Columns("celular").HeaderText = "Teléfono"
                    DataGridViewMascotas.Columns("nomMasc").HeaderText = "Mascota"
                    DataGridViewMascotas.Columns("idEspecie").HeaderText = "Especie"
                    DataGridViewMascotas.Columns("idRaza").HeaderText = "Raza"
                    DataGridViewMascotas.Columns("peso").HeaderText = "Peso"
                    DataGridViewMascotas.Columns("idTalla").HeaderText = "Talla"
                    DataGridViewMascotas.Columns("edad").HeaderText = "Edad"
                    DataGridViewMascotas.Columns("caracteristicas").HeaderText = "Características"
                    DataGridViewMascotas.Columns("idGenero").HeaderText = "Género"
                    DataGridViewMascotas.Columns("idEstadoReproductivo").HeaderText = "Estado Reproductivo"
                    DataGridViewMascotas.Columns("fecha").HeaderText = "Fecha"

                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub




    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridViewMascotas.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, selecciona una fila del DataGridView para eliminar.")
            Exit Sub
        End If

        Dim nombreMascota As String = DataGridViewMascotas.SelectedRows(0).Cells("nomMasc").Value.ToString()
        Dim telefonoCliente As String = DataGridViewMascotas.SelectedRows(0).Cells("celular").Value.ToString()

        Dim confirmacion As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.No Then
            Exit Sub
        End If

        Dim query As String = "DELETE FROM Mascota WHERE nomMasc = @nombreMascota AND celular = @telefonoCliente"

        Using connection As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombreMascota", nombreMascota)
                command.Parameters.AddWithValue("@telefonoCliente", telefonoCliente)

                Try
                    connection.Open()
                    Dim result As Integer = command.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Registro eliminado correctamente.")
                        CargarDatosMascota()
                        txtNomCliente.Clear()
                        txtCelular.Clear()
                        txtNomMasc.Clear()
                        ComboBoxEspecie.SelectedIndex = -1
                        ComboBoxRaza.SelectedIndex = -1
                        ComboBoxGenero.SelectedIndex = -1
                        ComboBoxTalla.SelectedIndex = -1
                        ComboBoxEstadoReproductivo.SelectedIndex = -1
                        txtPeso.Clear()
                        txtEdad.Clear()
                    Else
                        MessageBox.Show("No se encontró ninguna mascota para eliminar.")
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error al eliminar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub DataGridViewMascotas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMascotas.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridViewMascotas.Rows(e.RowIndex)

            txtNomCliente.Text = GetCellValue(row, "nomCliente")
            txtApCliente.Text = GetCellValue(row, "apCliente")
            txtCelular.Text = GetCellValue(row, "celular")
            txtNomMasc.Text = GetCellValue(row, "nomMasc")
            txtPeso.Text = GetCellValue(row, "peso")
            txtEdad.Text = GetCellValue(row, "edad")

            'SetComboBoxValue(ComboBoxEspecie, GetCellValue(row, "idEspecie"))
            'SetComboBoxValue(ComboBoxRaza, GetCellValue(row, "idRaza"))
            'SetComboBoxValue(ComboBoxTalla, GetCellValue(row, "idTalla"))
            'SetComboBoxValue(ComboBoxEstadoReproductivo, GetCellValue(row, "idEstadoReproductivo"))
            'SetComboBoxValue(ComboBoxGenero, GetCellValue(row, "idGenero"))
        End If
    End Sub

    Private Function GetCellValue(row As DataGridViewRow, columnName As String) As String
        Return If(IsDBNull(row.Cells(columnName).Value), "", row.Cells(columnName).Value.ToString())
    End Function

    Private Sub SetComboBoxValue(comboBox As ComboBox, value As String)
        If Not String.IsNullOrEmpty(value) Then
            Dim item = comboBox.Items.Cast(Of DataRowView)().FirstOrDefault(Function(r) r(comboBox.ValueMember).ToString() = value)
            If item IsNot Nothing Then
                comboBox.SelectedItem = item
            Else
                comboBox.SelectedIndex = -1
            End If
        Else
            comboBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub LoadPetDetails(idMascota As Integer)
        Dim connString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
        Dim query As String = "SELECT * FROM Mascota WHERE idMascota = @idMascota"

        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@idMascota", idMascota)

            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtNomMasc.Text = reader("nomMasc").ToString()
            End If
        End Using
    End Sub

End Class
