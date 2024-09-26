Public Class Menu_Principal
    Private Sub btnRegistroCita_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim registroCitaForm As New Registro_de_Cita()
        registroCitaForm.Show()
    End Sub

    Private Sub btnRegistroCita_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim registroCitaForm As New FormRegistroCita()
        registroCitaForm.Show()
    End Sub

    Private Sub btnRegistroCita_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim registroCitaForm As New FormRegistroCita()
        registroCitaForm.Show()
    End Sub

    Private Sub btnRegistroCita_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim registroCitaForm As New FormRegistroCita()
        registroCitaForm.Show()
    End Sub
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close() ' Cierra el formulario actual
        FormInicioSesion.Show() ' Vuelve a mostrar el formulario de inicio de sesión
    End Sub

End Class