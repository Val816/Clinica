Imports MySql.Data.MySqlClient

Public Class Proaxis_Dental
    Public Class ComboBoxItem
        Public Property Value As Integer
        Public Property Text As String

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub FormProfilaxisDental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar ComboBox de tallas desde la base de datos
        LlenarComboBoxTallas()
        LlenarComboBoxServicios()
    End Sub

    Private Sub LlenarComboBoxTallas()
        ' Conectar a la base de datos y llenar el ComboBox de tallas con id y descripción
        Dim query As String = "SELECT idTalla, descripcion FROM Talla"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Dim cmd As New MySqlCommand(query, conn)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim item As New ComboBoxItem With {
                    .Value = reader("idTalla"),
                    .Text = reader("descripcion").ToString()
                }
                ComboBoxTalla.Items.Add(item)
            End While
        End Using
    End Sub

    Private Sub LlenarComboBoxServicios()
        ComboBoxServicios.Items.Clear()
        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim item As New ComboBoxItem With {
                        .Value = reader("idServicio"),
                        .Text = reader("nombre").ToString()
                    }
                    ComboBoxServicios.Items.Add(item)
                End While
            End Using
        End Using
    End Sub
    Private Sub ComboBoxTalla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTalla.SelectedIndexChanged
        ' Obtener el costo basado en la talla seleccionada
        Dim idTallaSeleccionada As Integer = CType(ComboBoxTalla.SelectedItem, ComboBoxItem).Value
        Dim query As String = "SELECT precio FROM PrecioProfilaxis WHERE idTalla = @idTalla"

        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@idTalla", idTallaSeleccionada)
            conn.Open()
            Dim costo As Object = cmd.ExecuteScalar()
            If costo IsNot Nothing Then
                TextBoxCosto.Text = Convert.ToDecimal(costo).ToString("C2") ' Muestra el costo en formato de moneda
            Else
                TextBoxCosto.Text = "0.00"
            End If
        End Using
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Guardar la información de profilaxis en la base de datos
        Dim idMascota As Integer = 1 ' Suponiendo que el idMascota es conocido
        Dim fecha As Date = DateTimePickerFecha.Value
        Dim horaEntrada As Date = DateTimePickerHoraEntrada.Value
        Dim horaSalida As Date = DateTimePickerHoraSalida.Value
        Dim idTalla As Integer = CType(ComboBoxTalla.SelectedItem, ComboBoxItem).Value
        Dim observaciones As String = TextBoxObservaciones.Text
        Dim costo As Decimal = Decimal.Parse(TextBoxCosto.Text, Globalization.NumberStyles.Currency)

        Dim query As String = "INSERT INTO ProfilaxisDental (idMascota, fecha, horaEntrada, horaSalida, idTalla, observaciones, costo) " &
                              "VALUES (@idMascota, @fecha, @horaEntrada, @horaSalida, @idTalla, @observaciones, @costo)"

        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@idMascota", idMascota)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@horaEntrada", horaEntrada)
            cmd.Parameters.AddWithValue("@horaSalida", horaSalida)
            cmd.Parameters.AddWithValue("@idTalla", idTalla)
            cmd.Parameters.AddWithValue("@observaciones", observaciones)
            cmd.Parameters.AddWithValue("@costo", costo)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Registro de profilaxis guardado exitosamente.")
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
End Class
