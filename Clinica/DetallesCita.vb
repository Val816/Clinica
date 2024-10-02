Public Class DetallesCita
    Private Sub DetallesCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar los datos de la cita en la interfaz
        lblNombreTutor.Text = "Nombre Tutor: " & nombreTutor
        lblApellidoTutor.Text = "Apellido Tutor: " & apellidoTutor
        lblTelefono.Text = "Teléfono: " & telefono
        lblNombreMascota.Text = "Nombre Mascota: " & nombreMascota
        lblEspecie.Text = "Especie: " & especie
        lblFecha.Text = "Fecha: " & fecha
        lblHora.Text = "Hora: " & hora
    End Sub

    Private nombreTutor As String
    Private apellidoTutor As String
    Private telefono As String
    Private nombreMascota As String
    Private especie As String
    Private fecha As String
    Private hora As String

    ' Constructor para recibir los datos de la cita
    Public Sub New(tutor As String, apellido As String, tel As String, masc As String, esp As String, fe As String, hr As String)
        InitializeComponent()
        nombreTutor = tutor
        apellidoTutor = apellido
        telefono = tel
        nombreMascota = masc
        especie = esp
        fecha = fe
        hora = hr
    End Sub
End Class