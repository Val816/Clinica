Public Class Menu_Principal
    Private Sub btnRegistro_de_Cita_Click(sender As Object, e As EventArgs) Handles btnRegistroCita.Click
        Dim registroCitaForm As New Registro_de_Cita()
        registroCitaForm.Show()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim consultaCitaForm As New Consulta_de_Cita()
        consultaCitaForm.Show()
    End Sub

	Private Sub btnMascota_Click(sender As Object, e As EventArgs) Handles btnMascota.Click
		Dim registroMascotaForm As New Registro_de_Mascota()
		registroMascotaForm.Show()
	End Sub

	'Private Sub btnRegistroCita_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
	'    Dim registroCitaForm As New FormRegistroCita()
	'    registroCitaForm.Show()
	'End Sub

	'Private Sub btnRegistroCita_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
	'    Dim registroCitaForm As New FormRegistroCita()
	'    registroCitaForm.Show()
	'End Sub
	'Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
	'    Me.Close() ' Cierra el formulario actual
	'    FormInicioSesion.Show() ' Vuelve a mostrar el formulario de inicio de sesión
	'End Sub

End Class