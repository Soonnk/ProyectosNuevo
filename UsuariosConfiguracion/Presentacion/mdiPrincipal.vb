﻿Public Class mdiPrincipal
    Public activo As String


    Private Sub mdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEmpresas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmpresas.ItemClick
        Try
            Dim frmEmpresas As New ConsultarEmpresa
            frmEmpresas.MdiParent = Me
            frmEmpresas.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSistemas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSistemas.ItemClick

    End Sub

    Private Sub btnMagnusERP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMagnusERP.ItemClick

    End Sub

    Private Sub btnSIMAC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSIMAC.ItemClick

    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMagnusCONTA.ItemClick

    End Sub

    Private Sub btnMagnusGo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMagnusGo.ItemClick

    End Sub

    Private Sub btnUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUsuarios.ItemClick

    End Sub

    Private Sub btnActividades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnActividades.ItemClick

    End Sub

    Private Sub btnNuevoSuperior_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevoSuperior.ItemClick
        Try
            Dim frmActivo As Form = Me.ActiveMdiChild
            Select Case activo
                Case "empresas"
                    Dim frmNuevo As New AgregarEmpresa
                    frmNuevo.modo = AgregarEmpresa.tipo.Nuevo
                    frmNuevo.ShowDialog()

                Case "sistemas"
                    Dim frmNuevo As New AgregarSistema
                    frmNuevo.modo = AgregarSistema.tipo.Nuevo
                    frmNuevo.ShowDialog()

            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEditarSuperior_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditarSuperior.ItemClick
        Try
            Dim frmActivo As Form = Me.ActiveMdiChild
            Select Case activo
                Case "habitaciones"
                    Dim frmEditar As New ConsultarEmpresa
                    frmEditar.modo = ConsultarEmpresa.tipo.Editar
                    frmEditar = frmActivo
                    frmEditar.ConsultarEmpresa()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardarSuperior_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardarSuperior.ItemClick

    End Sub

    Private Sub btnCancelarSuperior_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelarSuperior.ItemClick

    End Sub
End Class