Public Class mdiPrincipal
    'Habitacion
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        pAgregarHabitaciones.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        pConsultarHabitaciones.ShowDialog()
    End Sub


    'Cliente
    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        pAgregarClientes.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem1.Click
        pConsultarClientes.ShowDialog()
    End Sub


    'Reservacion
    Private Sub AgregarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem2.Click
        pAgregarReservaciones.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem2.Click
        pConsultarReservaciones.ShowDialog()
    End Sub
End Class