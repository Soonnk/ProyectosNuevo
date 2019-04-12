Public Class mdiPrincipal
    Public activo As String
    Private ReadOnly Property CurFormCliente() As pConsultarClientes
        Get
            If Me.ActiveMdiChild Is Nothing Then
                Return Nothing
            End If
            Return TryCast(Me.ActiveMdiChild, pConsultarClientes)
        End Get
    End Property
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
                    'frmEditar.modo = pAgregarHabitaciones.tipo.Editar
                    'frmEditar = frmActivo
                    'frmEditar.consultarHabitacion
                    frmNuevo.modo = pAgregarHabitaciones.tipo.Nuevo
                    frmNuevo.ShowDialog()
                Case "Editar Habitacion"
                    Dim frmEditar As New pConsultarHabitaciones
                    frmEditar.modo = pConsultarHabitaciones.tipo.Editar
                    frmEditar = frmActivo
                    frmEditar.consultarHabitacion()

            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class