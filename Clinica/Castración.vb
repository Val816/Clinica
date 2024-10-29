Imports MySql.Data.MySqlClient

Public Class Castración_y_Esterilización
    Dim connectionString As String = "server=localhost;user id=root;password=root;database=veterinaria"
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)
    Dim idMascota As Integer
    Dim tipoProcedimiento As String
    Dim costo As Decimal
    Dim fecha As Date
    Dim observaciones As String

    Private Sub Castración_y_Esterilización_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar los ComboBox
        ComboBoxTipoProcedimiento.Items.Add("Castracion")
        ComboBoxTipoProcedimiento.Items.Add("Esterilizacion")
        ComboBoxEspecie.Items.Add("Perro")
        ComboBoxEspecie.Items.Add("Gato")
        ComboBoxTalla.Items.Add("Chico")
        ComboBoxTalla.Items.Add("Mediano")
        ComboBoxTalla.Items.Add("Grande")
    End Sub

    Private Sub ComboBoxTipoProcedimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoProcedimiento.SelectedIndexChanged, ComboBoxTalla.SelectedIndexChanged
        If ComboBoxTipoProcedimiento.SelectedIndex = -1 Or ComboBoxTalla.SelectedIndex = -1 Then
            Return
        End If

        tipoProcedimiento = ComboBoxTipoProcedimiento.SelectedItem.ToString()
        Dim idTalla As Integer = ComboBoxTalla.SelectedIndex + 1

        Select Case tipoProcedimiento
            Case "Castracion"
                Select Case idTalla
                    Case 1
                        TextBoxCosto.Text = "700.00"
                    Case 2
                        TextBoxCosto.Text = "850.00"
                    Case 3
                        TextBoxCosto.Text = "1000.00"
                End Select
            Case "Esterilizacion"
                Select Case idTalla
                    Case 1
                        TextBoxCosto.Text = "1000.00"
                    Case 2
                        TextBoxCosto.Text = "1300.00"
                    Case 3
                        TextBoxCosto.Text = "1700.00"
                End Select
        End Select

        If Not Decimal.TryParse(TextBoxCosto.Text, costo) Then
            MessageBox.Show("Por favor, ingresa un costo válido.")
            Return
        End If
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If idMascota = 0 Then
            MessageBox.Show("Por favor, selecciona una mascota válida.")
            Return
        End If


        fecha = DateTime.Now
        observaciones = "Observaciones del procedimiento."

        Dim query As String = "INSERT INTO ProcedimientoAnimal (idMascota, tipoProcedimiento, costo, fecha, observaciones) " &
                              "VALUES (@idMascota, @tipoProcedimiento, @costo, @fecha, @observaciones)"

        Using command As MySqlCommand = New MySqlCommand(query, connection)
            ' Agregar los parámetros
            command.Parameters.AddWithValue("@idMascota", idMascota)
            command.Parameters.AddWithValue("@tipoProcedimiento", tipoProcedimiento)
            command.Parameters.AddWithValue("@costo", costo)
            command.Parameters.AddWithValue("@fecha", fecha)
            command.Parameters.AddWithValue("@observaciones", observaciones)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Procedimiento registrado correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error al registrar el procedimiento: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub LlenarComboBoxServicios()
        ComboBoxServicios.Items.Clear()
        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using conn As New MySqlConnection(connectionString)
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

    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim servicioSeleccionado = CType(ComboBoxServicios.SelectedItem, Object)

        If servicioSeleccionado Is Nothing Then
            MessageBox.Show("Por favor, selecciona un servicio.")
            Return
        End If

        Dim idServicio As Integer = CInt(servicioSeleccionado.Value)

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

            Case 5
                Dim formEsterilizacion As New Castración_y_Esterilización()
                formEsterilizacion.Show()
                Me.Hide()

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

    Private Sub BtnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
