Public Class mdiPrincipal
    Public activo As String
    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Try
            Dim frmHabitacion As New pConsultarHabitaciones
            frmHabitacion.MdiParent = Me
            frmHabitacion.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Try
            Dim frmCliente As New pConsultarClientes
            frmCliente.MdiParent = Me
            frmCliente.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Try
            Dim frmReservacion As New pConsultarReservaciones
            frmReservacion.MdiParent = Me
            frmReservacion.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick

        Try
            Dim frmActivo As Form = Me.ActiveMdiChild
            Select Case activo
                Case "habitaciones"
                    Dim frmNuevo As New pAgregarHabitaciones
                    frmNuevo.modo = pAgregarHabitaciones.tipo.Nuevo
                    frmNuevo.ShowDialog()
                Case "Editar Cliente"
                    Dim frmEditar As New pConsultarHabitaciones
                    frmEditar.modo = pConsultarHabitaciones.tipo.Editar
                    frmEditar = frmActivo
                    frmEditar.consultarHabitacion()
                Case "clientes"
                    Dim frmNuevo As New pAgregarClientes
                    frmNuevo.modo = pAgregarClientes.tipo.Nuevo
                    frmNuevo.ShowDialog()
                Case "Editar Cliente"
                    Dim frmEditar As New pConsultarClientes
                    frmEditar.modo = pConsultarClientes.tipo.Editar
                    frmEditar = frmActivo
                    frmEditar.consultarCliente()
                Case "reservaciones"
                    Dim frmNuevo As New pAgregarReservaciones
                    frmNuevo.modo = pAgregarReservaciones.tipo.Nuevo
                    frmNuevo.ShowDialog()
                Case "Editar Reservacion"
                    Dim frmEditar As New pConsultarReservaciones
                    frmEditar.modo = pConsultarReservaciones.tipo.Editar
                    frmEditar = frmActivo
                    frmEditar.consultarReservacion()
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class