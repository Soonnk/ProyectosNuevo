Public Class mdiPrincipal
    Public activo As String

    Private ReadOnly Property Empresa() As ConsultarEmpresa
        Get
            If Me.ActiveMdiChild Is Nothing Then
                Return Nothing
            End If
            Return TryCast(Me.ActiveMdiChild, ConsultarEmpresa)
        End Get
    End Property

    Private ReadOnly Property Sistema() As ConsultarSistemas
        Get
            If Me.ActiveMdiChild Is Nothing Then
                Return Nothing
            End If
            Return TryCast(Me.ActiveMdiChild, ConsultarSistemas)
        End Get
    End Property


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
        Try
            Dim frmSistemas As New ConsultarSistemas
            frmSistemas.MdiParent = Me
            frmSistemas.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnNuevoSuperior_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevoSuperior.ItemClick
        Try
            Dim frmActivo As Form = Me.ActiveMdiChild
            Select Case activo
                Case "empresas"
                    Dim frmNuevo As New AgregarEmpresa
                    frmNuevo.modo = AgregarEmpresa.tipo.Nuevo
                    frmNuevo.Owner = Empresa
                    frmNuevo.ShowDialog()

                Case "sistemas"
                    Dim frmNuevo As New AgregarSistema
                    frmNuevo.modo = AgregarSistema.tipo.Nuevo
                    frmNuevo.Owner = Sistema
                    frmNuevo.ShowDialog()

            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnEditarSuperior_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditarSuperior.ItemClick
        Try
            Dim frmActivo As Form = Me.ActiveMdiChild
            Select Case activo
                Case "empresas"
                    Dim frmEditar As New ConsultarEmpresa
                    frmEditar.modo = ConsultarEmpresa.tipo.Editar
                    frmEditar = frmActivo
                    frmEditar.ConsultarEmpresa()
                Case "sistemas"
                    Dim frmEditar As New ConsultarSistemas
                    frmEditar.modo = ConsultarSistemas.tipo.Editar
                    frmEditar = frmActivo
                    frmEditar.ConsultarSistema()
            End Select
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class