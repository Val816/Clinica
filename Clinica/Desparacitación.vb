'Imports MySql.Data.MySqlClient

'Public Class Desparacitación

'    Private Sub DesparacitacionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Llenar ComboBox de desparacitaciones y servicios al cargar el formulario
'        LlenarComboBoxDesparacitacion()
'        LlenarComboBoxServicios()
'        MostrarDatosMascotaSeleccionada() ' Mostrar los datos de la mascota seleccionada en un Label
'        CalcularCostoDesparacitacion() ' Calcular el costo inicial al cargar el formulario
'    End Sub

'    ' Llenar ComboBox de desparacitaciones
'    Private Sub LlenarComboBoxDesparacitacion()
'        Dim query As String = "SELECT idDesparacitacion, descripcion FROM Desparacitacion"
'        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
'            Using cmd As New MySqlCommand(query, conn)
'                conn.Open()
'                Dim reader As MySqlDataReader = cmd.ExecuteReader()
'                Dim items As New HashSet(Of String)() ' Usar un HashSet para evitar duplicados
'                While reader.Read()
'                    Dim descripcion = reader("descripcion").ToString()
'                    If Not items.Contains(descripcion) Then
'                        items.Add(descripcion) ' Agregar a HashSet
'                        ComboBoxDesparacitacion.Items.Add(New With {.Value = reader("idDesparacitacion"), .Text = descripcion})
'                    End If
'                End While
'            End Using
'        End Using
'        ComboBoxDesparacitacion.DisplayMember = "Text"
'        ComboBoxDesparacitacion.ValueMember = "Value"
'    End Sub

'    ' Llenar ComboBox de servicios
'    Private Sub LlenarComboBoxServicios()
'        ComboBoxServicios.Items.Clear() ' Limpia los ítems previos para evitar duplicados
'        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio WHERE idServicio BETWEEN 1 AND 5 OR idServicio BETWEEN 8 AND 15"
'        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
'            Using cmd As New MySqlCommand(query, conn)
'                conn.Open()
'                Dim reader As MySqlDataReader = cmd.ExecuteReader()
'                While reader.Read()
'                    ComboBoxServicios.Items.Add(New With {.Value = reader("idServicio"), .Text = reader("nombre").ToString()})
'                End While
'            End Using
'        End Using
'        ComboBoxServicios.DisplayMember = "Text"
'        ComboBoxServicios.ValueMember = "Value"
'    End Sub

'    ' Mostrar los datos de la mascota seleccionada
'    Private Sub MostrarDatosMascotaSeleccionada()
'        Dim idMascota As Integer = ObtenerIdMascota()

'        Dim query As String = "SELECT nomMasc FROM Mascota WHERE idMascota = @idMascota"
'        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
'            Using cmd As New MySqlCommand(query, conn)
'                conn.Open()
'                cmd.Parameters.AddWithValue("@idMascota", idMascota)
'                Dim reader As MySqlDataReader = cmd.ExecuteReader()
'                If reader.Read() Then
'                    LabelNomMascota.Text = reader("nomMasc").ToString() ' Mostrar el nombre de la mascota en el Label
'                End If
'            End Using
'        End Using
'    End Sub

'    ' Obtener ID de la mascota registrada
'    Private Function ObtenerIdMascota() As Integer
'        ' Aquí podrías tener la lógica para obtener el ID de la mascota registrada en un formulario anterior
'        Return 1 ' Cambiar según la lógica que utilices
'    End Function

'    ' Calcular el costo de desparacitación según la raza seleccionada
'    Private Sub CalcularCostoDesparacitacion()
'        Dim query As String = "SELECT C.costo 
'                               FROM Mascota M
'                               JOIN Talla T ON M.idTalla = T.idTalla
'                               JOIN CostoDesparacitacion C ON T.idTalla = C.idTalla
'                               WHERE M.idMascota = @idMascota"
'        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
'            Using cmd As New MySqlCommand(query, conn)
'                conn.Open()
'                cmd.Parameters.AddWithValue("@idMascota", ObtenerIdMascota())
'                Dim costo As Decimal = 0

'                Dim reader As MySqlDataReader = cmd.ExecuteReader()
'                If reader.Read() Then
'                    costo = Convert.ToDecimal(reader("costo"))
'                    LabelCostoDesparacitacion.Text = $"Costo de desparacitación: {costo} pesos"
'                Else
'                    MessageBox.Show("No se encontró información de costo para la mascota seleccionada.")
'                End If

'                txtCostoTotal.Text = costo.ToString("0.00") ' Mostrar el costo total en el TextBox
'            End Using
'        End Using
'    End Sub

'    ' Guardar datos de la desparacitación
'    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
'        Try
'            ' Verificar si se seleccionó una desparacitación antes de guardar
'            If ComboBoxDesparacitacion.SelectedItem Is Nothing Then
'                MessageBox.Show("Debe seleccionar una desparacitación.")
'                Return
'            End If

'            Dim query As String = "INSERT INTO DesparacitacionHistorial (idMascota, idDesparacitacion, fecha, costo) " &
'                                  "VALUES (@idMascota, @idDesparacitacion, @fecha, @costo)"
'            Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
'                Using cmd As New MySqlCommand(query, conn)
'                    conn.Open()
'                    cmd.Parameters.AddWithValue("@idMascota", ObtenerIdMascota())
'                    cmd.Parameters.AddWithValue("@idDesparacitacion", ComboBoxDesparacitacion.SelectedItem.Value)
'                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now)
'                    cmd.Parameters.AddWithValue("@costo", Convert.ToDecimal(txtCostoTotal.Text))

'                    ' Ejecutar la consulta
'                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
'                    If rowsAffected > 0 Then
'                        MessageBox.Show("Datos de la desparacitación guardados exitosamente.")
'                    Else
'                        MessageBox.Show("No se guardaron los datos. Intenta nuevamente.")
'                    End If
'                End Using
'            End Using
'        Catch ex As Exception
'            MessageBox.Show("Error al guardar los datos: " & ex.Message)
'        End Try
'    End Sub

'    ' Redirigir al servicio seleccionado y guardar los datos
'    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
'        ' Guardar los datos de la desparacitación
'        btnGuardar_Click(sender, e)

'        ' Redirigir al servicio seleccionado
'        If ComboBoxServicios.SelectedItem IsNot Nothing Then
'            Dim idServicioSeleccionado As Integer = ComboBoxServicios.SelectedItem.Value
'            Select Case idServicioSeleccionado
'                Case 1 ' Servicio de Cirugía
'                    Dim cirugiaForm As New Cirugía()
'                    cirugiaForm.Show()
'                Case 2 ' Servicio de Consulta
'                    Dim consultaForm As New Consulta_Médica()
'                    consultaForm.Show()
'                    ' Agregar más casos según los servicios disponibles
'                Case Else
'                    MessageBox.Show("Servicio no disponible.")
'            End Select
'        Else
'            MessageBox.Show("Debe seleccionar un servicio antes de continuar.")
'        End If

'        Me.Close() ' Cerrar el formulario actual
'    End Sub

'    ' Botón para cerrar el formulario
'    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
'        Dim menuPrincipal As New Menu_Principal()
'        menuPrincipal.Show()
'        Me.Close() ' Cerrar el formulario actual
'    End Sub
'End Class
