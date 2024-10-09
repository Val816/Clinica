Imports MySql.Data.MySqlClient

Public Class Menu_Principal
    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llama al método para cargar los servicios en el ComboBox
        CargarServicios()
    End Sub

    Private Sub CargarServicios()
        ' Configura tu cadena de conexión a la base de datos
        Dim connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("SELECT idServicio, nombre FROM Servicio", connection)
            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Limpia el ComboBox antes de cargar los nuevos datos
                cmbServicios.Items.Clear()

                While reader.Read()
                    Dim idServicio As Integer = reader.GetInt32("idServicio")
                    Dim nombreServicio As String = reader.GetString("nombre")
                    ' Agrega cada servicio al ComboBox como un objeto Servicio
                    cmbServicios.Items.Add(New Servicio(idServicio, nombreServicio))
                End While

                ' Configura la presentación del ComboBox
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
            Case 1 ' Cirugía
                Dim cirugiaForm As New Cirugía()
                Me.Hide()
                cirugiaForm.Show()
            Case 2 ' Consulta Médica
                Dim consultaForm As New Consulta_Médica()
                Me.Hide()
                consultaForm.Show()
            'Case 3 ' Esterilización (si está habilitado)
            '    Dim esterilizacionForm As New Esterilizacion()
            '    Me.Hide()
            '    esterilizacionForm.Show()
            Case 4 ' Desparacitación
                Dim desparacitacionForm As New Desparacitación()
                Me.Hide()
                desparacitacionForm.Show()
            Case 5 ' Vacunación (si está habilitado)
                Dim vacunacionForm As New Vacunacion()
                Me.Hide()
                vacunacionForm.Show()
            Case Else
                MessageBox.Show("Servicio no encontrado.")
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
        Application.Exit() ' Cierra la aplicación completamente
    End Sub
End Class

' Clase para el servicio
Public Class Servicio
    Public Property ID As Integer
    Public Property Nombre As String

    Public Sub New(id As Integer, nombre As String)
        Me.ID = id
        Me.Nombre = nombre
    End Sub

    ' Sobreescribir el método ToString para mostrar el nombre en el ComboBox
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
