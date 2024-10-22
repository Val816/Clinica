Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Castración_y_Esterilización
    Dim conexion As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")

    Public Class TallaItem
        Public Property idTalla As Integer
        Public Property nomTalla As String

        Public Overrides Function ToString() As String
            Return nomTalla
        End Function
    End Class

    Private Sub FormCastracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTallas()
        LlenarComboBoxServicios()
        AddHandler ComboBoxServicio.SelectedIndexChanged, AddressOf ComboBoxServicio_SelectedIndexChanged
    End Sub

    ' Carga las tallas disponibles
    Private Sub CargarTallas()
        Try
            Dim queryTalla As String = "SELECT idTalla, nombre FROM Talla"
            Dim cmdTalla As New MySqlCommand(queryTalla, conexion)
            conexion.Open()
            Dim readerTalla As MySqlDataReader = cmdTalla.ExecuteReader()

            ComboBoxTalla.Items.Clear()

            While readerTalla.Read()
                Dim talla As New TallaItem() With {
                    .idTalla = readerTalla("idTalla"),
                    .nomTalla = readerTalla("nombre")
                }
                ComboBoxTalla.Items.Add(talla)
            End While

            readerTalla.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar las tallas: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' Llena el combo box de los servicios adicionales
    Private Sub LlenarComboBoxServicios()
        ComboBoxServicio.Items.Clear()
        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxServicio.Items.Add(New With {.Value = reader("idServicio"), .Text = reader("nombre")})
                End While
            End Using
        End Using
        ComboBoxServicio.DisplayMember = "Text"
        ComboBoxServicio.ValueMember = "Value"
    End Sub


    ' Guarda los datos de la castración
    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Try
            If ComboBoxTalla.SelectedItem Is Nothing Then
                MessageBox.Show("Por favor, selecciona una talla.")
                Return
            End If

            Dim selectedTalla As TallaItem = CType(ComboBoxTalla.SelectedItem, TallaItem)
            Dim idTalla As Integer = selectedTalla.idTalla
            Dim fechaCastracion As String = TextFecha.ToString("yyyy-MM-dd")
            Dim observaciones As String = TextBoxObservaciones.Text
            Dim costoCastracion As Decimal

            ' Verificar si el costo es un valor válido
            If Decimal.TryParse(TextBoxCosto.Text, costoCastracion) = False Then
                MessageBox.Show("Por favor, ingresa un costo válido.")
                Return
            End If

            Dim query As String = "INSERT INTO Castracion (idTalla, fecha, observaciones, precioCas) " &
                                  "VALUES (@idTalla, @fecha, @observaciones, @precioCas)"
            Dim cmd As New MySqlCommand(query, conexion)

            cmd.Parameters.AddWithValue("@idTalla", idTalla)
            cmd.Parameters.AddWithValue("@fecha", fechaCastracion)
            cmd.Parameters.AddWithValue("@observaciones", observaciones)
            cmd.Parameters.AddWithValue("@precioCas", costoCastracion)

            conexion.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("Castración registrada exitosamente.")
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al registrar la castración: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' Función para limpiar los campos después de guardar
    Private Sub LimpiarCampos()
        ComboBoxTalla.SelectedIndex = -1
        TextBoxObservaciones.Clear()
        TextBoxCosto.Clear()
    End Sub

    ' Funcionalidad del botón "Continuar a recibo"
    Private Sub ButtonContinuarRecibo_Click(sender As Object, e As EventArgs) Handles ButtonContinuarRecibo.Click

    End Sub

    ' Control del cambio de servicio
    Private Sub ComboBoxServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxServicio.SelectedIndexChanged
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

            Case 4
                Dim formDesparacitacion As New Desparacitación()
                formDesparacitacion.Show()
                Me.Hide()

                ' Case 5
                '    Dim formEsterilizacion As New Esterilización()
                ' formEsterilizacion.Show()
               ' Me.Hide()

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
                'Case 11
                Dim formProfilaxis As New Proaxis_Dental()
                formProfilaxis.Show()
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

End Class
End Class