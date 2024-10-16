Imports MySql.Data.MySqlClient

Public Class Cirugía
    ' Conexión a la base de datos
    Private connectionString As String = "Server=localhost;Database=tu_base_de_datos;Uid=tu_usuario;Pwd=tu_contraseña;"
    Private selectedCirugias As New List(Of Integer) ' Lista para almacenar los IDs de las cirugías seleccionadas
    Private totalCost As Decimal = 0 ' Variable para almacenar el costo total

    ' Método para cargar los tipos de cirugías en el ComboBox al cargar el formulario
    Private Sub CirugiaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCirugias()
    End Sub

    ' Cargar las cirugías desde la base de datos al ComboBox
    Private Sub LoadCirugias()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT idTipoCirugia, nombre, costo FROM TipoCirugia"
                Dim cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ' Agregar cada cirugía al ComboBox (mostrando nombre y costo)
                    ComboBoxCirugia.Items.Add(New With {
                        .id = reader("idTipoCirugia"),
                        .nombre = reader("nombre"),
                        .costo = reader("costo")
                    })
                End While
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las cirugías: " & ex.Message)
        End Try
    End Sub

    ' Método para agregar una cirugía seleccionada y calcular el costo total
    Private Sub ComboBoxCirugias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCirugia.SelectedIndexChanged
        Dim selectedCirugia = ComboBoxCirugia.SelectedItem

        ' Limitar a 3 cirugías
        If selectedCirugias.Count >= 3 Then
            MessageBox.Show("Solo puedes seleccionar hasta 3 cirugías.")
            Return
        End If

        ' Agregar el ID de la cirugía seleccionada a la lista
        selectedCirugias.Add(selectedCirugia.id)
        ' Sumar el costo de la cirugía seleccionada al total
        totalCost += selectedCirugia.costo
        ' Actualizar el TextBox de costo total
        TextBoxCostoTotal.Text = totalCost.ToString("C")
    End Sub

    ' Método para guardar los datos de la cirugía en la base de datos
    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                For Each idCirugia As Integer In selectedCirugias
                    Dim query As String = "INSERT INTO Cirugia (idMascota, idTipoCirugia, fecha, observaciones, costo) VALUES (@idMascota, @idTipoCirugia, @fecha, @observaciones, @costo)"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idMascota", 1) ' Cambiar a la mascota correcta según la lógica
                    cmd.Parameters.AddWithValue("@idTipoCirugia", idCirugia)
                    cmd.Parameters.AddWithValue("@fecha", DateTimePickerFecha.Value)
                    cmd.Parameters.AddWithValue("@observaciones", TextBoxObservaciones.Text)
                    cmd.Parameters.AddWithValue("@costo", totalCost)
                    cmd.ExecuteNonQuery()
                Next

                MessageBox.Show("Datos guardados exitosamente.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message)
        End Try
    End Sub
End Class
