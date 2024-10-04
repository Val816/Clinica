Public Class Menu_Principal
    Private Sub btnRegistro_de_Cita_Click(sender As Object, e As EventArgs) Handles btnRegistroCita.Click
		Dim registroCitaForm As New Registro_de_Cita()
		Me.Hide()
		registroCitaForm.Show()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
		Dim consultaCitaForm As New Consulta_de_Cita()
		Me.Hide()
		consultaCitaForm.Show()
    End Sub

	Private Sub btnMascota_Click(sender As Object, e As EventArgs) Handles btnMascota.Click
		Dim registroMascotaForm As New Registro_de_Mascota()
		Me.Hide()
		registroMascotaForm.Show()
	End Sub

	Private Sub btnCerrarSistema_Click(sender As Object, e As EventArgs) Handles btnCerrarSistema.Click
		Application.Exit() ' Cierra la aplicación completamente
	End Sub


End Class