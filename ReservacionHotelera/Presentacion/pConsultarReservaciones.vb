Public Class pConsultarReservaciones
    Private Sub pConsultarReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Public Sub Cargar()
        Try
            Dim nReservacion = New Negocios.Reservaciones
            Dim tabla = nReservacion.Consultar()
            GridControl1.DataSource = tabla
        Catch ex As Exception

        End Try
    End Sub
End Class