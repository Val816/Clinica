'Imports MySql.Data.MySqlClient
'Imports iTextSharp.text
'Imports iTextSharp.text.pdf
'Imports System.IO

'Public Class Eutanasia

'    Private connectionString As String = "server=localhost;user id=root;password=root;database=veterinaria"
'    Private idMascota As Integer

'    ' Cargar el formulario y llenar el ComboBox con los motivos
'    Private Sub EutanasiaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        LlenarComboBoxMotivos()
'        LlenarComboBoxServicios()
'        idMascota = ObtenIdMascotaAnterior()
'    End Sub

'        ' Método para llenar el ComboBox con los motivos desde la tabla MotivoEutanasia
'        Private Sub LlenarComboBoxMotivos()
'            ComboBoxMotivos.Items.Clear()
'            Dim query As String = "SELECT idMotivo, descripcion FROM MotivoEutanasia"
'            Using conn As New MySqlConnection(connectionString)
'                Using cmd As New MySqlCommand(query, conn)
'                    conn.Open()
'                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
'                    While reader.Read()
'                        ComboBoxMotivos.Items.Add(New With {.Value = reader("idMotivo"), .Text = reader("descripcion")})
'                    End While
'                End Using
'            End Using
'            ComboBoxMotivos.DisplayMember = "Text"
'            ComboBoxMotivos.ValueMember = "Value"
'        End Sub

'    Private Function ObtenIdMascotaAnterior() As Integer

'        Return 1
'    End Function


'    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

'        If ComboBoxMotivos.SelectedItem Is Nothing Or
'           String.IsNullOrEmpty(TextBoxObservaciones.Text) Or
'           String.IsNullOrEmpty(TextBoxCostoFinal.Text) Then
'                MessageBox.Show("Por favor, completa todos los campos.")
'                Return
'            End If

'            Dim motivoSeleccionado = CType(ComboBoxMotivos.SelectedItem, Object)


'        Dim query As String = "INSERT INTO Eutanasia (idMascota, idMotivo, fecha, observaciones, costoFinal) " &
'                              "VALUES (@idMascota, @idMotivo, @fecha, @observaciones, @costoFinal)"
'            Using conn As New MySqlConnection(connectionString)
'                Using cmd As New MySqlCommand(query, conn)
'                    cmd.Parameters.AddWithValue("@idMascota", idMascota)
'                    cmd.Parameters.AddWithValue("@idMotivo", motivoSeleccionado.Value)
'                    cmd.Parameters.AddWithValue("@fecha", DateTimePickerFecha.Value)
'                    cmd.Parameters.AddWithValue("@observaciones", TextBoxObservaciones.Text)
'                    cmd.Parameters.AddWithValue("@costoFinal", Decimal.Parse(TextBoxCostoFinal.Text))


'                Try
'                        conn.Open()
'                        cmd.ExecuteNonQuery()
'                        MessageBox.Show("Eutanasia registrada correctamente.")
'                    Catch ex As Exception
'                        MessageBox.Show("Error al registrar la eutanasia: " & ex.Message)
'                    End Try
'                End Using
'            End Using
'        End Sub


'    Private Sub LlenarComboBoxServicios()
'        ComboBoxServicios.Items.Clear()
'        Dim query As String = "SELECT DISTINCT idServicio, nombre FROM Servicio"
'        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
'            Using cmd As New MySqlCommand(query, conn)
'                conn.Open()
'                Dim reader As MySqlDataReader = cmd.ExecuteReader()
'                While reader.Read()
'                    ComboBoxServicios.Items.Add(New With {.Value = reader("idServicio"), .Text = reader("nombre")})
'                End While
'            End Using
'        End Using
'        ComboBoxServicios.DisplayMember = "Text"
'        ComboBoxServicios.ValueMember = "Value"
'    End Sub
'    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs)

'        Dim servicioSeleccionado As Object = ComboBoxServicios.SelectedItem
'        If servicioSeleccionado Is Nothing Then
'            MessageBox.Show("Por favor, selecciona un servicio.")
'            Return
'        End If

'        Dim idServicio As Integer = servicioSeleccionado.Value

'        Select Case idServicio
'            Case 1 ' 
'                Dim formCirugia As New Cirugía()
'                formCirugia.Show()
'                Me.Hide()

'            Case 2 ' 
'                Dim consultamedica As New Consulta_Médica()
'                consultamedica.Show()
'                Me.Hide()

'            'Case 4
'            '    Dim formDesparacitacion As New Desparacitación()
'            '    formDesparacitacion.Show()
'            '    Me.Hide()

'            Case 5
'                Dim formEsterilizacion As New Castración_y_Esterilización()
'                formEsterilizacion.Show()
'                Me.Hide()

'            Case 6
'                Dim formPension As New Pensión()
'                formPension.Show()
'                Me.Hide()

'            Case 7
'                Dim formGrooming As New Estética()
'                formGrooming.Show()
'                Me.Hide()
'            Case 8
'                Dim formEutanasia As New Eutanasia()
'                formEutanasia.Show()
'                Me.Hide()

'            Case 9
'                Dim formGrooming As New Vacunacion()
'                formGrooming.Show()
'                Me.Hide()

'            Case 10
'                Dim formHospitalizacion As New Hospitalización()
'                formHospitalizacion.Show()
'                Me.Hide()
'            Case 11
'                Dim formProfilaxis As New Proaxis_Dental()
'                formProfilaxis.Show()
'                Me.Hide()
'            Case 12
'                Dim formmRecibo As New Recibo()
'                formmRecibo.Show()
'                Me.Hide()
'            Case Else
'                MessageBox.Show("Servicio no reconocido. Por favor, selecciona un servicio válido.")

