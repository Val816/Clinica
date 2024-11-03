
'Public Class Estetica
'    ' Variables para el costo total
'    Private costoTotal As Decimal = 0

'    ' Evento de carga del formulario
'    Private Sub FormEstetica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Llenar ComboBox con servicios de estética
'        ComboBoxServicios.Items.Add("Baño")
'        ComboBoxServicios.Items.Add("Corte de Pelo")
'        ComboBoxServicios.Items.Add("Cepillado")
'        ComboBoxServicios.Items.Add("Corte de Uñas")
'        ComboBoxServicios.Items.Add("Perfumado")
'        ' Agregar más servicios si es necesario
'    End Sub

'    ' Evento para calcular el costo total
'    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
'        costoTotal = 0

'        ' Calcular costos según los CheckBoxes seleccionados
'        If CheckBoxBano.Checked Then
'            costoTotal += CalcularCosto("Baño")
'        End If
'        If CheckBoxCortePelo.Checked Then
'            costoTotal += CalcularCosto("Corte de Pelo")
'        End If
'        If CheckBoxCepillado.Checked Then
'            costoTotal += CalcularCosto("Cepillado")
'        End If
'        If CheckBoxCorteUnas.Checked Then
'            costoTotal += CalcularCosto("Corte de Uñas")
'        End If
'        If CheckBoxPerfume.Checked Then
'            costoTotal += CalcularCosto("Perfumado")
'        End If

'        ' Mostrar el costo total en el TextBox
'        TextBoxPrecioTotal.Text = costoTotal.ToString("C2") ' Formatear como moneda
'    End Sub

'    ' Función para calcular el costo basado en la talla
'    Private Function CalcularCosto(nombreServicio As String) As Decimal
'        Dim talla As String = ComboBoxTalla.SelectedItem.ToString() ' Obtener la talla seleccionada
'        Dim costo As Decimal = 0

'        ' Asignar costos según la talla y el servicio
'        Select Case nombreServicio
'            Case "Baño"
'                If talla = "Chica" Then
'                    costo = 400
'                ElseIf talla = "Mediana" Then
'                    costo = 650
'                ElseIf talla = "Grande" Then
'                    costo = 900
'                End If
'            Case "Corte de Pelo"
'                If talla = "Chica" Then
'                    costo = 200
'                ElseIf talla = "Mediana" Then
'                    costo = 350
'                ElseIf talla = "Grande" Then
'                    costo = 700
'                End If
'                ' Agregar más servicios según sea necesario
'        End Select

'        Return costo
'    End Function
'End Class
