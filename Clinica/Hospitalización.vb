'Imports MySql.Data.MySqlClient

'Public Class Hospitalizacion
'    Private connectionString As String = "Server=localhost;Database=veterinaria;User Id=root;Password=root;"
'    Private idMascota As Integer

'    ' Constructor que recibe el ID de la mascota
'    Public Sub New(id As Integer)
'        InitializeComponent() ' Inicializa los componentes del formulario
'        idMascota = id
'    End Sub

'    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
'        ' Validar que todos los campos requeridos estén llenos
'        If String.IsNullOrWhiteSpace(TxtObservacio.Text) OrElse
'           String.IsNullOrWhiteSpace(TxtMedicinas.Text) OrElse
'           cmbTalla.SelectedItem Is Nothing OrElse
'           cmbTipoHospitalizacion.SelectedItem Is Nothing OrElse
'           dtpFechaSalida.Value < dtpFechaEntrada.Value Then
'            MessageBox.Show("Por favor, complete todos los campos y asegúrese de que la fecha de salida sea mayor que la de entrada.")
'            Return
'        End If

'        ' Llamar al método para guardar la hospitalización
'        GuardarHospitalizacion()
'    End Sub

'    ' Método para registrar hospitalización
'    Private Sub GuardarHospitalizacion()
'        Dim query As String = "INSERT INTO Hospitalizacion (idMascota, fechaEntrada, fechaSalida, observaciones, medicinas, idTalla, tipoHospitalizacion, costo) " &
'                              "VALUES (@idMascota, @fechaEntrada, @fechaSalida, @observaciones, @medicinas, @idTalla, @tipoHospitalizacion, @costo)"

'        Using conn As New MySqlConnection(connectionString)
'            Using cmd As New MySqlCommand(query, conn)
'                ' Obtener datos del formulario
'                Dim fechaEntrada As DateTime = dtpFechaEntrada.Value
'                Dim fechaSalida As DateTime = dtpFechaSalida.Value
'                Dim observaciones As String = TxtObservaciones.Text
'                Dim medicinas As String = TxtMedicinas.Text
'                Dim idTalla As Integer = CInt(cmbTalla.SelectedValue) ' ComboBox para Talla
'                Dim tipoHospitalizacion As String = cmbTipoHospitalizacion.SelectedItem.ToString()

'                ' Calcular los días de hospitalización
'                Dim dias As Integer = (fechaSalida - fechaEntrada).Days
'                If dias <= 0 Then
'                    MessageBox.Show("La fecha de salida debe ser mayor que la fecha de entrada.")
'                    Return
'                End If

'                ' Obtener el costo de hospitalización
'                Dim costoPorDia As Decimal = ObtenerCosto(idTalla, tipoHospitalizacion)
'                Dim total As Decimal = dias * costoPorDia

'                ' Asignar el costo total al TextBox
'                TxtCostoTotal.Text = total.ToString("C2") ' Formato de moneda

'                ' Agregar parámetros a la consulta
'                cmd.Parameters.AddWithValue("@idMascota", idMascota) ' Usa el ID de mascota recibido
'                cmd.Parameters.AddWithValue("@fechaEntrada", fechaEntrada)
'                cmd.Parameters.AddWithValue("@fechaSalida", fechaSalida)
'                cmd.Parameters.AddWithValue("@observaciones", observaciones)
'                cmd.Parameters.AddWithValue("@medicinas", medicinas)
'                cmd.Parameters.AddWithValue("@idTalla", idTalla)
'                cmd.Parameters.AddWithValue("@tipoHospitalizacion", tipoHospitalizacion)
'                cmd.Parameters.AddWithValue("@costo", total)

'                Try
'                    conn.Open()
'                    cmd.ExecuteNonQuery()
'                    MessageBox.Show("Hospitalización guardada exitosamente.")
'                Catch ex As Exception
'                    MessageBox.Show("Error al guardar hospitalización: " & ex.Message)
'                End Try
'            End Using
'        End Using
'    End Sub

'    ' Método para obtener el costo por día según talla y tipo de hospitalización
'    Private Function ObtenerCosto(idTalla As Integer, tipoHospitalizacion As String) As Decimal
'        Dim costo As Decimal = 0
'        Dim query As String = "SELECT costo FROM CostoHospitalizacion WHERE idTalla = @idTalla AND tipoHospitalizacion = @tipoHospitalizacion"

'        Using conn As New MySqlConnection(connectionString)
'            Using cmd As New MySqlCommand(query, conn)
'                cmd.Parameters.AddWithValue("@idTalla", idTalla)
'                cmd.Parameters.AddWithValue("@tipoHospitalizacion", tipoHospitalizacion)

'                Try
'                    conn.Open()
'                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
'                    If reader.Read() Then
'                        costo = reader.GetDecimal("costo")
'                    End If
'                Catch ex As Exception
'                    MessageBox.Show("Error al obtener costo: " & ex.Message)
'                End Try
'            End Using
'        End Using

'        Return costo
'    End Function
'End Class