'        End Select
'    End Sub
'    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click

'        Dim menuPrincipal As New Menu_Principal()
'        menuPrincipal.Show()

'        Me.Close()
'    End Sub
'    Private Sub BtnGenerarPDF_Click(sender As Object, e As EventArgs) Handles BtnGenerarPDF.Click
'        Try

'            Dim saveFileDialog As New SaveFileDialog()
'            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
'            saveFileDialog.FileName = "Eutanasia_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"

'            If saveFileDialog.ShowDialog() = DialogResult.OK Then

'                Dim doc As New Document(PageSize.A4, 40, 40, 40, 20)
'                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName, FileMode.Create))


'                doc.Open()


'                Dim fuenteTitulo As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD)
'                Dim fuenteTexto As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL)

'                ' Título del PDF
'                doc.Add(New Paragraph("Autorización de Eutanasia", fuenteTitulo))
'                doc.Add(New Paragraph(Environment.NewLine))


'                Dim datosClienteMascota As String = ObtenerDatosClienteMascota(idMascota)
'                doc.Add(New Paragraph(datosClienteMascota, fuenteTexto))
'                doc.Add(New Paragraph(Environment.NewLine))

'                ' Datos de la eutanasia
'                Dim datosEutanasia As String = ObtenerDatosEutanasia(idMascota)
'                doc.Add(New Paragraph("Detalles del Procedimiento de Eutanasia", fuenteTitulo))
'                doc.Add(New Paragraph(datosEutanasia, fuenteTexto))
'                doc.Add(New Paragraph(Environment.NewLine))

'                ' Texto de autorización
'                Dim textoAutorizacion As String = "El cliente autoriza el procedimiento de eutanasia para su mascota " &
'                                                  "con pleno conocimiento de los detalles proporcionados y el motivo del procedimiento."
'                doc.Add(New Paragraph(textoAutorizacion, fuenteTexto))
'                doc.Add(New Paragraph(Environment.NewLine))

'                ' Espacio para la firma
'                doc.Add(New Paragraph("Firma del Cliente: _______________________", fuenteTexto))
'                doc.Add(New Paragraph(Environment.NewLine))
'                doc.Add(New Paragraph("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy"), fuenteTexto))

'                ' Cerrar el documento PDF
'                doc.Close()
'                writer.Close()

'                MessageBox.Show("PDF generado correctamente.")
'            End If
'        Catch ex As Exception
'            MessageBox.Show("Error al generar el PDF: " & ex.Message)
'        End Try
'    End Sub

'    ' Método para obtener los datos del cliente y la mascota desde la base de datos
'    Private Function ObtenerDatosClienteMascota(idMascota As Integer) As String
'        Dim resultado As String = ""
'        Dim query As String = "SELECT nomCliente, celular, nomMasc, idEspecie, idRaza FROM Mascota WHERE idMascota = @idMascota"

'        Using conn As New MySqlConnection(connectionString)
'            Using cmd As New MySqlCommand(query, conn)
'                cmd.Parameters.AddWithValue("@idMascota", idMascota)
'                conn.Open()
'                Dim reader As MySqlDataReader = cmd.ExecuteReader()

'                If reader.Read() Then
'                    resultado = "Cliente: " & reader("nomCliente") & Environment.NewLine &
'                                "Teléfono: " & reader("celular") & Environment.NewLine &
'                                "Mascota: " & reader("nomMasc") & Environment.NewLine &
'                                "Especie: " & ObtenerNombreEspecie(reader("idEspecie")) & Environment.NewLine &
'                                "Raza: " & ObtenerNombreRaza(reader("idRaza"))
'                End If
'            End Using
'        End Using
'        Return resultado
'    End Function

'    ' Método para obtener los datos de la eutanasia
'    Private Function ObtenerDatosEutanasia(idMascota As Integer) As String
'        Dim resultado As String = ""
'        Dim query As String = "SELECT E.fecha, M.descripcion AS motivo, E.observaciones, E.costoFinal " &
'                              "FROM Eutanasia E " &
'                              "JOIN MotivoEutanasia M ON E.idMotivo = M.idMotivo " &
'                              "WHERE E.idMascota = @idMascota"

'        Using conn As New MySqlConnection(connectionString)
'            Using cmd As New MySqlCommand(query, conn)
'                cmd.Parameters.AddWithValue("@idMascota", idMascota)
'                conn.Open()
'                Dim reader As MySqlDataReader = cmd.ExecuteReader()

'                If reader.Read() Then
'                    resultado = "Fecha: " & reader("fecha").ToString() & Environment.NewLine &
'                                "Motivo: " & reader("motivo") & Environment.NewLine &
'                                "Observaciones: " & reader("observaciones") & Environment.NewLine &
'                                "Costo Final: $" & reader("costoFinal").ToString()
'                End If
'            End Using
'        End Using
'        Return resultado
'    End Function

'    ' Métodos adicionales para obtener el nombre de la especie y la raza desde la base de datos
'    Private Function ObtenerNombreEspecie(idEspecie As Integer) As String
'        ' Aquí iría la consulta SQL para obtener el nombre de la especie
'        Return "Perro" ' Ejemplo temporal
'    End Function

'    Private Function ObtenerNombreRaza(idRaza As Integer) As String
'        ' Aquí iría la consulta SQL para obtener el nombre de la raza
'        Return "Labrador" ' Ejemplo temporal
'    End Function
'End Class

