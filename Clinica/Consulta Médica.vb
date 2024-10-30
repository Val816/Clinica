Imports MySql.Data.MySqlClient

Public Class Consulta_Médica
    Private conexionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
    Private idMascota As Integer

    Private Sub SeleccionarMascota(mascotaId As Integer)
        idMascota = mascotaId
    End Sub

    Private Sub ConsultaMedicaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBoxDesparacitacion()
        LlenarComboBoxVacunas()
        LlenarComboBoxEstadoReprod()
        LlenarComboBoxServicios()
    End Sub

    Private Sub LlenarComboBoxDesparacitacion()
        ComboBoxDesparacitacion.Items.Clear()

        Dim query As String = "SELECT idDesparacitacion, nombre FROM Desparacitacion"
        Using conn As New MySqlConnection(conexionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxDesparacitacion.Items.Add(New KeyValuePair(Of Integer, String)(reader("idDesparacitacion"), reader("nombre")))
                End While
            End Using
        End Using

        ComboBoxDesparacitacion.DisplayMember = "Value"
        ComboBoxDesparacitacion.ValueMember = "Key"
    End Sub


    Private Sub LlenarComboBoxVacunas()
        ComboBoxVacunas.Items.Clear()

        Dim query As String = "SELECT idVacuna, nombreVac FROM Vacuna"
        Using conn As New MySqlConnection(conexionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxVacunas.Items.Add(New KeyValuePair(Of Integer, String)(reader("idVacuna"), reader("nombreVac")))
                End While
            End Using
        End Using

        ComboBoxVacunas.DisplayMember = "Value"
        ComboBoxVacunas.ValueMember = "Key"
    End Sub

    Private Sub LlenarComboBoxEstadoReprod()
        ComboBoxEstadoReprod.Items.Clear()

        Dim query As String = "SELECT idEstadoReproductivo, descripcion FROM EstadoReproductivo"
        Using conn As New MySqlConnection(conexionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxEstadoReprod.Items.Add(New KeyValuePair(Of Integer, String)(reader("idEstadoReproductivo"), reader("descripcion")))
                End While
            End Using
        End Using

        ComboBoxEstadoReprod.DisplayMember = "Value"
        ComboBoxEstadoReprod.ValueMember = "Key"
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



    Private Sub GuardarConsulta()
        Dim query As String = "INSERT INTO Consulta (idMascota, idDesparacitacion, idVacuna, temperatura, pulso, TLLC, estadoRep, frecCardi, frecResp, enfermedad, receta, desparacitacion, costoCons, observaciones, fechaConsulta) " &
                      "VALUES (@idMascota, @idDesparacitacion, @idVacuna, @idServicio, @temperatura, @pulso, @TLLC, @estadoRep, @frecCardi, @frecResp, @enfermedad, @receta, @desparacitacion, @costoCons, @observaciones, @fechaConsulta)"
        Using conn As New MySqlConnection(conexionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                cmd.Parameters.AddWithValue("@idDesparacitacion", If(ComboBoxDesparacitacion.SelectedItem IsNot Nothing, DirectCast(ComboBoxDesparacitacion.SelectedItem, KeyValuePair(Of Integer, String)).Key, DBNull.Value))
                cmd.Parameters.AddWithValue("@idVacuna", If(ComboBoxVacunas.SelectedItem IsNot Nothing, DirectCast(ComboBoxVacunas.SelectedItem, KeyValuePair(Of Integer, String)).Key, DBNull.Value))
                cmd.Parameters.AddWithValue("@temperatura", Convert.ToDouble(TextBoxTemperatura.Text))
                cmd.Parameters.AddWithValue("@pulso", TextBoxPulso.Text)
                cmd.Parameters.AddWithValue("@TLLC", TextBoxTLLC.Text)
                cmd.Parameters.AddWithValue("@estadoRep", ComboBoxEstadoReprod.SelectedValue)
                cmd.Parameters.AddWithValue("@frecCardi", TextBoxFrecCardiaca.Text)
                cmd.Parameters.AddWithValue("@frecResp", Convert.ToDouble(TextBoxFrecRespiratoria.Text))
                cmd.Parameters.AddWithValue("@enfermedad", TextBoxEnfermedad.Text)
                cmd.Parameters.AddWithValue("@receta", TextBoxReceta.Text)
                cmd.Parameters.AddWithValue("@desparacitacion", If(ComboBoxDesparacitacion.SelectedItem IsNot Nothing, "S", "N"))
                cmd.Parameters.AddWithValue("@costoCons", 300)
                cmd.Parameters.AddWithValue("@observaciones", TextBoxObservaciones.Text)
                cmd.Parameters.AddWithValue("@fechaConsulta", DateTime.Now)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Consulta guardada exitosamente")
            End Using
        End Using
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            GuardarConsulta()
        Catch ex As Exception
            MessageBox.Show("Error al guardar la consulta: " & ex.Message)
        End Try
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
            'Case 8
            '    Dim formEutanasia As New Eutanasia()
            '    formEutanasia.Show()
            '    Me.Hide()

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
                Dim formRecibo As New Recibo()
                formRecibo.Show()
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
