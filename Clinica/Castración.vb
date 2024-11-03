Imports MySql.Data.MySqlClient

Public Class Castración_y_Esterilización
    Private connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
    Private idMascota As Integer

    ' Constructor que recibe el id de la mascota
    Public Sub New(mascotaId As Integer)
        InitializeComponent()
        idMascota = mascotaId ' Asigna el idMascota recibido
    End Sub

    Public Sub New()
        InitializeComponent()
        ' Obtén el ID de la última mascota registrada
        idMascota = ObtenerUltimoIDMascota()
    End Sub

    Private Sub Castracion_y_Esterilizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTiposProcedimiento()
        LlenarComboBoxServicios() ' Llenar el ComboBox de servicios al cargar el formulario
        ' Cargar registros con la última mascota registrada
        If idMascota = 0 Then
            MessageBox.Show("No hay mascotas registradas.")
        Else
            CargarRegistros()
        End If
    End Sub

    Private Sub CargarTiposProcedimiento()
        ComboBoxTipoProcedimiento.Items.Add("Castracion")
        ComboBoxTipoProcedimiento.Items.Add("Esterilizacion")
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ComboBoxTipoProcedimiento.SelectedItem Is Nothing Or String.IsNullOrWhiteSpace(TextBoxObservaciones.Text) Then
            MessageBox.Show("Por favor, seleccione el tipo de procedimiento y complete las observaciones.")
            Return
        End If

        Dim tipo As String = ComboBoxTipoProcedimiento.SelectedItem.ToString()

        ' Intenta obtener los detalles de la mascota desde la base de datos
        Dim especieId As Integer
        Dim tallaId As Integer
        Dim costo As Decimal = ObtenerCostoProcedimiento(idMascota, tipo, especieId, tallaId)

        If costo <= 0 Then
            MessageBox.Show("Error al calcular el costo. Verifique los datos de la mascota.")
            Return
        End If

        ' Asigna el costo al TextBox para mostrarlo al usuario
        TextBoxCosto.Text = costo.ToString("C") ' Formato de moneda

        ' Guardar el registro
        Dim observaciones As String = TextBoxObservaciones.Text
        Dim query As String = "INSERT INTO RegistroProcedimiento (idMascota, tipoProcedimiento, idEspecie, idTalla, costo, fecha, observaciones) " &
                          "VALUES (@idMascota, @tipoProcedimiento, @idEspecie, @idTalla, @costo, CURDATE(), @observaciones)"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                cmd.Parameters.AddWithValue("@tipoProcedimiento", tipo)
                cmd.Parameters.AddWithValue("@idEspecie", especieId)
                cmd.Parameters.AddWithValue("@idTalla", tallaId)
                cmd.Parameters.AddWithValue("@costo", costo)
                cmd.Parameters.AddWithValue("@observaciones", observaciones)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro guardado exitosamente.")
                    CargarRegistros()
                Catch ex As MySqlException
                    MessageBox.Show("Error en la base de datos: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error general: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Function ObtenerCostoProcedimiento(idMascota As Integer, tipo As String, ByRef especieId As Integer, ByRef tallaId As Integer) As Decimal
        Dim costo As Decimal = 0
        Dim query As String = "SELECT idEspecie, idTalla FROM Mascota WHERE idMascota = @idMascota"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            especieId = reader.GetInt32("idEspecie")
                            tallaId = reader.GetInt32("idTalla")

                            ' Verifica que especieId y tallaId tengan valores válidos
                            If especieId = 0 Or tallaId = 0 Then
                                MessageBox.Show("La mascota no tiene una especie o talla válida asignada.")
                                Return 0
                            End If

                            costo = ObtenerCosto(tipo, tallaId) ' Ahora calculamos el costo basado en la talla
                        Else
                            MessageBox.Show("No se encontró la mascota con el ID proporcionado.")
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Error al obtener los datos de la mascota: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error general: " & ex.Message)
                End Try
            End Using
        End Using

        Return costo
    End Function

    Private Function ObtenerCosto(tipo As String, tallaId As Integer) As Decimal
        Dim costo As Decimal = 0

        If tipo = "Castracion" Then
            Select Case tallaId
                Case 1 ' chico
                    costo = 700
                Case 2 ' mediano
                    costo = 800
                Case 3 ' grande
                    costo = 1000
                Case Else
                    MessageBox.Show("Talla no válida para castración.")
            End Select
        ElseIf tipo = "Esterilizacion" Then
            Select Case tallaId
                Case 1 ' chico
                    costo = 1000
                Case 2 ' mediano
                    costo = 1300
                Case 3 ' grande
                    costo = 1700
                Case Else
                    MessageBox.Show("Talla no válida para esterilización.")
            End Select
        Else
            MessageBox.Show("Tipo de procedimiento no válido.")
        End If

        Return costo
    End Function

    Private Sub CargarRegistros()
        Dim query As String = "SELECT m.nomMasc AS NombreMascota, rp.tipoProcedimiento, rp.costo, rp.fecha FROM RegistroProcedimiento rp INNER JOIN Mascota m ON rp.idMascota = m.idMascota"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable()
                Try
                    conn.Open()
                    dt.Load(cmd.ExecuteReader())
                    DataGridViewRegistros.DataSource = dt
                Catch ex As MySqlException
                    MessageBox.Show("Error en la base de datos: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error general: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Function ObtenerUltimoIDMascota() As Integer
        Dim ultimoID As Integer = 0
        Dim query As String = "SELECT MAX(idMascota) AS UltimoID FROM Mascota"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            If Not IsDBNull(reader("UltimoID")) Then
                                ultimoID = reader.GetInt32("UltimoID")
                            End If
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al acceder a la base de datos: " & ex.Message)
                End Try
            End Using
        End Using

        Return ultimoID
    End Function
    Private Sub LlenarComboBoxServicios()
        ComboBoxServicios.Items.Clear()
        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBoxServicios.Items.Add(New ComboBoxItem(reader("nombre").ToString(), Convert.ToInt32(reader("idServicio"))))
                End While
            End Using
        End Using
        ComboBoxServicios.DisplayMember = "Text"
        ComboBoxServicios.ValueMember = "Value"
    End Sub

    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxServicios.SelectedIndexChanged
        Dim servicioSeleccionado As ComboBoxItem = CType(ComboBoxServicios.SelectedItem, ComboBoxItem)
        If servicioSeleccionado Is Nothing Then
            MessageBox.Show("Por favor, selecciona un servicio.")
            Return
        End If

        Dim idServicio As Integer = servicioSeleccionado.Value

        Select Case idServicio
            Case 1
                Dim formCirugia As New Cirugía()
                formCirugia.Show()
                Me.Hide()
            Case 2
                Dim consultamedica As New Consulta_Médica()
                consultamedica.Show()
                Me.Hide()
            Case 3
                Dim formDesparacitacion As New DesparacitacionForm()
                formDesparacitacion.Show()
                Me.Hide()
            Case 4
                Dim formEsterilizacion As New Castración_y_Esterilización(idMascota) ' Pasa el idMascota al nuevo formulario
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
                Dim formVacunacion As New Vacunacion()
                formVacunacion.Show()
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
                Dim formRecibo As New Recibo()
                formRecibo.Show()
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

Public Class ComboBoxItem
    Public Property Text As String
    Public Property Value As Integer

    Public Sub New(text As String, value As Integer)
        Me.Text = text
        Me.Value = value
    End Sub
End Class
