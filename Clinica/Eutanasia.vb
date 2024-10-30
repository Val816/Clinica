﻿Imports MySql.Data.MySqlClient
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
    End Sub

    Private Sub FormEutanasia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBoxMotivo()
        LlenarComboBoxServicios()
        TextBoxCosto.Text = CostoEutanasia.ToString("C2")
    End Sub

    Private Function ExisteMascota(idMascota As Integer) As Boolean
        Dim existe As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM mascota WHERE idMascota = @idMascota"

        Using connection As New MySqlConnection("tu_conexion")
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@idMascota", idMascota)
                connection.Open()
                existe = Convert.ToInt32(command.ExecuteScalar()) > 0
            End Using
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

    ' Al seleccionar un motivo, el costo se muestra en el TextBoxCosto
    Private Sub ComboBoxMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMotivo.SelectedIndexChanged
        TextBoxCosto.Text = CostoEutanasia.ToString("C2") ' Actualizar el TextBox con el costo fijo
    End Sub
    Private Sub GuardarEutanasia()
        ' Verifica si el idMascota existe en la tabla mascota
        If Not ExisteMascota(idMascota) Then
            MessageBox.Show("La mascota con el ID especificado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Inserta el registro en la tabla eutanasia
        Dim query As String = "INSERT INTO eutanasia (idMascota, costo) VALUES (@idMascota, @costo)"

        Using connection As New MySqlConnection("tu_conexion")
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@idMascota", idMascota)
                command.Parameters.AddWithValue("@costo", CostoEutanasia)
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Registro de eutanasia guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ComboBoxMotivo.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un motivo de eutanasia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim observaciones As String = TextBoxObservaciones.Text
        If String.IsNullOrWhiteSpace(observaciones) Then
            MessageBox.Show("Por favor, ingrese observaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Obtener los valores de los campos
        Dim idMotivo As Integer = CType(ComboBoxMotivo.SelectedItem, ComboBoxItem).Value
        Dim fecha As DateTime = DateTimePickerFecha.Value

        ' Puedes establecer el costo final aquí según sea necesario
        Dim costoFinal As Decimal = CostoEutanasia ' O calcularlo de alguna manera

        ' Insertar los datos en la tabla eutanasia
        Dim query As String = "INSERT INTO eutanasia (idMascota, idMotivo, fecha, observaciones, costoFinal) VALUES (@idMascota, @idMotivo, @fecha, @observaciones, @costoFinal)"

        Try
            Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idMascota", idMascota) ' Asignar el idMascota asociado
                cmd.Parameters.AddWithValue("@idMotivo", idMotivo)
                cmd.Parameters.AddWithValue("@fecha", fecha)
                cmd.Parameters.AddWithValue("@observaciones", observaciones)
                cmd.Parameters.AddWithValue("@costoFinal", costoFinal)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Registro de eutanasia guardado correctamente para la mascota.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar los campos después de guardar
            ComboBoxMotivo.SelectedItem = Nothing
            TextBoxObservaciones.Clear()
            DateTimePickerFecha.Value = DateTime.Now ' Resetear a la fecha actual
        Catch ex As MySqlException
            MessageBox.Show("Error al guardar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Clase auxiliar para manejar los elementos del ComboBox
    Private Class ComboBoxItem
        Public Property Value As Integer
        Public Property Text As String
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    ' Generar PDF (placeholder, solo para mostrar cómo sería el evento)
    Private Sub ButtonGenerarPDF_Click(sender As Object, e As EventArgs) Handles BtnGenerarPDF.Click
        MessageBox.Show("Función de generación de PDF en desarrollo.")
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Me.Close()
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
    Private Sub ComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs)

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

            'Case 4
            '    Dim formDesparacitacion As New Desparacitación()
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
            'Case 8
            '    Dim formEutanasia As New Eutanasia()
            '    formEutanasia.Show()
            '    Me.Hide()

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

        Me.Close()
    End Sub
    Private Sub BtnGenerarPDF_Click(sender As Object, e As EventArgs) Handles BtnGenerarPDF.Click
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
            saveFileDialog.FileName = "Eutanasia_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Crear el documento PDF
                Dim doc As New Document(PageSize.A4, 40, 40, 40, 20)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName, FileMode.Create))

                ' Abrir el documento para agregar contenido
                doc.Open()

                Dim bfTitulo As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
                Dim fuenteTitulo As New iTextSharp.text.Font(bfTitulo, 16, iTextSharp.text.Font.BOLD)

                Dim bfTexto As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
                Dim fuenteTexto As New iTextSharp.text.Font(bfTexto, 12, iTextSharp.text.Font.NORMAL)

                ' Título del PDF
                doc.Add(New Paragraph("Autorización de Eutanasia", fuenteTitulo))
                doc.Add(New Paragraph(Environment.NewLine))

                ' Agregar datos del cliente y la mascota
                Dim datosClienteMascota As String = ObtenerDatosClienteMascota(idMascota)
                doc.Add(New Paragraph("Datos del Cliente y Mascota", fuenteTitulo))
                doc.Add(New Paragraph(datosClienteMascota, fuenteTexto))
                doc.Add(New Paragraph(Environment.NewLine))

                ' Agregar detalles del procedimiento de eutanasia
                Dim datosEutanasia As String = ObtenerDatosEutanasia(idMascota)
                doc.Add(New Paragraph("Detalles del Procedimiento de Eutanasia", fuenteTitulo))
                doc.Add(New Paragraph(datosEutanasia, fuenteTexto))
                doc.Add(New Paragraph(Environment.NewLine))

                ' Texto de autorización
                Dim textoAutorizacion As String = "El cliente autoriza el procedimiento de eutanasia para su mascota " &
                                              "con pleno conocimiento de los detalles proporcionados y el motivo del procedimiento."
                doc.Add(New Paragraph(textoAutorizacion, fuenteTexto))
                doc.Add(New Paragraph(Environment.NewLine))

                ' Espacio para la firma
                doc.Add(New Paragraph("Firma del Cliente: _______________________", fuenteTexto))
                doc.Add(New Paragraph(Environment.NewLine))
                doc.Add(New Paragraph("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy"), fuenteTexto))

                ' Cerrar el documento PDF
                doc.Close()
                writer.Close()

                MessageBox.Show("PDF generado correctamente.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message)
        End Try
    End Sub


    Private Function ObtenerDatosClienteMascota(idMascota As Integer) As String
        Dim resultado As String = ""
        Dim query As String = "SELECT nomCliente, celular, nomMasc, idEspecie, idRaza FROM Mascota WHERE idMascota = @idMascota"

        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    resultado = "Cliente: " & reader("nomCliente") & Environment.NewLine &
                                "Teléfono: " & reader("celular") & Environment.NewLine &
                                "Mascota: " & reader("nomMasc") & Environment.NewLine &
                                "Especie: " & ObtenerNombreEspecie(reader("idEspecie")) & Environment.NewLine &
                                "Raza: " & ObtenerNombreRaza(reader("idRaza"))
                End If
            End Using
        End Using
        Return resultado
    End Function


    Private Function ObtenerDatosEutanasia(idMascota As Integer) As String
        Dim resultado As String = ""
        Dim query As String = "SELECT E.fecha, M.descripcion AS motivo, E.observaciones, E.costoFinal " &
                              "FROM Eutanasia E " &
                              "JOIN MotivoEutanasia M ON E.idMotivo = M.idMotivo " &
                              "WHERE E.idMascota = @idMascota"

        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idMascota", idMascota)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    resultado = "Fecha: " & Convert.ToDateTime(reader("fecha")).ToString("dd/MM/yyyy") & Environment.NewLine &
                                "Motivo: " & reader("motivo").ToString() & Environment.NewLine &
                                "Observaciones: " & reader("observaciones").ToString() & Environment.NewLine &
                                "Costo Final: " & Convert.ToDecimal(reader("costoFinal")).ToString("C2")
                End If
            End Using
        End Using
        Return resultado
    End Function


    ' Métodos adicionales para obtener el nombre de la especie y la raza desde la base de datos
    Private Function ObtenerNombreEspecie(idEspecie As Integer) As String
        Dim nombreEspecie As String = ""
        Dim query As String = "SELECT nombre FROM especie WHERE idEspecie = @idEspecie"

        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@idEspecie", idEspecie)

            Try
                conn.Open()
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    nombreEspecie = result.ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al obtener el nombre de la especie: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return nombreEspecie
    End Function


    Private Function ObtenerNombreRaza(idRaza As Integer) As String
        Dim nombreRaza As String = ""
        Dim query As String = "SELECT nombre FROM raza WHERE idRaza = @idRaza"

        Using conn As New MySqlConnection("Server=localhost;Database=veterinaria;User Id=root;Password=root;")
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@idRaza", idRaza)

            Try
                conn.Open()
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    nombreRaza = result.ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al obtener el nombre de la raza: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return nombreRaza
    End Function

End Class

