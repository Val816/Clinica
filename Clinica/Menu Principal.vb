Imports MySql.Data.MySqlClient

Public Class Menu_Principal
    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarServicios()
    End Sub

    Private Sub CargarServicios()
        Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("SELECT idServicio, nombre FROM Servicio", connection)
            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                cmbServicios.Items.Clear()

                While reader.Read()
                    Dim idServicio As Integer = reader.GetInt32("idServicio")
                    Dim nombreServicio As String = reader.GetString("nombre")
                    cmbServicios.Items.Add(New Servicio(idServicio, nombreServicio))
                End While

                cmbServicios.DisplayMember = "Nombre"
                cmbServicios.ValueMember = "ID"
            Catch ex As Exception
                MessageBox.Show("Error al cargar los servicios: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cmbServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServicios.SelectedIndexChanged
        Dim selectedService As Servicio = CType(cmbServicios.SelectedItem, Servicio)

        If selectedService IsNot Nothing Then
            RedirigirFormulario(selectedService.ID)
        End If
    End Sub

    Private Sub RedirigirFormulario(idServicio As Integer)
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
            '    Dim formDesparacitacion As New desparacitación(idMascota)
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
                Dim formRecibo As New Recibo()
                formRecibo.Show()
                Me.Hide()
            Case Else
                MessageBox.Show("Servicio no reconocido. Por favor, selecciona un servicio válido.")

        End Select
    End Sub


    Private Sub btnRegistro_de_Cita_Click(sender As Object, e As EventArgs) Handles btnRegistroCita.Click
        Dim registroCitaForm As New Registro_de_Cita()
        Me.Hide()
        registroCitaForm.Show()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim consultaCitaForm As New Consulta_de_Cita()
        Me.Hide()
        consultaCitaForm.Show()
    End Sub

    Private Sub btnMascota_Click(sender As Object, e As EventArgs) Handles btnMascota.Click
        Dim registroMascotaForm As New Registro_de_Mascota()
        Me.Hide()
        registroMascotaForm.Show()
    End Sub

    Private Sub btnCerrarSistema_Click(sender As Object, e As EventArgs) Handles btnCerrarSistema.Click
        Application.Exit()
    End Sub
End Class

Public Class Servicio
    Public Property ID As Integer
    Public Property Nombre As String

    Public Sub New(id As Integer, nombre As String)
        Me.ID = id
        Me.Nombre = nombre
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
