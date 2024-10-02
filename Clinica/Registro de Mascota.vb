Imports MySql.Data.MySqlClient
Public Class Registro_de_Mascota

    ' Función que carga el formulario y llena el ComboBox de servicios
    Private Sub Registro_de_Mascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar ComboBox de servicios (ejemplo de servicios)
        ComboBoxServicios.Items.Add("Desparacitación")
        ComboBoxServicios.Items.Add("Vacunación")
        ComboBoxServicios.Items.Add("Consulta")
        ComboBoxServicios.Items.Add("Cirugía")
    End Sub

    ' Botón para guardar los datos de la mascota y continuar con el servicio seleccionado
    Private Sub btnGuardarContinuar_Click(sender As Object, e As EventArgs) Handles btnGuardarContinuar.Click
        ' Verificar si los campos obligatorios están llenos
        If String.IsNullOrEmpty(txtNomMasc.Text) Or String.IsNullOrEmpty(txtEspecie.Text) Or ComboBoxServicios.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, llene todos los campos obligatorios y seleccione un servicio.")
            Return
        End If

        Try
            ' Código para insertar en la base de datos
            Dim query As String = "INSERT INTO Mascota (nomMasc, especie, raza, peso, talla, edad, caracteristicas, idGenero) VALUES (@nomMasc, @especie, @raza, @peso, @talla, @edad, @caracteristicas, @idGenero)"
            Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    cmd.Parameters.AddWithValue("@nomMasc", txtNomMasc.Text)
                    cmd.Parameters.AddWithValue("@especie", txtEspecie.Text)
                    cmd.Parameters.AddWithValue("@raza", txtRaza.Text)
                    cmd.Parameters.AddWithValue("@peso", Convert.ToDouble(txtPeso.Text))
                    cmd.Parameters.AddWithValue("@talla", txtTalla.Text)
                    cmd.Parameters.AddWithValue("@edad", Convert.ToInt32(txtEdad.Text))
                    cmd.Parameters.AddWithValue("@caracteristicas", txtCaracteristicas.Text)
                    cmd.Parameters.AddWithValue("@idGenero", ObtenerIdGenero())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Mascota registrada con éxito.")
        Catch ex As Exception
            MessageBox.Show("Error al registrar la mascota: " & ex.Message)
        End Try

        Select Case ComboBoxServicios.SelectedItem.ToString()
            Case "Desparacitación"
                Dim frmDesparacitacion As New Desparacitación()
                frmDesparacitacion.Show()
            'Case "Vacunación"
            '    Dim frmVacunacion As New Vacunacion()
            '    frmVacunacion.Show()
            Case "Consulta"
                Dim frmConsulta As New Consulta_Médica()
                frmConsulta.Show()
                'Case "Cirugía"
                '    Dim frmCirugia As New Cirugia()
                '    frmCirugia.Show()
                'Case "Grooming"
                '    Dim frmConsulta As New Consulta_Médica()
                '    frmConsulta.Show()
            Case Else
                MessageBox.Show("Seleccione un servicio válido.")
        End Select
    End Sub
    Private Sub RegistroMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxGenero.Items.Add("Macho")
        ComboBoxGenero.Items.Add("Hembra")
        ComboBoxGenero.SelectedIndex = 0 ' Selecciona "Macho" como predeterminado
    End Sub
    Private Function ObtenerIdGenero() As Integer
        Select Case ComboBoxGenero.SelectedItem.ToString()
            Case "Macho"
                Return 1 ' ID para Macho
            Case "Hembra"
                Return 2 ' ID para Hembra
            Case Else
                Return 0 ' ID por defecto si no se selecciona
        End Select
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Dim frmMenuPrincipal As New Menu_Principal()
        frmMenuPrincipal.Show()
    End Sub

End Class