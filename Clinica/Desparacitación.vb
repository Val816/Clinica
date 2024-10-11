Imports MySql.Data.MySqlClient

Public Class Desparacitación
    Private conexionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
    Private idMascota As Integer

    ' Constructor que recibe el id de la mascota
    Public Sub New(idMascotaPasada As Integer)
        InitializeComponent()
        idMascota = idMascotaPasada
    End Sub

    ' Cargar el formulario y llenar los ComboBox al cargar el formulario
    Private Sub DesparacitacionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBoxDesparacitacion()
        LlenarComboBoxServicios()
    End Sub

    ' Llenar ComboBox de Desparacitaciones
    Private Sub LlenarComboBoxDesparacitacion()
        ComboBoxDesparacitacion.Items.Clear()

        Dim query As String = "SELECT idDesparacitacion, nombre FROM Desparacitacion"
        Using conn As New MySqlConnection(conexionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ' Usar KeyValuePair para agregar el valor y el texto
                    ComboBoxDesparacitacion.Items.Add(New KeyValuePair(Of Integer, String)(reader("idDesparacitacion"), reader("nombre")))
                End While
            End Using
        End Using

        ComboBoxDesparacitacion.DisplayMember = "Value"
        ComboBoxDesparacitacion.ValueMember = "Key"
    End Sub

    ' Llenar ComboBox de Servicios
    Private Sub LlenarComboBoxServicios()
        ComboBoxServicios.Items.Clear()

        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using conn As New MySqlConnection(conexionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxServicios.Items.Add(New KeyValuePair(Of Integer, String)(reader("idServicio"), reader("nombre")))
                End While
            End Using
        End Using

        ComboBoxServicios.DisplayMember = "Value"
        ComboBoxServicios.ValueMember = "Key"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            GuardarRegistroDesparacitacion()
        Catch ex As Exception
            MessageBox.Show("Error al guardar el registro de desparacitación: " & ex.Message)
        End Try
    End Sub

    ' Redirigir al formulario adecuado cuando selecciona un servicio
    Private Sub GuardarRegistroDesparacitacion()
        Dim query As String = "INSERT INTO RegistroDesparacitaciones (idMascota, idDesparacitacion, observaciones) VALUES (@idMascota, @idDesparacitacion, @observaciones)"

        Using conn As New MySqlConnection(conexionString)
            Using cmd As New MySqlCommand(query, conn)
                ' Obtener el idDesparacitacion seleccionado
                Dim idDesparacitacionSeleccionada As Integer = CType(ComboBoxDesparacitacion.SelectedItem, KeyValuePair(Of Integer, String)).Key

                ' Agregar parámetros al comando SQL
                cmd.Parameters.AddWithValue("@idMascota", idMascota) ' Usar el idMascota pasado al formulario
                cmd.Parameters.AddWithValue("@idDesparacitacion", idDesparacitacionSeleccionada)
                cmd.Parameters.AddWithValue("@observaciones", TextBoxObservaciones.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro de desparacitación guardado exitosamente.")
            End Using
        End Using
    End Sub

    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxServicios.SelectedIndexChanged
        If ComboBoxServicios.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona un servicio.")
            Return
        End If

        ' Obtener el servicio seleccionado como KeyValuePair
        Dim servicioSeleccionado As KeyValuePair(Of Integer, String) = CType(ComboBoxServicios.SelectedItem, KeyValuePair(Of Integer, String))
        Dim idServicio As Integer = servicioSeleccionado.Key ' Obtener el idServicio


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

    ' Botón para regresar al Menú Principal
    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim menuPrincipal As New Menu_Principal()
        menuPrincipal.Show()
        Me.Close()
    End Sub
End Class
