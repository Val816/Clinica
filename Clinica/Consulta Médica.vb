Imports MySql.Data.MySqlClient

Public Class Consulta_Médica
    Private conexionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
    Private idMascota As Integer
    Private idEstadoReprod As Integer

    Private Sub ConsultaMedicaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New MySqlConnection(conexionString)
            conn.Open()
            idMascota = ObtenerUltimoIdMascota(conn)
            idEstadoReprod = ObtenerUltimoIdEstadoReprod(conn)
        End Using
        LlenarComboBoxDesparacitacion()
        LlenarComboBoxVacunas()
        LlenarComboBoxEstadoReprod()
        LlenarComboBoxServicios()

        ' Establecer el último valor de estado reproductivo en el ComboBox
        ComboBoxEstadoReprod.SelectedValue = idEstadoReprod
    End Sub

    Private Function ObtenerUltimoIdMascota(connection As MySqlConnection) As Integer
        Dim idMascota As Integer = 0
        Try
            Dim query As String = "SELECT MAX(idMascota) FROM Mascota"
            Using cmd As New MySqlCommand(query, connection)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    idMascota = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID de la mascota: " & ex.Message)
        End Try
        Return idMascota
    End Function

    Private Function ObtenerUltimoIdEstadoReprod(connection As MySqlConnection) As Integer
        Dim idEstadoReprod As Integer = 0
        Try
            Dim query As String = "SELECT idEstadoReproductivo FROM Mascota ORDER BY idMascota DESC LIMIT 1"
            Using cmd As New MySqlCommand(query, connection)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    idEstadoReprod = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID de estado reproductivo: " & ex.Message)
        End Try
        Return idEstadoReprod
    End Function

    Private Sub LlenarComboBoxDesparacitacion()
        ComboBoxDesparacitacion.Items.Clear()
        ComboBoxDesparacitacion.Items.Add(New KeyValuePair(Of Integer, String)(0, "No aplica")) ' Agregar "No aplica"

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
        ComboBoxVacunas.Items.Add(New KeyValuePair(Of Integer, String)(0, "No aplica")) ' Agregar "No aplica"

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
        Using conn As New MySqlConnection(conexionString)
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
                      "VALUES (@idMascota, @idDesparacitacion, @idVacuna, @temperatura, @pulso, @TLLC, @estadoRep, @frecCardi, @frecResp, @enfermedad, @receta, @desparacitacion, @costoCons, @observaciones, @fechaConsulta)"
        Using conn As New MySqlConnection(conexionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                cmd.Parameters.AddWithValue("@idDesparacitacion", If(ComboBoxDesparacitacion.SelectedItem IsNot Nothing, DirectCast(ComboBoxDesparacitacion.SelectedItem, KeyValuePair(Of Integer, String)).Key, DBNull.Value))
                cmd.Parameters.AddWithValue("@idVacuna", If(ComboBoxVacunas.SelectedItem IsNot Nothing, DirectCast(ComboBoxVacunas.SelectedItem, KeyValuePair(Of Integer, String)).Key, DBNull.Value))
                cmd.Parameters.AddWithValue("@temperatura", Convert.ToDouble(TextBoxTemperatura.Text))
                cmd.Parameters.AddWithValue("@pulso", TextBoxPulso.Text)
                cmd.Parameters.AddWithValue("@TLLC", TextBoxTLLC.Text)
                cmd.Parameters.AddWithValue("@estadoRep", idEstadoReprod)
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

            Case 3
                Dim formDesparacitacion As New DesparacitacionForm()
                formDesparacitacion.Show()
                Me.Hide()

            Case 4
                Dim formEsterilizacion As New Castración_y_Esterilización()
                formEsterilizacion.Show()
                Me.Hide()

            Case 5
                Dim formPension As New Pensión()
                formPension.Show()
                Me.Hide()

            Case 6
                Dim formGrooming As New Estética()
                formGrooming.Show()
                Me.Hide()
            Case 7
                Dim formEutanasia As New Eutanasia()
                formEutanasia.Show()
                Me.Hide()

            Case 8
                Dim formGrooming As New Vacunacion()
                formGrooming.Show()
                Me.Hide()

            Case 9
                Dim formHospitalizacion As New Hospitalización()
                formHospitalizacion.Show()
                Me.Hide()
            Case 10
                Dim formProfilaxis As New Proaxis_Dental()
                formProfilaxis.Show()
                Me.Hide()
            Case 11
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

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class
