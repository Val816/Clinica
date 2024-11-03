Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Eutanasia
    Private Const CostoEutanasia As Decimal = 250D ' Costo fijo de eutanasia
    Private idMascota As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(idMascotaSeleccionada As Integer)
        InitializeComponent()
        idMascota = idMascotaSeleccionada
        MessageBox.Show("ID de mascota seleccionado: " & idMascota.ToString())
    End Sub

    Private Sub Eutanasia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        idMascota = ObtenerUltimoIdMascota()

        If idMascota <= 0 OrElse Not ExisteMascota(idMascota) Then

            Me.Close()
            Return
        End If

        LlenarComboBoxMotivo()
        LlenarComboBoxServicios()
        TextBoxCosto.Text = CostoEutanasia.ToString("C2")
    End Sub

    Private Function ObtenerUltimoIdMascota() As Integer
        Dim idMascota As Integer = 0
        Dim query As String = "SELECT MAX(idMascota) FROM Mascota"

        Using connection As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Try
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        idMascota = Convert.ToInt32(result)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener el ID de la mascota: " & ex.Message)
            End Try
        End Using
        Return idMascota
    End Function
    Private Function ExisteMascota(id As Integer) As Boolean
        Dim existe As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM Mascota WHERE idMascota = @idMascota"

        Using connection As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Try
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@idMascota", id)
                    existe = Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al verificar la existencia de la mascota: " & ex.Message)
            End Try
        End Using

        Return existe
    End Function

    Private Sub LlenarComboBoxMotivo()
        ComboBoxMotivo.Items.Clear()

        Dim query As String = "SELECT idMotivo, descripcion FROM motivoeutanasia"
        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Dim cmd As New MySqlCommand(query, conn)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim item As New ComboBoxItem With {
                    .Value = reader("idMotivo"),
                    .Text = reader("descripcion").ToString()
                }
                ComboBoxMotivo.Items.Add(item)
            End While
        End Using
    End Sub

    Private Sub ComboBoxMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMotivo.SelectedIndexChanged
        TextBoxCosto.Text = CostoEutanasia.ToString("C2")
    End Sub

    Private Sub GuardarEutanasia()
        If idMascota <= 0 Then
            MessageBox.Show("ID de mascota no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not ExisteMascota(idMascota) Then
            MessageBox.Show("La mascota especificada no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If ComboBoxMotivo.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor seleccione un motivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim idMotivo As Integer = CType(ComboBoxMotivo.SelectedItem, ComboBoxItem).Value
        Dim fecha As DateTime = DateTimePickerFecha.Value
        Dim observaciones As String = TextBoxObservaciones.Text
        Dim costoFinal As Decimal = CostoEutanasia

        Dim idEutanasia As Integer
        Using connection As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            connection.Open()
            Dim queryID As String = "SELECT COALESCE(MAX(idEutanasia), 0) + 1 FROM eutanasia"
            Using commandID As New MySqlCommand(queryID, connection)
                idEutanasia = Convert.ToInt32(commandID.ExecuteScalar())
            End Using
        End Using

        Dim queryInsertar As String = "INSERT INTO eutanasia (idEutanasia, idMascota, idMotivo, fecha, observaciones, costoFinal) " &
                                        "VALUES (@idEutanasia, @idMascota, @idMotivo, @fecha, @observaciones, @costoFinal)"

        Using connection As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using insertCommand As New MySqlCommand(queryInsertar, connection)
                insertCommand.Parameters.AddWithValue("@idEutanasia", idEutanasia)
                insertCommand.Parameters.AddWithValue("@idMascota", idMascota)
                insertCommand.Parameters.AddWithValue("@idMotivo", idMotivo)
                insertCommand.Parameters.AddWithValue("@fecha", fecha)
                insertCommand.Parameters.AddWithValue("@observaciones", observaciones)
                insertCommand.Parameters.AddWithValue("@costoFinal", costoFinal)

                Try
                    connection.Open()
                    insertCommand.ExecuteNonQuery()
                    MessageBox.Show("Registro de eutanasia guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Limpiar los campos después de guardar
                    ComboBoxMotivo.SelectedItem = Nothing
                    TextBoxObservaciones.Clear()
                    DateTimePickerFecha.Value = DateTime.Now
                Catch ex As Exception
                    MessageBox.Show("Error al guardar la eutanasia: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarEutanasia()
    End Sub

    ' Clase auxiliar para manejar los elementos del ComboBox
    Private Class ComboBoxItem
        Public Property Value As Integer
        Public Property Text As String
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class
    Private Function ObtenerNombreMascota(idMascota As Integer, connection As MySqlConnection) As String
        Dim nombreMascota As String = ""
        Try
            Dim query As String = "SELECT nomMasc FROM Mascota WHERE idMascota = @idMascota"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    nombreMascota = result.ToString()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el nombre de la mascota: " & ex.Message)
        End Try
        Return nombreMascota
    End Function

    Private Sub ButtonGenerarPDF_Click(sender As Object, e As EventArgs) Handles BtnGenerarPDF.Click
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "PDF Files|*.pdf"
        dialog.Title = "Guardar PDF"


        Dim fechaActual As String = DateTime.Now.ToString("yyyyMMdd")
        dialog.FileName = $"Eutanasia_{fechaActual}.pdf"

        If dialog.ShowDialog() = DialogResult.OK Then
            Dim doc As New Document()
            Try
                PdfWriter.GetInstance(doc, New FileStream(dialog.FileName, FileMode.Create))
                doc.Open()

                Dim nombreMascota As String = ""
                Dim motivo As String = ""

                Using connection As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
                    connection.Open()

                    nombreMascota = ObtenerNombreMascota(idMascota, connection)


                    If ComboBoxMotivo.SelectedItem IsNot Nothing Then
                        motivo = ComboBoxMotivo.SelectedItem.ToString()
                    Else
                        motivo = "No se seleccionó un motivo"
                    End If
                End Using
                If String.IsNullOrEmpty(nombreMascota) Then
                    MessageBox.Show("No se pudo obtener el nombre de la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                If String.IsNullOrEmpty(motivo) Then
                    MessageBox.Show("No se pudo obtener el motivo de eutanasia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                doc.Add(New Paragraph("Registro de Eutanasia"))
                doc.Add(New Paragraph($"Nombre de la mascota: {nombreMascota}"))
                doc.Add(New Paragraph($"Motivo: {motivo}")) ' Asegúrate de que el motivo esté correctamente asignado
                doc.Add(New Paragraph($"Fecha: {DateTimePickerFecha.Value.ToShortDateString()}"))
                doc.Add(New Paragraph($"Observaciones: {TextBoxObservaciones.Text}"))
                doc.Add(New Paragraph($"Costo: {TextBoxCosto.Text}"))

                doc.Add(New Paragraph("Firma del tutor: ________________________"))

                MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al generar el PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                doc.Close()
            End Try
        End If
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
        Me.Hide()
    End Sub


End Class
