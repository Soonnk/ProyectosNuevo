Public Class mdiPrincipal
    Public activo As String
    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHabitacion.ItemClick
        Try
            Dim frmHabitacion As New pConsultarHabitaciones
            frmHabitacion.MdiParent = Me
            frmHabitacion.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClientes.ItemClick
        Try
            Dim frmCliente As New pConsultarClientes
            frmCliente.MdiParent = Me
            frmCliente.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReservacion.ItemClick
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

                Case "clientes"
                    Dim frmNuevo As New pAgregarClientes
                    frmNuevo.modo = pAgregarClientes.tipo.Nuevo
                    frmNuevo.ShowDialog()

                Case "reservaciones"
                    Dim frmNuevo As New pAgregarReservaciones
                    frmNuevo.modo = pAgregarReservaciones.tipo.Nuevo
                    frmNuevo.ShowDialog()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificar.ItemClick
        Try
            Dim frmActivo As Form = Me.ActiveMdiChild
            Select Case activo
                Case "habitaciones"
                    Dim frmEditar As New pConsultarHabitaciones
                    frmEditar.modo = pConsultarHabitaciones.tipo.Editar
                    frmEditar = frmActivo
                    frmEditar.consultarHabitacion()
                Case "clientes"
                    Dim frmEditar As New pConsultarClientes
                    frmEditar.modo = pConsultarClientes.tipo.Editar
                    frmEditar = frmActivo
                    frmEditar.consultarCliente()
                Case "Ereservaciones"
                    Dim frmEditar As New pConsultarReservaciones
                    frmEditar.modo = pConsultarReservaciones.tipo.Editar
                    frmEditar = frmActivo
                    frmEditar.consultarReservacion()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminar.ItemClick
        Try

            Dim frmActivo As Form = Me.ActiveMdiChild
            Select Case activo
                Case "habitaciones"
                    Dim frmEliminar As New pConsultarHabitaciones
                    frmEliminar = frmActivo
                    frmEliminar.EliminarHabitacion()
                Case "clientes"
                    Dim frmEliminar As New pConsultarClientes
                    frmEliminar = frmActivo
                    frmEliminar.EliminarCliente()
                Case "Ereservaciones"
                    Dim frmEliminar As New pConsultarReservaciones
                    frmEliminar = frmActivo
                    frmEliminar.EliminarReservacion()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class